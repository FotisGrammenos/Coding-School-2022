using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ListOjbectHandler
    {
        private EditForm _helperEditForm;

        public ListOjbectHandler()
        {
            _helperEditForm = new EditForm();
        }
        public ListOjbectHandler(EditForm edit)
       {
            _helperEditForm = edit;
       }

        public void ProfessorListObject(Instidute.Professor prof)
        {
            _helperEditForm.SetTheFirstTwoTextField(prof.GetName(), prof.Rank);
            _helperEditForm.SetTheIntTextField(prof.Age.ToString());
            _helperEditForm.ClearCoursesList();

            foreach (Instidute.Course cors in prof.Courses)
            {
                if (cors != null)
                    _helperEditForm.AddCoursesOnList(cors.Code);
            }
        }

        public void StudentListObject(Instidute.Student student)
        {
            _helperEditForm.SetTheFirstTwoTextField(student.Name, student.RegisterNumber.ToString());
            _helperEditForm.SetTheIntTextField(student.Age.ToString());
            _helperEditForm.ClearCoursesList();

            foreach (Instidute.Course cors in student.Courses)
            {
                if (cors != null)
                    _helperEditForm.AddCoursesOnList(cors.Code);
            }
        }

        public void CourseListObject(Instidute.Course course)
        {
            _helperEditForm.SetTheFirstTwoTextField(course.Code, course.Subject);
        }
    }
}
