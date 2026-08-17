namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Test;

// public class Box<T> where T : struct
// {
//     public T Value { get; set; }
//
//     public T GetValue()
//     {
//         return Value;
//     }
//     
// }

public class Box
{
   public object Value { get; set; }
    public object GetValue()
    {
        return Value;
    }
}