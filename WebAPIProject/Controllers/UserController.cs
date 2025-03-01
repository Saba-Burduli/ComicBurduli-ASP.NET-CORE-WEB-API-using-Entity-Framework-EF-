
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SalesManagementSystem.SERVICE.DTOs.UserModels;
using SalesManagementSystem.SERVICE.Interfaces;
 

namespace SalesManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       private readonly IUserService _userService;

       public UserController(IUserService userService)
       {
            _userService = userService;
       }

       [HttpGet("GetAllUsersWithPerson")]
       public async Task<IEnumerable<UserModel>> GetAllUsersWithPerson()
       {
           return await _userService.GetAllUsersWithPersonAsync();
       }
       //api/user/register
       [HttpPost("Register")]
       public async Task<IActionResult> RegisterUserAsync([FromBody] RegisterUserModel userModel)
       {
           if (ModelState.IsValid)
           {
               var result =await _userService.RegisterUserAsync(userModel);
               if (!result.Success)
                   return BadRequest(result.Massage = "Bad Request");
               
               return Ok(result);
              
           }
           return BadRequest();
       }

        [HttpGet("GetUserWithPersonBtId/{id}")]
        public async Task<UserModel> GetUserWithPersonByIdAsync(int id)
        {
            return await _userService.GetUserWithPersonByIdAsync(id);
        }

        [HttpPut("Login")]
        public async Task<IActionResult> LoginUserAsync(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);
                if (!result.Success)
                {
                    return BadRequest(result.Massage == "Bad Request !");

                }
                return Ok(result);
            }
            return BadRequest();
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateUserAsync([FromQuery] int userId, [FromBody] UpdateUserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.UpdateUserAsync(userId,model);
                if (!result.Success)
                {
                    return BadRequest(result.Massage);
                }
                return Ok(result);
            }
            return BadRequest();
        }



    }
}
