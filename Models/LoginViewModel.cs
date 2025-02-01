using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
   
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

}
