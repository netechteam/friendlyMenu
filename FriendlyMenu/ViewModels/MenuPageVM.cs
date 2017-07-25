using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class MenuPageVM
    {
        public string MenuTitle { get; set; }
        public List<DishSummaryVM> Dishes { get; set; }
    }
}
