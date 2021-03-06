namespace StudentManagementSystem_v0
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ucAddStudent1 = new StudentManagementSystem_v0._UserControls.ucAddStudent();
            this.ucCourseOfferings1 = new StudentManagementSystem_v0._UserControls.ucCourseOfferings();
            this.ucAssignCourses1 = new StudentManagementSystem_v0._UserControls.ucAssignCourses();
            this.ucAddTeacher1 = new StudentManagementSystem_v0._UserControls.ucAddTeacher();
            this.ucAddCourse1 = new StudentManagementSystem_v0._UserControls.ucAddCourse();
            this.ucAddProgram1 = new StudentManagementSystem_v0._UserControls.ucAddProgram();
            this.ucAddDepartment1 = new StudentManagementSystem_v0._UserControls.ucAddDepartment();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 98);
            this.panel1.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLeft.Controls.Add(this.pictureBox4);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.button2);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.btnDepartments);
            this.pnlLeft.Controls.Add(this.btnPrograms);
            this.pnlLeft.Controls.Add(this.btnCourses);
            this.pnlLeft.Controls.Add(this.btnTeachers);
            this.pnlLeft.Controls.Add(this.btnStudents);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 98);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(248, 692);
            this.pnlLeft.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudentManagementSystem_v0.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(61, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(80, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Menu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_batch_assign1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 54);
            this.button2.TabIndex = 17;
            this.button2.Text = "     Assign Courses";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_course_assign_11;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Course Offerings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.Color.White;
            this.btnDepartments.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_department1;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(4, 554);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(238, 54);
            this.btnDepartments.TabIndex = 15;
            this.btnDepartments.Text = "   Departments";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.BackColor = System.Drawing.Color.Transparent;
            this.btnPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.ForeColor = System.Drawing.Color.White;
            this.btnPrograms.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_p1;
            this.btnPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograms.Location = new System.Drawing.Point(4, 494);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(238, 54);
            this.btnPrograms.TabIndex = 14;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_book1;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(4, 434);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(238, 54);
            this.btnCourses.TabIndex = 13;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.Transparent;
            this.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_training1;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(4, 374);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(238, 54);
            this.btnTeachers.TabIndex = 12;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_students1;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(4, 194);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(238, 54);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(399, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "School Management System";
            // 
            // ucAddStudent1
            // 
            this.ucAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddStudent1.Location = new System.Drawing.Point(248, 98);
            this.ucAddStudent1.Name = "ucAddStudent1";
            this.ucAddStudent1.Size = new System.Drawing.Size(865, 692);
            this.ucAddStudent1.TabIndex = 10;
            // 
            // ucCourseOfferings1
            // 
            this.ucCourseOfferings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCourseOfferings1.Location = new System.Drawing.Point(248, 98);
            this.ucCourseOfferings1.Name = "ucCourseOfferings1";
            this.ucCourseOfferings1.Size = new System.Drawing.Size(865, 692);
            this.ucCourseOfferings1.TabIndex = 9;
            // 
            // ucAssignCourses1
            // 
            this.ucAssignCourses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssignCourses1.Location = new System.Drawing.Point(248, 98);
            this.ucAssignCourses1.Name = "ucAssignCourses1";
            this.ucAssignCourses1.Size = new System.Drawing.Size(865, 692);
            this.ucAssignCourses1.TabIndex = 8;
            // 
            // ucAddTeacher1
            // 
            this.ucAddTeacher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddTeacher1.Location = new System.Drawing.Point(248, 98);
            this.ucAddTeacher1.Name = "ucAddTeacher1";
            this.ucAddTeacher1.Size = new System.Drawing.Size(865, 692);
            this.ucAddTeacher1.TabIndex = 7;
            // 
            // ucAddCourse1
            // 
            this.ucAddCourse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddCourse1.Location = new System.Drawing.Point(248, 98);
            this.ucAddCourse1.Name = "ucAddCourse1";
            this.ucAddCourse1.Size = new System.Drawing.Size(865, 692);
            this.ucAddCourse1.TabIndex = 6;
            // 
            // ucAddProgram1
            // 
            this.ucAddProgram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddProgram1.Location = new System.Drawing.Point(248, 98);
            this.ucAddProgram1.Name = "ucAddProgram1";
            this.ucAddProgram1.Size = new System.Drawing.Size(865, 692);
            this.ucAddProgram1.TabIndex = 5;
            // 
            // ucAddDepartment1
            // 
            this.ucAddDepartment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddDepartment1.Location = new System.Drawing.Point(248, 98);
            this.ucAddDepartment1.Name = "ucAddDepartment1";
            this.ucAddDepartment1.Size = new System.Drawing.Size(865, 692);
            this.ucAddDepartment1.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.ucAddStudent1);
            this.Controls.Add(this.ucCourseOfferings1);
            this.Controls.Add(this.ucAssignCourses1);
            this.Controls.Add(this.ucAddTeacher1);
            this.Controls.Add(this.ucAddCourse1);
            this.Controls.Add(this.ucAddProgram1);
            this.Controls.Add(this.ucAddDepartment1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private _UserControls.ucAddDepartment ucAddDepartment1;
        private _UserControls.ucAddProgram ucAddProgram1;
        private _UserControls.ucAddCourse ucAddCourse1;
        private _UserControls.ucAddTeacher ucAddTeacher1;
        private _UserControls.ucAssignCourses ucAssignCourses1;
        private _UserControls.ucCourseOfferings ucCourseOfferings1;
        private _UserControls.ucAddStudent ucAddStudent1;
        private System.Windows.Forms.Label label1;
    }
}

