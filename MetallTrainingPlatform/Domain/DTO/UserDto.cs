using System.ComponentModel.DataAnnotations;

namespace MetallTrainingPlatform.Domain.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
