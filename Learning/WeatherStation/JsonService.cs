using Newtonsoft.Json;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JsonService
    {
        public List<Station> LoadStations()
        {
            string json = File.ReadAllText("stations.json");

            StationRoot root =
                JsonConvert.DeserializeObject<StationRoot>(json);

            return root.Stations;
        }


        
        public void SaveSummary(
            List<WeatherSummary> summary,
            string filePath)
        {

            string json = JsonConvert.SerializeObject(summary, Formatting.Indented);
            
            StreamWriter sw = new StreamWriter(filePath , true);
            sw.Write(json);
            //File.WriteAllText(filePath, json);
            
        }
    }


    public class StationRoot
    {
        public List<Station> Stations { get; set; }
    }
