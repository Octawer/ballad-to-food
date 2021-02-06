using ballad_to_food.Core.Models;
using System.Collections.Generic;

namespace ballad_to_food.Data.Interfaces
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
