using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant> {
                new Restaurant(){Id = 1, Name = "Jayesh's Dhaba",Cuisine = CuisineType.Indian},
                new Restaurant(){Id = 2, Name = "PS Delicacies",Cuisine = CuisineType.Italian},
                new Restaurant(){Id = 3, Name = "Sheru Chinese",Cuisine = CuisineType.Chinese},
                new Restaurant(){Id = 4, Name = "Egg Bite",Cuisine = CuisineType.Korean}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
        }
    }
}
