using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnSale.Web.Data;

namespace OnSale.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetComboCategories()
        {
            List<SelectListItem> list = _context.Categories.Select(t => new SelectListItem
                {
                    Text = t.Name,
                    Value = $"{t.Id}"
                })
                .OrderBy(t => t.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Выберите категорию...]",
                Value = "0"
            });

            return list;
        }
    }
}
