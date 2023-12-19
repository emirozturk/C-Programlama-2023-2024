using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SozBackend.Models;
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
            return new OkObjectResult(Response<User>.Success(user));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<List<User>>.Fail(ex.Message));
        }
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        try
        {
            List<User> userList = userService.GetUsers();
            return new OkObjectResult(Response<List<User>>.Success(userList));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<List<User>>.Fail(ex.Message));
        }
    }

    [HttpGet("{username}")]
    public IActionResult GetUser(string username)
    {
        try
        {
            User user = userService.GetUser(username);
            return new OkObjectResult(Response<User>.Success(user));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(Response<User>.Fail(ex.Message));
        }
    }

    [HttpDelete("{username}")]
    public IActionResult DeleteUser(string username)
    {
        try
        {
            User response = userService.DeleteUser(username);
            return new OkObjectResult(Response<User>.Success(response));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<User>.Fail(e.Message));
        }
    }
    [HttpPut("{username}")]
    public IActionResult UpdateUser(User user,string username)
    {
        try
        {
            User updatedUser = userService.UpdateUser(username, user);
            return new OkObjectResult(Response<User>.Success(updatedUser));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<User>.Fail(e.Message));
        }
    }
}