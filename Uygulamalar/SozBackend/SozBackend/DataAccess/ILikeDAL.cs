using SozBackend.Models;

namespace SozBackend.DataAccess;

public interface ILikeDAL
{
    Like AddLikeToQuote(int userId, int clikeQuoteId);
}