namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

    public class CsvService
    {
        public List<WeatherRecord> ReadWeatherRecords()
        {
            List<WeatherRecord> records = new List<WeatherRecord>();

            string[] lines = File.ReadAllLines("weather.csv");

            
            foreach (string line in lines.Skip(1))   
            {
                string[] parts = line.Split(',');

                records.Add(new WeatherRecord
                {
                    StationCode = parts[0],
                    
                    Date = DateTime.Parse(parts[1]),
                    TempC = double.Parse(parts[2]),
                    Humidity = int.Parse(parts[3])
                });
            }

            return records;
        }
    }