using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class DishVM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int MenuCategoryId { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public double PriceBreakfast { get; set; }
        public double PriceLunch { get; set; }
        public double PriceCombo { get; set; }
        public double PriceDinner { get; set; }
        public double IsBreakfast { get; set; }
        public double IsLunch { get; set; }
        public double IsCombo { get; set; }
        public double IsSpicy { get; set; }
        public List<IngredientVM> Ingredients { get; set; }
    }
}
