#nullable disable
namespace Shared.Fooditem
{
    public class FoodItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal DiscountPercent { get; set; }
        public int RestaurantId { get; set; } // ضروري للربط
        public string RestaurantName { get; set; }
        public string CategoryName { get; set; }
    }
}