namespace Grade_Record_Keeping.Forms
{
    partial class frmAssignSubject
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
            this.lblname = new System.Windows.Forms.Label();
            this.lsv1 = new System.Windows.Forms.ListView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.tb_search1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_box_subjects = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.group_box_taken = new System.Windows.Forms.GroupBox();
            this.cbosy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbosemester = new System.Windows.Forms.ComboBox();
            this.tb_search2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsv2 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbosy1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbosem = new System.Windows.Forms.ComboBox();
            this.group_box_subjects.SuspendLayout();
            this.group_box_taken.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(22, 64);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(46, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "label1";
            // 
            // lsv1
            // 
            this.lsv1.FullRowSelect = true;
            this.lsv1.GridLines = true;
            this.lsv1.Location = new System.Drawing.Point(13, 108);
            this.lsv1.Name = "lsv1";
            this.lsv1.Size = new System.Drawing.Size(423, 335);
            this.lsv1.TabIndex = 1;
            this.lsv1.UseCompatibleStateImageBehavior = false;
            this.lsv1.View = System.Windows.Forms.View.Details;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(442, 36);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(223, 31);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Assign Subjects";
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(520, 320);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 39);
            this.btn_transfer.TabIndex = 3;
            this.btn_transfer.Text = ">>";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // tb_search1
            // 
            this.tb_search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search1.Location = new System.Drawing.Point(295, 77);
            this.tb_search1.Name = "tb_search1";
            this.tb_search1.Size = new System.Drawing.Size(141, 22);
            this.tb_search1.TabIndex = 5;
            this.tb_search1.TextChanged += new System.EventHandler(this.tb_search1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Subject:";
            // 
            // group_box_subjects
            // 
            this.group_box_subjects.Controls.Add(this.label5);
            this.group_box_subjects.Controls.Add(this.tb_search1);
            this.group_box_subjects.Controls.Add(this.label1);
            this.group_box_subjects.Controls.Add(this.lsv1);
            this.group_box_subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_box_subjects.Location = new System.Drawing.Point(12, 98);
            this.group_box_subjects.Name = "group_box_subjects";
            this.group_box_subjects.Size = new System.Drawing.Size(458, 461);
            this.group_box_subjects.TabIndex = 7;
            this.group_box_subjects.TabStop = false;
            this.group_box_subjects.Text = "All Subjects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "All Subjects";
            // 
            // group_box_taken
            // 
            this.group_box_taken.Controls.Add(this.cbosy);
            this.group_box_taken.Controls.Add(this.label4);
            this.group_box_taken.Controls.Add(this.label3);
            this.group_box_taken.Controls.Add(this.cbosemester);
            this.group_box_taken.Controls.Add(this.tb_search2);
            this.group_box_taken.Controls.Add(this.label2);
            this.group_box_taken.Controls.Add(this.lsv2);
            this.group_box_taken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_box_taken.Location = new System.Drawing.Point(632, 98);
            this.group_box_taken.Name = "group_box_taken";
            this.group_box_taken.Size = new System.Drawing.Size(458, 461);
            this.group_box_taken.TabIndex = 8;
            this.group_box_taken.TabStop = false;
            this.group_box_taken.Text = "Subjects to Handle";
            // 
            // cbosy
            // 
            this.cbosy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Location = new System.Drawing.Point(315, 38);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(121, 26);
            this.cbosy.TabIndex = 10;
            this.cbosy.SelectedIndexChanged += new System.EventHandler(this.cbosy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "School Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Semester:";
            // 
            // cbosemester
            // 
            this.cbosemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosemester.FormattingEnabled = true;
            this.cbosemester.Location = new System.Drawing.Point(91, 38);
            this.cbosemester.Name = "cbosemester";
            this.cbosemester.Size = new System.Drawing.Size(121, 26);
            this.cbosemester.TabIndex = 7;
            this.cbosemester.SelectedIndexChanged += new System.EventHandler(this.cbosemester_SelectedIndexChanged);
            // 
            // tb_search2
            // 
            this.tb_search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search2.Location = new System.Drawing.Point(295, 81);
            this.tb_search2.Name = "tb_search2";
            this.tb_search2.Size = new System.Drawing.Size(141, 22);
            this.tb_search2.TabIndex = 5;
            this.tb_search2.TextChanged += new System.EventHandler(this.tb_search2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Subject:";
            // 
            // lsv2
            // 
            this.lsv2.ContextMenuStrip = this.contextMenuStrip1;
            this.lsv2.FullRowSelect = true;
            this.lsv2.GridLines = true;
            this.lsv2.Location = new System.Drawing.Point(13, 108);
            this.lsv2.Name = "lsv2";
            this.lsv2.Size = new System.Drawing.Size(423, 327);
            this.lsv2.TabIndex = 1;
            this.lsv2.UseCompatibleStateImageBehavior = false;
            this.lsv2.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // cbosy1
            // 
            this.cbosy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosy1.FormattingEnabled = true;
            this.cbosy1.Location = new System.Drawing.Point(493, 288);
            this.cbosy1.Name = "cbosy1";
            this.cbosy1.Size = new System.Drawing.Size(121, 21);
            this.cbosy1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "School Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Semester:";
            // 
            // cbosem
            // 
            this.cbosem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosem.FormattingEnabled = true;
            this.cbosem.Location = new System.Drawing.Point(493, 238);
            this.cbosem.Name = "cbosem";
            this.cbosem.Size = new System.Drawing.Size(121, 21);
            this.cbosem.TabIndex = 11;
            // 
            // frmAssignSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.cbosy1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group_box_taken);
            this.Controls.Add(this.group_box_subjects);
            this.Controls.Add(this.cbosem);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmAssignSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAssignSubject_Load);
            this.group_box_subjects.ResumeLayout(false);
            this.group_box_subjects.PerformLayout();
            this.group_box_taken.ResumeLayout(false);
            this.group_box_taken.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_transfer;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.ListView lsv1;
        public System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox tb_search1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_box_subjects;
        private System.Windows.Forms.GroupBox group_box_taken;
        private System.Windows.Forms.TextBox tb_search2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView lsv2;
        private System.Windows.Forms.ComboBox cbosy;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbosemester;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbosy1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbosem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}