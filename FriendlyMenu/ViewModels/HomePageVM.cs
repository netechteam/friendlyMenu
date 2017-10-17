using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class HomePageVM: WebPageVM
    {
      public List<DishSummaryVM> FeaturedDishes{ get; set; }
      public List<CategorySummaryVM> Categories { get; set; }
    }
}
