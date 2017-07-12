using System.Collections.Generic;

namespace ViewModels
{
    public class DishIngredientVM 
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        //public string [] IngredientId { get; set; }
        public List<int> IngredientId { get; set; }

    }
}
