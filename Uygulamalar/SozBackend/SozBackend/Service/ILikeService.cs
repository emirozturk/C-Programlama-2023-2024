using SozBackend.Models;

namespace SozBackend.Service;

public interface ILikeService
{
    Like AddLikeToQuote(CLike clike);
}