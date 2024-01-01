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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;
        private void reports(string sql, string rptname)
        {

            try
            {

                config.loadReports(sql);

                string reportname = rptname;


                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\reports\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }


        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            sql = "SELECT  `LEVEL` FROM `level`";
            config.fiil_CBO(sql, cboLevel);

            sql = "SELECT  `ACADYR` FROM `ay`";
            config.fiil_CBO(sql, cbosy);

            sql = "SELECT  `SECTION` FROM `tblsection` WHERE LEVEL='" + cboLevel.Text + "'";
            config.fiil_CBO(sql, cbo_section);
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reports("SELECT s.`IDNO`, CONCAT ( `LNAME`, ' , ',`FNAME` , ' ',`MNAME`) as 'Name', `SEX`, `AGE`, `HOME_ADD`, `AY`, `YR`, `STATUS` "
             + "FROM `tblstudent`  s,`schoolyr` sy WHERE  s.`IDNO`=sy.`IDNO` AND YR ='" + cboLevel.Text 
             + "' AND AY = '" + cbosy.Text + "' AND SECTION = '" + cbo_section.Text + "'", "studentbygender");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            reports("SELECT Concat(`FNAME`,' ', `LNAME`,' ', `MNAME`) AS 'FULL NAME',`AY`, `YR`,`SEX`, `HOME_ADD` FROM `tblstudent` s, `schoolyr` sy WHERE  s.`IDNO`=sy.`IDNO`", "chart");
        }
    }
}
