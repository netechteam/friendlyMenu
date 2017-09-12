using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace ViewModels
{
    public class CategoryPageVM
    {
        public string CategoryName { get; set; }
        //public string Description { get; set; }
        //public string Price { get; set; }
        //public string Ingredients { get; set; }
        //public string ImageUrl { get; set; }
        public List<DishSummaryVM> Dishes { get; set; }
    }
}
