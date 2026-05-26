namespace Shared.Charity
{
    public record UpdateCharityDto
    {
        public string? CoverageArea { get; init; }
        public string? RegistrationNo { get; init; }
        public string? Mission { get; init; }
    }
}
