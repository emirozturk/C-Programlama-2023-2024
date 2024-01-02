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
    public UserController(IUserService userService)
    {
        this.userService = userService;
    }
    [HttpPost]
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
    public IActionResult GetUsers()
    {
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
}