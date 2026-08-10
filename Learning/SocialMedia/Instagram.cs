namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Instagram
{
    private readonly List<User> users = new();

    private readonly List<Post> posts = new();

    public void RegisterUser(User user)
    {
        users.Add(user);
    }

    public void AddPost(Post post)
    {
        posts.Add(post);
    }


    public void ShowAllPosts()
    {
        foreach (Post post in posts)
        {
            post.Display();

            Console.WriteLine();
        }
    }

}