using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Session_07
{
    internal class MenuActionHandler
    {
        private const string FILE_NAME = "university.txt";

        private Instidute.University _university;
        public MenuActionHandler()
        {
            _university = new Instidute.University();
            _university.PopulateUniversity();
            _university.Name = "Florida State University";
            _university.YearsOfService = 50;
            ExecuteLoad();
        }

        public MenuActionHandler(Instidute.University currUniversity)
        {
            _university = currUniversity;          
        }

        public void ExecuteSave()
        {
            string json = JsonConvert.SerializeObject(_university, Formatting.Indented);

            File.WriteAllText(FILE_NAME, json);
        }

        public void ExecuteLoad()
        {
            string s = File.ReadAllText(FILE_NAME);

            _university = (Instidute.University)JsonConvert.DeserializeObject(s, typeof(Instidute.University));
        }


        public void CreateTheRightForm(FormType myType)
        {
            //TODO:i pio asximi switch tou komso! anprolabeis ala3e tin 
            var newForm = new EditForm(_university);
            switch (myType)
            {

                case FormType.ProfessorForm:
                    newForm.Text = "Professor";
                    newForm.SetVisibleIntField(true);
                    newForm.SetVisibleCourseList(true);
                    newForm.SetUpLabels("Professor Name", "Professor Rank", "Professor Age");
                    ProfessorListLoader(newForm);
                    break;
                case FormType.StudentForm:
                    newForm.Text = "Student";
                    newForm.SetVisibleIntField(true);
                    newForm.SetVisibleCourseList(true);
                    newForm.SetUpLabels("Student Name", "Student RegisterNumber", "Student Age");
                    StudentListLoader(newForm);
                    break;
                case FormType.CourseForm:
                    newForm.Text = "Course";
                    newForm.SetUpLabels("Course Code", "Course Subject");
                    newForm.SetVisibleIntField(false);
                    newForm.SetVisibleCourseList(false);
                    CoursesListLoader(newForm);
                    break;
                /*case FormType.ScheduleForm: 
                    break;
                case FormType.GradeForm:
                    break;*/
                default:
                    return;
            }
            newForm.ShowDialog();
        }


        public void ProfessorListLoader(EditForm myForm)
        {
            myForm.ClearItemList();
            foreach (Instidute.Professor prof in _university.Professors)
            {
                if (prof != null)
                    myForm.AddItemOnList(prof.Name);
            }
        }

        public void StudentListLoader(EditForm myForm)
        {
            myForm.ClearItemList();
            foreach (Instidute.Student stud in _university.Students)
            {
                if (stud != null)
                    myForm.AddItemOnList(stud.Name);
            }
        }

        public void CoursesListLoader(EditForm myForm)
        {
            myForm.ClearItemList();
            foreach (Instidute.Course cors in _university.Courses)
            {
                if (cors != null)
                    myForm.AddItemOnList(cors.Code);
            }
        }

        /* public void GradeListLoader(EditForm myForm)
         {
             foreach (Instidute.Grade grade in _university.)
             {
                 if (item != null)
                     myForm.AddItemOnList(grade.);
             }
         }
         public void scheduleListLoader(EditForm myForm)
         {
             foreach (Instidute.Schedule schedule in _university.)
             {
                 if (item != null)
                     myForm.AddItemOnList(schedule.);
             }
         }*/

        public string GetUnirvsityName()
        {
            return _university.Name;
        }

    }
}
