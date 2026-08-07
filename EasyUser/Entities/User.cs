using System.ComponentModel.DataAnnotations;

namespace EasyUser;


// summary
// primary user class with user specific properties
// Only Id, Username, password is required
// other properties are nullable to ensure flexibility when storing user details

public class User
{
    public Guid Id { get;  } = Guid.NewGuid();
    public string UserName { get; set; } = "";
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    [EmailAddress]
    public string? Email { get; set; }
    [Phone]
    public string? Phone { get; set; }
   
    public int? Age { get; set; }
    
    public byte[]? Photo { get; set; }
    
    //removed setter to only allow hash and salt to be set during user creation
    //and only accessed for logins 
    public byte[] PasswordHash { get; } = [];
    public byte[]? PasswordSalt { get;  }
    
    
    
}