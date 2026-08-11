using EasyUser.Interfaces;

namespace EasyUser.Services;

public class UserService : UserInterface
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

    public void EditUser()
    {
    }

    public void GetUser()
    {
        
    }
}