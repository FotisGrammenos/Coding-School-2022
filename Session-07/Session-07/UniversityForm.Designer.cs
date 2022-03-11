namespace Session_07
{
    partial class UniversityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.textNumStudents = new DevExpress.XtraEditors.TextEdit();
            this.labelNumStudents = new System.Windows.Forms.Label();
            this.labelNumCourses = new System.Windows.Forms.Label();
            this.textNumCourses = new DevExpress.XtraEditors.TextEdit();
            this.labelNumGrades = new System.Windows.Forms.Label();
            this.textNumGrades = new DevExpress.XtraEditors.TextEdit();
            this.labelNumSchedule = new System.Windows.Forms.Label();
            this.textNumSchedule = new DevExpress.XtraEditors.TextEdit();
            this.labelNumProfessors = new System.Windows.Forms.Label();
            this.textNumProfessors = new DevExpress.XtraEditors.TextEdit();
            this.labelYearService = new System.Windows.Forms.Label();
            this.textYearService = new DevExpress.XtraEditors.TextEdit();
            this.labelUnivName = new System.Windows.Forms.Label();
            this.textUnivName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumStudents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumCourses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumGrades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumSchedule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumProfessors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYearService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnivName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(4, 183);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(116, 183);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 183);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 183);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            // 
            // textNumStudents
            // 
            this.textNumStudents.Location = new System.Drawing.Point(125, 24);
            this.textNumStudents.Name = "textNumStudents";
            this.textNumStudents.Size = new System.Drawing.Size(101, 20);
            this.textNumStudents.TabIndex = 4;
            // 
            // labelNumStudents
            // 
            this.labelNumStudents.AutoSize = true;
            this.labelNumStudents.Location = new System.Drawing.Point(11, 31);
            this.labelNumStudents.Name = "labelNumStudents";
            this.labelNumStudents.Size = new System.Drawing.Size(101, 13);
            this.labelNumStudents.TabIndex = 5;
            this.labelNumStudents.Text = "Number of Students";
            // 
            // labelNumCourses
            // 
            this.labelNumCourses.AutoSize = true;
            this.labelNumCourses.Location = new System.Drawing.Point(11, 82);
            this.labelNumCourses.Name = "labelNumCourses";
            this.labelNumCourses.Size = new System.Drawing.Size(97, 13);
            this.labelNumCourses.TabIndex = 7;
            this.labelNumCourses.Text = "Number of Courses";
            // 
            // textNumCourses
            // 
            this.textNumCourses.Location = new System.Drawing.Point(125, 75);
            this.textNumCourses.Name = "textNumCourses";
            this.textNumCourses.Size = new System.Drawing.Size(101, 20);
            this.textNumCourses.TabIndex = 6;
            // 
            // labelNumGrades
            // 
            this.labelNumGrades.AutoSize = true;
            this.labelNumGrades.Location = new System.Drawing.Point(11, 108);
            this.labelNumGrades.Name = "labelNumGrades";
            this.labelNumGrades.Size = new System.Drawing.Size(93, 13);
            this.labelNumGrades.TabIndex = 9;
            this.labelNumGrades.Text = "Number of Grades";
            // 
            // textNumGrades
            // 
            this.textNumGrades.Location = new System.Drawing.Point(125, 101);
            this.textNumGrades.Name = "textNumGrades";
            this.textNumGrades.Size = new System.Drawing.Size(101, 20);
            this.textNumGrades.TabIndex = 8;
            // 
            // labelNumSchedule
            // 
            this.labelNumSchedule.AutoSize = true;
            this.labelNumSchedule.Location = new System.Drawing.Point(11, 134);
            this.labelNumSchedule.Name = "labelNumSchedule";
            this.labelNumSchedule.Size = new System.Drawing.Size(104, 13);
            this.labelNumSchedule.TabIndex = 11;
            this.labelNumSchedule.Text = "Number of Schedule";
            // 
            // textNumSchedule
            // 
            this.textNumSchedule.Location = new System.Drawing.Point(125, 127);
            this.textNumSchedule.Name = "textNumSchedule";
            this.textNumSchedule.Size = new System.Drawing.Size(101, 20);
            this.textNumSchedule.TabIndex = 10;
            // 
            // labelNumProfessors
            // 
            this.labelNumProfessors.AutoSize = true;
            this.labelNumProfessors.Location = new System.Drawing.Point(11, 57);
            this.labelNumProfessors.Name = "labelNumProfessors";
            this.labelNumProfessors.Size = new System.Drawing.Size(108, 13);
            this.labelNumProfessors.TabIndex = 13;
            this.labelNumProfessors.Text = "Number of Professors\r\n";
            // 
            // textNumProfessors
            // 
            this.textNumProfessors.Location = new System.Drawing.Point(125, 50);
            this.textNumProfessors.Name = "textNumProfessors";
            this.textNumProfessors.Size = new System.Drawing.Size(101, 20);
            this.textNumProfessors.TabIndex = 12;
            // 
            // labelYearService
            // 
            this.labelYearService.AutoSize = true;
            this.labelYearService.Location = new System.Drawing.Point(280, 57);
            this.labelYearService.Name = "labelYearService";
            this.labelYearService.Size = new System.Drawing.Size(80, 13);
            this.labelYearService.TabIndex = 17;
            this.labelYearService.Text = "Year of Service";
            // 
            // textYearService
            // 
            this.textYearService.Location = new System.Drawing.Point(394, 50);
            this.textYearService.Name = "textYearService";
            this.textYearService.Size = new System.Drawing.Size(101, 20);
            this.textYearService.TabIndex = 16;
            // 
            // labelUnivName
            // 
            this.labelUnivName.AutoSize = true;
            this.labelUnivName.Location = new System.Drawing.Point(280, 31);
            this.labelUnivName.Name = "labelUnivName";
            this.labelUnivName.Size = new System.Drawing.Size(84, 13);
            this.labelUnivName.TabIndex = 15;
            this.labelUnivName.Text = "University Name";
            // 
            // textUnivName
            // 
            this.textUnivName.Location = new System.Drawing.Point(394, 24);
            this.textUnivName.Name = "textUnivName";
            this.textUnivName.Size = new System.Drawing.Size(101, 20);
            this.textUnivName.TabIndex = 14;
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.labelYearService);
            this.Controls.Add(this.textYearService);
            this.Controls.Add(this.labelUnivName);
            this.Controls.Add(this.textUnivName);
            this.Controls.Add(this.labelNumProfessors);
            this.Controls.Add(this.textNumProfessors);
            this.Controls.Add(this.labelNumSchedule);
            this.Controls.Add(this.textNumSchedule);
            this.Controls.Add(this.labelNumGrades);
            this.Controls.Add(this.textNumGrades);
            this.Controls.Add(this.labelNumCourses);
            this.Controls.Add(this.textNumCourses);
            this.Controls.Add(this.labelNumStudents);
            this.Controls.Add(this.textNumStudents);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UniversityForm";
            this.Text = "UniversityForm";
            ((System.ComponentModel.ISupportInitialize)(this.textNumStudents.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumCourses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumGrades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumSchedule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumProfessors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYearService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnivName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonNew;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.TextEdit textNumStudents;
        private System.Windows.Forms.Label labelNumStudents;
        private System.Windows.Forms.Label labelNumCourses;
        private DevExpress.XtraEditors.TextEdit textNumCourses;
        private System.Windows.Forms.Label labelNumGrades;
        private DevExpress.XtraEditors.TextEdit textNumGrades;
        private System.Windows.Forms.Label labelNumSchedule;
        private DevExpress.XtraEditors.TextEdit textNumSchedule;
        private System.Windows.Forms.Label labelNumProfessors;
        private DevExpress.XtraEditors.TextEdit textNumProfessors;
        private System.Windows.Forms.Label labelYearService;
        private DevExpress.XtraEditors.TextEdit textYearService;
        private System.Windows.Forms.Label labelUnivName;
        private DevExpress.XtraEditors.TextEdit textUnivName;
    }
}