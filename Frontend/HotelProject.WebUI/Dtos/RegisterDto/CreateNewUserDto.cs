using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail alanı gereklidir")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
