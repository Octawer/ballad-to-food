using System.Collections.Generic;
using ballad_to_food.Core.Models;
using ballad_to_food.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ballad_to_food.Pages
{
    public class RestaurantsModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public RestaurantsModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Restaurants = restaurantData.GetAll();
        }
    }
}
