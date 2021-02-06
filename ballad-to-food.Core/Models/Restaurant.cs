using ballad_to_food.Core.Enums;

namespace ballad_to_food.Core.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
