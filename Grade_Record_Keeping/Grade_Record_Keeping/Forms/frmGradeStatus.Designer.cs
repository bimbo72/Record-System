namespace Grade_Record_Keeping.Forms
{
    partial class frmGradeStatus
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
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Size = new System.Drawing.Size(143, 18);
            this.lblname.Text = "Grade Status Name:";
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(100, 28);
            this.lbltitle.Size = new System.Drawing.Size(173, 24);
            this.lbltitle.Text = "Add Grade Status";
            // 
            // lblinitial
            // 
            this.lblinitial.Size = new System.Drawing.Size(135, 18);
            this.lblinitial.Text = "Grade Status Initial:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 166);
            // 
            // tb_course_Name
            // 
            this.tb_course_Name.Location = new System.Drawing.Point(159, 120);
            this.tb_course_Name.Size = new System.Drawing.Size(173, 24);
            // 
            // tb_course_Initial
            // 
            this.tb_course_Initial.Location = new System.Drawing.Point(159, 75);
            this.tb_course_Initial.Size = new System.Drawing.Size(173, 24);
            this.tb_course_Initial.TextChanged += new System.EventHandler(this.tb_course_Initial_TextChanged);
            // 
            // frmGradeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 219);
            this.Name = "frmGradeStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
