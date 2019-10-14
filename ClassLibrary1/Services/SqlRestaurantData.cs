using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);//adding a new restaurant
            db.SaveChanges();
        }
        public Restaurant Get(int Id)
        {
           
            return db.Restaurants.FirstOrDefault(r => r.Id == Id);
        }
        void IRestaurantData.Add(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        Restaurant IRestaurantData.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return from r in db.Restaurants
                   orderby r.Name
                   select r;
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant); //object already existing in the dbb
            entry.State = System.Data.Entity.EntityState.Modified;// the register has been modified 
            db.SaveChanges();
        }
    }
}
