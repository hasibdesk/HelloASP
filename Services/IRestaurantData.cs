using System.Collections;
using System.Collections.Generic;
using HelloASP.Models;

namespace HelloASP.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}