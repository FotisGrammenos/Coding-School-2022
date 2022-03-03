using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student : Person 
    {
        public int RegisterNumber { get; set; }

        public Course[] Courses { get; set; }

        public Student()
        {

        }

        public void Attend(Course course,DateTime dateTime)
        {

        }

        public void WritteExam(Course course, DateTime dateTime)
        {

        }
    }
}
            