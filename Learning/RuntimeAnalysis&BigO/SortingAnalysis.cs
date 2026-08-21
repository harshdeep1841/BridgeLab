using System;
using System.Diagnostics;

namespace ConsoleAppLearning1.Learning.RuntimeAnalysis_BigO
{
    public class SortingAnalysis
    {
        public void Analysis(int[] arr)
        {
            int[] bubbleArray = (int[])arr.Clone();
            int[] mergeArray = (int[])arr.Clone();
            int[] quickArray = (int[])arr.Clone();

            Stopwatch sw = new Stopwatch();

            // Bubble Sort
            sw.Start();
            BubbleSort(bubbleArray);
            sw.Stop();
            Console.WriteLine($"Bubble Sort : {sw.ElapsedMilliseconds} ms");

            // Merge Sort
            sw.Restart();
            MergeSort(mergeArray, 0, mergeArray.Length - 1);
            sw.Stop();
            Console.WriteLine($"Merge Sort  : {sw.ElapsedMilliseconds} ms");

            // Quick Sort
            sw.Restart();
            QuickSort(quickArray, 0, quickArray.Length - 1);
            sw.Stop();
            Console.WriteLine($"Quick Sort  : {sw.ElapsedMilliseconds} ms");
        }

        #region Bubble Sort

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        #endregion

        #region Merge Sort

        private void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }

            while (i <= mid)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (int x = 0; x < temp.Length; x++)
                arr[left + x] = temp[x];
        }

        #endregion

        #region Quick Sort

        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

            return i + 1;
        }

        #endregion
    }
}