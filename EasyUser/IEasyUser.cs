using EasyUser.Interfaces;
using EasyUser.Services;

namespace EasyUser;

// summary
// main class
public class IEasyUser
{
   public UserInterface userInterface { get; }
   public PasswordInterface passwordInterface { get; }

   public IEasyUser()
   {
      userInterface = new UserService();
      passwordInterface = new PasswordHashService();

   }
}