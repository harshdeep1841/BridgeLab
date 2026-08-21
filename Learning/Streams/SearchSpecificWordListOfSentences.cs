using System.Text.RegularExpressions;

namespace ConsoleAppLearning1.Learning.Streams;

public class SearchSpecificWordListOfSentences
{
    public string SearchWord(List<string> sentences , string word)
    {
        foreach (string sentence in sentences)
        {
            string [] strs = Regex.Split(sentence, @"\s+");
            foreach (string str in strs)
            {
                if (str == word)
                {
                    return sentence;
                }
            }
        }

        return "sentence not found";
    }
}