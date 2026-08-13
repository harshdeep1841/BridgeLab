namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public Movie(string title, string director, int releaseYear, double rating)
    {
        Title = title;
        Director = director;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Director: {Director}, Year: {ReleaseYear}, Rating: {Rating}";
    }
}

public class MovieNode
{
    public Movie Data { get; set; }

    public MovieNode Next { get; set; }

    public MovieNode Previous { get; set; }

    public MovieNode(Movie movie)
    {
        Data = movie;
    }
}