using System.Collections;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections;

public class AssignmentCollection
{
    public void Reverse(ArrayList input)
    {
        //input.Reverse();
        LinkedList<int> ll = new LinkedList<int>();
        foreach (int i in input)
        {
            ll.AddFirst(i);
        }

        foreach (int i in ll)
        {
            Console.Write(i + " ");
        }
    }

    public void FreqElement(string[] strs)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (string str in strs)
        {
            if (!dict.ContainsKey(str))
            {
                dict[str] = 1;
            }
            else
            {
                dict[str]++;
            }
        }

        foreach (var (k, v) in dict)
        {
            Console.Write(k + " " + v);
        }
    }
    
    
    
    
}