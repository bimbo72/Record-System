namespace Grade_Record_Keeping.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tryToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.assigningToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tryToolStripMenuItem
            // 
            this.tryToolStripMenuItem.Name = "tryToolStripMenuItem";
            this.tryToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.tryToolStripMenuItem.Text = "try";
            this.tryToolStripMenuItem.Click += new System.EventHandler(this.tryToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.courseToolStripMenuItem,
            this.semesterToolStripMenuItem,
            this.schoolYearToolStripMenuItem,
            this.insructorToolStripMenuItem,
            this.subjectModuleToolStripMenuItem,
            this.gradeStatusToolStripMenuItem,
            this.subjectsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
           
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfStudentsToolStripMenuItem,
            this.importStudentsToolStripMenuItem});
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // listOfStudentsToolStripMenuItem
            // 
            this.listOfStudentsToolStripMenuItem.Name = "listOfStudentsToolStripMenuItem";
            this.listOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listOfStudentsToolStripMenuItem.Text = "List of Students";
            this.listOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentsToolStripMenuItem_Click);
            // 
            // importStudentsToolStripMenuItem
            // 
            this.importStudentsToolStripMenuItem.Name = "importStudentsToolStripMenuItem";
            this.importStudentsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.importStudentsToolStripMenuItem.Text = "Import Students";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.semesterToolStripMenuItem.Text = "Semester";
            this.semesterToolStripMenuItem.Click += new System.EventHandler(this.semesterToolStripMenuItem_Click);
            // 
            // schoolYearToolStripMenuItem
            // 
            this.schoolYearToolStripMenuItem.Name = "schoolYearToolStripMenuItem";
            this.schoolYearToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.schoolYearToolStripMenuItem.Text = "School Year";
            this.schoolYearToolStripMenuItem.Click += new System.EventHandler(this.schoolYearToolStripMenuItem_Click);
            // 
            // insructorToolStripMenuItem
            // 
            this.insructorToolStripMenuItem.Name = "insructorToolStripMenuItem";
            this.insructorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.insructorToolStripMenuItem.Text = "Insructor";
            this.insructorToolStripMenuItem.Click += new System.EventHandler(this.insructorToolStripMenuItem_Click);
            // 
            // subjectModuleToolStripMenuItem
            // 
            this.subjectModuleToolStripMenuItem.Name = "subjectModuleToolStripMenuItem";
            this.subjectModuleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.subjectModuleToolStripMenuItem.Text = "Subject Module";
            this.subjectModuleToolStripMenuItem.Click += new System.EventHandler(this.subjectModuleToolStripMenuItem_Click);
            // 
            // gradeStatusToolStripMenuItem
            // 
            this.gradeStatusToolStripMenuItem.Name = "gradeStatusToolStripMenuItem";
            this.gradeStatusToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gradeStatusToolStripMenuItem.Text = "Grade Status";
            this.gradeStatusToolStripMenuItem.Click += new System.EventHandler(this.gradeStatusToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // assigningToolStripMenuItem
            // 
            this.assigningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectToolStripMenuItem,
            this.subjectToStudentToolStripMenuItem,
            this.subjectToCourseToolStripMenuItem});
            this.assigningToolStripMenuItem.Name = "assigningToolStripMenuItem";
            this.assigningToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.assigningToolStripMenuItem.Text = "Assigning";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subjectToolStripMenuItem.Text = "Subject to Instructor";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // subjectToStudentToolStripMenuItem
            // 
            this.subjectToStudentToolStripMenuItem.Name = "subjectToStudentToolStripMenuItem";
            this.subjectToStudentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subjectToStudentToolStripMenuItem.Text = "Subject to Student";
            // 
            // subjectToCourseToolStripMenuItem
            // 
            this.subjectToCourseToolStripMenuItem.Name = "subjectToCourseToolStripMenuItem";
            this.subjectToCourseToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subjectToCourseToolStripMenuItem.Text = "Subject to Course";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentsToolStripMenuItem;
    }
}



