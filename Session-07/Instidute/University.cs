using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instidute
{
    public class University
    {

        public Guid ID { get; }

        public string Name { get; set; }

        public int YearsOfService { get; set; }
        
        /*
         *  Mallon auta 8a ginoun classes 
         *  
        public Student[] Students { get; set; }

        public Course[] Courses { get; set; }
        
        public  Grade[] Grades { get; set; }
        
        public Schedule[] ScheduleCourse {get; set;}
         *
         *
         */

        public University()
        {
            ID = System.Guid.NewGuid();
            Name = string.Empty;
            YearsOfService = 0;
        }
    }
}
