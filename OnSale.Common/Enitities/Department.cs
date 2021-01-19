using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OnSale.Common.Enitities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }

        [DisplayName("Количество городов")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }

    }
}
