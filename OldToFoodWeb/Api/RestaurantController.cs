using ClassLibrary1.Models;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace OldToFoodWeb
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantData db;
        public RestaurantController(IRestaurantData db){
            this.db = db;
            }
        public IEnumerable<Restaurant> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
