using ballad_to_food.Core.Enums;
using ballad_to_food.Core.Models;
using ballad_to_food.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ballad_to_food.Data.DataServices
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { ID = 1, Name = "The First and Foremost", Location = "Reunion", Cuisine = Cuisine.French },
                new Restaurant { ID = 2, Name = "Timmy Tommy", Location = "Tijuana", Cuisine = Cuisine.Mexican },
                new Restaurant { ID = 3, Name = "Jimmy Eat World", Location = "Seattle", Cuisine = Cuisine.Italian },
                new Restaurant { ID = 4, Name = "La Saciedad Secreta", Location = "Burgos", Cuisine = Cuisine.Spanish },
                new Restaurant { ID = 5, Name = "Outsiders", Location = "Kyoto", Cuisine = Cuisine.Japanese },
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.ID);
        }
    }
}
