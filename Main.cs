using System.Collections.Specialized;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodExplore;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverloading;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;
using ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;
using Operators;
namespace ConsoleAppLearning1.Learning.Operator;

public  class MainCs
{
    public static void Main(string[] args)
    {
        // Arithmatic a = new Arithmatic();
        // a.func();
        //
        //
        // //method overloading
        // Console.WriteLine(Calculator.Add(10, 20));
        //
        // Console.WriteLine(Calculator.Add(10, 20, 30));

        //method overriding
        // Dog dog = new Dog();
        // dog.Speak();
        //
        // Animal animal = new Dog();
        // animal.Speak();
        //
        // int max = Math.Max(10, 20);
        //
        // int d = 6;
        // switch (d)
        // {
        //     case 10:
        //         Console.WriteLine(d);
        //         break;
        //     case 20:
        //         Console.WriteLine(d);
        //         break;
        //     case 30:
        //         Console.WriteLine(d);
        //         break;  
        //     default:
        //         Console.WriteLine(d);
        //         break;
        //     
        // }

        // string str1 = Console.ReadLine();
        // Console.WriteLine(str1);
        // int num = int.Parse(str1);
        // Console.WriteLine(num); //if str1 contains characters then it will give ForamtException
        //  int num1 = int.Parse(Console.ReadLine());
        //  Console.WriteLine(num1);

        // int num2 = Console.ReadKey();
        // char ch = Console.ReadLine() ![0];
        // Console.WriteLine(ch);
        // char ch1 = (char)Console.Read();
        // Console.WriteLine(ch1);


        //Problem Solving

        //  int[] arr = { 1, 2, 2, 3, 3 };

        // for(int i = 0 ; i < arr.Length ; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // ArrayCS.printElements(arr);

        // List<int> res  = ArrayCS.removeDuplicates(arr);
        // Console.WriteLine(res);
        // foreach (int i in res)
        // {
        //     Console.WriteLine(i);
        // }

        // double double1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine(double1);
        // int int1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(int1);

        //  double double2 =   ArrayProblem.TriangleArea(12, 12);
        //  Console.WriteLine(double2);
        //  
        //  Console.WriteLine(ArrayProblem.Anagram("HarSh" , "harsH"));
        //
        //  string[] strs = { "flower", "flow", "flight" };
        //
        //  string longestPrefix = ArrayProblem.LongestCommonPrefix(strs);
        //  Console.WriteLine(longestPrefix);
        //
        // string rev =  ArrayProblem.Reverse("EasyRewardz");
        // Console.WriteLine(rev);
        // int [] arr1 = { 1, 3, 2, 0, 1, 0, 2, 1, 0, 4 };
        // ArrayProblem.MoveZerosToEnd(arr1);
        //
        // foreach (int i in arr1)
        // {
        //     Console.Write(i + " ");
        // }

        // string s1 = new string("Harsh");
        // string s2 = "Harsh";
        //
        // if(s1 == s2) Console.WriteLine(s1); //both equals() and == check content not referance
        //
        //
        // int [ , ] array = new int[3 , 3]; //2d array
        //
        // for (int i = 0; i < array.GetLength(0); i++) //GetLength gives us the length of particular dimension
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //        array[i, j] = i + j; 
        //     }
        //    Console.Error.WriteLine(array);
        //}




    // int[] array2 = { 1, 2, 3, 4 };
       // int [] copy = new int[array2.Length];
       //
       // Array.Copy(array2 , copy , 4);
       //Array.Clear(array2 , 1 , 3);     // }
      
       
       // Array.Reverse(array2 , 1 , 3);
       // Array.Resize(ref array2 , 6);

       // for (int i = 0; i < array2.Length; i++)
       // {
       //     Console.Write(array2[i] + " ");
       // }
        
        
         // for (int i = 0; i < copy.Length; i++)
         // {
         //     Console.Write(copy[i] + " ");
         // }
         //
        //  int input = Convert.ToInt32(Console.ReadLine());
        // ArrayProblem.practiceProblem(input);
        
       //  string inputString = Convert.ToString(Console.ReadLine());
       // char ch =  ArrayProblem.FirstNonRepatingCharacter(inputString);
       // Console.WriteLine(ch);
       
       //input 2d array
       // string n = Console.ReadLine();
       // string m = Console.ReadLine();
       // int row;
       // int column;
       // if ((!int.TryParse(n, out row) || row < 0) || (!int.TryParse(m, out column) || column < 0))
       // {
       //     Console.Error.WriteLine("Invalid input");
       //     return;
       // }
       //
       // int [ , ] array2D = new int[row , column];
       //
       // for (int i = 0; i < array2D.GetLength(0); i++)
       // {
       //     for (int j = 0; j < array2D.GetLength(1); j++)
       //     {
       //         array2D[i, j] = Convert.ToInt32(Console.ReadLine());
       //     }
       // }
       //
       // ArrayProblem.Print2DArray(array2D);
       //
       // Assignment1.WelcomeToBridgelabz();
       // Assignment1.AddTwoNumbers();
       // Assignment1.CelsiusToFahrenheit();
       // Assignment1.AreaOfCircle();
       // Assignment1.VolumeOfCylinder();
       // Assignment1.CalculateSimpleInterest();

       // int[] termiator = { 1, 2, 3, 4, 5 };
       // int[] skynet = new int[4];
       // Array.Copy(termiator , skynet, 2); //here length is how many elements we 
       //want to copy in new arr. (length in parameter  <= length of new arr)

       // for (int i = 0; i < skynet.Length; i++)
       // {
       //     Console.WriteLine(skynet[i]);
       // }
       
       
       int[] nums = {10, 20, -30 , 40 , 50};
       int[] ones = { 1, 0, 1, 1, 1, 0, 20, 40 };
       // int a = 5;
       // MethodExp.Change(nums , ref a) ;
       // Console.WriteLine(a);
       //Console.WriteLine(nums[0]);
       
       // string name = "Hello";
       // MethodExp.Change2(name);
       // Console.WriteLine(name); //Hello 


       
       // MethodExp.Change3(nums);
       // Console.WriteLine(nums[0]);
       // Console.WriteLine(nums[1]);
       // Console.WriteLine(nums[2]);
       
       
       // MethodExp.Change4(nums);
       // Console.WriteLine(nums[0]);
        
       //MethodExp.Change5(nums);
       
       //MethodExp.Change6(nums);
       
       
       // MethodExp.Change7(ref nums);
       // Console.WriteLine(nums[0]);
       
       //MethodExp.Change8(nums);
           
        
       // MethodExp.Change9(ref nums);
       // Console.WriteLine(nums.Length);
       
       // int[] dice = { 1, 2, 3, 4, 5, 6 };
       // Random random = new Random();
       // random.Shuffle(dice);
       // Console.WriteLine(string.Join(",", dice));
       //
       // for (int i = 0; i < 6; i++)
       // {
       //     Console.WriteLine(random.Next(3 , 5)); //from 3  to 5 - 1 i-e 4
       //     
       // }
       //
       // int randomNum = random.Next(1 , 10); // 1 to 9
       //
       // Console.WriteLine(random.Next()); //it will print number from 1 to 10 in random order
       //
       //
       
       //Math
      //double absDouble =  Math.Abs(2.6);
      //Console.WriteLine(absDouble);
      //Console.WriteLine(Math.Ceiling(absDouble)); //next int
      //Console.WriteLine(Math.Floor(absDouble)); //prev int
      //Console.WriteLine(Math.Round(absDouble)); //closest int

    //MethodExp.Change10(10 , 20 , 3 , 7 );
    
    
    // string number = Console.ReadLine();
    //
    // if (!int.TryParse( number , out int num))
    // {
    //     Console.Error.WriteLine("Invalid input");
    // }

    // int cntUpperCase = ArrayProblem.CountUpperCase("HarsH");
    // Console.WriteLine(cntUpperCase);
    //
    // ArrayProblem.rotateArrayLeft(nums , 2);
    // Console.WriteLine(string.Join(", " , nums));
    
    // int maxOnes = ArrayProblem.MaxConsecutiveOnes(ones);
    // Console.WriteLine(maxOnes);
    
    // int maxSubarraySum = ArrayProblem.MaxSubarraySum(nums);
    // Console.WriteLine(maxSubarraySum);
    
    IList<int> unionArrays  = ArrayProblem.UnionArray(nums, ones);
    Console.WriteLine(string.Join(", " , unionArrays));
    
    }

}
