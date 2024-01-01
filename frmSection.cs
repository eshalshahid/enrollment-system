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
    public partial class frmSection : Form
    {
        public frmSection()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql,id;
        int maxrow;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `SECTIONID` as 'ID', `SECTION`,LEVEL FROM `tblsection` WHERE SECTION LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtgList);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (id == "0")
            {
                sql = "SELECT * FROM tblsection WHERE  SECTION = '" + txtSection.Text + "' AND LEVEL='" + cboLevel.Text + "'";
                config.singleResult(sql);
                maxrow = config.dt.Rows.Count;
                 if(maxrow > 0)
                {
                    MessageBox.Show("Data is already exist!", "Inavlid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sql = "INSERT INTO  `tblsection`  (`SECTION`,LEVEL) VALUES ('" + txtSection.Text + "','" + cboLevel.Text + "')";
                    config.Execute_Query(sql);
                    MessageBox.Show("New Data has been saved in the database.");
                } 
            }
            else
            {

                sql = "SELECT * FROM tblsection WHERE SECTION = '" + txtSection.Text + "' AND LEVEL='" + cboLevel.Text + "'";
                config.singleResult(sql);
                maxrow = config.dt.Rows.Count;
                if (maxrow > 0)
                {
                    MessageBox.Show("Data is already exist!", "Inavlid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    sql = "UPDATE tblsection SET SECTION ='" + txtSection.Text + "',LEVEL ='" + cboLevel.Text + "' WHERE SECTIONID='" + id + "'";
                    config.Execute_Query(sql);
                    MessageBox.Show("Data has been updated in the database.");
                }
                 
            }
            frmSection_Load(sender, e);
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            txtSection.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
            cboLevel.Text = dtgList.CurrentRow.Cells[2].Value.ToString();
            id = dtgList.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tblsection WHERE SECTIONID = '" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);
            MessageBox.Show("Data has been deleted in the database.");
            frmSection_Load(sender, e);
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            sql = "SELECT `SECTIONID` as 'ID', `SECTION`,LEVEL FROM `tblsection`";
            config.Load_DTG(sql, dtgList);
            txtSection.Clear();
            txtSection.Focus();
            id = "0";

            sql = "SELECT  `LEVEL` FROM `level`";
            config.fiil_CBO(sql, cboLevel);
        }
    }
}
