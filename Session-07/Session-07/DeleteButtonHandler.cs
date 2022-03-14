using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class DeleteButtonHandler
    {
        private EditForm _helperEditForm;

        public DeleteButtonHandler()
        {
            _helperEditForm = new EditForm();
        }

        public DeleteButtonHandler(EditForm edit)
        {
            _helperEditForm = edit;
        }

        public List<Instidute.Professor> DeleteProfessor(List<Instidute.Professor> professors, int indexOfProfessor)
        {
            professors.Remove(professors[indexOfProfessor]);
            return professors;
        }

        public List<Instidute.Student> DeleteStudents(List<Instidute.Student> students, int indexOfStudent)
        {
            students.Remove(students[indexOfStudent]);
            return students;
        }

        public List<Instidute.Course> DeleteCourse(List<Instidute.Course> courses, int indexOfCourse)
        {
            courses.Remove(courses[indexOfCourse]);
            return courses;
        }
    }
}
