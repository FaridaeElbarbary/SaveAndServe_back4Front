namespace Shared.AuthenticationDtos
{
    public record UserRegisterResultDto(string DisplayName, string Email, string Token, string role, string NationalId,
        string VehicleType, string VehicleNumber, string Zone,
        string WorkHours, string RegistrationNo, string OrganizationName, string CuisineType)
    {


    }
}
