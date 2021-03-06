﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using OnSale.Common.Enitities;

namespace OnSale.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name="Описание")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [DisplayName("Действующее")]
        public bool IsActive { get; set; }

        [DisplayName("Звездное")]
        public bool IsStarred { get; set; }

        public Category Category { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        [DisplayName("Количество изображений продуктов")]
        public int ProductImagesNumber => ProductImages == null ? 0 : ProductImages.Count;

        //TODO: Pending to put the correct paths
        [Display(Name = "Изображение")]
        public string ImageFullPath => ProductImages == null || ProductImages.Count == 0
            ? $"https://onsalesomik.azurewebsites.net/images/noimage.png"
            : ProductImages.FirstOrDefault().ImageFullPath;

        public ICollection<Qualification> Qualifications { get; set; }

        [DisplayName("Product Qualifications")]
        public int ProductQualifications => Qualifications == null ? 0 : Qualifications.Count;

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float Qualification => Qualifications == null || Qualifications.Count == 0 ? 0 : Qualifications.Average(q => q.Score);
    }
}
