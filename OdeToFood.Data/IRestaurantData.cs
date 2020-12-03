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
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        int Commit();
        Restaurant Add(Restaurant newRestaurant);
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

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(restaurant => restaurant.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = restaurants.Max(restaurant => restaurant.Id) + 1;
            restaurants.Add(newRestaurant);
            return newRestaurant;
        }
    }
}
