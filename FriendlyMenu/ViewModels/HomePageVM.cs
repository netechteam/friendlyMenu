using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    class HomePageVM: WebPageVM
    {
      public List<DishSummaryVM> FeaturedDishes{ get; set; }
      public List<CategorySummaryVM> Categories { get; set; }
    }
}
