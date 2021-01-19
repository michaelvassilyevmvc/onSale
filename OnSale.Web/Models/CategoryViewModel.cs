using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using OnSale.Common.Enitities;

namespace OnSale.Web.Models
{
    public class CategoryViewModel:Category
    {
        [Display(Name = "Изображение")]
        public IFormFile ImageFile { get; set; }
    }
}
