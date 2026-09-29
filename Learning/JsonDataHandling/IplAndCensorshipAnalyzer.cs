using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.JsonDataHandling;

public class IplAndCensorshipAnalyzer
{
    public void Analyze()
    {
        //JSON
        string jsonString = File.ReadAllText("Ipl.json");
        List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonString);

        matches = matches.Select(match =>
        {
            match.Player_Of_Match = "REDACTED";

            match.Team1 = MaskTeamName(match.Team1);
            match.Team2 = MaskTeamName(match.Team2);
            match.Winner = MaskTeamName(match.Winner);

            Dictionary<string, int> updatedScore = new Dictionary<string, int>();

            foreach (var item in match.Score)
            {
                string newKey = MaskTeamName(item.Key);
                updatedScore.Add(newKey, item.Value);
            }

            match.Score = updatedScore;

            return match;
        }).ToList();

        string output = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText("CensoredIpl.json", output);
        
        //CSV
        StreamReader sr = new StreamReader("Ipl.json");
        var csvReader = new CsvReader(sr , CultureInfo.InvariantCulture);
        List<Match> matchesCsv = csvReader.GetRecords<Match>().ToList();
        //after that same logic as above
    }

    private string MaskTeamName(string team)
    {
        string[] words = team.Split(' ');

        if (words.Length == 2)
        {
            words[1] = "***";
        }
        else if (words.Length == 3)
        {
            words[1] = "***";
        }
        

        return string.Join(" ", words);
        
    }


    public void JsonToXml()
    {
        string jsonString = File.ReadAllText("Ipl.json");
        XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(jsonString, "Ipl.json");
        // Console.WriteLine(xmlDoc.BaseURI);
    }
}
