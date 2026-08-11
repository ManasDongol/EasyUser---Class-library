using System.Security.Cryptography;
using EasyUser.Interfaces;


namespace EasyUser.Services;
//password hasher
public class PasswordHashService  : PasswordInterface
{
    
    private const int SaltSize = 16; // 128-bit
    private const int HashSize = 32; // 256-bit
    private const int Iterations = 600_000; 
    private  readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA512;
    private const int OutputLength = HashSize + SaltSize;
    
    
    //return type, a tuple of type byte array, byte array
    public  (byte[] hash,byte[] salt) HashPassword(string password)
    {
        byte[] passwordBytes = (Byte[])password.Clone();
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] Hash = Rfc2898DeriveBytes.Pbkdf2(passwordBytes, salt, Iterations, Algorithm,OutputLength);
        return (Hash, salt);
    }
    
    //update existing password
    public  (byte[] hash,byte[] salt) ReHashPassword(string password,byte[] salt)
    {
        byte[] passwordBytes = (Byte[])password.Clone();
        byte[] Hash = Rfc2898DeriveBytes.Pbkdf2(passwordBytes, salt, Iterations, Algorithm,OutputLength);
        return (Hash, salt);
    }

    public  bool CheckPassword(byte[] hash, byte[] salt,string password)
    {
        
        byte[] passwordBytes = (Byte[])password.Clone();
        byte[] newHash = Rfc2898DeriveBytes.Pbkdf2(passwordBytes, salt, Iterations, Algorithm,OutputLength);

        if (newHash == hash)
        {
            return true;
        }

        return false;
    }
    
    public bool changePassword( string newPassword,byte[] salt)
    {
        ReHashPassword(newPassword, salt);
        return true;
    }
}