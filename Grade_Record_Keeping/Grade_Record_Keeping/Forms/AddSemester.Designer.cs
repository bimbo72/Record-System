namespace Grade_Record_Keeping.Forms
{
    partial class AddSemester
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
            this.lblname.Size = new System.Drawing.Size(120, 18);
            this.lblname.Text = "Semester Name:";
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(65, 40);
            this.lbltitle.Size = new System.Drawing.Size(159, 25);
            this.lbltitle.Text = "Add Semester";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // AddSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Name = "AddSemester";
            this.Text = "";
            this.Load += new System.EventHandler(this.AddSemester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
