using System.Diagnostics;

namespace ConsoleAppLearning1.Learning.RuntimeAnalysis_BigO;

public class SearchTarget
{
    public void searchTarget(int[] array, int target)
    {
        //using Linear Search
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                break;
            }
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();
        //Binary Search
        stopwatch.Start();
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (array[mid] == target)
            {
                break;
            }
            else if (array[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}