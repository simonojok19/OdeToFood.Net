using OdeToFood.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
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
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;

        }
    }
}
