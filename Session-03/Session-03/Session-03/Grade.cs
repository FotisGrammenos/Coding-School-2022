using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID { get; }

        public Guid CourseID { get; set; }

        public Guid StudentID { get; set; }

        public int Value;

        public Grade()
        {
            ID = System.Guid.NewGuid();
        }

    }
}
