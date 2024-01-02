using Microsoft.AspNetCore.Mvc;
using SozBackend.Models;
using SozBackend.Service;

namespace SozBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class LikeController
{
    private ILikeService likeService;

    public LikeController(ILikeService likeService)
    {
        this.likeService = likeService;
    }
    [HttpPost]
    public IActionResult AddLikeToQuote(CLike clike)
    {
        try
        {
            Like like = likeService.AddLikeToQuote(clike);
            return new OkObjectResult(Response<Like>.Success(like));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<Like>.Fail(ex.Message));
        }
    }
}