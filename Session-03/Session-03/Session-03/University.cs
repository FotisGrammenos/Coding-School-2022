using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        public Student[] Students;

        public Course[] Courses;

        public Grade[] Grades;

        public Schedule[] ScheduledCourse;

        private Professor[] Professors;

        public University()
        {
            Students = new Student[30];
            Professors = new Professor[5];
            Courses = new Course[20];
            ScheduledCourse = new Schedule[60];
        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourses()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime dateTime)
        {
            
        }

    }
}
