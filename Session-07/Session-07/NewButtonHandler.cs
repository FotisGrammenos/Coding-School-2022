using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    
    public class NewButtonHandler
    {
        private EditForm _helperEditForm;

        public NewButtonHandler()
        {
            _helperEditForm = new EditForm();   
        }

        public NewButtonHandler(EditForm edit)
        {
            _helperEditForm = edit;
        }

        public Instidute.Professor CreateNewProfessor()
        {
            Instidute.Professor newProfessor = new Instidute.Professor();
            newProfessor.Name= "[enterName]";
            newProfessor.Rank = "[enterRank]";
            return newProfessor;
        }
        public Instidute.Student CreateNewStudent()
        {
            Instidute.Student newStudent = new Instidute.Student();
            newStudent.Name = "[enterName]";
            return newStudent;
        }

        public Instidute.Course CreateNewCourse()
        {
            Instidute.Course newCourse = new Instidute.Course();
            newCourse.Code = "[enterCode]";
            newCourse.Subject = "[enterSubject]";
            return newCourse;
        }
    }
}
