using SalesManagementSystem.DATA;
using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.DATA.Infastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Repositories
{
  public interface IRoleRepository : IBaseRepository<Role>
    {
        
    }

    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly SalesManagmentSystemDbContext _context;

        public RoleRepository(SalesManagmentSystemDbContext context):base(context)
        {
            context = _context;
        }
    }
}
