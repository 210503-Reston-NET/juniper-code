using System.Collections.Generic;
using RRModels;
using RRDL;

namespace RRBL
{
    public interface IRestaurantBL
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);
    }
}