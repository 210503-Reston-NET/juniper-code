using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using RRModels;

namespace RRDL
{
    public class RepoFile : IRepository
    {
        private const string filePath = "../RRDL/Restaurants.json";
        private string jsonString;
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            List<Restaurant> restauransFromFile = GetAllRestaurants();
            restauransFromFile.Add(restaurant);
            jsonString = JsonSerializer.Serialize(restauransFromFile);
            File.WriteAllText(filePath, jsonString);
            return restaurant;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Restaurant>();
            }
            return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return GetAllRestaurants().FirstOrDefault(resto => resto.Equals(restaurant));
        }
    }
}