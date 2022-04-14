using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.Shared
{
    public class TransactionListViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public string EmployeeFullName { get; set; }

        public string CustomerFullName { get; set; }

        public PayMentMethod PayMentMethod { get; set; }

        public decimal TotalValue { get; set; }

    }

    public class TransactionEditViewModel
    {
        public Guid ID { get; set; }

        public string EmployeeFullName { get; set; }

        public string CustomerFullName { get; set; }

        public Guid CustomerID { get; set; }

        public Guid EmployeeID { get; set; }

        public PayMentMethod PayMentMethod { get; set; }

        public decimal TotalValue { get; set; }

        public List<TransactionLineEditViewModel> TransactionLineList { get; set; }
    }
}
