﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class DishSummaryVM
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
        public string Ingredients { get; set; }
        public string ImageUrl { get; set; }
        //todo add three more prices and the flags
    }
}
