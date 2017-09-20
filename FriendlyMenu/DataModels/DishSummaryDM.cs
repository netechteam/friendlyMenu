using System.Collections.Generic;

namespace DataModels
{
    public class DishSummaryDM
    {
        public int DishId { get; set; }
        //public int CategoryId { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public double BreakfastPrice { get; set; }
        public double LunchPrice { get; set; }
        public double ComboPrice { get; set; }
        public double DinnerPrice { get; set; }
        public bool IsBreakfast { get; set; }
        public bool IsLunch { get; set; }
        public bool IsCombo { get; set; }
        public bool IsSpicy { get; set; }
        public string ImageUrl { get; set; } // todo this need to be a list
        public List<IngredientDM> Ingredients { get; set; } 
    }
}
