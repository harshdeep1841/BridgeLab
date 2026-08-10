namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class RegularUser : User
{
    public RegularUser(
        int id,
        string username,
        string email,
        string password)
        : base(id, username, email, password)
    {
    }

    public override void DisplayProfile()
    {
        Console.WriteLine(
            $"Regular User: {Username}"
        );
    }
}