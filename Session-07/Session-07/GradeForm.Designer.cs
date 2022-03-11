namespace Session_07
{
    partial class GradeForm
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
            this.labelGradeLoad = new System.Windows.Forms.Label();
            this.labelStudName = new System.Windows.Forms.Label();
            this.textStudentName = new DevExpress.XtraEditors.TextEdit();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            this.textCourseCode = new DevExpress.XtraEditors.TextEdit();
            this.labelCourseCode = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textGrade = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGrade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(146, 24);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 60;
            // 
            // labelGradeLoad
            // 
            this.labelGradeLoad.AutoSize = true;
            this.labelGradeLoad.Location = new System.Drawing.Point(7, 27);
            this.labelGradeLoad.Name = "labelGradeLoad";
            this.labelGradeLoad.Size = new System.Drawing.Size(92, 13);
            this.labelGradeLoad.TabIndex = 59;
            this.labelGradeLoad.Text = "Grade Load Index";
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Location = new System.Drawing.Point(7, 70);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(75, 13);
            this.labelStudName.TabIndex = 56;
            this.labelStudName.Text = "Student Name";
            // 
            // textStudentName
            // 
            this.textStudentName.Location = new System.Drawing.Point(146, 63);
            this.textStudentName.Name = "textStudentName";
            this.textStudentName.Size = new System.Drawing.Size(101, 20);
            this.textStudentName.TabIndex = 55;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 54;
            this.buttonSave.Text = "Save";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 53;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(116, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 52;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(4, 172);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 51;
            this.buttonNew.Text = "New";
            // 
            // textCourseCode
            // 
            this.textCourseCode.Location = new System.Drawing.Point(146, 89);
            this.textCourseCode.Name = "textCourseCode";
            this.textCourseCode.Size = new System.Drawing.Size(101, 20);
            this.textCourseCode.TabIndex = 57;
            // 
            // labelCourseCode
            // 
            this.labelCourseCode.AutoSize = true;
            this.labelCourseCode.Location = new System.Drawing.Point(7, 96);
            this.labelCourseCode.Name = "labelCourseCode";
            this.labelCourseCode.Size = new System.Drawing.Size(68, 13);
            this.labelCourseCode.TabIndex = 58;
            this.labelCourseCode.Text = "Course Code";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(7, 122);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 62;
            this.labelGrade.Text = "Grade";
            // 
            // textGrade
            // 
            this.textGrade.Location = new System.Drawing.Point(146, 115);
            this.textGrade.Name = "textGrade";
            this.textGrade.Size = new System.Drawing.Size(101, 20);
            this.textGrade.TabIndex = 61;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textGrade);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelGradeLoad);
            this.Controls.Add(this.labelCourseCode);
            this.Controls.Add(this.textCourseCode);
            this.Controls.Add(this.labelStudName);
            this.Controls.Add(this.textStudentName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGrade.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label labelGradeLoad;
        private System.Windows.Forms.Label labelStudName;
        private DevExpress.XtraEditors.TextEdit textStudentName;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonNew;
        private DevExpress.XtraEditors.TextEdit textCourseCode;
        private System.Windows.Forms.Label labelCourseCode;
        private System.Windows.Forms.Label labelGrade;
        private DevExpress.XtraEditors.TextEdit textGrade;
    }
}