using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instidute
{
    [Serializable]
    public class University
    {

        public Guid ID { get; }

        public string Name { get; set; }

        public int YearsOfService { get; set; }
        
        public List<Student> Students { get; set; }

        public List<Professor> Professors { get; set; }

        public List<Course> Courses { get; set; }

        /*public List<> Grades { get; set; }
        
        public List<> ScheduleCourse {get; set;}*/


        public University()
        {
            ID = System.Guid.NewGuid();
            Name = string.Empty;
            YearsOfService = 0;
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            /* Grades = new List<Grades>();
             ScheduleCourse = new List<Schedule>();*/
        }

        public void PopulateUniversity()
        {
            var c = new Course();
            c.Code = "HY240";
            c.Subject = "Data Science";
            Courses.Add(c);

            Student a = new Student();
            a.Name = "Fotis";
            a.Age = 23; 
            a.RegisterNumber = 3753;
            a.Courses.Add(c);
            Students.Add(a);

            var b = new Professor();
            b.Name = "Giannis";
            b.Age = 22;
            b.Rank = "Assistant";
            b.Courses.Add(c);
            Professors.Add(b);

            b = new Professor();
            b.Name = "Maria";
            b.Age = 22;
            b.Rank = "Assistant";
            b.Courses.Add(c);
            Professors.Add(b);


        }
    }
}
