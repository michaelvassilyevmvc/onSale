using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
