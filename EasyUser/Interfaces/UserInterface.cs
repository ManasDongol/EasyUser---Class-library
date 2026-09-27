using System.ComponentModel;

namespace EasyUser.Interfaces;

public interface IUserInterface
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
    public abstract User EditUser(
        User currentUser,
        string? username, 
        string? password, 
        string? email=null,
        string? phonenumber=null,
        int? age=null, 
        Byte[]? photo=null
        
        );
    public abstract void GetUser();
 
 
}