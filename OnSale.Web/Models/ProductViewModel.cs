using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnSale.Common.Enitities;

namespace OnSale.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Категория")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать категорию.")]
        [Required]
        public int CategoryId { get; set; }
            
        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Изображение")]
        public IFormFile ImageFile { get; set; }
    }
}
