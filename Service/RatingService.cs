using SalesManagementSystem.DAL;
using SalesManagementSystem.DAL.Repositories;
using SalesManagementSystem.DATA.Entites;
using SalesManagementSystem.SERVICE.DTOs;
using SalesManagementSystem.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.SERVICE
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;



                public RatingService(IRatingRepository ratingRepository)
                {
                    _ratingRepository = ratingRepository;
                }


                public async Task<IEnumerable<UpdateRatingModel>> GetAllRatingAsync()
                {
                    var entity = await _ratingRepository.GetAllAsync();
                    var model = (List<UpdateRatingModel>)entity;
                    return model;
                }



                public Task<UpdateRatingModel> GetRatingByIdAsync(int id)
                {
                    throw new NotImplementedException();
                }



                public async Task AddRatingAsync(CreateRatingModel model)
                {
                    var entity = new Rating()
                    {
                        RatingValue = model.RatingValue,
                    };
                
                    await _ratingRepository.AddAsync(entity);
                }




                public Task UpdateRatingAsync(UpdateRatingModel model)
                {
                    throw new NotImplementedException();
                }




                public Task DeleteRatingAsync(int id)
                {
                    throw new NotImplementedException();
                }
    }
}
