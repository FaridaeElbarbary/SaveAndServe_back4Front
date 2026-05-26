using System.ComponentModel.DataAnnotations;

namespace Shared.AuthenticationDtos
{
    public record LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; }

        [Required]
        public string Password { get; init; }
    }
}
