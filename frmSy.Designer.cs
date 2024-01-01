namespace EnrollmentSystem
{
    partial class frmSy
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsy = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(296, 138);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(243, 141);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 26;
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
            this.dtgList.Location = new System.Drawing.Point(5, 164);
            this.dtgList.MultiSelect = false;
            this.dtgList.Name = "dtgList";
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(473, 214);
            this.dtgList.TabIndex = 25;
            this.dtgList.Click += new System.EventHandler(this.dtgList_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(141, 21);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(211, 16);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "* Example input of sy; 1990 - 1991 *";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(132, 86);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsy
            // 
            this.txtsy.Location = new System.Drawing.Point(132, 60);
            this.txtsy.Name = "txtsy";
            this.txtsy.Size = new System.Drawing.Size(268, 20);
            this.txtsy.TabIndex = 20;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(55, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "School Year :";
            // 
            // frmSy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 411);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsy);
            this.Controls.Add(this.Label2);
            this.Name = "frmSy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage School Year";
            this.Load += new System.EventHandler(this.frmSy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.TextBox txtsy;
        internal System.Windows.Forms.Label Label2;
    }
}