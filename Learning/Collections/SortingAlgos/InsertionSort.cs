namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.SortingAlgos;

public class InsertionSort : ISort
{
    public void Sort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int  j = i;
            while (j > 0 && nums[j - 1] > nums[j])
            { 
                (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                j--;
            }
        }

        foreach (int i in nums )
        {
            Console.WriteLine(i + " ");
        }
    }
}