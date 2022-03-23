using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataClasses;

namespace DataLibrary
{
    public class TransactionLine : Item
    {
        public Guid TransactionID { get; set; }
        public Guid ServiceTaskID { get; set; }
        public Guid EngineerID { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; }
        public decimal Price { get; set; }
       
        public ServiceTask ServiceTask { get; set; }
        public Engineer Engineer { get; set; }
        public TransactionLine()
        {
            ServiceTask = new ServiceTask();
            Engineer = new Engineer();
            PricePerHour = 44.5m;
        }

    }
}
