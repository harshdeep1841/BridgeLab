namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Like
{
    public User User { get; }

    public DateTime CreatedAt { get; }

    public Like(User user)
    {
        User = user;
        CreatedAt = DateTime.Now;
    }
}