using System.Text;

namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class ArrayCS
{
    public static void printElements(int[] arr)
    {
        foreach (int e in arr)
        {
            Console.WriteLine(e);
        }
        
    }

    public static List<int> removeDuplicates(int[] arr)
    {
        int n = arr.Length;
        List<int> list = new List<int>();
        //1 1 2 3 2 2 2
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            
        }

        foreach ( var (key, value) in dict )
        {
            list.Add(key);
        }
        
        return list;
    }

    public static double triangleArea(int b, int h)
    {
        double area = ( b * h / 2);
        return area;
    }

    public static bool leapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        return false;
    }

    public static bool anagram(string a, string b)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        foreach (char c in a)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach (char c in b)
        {
            if (!dict.ContainsKey(c))
            {
                return false;
            }

            dict[c]--;
            if (dict[c] < 0)
                return false;
        }

        return true;
    }
    
    public static string minLen(string[] str)
    {
        int len = 500;
        string res = "";
        for(int i = 0 ; i < str.Length ; i++)
        {
            string str1 = str[i];
            if(len > str1.Length)
            {
                len = str1.Length;
                res = str1;
            }
        }

        return res;
    }

    
    public static  string LongestCommonPrefix(string[] strs) {
        int a = 0;
        string ans = "";
       
        string str = minLen(strs);
        for(int i = 0 ; i < str.Length ; i++)
        {
            char ch = strs[0][i];
            for(int j = 0; j < strs.Length ; j++)
            {
                if(ch != strs[j][i])
                {
                    return ans;
                }

            }

            ans += strs[0][a];
            a++;
            
        }

        return ans;
    }

    public static string reverse( string str)
    {
        int start = 0;
        int end = str.Length - 1;
        StringBuilder sb = new StringBuilder(str);
        
        while (start < end)
        { 
            char temp = sb[start];
            sb[start] =  sb[end];
            sb[end] = temp;
            start++;
            end--;
        }

        return sb.ToString();

    }

    public static void moveZerosToEnd(int[] arr)
    {
        // 1 3 2 0 1 0 2 1 0 4
        
        int j = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j++;
            }
        }
        
    }
    
    
    
    
}