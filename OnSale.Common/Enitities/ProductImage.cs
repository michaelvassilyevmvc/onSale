using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Enitities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Изображение")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Изображение")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalesomik.azurewebsites.net/images/noimage.png"
            : $"https://myonsale.blob.core.windows.net/products/{ImageId}";
    }
}
