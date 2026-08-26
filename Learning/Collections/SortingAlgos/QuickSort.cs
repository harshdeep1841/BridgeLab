namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.SortingAlgos;

public class QuickSort 
{
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i]; 
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            Sort(arr, low, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, high);
        }
    }
}