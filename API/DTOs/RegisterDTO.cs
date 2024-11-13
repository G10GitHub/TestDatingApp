
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string password { get; set; }
    }
}