using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Core.Services
{
    public class RestoDataService : IRestoDataService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;

        public RestoDataService(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            this._restaurantRepository = restaurantRepository;
            this._reviewRepository = reviewRepository;
        }

        public async Task<bool> AddReview(Guid restoId, Review review)
        {
            await _reviewRepository.PostReview(restoId, review);
            return true;
        }

        public async Task<Restaurant> GetRandomRestaurants()
        {
            List<Restaurant> restoList = await _restaurantRepository.GetRestaurants();
            Random rnd = new Random();
            int random = rnd.Next(1, restoList.Count);
            Restaurant randomResto = restoList[random];
            return randomResto;
        }

        public async Task<List<Restaurant>> GetRestaurants()
        {
            return await _restaurantRepository.GetRestaurants();
        }

        public async Task<List<Review>> GetReviews(Guid restoId)
        {
            return await _reviewRepository.GetReviews(restoId);
        }
    }
}
