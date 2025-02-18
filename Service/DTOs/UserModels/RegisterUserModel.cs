using Microsoft.VisualBasic;
using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.SERVICE.DTOs.PersonModels;

namespace SalesManagementSystem.SERVICE.DTOs.UserModels;

public class RegisterUserModel
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    
    public DateTime RegistrationDate { get; set; } = DateTime.Now;
    
    public PersonModel? Person { get; set; }
    
}