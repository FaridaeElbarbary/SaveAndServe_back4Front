namespace Shared.Charity
{
    public record CharityDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string CoverageArea { get; init; } = string.Empty;
        public string RegistrationNo { get; init; } = string.Empty;
        public string Mission { get; init; } = string.Empty;
    }
}
