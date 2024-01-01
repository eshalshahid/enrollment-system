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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent(string studentid)
        {
            InitializeComponent();

            txtStudentId.Text = studentid;
        }

        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql, radioSEX, Ryesno, Nyesno, Pyesno, Cyesno;

        private void tsSave_Click(object sender, EventArgs e)
        {


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

            //'student(requirements)
            sql = "UPDATE  `tblrequirements` SET `NSO`='" + Nyesno + "', `PICID`='" + Pyesno + "', `REPORTCARD`='" + Ryesno
                    + "', `CERTIFICATE_OF_TRANSFER`='" + Cyesno + "' WHERE IDNO='" + txtStudentId.Text + "'";
            config.Execute_Query(sql);
            //'student basic info
            sql = "UPDATE tblstudent SET   `FNAME`='" + txtFName.Text + "', `LNAME`='" + txtLName.Text + "', `MNAME`='" + txtMName.Text 
                    + "', `SEX`='" + radioSEX + "', `BDAY`='" + dtpDbirth.Text + "', `BPLACE`='" + txtPBirth.Text + "', `AGE`='" + txtAge.Text 
                    + "', `HOME_ADD`='" + txtAddress.Text + "',GUARDIAN='" + txtguardian.Text + "',GUARDIAN_ADD ='" + txtguardianadd.Text 
                    + "',GUARDIAN_TEL ='" + txtguardiantel.Text + "',`LASTSCHOOLATTEND`='" + txtLastSchoolAttend.Text 
                    + "', WEIGTH='" + txtWeigth.Text + "',HEIGTH='" + txtHeight.Text + "' WHERE IDNO='" + txtStudentId.Text + "'";
            config.Execute_CUD(sql, "error to update the data", "Student information has been updated.");
 
        }

        private void ts_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            txtStudentId_TextChanged(sender, e);
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

            sql = "SELECT ACADYR FROM ay";
            config.fiil_CBO(sql, cboAddSy);


            sql = "SELECT * FROM tblstudent WHERE IDNO = '" + txtStudentId.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                txtFName.Text = config.dt.Rows[0].Field<string>("FNAME");
                txtLName.Text =config.dt.Rows[0].Field<string>("LNAME");
                txtMName.Text =config.dt.Rows[0].Field<string>("MNAME");
                txtAddress.Text =config.dt.Rows[0].Field<string>("HOME_ADD");
                txtguardian.Text =config.dt.Rows[0].Field<string>("GUARDIAN");
                txtguardianadd.Text =config.dt.Rows[0].Field<string>("GUARDIAN_ADD");
                txtguardiantel.Text =config.dt.Rows[0].Field<int>("GUARDIAN_TEL").ToString();
                txtPBirth.Text =config.dt.Rows[0].Field<string>("BPLACE");
                dtpDbirth.Text =config.dt.Rows[0].Field<DateTime>("BDAY").ToString();
                txtAge.Text =config.dt.Rows[0].Field<int>("AGE").ToString();
                txtWeigth.Text =config.dt.Rows[0].Field<int>("WEIGTH").ToString();
                txtHeight.Text =config.dt.Rows[0].Field<int>("HEIGTH").ToString();
                txtLastSchoolAttend.Text =config.dt.Rows[0].Field<string>("LASTSCHOOLATTEND"); 


                if (config.dt.Rows[0].Field<string>("SEX") == "FEMALE")
                {
                    rdoFemale.Checked = true;
                }
                else
                {
                    rdoMale.Checked = true;
                }


                //    'students requirements 
                sql = "SELECT * FROM `tblrequirements`  WHERE IDNO = '" + txtStudentId.Text + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    if(config.dt.Rows[0].Field<string>("NSO") == "Yes")
                    {
                        chkBirthCert.Checked = true;
                    }
                    else
                    {
                        chkBirthCert.Checked = false;
                    }

                    if(config.dt.Rows[0].Field<string>("PICID") == "Yes")
                    {
                        chkPic.Checked = true;
                    }
                    else
                    {
                        chkPic.Checked = false;
                    }



                    if(config.dt.Rows[0].Field<string>("REPORTCARD") == "Yes")
                    {
                        chkReportCard.Checked =true;
                    }
                    else
                    {
                        chkReportCard.Checked = false;
                    }

                    if(config.dt.Rows[0].Field<string>("CERTIFICATE_OF_TRANSFER") == "Yes")
                    {
                        chkCertification.Checked = true;
                    }
                    else
                    {
                        chkCertification.Checked = false;
                    }
                        
                }
                 

            }
            
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
