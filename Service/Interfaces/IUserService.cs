using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.SERVICE.DTOs.UserModels;

namespace SalesManagementSystem.SERVICE.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserModel>> GetAllUsersAsync();
    Task<UserModel?> GetUserByIdAsync(int id); 
    Task<ResponseModel> RegisterUserAsync(ResponseModel userModel);
    Task<ResponseModel> UpdateUserAsync(UpdateUserModel userModel);    
    Task<ResponseModel> DeleteUserAsync(int id);
    Task<ResponseModel> LoginUserAsync(LoginModel userModel);
    Task<ResponseModel> AssignRoleAsync(int userId, int roleId);
    
    
    
    
}