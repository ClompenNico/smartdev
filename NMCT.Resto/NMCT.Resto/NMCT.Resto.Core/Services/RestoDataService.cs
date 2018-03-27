using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Repositories;

namespace NMCT.Resto.Core.Services
{
    public class RestoDataService : IRestoDataService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;

        //repositories worden automatisch en mbv dependency injection meegegeven via de constructor
        public RestoDataService(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository){
            this._restaurantRepository = restaurantRepository;
            this._reviewRepository = reviewRepository;
        }

        public async Task<List<Restaurant>> GetRestaurants(){
            return await _restaurantRepository.GetRestaurants();
        }

        public async Task<List<Review>> GetReviews(Guid guid)
        {
            return await _reviewRepository.GetReviews(guid);
        }

        public async Task<bool> AddReview(Guid restoId, Review review)
        {
            await _reviewRepository.PostReview(restoId, review);
            return true;
        }


        public async Task<Restaurant> GetRandomRestaurant()
        {
            List<Restaurant> lijst = new List<Restaurant>();
            lijst =  await _restaurantRepository.GetRestaurants();

            Random rnd = new Random();
            int r = rnd.Next(lijst.Count);

            Restaurant randomResto = lijst[r];
            return randomResto;
        }
    }
}
