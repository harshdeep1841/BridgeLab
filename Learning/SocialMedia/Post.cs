namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Post : ILikeable, ICommentable
{
    public int Id { get; }

    public string Caption { get; private set; }

    public DateTime CreatedAt { get; }

    public User Owner { get; }

    private  Media media;

    private  List<Like> likes = new();

    private  List<Comment> comments = new();

    private static int nextId = 1;

    public Post(User owner, string caption, Media media)
    {
        Id = nextId++;

        Owner = owner;
        Caption = caption;
        this.media = media;

        CreatedAt = DateTime.Now;
    }

    public void AddLike(User user)
    {
        if (likes.Any(like => like.User == user))
        {
            Console.WriteLine(
                $"{user.Username} already liked this post."
            );

            return;
        }

        likes.Add(new Like(user));

        Console.WriteLine(
            $"{user.Username} liked post {Id}."
        );
    }

    public void RemoveLike(User user)
    {
        Like? like = likes.Find(l => l.User == user);
        
        if (like != null)
        {
            likes.Remove(like);
        }
        
        
    }

    public void AddComment(User user, string text)
    {
        Comment comment = new Comment(user, this, text);

        comments.Add(comment);
        Console.WriteLine(
            $"{user.Username} commented: {text}"
        );
    }

    public void Display()
    {
        Console.WriteLine(
            $"Post by {Owner.Username}: {Caption}"
        );

        media.Display();

        Console.WriteLine(
            $"Likes: {likes.Count}"
        );

        Console.WriteLine(
            $"Comments: {comments.Count}"
        );
    }
}