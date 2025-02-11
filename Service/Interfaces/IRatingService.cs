using SalesManagementSystem.SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.SERVICE.Interfaces
{
    public interface IRatingService
    {

        Task<IEnumerable<UpdateRatingModel>> GetAllRatingAsync();
        Task<UpdateRatingModel> GetRatingByIdAsync(int id);
        Task AddRatingAsync(CreateRatingModel model);
        Task UpdateRatingAsync(UpdateRatingModel model);
        Task DeleteRatingAsync(int id);

    }
}
