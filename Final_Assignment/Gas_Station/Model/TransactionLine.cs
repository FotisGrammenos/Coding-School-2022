using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransactionLine : BaseEntitie
    {
        public Guid TransactionID { get; set; }

        public Guid ItemID { get; set; }

        public decimal Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal TotalValue { get; set; }

        public TransactionLine()
        {

        }
    }
}
