using EasyUser.Interfaces;

namespace EasyUser.Services;

public class UserService : IUserInterface
{
    public User CreateUser(string username, string password, string? email,string? phonenumber,int? age, Byte[]? photo)
    {
        User user = new User()
        {
            UserName = username,
            Phone = phonenumber ?? null,
            Email = email ?? null,
            Age = age ?? 0,
            Photo = photo ?? null

        };

        return user;
    }

    public void DeleteUser()
    {
    }

    public void GetUser()
    {
    }

    public User EditUser(User currentUser,string? username, string? password, string? email,string? phonenumber,int? age, Byte[]? photo)
    {
       currentUser.UserName = username??currentUser.UserName;
       currentUser.Email = email??currentUser.Email;
       currentUser.Phone = phonenumber??currentUser.Phone;  
       currentUser.Age = age??currentUser.Age;
       
       return currentUser;
    
    }
}