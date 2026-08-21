namespace ConsoleAppLearning1.Learning.Streams;

public class FirstAndLastOccuranceBS
{
    public int FirstOccurance(int [] arr , int n)
    {
        int low = 0;
        int high = arr.Length - 1;
        int ans = -1;
        //1 2 2 2 3 4 4 5 6
        while (low <= high)
        {
         int mid = low + (high - low) / 2;
         if (arr[mid] >= n)
         {
             ans = mid;
             high = mid - 1;
         }
         else if (arr[mid] < n)
         {
             low = mid + 1;
         }
        }
        return ans;
    }

    public int LastOccurance(int[] arr, int n)
    {
        int low = 0;
        int high = arr.Length - 1;
        int ans = -1;
        while (low <= high)
        {
            int mid  = low + (high - low) / 2;
            if (arr[mid] <= n)
            {
                ans = mid;
                low = mid + 1;
            }
            else if (arr[mid] > n)
            {
                high = mid - 1;
            }
        }
        return ans;
    }
}