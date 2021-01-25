using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Web.Models
{
    public class LoginViewModel
    {
        
        [Required(ErrorMessage = "Обязательное поле")]
        [EmailAddress]
        [Display(Name = "Имя пользователя")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MinLength(6, ErrorMessage = "{0} Не может содержать менее {1} символов")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
