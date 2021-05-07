using System.Collections.Generic;
using RRModels;
using RRDL;

namespace RRBL
{
    /// <summary>
    /// Business Logic class for the restaurant model
    /// </summary>
    public class RestaurantBL : IRestaurantBL
    {
        //BL Classes are in charge of processing/ sanitizing/ further validating data
        //As the name suggests, it's in charge of processing logic.
        //EX. How does the ordering process work in a store app.
        //Any logic that is related to accessing the data stored somewhere, should be relagated to the DL layer
        private IRepository _repo;
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        } 
        public List<Restaurant> GetAllRestaurants()
        {
            return _repo.GetAllRestaurants();
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            return _repo.AddRestaurant(restaurant);
        }
    }
}