namespace Shared.Consumer
{
    public record UpdateConsumerDto
    {
        public int? Age { get; init; }
        public string Gender { get; init; }
        public string PreferredPaymentMethod { get; init; }
    }
}
