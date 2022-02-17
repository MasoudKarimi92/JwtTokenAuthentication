using System.ComponentModel.DataAnnotations;

namespace SampleJwtToken.Models
{
    public class RegisterModel : LoginModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

    }
}
