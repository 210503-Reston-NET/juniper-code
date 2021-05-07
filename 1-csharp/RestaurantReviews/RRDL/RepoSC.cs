using System.Collections.Generic;
using System.Linq;
using RRModels;

namespace RRDL
{
    public class RepoSC : IRepository
    {
        public List<Restaurant> GetAllRestaurants()
        {
            //return static collection of restaurants
            return RRSCStorage.Restaurants;
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            RRSCStorage.Restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return RRSCStorage.Restaurants.FirstOrDefault(resto => resto.Equals(restaurant));
        }
    }
}