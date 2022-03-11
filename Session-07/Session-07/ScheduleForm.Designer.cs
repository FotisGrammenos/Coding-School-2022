namespace Session_07
{
    partial class ScheduleForm
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
            this.labelCallendar = new System.Windows.Forms.Label();
            this.textCallender = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelsScheduleLoad = new System.Windows.Forms.Label();
            this.labelCourseCode = new System.Windows.Forms.Label();
            this.textCourseCode = new DevExpress.XtraEditors.TextEdit();
            this.labelProfName = new System.Windows.Forms.Label();
            this.textProfName = new DevExpress.XtraEditors.TextEdit();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textCallender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProfName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCallendar
            // 
            this.labelCallendar.AutoSize = true;
            this.labelCallendar.Location = new System.Drawing.Point(7, 122);
            this.labelCallendar.Name = "labelCallendar";
            this.labelCallendar.Size = new System.Drawing.Size(51, 13);
            this.labelCallendar.TabIndex = 74;
            this.labelCallendar.Text = "Callender";
            // 
            // textCallender
            // 
            this.textCallender.Location = new System.Drawing.Point(146, 115);
            this.textCallender.Name = "textCallender";
            this.textCallender.Size = new System.Drawing.Size(101, 20);
            this.textCallender.TabIndex = 73;
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
            this.spinEdit1.TabIndex = 72;
            // 
            // labelsScheduleLoad
            // 
            this.labelsScheduleLoad.AutoSize = true;
            this.labelsScheduleLoad.Location = new System.Drawing.Point(7, 27);
            this.labelsScheduleLoad.Name = "labelsScheduleLoad";
            this.labelsScheduleLoad.Size = new System.Drawing.Size(108, 13);
            this.labelsScheduleLoad.TabIndex = 71;
            this.labelsScheduleLoad.Text = "Schedule Load Index";
            // 
            // labelCourseCode
            // 
            this.labelCourseCode.AutoSize = true;
            this.labelCourseCode.Location = new System.Drawing.Point(7, 96);
            this.labelCourseCode.Name = "labelCourseCode";
            this.labelCourseCode.Size = new System.Drawing.Size(68, 13);
            this.labelCourseCode.TabIndex = 70;
            this.labelCourseCode.Text = "Course Code";
            // 
            // textCourseCode
            // 
            this.textCourseCode.Location = new System.Drawing.Point(146, 89);
            this.textCourseCode.Name = "textCourseCode";
            this.textCourseCode.Size = new System.Drawing.Size(101, 20);
            this.textCourseCode.TabIndex = 69;
            // 
            // labelProfName
            // 
            this.labelProfName.AutoSize = true;
            this.labelProfName.Location = new System.Drawing.Point(7, 70);
            this.labelProfName.Name = "labelProfName";
            this.labelProfName.Size = new System.Drawing.Size(82, 13);
            this.labelProfName.TabIndex = 68;
            this.labelProfName.Text = "Professor Name";
            // 
            // textProfName
            // 
            this.textProfName.Location = new System.Drawing.Point(146, 63);
            this.textProfName.Name = "textProfName";
            this.textProfName.Size = new System.Drawing.Size(101, 20);
            this.textProfName.TabIndex = 67;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 66;
            this.buttonSave.Text = "Save";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 65;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(116, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 64;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(4, 172);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 63;
            this.buttonNew.Text = "New";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 242);
            this.Controls.Add(this.labelCallendar);
            this.Controls.Add(this.textCallender);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelsScheduleLoad);
            this.Controls.Add(this.labelCourseCode);
            this.Controls.Add(this.textCourseCode);
            this.Controls.Add(this.labelProfName);
            this.Controls.Add(this.textProfName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.textCallender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCourseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProfName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCallendar;
        private DevExpress.XtraEditors.TextEdit textCallender;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label labelsScheduleLoad;
        private System.Windows.Forms.Label labelCourseCode;
        private DevExpress.XtraEditors.TextEdit textCourseCode;
        private System.Windows.Forms.Label labelProfName;
        private DevExpress.XtraEditors.TextEdit textProfName;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonNew;
    }
}