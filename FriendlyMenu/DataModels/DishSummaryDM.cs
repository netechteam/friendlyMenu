using System.Collections.Generic;

namespace DataModels
{
    public class DishSummaryDM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public double PriceBreakfast { get; set; }
        public double PriceLunch { get; set; }
        public double PriceCombo { get; set; }
        public double PriceDinner { get; set; }
        public bool IsBreakfast { get; set; }
        public bool IsLunch { get; set; }
        public bool IsCombo { get; set; }
        public bool IsSpicy { get; set; }
        public List<IngredientDM> Ingredients { get; set; } 
    }
}
