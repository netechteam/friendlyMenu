using System.Collections.Generic;

namespace DataModels
{
    public class DishIngredientArrayDM 
    {
        public int Id { get; set; }
        public string DishName{ get; set; }
        public int [] IngredientId { get; set; }
    }
}
