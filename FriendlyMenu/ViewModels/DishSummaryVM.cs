using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class DishSummaryVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }
        public string ImageUrl { get; set; }

        //todo add three more prices and the flags
    }
}
