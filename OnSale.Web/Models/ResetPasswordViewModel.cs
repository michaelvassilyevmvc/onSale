using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Web.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [EmailAddress]
        [Display(Name="Имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Подтверждение пароля")]
        public string ConfirmPassword { get; set; }

         [Required(ErrorMessage = "Обязательное поле")]
        public string Token { get; set; }
    }
}
