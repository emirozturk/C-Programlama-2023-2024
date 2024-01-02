using SozBackend.DataAccess;
using SozBackend.Models;

namespace SozBackend.Service;

public class LikeService : ILikeService
{
    private ILikeDAL likeDal;
    private IUserService userService;

    public LikeService(ILikeDAL likeDal,IUserService userService)
    {
        this.likeDal = likeDal;
        this.userService = userService;
    }
    public Like AddLikeToQuote(CLike clike)
    {
        var user = userService.GetUser(clike.Username);
        Like like = likeDal.AddLikeToQuote(user.Id, clike.QuoteId);
        return like;
    }
}