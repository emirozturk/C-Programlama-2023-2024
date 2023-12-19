using SozBackend.Models;

namespace SozBackend.DataAccess;

public class QuoteDAL : IQuoteDAL
{
    private SozDbContext context;
    private IUserDAL userDal;

    public QuoteDAL(SozDbContext context,IUserDAL userDal)
    {
        this.context = context;
        this.userDal = userDal;
    }

    public List<Quote> GetQuotesOfUser(string username)
    {
        return userDal.GetUser(username).Quotes.ToList();
    }
}