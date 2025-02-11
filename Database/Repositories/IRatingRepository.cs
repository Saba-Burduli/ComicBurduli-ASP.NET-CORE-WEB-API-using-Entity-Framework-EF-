using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.DATA.Infastructures;
using SalesManagementSystem.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Repositories
{
    public interface IRatingRepository : IBaseRepository<Rating>
    {


    }

    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        private readonly SalesManagmentSystemDbContext _context;
        public RatingRepository(SalesManagmentSystemDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
