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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, messageTrue, messageFalse;


        private void tsNew_Click(object sender, EventArgs e)
        {
            sql = "SELECT ACCOUNT_ID,`ACCOUNT_NAME` as 'Full Name', `ACCOUNT_USERNAME` as 'Username', `ACCOUNT_TYPE` as 'Type'FROM `useraccounts`";
            config.Load_DTG(sql, dtglist);
            dtglist.Columns[0].Visible = false;
            funct.clearTxt(GroupBox1);
            lblId.Text = "";
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM useraccounts WHERE  ACCOUNT_ID='" + dtglist.CurrentRow.Cells[0].Value + "'";
            messageTrue = "User has beeen deleted.";
            messageFalse = "Failed to delete the user.";
            config.Execute_CUD(sql, messageFalse, messageTrue);
            tsNew_Click(sender, e);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT * FROM `useraccounts` WHERE ACCOUNT_ID='" + dtglist.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            lblId.Text = config.dt.Rows[0].Field<int>(0).ToString();
            txtName.Text = config.dt.Rows[0].Field<string>(1);
            txtUname.Text = config.dt.Rows[0].Field<string>(2); 
            cboType.Text = config.dt.Rows[0].Field<string>(4);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            tsNew_Click(sender, e);
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if( txtName.Text == "" || txtPass.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("You must fill up all the textboxes in order to save.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            if (lblId.Text != "") {
                sql = "UPDATE `useraccounts` SET `ACCOUNT_NAME`='" + txtName.Text 
                    + "', `ACCOUNT_USERNAME`='" + txtUname.Text
                    + "', `ACCOUNT_PASSWORD`=sha('" + txtPass.Text + "'), `ACCOUNT_TYPE`='" + cboType.Text 
                    + "'  WHERE ACCOUNT_ID='" + lblId.Text + "'";
                messageTrue = "User has beeen updated.";
                messageFalse = "Failed to update the user.";
                config.Execute_CUD(sql, messageFalse, messageTrue);
            }
            else
            {
                sql = "INSERT INTO `useraccounts` (`ACCOUNT_NAME`, `ACCOUNT_USERNAME`, `ACCOUNT_PASSWORD`, `ACCOUNT_TYPE`)"
                + " VALUES ('" + txtName.Text + "','" + txtUname.Text + "',sha('" + txtPass.Text + "'),'" + cboType.Text + "')";
                messageTrue = "User has beeen saved.";
                messageFalse = "Failed to save the user.";
                config.Execute_CUD(sql, messageFalse, messageTrue);

            }
            tsNew_Click(sender, e);
        }
    }
}
