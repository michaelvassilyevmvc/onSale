using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Display(Name = "Текущий пароль")]
        [Required(ErrorMessage = "{0} обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        public string OldPassword { get; set; }

        [Display(Name = "Новый пароль")]
        [Required(ErrorMessage = "{0} обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        public string NewPassword { get; set; }

        [Display(Name = "Подтверждение пароля")]
        [Required(ErrorMessage = "{0} обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Поле {0} должно содержать от {2} до {1} символов.")]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}
