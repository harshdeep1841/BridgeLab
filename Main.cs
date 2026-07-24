using System.Collections.Specialized;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverloading;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;
using ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;
using Operators;
namespace ConsoleAppLearning1.Learning.Operator;

public class MainCS
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

     //  double double2 =   ArrayProblem.triangleArea(12, 12);
     //  Console.WriteLine(double2);
     //  
     //  Console.WriteLine(ArrayProblem.anagram("HarSh" , "harsH"));
     //
     //  string[] strs = { "flower", "flow", "flight" };
     //
     //  string longestPrefix = ArrayProblem.LongestCommonPrefix(strs);
     //  Console.WriteLine(longestPrefix);
     //
     // string rev =  ArrayProblem.reverse("EasyRewardz");
     // Console.WriteLine(rev);
     // int [] arr1 = { 1, 3, 2, 0, 1, 0, 2, 1, 0, 4 };
     // ArrayProblem.moveZerosToEnd(arr1);
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
     // }
     //    Console.Error.WriteLine(array);
        
        
        

       // int[] array2 = { 1, 2, 3, 4 };
       // int [] copy = new int[array2.Length];
       //
       // Array.Copy(array2 , copy , 4);
       //Array.Clear(array2 , 1 , 3);
      
       
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
       // char ch =  ArrayProblem.firstNonRepatingCharacter(inputString);
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
       // ArrayProblem.print2DArray(array2D);
    
       Assignment1.WelcomeToBridgelabz();
       Assignment1.AddTwoNumbers();
       Assignment1.CelsiusToFahrenheit();
       Assignment1.AreaOfCircle();
       Assignment1.VolumeOfCylinder();
       Assignment1.CalculateSimpleInterest();


    }

}

