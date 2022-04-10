using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Model
{
    public class Transaction : BaseEntitie
    {
        public DateTime Date { get; set; }

        public Guid EmplouyeeID { get; set; }

        public Guid CustomerID { get; set; }

        public PayMentMethod PaymentMethod { get; set; }

        public decimal TotalValue { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } 

        public Customer Customer { get; set; }
 
        public Employee Employee { get; set; }
        public Transaction()
        {

        }
    }
}
