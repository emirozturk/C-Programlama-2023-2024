using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SozBackend.Models;

namespace SozBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private SozDbContext context;

    public UserController(SozDbContext context)
    {
        this.context = context;
    }
    [HttpPost]
    public User AddUser(User newUser)
    {
        context.Users.Add(newUser);
        context.SaveChanges();
        return newUser;
    }

    [HttpGet]
    public List<User> GetUsers()
    {
        return context.Users.ToList();
    }

    [HttpGet("{username}")]
    public IActionResult GetUser(string username)
    {
        try
        {
            var result = context.Users.FirstOrDefault(x => x.Username == username);
            if (result != null)
                return new OkObjectResult(Response<User>.Success(result));
            return new BadRequestObjectResult(Response<User>.Fail("Kullanıcı Bulunamadı"));
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}