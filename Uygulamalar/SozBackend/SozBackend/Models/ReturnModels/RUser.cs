namespace SozBackend.Models.ReturnModels;

public class RUser
{

    public string Username { get; set; }

    public ICollection<Like> Likes { get; }

    public ICollection<Quote> Quotes { get; }

    public RUser(User user)
    {
        Username = user.Username;
        Likes = user.Likes;
        Quotes = user.Quotes;
    }
}