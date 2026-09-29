namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

using System.Collections.Generic;
using System.IO;

public class BinaryService
    {
        public MemoryStream WriteTemperatures(List<WeatherRecord> records)
        {
            MemoryStream ms = new MemoryStream();

            BinaryWriter bw = new BinaryWriter(ms);

            foreach (var record in records)
            {
                bw.Write(record.TempC);
            }

            bw.Flush();

            ms.Position = 0;

            return ms;
        }

        public List<double> ReadTemperatures(MemoryStream ms)
        {
            List<double> temperatures = new();

            ms.Position = 0;

            BinaryReader br = new BinaryReader(ms);

            while (ms.Position < ms.Length)
            {
                temperatures.Add(br.ReadDouble());
            }

        
            return temperatures;
        }
        
    } 