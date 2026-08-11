namespace EasyUser.Interfaces;

public interface PasswordInterface
{
    public abstract (byte[] hash, byte[] salt) HashPassword(string password);
    public abstract (byte[] hash, byte[] salt) ReHashPassword(string password, byte[] salt);
    public abstract bool CheckPassword(byte[] hash, byte[] salt, string password);
    public abstract bool changePassword(string newPassword, byte[] salt);
}