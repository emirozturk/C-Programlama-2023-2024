using SozBackend.Models;

namespace SozBackend.DataAccess;

public interface IUserDAL
{
    User? GetUser(string newUserUsername);
    User AddUser(User newUser);
    List<User> GetUsers();
    User DeleteUser(User result);
    User UpdateUser(User result);
}