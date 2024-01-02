using SozBackend.Models;

namespace SozBackend.DataAccess;

public class LikeDAL : ILikeDAL
{
    private SozDbContext context;

    public LikeDAL(SozDbContext context)
    {
        this.context = context;
    }
    public Like AddLikeToQuote(int userId, int quoteId)
    {
        var newLike = new Like() { UserId = userId, QuoteId = quoteId };
        context.Likes.Add(newLike);
        context.SaveChanges();
        return newLike;
    }
}