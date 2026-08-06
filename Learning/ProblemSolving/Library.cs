namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class Library
{
    private Book[] books;

    public Library(Book[] books)
    {
        this.books = books;
    }

    public void DisplayBooks()
    {
        foreach (Book book in books)
        {
            book.Display();
        }
    }

    public Book[] Search(string title)
      {
        List<Book> result = new List<Book>();

        foreach (Book book in books)
        {
            if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(book);
            }
        }

        return result.ToArray();
    }

    public void CheckoutBook(string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(title , StringComparison.OrdinalIgnoreCase))
            {
                book.Checkout();
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    public void ReturnBook(string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                book.ReturnBook();
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }
}