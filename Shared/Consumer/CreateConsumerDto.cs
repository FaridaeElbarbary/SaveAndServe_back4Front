using System.ComponentModel.DataAnnotations;

namespace Shared.Consumer
{
    public record CreateConsumerDto
    {

        public string Name { get; init; }
        [Required]
        [Range(18, 120)]
        public int Age { get; init; }

        [Required]
        public string Gender { get; init; } // Male/Female/Other

        public string PreferredPaymentMethod { get; init; } // Cash/Card/Wallet
    }
}
