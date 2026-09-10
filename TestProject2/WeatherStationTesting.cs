using ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

namespace TestProject2;

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

    public class WeatherTests
    {
        private List<Station> stations;
        private WeatherValidator validator;
        private WeatherProcessor processor;
        private BinaryService binaryService;

        [SetUp]
        public void Setup()
        {
            stations = new List<Station>()
            {
                new Station
                {
                    Code="ST01",
                    Region="Coastal",
                    MinTemp=10,
                    MaxTemp=45
                },

                new Station
                {
                    Code="ST02",
                    Region="Hill",
                    MinTemp=-10,
                    MaxTemp=30
                }
            };

            validator = new WeatherValidator(stations);
            processor = new WeatherProcessor();
            binaryService = new BinaryService();
        }

        [Test]
        public void ValidStation()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST01",
                TempC = 30,
                Humidity = 50
            };

            Assert.DoesNotThrow(() => validator.Validate(record));
        }

        [Test]
        public void UnknownStation()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST99",
                TempC = 20,
                Humidity = 50
            };

            Assert.Throws<UnknownStationException>(
                () => validator.Validate(record));
        }

        [Test]
        public void TemperatureMinBoundary()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST01",
                TempC = 5,
                Humidity = 40
            };

            Assert.Throws<TemperatureOutOfRangeException>(() => validator.Validate(record));
        }

        [Test]
        public void TemperatureMaxBoundary()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST01",
                TempC = 47,
                Humidity = 40
            };

            Assert.Throws<TemperatureOutOfRangeException>(() => validator.Validate(record));
        }


        [Test]
        public void HumidityBelowZero()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST01",
                TempC = 30,
                Humidity = -1
            };

            Assert.Throws<InvalidHumidityException>(
                () => validator.Validate(record));
        }

        [Test]
        public void HumidityAbove100()
        {
            WeatherRecord record = new WeatherRecord
            {
                StationCode = "ST01",
                TempC = 30,
                Humidity = 101
            };

            Assert.Throws<InvalidHumidityException>(
                () => validator.Validate(record));
        }

        [Test]
        public void GenerateSummaryShouldReturnCorrectValues()
        {
            List<WeatherRecord> records = new List<WeatherRecord>()
            {
                new WeatherRecord
                {
                    StationCode="ST01",
                    Date=new DateTime(2026,9,1),
                    TempC=20,
                    Humidity=50
                },

                new WeatherRecord
                {
                    StationCode="ST02",
                    Date=new DateTime(2026,9,1),
                    TempC=30,
                    Humidity=60
                },

                new WeatherRecord
                {
                    StationCode="ST01",
                    Date=new DateTime(2026,9,1),
                    TempC=40,
                    Humidity=70
                },
                
                new WeatherRecord
                {
                    StationCode="ST02",
                    Date=new DateTime(2026,9,1),
                    TempC=20,
                    Humidity=60
                },
            };

            var result = processor.GenerateSummary(records);

            Assert.AreEqual(20, result[1].MinTemp);
            Assert.AreEqual(30, result[1].MaxTemp);
            Assert.AreEqual(25 ,result[1].AverageTemp);
        }

        [Test]
        public void DetectAnomalies()
        {
            List<WeatherRecord> records = new List<WeatherRecord>()
            {
                new WeatherRecord
                {
                    StationCode="ST01",
                    TempC=30,
                    Humidity=50
                },

                new WeatherRecord
                {
                    StationCode="ST01",
                    TempC=70,
                    Humidity=40
                }
            };

            var anomalies =
                processor.DetectAnomalies(records, stations);

            Assert.AreEqual(1, anomalies.Count);
        }

        [Test]
        public void BinaryRoundTrip()
        {
            List<WeatherRecord> records = new List<WeatherRecord>()
            {
                new WeatherRecord{TempC=20},
                new WeatherRecord{TempC=25},
                new WeatherRecord{TempC=30}
            };

            MemoryStream ms =
                binaryService.WriteTemperatures(records);

            List<double> temps =
                binaryService.ReadTemperatures(ms);

            Assert.AreEqual(3, temps.Count);
            Assert.AreEqual(20, temps[0]);
            Assert.AreEqual(25, temps[1]);
            Assert.AreEqual(30, temps[2]);
        }


    }