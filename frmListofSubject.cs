using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrollmentSystem.Includes;


namespace EnrollmentSystem
{
    public partial class frmListofSubject : Form
    {
        public frmListofSubject()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, messageTrue, messageFalse;
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            sql = "SELECT  `SUBJ_ID` as 'SubjectID', `SUBJ_CODE` as 'Subject', `SUBJ_DESCRIPTION` as 'Description', `YR` as 'Level'  FROM `subject` WHERE SUBJ_CODE LIKE '%" + tsSearch.Text + "%' OR SUBJ_DESCRIPTION LIKE '%" + tsSearch.Text + "%' OR SUBJ_ID LIKE '%" + tsSearch.Text + "%' OR YR LIKE '%" + tsSearch.Text + "%'";
            config.Load_DTG(sql, dtgList);
        }

        private void frmListofSubject_Load(object sender, EventArgs e)
        {
            ToolStripButton1_Click(sender, e);
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditSubject(dtgList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog(); 
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmSubjects();
            frm.ShowDialog();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `subject` WHERE `SUBJ_ID`='" + dtgList.CurrentRow.Cells[0].Value + "'";
            messageTrue = "Subject has been deleted.";
            messageFalse = "Subject failed to delete.";
            config.Execute_CUD(sql, messageFalse, messageTrue);
            frmListofSubject_Load(sender, e);
        }
    }
}
