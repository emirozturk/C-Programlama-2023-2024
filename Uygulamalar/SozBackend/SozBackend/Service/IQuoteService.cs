using SozBackend.Models;

namespace SozBackend.Service;

public interface IQuoteService
{
    List<Quote> GetQuotesOfUser(string username);
    Quote AddQuoteToUser(Quote quote, string username);
    Quote DeleteQuoteOfUser(Quote quote, string username);
}