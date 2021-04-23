namespace StudentManagementSystem_v0
{
    partial class TeacherDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnMarksEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ucMarksEntry1 = new StudentManagementSystem_v0._UserControls.ucMarksEntry();
            this.ucViewCourses1 = new StudentManagementSystem_v0._UserControls.ucViewCourses();
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
            this.panel1.Size = new System.Drawing.Size(1113, 89);
            this.panel1.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLeft.Controls.Add(this.pictureBox4);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.txtTID);
            this.pnlLeft.Controls.Add(this.btnViewCourses);
            this.pnlLeft.Controls.Add(this.btnMarksEntry);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 89);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(245, 701);
            this.pnlLeft.TabIndex = 3;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudentManagementSystem_v0.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(56, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "TID";
            // 
            // txtTID
            // 
            this.txtTID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTID.Enabled = false;
            this.txtTID.Location = new System.Drawing.Point(110, 132);
            this.txtTID.Name = "txtTID";
            this.txtTID.ReadOnly = true;
            this.txtTID.Size = new System.Drawing.Size(56, 20);
            this.txtTID.TabIndex = 76;
            this.txtTID.Text = "7";
            this.txtTID.TextChanged += new System.EventHandler(this.txtTID_TextChanged);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_courses;
            this.btnViewCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCourses.Location = new System.Drawing.Point(3, 277);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(236, 54);
            this.btnViewCourses.TabIndex = 13;
            this.btnViewCourses.Text = "   View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = false;
            this.btnViewCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnMarksEntry
            // 
            this.btnMarksEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnMarksEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMarksEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarksEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarksEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarksEntry.ForeColor = System.Drawing.Color.White;
            this.btnMarksEntry.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_report_card_11;
            this.btnMarksEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarksEntry.Location = new System.Drawing.Point(0, 217);
            this.btnMarksEntry.Name = "btnMarksEntry";
            this.btnMarksEntry.Size = new System.Drawing.Size(239, 54);
            this.btnMarksEntry.TabIndex = 12;
            this.btnMarksEntry.Text = "Marks Entry";
            this.btnMarksEntry.UseVisualStyleBackColor = false;
            this.btnMarksEntry.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(74, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Menu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(412, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "School Management System";
            // 
            // ucMarksEntry1
            // 
            this.ucMarksEntry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMarksEntry1.Location = new System.Drawing.Point(245, 89);
            this.ucMarksEntry1.Name = "ucMarksEntry1";
            this.ucMarksEntry1.Size = new System.Drawing.Size(868, 701);
            this.ucMarksEntry1.TabIndex = 5;
            this.ucMarksEntry1.Load += new System.EventHandler(this.ucMarksEntry1_Load);
            // 
            // ucViewCourses1
            // 
            this.ucViewCourses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewCourses1.Location = new System.Drawing.Point(245, 89);
            this.ucViewCourses1.Name = "ucViewCourses1";
            this.ucViewCourses1.Size = new System.Drawing.Size(868, 701);
            this.ucViewCourses1.TabIndex = 4;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.ucMarksEntry1);
            this.Controls.Add(this.ucViewCourses1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarksEntry;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTID;
        private _UserControls.ucViewCourses ucViewCourses1;
        private _UserControls.ucMarksEntry ucMarksEntry1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

