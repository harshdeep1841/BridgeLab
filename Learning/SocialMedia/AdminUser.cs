namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class AdminUser : User
{
    public AdminUser(
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
            $"Admin User: {Username}"
        );
    }

    public void DeletePost(Post post)
    {
        Console.WriteLine(
            $"Admin {Username} deleted a post."
        );
    }
}