namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public bool IsAvailable { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void Checkout()
    {
        if (!IsAvailable)
        {
            Console.WriteLine($"{Title} is already checked out.");
            return;
        }

        IsAvailable = false;
        Console.WriteLine($"{Title} checked out successfully.");
    }

    public void ReturnBook()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} returned successfully.");
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Available: {IsAvailable}");
    }

    public override  string ToString()
    {
        return $"{Title} - {Author}";
    }
}