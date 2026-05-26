using System.ComponentModel.DataAnnotations;

namespace Shared.Basket
{
    public record BasketItemDto
    {
        public int Id { get; init; }
        public string ProductName { get; init; }

        [Range(1, double.MaxValue)]
        public decimal Price { get; init; }

        [Range(1, 98)]
        public int quantity { get; init; }
    }

}
