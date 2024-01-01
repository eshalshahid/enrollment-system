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
    public partial class frmSy : Form
    {
        public frmSy()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql, id;
        int  maxrow;

        private void frmSy_Load(object sender, EventArgs e)
        {
            sql = "SELECT `AY_ID` as 'ID', `ACADYR` as 'School Year' FROM `ay`";
            config.Load_DTG(sql, dtgList);
            txtsy.Clear();
            txtsy.Focus();
            id = "0";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `AY_ID` as 'ID', `ACADYR` as 'School Year' FROM `ay` WHERE ACADYR LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtgList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM ay WHERE AY_ID = '" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);
            MessageBox.Show("Data has been deleted in the database.");
            frmSy_Load(sender, e);
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            id = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtsy.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                sql = "SELECT * FROM ay WHERE ACADYR LIKE '%" + txtsy.Text + "%'";
                config.singleResult(sql);
                maxrow = config.dt.Rows.Count;
                if(maxrow > 0)
                {
                    MessageBox.Show("Data is already exist!", "Inavlid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sql = "INSERT INTO  `ay`  (`ACADYR`) VALUES ('"+ txtsy.Text + "')";
                    config.Execute_Query(sql);
                    MessageBox.Show("New Data has been saved in the database.");
                }
            }
            else
            {
                sql = "UPDATE ay SET ACADYR ='" + txtsy.Text + "' WHERE AY_ID='" + id + "'";
                config.Execute_Query(sql);
                MessageBox.Show("Data has been updated in the database.");
            }

            frmSy_Load(sender, e);
        }
    }
}
