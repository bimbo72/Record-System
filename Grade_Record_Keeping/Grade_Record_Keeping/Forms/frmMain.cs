using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Grade_Record_Keeping.Class;
namespace Grade_Record_Keeping.Forms
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
      

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent f = new frmStudent();
            f.ShowDialog();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCourse flc = new frmListCourse();
            List<string> list_v = new List<string>(new string[] { "Id", "Course Initial", "Course Name" });
            Global_Vars.md.LoadListHeader(flc.lsv, list_v);
            flc.ShowDialog();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            frmListSemester fls = new frmListSemester();
            List<string> list_v = new List<string>(new string[] { "Semester Id", "Semester"});
            Global_Vars.md.LoadListHeader(fls.lsv, list_v);
            fls.ShowDialog();
        }

        private void schoolYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSchoolYear fls = new frmListSchoolYear();
            List<string> list_v = new List<string>(new string[] { "School Year Id", "School Year" });
            Global_Vars.md.LoadListHeader(fls.lsv, list_v);
            fls.ShowDialog();
        }

        private void insructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInstructor fli = new frmListInstructor();
            List<string> list_v = new List<string>(new string[] { "Id", "Instructor Id", "Fisrt Name", "Middle Name", "LastName" });
            Global_Vars.md.LoadListHeader(fli.lsv, list_v);
            fli.ShowDialog();
        }

        private void subjectModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubjectModule flsm = new frmListSubjectModule();
            List<string> list_v = new List<string>(new string[] { "Module Id", "Module" });
            Global_Vars.md.LoadListHeader(flsm.lsv, list_v);
            flsm.ShowDialog();
        }

        private void gradeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListGradeStatus flgs = new frmListGradeStatus();
            List<string> list_v = new List<string>(new string[] { "Id", "Grade Status Initial", "Grade Status" });
            Global_Vars.md.LoadListHeader(flgs.lsv, list_v);
            flgs.ShowDialog();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubjects fls = new frmListSubjects();
            List<string> list_v = new List<string>(new string[] { "Id", "Code","Description","Unit","Module" });
            Global_Vars.md.LoadListHeader(fls.lsv, list_v);
            fls.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInstructorAssign fli = new frmListInstructorAssign();
            List<string> list_v = new List<string>(new string[] { "Id", "Instructor Id", "Fisrt Name", "Middle Name", "LastName" });
            Global_Vars.md.LoadListHeader(fli.lsv, list_v);
            fli.ShowDialog();
        }

        private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStudents fls = new frmListStudents();
            List<string> list_v = new List<string>(new string[] { "Id", "Student Id", "Fisrt Name", "Middle Name", "LastName" });
            Global_Vars.md.LoadListHeader(fls.lsv, list_v);
            fls.ShowDialog();
        }
     
    }
}
