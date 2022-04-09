using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction : BaseEntitie
    {
        public DateTime Date { get; set; }

        public Guid EmplouyeeID { get; set; }

        public Guid CustomerID { get; set; }

        public Payment PaymentMethod { get; set; }

        public decimal TotalValue { get; set; }

        public Transaction()
        {

        }
    }
}
