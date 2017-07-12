using System.Collections.Generic;

namespace DataModels
{
    public class DishIngredientDM 
    {
        public int Id { get; set; }
        public string DishName{ get; set; }
        //public int [] IngredientId { get; set; }
        public List<int> IngredientId { get; set; }
    }
}
