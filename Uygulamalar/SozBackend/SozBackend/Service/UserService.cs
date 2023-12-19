using SozBackend.DataAccess;
using SozBackend.Models;

namespace SozBackend.Service;

public class UserService : IUserService
{
    private IUserDAL userDal;

    public UserService(IUserDAL userDal)
    {
        this.userDal = userDal;
    }
    public User AddUser(User newUser)
    {
        var result = userDal.GetUser(newUser.Username);
        if (result == null)
            return userDal.AddUser(newUser);
        throw new Exception("User Exists");
    }

    public List<User> GetUsers()
    {
        List<User> users = userDal.GetUsers();
        if (users.Count > 0)
            return users;
        else
            throw new Exception("No users found");
    }

    public User GetUser(string username)
    {
        var result=userDal.GetUser(username);
        if (result == null)
            throw new Exception("User not found");
        return result;
    }

    public User DeleteUser(string username)
    {
        var result=userDal.GetUser(username);
        if (result == null)
            throw new Exception("User not found");
        result = userDal.DeleteUser(result);
        return result;
    }

    public User UpdateUser(string username, User user)
    {
        var result = userDal.GetUser(username);
        if (result == null)
            throw new Exception("User not found");
        result.Username = user.Username;
        result.Password = user.Password;
        result = userDal.UpdateUser(result);
        return result;
    }
}