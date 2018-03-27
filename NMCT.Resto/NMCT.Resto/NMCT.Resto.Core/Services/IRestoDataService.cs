using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMCT.Resto.Core.Model;

namespace NMCT.Resto.Core.Services
{
    public interface IRestoDataService
    {
        Task<List<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRandomRestaurant();
        Task<List<Review>> GetReviews(Guid restoId);
        Task<bool> AddReview(Guid restoId, Review review);
    }
}
