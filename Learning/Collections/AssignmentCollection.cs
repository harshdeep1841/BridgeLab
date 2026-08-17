using System.Collections;
using ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections;

public class Node
{
    public int Data {get; set;}
    public Node Next { get; set; }

    public Node(int data, Node next)
    {
        this.Data = data;
        this.Next = next;
    }

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}
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
            Console.WriteLine(k + " " + v);
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
    
    
    public void CollectionTest()
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(1);
        list.Add(1);
       int cnt =  list.Count;
       int cap =  list.Capacity;
       Console.Write($"{cnt} ,   {cap}");
       
    }

    public Node ArrayToLL(int [] arr)
    {
        if (arr.Length == 0) return null;
        Node head = new Node(0);
        Node temp = head;
        foreach(int i in arr)
        {
            temp.Next = new Node(i);
            temp = temp.Next;
        }
        return head;
    }

    public Node KthFromEnd(Node head, int k)
    {
        if (head == null || head.Next == null) return head;
        Node newNode = Reverse(head);
        Node temp = newNode;
        while (temp != null)
        {
            k--;
            if (k == 0)
            {
                break;
            }
            temp = temp.Next;
        }

        return temp;
    }

    public Node Reverse(Node head)
    {
        Node temp = head;
        Node prev = null;
        while (temp != null)
        {
            Node front = temp.Next;
            temp.Next = prev;
            prev = temp;
            temp = front;
        }

        return prev;
    }


    public bool SetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1.Count != set2.Count) return false;
        foreach (int i in set1)
        {
            if (!set2.Contains(i))
            {
                return false;
            }
        }
        return true;
    }

    public void ReverseQueue(Queue<int> queue)
    {
        // IEnumerable<int> e =  queue.Reverse();
        // foreach (int i in e)
        // {            
        //     Console.Write(i + " ");
        // }        
        if(queue.Count == 0) return;
        int val  = queue.Dequeue();
        ReverseQueue(queue);
        queue.Enqueue(val);
    }

    public void GenerateBinaryNumbers(int n)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");
        int cnt = 1;
        List<string> ans = new List<string>();
        while (queue.Count > 0)
        {
            string temp = queue.Dequeue();
            ans.Add(temp);
            if (cnt < n)
            {
                queue.Enqueue(temp + "0");
                cnt++;
            }
            if (cnt < n)
            {
                queue.Enqueue(temp + "1");
                cnt++;
            } 
            
            
        }

        foreach (string s in ans)
        {
            Console.WriteLine(s + " ");
        }
    }
    
    
}