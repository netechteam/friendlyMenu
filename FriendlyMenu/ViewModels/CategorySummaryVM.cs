using System.Collections.Generic;

namespace ViewModels
{
  public class CategorySummaryVM
  {
    public int CategoryId { get; set; }
    public int DisplayName { get; set; }
    public List<ImageVM> featuredImage { get; set; }

  }
}