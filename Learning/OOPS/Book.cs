namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Book
{
    
    public string Title { get; set;}
    public string Author { get; set;}
    public int Price { get; set;}

    public Book(string title, string author, int price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public void display()
    {
        Console.WriteLine($"{Title} - {Author} - {Price}");
    }
}