using OldToFoodWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OldToFoodWeb.Controllers
{
    public class GreetingsController : Controller
    {
        // GET: Greetings
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
            
        }
    }
}