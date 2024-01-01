namespace EnrollmentSystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_User = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_students = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Enrollment = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfEnrolledStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Subject = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Maintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAcademicYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGradeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ts_students,
            this.ts_Enrollment,
            this.ts_Subject,
            this.ts_Maintenance,
            this.ts_Reports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_User,
            this.ts_Login,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ts_User
            // 
            this.ts_User.Name = "ts_User";
            this.ts_User.Size = new System.Drawing.Size(170, 22);
            this.ts_User.Text = "Manage Accounts";
            this.ts_User.Click += new System.EventHandler(this.ts_User_Click);
            // 
            // ts_Login
            // 
            this.ts_Login.Name = "ts_Login";
            this.ts_Login.Size = new System.Drawing.Size(170, 22);
            this.ts_Login.Text = "Login";
            this.ts_Login.Click += new System.EventHandler(this.ts_Login_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ts_students
            // 
            this.ts_students.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewStudentsToolStripMenuItem,
            this.listOfStudentsToolStripMenuItem});
            this.ts_students.Name = "ts_students";
            this.ts_students.Size = new System.Drawing.Size(65, 20);
            this.ts_students.Text = "Students";
            // 
            // registerNewStudentsToolStripMenuItem
            // 
            this.registerNewStudentsToolStripMenuItem.Name = "registerNewStudentsToolStripMenuItem";
            this.registerNewStudentsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registerNewStudentsToolStripMenuItem.Text = "Register New Student";
            this.registerNewStudentsToolStripMenuItem.Click += new System.EventHandler(this.registerNewStudentsToolStripMenuItem_Click);
            // 
            // listOfStudentsToolStripMenuItem
            // 
            this.listOfStudentsToolStripMenuItem.Name = "listOfStudentsToolStripMenuItem";
            this.listOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listOfStudentsToolStripMenuItem.Text = "List of Students";
            this.listOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentsToolStripMenuItem_Click);
            // 
            // ts_Enrollment
            // 
            this.ts_Enrollment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollmentFormToolStripMenuItem,
            this.listOfEnrolledStudentsToolStripMenuItem});
            this.ts_Enrollment.Name = "ts_Enrollment";
            this.ts_Enrollment.Size = new System.Drawing.Size(77, 20);
            this.ts_Enrollment.Text = "Enrollment";
            // 
            // enrollmentFormToolStripMenuItem
            // 
            this.enrollmentFormToolStripMenuItem.Name = "enrollmentFormToolStripMenuItem";
            this.enrollmentFormToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.enrollmentFormToolStripMenuItem.Text = "Enroll Students";
            this.enrollmentFormToolStripMenuItem.Click += new System.EventHandler(this.enrollmentFormToolStripMenuItem_Click);
            // 
            // listOfEnrolledStudentsToolStripMenuItem
            // 
            this.listOfEnrolledStudentsToolStripMenuItem.Name = "listOfEnrolledStudentsToolStripMenuItem";
            this.listOfEnrolledStudentsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listOfEnrolledStudentsToolStripMenuItem.Text = "List of Enrolled Students";
            this.listOfEnrolledStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfEnrolledStudentsToolStripMenuItem_Click);
            // 
            // ts_Subject
            // 
            this.ts_Subject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewSubjectsToolStripMenuItem,
            this.listOfSubjectsToolStripMenuItem});
            this.ts_Subject.Name = "ts_Subject";
            this.ts_Subject.Size = new System.Drawing.Size(63, 20);
            this.ts_Subject.Text = "Subjects";
            // 
            // registerNewSubjectsToolStripMenuItem
            // 
            this.registerNewSubjectsToolStripMenuItem.Name = "registerNewSubjectsToolStripMenuItem";
            this.registerNewSubjectsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registerNewSubjectsToolStripMenuItem.Text = "Register New Subject";
            this.registerNewSubjectsToolStripMenuItem.Click += new System.EventHandler(this.registerNewSubjectsToolStripMenuItem_Click);
            // 
            // listOfSubjectsToolStripMenuItem
            // 
            this.listOfSubjectsToolStripMenuItem.Name = "listOfSubjectsToolStripMenuItem";
            this.listOfSubjectsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listOfSubjectsToolStripMenuItem.Text = "List of Subjects";
            this.listOfSubjectsToolStripMenuItem.Click += new System.EventHandler(this.listOfSubjectsToolStripMenuItem_Click);
            // 
            // ts_Maintenance
            // 
            this.ts_Maintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAcademicYearToolStripMenuItem,
            this.manageGradeLevelToolStripMenuItem,
            this.manageSectionsToolStripMenuItem});
            this.ts_Maintenance.Name = "ts_Maintenance";
            this.ts_Maintenance.Size = new System.Drawing.Size(88, 20);
            this.ts_Maintenance.Text = "Maintenance";
            // 
            // manageAcademicYearToolStripMenuItem
            // 
            this.manageAcademicYearToolStripMenuItem.Name = "manageAcademicYearToolStripMenuItem";
            this.manageAcademicYearToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manageAcademicYearToolStripMenuItem.Text = "Manage Academic Year";
            this.manageAcademicYearToolStripMenuItem.Click += new System.EventHandler(this.manageAcademicYearToolStripMenuItem_Click);
            // 
            // manageGradeLevelToolStripMenuItem
            // 
            this.manageGradeLevelToolStripMenuItem.Name = "manageGradeLevelToolStripMenuItem";
            this.manageGradeLevelToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manageGradeLevelToolStripMenuItem.Text = "Manage Grade | Level";
            this.manageGradeLevelToolStripMenuItem.Click += new System.EventHandler(this.manageGradeLevelToolStripMenuItem_Click);
            // 
            // manageSectionsToolStripMenuItem
            // 
            this.manageSectionsToolStripMenuItem.Name = "manageSectionsToolStripMenuItem";
            this.manageSectionsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manageSectionsToolStripMenuItem.Text = "Manage Sections";
            this.manageSectionsToolStripMenuItem.Click += new System.EventHandler(this.manageSectionsToolStripMenuItem_Click);
            // 
            // ts_Reports
            // 
            this.ts_Reports.Name = "ts_Reports";
            this.ts_Reports.Size = new System.Drawing.Size(59, 20);
            this.ts_Reports.Text = "Reports";
            this.ts_Reports.Click += new System.EventHandler(this.ts_Reports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 497);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System | Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_User;
        private System.Windows.Forms.ToolStripMenuItem ts_Login;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_students;
        private System.Windows.Forms.ToolStripMenuItem registerNewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_Enrollment;
        private System.Windows.Forms.ToolStripMenuItem enrollmentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfEnrolledStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_Subject;
        private System.Windows.Forms.ToolStripMenuItem registerNewSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_Maintenance;
        private System.Windows.Forms.ToolStripMenuItem manageAcademicYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGradeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_Reports;
    }
}

