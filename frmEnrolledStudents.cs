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
    public partial class frmEnrolledStudents : Form
    {
        public frmEnrolledStudents()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;
        private void tsFind_Click(object sender, EventArgs e)
        {
            sql = "SELECT s.`IDNO`, CONCAT(`FNAME` ,' ', `LNAME`,' ', `MNAME`) as 'FULL NAME', `SEX` , `AGE`, `HOME_ADD` as 'ADDRESS' ,`LEVEL` , `SECTION`  , `AY` " +
                   " FROM `tblstudent` s, `tblstudupdatelevel` sl WHERE s.`IDNO`=sl.`IDNO` AND ( CONCAT(`FNAME` ,' ', `LNAME`,' ', `MNAME`) LIKE '%" + tsSearch.Text + "%' OR FNAME LIKE '%" + tsSearch.Text +
                   "' OR LNAME LIKE '%" + tsSearch.Text + "' OR LEVEL LIKE '%" + tsSearch.Text + "' OR SECTION LIKE '%" + tsSearch.Text + "' OR AY LIKE '%" + tsSearch.Text +
                   "' OR CONCAT(`LEVEL` ,' ', `AY`) LIKE '%" + tsSearch.Text + "' OR CONCAT(`LEVEL` ,' ', `SECTION`) LIKE '%" + tsSearch.Text + "' OR CONCAT(`LNAME` ,' ', `AY`) LIKE '%" + tsSearch.Text + "')";
            config.Load_DTG(sql, dtgList);
        }

        private void frmEnrolledStudents_Load(object sender, EventArgs e)
        {
            tsFind_Click(sender, e);
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            Form frm = new frmPrintEnrolledSubject(dtgList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
