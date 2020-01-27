using System.ComponentModel.DataAnnotations;
using HelloASP.Models;

namespace HelloASP.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}