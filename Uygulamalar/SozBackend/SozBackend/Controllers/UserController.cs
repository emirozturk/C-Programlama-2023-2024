using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SozBackend.Models;
using SozBackend.Models.ReturnModels;
using SozBackend.Service;

namespace SozBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private IUserService userService;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly IConfiguration configuration;
    public UserController(IUserService userService,IConfiguration configuration,IHttpContextAccessor httpContextAccessor)
    {
        this.userService = userService;
        this.configuration = configuration;
        this.httpContextAccessor = httpContextAccessor;
    }
    [HttpPost]
    [Authorize]
    public IActionResult AddUser(User newUser)
    {
        try
        {
            User user = userService.AddUser(newUser);
            return new OkObjectResult(Response<RUser>.Success(new RUser(user)));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<RUser>.Fail(ex.Message));
        }
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetUsers()
    {
        var username = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if(username != "emirozturk")
            return new BadRequestObjectResult(Response<List<RUser>>.Fail("Bu alana yalnızca EMİR ÖZTÜRK erişebilir."));
        try
        {
            List<User> userList = userService.GetUsers();
            var ruserList = userList.Select(x => new RUser(x)).ToList();
            return new OkObjectResult(Response<List<RUser>>.Success(ruserList));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<List<RUser>>.Fail(ex.Message));
        }
    }

    [HttpGet("{username}")]
    [Authorize]
    public IActionResult GetUser(string username)
    {
        try
        {
            User user = userService.GetUser(username);
            return new OkObjectResult(Response<RUser>.Success(new RUser(user)));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<RUser>.Fail(ex.Message));
        }
    }

    [HttpDelete("{username}")]
    [Authorize]
    public IActionResult DeleteUser(string username)
    {
        try
        {
            User response = userService.DeleteUser(username);
            return new OkObjectResult(Response<RUser>.Success(new RUser(response)));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<RUser>.Fail(e.Message));
        }
    }
    [HttpPut("{username}")]
    [Authorize]
    public IActionResult UpdateUser(User user,string username)
    {
        try
        {
            User updatedUser = userService.UpdateUser(username, user);
            return new OkObjectResult(Response<RUser>.Success(new RUser(updatedUser)));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<RUser>.Fail(e.Message));
        }
    }

    [HttpPost("/CreateToken")]
    public IActionResult CreateToken(User user)
    {
        var found = userService.GetUser(user.Username);
        if (found == null)
            return new BadRequestObjectResult(Response<User>.Fail("User not found."));
        if(found.Password != user.Password)
            return new BadRequestObjectResult(Response<User>.Fail("Wrong password."));
        return new OkObjectResult(Security.CreateToken(user, configuration));
    }
}