namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Follow
{
    public User Follower { get; }

    public User Following { get; }

    public DateTime CreatedAt { get; }

    public Follow(User follower, User following)
    {
        Follower = follower;
        Following = following;
        CreatedAt = DateTime.Now;
    }
}