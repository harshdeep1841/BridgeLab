using Newtonsoft.Json;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.JsonDataHandling;

public class JsonSample
{
    public void Serialize(StudentDH student)
    {
        //object to json
       
       
        var json = JsonConvert.SerializeObject(student);
        AddJson(json);
        Console.WriteLine(json);
    }

    public void Deserialize()
    {
        var json = new {Name = "Jane", Age = 20 , Subjects = new List<string> {"Jane", "Jane", "Jane"}};
        var jsonString = JsonConvert.SerializeObject(json);
        Console.WriteLine(jsonString);
    }
    

    public void AddJson(string json)
    {
      using  StreamWriter streamWriter = new StreamWriter("JsonSample.json" , true);
      streamWriter.Write(json);
    }
    
    
    public void AnonomusObjectSerialize()
    {
        
        var user = new {Name = "Jane", Age = 20};
        var json = JsonConvert.SerializeObject(user);
        Console.WriteLine(json);
    }

    public void ReadJsonData()
    {
        var json = File.ReadAllText("JsonSample.json");
        StudentDH jsonObject = JsonConvert.DeserializeObject<StudentDH>(json);
        Console.WriteLine(jsonObject.Name);
        Console.WriteLine(jsonObject.Age);
       //we can also use dynamic which tells the type in runtime. 
    }

    public void WriteJsonData()
    {
        var user = new
        {
            id = 102,
            name = "Bob",
            age = 30,
            email = "bob@example.com",
            skills = new string[] { "Python", "Django", "AWS" },
            address = new { city = "Los Angeles", zip = "90001" }
        };

        string jsonString = JsonConvert.SerializeObject(user, Formatting.Indented);
        File.AppendAllText("JsonSample.json", jsonString );

    }
}