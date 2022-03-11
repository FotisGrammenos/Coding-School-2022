using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public enum FormType
    {
        UniversityForm,
        ProfessorForm,
        StudentForm,
        ScheduleForm,
        CourseForm,
        GradeForm
    }
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        #region MenuActions
        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.UniversityForm);
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.ProfessorForm);
        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.StudentForm);
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.CourseForm);
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.GradeForm);
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTheRightForm(FormType.ScheduleForm);
        }

        //TODO: ftia3e autes tis sinartiseis oste an apothikeuei
        //kai na kanei load arxeia Json
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        # endregion

        private void CreateTheRightForm(FormType myType)
        {
            Form newForm;
            switch (myType)
            {
                case FormType.UniversityForm:
                    newForm = new UniversityForm();
                    break;
                case FormType.ProfessorForm:
                    newForm = new ProfessorForm();
                    break;
                case FormType.StudentForm:
                    newForm = new StudentForm();
                    break;
                case FormType.ScheduleForm:
                    newForm = new ScheduleForm();
                    break;
                case FormType.CourseForm:
                    newForm = new CourseForm();
                    break;
                case FormType.GradeForm:
                    newForm = new GradeForm();
                    break;
                default:
                    return;
            }
            newForm.TopLevel = false;
            newForm.Parent = this;
            newForm.Show();
        }

    }
}
