using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using RRModels;

namespace RRDL
{
    public class RepoFile : IRepository
    {
        private const string filePath = "../RRDL/Restaurants.xml";
        // private string jsonString;
        private string xmlString;
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            List<Restaurant> restaurantsFromFile = GetAllRestaurants();
            restaurantsFromFile.Add(restaurant);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
            using (Stream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode);
                serializer.Serialize(writer, restaurantsFromFile);
                writer.Close();
            }
            // jsonString = JsonSerializer.Serialize(restaurantsFromFile);
            // File.WriteAllText(filePath, jsonString);

            return restaurant;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            try
            {
                xmlString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Restaurant>();
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
            using (Stream reader = new FileStream(filePath, FileMode.Open))
            {
                return (List<Restaurant>)serializer.Deserialize(reader);
            }
            // return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return GetAllRestaurants().FirstOrDefault(resto => resto.Equals(restaurant));
        }
    }
}