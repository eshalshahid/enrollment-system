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
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;
        }

        public frmLogin()
        {
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM useraccounts" 
               + " WHERE  `ACCOUNT_USERNAME` = '" + UsernameTextBox.Text 
               + "' AND `ACCOUNT_PASSWORD` = sha('" + PasswordTextBox.Text + "')";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                frm.enabled_menu();
                MessageBox.Show("Welcome " + config.dt.Rows[0].Field<string>("ACCOUNT_TYPE"));
                this.Close();
            }
            else
            {
                MessageBox.Show("", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidateLogin(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
