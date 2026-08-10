namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Comment
{
    public User User { get; }

    public Post Post { get; }

    public string Text { get; private set; }

    public DateTime CreatedAt { get; }

    public Comment(
        User user,
        Post post,
        string text)
    {
        User = user;
        Post = post;
        Text = text;
        CreatedAt = DateTime.Now;
    }

    public void Edit(string newText)
    {
        Text = newText;
    }
}