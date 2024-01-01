namespace EnrollmentSystem
{
    partial class frmSubjects
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsList = new System.Windows.Forms.ToolStripButton();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtsubjDesc = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtsujCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbosy = new System.Windows.Forms.ComboBox();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.tsList});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 317);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(576, 57);
            this.ToolStrip1.TabIndex = 45;
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
            // tsList
            // 
            this.tsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsList.Image = global::EnrollmentSystem.Properties.Resources.close;
            this.tsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(54, 54);
            this.tsList.Text = "Close";
            this.tsList.Click += new System.EventHandler(this.tsList_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(42, 224);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 20);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Level :";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "Grade 7",
            "Gade 8",
            "3rd Year",
            "4th Year"});
            this.cboYear.Location = new System.Drawing.Point(152, 221);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(333, 28);
            this.cboYear.TabIndex = 38;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(42, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 20);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Description :";
            // 
            // txtsubjDesc
            // 
            this.txtsubjDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubjDesc.Location = new System.Drawing.Point(152, 115);
            this.txtsubjDesc.Name = "txtsubjDesc";
            this.txtsubjDesc.Size = new System.Drawing.Size(333, 100);
            this.txtsubjDesc.TabIndex = 37;
            this.txtsubjDesc.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(42, 86);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 20);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Subject :";
            // 
            // txtsujCode
            // 
            this.txtsujCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsujCode.Location = new System.Drawing.Point(152, 83);
            this.txtsujCode.Name = "txtsujCode";
            this.txtsujCode.Size = new System.Drawing.Size(333, 26);
            this.txtsujCode.TabIndex = 36;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(576, 63);
            this.Label7.TabIndex = 39;
            this.Label7.Text = "Add New Subject";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(209, 134);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(104, 20);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "School Year :";
            // 
            // cbosy
            // 
            this.cbosy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Location = new System.Drawing.Point(191, 131);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(145, 28);
            this.cbosy.TabIndex = 40;
            // 
            // frmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 374);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtsubjDesc);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtsujCode);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cbosy);
            this.Name = "frmSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Form";
            this.Load += new System.EventHandler(this.frmSubjects_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsSave;
        internal System.Windows.Forms.ToolStripButton tsNew;
        internal System.Windows.Forms.ToolStripButton tsList;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboYear;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RichTextBox txtsubjDesc;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtsujCode;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbosy;
    }
}