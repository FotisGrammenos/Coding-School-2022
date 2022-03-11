using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instidute
{
    public class Student : Person
    {
        public int RegisterNumber { get; set; }

        public List<Course> Courses { get; set; }

        public Student()
        {
            RegisterNumber = 0;
            Courses = new List<Course>();
        }

        /*
        public void Attend(Course course, DateTime dateTime)
        {

        }

        public void WritteExam(Course course, DateTime dateTime)
        {

        }
        */
    }
}
