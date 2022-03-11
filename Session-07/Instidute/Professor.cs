using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instidute
{
  
    public class Professor : Person
    {
        public string Rank { get; set; }

        public List<Course> Courses { get; set; }

        public Professor()
        {
            Rank = string.Empty;
            Courses = new List<Course>();
        }
        
        /*
         * Den 3erw an prepei na ta ilopoiso
         * 
        public void Teach(Course course, DateTime dateTime)
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, Grade grade)
        {

        }
        *
        *
        */

        public string GetName()
        {
            return "Dr." + Name;
        }
    }
}
