namespace EnrollmentSystem
{
    partial class frmSection
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
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(75, 59);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "Grade/Year :";
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(150, 56);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(268, 21);
            this.cboLevel.TabIndex = 47;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(303, 127);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(250, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "Search :";
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(12, 153);
            this.dtgList.MultiSelect = false;
            this.dtgList.Name = "dtgList";
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(473, 229);
            this.dtgList.TabIndex = 42;
            this.dtgList.Click += new System.EventHandler(this.dtgList_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(150, 83);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 40;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(150, 30);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(268, 20);
            this.txtSection.TabIndex = 39;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(95, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "Section :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 415);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Sections";
            this.Load += new System.EventHandler(this.frmSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboLevel;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.TextBox txtSection;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnDelete;
    }
}