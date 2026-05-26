namespace Shared.Charity
{
    public record CreateCharityDto
    {
        public string CoverageArea { get; init; } = string.Empty;
        public string RegistrationNo { get; init; } = string.Empty;
        public string Mission { get; init; } = string.Empty;
    }
}
