namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodExplore;

public class MethodExp
{
    public static void Change(int[] arr ,  ref int x)
    {
        x = 50;
        arr = new int[] {5,5,5};
        
    }
    
     public static void Change2(string text)
    {
        text = "World";
    }
    
    
    public static void Change3(int[] arr)
    {
        arr[0]++;
        arr[1]++;
        arr[2]++;
    }
    
    public static void Change4(int[] arr)
    {
        arr = arr;
        arr[0] = 99;
    }

    public static void Change5(int[] arr)
    {

        int[] b = arr;

        b[0] = 100;

        Console.WriteLine(arr[0]);
    }

    public static void Change6(int[] arr)
    {

        int[] b = arr;

        arr = new int[] {9,9,9};

        Console.WriteLine(b[0]);
    }
    
    //*****STAR******
    public static void Change7(ref int[] arr)
    {
        arr = new int[] {5,5,5};
    }

    public static void Change8(int[] arr)
    {

        int [] b = (int[])arr.Clone();
        
        b[0] = 100;

        Console.WriteLine(arr[0]);
    }
    
    public static void Change9(ref int[] arr)
    {
        Array.Resize(ref arr, 5);
    }


    
}