using System;
using RRModels;
using System.Collections.Generic;
using RRBL;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidationService _validate;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidationService validate)
        {
            _restaurantBL = restaurantBL;
            _validate = validate;
        }
        public void Start()
        {
            bool repeat = true;
            do {
                Console.WriteLine("Welcome to my Restaurant Reviews Menu!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View Restaurants");
                Console.WriteLine("[1] Create a restaurant");
                Console.WriteLine("[2] Go back");
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                    ViewRestaurants();
                        //add a restaurant
                        break;

                    case "1":
                        AddARestaurant();
                        break;

                    case "2":
                        //exit
                        repeat = false;
                        break;

                    default:
                        //invalid input
                        Console.WriteLine("Invalid input");
                    break;
                }
            } while(repeat);
        }

        private void AddARestaurant()
        {
            Console.WriteLine("Enter the details of the restaurant you want to add");
            //I want to make sure that my end user doesn't input nothing
            //Validate input I'm receiving
            string name = _validate.ValidateString("Enter the restaurant name: ");
            string city = _validate.ValidateString("Enter the city where the restaurant is located at");
            string state = _validate.ValidateString("Enter the state where the restaurant is located at");

            Restaurant newRestaurant = new Restaurant(name, city, state);
            _restaurantBL.AddRestaurant(newRestaurant);
        }

        private void ViewRestaurants()
        {
            List<Restaurant> restaurants = _restaurantBL.GetAllRestaurants();
            foreach (Restaurant rest in restaurants)
            {
                Console.WriteLine(rest.ToString());
            }
        }
    }
}