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
    public partial class frmEnrollStudents : Form
    {
        public frmEnrollStudents()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmEnrollStudents_Load(object sender, EventArgs e)
        {

            sql = "SELECT CONCAT( `LNAME`,', ', `FNAME`,' ', `MNAME`) FROM `tblstudent`";
            config.autocomplete(sql, txtsearch);

            sql = "SELECT `IDNO`, CONCAT( `LNAME`,', ', `FNAME`,' ', `MNAME`) as 'FULL NAME'  FROM `tblstudent`";
            config.Load_DTG(sql, dtgList);

            dtgList.Font = new Font("Arial", 9);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `IDNO`, CONCAT( `LNAME`,', ', `FNAME`,' ', `MNAME`) as 'FULL NAME'  FROM `tblstudent` WHERE CONCAT( `LNAME`,', ', `FNAME`,' ', `MNAME`) LIKE '%" + txtsearch.Text + "%' OR LNAME LIKE '%" + txtsearch.Text + "%' OR FNAME LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtgList);
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            
             
        }
 
        private void cboLevel_SelectedValueChanged(object sender, EventArgs e)
        { 
            sql = "SELECT `SUBJ_CODE` as 'Subject', `SUBJ_DESCRIPTION` as 'Description' FROM `subject` WHERE `YR` = '" + cboLevel.Text + "'";
            config.Load_DTG(sql, dtgSubject);
            dtgSubject.Font = new Font("Arial", 9);

            sql = "SELECT `SECTION` FROM `tblsection` WHERE LEVEL='" + cboLevel.Text + "'";
            config.fiil_CBO(sql, cbosection);


        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            string id = dtgList.CurrentRow.Cells[0].Value.ToString();
            string level;

            if(txtFullname.Text == "")
            {
                MessageBox.Show("Fill the name of the students.", "Action is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = "SELECT * FROM `tblstudupdatelevel` WHERE `IDNO` ='" + id + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                level = config.dt.Rows[0].Field<string>("LEVEL");



                sql = "UPDATE `tblstudupdatelevel` SET  "
                        + "`LEVEL`='" + cboLevel.Text + "',SECTION = '" + cbosection.Text
                        + "' ,`AY`= '" + cbosy.Text + "' WHERE `IDNO`='" + id + "'";
                config.Execute_Query(sql);
            }
            else
            {

                sql = "INSERT INTO `tblstudupdatelevel` (`IDNO`, `LEVEL`,SECTION, `AY`) "
                    + "VALUES ('" + id + "','" + cboLevel.Text + "','"
                    + cbosection.Text + "','" + cbosy.Text + "')";
                config.Execute_Query(sql);
            }




            //            'for school year of student 
            sql = "INSERT INTO `schoolyr` (`AY`, `YR`,SECTION, `IDNO`, `STATUS`) " 
                + "VALUES ('" + cbosy.Text +"','" + cboLevel.Text + "','" 
                + cbosection.Text + "','" + id + "','')";
            config.Execute_CUD(sql, "error to save", "Students has been enrolled.");





            sql = "SELECT * FROM `tblstudupdatelevel` l,`schoolyr`  sy, `subject` s "
                + "WHERE  l.IDNO=sy.IDNO AND l.LEVEL = sy.YR AND sy.`YR` =s.`YR` AND sy.`IDNO` = '" + id + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach(DataRow r in config.dt.Rows)
                {
                    sql = "INSERT INTO `grades` (`IDNO`, `SUBJ_ID`, `SYID` ) " 
                               + " VALUES ('" + id + "','" + r.Field<int>("SUBJ_ID") + "','" + r.Field<int>("SYID") + "')";
                    config.Execute_Query(sql);

                }
            }

            btnClear_Click(sender, e);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox1);
            funct.clearTxt(GroupBox4);
            cbosy.Text = "";
            cbosy.DataSource = null;
            cboLevel.Text = "";
            cboLevel.DataSource = null;
            cbosection.Text = "";
            cbosection.DataSource = null; 
            dtgSubject.Columns.Clear();
             
        }

        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT `IDNO`, CONCAT( `LNAME`,', ', `FNAME`,' ', `MNAME`) as 'FULL NAME', `SEX`"
              + ", `AGE`, `HOME_ADD` as 'ADDRESS'"
              + " FROM `tblstudent` WHERE `IDNO` = '" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtFullname.Text = config.dt.Rows[0].Field<string>("FULL NAME");

                sql = " SELECT * FROM `tblstudupdatelevel` "
                        + "WHERE `IDNO` ='" + dtgList.CurrentRow.Cells[0].Value + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    txtLevel.Text = config.dt.Rows[0].Field<string>("LEVEL");
                    txtSection.Text = config.dt.Rows[0].Field<string>("SECTION");
                }
                else
                {
                    txtLevel.Text = "New";
                    txtSection.Text = "New";
                }

                sql = "SELECT ACADYR FROM ay";
                config.fiil_CBO(sql, cbosy);

                sql = "SELECT  LEVEL FROM `level`";
                config.combo(sql, cboLevel);

                cbosection.DataSource = null;
                cbosection.Text = "Select";

                //sql = "SELECT  SECTION FROM `tblsection`";
                //config.fiil_CBO(sql, cbosection);

                dtgSubject.Columns.Clear();
            }
        }
    }
}
