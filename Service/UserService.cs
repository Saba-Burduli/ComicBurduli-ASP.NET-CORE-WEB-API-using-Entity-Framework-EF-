using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SalesManagementSystem.DAL.Repositories;
using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.SERVICE.DTOs.PersonModels;
using SalesManagementSystem.SERVICE.DTOs.UserModels;
using SalesManagementSystem.SERVICE.Interfaces;

namespace SalesManagementSystem.SERVICE
{

    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;




        public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;

        }


        //[GET] GetAll Method (buisness logic)
        public async Task<IEnumerable<UserModel>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(user => new UserModel
            {
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                UserId = user.UserId
            });
            throw new NotImplementedException();
        }


        //[GET] GetAllUsersWithPersonAsync Method (buisness logic)
        public async Task<IEnumerable<UserModel>> GetAllUsersWithPersonAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(user => new UserModel
            {
                UserName = user.UserName,
                Email = user.Email,
                UserId = user.UserId
            });
        }



        //[GET] GetById Method (buisness logic)
        public async Task<UserModel?> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return null;

            }
            return new UserModel
            {
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,

            };


        }




        //[POST] Register Method (buisness logic)
        public async Task<ResponseModel> RegisterUserAsync(RegisterUserModel userModel)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(userModel.Email);
            if (existingUser != null)
            {
                return new ResponseModel { Success = false, Massage = "User already exists" };
            }

            Person newPerson = new Person()
            {
                FirstName = userModel.Person.FirstName,
                LastName = userModel.Person.LastName,
                Address = userModel.Person.Addres,
                Phone = userModel.Person.Phone,
                PersonTypeID = 1

            };

            var newUser = new User
            {
                UserName = userModel.UserName,
                Email = userModel.Email,
                PasswordHash = userModel.Password,
            };
            await _userRepository.AddAsync(newUser);

            return new ResponseModel { Success = true, Massage = "User created successfully!" };
        }



        //[PUT] Update Method (buisness logic)
        public async Task<ResponseModel> UpdateUserAsync(int userId, UpdateUserModel model)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return new ResponseModel { Success = false, Massage = "User Not Found!" };

            if (!string.IsNullOrWhiteSpace(model.UserName))
                user.UserName = model.UserName;

            if (!string.IsNullOrEmpty(model.Password))
            {
                user.PasswordHash = await _passwordHasher.HashPassword(model.Password);
            }

            await _userRepository.UpdateAsync(user);

            return new ResponseModel { Success = true, Massage = "User Profile Updated !!" };

        }

        //[PUT] Login Method (buisness logic)
        public async Task<ResponseModel> LoginUserAsync(LoginModel userModel)
        {
            var user = await _userRepository.GetUserByEmailAsync(userModel.Email);//add email in there +++
            if (user == null)
            {
                return new ResponseModel { Success = false, Massage = "Invalid Operation" };
            }
            return new ResponseModel { Success = true, Massage = "User has logged in !!" };
        }

        //we gonna add this buisness method +++
        public Task<ResponseModel> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }


        //we gonna add this buisness method +++
        public Task<ResponseModel> AssignRoleAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }



        public async Task<UserModel> GetUserWithPersonByIdAsync(int id)
        {
            var user = await _userRepository.GetUserWithPersonByIdAsync(id);

            return new UserModel
            {
                UserId = user.UserId,
                Email = user?.Email,
                UserName = user?.UserName,
                Person = new PersonModel
                {
                    FirstName = user.Person.FirstName,
                    LastName = user.Person.LastName,
                    Addres = user.Person.Address,
                    Phone = user.Person.Phone,
                    PersonTypeID = user.Person.PersonTypeId,
                }
            };

        }
    }
}