namespace Grade_Record_Keeping.Forms
{
    partial class AddCourse
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
            this.tb_course_Name = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.tb_course_Initial = new System.Windows.Forms.TextBox();
            this.lblinitial = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_course_Name
            // 
            this.tb_course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course_Name.Location = new System.Drawing.Point(129, 120);
            this.tb_course_Name.Name = "tb_course_Name";
            this.tb_course_Name.Size = new System.Drawing.Size(161, 24);
            this.tb_course_Name.TabIndex = 10;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(18, 126);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(105, 18);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Course Name:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(98, 27);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(121, 24);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "Add Course";
            // 
            // tb_course_Initial
            // 
            this.tb_course_Initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course_Initial.Location = new System.Drawing.Point(129, 75);
            this.tb_course_Initial.Name = "tb_course_Initial";
            this.tb_course_Initial.Size = new System.Drawing.Size(161, 24);
            this.tb_course_Initial.TabIndex = 7;
            // 
            // lblinitial
            // 
            this.lblinitial.AutoSize = true;
            this.lblinitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinitial.Location = new System.Drawing.Point(18, 78);
            this.lblinitial.Name = "lblinitial";
            this.lblinitial.Size = new System.Drawing.Size(97, 18);
            this.lblinitial.TabIndex = 6;
            this.lblinitial.Text = "Course Initial:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(215, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 219);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tb_course_Name);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.tb_course_Initial);
            this.Controls.Add(this.lblinitial);
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label lbltitle;
        public System.Windows.Forms.Label lblinitial;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox tb_course_Name;
        public System.Windows.Forms.TextBox tb_course_Initial;
    }
}