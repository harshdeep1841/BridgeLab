namespace ConsoleAppLearning1.Learning.Streams;

public class RotationPointBS
{
    public void RotatePointInSortedArray(int [] arr )
    {
        int low = 0;
        int high = arr.Length - 1;
        int min = Int32.MaxValue;
        //4 5 1 2 3
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[low] <= arr[mid])
            {
                min = Math.Min(arr[low], min);
                low = mid + 1;
            }
            else if (arr[mid] <= arr[high])
            {
                min = Math.Min(min ,  arr[mid]);
                high = mid - 1;
            }
        }
        Console.WriteLine(min);
    }
}