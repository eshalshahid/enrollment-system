namespace EnrollmentSystem
{
    partial class frmUser
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this.txtPass);
            this.GroupBox1.Controls.Add(this.txtUname);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cboType);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.lblId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(86, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(462, 165);
            this.GroupBox1.TabIndex = 47;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "User Details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(119, 92);
            this.txtPass.MaxLength = 16;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(287, 26);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(119, 60);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(287, 26);
            this.txtUname.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 95);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Password :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Name :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Username :";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Administrator",
            "Staff "});
            this.cboType.Location = new System.Drawing.Point(119, 124);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(287, 28);
            this.cboType.TabIndex = 3;
            this.cboType.Text = "Administrator";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(22, 127);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 20);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Type :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(285, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 15;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave,
            this.tsNew,
            this.tsDelete,
            this.tsClose});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 442);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(664, 57);
            this.ToolStrip1.TabIndex = 50;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::EnrollmentSystem.Properties.Resources.save;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(54, 54);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::EnrollmentSystem.Properties.Resources.trash_512;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(54, 54);
            this.tsDelete.Text = "Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(12, 183);
            this.dtglist.Name = "dtglist";
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(639, 256);
            this.dtglist.TabIndex = 48;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // tsClose
            // 
            this.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClose.Image = global::EnrollmentSystem.Properties.Resources.close;
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(54, 54);
            this.tsClose.Text = "Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = global::EnrollmentSystem.Properties.Resources.refresh;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(54, 54);
            this.tsNew.Text = "New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 499);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.dtglist);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.TextBox txtUname;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsSave;
        internal System.Windows.Forms.ToolStripButton tsDelete;
        internal System.Windows.Forms.DataGridView dtglist;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
    }
}