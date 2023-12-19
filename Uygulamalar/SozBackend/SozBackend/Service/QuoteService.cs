using SozBackend.DataAccess;
using SozBackend.Models;

namespace SozBackend.Service;

public class QuoteService: IQuoteService
{
    private IQuoteDAL quoteDal;
    private IUserService userService;

    public QuoteService(IQuoteDAL quoteDal,IUserService userService)
    {
        this.quoteDal = quoteDal;
        this.userService = userService;
    }

    public List<Quote> GetQuotesOfUser(string username)
    {
        List<Quote> result = quoteDal.GetQuotesOfUser(username);
        if (result.Count == 0)
            throw new Exception("No quotes found");
        return result;
    }

    public Quote AddQuoteToUser(Quote quote, string username)
    {
        var user = userService.GetUser(username);
        if(user == null)
            throw new Exception("User not found");
        user.Quotes.Add(quote);
        userService.UpdateUser(user.Username, user);
        return quote;
    }

    public Quote DeleteQuoteOfUser(Quote quote, string username)
    {
        var user = userService.GetUser(username);
        if(user == null)
            throw new Exception("User not found");
        var found = user.Quotes.First(x => x.Id == quote.Id);
        user.Quotes.Remove(found);
        userService.UpdateUser(user.Username, user);
        return quote;
    }
}