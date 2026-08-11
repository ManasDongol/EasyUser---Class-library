using System.ComponentModel;

namespace EasyUser.Interfaces;

public interface UserInterface
{
    public abstract User CreateUser(
            string username, 
            string password, 
            string? email=null,
            string? phonenumber=null,
            int? age=null, 
            Byte[]? photo=null)
        ;
    public abstract void DeleteUser();
    public abstract void EditUser();
    public abstract void GetUser();
 
 
}