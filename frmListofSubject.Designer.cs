namespace EnrollmentSystem
{
    partial class frmListofSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListofSubject));
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.dtgList.Size = new System.Drawing.Size(910, 409);
            this.dtgList.TabIndex = 6;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(119, 54);
            this.ToolStripLabel1.Text = "Search Subject :";
            // 
            // tsSearch
            // 
            this.tsSearch.BackColor = System.Drawing.Color.Cyan;
            this.tsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsSearch.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsSearch.Size = new System.Drawing.Size(400, 57);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDelete,
            this.tsEdit,
            this.tsAdd,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.tsSearch,
            this.ToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStrip1.Size = new System.Drawing.Size(910, 57);
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.Text = "ToolStrip1";
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
            // tsEdit
            // 
            this.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEdit.Image = global::EnrollmentSystem.Properties.Resources.edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(54, 54);
            this.tsEdit.Text = "Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsAdd
            // 
            this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsAdd.Image")));
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(54, 54);
            this.tsAdd.Text = "Add New Student";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = global::EnrollmentSystem.Properties.Resources.search;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.ToolStripButton1.Text = "Search";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // frmListofSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 466);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmListofSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Subject";
            this.Load += new System.EventHandler(this.frmListofSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox tsSearch;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsDelete;
        internal System.Windows.Forms.ToolStripButton tsEdit;
        internal System.Windows.Forms.ToolStripButton tsAdd;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
    }
}