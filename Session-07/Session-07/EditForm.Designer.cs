namespace Session_07
{
    partial class EditForm
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
            this.labelFirstString = new System.Windows.Forms.Label();
            this.labelIntDisplay = new System.Windows.Forms.Label();
            this.labelSecontString = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.textFirstString = new System.Windows.Forms.TextBox();
            this.textSecondString = new System.Windows.Forms.TextBox();
            this.textIntField = new System.Windows.Forms.TextBox();
            this.listViewObject = new System.Windows.Forms.ListView();
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(8, 367);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(106, 47);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(120, 367);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 367);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 47);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(287, 367);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 47);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            // 
            // labelFirstString
            // 
            this.labelFirstString.AutoSize = true;
            this.labelFirstString.Location = new System.Drawing.Point(271, 17);
            this.labelFirstString.Name = "labelFirstString";
            this.labelFirstString.Size = new System.Drawing.Size(101, 13);
            this.labelFirstString.TabIndex = 5;
            this.labelFirstString.Text = "Number of Students";
            // 
            // labelIntDisplay
            // 
            this.labelIntDisplay.AutoSize = true;
            this.labelIntDisplay.Location = new System.Drawing.Point(271, 68);
            this.labelIntDisplay.Name = "labelIntDisplay";
            this.labelIntDisplay.Size = new System.Drawing.Size(97, 13);
            this.labelIntDisplay.TabIndex = 7;
            this.labelIntDisplay.Text = "Number of Courses";
            // 
            // labelSecontString
            // 
            this.labelSecontString.AutoSize = true;
            this.labelSecontString.Location = new System.Drawing.Point(271, 43);
            this.labelSecontString.Name = "labelSecontString";
            this.labelSecontString.Size = new System.Drawing.Size(108, 13);
            this.labelSecontString.TabIndex = 13;
            this.labelSecontString.Text = "Number of Professors\r\n";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Location = new System.Drawing.Point(271, 91);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(45, 13);
            this.labelCourses.TabIndex = 20;
            this.labelCourses.Text = "Courses";
            // 
            // textFirstString
            // 
            this.textFirstString.Location = new System.Drawing.Point(388, 17);
            this.textFirstString.Name = "textFirstString";
            this.textFirstString.Size = new System.Drawing.Size(117, 20);
            this.textFirstString.TabIndex = 21;
            // 
            // textSecondString
            // 
            this.textSecondString.Location = new System.Drawing.Point(388, 40);
            this.textSecondString.Name = "textSecondString";
            this.textSecondString.Size = new System.Drawing.Size(117, 20);
            this.textSecondString.TabIndex = 22;
            // 
            // textIntField
            // 
            this.textIntField.Location = new System.Drawing.Point(388, 66);
            this.textIntField.Name = "textIntField";
            this.textIntField.Size = new System.Drawing.Size(28, 20);
            this.textIntField.TabIndex = 23;
            // 
            // listViewObject
            // 
            this.listViewObject.HideSelection = false;
            this.listViewObject.Location = new System.Drawing.Point(12, 10);
            this.listViewObject.Name = "listViewObject";
            this.listViewObject.Size = new System.Drawing.Size(213, 343);
            this.listViewObject.TabIndex = 24;
            this.listViewObject.UseCompatibleStateImageBehavior = false;
            this.listViewObject.SelectedIndexChanged += new System.EventHandler(this.listViewObject_SelectedIndexChanged);
            // 
            // listViewCourses
            // 
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.Location = new System.Drawing.Point(274, 107);
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.Size = new System.Drawing.Size(231, 246);
            this.listViewCourses.TabIndex = 25;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 422);
            this.Controls.Add(this.listViewCourses);
            this.Controls.Add(this.listViewObject);
            this.Controls.Add(this.textIntField);
            this.Controls.Add(this.textSecondString);
            this.Controls.Add(this.textFirstString);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelSecontString);
            this.Controls.Add(this.labelIntDisplay);
            this.Controls.Add(this.labelFirstString);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonNew;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private System.Windows.Forms.Label labelFirstString;
        private System.Windows.Forms.Label labelIntDisplay;
        private System.Windows.Forms.Label labelSecontString;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.TextBox textFirstString;
        private System.Windows.Forms.TextBox textSecondString;
        private System.Windows.Forms.TextBox textIntField;
        private System.Windows.Forms.ListView listViewObject;
        private System.Windows.Forms.ListView listViewCourses;
    }
}