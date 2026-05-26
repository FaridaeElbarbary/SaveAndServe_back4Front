namespace Shared.Delivery
{
    public record UpdateDeliveryPartnerDto
    {
        public string? AvailabilityStatus { get; init; }
        public string? VehicleType { get; init; }
        public string? VehicleNo { get; init; }
        public string? CurrentLocation { get; init; }
    }
}
