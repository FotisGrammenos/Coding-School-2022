namespace Session_07
{
    partial class CourseForm
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
            this.labelCourseLoad = new System.Windows.Forms.Label();
            this.labelCourseSubject = new System.Windows.Forms.Label();
            this.textCourseSubject = new DevExpress.XtraEditors.TextEdit();
            this.labelStudName = new System.Windows.Forms.Label();
            this.textCourseName = new DevExpress.XtraEditors.TextEdit();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseName.Properties)).BeginInit();
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
            this.spinEdit1.TabIndex = 50;
            // 
            // labelCourseLoad
            // 
            this.labelCourseLoad.AutoSize = true;
            this.labelCourseLoad.Location = new System.Drawing.Point(7, 27);
            this.labelCourseLoad.Name = "labelCourseLoad";
            this.labelCourseLoad.Size = new System.Drawing.Size(101, 13);
            this.labelCourseLoad.TabIndex = 49;
            this.labelCourseLoad.Text = "Courses Load Index";
            // 
            // labelCourseSubject
            // 
            this.labelCourseSubject.AutoSize = true;
            this.labelCourseSubject.Location = new System.Drawing.Point(7, 96);
            this.labelCourseSubject.Name = "labelCourseSubject";
            this.labelCourseSubject.Size = new System.Drawing.Size(79, 13);
            this.labelCourseSubject.TabIndex = 48;
            this.labelCourseSubject.Text = "Course Subject";
            // 
            // textCourseSubject
            // 
            this.textCourseSubject.Location = new System.Drawing.Point(146, 89);
            this.textCourseSubject.Name = "textCourseSubject";
            this.textCourseSubject.Size = new System.Drawing.Size(101, 20);
            this.textCourseSubject.TabIndex = 47;
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Location = new System.Drawing.Point(7, 70);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(74, 13);
            this.labelStudName.TabIndex = 46;
            this.labelStudName.Text = "Course Name ";
            // 
            // textCourseName
            // 
            this.textCourseName.Location = new System.Drawing.Point(146, 63);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(101, 20);
            this.textCourseName.TabIndex = 45;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "Save";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(116, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(4, 172);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 41;
            this.buttonNew.Text = "New";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelCourseLoad);
            this.Controls.Add(this.labelCourseSubject);
            this.Controls.Add(this.textCourseSubject);
            this.Controls.Add(this.labelStudName);
            this.Controls.Add(this.textCourseName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label labelCourseLoad;
        private System.Windows.Forms.Label labelCourseSubject;
        private DevExpress.XtraEditors.TextEdit textCourseSubject;
        private System.Windows.Forms.Label labelStudName;
        private DevExpress.XtraEditors.TextEdit textCourseName;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonNew;
    }
}