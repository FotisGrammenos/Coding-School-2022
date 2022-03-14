using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Session_07
{
    public partial class EditForm : Form
    {
        private Instidute.University _university;
        private ListOjbectHandler _objectList;
        private MenuActionHandler _menuHandler;

        public EditForm()
        {
            InitializeComponent();
           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _university = new Instidute.University();
            _objectList = new ListOjbectHandler(this);
            _menuHandler = new MenuActionHandler(_university);
        }

        public EditForm(Instidute.University university)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _university = university;
            _objectList = new ListOjbectHandler(this);
            _menuHandler = new MenuActionHandler(university);

        }

        #region InitForm

        public void SetUpLabels(string firstLabel, string secondLabel, string intLabel)
        {
            SetTheFirstTwoLableField(firstLabel, secondLabel);
            labelIntDisplay.Visible = true;
            labelIntDisplay.Text = intLabel;
        }

        public void SetUpLabels(string firstLabel, string secondLabel)
        {
            SetTheFirstTwoLableField(firstLabel, secondLabel);
            labelIntDisplay.Visible = false;
            labelIntDisplay.Text = string.Empty;
        }

        public void SetDataField(Instidute.Professor myProfessor)
        {
            SetTheFirstTwoTextField(myProfessor.GetName(), myProfessor.Rank);
            textIntField.Text = myProfessor.Age.ToString();
;       }
        public void SetDataField(Instidute.Student myStudent)
        {
            SetTheFirstTwoTextField(myStudent.Name, myStudent.RegisterNumber.ToString());
            textIntField.Text = myStudent.Age.ToString();
;
        }

        public void SetDataField(Instidute.Course myCourse)
        {
            SetTheFirstTwoTextField(myCourse.Code, myCourse.Subject);
            textIntField.Text = string.Empty;
        }

        /*den 3erw pos tha brw to namestudent kai to courseCode
        //TODO
        public void SetDataField(Instidute.Grade)
        {
            SetTheFirstTwoTextField(myStudent.GetName(), myStudent.RegisterNumber);
            textIntField.Visible = true;
        }

        public void SetDataField(Instidute.Schedule mySchedule)
        {
             textIntField.Visible = true;
        }*/

        #endregion

        public void SetVisibleIntField(bool state)
        {
            labelIntDisplay.Visible = state;
            textIntField.Visible = state;
        }

        public void SetVisibleCourseList(bool state)
        {
            labelCourses.Visible = state;
            listViewCourses.Visible = state;
        }

        public void AddItemOnList(string itemName)
        {
            checkedListBox1.Items.Add(string.Format("{0}", itemName));
        }   
        public void ClearItemList()
        {
            checkedListBox1.Items.Clear();
        }
        public void AddCoursesOnList(string CourseName)
        {
            listViewCourses.Items.Add(string.Format("{0}", CourseName));
        }

        public void ClearCoursesList()
        {
            listViewCourses.Items.Clear();
        }
        public void SetTheFirstTwoTextField(string firstString, string secondString)
        {
            textFirstString.Text = firstString;
            textSecondString.Text = secondString;
        }

        public void ClearFirstTwoTextField()
        {
            textFirstString.Text = string.Empty;
            textSecondString.Text = string.Empty;
        }

        public void SetTheIntTextField(string index)
        {
            textIntField.Text = index;
        }

        public void ClearTheIntTextField()
        {
            textIntField.Text = string.Empty;
        }

        private void SetTheFirstTwoLableField(string firstString, string secondString)
        {
            labelFirstString.Text = firstString;
            labelSecontString.Text= secondString;
        }


        #region ButtonAction
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = this.Text;
            switch (type)
            {
                case ("Professor"):
                    _objectList.ProfessorListObject(_university.Professors[checkedListBox1.SelectedIndex]);
                    break;
                case ("Student"):
                    _objectList.StudentListObject(_university.Students[checkedListBox1.SelectedIndex]);
                    break;
                case ("Course"):
                    _objectList.CourseListObject(_university.Courses[checkedListBox1.SelectedIndex]);
                    break;
                /*case ("Grade"):
                    break;
                case ("Schedule"):
                    break;*/
                default:
                    break;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var handler = new NewButtonHandler(this);
            string type = this.Text;
            switch (type)
            {
                case ("Professor"):
                    _university.Professors.Add(handler.CreateNewProfessor());
                    _menuHandler.ProfessorListLoader(this);
                    _objectList.ProfessorListObject(_university.Professors[_university.Professors.Count - 1]);
                    break;
                case ("Student"):
                    _university.Students.Add(handler.CreateNewStudent());
                    _menuHandler.StudentListLoader(this);
                    _objectList.StudentListObject(_university.Students[_university.Students.Count - 1]);
                    break;
                case ("Course"):
                    _university.Courses.Add(handler.CreateNewCourse());
                    _menuHandler.CoursesListLoader(this);
                    _objectList.CourseListObject(_university.Courses[_university.Courses.Count - 1]);
                    break;
                /*case ("Grade"):
                    break;
                case ("Schedule"):
                    break;*/
                default:
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonHandler handler = new DeleteButtonHandler(this);
            string type = this.Text;
            switch (type)
            {
                case ("Professor"):
                    _university.Professors = handler.DeleteProfessor(_university.Professors, checkedListBox1.SelectedIndex);
                    _menuHandler.ProfessorListLoader(this);
                    break;
                case ("Student"):
                    _university.Students = handler.DeleteStudents(_university.Students, checkedListBox1.SelectedIndex);
                    _menuHandler.StudentListLoader(this);
                    break;
                 case ("Course"):
                    _university.Courses = handler.DeleteCourse(_university.Courses, checkedListBox1.SelectedIndex);
                    _menuHandler.CoursesListLoader(this);
                    break;
                 /*case ("Grade"):
                     break;
                 case ("Schedule"):
                     break;*/
                default:
                    break;
            }
            ClearCoursesList();
            ClearFirstTwoTextField();
            ClearTheIntTextField();
        }

        #endregion
    }
}
