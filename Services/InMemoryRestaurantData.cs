using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASP.Models;

namespace HelloASP.Services
{
    public class InMemoryRestaurantData: IRestaurantData
    {
        private List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1,Name = "The Bent Fork"},
                new Restaurant{Id = 2,Name = "Purnima"},
                new Restaurant{Id = 3,Name = "La Mesa"},
                new Restaurant{Id = 4,Name = "New Bombay Palace"},
                new Restaurant{Id = 5,Name = "Hungry Bite"},

            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Id);
        }
        
        
    }
}
