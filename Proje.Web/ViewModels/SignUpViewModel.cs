using System.ComponentModel.DataAnnotations;

namespace Proje.Web.ViewModels
{
    public class SignUpViewModel
    {

        public SignUpViewModel()
        {

        }
        public SignUpViewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }


        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email formatı yanlış")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Şifreniz en az 8 karakter içermelidir")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        [Compare(nameof(Password),ErrorMessage ="Şifre aynı değil")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Şifreniz en az 8 karakter içermelidir")]
        [Required(ErrorMessage = "Şife tekrar alanı boş bırakılamaz")]
        [Display(Name = "Şifre Tekrar :")]
        public string PasswordConfirm { get; set; }
    }
}
