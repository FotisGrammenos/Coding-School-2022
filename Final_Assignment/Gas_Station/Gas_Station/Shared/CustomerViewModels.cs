using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared
{
   public class CustomerListViewModel
   {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string  Surname { get; set; }

        public string CardNumber { get; set; }    
    }

    public class CustomerEditViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
     
    }

}
