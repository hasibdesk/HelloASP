﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASP.Data;
using HelloASP.Models;

namespace HelloASP.Services
{
    public class SqlRestaurantData: IRestaurantData
    {
        private MyDbContext _context;

        public SqlRestaurantData(MyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Restaurant> GetAll()
        {
           return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
           return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }
    }
}
