using Microsoft.AspNetCore.Identity;
using OnSale.Common.Enitities;
using OnSale.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(20, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Документ")]
        public string Document { get; set; }

        [Display(Name = "Имя")]
        [MaxLength(50, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [MaxLength(50, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string LastName { get; set; }

        [MaxLength(50, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Изображение")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44315/images/noimage.png"
            : $"https://onsale.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Тип пользователя")]
        public UserType UserType { get; set; }

        [Display(Name = "Город")]
        public City City { get; set; }

        [Display(Name = "Полное имя пользователя")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Пользователь")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
