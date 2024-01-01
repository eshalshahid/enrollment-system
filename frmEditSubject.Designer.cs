namespace EnrollmentSystem
{
    partial class frmEditSubject
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
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtsubjDesc = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtsujCode = new System.Windows.Forms.TextBox();
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
            this.tsAdd});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 339);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(579, 57);
            this.ToolStrip1.TabIndex = 58;
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
            // tsAdd
            // 
            this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAdd.Image = global::EnrollmentSystem.Properties.Resources.close;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(54, 54);
            this.tsAdd.Text = "Close";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(579, 72);
            this.Label7.TabIndex = 53;
            this.Label7.Text = "Edit Subject";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(43, 95);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 59;
            this.Label1.Text = "Subject Id :";
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Enabled = false;
            this.txtSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectID.Location = new System.Drawing.Point(153, 92);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(333, 26);
            this.txtSubjectID.TabIndex = 48;
            this.txtSubjectID.TextChanged += new System.EventHandler(this.txtSubjectID_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(43, 256);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 20);
            this.Label5.TabIndex = 56;
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
            this.cboYear.Location = new System.Drawing.Point(153, 253);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(333, 28);
            this.cboYear.TabIndex = 51;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(43, 159);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 20);
            this.Label4.TabIndex = 55;
            this.Label4.Text = "Description :";
            // 
            // txtsubjDesc
            // 
            this.txtsubjDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubjDesc.Location = new System.Drawing.Point(153, 156);
            this.txtsubjDesc.Name = "txtsubjDesc";
            this.txtsubjDesc.Size = new System.Drawing.Size(333, 91);
            this.txtsubjDesc.TabIndex = 50;
            this.txtsubjDesc.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(43, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 20);
            this.Label3.TabIndex = 54;
            this.Label3.Text = "Subject :";
            // 
            // txtsujCode
            // 
            this.txtsujCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsujCode.Location = new System.Drawing.Point(153, 124);
            this.txtsujCode.Name = "txtsujCode";
            this.txtsujCode.Size = new System.Drawing.Size(333, 26);
            this.txtsujCode.TabIndex = 49;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(260, 172);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(104, 20);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "School Year :";
            // 
            // cbosy
            // 
            this.cbosy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Location = new System.Drawing.Point(235, 164);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(155, 28);
            this.cbosy.TabIndex = 52;
            // 
            // frmEditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 396);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtsubjDesc);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtsujCode);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cbosy);
            this.Name = "frmEditSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Subject";
            this.Load += new System.EventHandler(this.frmEditSubject_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsSave;
        internal System.Windows.Forms.ToolStripButton tsAdd;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSubjectID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboYear;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RichTextBox txtsubjDesc;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtsujCode;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbosy;
    }
}