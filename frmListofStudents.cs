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
using EnrollmentSystem.Properties;

namespace EnrollmentSystem
{
    public partial class frmListofStudents : Form
    {
        public frmListofStudents()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql;

        private void tsFind_Click(object sender, EventArgs e)
        {
            sql = "SELECT `IDNO`, CONCAT(`FNAME` ,' ', `LNAME`,' ', `MNAME`) as 'FULL NAME', `SEX` , `AGE`, `HOME_ADD` as 'ADDRESS'  FROM `tblstudent` WHERE CONCAT(`FNAME` ,' ', `LNAME`,' ', `MNAME`) LIKE '%" + tsSearch.Text + "%' OR FNAME LIKE '%" + tsSearch.Text + "%' OR LNAME LIKE '%" + tsSearch.Text + "%'";
            config.Load_DTG(sql, dtgList);

            tsDelete.Enabled = false;
        
        }

        private void frmListofStudents_Load(object sender, EventArgs e)
        {
            tsFind_Click(sender, e);
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `tblstudent` WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM `schoolyr`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `studentsubjects`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `tblrequirements`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `tblstuddetails`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `tblstudsiblings`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `tblstudupdatelevel`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            sql = "DELETE FROM `grades`  WHERE `IDNO`='" + dtgList.CurrentRow.Cells[0].Value + "'";
             config.Execute_Query(sql);

            tsFind_Click(sender, e);
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsDelete.Enabled = true;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            frmEditStudent frm = new frmEditStudent(dtgList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent();
            frm.ShowDialog();
        }
    }
}
