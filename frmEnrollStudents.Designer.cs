namespace EnrollmentSystem
{
    partial class frmEnrollStudents
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgSubject = new System.Windows.Forms.DataGridView();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.cbosy = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.cbosection = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubject)).BeginInit();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(573, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(777, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 25);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dtgSubject
            // 
            this.dtgSubject.AllowUserToAddRows = false;
            this.dtgSubject.AllowUserToDeleteRows = false;
            this.dtgSubject.AllowUserToResizeColumns = false;
            this.dtgSubject.AllowUserToResizeRows = false;
            this.dtgSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgSubject.Location = new System.Drawing.Point(3, 16);
            this.dtgSubject.Name = "dtgSubject";
            this.dtgSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSubject.Size = new System.Drawing.Size(548, 189);
            this.dtgSubject.TabIndex = 0;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.dtgSubject);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(319, 260);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(554, 208);
            this.GroupBox5.TabIndex = 14;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Subjects";
            // 
            // cbosy
            // 
            this.cbosy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Location = new System.Drawing.Point(356, 37);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(186, 21);
            this.cbosy.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(352, 21);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(85, 13);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Academic Year :";
            // 
            // cbosection
            // 
            this.cbosection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosection.FormattingEnabled = true;
            this.cbosection.Location = new System.Drawing.Point(194, 37);
            this.cbosection.Name = "cbosection";
            this.cbosection.Size = new System.Drawing.Size(155, 21);
            this.cbosection.TabIndex = 2;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(191, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Section :";
            // 
            // cboLevel
            // 
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(9, 37);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(173, 21);
            this.cboLevel.TabIndex = 1;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            this.cboLevel.SelectedValueChanged += new System.EventHandler(this.cboLevel_SelectedValueChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(6, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Level :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(675, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cbosy);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.cbosection);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.cboLevel);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(319, 181);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(554, 73);
            this.GroupBox3.TabIndex = 13;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Update Status";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(437, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(271, 46);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Enroll Student";
            // 
            // txtFullname
            // 
            this.txtFullname.Enabled = false;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(65, 22);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(462, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // txtSection
            // 
            this.txtSection.Enabled = false;
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(336, 19);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(172, 20);
            this.txtSection.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(281, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Section :";
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(61, 19);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(214, 20);
            this.txtLevel.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(14, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Level :";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtSection);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.txtLevel);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Location = new System.Drawing.Point(19, 48);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(523, 51);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Grade or Year Level ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox4);
            this.GroupBox1.Controls.Add(this.txtFullname);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(319, 62);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(554, 113);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Student Details";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(18, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Name :";
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(6, 74);
            this.dtgList.MultiSelect = false;
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(298, 425);
            this.dtgList.TabIndex = 3;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            this.dtgList.Click += new System.EventHandler(this.dtgList_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 32);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(133, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Search for Student Name :";
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(6, 48);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(298, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dtgList);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.txtsearch);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(313, 509);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "List Of Student";
            // 
            // frmEnrollStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "frmEnrollStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.frmEnrollStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubject)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.DataGridView dtgSubject;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.ComboBox cbosy;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cbosection;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cboLevel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFullname;
        internal System.Windows.Forms.TextBox txtSection;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtLevel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.GroupBox GroupBox2;
    }
}