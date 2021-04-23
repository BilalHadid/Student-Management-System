namespace StudentManagementSystem_v0
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.btnViewTranscript = new System.Windows.Forms.Button();
            this.btnCourseRegistration = new System.Windows.Forms.Button();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ucViewTranscript1 = new StudentManagementSystem_v0._UserControls.ucViewTranscript();
            this.ucCheckResult1 = new StudentManagementSystem_v0._UserControls.ucCheckResult();
            this.ucRegisterCourse1 = new StudentManagementSystem_v0._UserControls.ucRegisterCourse();
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
            this.panel1.Size = new System.Drawing.Size(1113, 120);
            this.panel1.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.pictureBox4);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.txtSID);
            this.pnlLeft.Controls.Add(this.btnViewTranscript);
            this.pnlLeft.Controls.Add(this.btnCourseRegistration);
            this.pnlLeft.Controls.Add(this.btnCheckResult);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 120);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(280, 670);
            this.pnlLeft.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(74, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 80;
            this.label2.Text = "Menu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudentManagementSystem_v0.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(55, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 79;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "SID";
            // 
            // txtSID
            // 
            this.txtSID.Enabled = false;
            this.txtSID.Location = new System.Drawing.Point(108, 123);
            this.txtSID.Name = "txtSID";
            this.txtSID.ReadOnly = true;
            this.txtSID.Size = new System.Drawing.Size(62, 20);
            this.txtSID.TabIndex = 76;
            this.txtSID.Text = "7";
            // 
            // btnViewTranscript
            // 
            this.btnViewTranscript.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTranscript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewTranscript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTranscript.ForeColor = System.Drawing.Color.White;
            this.btnViewTranscript.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_report_card_4;
            this.btnViewTranscript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTranscript.Location = new System.Drawing.Point(3, 321);
            this.btnViewTranscript.Name = "btnViewTranscript";
            this.btnViewTranscript.Size = new System.Drawing.Size(233, 56);
            this.btnViewTranscript.TabIndex = 14;
            this.btnViewTranscript.Text = "    View Transcript";
            this.btnViewTranscript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewTranscript.UseVisualStyleBackColor = false;
            this.btnViewTranscript.Click += new System.EventHandler(this.btnViewTranscript_Click);
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourseRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourseRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCourseRegistration.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_course_assign_filled;
            this.btnCourseRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseRegistration.Location = new System.Drawing.Point(3, 203);
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(233, 52);
            this.btnCourseRegistration.TabIndex = 13;
            this.btnCourseRegistration.Text = " Course Registration";
            this.btnCourseRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourseRegistration.UseVisualStyleBackColor = false;
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckResult.ForeColor = System.Drawing.Color.White;
            this.btnCheckResult.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_report_card_3;
            this.btnCheckResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckResult.Location = new System.Drawing.Point(3, 261);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(233, 54);
            this.btnCheckResult.TabIndex = 12;
            this.btnCheckResult.Text = "   Check Result";
            this.btnCheckResult.UseVisualStyleBackColor = false;
            this.btnCheckResult.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(383, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "School Management System";
            // 
            // ucViewTranscript1
            // 
            this.ucViewTranscript1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewTranscript1.Location = new System.Drawing.Point(280, 120);
            this.ucViewTranscript1.Name = "ucViewTranscript1";
            this.ucViewTranscript1.Size = new System.Drawing.Size(833, 670);
            this.ucViewTranscript1.TabIndex = 6;
            // 
            // ucCheckResult1
            // 
            this.ucCheckResult1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCheckResult1.Location = new System.Drawing.Point(280, 120);
            this.ucCheckResult1.Name = "ucCheckResult1";
            this.ucCheckResult1.Size = new System.Drawing.Size(833, 670);
            this.ucCheckResult1.TabIndex = 5;
            // 
            // ucRegisterCourse1
            // 
            this.ucRegisterCourse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRegisterCourse1.Location = new System.Drawing.Point(280, 120);
            this.ucRegisterCourse1.Name = "ucRegisterCourse1";
            this.ucRegisterCourse1.Size = new System.Drawing.Size(833, 670);
            this.ucRegisterCourse1.TabIndex = 4;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.ucViewTranscript1);
            this.Controls.Add(this.ucCheckResult1);
            this.Controls.Add(this.ucRegisterCourse1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
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
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Button btnCourseRegistration;
        private System.Windows.Forms.Button btnViewTranscript;
        private _UserControls.ucRegisterCourse ucRegisterCourse1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSID;
        private _UserControls.ucCheckResult ucCheckResult1;
        private _UserControls.ucViewTranscript ucViewTranscript1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

