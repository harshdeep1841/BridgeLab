namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.SortingAlgos;

public class MergeSort 
{
    public void Sort(int[] array , int low , int high)
    {
        if (low >= high)
        {
            return;
        }
        int mid  = low + (high - low) / 2;
        Sort(array, low , mid);
        Sort(array, mid + 1, high);
        Merging(array, low, mid, high);
    }

    public void Merging(int[] array, int low, int mid, int high)
    {
        int ptr1 = low;
        int ptr2 = mid + 1;
        int[] temp = new int[high - low + 1];
        int k = 0;
        while (ptr1 <= mid && ptr2 <= high)
        {
            if (array[ptr1] <= array[ptr2])
            {
                temp[k++] = array[ptr1];
                ptr1++;
            }
            else
            {
                temp[k++] = array[ptr2];
                ptr2++;
            }
        }

        while (ptr1 <= mid)
        {
            temp[k++] = array[ptr1];
            ptr1++;
        }

        while (ptr2 <= high)
        {
            temp[k++] = array[ptr2];
            ptr2++;
        }

        for (int i = 0; i < temp.Length; i++)
        {
            array[low + i] = temp[i];
        }
        
        foreach (int i in temp )
        {
            Console.Write(i + " ");
        }
    }

}