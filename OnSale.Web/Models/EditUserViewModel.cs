using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MaxLength(20, ErrorMessage = "Для поля {0} максимальное количество цифр {1}")]
        [Display(Name = "Документ")]
        public string Document { get; set; }

        [Display(Name = "Имя")]
        [MaxLength(50, ErrorMessage = "Для поля {0} максимальное количество символов {1}")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [MaxLength(50, ErrorMessage = "Для поля {0} максимальное количество символов {1}")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "Для поля {0} максимальное количество символов {1}")]
        public string Address { get; set; }

        [Display(Name = "Номер телефона")]
        [MaxLength(20, ErrorMessage = "Для поля {0} максимальное количество цифр {1}")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Изображение")]
        public Guid ImageId { get; set; }

        [Display(Name = "Изображение")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalesomik.azurewebsites.net/images/noimage.png"
            : $"https://myonsale.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Изображение")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Страна")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать страну.")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Отделение")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать отделение.")]
        public int DepartmentId { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Город")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать город.")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}
