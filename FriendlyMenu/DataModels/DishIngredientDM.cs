using System.Collections.Generic;

namespace DataModels
{
    public class DishIngredientDM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string DishName { get; set; }
        public int[] IngredientIds { get; set; }

    }
}
