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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void tsNew_Click(object sender, EventArgs e)
        {
            sql = "SELECT ACADYR FROM ay";
            config.fiil_CBO(sql, cbosy);

            sql = "SELECT LEVEL FROM level";
            config.fiil_CBO(sql, cboYear);

            txtsubjDesc.Clear();
            txtsujCode.Clear();
            txtsujCode.Focus();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            tsNew_Click(sender, e);
        }

        private void tsList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            string messageTrue, messageFalse;
            if (txtsubjDesc.Text == "" || txtsujCode.Text == "") {
                MessageBox.Show("Empty fields must be filled up.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "INSERT INTO `subject` (`SUBJ_CODE`, `SUBJ_DESCRIPTION`, `YR`)"
                 + " VALUES ('" + txtsujCode.Text + "','" + txtsubjDesc.Text + "','"
                 + cboYear.Text  + "')";
            messageTrue = "Subject has been saved.";
            messageFalse = "Failed to save a sabject.";
            config.Execute_CUD(sql, messageFalse, messageTrue);

            tsNew_Click(sender, e);
        }
    }
}
