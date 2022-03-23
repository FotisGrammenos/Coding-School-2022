using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    [Serializable]
    public class Transaction : Item
    {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }


        public Manager Manager { get; set; }

        public Car Car { get; set; }
        
        public Customer Customer { get; set; }

        public Transaction()
        {
            Manager = new Manager();
            Car = new Car();
            TransactionLines = new List<TransactionLine>();
            Date = DateTime.Now;
        }
    }
}
