using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name="Kullanıcı Adı")]
        [Required(ErrorMessage = "Please enter an username!")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Please enter a password!")]
        public string Password { get; set; }
    }
}
