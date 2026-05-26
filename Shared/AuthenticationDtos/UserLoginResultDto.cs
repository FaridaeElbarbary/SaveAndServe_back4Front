namespace Shared.AuthenticationDtos
{
    public record UserLoginResultDto(string DisplayName, string Email, string Token, string role, string UserId)
    {
    }
}