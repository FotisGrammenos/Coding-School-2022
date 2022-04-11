using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.Shared
{
    public class EmployeeListViewModel
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }

        public string Name { get; set; }

        public DateTime HireDateStart { get; set; }

        public DateTime HireDateEnd { get; set; }

        public decimal SallaryPerMonth { get; set; }

        public EmployeeType Role { get; set; }
    }

    public class EmployeeEditViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime HireDateStart { get; set; }

        public DateTime HireDateEnd { get; set; }

        public decimal SallaryPerMonth { get; set; }

        public EmployeeType Role { get; set; }
    }
}
