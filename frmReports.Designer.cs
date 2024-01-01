namespace EnrollmentSystem
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label4 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtsearchid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbo_section = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbosy = new System.Windows.Forms.ComboBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnstudecopy = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 56);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(21, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "SY";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(9, 72);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Grade/Year";
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(9, 32);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 21);
            this.ComboBox2.TabIndex = 2;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(9, 108);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(121, 29);
            this.Button3.TabIndex = 1;
            this.Button3.Text = "Master List";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(11, 220);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(139, 30);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Students\' Enrolled";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(9, 168);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(121, 29);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Master List";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(284, 230);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Search ID";
            // 
            // txtsearchid
            // 
            this.txtsearchid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearchid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearchid.Location = new System.Drawing.Point(284, 246);
            this.txtsearchid.Name = "txtsearchid";
            this.txtsearchid.Size = new System.Drawing.Size(133, 20);
            this.txtsearchid.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Grade/Year";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.ComboBox1);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.ComboBox2);
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Location = new System.Drawing.Point(318, 205);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(139, 151);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 56);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Section";
            // 
            // cbo_section
            // 
            this.cbo_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_section.FormattingEnabled = true;
            this.cbo_section.Location = new System.Drawing.Point(9, 72);
            this.cbo_section.Name = "cbo_section";
            this.cbo_section.Size = new System.Drawing.Size(121, 21);
            this.cbo_section.TabIndex = 5;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.cbo_section);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbosy);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cboLevel);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Location = new System.Drawing.Point(11, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(139, 203);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "SY";
            // 
            // cbosy
            // 
            this.cbosy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Location = new System.Drawing.Point(9, 112);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(121, 21);
            this.cbosy.TabIndex = 3;
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(9, 32);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 21);
            this.cboLevel.TabIndex = 2;
            // 
            // btnstudecopy
            // 
            this.btnstudecopy.Location = new System.Drawing.Point(287, 272);
            this.btnstudecopy.Name = "btnstudecopy";
            this.btnstudecopy.Size = new System.Drawing.Size(131, 34);
            this.btnstudecopy.TabIndex = 8;
            this.btnstudecopy.Text = "Students Copy";
            this.btnstudecopy.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(157, 507);
            this.Panel1.TabIndex = 9;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(157, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(635, 507);
            this.crystalReportViewer1.TabIndex = 12;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtsearchid);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnstudecopy);
            this.Controls.Add(this.Panel1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtsearchid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbo_section;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbosy;
        internal System.Windows.Forms.ComboBox cboLevel;
        internal System.Windows.Forms.Button btnstudecopy;
        internal System.Windows.Forms.Panel Panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}