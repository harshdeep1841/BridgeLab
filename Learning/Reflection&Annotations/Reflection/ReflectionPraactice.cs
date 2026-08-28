using System.Reflection;

namespace ConsoleAppLearning1.Learning.Reflection_Annotations.Reflection;

public class University
{
    public  string name;
    public string Name { get; set; }
    public string Location { get; set; }

    public University(string name, string location)
    {
        Name = name;
        Location = location;
    }

    public void GetInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Location);
    }

    public int Fee(int amount)
    {
        return amount;
    }
}


public class ReflectionPractice
{
    public void GetFieldsMethods()
    {
        Type type = typeof(University);
        MethodInfo [] methods = type.GetMethods();
        // foreach (var item in methods)
        // {
        //     Console.WriteLine(item.Name + " : " + item.ReturnType);
        // }
        
        // University university = new University();
        ConstructorInfo  constructor = type.GetConstructor(new Type [] {typeof(string) , typeof(string)});
        University university = (University)constructor.Invoke(new object[] { "Ahmed", "Abdulla"  });
        int invokeMethod = (int) methods[5].Invoke(university , new object[] {1});


        // FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        // foreach (var item in fields)
        // {
        //     Console.WriteLine(item.Name);
        // }
        Console.WriteLine(invokeMethod);
        

    }
}