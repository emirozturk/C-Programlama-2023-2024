using SozBackend.Models;

namespace SozBackend.DataAccess;

public interface IQuoteDAL
{
    List<Quote> GetQuotesOfUser(string username);
}