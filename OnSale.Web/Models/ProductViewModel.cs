using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnSale.Common.Enitities;
using OnSale.Web.Data.Entities;

namespace OnSale.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Категория")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать категорию.")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int CategoryId { get; set; }
            
        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Изображение")]
        public IFormFile ImageFile { get; set; }

        [RegularExpression(@"^\d+([\.\,]?\d+)?$", ErrorMessage = "Используйте только цифры . или , для вставки десятичных дробей")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name="Цена")]
        [MaxLength(12,ErrorMessage = "Для поля {0} максимальное количество цифр {1}")]
        public string PriceString { get; set; }
    }
}
