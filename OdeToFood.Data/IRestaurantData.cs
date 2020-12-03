using OdeToFood.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        public Restaurant GetById(int id);
    }

    public class InMemoryRestuarantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestuarantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Scott's Pizza",
                    Location = "Maryland",
                    Cuisine = CuisineType.Indian
                },

                new Restaurant
                {
                    Id = 2,
                    Name = "Cafe Javas",
                    Location = "Kampala Uganda",
                    Cuisine = CuisineType.Mexican
                },

                new Restaurant
                {
                    Id = 3,
                    Name = "KFC Lugogo",
                    Location = "Kampala Uganda",
                    Cuisine = CuisineType.Indian
                }
            };
        }
        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;

        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(restaurants => restaurants.Id == id);
        }
    }
}
