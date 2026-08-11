using EasyUser.Interfaces;

namespace EasyUser;

// summary
// main class
public interface EasyUser
{
   UserInterface userInterface { get; }
   PasswordInterface passwordInterface { get; }
}