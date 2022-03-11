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

        public EditForm()
        {
            InitializeComponent();
           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _university = new Instidute.University();
        }

        public EditForm(Instidute.University university)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _university = university;
            
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

        public void SetTheIntTextField(string index)
        {
            textIntField.Text = index;
        }

        private void SetTheFirstTwoLableField(string firstString, string secondString)
        {
            labelFirstString.Text = firstString;
            labelSecontString.Text= secondString;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var handler = new ListOjbectHandler(this);
            string type = this.Text;
            switch (type)
            {
                case ("Professor"):                    
                    handler.ProfessorListObject(_university.Professors[checkedListBox1.SelectedIndex]);
                    break;
                case ("Student"):
                    handler.StudentListObject(_university.Students[checkedListBox1.SelectedIndex]);
                    break;
                case ("Course"):
                    handler.CourseListObject(_university.Courses[checkedListBox1.SelectedIndex]);
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
            var checker = new ListOjbectHandler(this);
            var loader = new MenuActionHandler(_university);
            string type = this.Text;
            switch (type)
            {
                case ("Professor"):
                    _university.Professors.Add(handler.CreateNewProfessor());
                    loader.ProfessorListLoader(this);
                    checker.ProfessorListObject(_university.Professors[_university.Professors.Count - 1]);
                    break;
                case ("Student"):
                    _university.Students.Add(handler.CreateNewStudent());
                    loader.StudentListLoader(this);
                    checker.StudentListObject(_university.Students[_university.Students.Count - 1]);
                    break;
                case ("Course"):
                    _university.Courses.Add(handler.CreateNewCourse());
                    loader.CoursesListLoader(this);
                    checker.CourseListObject(_university.Courses[_university.Courses.Count - 1]);
                    break;
                /*case ("Grade"):
                    break;
                case ("Schedule"):
                    break;*/
                default:
                    break;
            }
        }
    }
}
