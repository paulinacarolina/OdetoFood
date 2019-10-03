using ClassLibrary1.Models;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OldToFoodWeb.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData db;
        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
          
            return View();
        }

        
        //creating the function which creates the restaurant
        [HttpPost] //specifying it only reacts on a post method
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant )
        {
            if (String.IsNullOrEmpty(restaurant.Name))
            {
                ModelState.AddModelError(nameof(restaurant.Name), "The name is required");
            }
            if (ModelState.IsValid)
            {
                db.Add(restaurant);//adding a resta
               
            }
            return View();
        }

    }
}