﻿namespace Grade_Record_Keeping.Forms
{
    partial class frmListGradeStatus
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
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(252, 31);
            this.lbltitle.Size = new System.Drawing.Size(241, 29);
            this.lbltitle.Text = "List of Grade Status";
            // 
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frmListGradeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(782, 421);
            this.Name = "frmListGradeStatus";
            this.Load += new System.EventHandler(this.frmListGradeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
