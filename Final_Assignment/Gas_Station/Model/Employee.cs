using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Model
{
    public class Employee : BaseEntitie
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime HireDateStart { get; set; }

        public DateTime HireDateEnd { get; set; }
        
        public decimal  SallaryPerMonth { get; set; }

        public EmployeeType Role { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Employee()
        {

        }
    }
}
