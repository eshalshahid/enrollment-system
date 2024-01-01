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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql, radioSEX, Ryesno, Nyesno, Pyesno, Cyesno;

        private void ts_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDbirth_ValueChanged(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpDbirth.Value.ToString("yyyy")); 
            txtAge.Text = age.ToString();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            func.clearTxt(GroupBox1);
            txtStudentId.Clear();
            rdoMale.Checked = true;
            rdoFemale.Checked = false;
            chkBirthCert.Checked = false;
            chkPic.Checked = false;
            chkReportCard.Checked = false;
            chkCertification.Checked = false;

            sql = "SELECT ACADYR FROM ay";
            config.fiil_CBO(sql, cboAddSy); 
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        { 

            tsNew_Click(sender, e);

            config.autonumber("StudentID", txtStudentId);
            txtLName.Focus();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if(txtStudentId.Text == "")
            {
                MessageBox.Show("One of the box is empty on the student details,You must fill it", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //foreach(Control txt in GroupBox1.Controls)
            //{
            //    if(txt is TextBox)
            //    {
            //        MessageBox.Show("One of the box is empty on the student details,You must fill it", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}

            if (rdoMale.Checked)
            {
                radioSEX = "MALE";
            }
            else
            {
                radioSEX = "FEMALE";
            }

            Nyesno = func.checkOption(chkBirthCert);
            Cyesno = func.checkOption(chkCertification);
            Pyesno = func.checkOption(chkPic);
            Ryesno = func.checkOption(chkReportCard);

            sql = "INSERT INTO  `tblrequirements` (`NSO`, `PICID`, `REPORTCARD`, `CERTIFICATE_OF_TRANSFER`, `IDNO`) "
                    + "VALUES ('" + Nyesno + "','" + Pyesno + "','" + Ryesno
                    + "','" + Cyesno + "','" + txtStudentId.Text + "')";
            config.Execute_Query(sql);

            sql = "INSERT INTO tblstudent(`IDNO`, `FNAME`, `LNAME`, `MNAME`, `SEX`, `BDAY`, `BPLACE`, `AGE`, `HOME_ADD`, `GUARDIAN`,`GUARDIAN_ADD`,`GUARDIAN_TEL`,`LASTSCHOOLATTEND`,`HEIGTH`,`WEIGTH`) "
                + "VALUES ('" + txtStudentId.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtMName.Text
                + "','" + radioSEX + "','" + dtpDbirth.Text + "','" + txtPBirth.Text + "','" + txtAge.Text + "','"
                + txtAddress.Text + "','" + txtguardian.Text + "','" + txtguardianadd.Text + "','" + txtguardiantel.Text
                + "','" + txtLastSchoolAttend.Text + "','" + txtHeight.Text + "','"
                + txtWeigth.Text + "')";
            config.Execute_CUD(sql, "error to save the data", "Student has been registered.");


            sql = "Update tblautonumber set EndValue = EndValue + IncrementValue WHERE Remarks='StudentID'";
            config.Execute_Query(sql);

            tsNew_Click(sender, e);
             
        }
    }
}
