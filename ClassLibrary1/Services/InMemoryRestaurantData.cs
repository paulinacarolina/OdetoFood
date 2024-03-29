﻿using ClassLibrary1.Models;
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
                new Restaurant{ Id = 1, Name = "tacos", Cuisine = CuisineType.Mexican}
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            // creating the false id to the new restaurant 
            restaurant.Id = restaurants.Max(r => r.Id) + 1;


        }
    }
}

