using System.Text;

namespace EasyUser.Services;

public static class ChangePasswordService
{
    public static bool changePassword( string newPassword,byte[] salt)
    {
        PasswordHashService.ReHashPassword(newPassword, salt);
        return true;
    }
    
}