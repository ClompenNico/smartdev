using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Core.Services
{
    public interface IRestoDataService
    {
        Task<List<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRandomRestaurants();
        Task<List<Review>> GetReviews(Guid restoId);
        Task<bool> AddReview(Guid restoId, Review review);

    }
}
