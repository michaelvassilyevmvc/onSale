using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Поле {0} является обязательным.")]
        [MaxLength(100, ErrorMessage = "Поле {0} не может содержать более {1} символов.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Поле {0} является обязательным.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        public string Password { get; set; }

        [Display(Name = "Подтверждение пароля")]
        [Required(ErrorMessage = "Поле {0} является обязательным.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
