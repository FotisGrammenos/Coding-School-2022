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
        ProfessorForm,
        StudentForm,
        ScheduleForm,
        CourseForm,
        GradeForm
    }
    public partial class MainForm : Form
    {
        private MenuActionHandler _myHandler;
        public MainForm()
        {
            InitializeComponent();
            _myHandler = new MenuActionHandler();
            this.Text = _myHandler.GetUnirvsityName();
        }

        #region MenuActions
        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.CreateTheRightForm(FormType.ProfessorForm);
        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.CreateTheRightForm(FormType.StudentForm);
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.CreateTheRightForm(FormType.CourseForm);
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.CreateTheRightForm(FormType.GradeForm);
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.CreateTheRightForm(FormType.ScheduleForm);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.ExecuteSave();   
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myHandler.ExecuteLoad();
        }
        # endregion

        
       
    }
}
