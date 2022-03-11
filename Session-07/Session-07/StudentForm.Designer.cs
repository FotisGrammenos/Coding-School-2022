namespace Session_07
{
    partial class StudentForm
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
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelStudLoad = new System.Windows.Forms.Label();
            this.textBoxStudCourses = new System.Windows.Forms.TextBox();
            this.labelStudAge = new System.Windows.Forms.Label();
            this.textStudentAge = new DevExpress.XtraEditors.TextEdit();
            this.labelStudRegNum = new System.Windows.Forms.Label();
            this.textStudentRegNum = new DevExpress.XtraEditors.TextEdit();
            this.labelStudCourses = new System.Windows.Forms.Label();
            this.labelStudName = new System.Windows.Forms.Label();
            this.textStudentsName = new DevExpress.XtraEditors.TextEdit();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentRegNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentsName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(146, 34);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 40;
            // 
            // labelStudLoad
            // 
            this.labelStudLoad.AutoSize = true;
            this.labelStudLoad.Location = new System.Drawing.Point(7, 37);
            this.labelStudLoad.Name = "labelStudLoad";
            this.labelStudLoad.Size = new System.Drawing.Size(92, 13);
            this.labelStudLoad.TabIndex = 39;
            this.labelStudLoad.Text = "Stud\'s Load Index";
            // 
            // textBoxStudCourses
            // 
            this.textBoxStudCourses.Location = new System.Drawing.Point(282, 30);
            this.textBoxStudCourses.Multiline = true;
            this.textBoxStudCourses.Name = "textBoxStudCourses";
            this.textBoxStudCourses.Size = new System.Drawing.Size(219, 144);
            this.textBoxStudCourses.TabIndex = 38;
            // 
            // labelStudAge
            // 
            this.labelStudAge.AutoSize = true;
            this.labelStudAge.Location = new System.Drawing.Point(7, 106);
            this.labelStudAge.Name = "labelStudAge";
            this.labelStudAge.Size = new System.Drawing.Size(76, 13);
            this.labelStudAge.TabIndex = 37;
            this.labelStudAge.Text = "Student\'s  Age";
            // 
            // textStudentAge
            // 
            this.textStudentAge.Location = new System.Drawing.Point(146, 99);
            this.textStudentAge.Name = "textStudentAge";
            this.textStudentAge.Size = new System.Drawing.Size(101, 20);
            this.textStudentAge.TabIndex = 36;
            // 
            // labelStudRegNum
            // 
            this.labelStudRegNum.AutoSize = true;
            this.labelStudRegNum.Location = new System.Drawing.Point(7, 132);
            this.labelStudRegNum.Name = "labelStudRegNum";
            this.labelStudRegNum.Size = new System.Drawing.Size(133, 13);
            this.labelStudRegNum.TabIndex = 35;
            this.labelStudRegNum.Text = "Student\'s Register Number";
            // 
            // textStudentRegNum
            // 
            this.textStudentRegNum.Location = new System.Drawing.Point(146, 125);
            this.textStudentRegNum.Name = "textStudentRegNum";
            this.textStudentRegNum.Size = new System.Drawing.Size(101, 20);
            this.textStudentRegNum.TabIndex = 34;
            // 
            // labelStudCourses
            // 
            this.labelStudCourses.AutoSize = true;
            this.labelStudCourses.Location = new System.Drawing.Point(280, 14);
            this.labelStudCourses.Name = "labelStudCourses";
            this.labelStudCourses.Size = new System.Drawing.Size(92, 13);
            this.labelStudCourses.TabIndex = 33;
            this.labelStudCourses.Text = "Student\'s Courses";
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Location = new System.Drawing.Point(7, 80);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(85, 13);
            this.labelStudName.TabIndex = 32;
            this.labelStudName.Text = "Student\'s Name ";
            // 
            // textStudentsName
            // 
            this.textStudentsName.Location = new System.Drawing.Point(146, 73);
            this.textStudentsName.Name = "textStudentsName";
            this.textStudentsName.Size = new System.Drawing.Size(101, 20);
            this.textStudentsName.TabIndex = 31;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 182);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Save";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(116, 182);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(4, 182);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 27;
            this.buttonNew.Text = "New";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelStudLoad);
            this.Controls.Add(this.textBoxStudCourses);
            this.Controls.Add(this.labelStudAge);
            this.Controls.Add(this.textStudentAge);
            this.Controls.Add(this.labelStudRegNum);
            this.Controls.Add(this.textStudentRegNum);
            this.Controls.Add(this.labelStudCourses);
            this.Controls.Add(this.labelStudName);
            this.Controls.Add(this.textStudentsName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentRegNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentsName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label labelStudLoad;
        private System.Windows.Forms.TextBox textBoxStudCourses;
        private System.Windows.Forms.Label labelStudAge;
        private DevExpress.XtraEditors.TextEdit textStudentAge;
        private System.Windows.Forms.Label labelStudRegNum;
        private DevExpress.XtraEditors.TextEdit textStudentRegNum;
        private System.Windows.Forms.Label labelStudCourses;
        private System.Windows.Forms.Label labelStudName;
        private DevExpress.XtraEditors.TextEdit textStudentsName;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonNew;
    }
}