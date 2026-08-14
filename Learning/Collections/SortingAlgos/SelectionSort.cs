namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.SortingAlgos;

public class SelectionSort : ISort
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            
            (array[min] , array[i]) = (array[i], array[min]);
        }

        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
}