using ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;
namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodExplore;
public class Assignments
{
    public static int FindSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public static double findMean(int[] arr)
    {
        return (double) (FindSum(arr) /  arr.Length);
    }

    public static double findShortest(int[] arr)
    {
        Array.Sort(arr);
        return arr[0];
    }

    public static double findLongest(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length - 1];
    }

    public static void printHeights(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine($"total height :  {FindSum(arr)}");
        Console.WriteLine($"mean : {findMean(arr)}");
        Console.WriteLine($"shortest height : {findShortest(arr)}");
        Console.WriteLine($"longest height : {findLongest(arr)}");
    }

    public static bool ArmStrong(int num)
    {  
        string str = num.ToString();
        int temp = num;
        int n = str.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = temp % 10;
            int pov = (int)Math.Pow(number  , n);
            sum += pov;
            temp /= 10;
        }

        if (sum == num)
        {
            return true;
        }
        return false;
    }

    public static bool PrimeNumber(int num)
    {
        //11
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool NeonNumber(int num)
    {
        //number who's some of the digits of its square is equal to the number itself
        //9 - > 9X9 -> 81 -> 8 + 1 = 9
        int sqr = num * num;
        int tempNum = num;
        string temp = sqr.ToString();
        int sum = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            int s = tempNum % 10;
            sum += s;
            tempNum /= 10;
        }
        return sum == num ? true : false;
    }
    
    //Calendar Question

    public static string MonthName(int num)
    {
        if (num > 12 || num < 1) return "No possible";
        string[] month =
        {
            "January", "Feberuary", "March", "April", "May",
            "June", "July", "Augest", "September", "October", "November", "December",
        };
        return month[num - 1];
    }

    public static int NumberOfDaysInMonth(string month , int year)
    {
        Dictionary<string , int> dict   = new Dictionary<string , int>();
        dict.Add("January", 1);
        dict.Add("February", 2);
        dict.Add("March", 3);
        dict.Add("April", 4);
        dict.Add("May", 5);
        dict.Add("June", 6);
        dict.Add("July", 7);
        dict.Add("August", 8);
        dict.Add("September", 9);
        dict.Add("October", 10);
        dict.Add("November", 11);
        dict.Add("December", 12);

        int[] days = {31 , 28 , 31 , 30 , 31 , 30 , 31 , 31 , 30 ,31 , 30 , 31 };
        if (ArrayProblem.LeapYear(year) && month == "February")
        {
            return 29;
        }
        int currentMonth = dict[month];
        return days[currentMonth - 1];
        
        

    }
    
    
    public static DayOfWeek FirstDayOfMonth(int month,int year)
    {
        DateTime date = new DateTime(year, month, 1);
        return date.DayOfWeek;
    }

    public static void Transpose(int[,] arr)
    {
        //1 2 3         1 4 7
        //4 5 6 ------> 2 5 8
        //7 8 9         3 6 9
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        
    }

    public static void printDiamond(int n)
    {
        
        for (int i = 1; i <= n;  i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            
            for(int j = 1 ; j <= 2*i - 1; j++)
            {
                if (j == 1 || j == 2 * i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
                
            }

            for (int j = 1; j <= n - i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            
          
            
        }

        for (int i = 1 ; i<=n - 1;i++)
        {
            
            for (int j = 1; j <= i ; j++)
            {
                Console.Write(" ");
               
            }
            
            for(int j = 1 ; j<= 2*(n - i ) - 1 ; j++)
            {
                if (j == 1 || j == 2 *(n - i) - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("$");
                }
                
            }

          
            Console.WriteLine();
        }

    }


}