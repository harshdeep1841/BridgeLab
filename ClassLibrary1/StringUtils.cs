using System.Text;

namespace ClassLibrary1;

public class StringUtils
{
    public StringUtils(){}
    
    public string reverse(string s)
    {
        StringBuilder sb = new StringBuilder(s);

        int i = 0;
        int j = s.Length - 1;

        while (i <= j)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;

            i++;
            j--;
        }
        
        return sb.ToString();
    }

    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i <= j)
        {
            if (s[i] != s[j])
            {
                return false;
            }

            i++;
            j--;
        }
        return true;
    }

    public string ToUpperCase(string s)
    {
        return s.ToUpper();
    }
}