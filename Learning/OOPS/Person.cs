namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }


    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(Person person)
    {
        Name = person.Name;
        Age = person.Age;
        Email = person.Email;
    }
    
}