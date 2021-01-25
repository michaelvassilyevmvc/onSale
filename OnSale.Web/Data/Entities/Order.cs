using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnSale.Common.Enitities;
using OnSale.Common.Enums;

namespace OnSale.Web.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Display(Name = "Пользователь")]
        public User User { get; set; }

        public OrderStatus OrderStatus { get; set; }

        [Display(Name = "Дата отправления")]
        public DateTime? DateSent { get; set; }

        [Display(Name = "Дата подтверждения")]
        public DateTime? DateConfirmed { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public int Lines => OrderDetails == null ? 0 : OrderDetails.Count;

        public float Quantity => OrderDetails == null ? 0 : OrderDetails.Sum(od => od.Quantity);

        public decimal Value => OrderDetails == null ? 0 : OrderDetails.Sum(od => od.Value);
    }
}
