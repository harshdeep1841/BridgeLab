using System.Text;

namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class ArrayProblem
{
    public static void PrintElements(int[] arr)
    {
        foreach (int e in arr)
        {
            Console.WriteLine(e);
        }
        
    }

    public static List<int> RemoveDuplicates(int[] arr)
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

    public static double TriangleArea(int b, int h)
    {
        double area = ( b * h / 2);
        return area;
    }

    public static bool LeapYear(int year)
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

    public static bool Anagram(string a, string b)
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
    
    public static string MinLen(string[] str)
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
       
        string str = MinLen(strs);
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

    public static string Reverse( string str)
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

    public static void Reverse(int[] arr , int st , int end)
    {
        while (st <= end)
        {
            int temp =  arr[st];
            arr[st] = arr[end];
            arr[end] = temp;
            st++;
            end--;
        }
    }

    public static void MoveZerosToEnd(int[] arr)
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

    public static char FirstNonRepatingCharacter(string s)
    {
        // r    a   c   e   c   a   r
        for (int i = 0; i < s.Length; i++)
        {
            bool flag = false;
            for (int j = 0; j < s.Length; j++)
            {
                if (i != j && s[i] == s[j])
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                return s[i];
            }
            
        }

        return 'x'; //when all characters are repating
    }

    public static void PracticeProblem(int n)
    {
        int[] arr = new int[n];

        for(int i = 0 ; i < n ; i++)
        {
            
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] <= 0)
            {
                arr[i] = 0;
                break;
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
        Console.WriteLine(sum);
        
    }

    public static void Print2DArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int CountUpperCase(string str)
    {
        int cnt = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                cnt++;
            }
        }

        return cnt;
    }

    public static void rotateArrayLeft(int[] arr , int k)
    {
        int len  = arr.Length;
       // 1,2,3,4,5 //k = 2;
        //3 ,4, 5, 1, 2 
        
        Reverse(arr , 0 , k - 1);
        Reverse(arr , k , arr.Length - 1);
        Reverse(arr , 0 , arr.Length - 1);
        
    }

    public static int MaxConsecutiveOnes(int[] arr)
    {
        //1 0 0 1 1 1 0 1
        int cnt = 0;
        int maxCnt = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                cnt++;
            }
            else cnt = 0;
            
            maxCnt = Math.Max(cnt, maxCnt);
        }
        return maxCnt;
    }

    public static int MaxSubarraySum(int[] arr)
    {
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                sum = 0;
            }
            else
            {
                sum += arr[i];
            }
            maxSum = Math.Max(maxSum, sum);
        }
        
        return maxSum;
    }

    public static IList<int> UnionArray(int[] arr1, int[] arr2)
    {
        HashSet<int> set = new HashSet<int>();
        IList<int> ans = new List<int>();
        for (int i = 0; i < arr1.Length; i++)
        {
            set.Add(arr1[i]);
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            set.Add(arr2[i]);
        }

        foreach (int e in set)
        {
            ans.Add(e);
        }

        return ans;
    }

    public static int  func1(out int a , out int b)
    {
        a = 12;
        b = 12;
        return a ;
    }

    public static void HollowTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                if (i == n)
                {
                    Console.Write("*");
                }
                else if (j == 1 || j == 2 * i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }



    


}