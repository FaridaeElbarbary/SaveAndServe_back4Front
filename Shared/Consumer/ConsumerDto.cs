namespace Shared.Consumer
{
    public record ConsumerDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
        public string Gender { get; init; }
        public string PreferredPaymentMethod { get; init; }
    }
}
