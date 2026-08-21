using System.Text;

namespace ConsoleAppLearning1.Learning.Streams;

public class ConcanateStrings
{
    public void ConcanateStringUsingStringBuilder(String [] strs)
    {
        StringBuilder str = new StringBuilder();
        foreach (String s in strs)
        {
            str.Append(s);
        }
    }
}