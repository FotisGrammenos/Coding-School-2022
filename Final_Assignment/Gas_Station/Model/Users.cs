using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users : BaseEntitie
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Enums.EmployeeType Role { get; set; }
    }
}
