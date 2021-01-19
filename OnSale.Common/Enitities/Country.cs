using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Common.Enitities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage = "{0} Не может содержать более {1} символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }

        [Display(Name = "Количество отделений")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
    }
}
