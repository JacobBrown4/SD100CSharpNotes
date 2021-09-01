using _14_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _14_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        //C
        [HttpPost]
        public async Task<IHttpActionResult> CreateRating(Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var restaurant = await _context.Restaurants.FindAsync(rating.RestaurantId);
            if(restaurant == null)
            {
                return BadRequest($"The restaurant with an Id of {rating.RestaurantId} does not exist");
            }

            _context.Ratings.Add(rating);
            if(await _context.SaveChangesAsync() == 1)
            {
                return Ok($"You successfully rated {restaurant.Name}!");
            }

            return InternalServerError();
        }
        //R
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Rating> ratings = await _context.Ratings.ToListAsync();
            return Ok(ratings);
        }
        //Rid
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Rating rating = await _context.Ratings.FirstOrDefaultAsync(r => r.Id == id);

            if(rating != null)
            {
                return Ok(rating);
            }
            return NotFound();

        }
        //U
        //D

    }
}
