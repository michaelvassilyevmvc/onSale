using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnSale.Common.Enitities;
using OnSale.Web.Models;

namespace OnSale.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();

        IEnumerable<SelectListItem> GetComboCountries();

        IEnumerable<SelectListItem> GetComboDepartments(int countryId);

        IEnumerable<SelectListItem> GetComboCities(int departmentId);

    }
}
