using System.ComponentModel.DataAnnotations;

namespace AuthWebApi.Models.BindingModel
{
    public class loginBindingModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}