namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class LibraryBook
{
    public static string LibraryName = "Library Book";

    private readonly string author;
    public  string  Author { get; set; }
    public string Title { get; set; }
    public int Available { get; set; }
    public double Price { get; set; }

    public LibraryBook(){}

    public LibraryBook(string author, string title, int available, double price)
    {
        Author = author;
        Title = title;
        Available = available;
        Price = price;
    }
    

    public void BorrowBook()
    {
        Available -= 1;
        
    }

}