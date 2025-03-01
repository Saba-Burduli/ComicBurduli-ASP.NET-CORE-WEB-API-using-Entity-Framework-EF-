using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.DATA;
using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.DATA.Infastructures;

namespace SalesManagementSystem.DAL.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
Task<User> GetUserByEmailAsync(string email);
    Task GetUserWithPersonByIdAsync(int id);
}

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly SalesManagmentSystemDbContext _context;

    public UserRepository(SalesManagmentSystemDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        if (_context == null || _context.Users.Any(u => u.Email == null))
            throw new ArgumentNullException("Database context is null");
        
        return await _context.Users.FirstOrDefaultAsync(u=>u.Email == email);
        
    }

    public async Task<User> GetUserWithPersonByIdAsync(int id)
    {
        return await _context.Users
            .Include(u => u.Person)
            .FirstOrDefaultAsync(u => u.UserId == id);

    }


    //add this +++
    Task<User> IUserRepository.GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
    //add this +++
    Task IUserRepository.GetUserWithPersonByIdAsync(int id)
    {
        return GetUserWithPersonByIdAsync(id);
    }
}


