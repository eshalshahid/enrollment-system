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
    public partial class frmLevel : Form
    {
        public frmLevel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql,id;
        int maxrow;
        private void frmLevel_Load(object sender, EventArgs e)
        {
            sql = "SELECT `YR_ID` as 'ID', `LEVEL` FROM `level`";
            config.Load_DTG(sql, dtgList);
            txtLevel.Clear();
            txtLevel.Focus();
            dtgList.ClearSelection();
            id = "0";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `YR_ID` as 'ID', `LEVEL` FROM `level` WHERE LEVEL LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtgList);
            
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            id = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtLevel.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM level WHERE YR_ID = '" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);
            MessageBox.Show("Data has been deleted in the database.");
            frmLevel_Load(sender, e);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (id == "0")
            {
                sql = "SELECT * FROM level WHERE LEVEL LIKE '%" + txtLevel.Text + "%'";
                config.singleResult(sql);
                maxrow = config.dt.Rows.Count;
                if (maxrow > 0)
                {
                    MessageBox.Show("Data is already exist!", "Inavlid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sql = "INSERT INTO  `level`  (`LEVEL`) VALUES ('" + txtLevel.Text + "')";
                    config.Execute_Query(sql);
                    MessageBox.Show("New Data has been saved in the database.");
                }

            }
            else
            {
                sql = "UPDATE level SET LEVEL ='" + txtLevel.Text + "' WHERE YR_ID='" + id + "'";
                config.Execute_Query(sql);
                MessageBox.Show("Data has been updated in the database.");
            }
            frmLevel_Load(sender, e);
          
        }
    }
}
