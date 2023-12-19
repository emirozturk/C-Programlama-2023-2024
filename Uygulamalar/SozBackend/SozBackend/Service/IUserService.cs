using SozBackend.Models;

namespace SozBackend.Service;

public interface IUserService
{
    User AddUser(User user);
    List<User> GetUsers();
    User GetUser(string username);
    User DeleteUser(string username);
    User UpdateUser(string username, User user);
}