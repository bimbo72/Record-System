namespace Grade_Record_Keeping.Forms
{
    partial class AddSchoolYear
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
            this.lblname.Size = new System.Drawing.Size(137, 18);
            this.lblname.Text = "School Year Name:";
            // 
            // lbltitle
            // 
            this.lbltitle.Size = new System.Drawing.Size(189, 25);
            this.lbltitle.Text = "Add School Year";
            // 
            // AddSchoolYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Name = "AddSchoolYear";
            this.Text = "";
            this.Load += new System.EventHandler(this.AddSchoolYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
