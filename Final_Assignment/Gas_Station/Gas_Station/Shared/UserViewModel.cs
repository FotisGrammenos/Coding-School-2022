using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.Shared
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public EmployeeType Role { get; set; }
        public bool IsAuth { get; set; }
    }
}
