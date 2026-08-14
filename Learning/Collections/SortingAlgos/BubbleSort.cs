namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.SortingAlgos;

public class BubbleSort : ISort
{
    public void Sort(int[] array)
    {
        //3 2 5 2 4
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                   ( array[j] , array[j + 1]) = (array[j + 1] , array[j]);
                }
            }
        }

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
    
}