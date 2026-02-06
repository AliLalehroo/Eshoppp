using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class LoginUserDto
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل معتبر نیست")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; } = string.Empty;

        public string? ReturnUrl { get; set; }
    }
}
