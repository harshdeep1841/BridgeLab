namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

using System.Collections.Generic;
using System.Linq;

    public class WeatherProcessor
    {
        public List<WeatherSummary> GenerateSummary(List<WeatherRecord> records)
        {
            var summary = records
                .GroupBy(r => new
                {
                    r.StationCode,
                    r.Date
                })
                .Select(g => new WeatherSummary
                {
                    
                    StationCode = g.Key.StationCode,
                    Date = g.Key.Date,
                    MinTemp = g.Min(x => x.TempC),
                    MaxTemp = g.Max(x => x.TempC),
                    AverageTemp = g.Average(x => x.TempC)
                    
                })
                .ToList();

            return summary;
        }

        public List<WeatherRecord> DetectAnomalies(
            List<WeatherRecord> records,
            List<Station> stations)
        {
            List<WeatherRecord> anomalies = new();

            foreach (var record in records)
            {
                Station station = stations
                    .FirstOrDefault(s => s.Code == record.StationCode);

                if (station == null)
                    continue;

                if (record.TempC < station.MinTemp ||
                    record.TempC > station.MaxTemp)
                {
                    anomalies.Add(record);
                }
            }

            return anomalies;
        }
    }