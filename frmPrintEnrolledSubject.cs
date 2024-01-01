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
    public partial class frmPrintEnrolledSubject : Form
    {
        public frmPrintEnrolledSubject(string id)
        {
            InitializeComponent();

            sql = "SELECT CONCAT(  `FNAME` ,  ' ',  `LNAME` ,  ' ',  `MNAME` ) AS  'NAME',  `LEVEL` ,  `SECTION` , l.`AY` ,  `SUBJ_CODE`,`SUBJ_DESCRIPTION`, s.`IDNO` "
              + " FROM  `tblstudent` s,  `tblstudupdatelevel` l,  `grades` g,  `subject` sub"
              + " WHERE s.`IDNO` = l.`IDNO` "
              + " AND l.`IDNO` = g.`IDNO` "
              + " AND g.`SUBJ_ID` = sub.`SUBJ_ID` AND s.`IDNO` ='" + id + "'";
            reports(sql, "cashiercopy");

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

        private void frmPrintEnrolledSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
