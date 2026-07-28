namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class StringProblem
{
    public static void BasicConcept()
    {
        string text = "My name is Harsh";
        // char [] ch = text.ToCharArray();
        // foreach(char c in ch)
        // {
        //     Console.WriteLine(c);
        // }
        //
        //
        // string name = " Harsh";
        // Object obj = name;
        // string name1 = (string)obj;
        // string newStr =  name.Trim();
        // string newnewStr =  name.Replace("ar", "aaaa");
        // bool checkStr = name.Contains("ar");
        // Console.WriteLine(newnewStr);
        // Console.WriteLine(checkStr);
        //
        
    }
    
    public static void CountVowelsAndConsonants(string str)
    {
        int vowels = 0;
        int consonants = 0;

        foreach (char ch in str.ToLower())
        {
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"Vowels : {vowels}");
        Console.WriteLine($"Consonants : {consonants}");
    }
    
    public static string ReverseString(string str)
    {
        char[] result = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            result[i] = str[str.Length - 1 - i];
        }

        return new string(result);
    }
    
    public static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
    
    
    public static string RemoveDuplicates(string str)
    {
        HashSet<char> set = new HashSet<char>();
        string result = "";

        foreach (char ch in str)
        {
            if (!set.Contains(ch))
            {
                set.Add(ch);
                result += ch;
            }
        }

        return result;
    }
    
    
    public static int CountSubstring(string str, string sub)
    {
        int count = 0;

        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            bool found = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (str[i + j] != sub[j])
                {
                    found = false;
                    break;
                }
            }

            if (found)
                count++;
        }

        return count;
    }
    
    public static string ToggleCase(string str)
    {
        char[] result = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
                result[i] = char.ToLower(str[i]);
            else if (char.IsLower(str[i]))
                result[i] = char.ToUpper(str[i]);
            else
                result[i] = str[i];
        }

        return new string(result);
    }
    
    public static void CompareStrings(string s1, string s2)
    {
        int min = Math.Min(s1.Length, s2.Length);

        for (int i = 0; i < min; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine($"{s1} comes before {s2}");
                return;
            }

            if (s1[i] > s2[i])
            {
                Console.WriteLine($"{s2} comes before {s1}");
                return;
            }
        }

        if (s1.Length < s2.Length)
            Console.WriteLine($"{s1} comes before {s2}");
        else if (s1.Length > s2.Length)
            Console.WriteLine($"{s2} comes before {s1}");
        else
            Console.WriteLine("Both strings are equal");
    }
    
    
}