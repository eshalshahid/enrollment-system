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
    public partial class frmEditSubject : Form
    {
        public frmEditSubject(string id)
        {
            InitializeComponent();
            txtSubjectID.Text = id;
        }
        SQLConfig config = new SQLConfig();
        string sql, messageFalse, messageTrue;
        private void frmEditSubject_Load(object sender, EventArgs e)
        {

        }

        private void txtSubjectID_TextChanged(object sender, EventArgs e)
        {

            sql = "SELECT ACADYR FROM ay";
            config.fiil_CBO(sql, cbosy);

            sql = "SELECT LEVEL FROM level";
            config.fiil_CBO(sql, cboYear);


            sql = "SELECT  * FROM `subject` WHERE `SUBJ_ID`='" + txtSubjectID.Text + "'";
            config.singleResult(sql);
            txtsujCode.Text = config.dt.Rows[0].Field<string>("SUBJ_CODE");
            txtsubjDesc.Text = config.dt.Rows[0].Field<string>("SUBJ_DESCRIPTION");
            cboYear.Text = config.dt.Rows[0].Field<string>("YR");

        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if (txtsubjDesc.Text == "" || txtsujCode.Text == "") {
                MessageBox.Show("Empty fields must be filled up.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "UPDATE `subject` SET `SUBJ_CODE`='" + txtsujCode.Text + "', `SUBJ_DESCRIPTION`='" + txtsubjDesc.Text + "', `YR`='"
                + cboYear.Text + "' WHERE SUBJ_ID ='" + txtSubjectID.Text + "'";
            messageTrue = "Subject has been updated.";
            messageFalse = "Failed to update a sabject.";
            config.Execute_CUD(sql, messageFalse, messageTrue);
        }
    }
}
