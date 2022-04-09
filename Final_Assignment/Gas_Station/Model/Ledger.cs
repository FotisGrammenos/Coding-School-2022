using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ledger
    {
        public Guid Year { get; set; }

        public Guid Month { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal TotalValue { get; set; }

        public Ledger()
        {

        }
    }
}
