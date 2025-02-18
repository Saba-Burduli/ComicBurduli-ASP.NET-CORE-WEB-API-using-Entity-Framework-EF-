using System.Runtime.Intrinsics.Arm;

using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace SalesManagementSystem.DAL.Repositories;

//this is IPasswordHasher interface for methods for password 
public interface IPasswordHasher 
{
    Task<string> HashPassword(string password);
    
    //this is for Login
    Task<bool> VerifyPassword(string password, string hashPassword);   
}

public class PasswordHasher : IPasswordHasher
{
    public Task<string> HashPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentNullException(nameof(password)+ " cannot be null or empty");
        }

        //this is for hash password and add in database like that :: ComicSolvency123 to (3y5t2052bv2502388572)
        using (var sha =SHA256.Create())
        {
            var hashPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Task.FromResult(Convert.ToBase64String(hashPassword));
        }
    }

    public async Task<bool> VerifyPassword(string password, string hashedPassword)
    {
        if (password == null) 
            throw new ArgumentNullException(nameof(password)+ " cannot be null or empty");
         
        var inputHashPassword=await HashPassword(password);
        return inputHashPassword == hashedPassword;
        
        
    }
}
