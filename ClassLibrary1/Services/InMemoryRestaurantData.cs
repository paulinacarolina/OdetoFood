using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name = "spaggethi", Cuisine = CuisineType.Italian},
                new Restaurant{ Id = 2, Name = "curry ", Cuisine = CuisineType.Indian},
                new Restaurant{ Id = 1, Name = "tacos", Cuisine = CuisineType.Mexican},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}

z