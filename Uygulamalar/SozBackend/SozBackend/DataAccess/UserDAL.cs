using Microsoft.EntityFrameworkCore;
using SozBackend.Models;

namespace SozBackend.DataAccess;

public class UserDAL:IUserDAL
{
    private SozDbContext context;

    public UserDAL(SozDbContext context)
    {
        this.context = context;
    }
    public User GetUser(string username)
    {
        return context.Users
            .Include(x=>x.Likes)
            .Include(x=>x.Quotes)
            .FirstOrDefault(x => x.Username == username);
    }

    public User AddUser(User newUser)
    {
        context.Users.Add(newUser);
        context.SaveChanges();
        return newUser;
    }

    public List<User> GetUsers()
    {
        return context.Users.ToList();
    }

    public User DeleteUser(User result)
    {
        context.Users.Remove(result);
        context.SaveChanges();
        return result;
    }

    public User UpdateUser(User result)
    {
        context.Users.Update(result);
        context.SaveChanges();
        return result;
    }
}