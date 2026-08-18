using System.Text.RegularExpressions;

namespace ConsoleAppLearning1.Learning.Streams;

public class CountWordOccurances
{
    public void WordOccurances()
    {
        FileStream fileReader = new FileStream("words.txt", FileMode.Open , FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileReader);
        string line;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        while ((line = streamReader.ReadLine()) != null)
        {
            string[] strs = Regex.Split(line, @"\s+");
            foreach (string str in strs)
            {
                string word = str.Trim('.', ',', '!', '?', ';', ':', '"', '\'', '(', ')');
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(str, 1);
                }
                else
                {
                    dictionary[str]++;
                }
            }
        }

        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}