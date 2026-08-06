using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class TempratureAnalyzer
{
    public int [][] TempArray { get; set; }
    
   public TempratureAnalyzer(){}

   public TempratureAnalyzer(int[][] tempArray)
    {
        TempArray = tempArray;
    }
    public  void HotestAndColdestDay()
    {
        int[] avgTempPerDay = AvgTempPerDay();
        int low = Int32.MaxValue;
        int high = Int32.MinValue;
        int lowDay = 0;
        int highDay = 0;
        for (int i = 0; i < avgTempPerDay.Length; i++)
        {
            if (low > avgTempPerDay[i])
            {
                low = avgTempPerDay[i];
                lowDay = i + 1;
            }
             if (high < avgTempPerDay[i])
            {
                high = avgTempPerDay[i];
                highDay = i + 1;
            }
        }
        Console.WriteLine($"Hotest : {highDay} , Coldest : {lowDay} ");
    }

    public  int [] AvgTempPerDay()
    {
        int[] tempPerDay = new int[TempArray.Length];
        for (int i = 0; i < TempArray.GetLength(0); i++)
        {
            int tempAvg = 0;
            for (int j = 0; j < TempArray.GetLength(1); j++)
            {
                tempAvg += TempArray[i][j];
            }

            tempPerDay[i] = tempAvg;
        }
        
        return tempPerDay;
    }
}