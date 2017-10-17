using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class CategorySummaryDM
    {
      public int CategoryId { get; set; }
      public int DisplayName { get; set; }
      public List<ImageDM> featuredImage { get; set; }
  }
}
