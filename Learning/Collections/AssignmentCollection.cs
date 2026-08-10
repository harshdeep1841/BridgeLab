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

    
    //1 2 3 4 5 6
    //2 1 6 5 4 3
    //3 4 5 6 1 2 
    public void rotateListByK(ArrayList list, int k)
    {
        list.Reverse(0 , k);
        list.Reverse(k, list.Count - k);
        list.Reverse(0 , list.Count );
    }
    
    public  ArrayList RemoveDuplicates(ArrayList list)
    {
        HashSet<int> seen = new HashSet<int>();
        ArrayList result = new ArrayList();

        foreach (int item in list)
        {
            if (seen.Add(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
    public  bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.SetEquals(set2);
    }
    
    //TODO
    //rest of the questions
    
    
    
}