namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

using System;
using System.Collections.Generic;
using System.Linq;

    public class WeatherValidator
    {
        private  List<Station> stations;

        public WeatherValidator(List<Station> stations)
        {
            this.stations = stations;
        }

        public void Validate(WeatherRecord record)
        {
            Station station = stations.FirstOrDefault(s => s.Code == record.StationCode);

            if (station == null)
                throw new UnknownStationException(record.StationCode);

            if (record.TempC < station.MinTemp || record.TempC > station.MaxTemp)
                throw new TemperatureOutOfRangeException(record.StationCode);

            if (record.Humidity < 0 || record.Humidity > 100)
                throw new InvalidHumidityException(record.Humidity);
        }
    }