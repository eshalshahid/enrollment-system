using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        public void enabled_menu()
        {
            ts_Enrollment.Enabled = true;
            ts_Maintenance.Enabled = true;
            ts_students.Enabled = true;
            ts_Subject.Enabled = true;
            ts_User.Enabled = true;
            ts_Reports.Enabled = true;
            ts_Login.Text = "Logout";
        }

        public void disabled_menu()
        {
            ts_Enrollment.Enabled = false;
            ts_Maintenance.Enabled = false;
            ts_students.Enabled = false;
            ts_Subject.Enabled = false;
            ts_User.Enabled = false;
            ts_Reports.Enabled = false;
        }
        public void showForm(Form frm)
        {
            closeForm(); 

            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void registerNewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddStudent();
            showForm(frm);
        }

        private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListofStudents();
            showForm(frm);
        }

        private void enrollmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollStudents();
            showForm(frm);
        }

        private void listOfEnrolledStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrolledStudents();
            showForm(frm);
        }

        private void registerNewSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSubjects();
            showForm(frm);
        }

        private void listOfSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListofSubject();
            showForm(frm);
        }

        private void manageAcademicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSy();
            showForm(frm);
        }

        private void manageGradeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLevel();
            showForm(frm);
        }

        private void manageSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSection();
            showForm(frm);
        }

        private void ts_Reports_Click(object sender, EventArgs e)
        {
            Form frm = new frmReports();
            showForm(frm);
        }

        private void ts_User_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            showForm(frm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }

        private void ts_Login_Click(object sender, EventArgs e)
        {
            if (ts_Login.Text == "Login")
            {
                Form frm = new frmLogin(this);
                frm.ShowDialog();
            }
            else
            {
                disabled_menu();
                ts_Login.Text = "Login";
                closeForm();
            }
        }
    }
}
