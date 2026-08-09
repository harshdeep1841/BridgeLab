using System.Text.RegularExpressions;

namespace ConsoleAppLearning1.Learning.Operator.Learning.RegixExplore;

public class RegexAssignement
{
    public void ValidateUserName(string name)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        
        Match match = Regex.Match(name , pattern);
        Console.WriteLine(match.Value);
        if (match.Success)
        {
            Console.WriteLine($"{match.Value} is valid");
        }
    }

    public void ValidateLicencePlateNumber(string licencePlateNumber)
    {
        string pattern = @"^[A-Z][A-Z]\d{4}$";
        Match match = Regex.Match(licencePlateNumber, pattern);
        Console.WriteLine(match.Value);
    }

    public void ValidateHexColorCode(string hexColorCode)
    {
        string pattern = @"^[#][0-9a-fA-F]{6}$";
        Match match = Regex.Match(hexColorCode, pattern);
        Console.WriteLine(match.Value);
    }

    public void ExtractEmailFromSentence(string sentence)
    {
        string pattern = @"[a-z]{1,9}[@][a-z]{1,9}[.][a-z]{1,9}";
        MatchCollection matchs = Regex.Matches(sentence, pattern);
        foreach (Match match in matchs)
        {
            Console.WriteLine(match.Value);
        }
    }

    public void ExtractAllCaptilizedWords(string sentence)
    {
        string pattern = @"[A-Z][a-z]{1,15}";
        MatchCollection matches = Regex.Matches(sentence, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public void ExtractDates(string sentence)
    {
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        MatchCollection matches = Regex.Matches(sentence, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public void ExtractLinks(string sentence)
    {
        string pattern = @"https?://[a-z]{1,9}\.[a-z]{1,9}(\.[a-z]{1,9})?";
        MatchCollection matches = Regex.Matches(sentence, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public void ReplaceSpace(string sentence)
    {
        string pattern = @"\s{2,}";
     string newstr =  Regex.Replace(sentence, pattern, " ");
     Console.WriteLine(newstr);
    }

    public void SensorBadWords(string sentence)
    {
        string[] badWords = { "stupid", "moron", "dumbass", "dumb", "fuck" };
        foreach (string badWord in badWords)
        {
            sentence = Regex.Replace(sentence, badWord, "****");
        }
        Console.WriteLine(sentence);
    }
    //*****STAR******
    // public void ValidateIpAddress(string ipAddress)
    // { //TODO
    //     string pattern = @"(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])";
    //     MatchCollection matches = Regex.Matches(ipAddress, pattern);
    //     foreach (Match match in matches)
    //     {
    //         Console.WriteLine(match.Value);
    //     }
    // }
}