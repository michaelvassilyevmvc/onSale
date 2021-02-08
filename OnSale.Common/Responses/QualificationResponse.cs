using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Common.Responses
{
    public class QualificationResponse
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float Score { get; set; }

        public string Remarks { get; set; }
    }
}
