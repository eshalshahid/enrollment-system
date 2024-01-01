namespace EnrollmentSystem
{
    partial class frmListofStudents
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
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsFind = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dtgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(0, 57);
            this.dtgList.Name = "dtgList";
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(840, 443);
            this.dtgList.TabIndex = 3;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(184, 54);
            this.ToolStripLabel1.Text = "Search for Student Name";
            // 
            // tsSearch
            // 
            this.tsSearch.BackColor = System.Drawing.Color.Snow;
            this.tsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsSearch.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsSearch.Size = new System.Drawing.Size(400, 57);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.White;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton2,
            this.tsAdd,
            this.tsDelete,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.tsSearch,
            this.tsFind});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStrip1.Size = new System.Drawing.Size(840, 57);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Image = global::EnrollmentSystem.Properties.Resources.edit;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.ToolStripButton2.Text = "Edit";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // tsAdd
            // 
            this.tsAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAdd.Image = global::EnrollmentSystem.Properties.Resources.add;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(54, 54);
            this.tsAdd.Text = "Add New Student";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.BackColor = System.Drawing.Color.Transparent;
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Enabled = false;
            this.tsDelete.Image = global::EnrollmentSystem.Properties.Resources.trash_512;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(54, 54);
            this.tsDelete.Text = "Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsFind
            // 
            this.tsFind.BackColor = System.Drawing.Color.Transparent;
            this.tsFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFind.Image = global::EnrollmentSystem.Properties.Resources.search;
            this.tsFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFind.Name = "tsFind";
            this.tsFind.Size = new System.Drawing.Size(54, 54);
            this.tsFind.Text = "Search";
            this.tsFind.Click += new System.EventHandler(this.tsFind_Click);
            // 
            // frmListofStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmListofStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Students";
            this.Load += new System.EventHandler(this.frmListofStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton tsAdd;
        internal System.Windows.Forms.ToolStripButton tsDelete;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox tsSearch;
        internal System.Windows.Forms.ToolStripButton tsFind;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
    }
}