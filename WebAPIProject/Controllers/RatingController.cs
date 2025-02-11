using Microsoft.AspNetCore.Mvc;
using SalesManagementSystem.SERVICE.DTOs;
using SalesManagementSystem.SERVICE.Interfaces;

namespace SalesManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("GetAllRating")]
        public async Task<IActionResult> GetAllRating()
        {
            var result = await _ratingService.GetAllRatingAsync();
            return Ok(result);
        }

        [HttpPost("AddRating")]
        public async Task<IActionResult> AddRating([FromBody] CreateRatingModel model)
        {
            if (ModelState.IsValid)
            {
                await _ratingService.AddRatingAsync(model);
                return StatusCode(200);
            }

            return BadRequest(ModelState);
        }
    }
}
