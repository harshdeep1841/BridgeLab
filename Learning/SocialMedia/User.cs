namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public abstract class User
{
    public int Id { get; }

    public string Username { get; }

    public string Email { get; }

    private string password;

    private  List<Post> posts = new();

    protected User(int id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        this.password = password;
    }

    public void CreatePost(string caption, Media media)
    {
        Post post = new Post(this, caption, media);

        posts.Add(post);

        Console.WriteLine($"{Username} created a post.");
    }

    public void LikePost(Post post)
    {
        post.AddLike(this);
    }

    public void CommentOnPost(Post post, string text)
    {
        post.AddComment(this, text);
    }

    public void Follow(User user)
    {
        if (user == this)
            throw new InvalidOperationException(
                "You cannot follow yourself."
            );

        Follow follow = new Follow(this, user);

        Console.WriteLine(
            $"{Username} followed {user.Username}"
        );
    }

    public abstract void DisplayProfile();
}