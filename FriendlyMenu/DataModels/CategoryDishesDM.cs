using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class CategoryDishesDM
    {
        public List<DishSummaryDM> DishSummaries { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
