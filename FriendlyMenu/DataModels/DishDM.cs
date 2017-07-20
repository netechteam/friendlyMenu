namespace DataModels
{
    public class DishDM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int MenuCategoryId { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public double PriceLunch { get; set; }
        public double PriceDinner { get; set; }
    }
}
