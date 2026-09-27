using EasyUser.Interfaces;
using EasyUser.Services;

namespace EasyUser;

// summary
// main class
public class EasyUser
{
   public IUserInterface userInterface { get; }
   public PasswordInterface passwordInterface { get; }

   public EasyUser()
   {
      userInterface = new UserService();
      passwordInterface = new PasswordHashService();

   }

   public User CreateUser(string username, string password,string? email,string? phonenumber,int? age)
   {
      return userInterface.CreateUser(username,password,email,phonenumber,age);
   }

   public void DeleteUser()
   {
      userInterface.DeleteUser();
   }

   public User EditUser(User currentUser,string? username, string? password, string? email, string? phonenumber, int? age)
   {
      return userInterface.EditUser(currentUser,username, password, email, phonenumber, age);
   }
}