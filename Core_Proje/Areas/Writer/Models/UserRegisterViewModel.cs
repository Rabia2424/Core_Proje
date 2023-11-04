using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter an name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an surname!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter an imageUrl!")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Please enter an username!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter a password!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter the password again!")]
        [Compare("Password", ErrorMessage = "Passwords are not matched!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter an email!")]
        public string Mail { get; set; }
    }
}
