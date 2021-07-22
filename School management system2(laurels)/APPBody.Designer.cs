namespace School_management_system2_laurels_
{
    partial class APPBody
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
            this.Log_In_timer = new System.Windows.Forms.Timer(this.components);
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Minimisebutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SliddingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.ABOUTUS = new System.Windows.Forms.Button();
            this.teacher_button = new System.Windows.Forms.Button();
            this.class_button = new System.Windows.Forms.Button();
            this.results_button = new System.Windows.Forms.Button();
            this.exams_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.subject_button = new System.Windows.Forms.Button();
            this.registration_button = new System.Windows.Forms.Button();
            this.Slididngpanel_toggle_button = new System.Windows.Forms.Button();
            this.logoff = new System.Windows.Forms.Button();
            this.Minimise = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.contentpanel.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_In_timer
            // 
            this.Log_In_timer.Interval = 50;
            this.Log_In_timer.Tick += new System.EventHandler(this.Log_In_timer_Tick);
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.DarkRed;
            this.Titlebar.Controls.Add(this.logoff);
            this.Titlebar.Controls.Add(this.Minimise);
            this.Titlebar.Controls.Add(this.close);
            this.Titlebar.Controls.Add(this.Minimisebutton);
            this.Titlebar.Controls.Add(this.Closebutton);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.ForeColor = System.Drawing.Color.DarkGray;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(1403, 42);
            this.Titlebar.TabIndex = 0;
            this.Titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Titlebar_Paint);
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Minimisebutton
            // 
            this.Minimisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimisebutton.Location = new System.Drawing.Point(1417, 0);
            this.Minimisebutton.Name = "Minimisebutton";
            this.Minimisebutton.Size = new System.Drawing.Size(38, 39);
            this.Minimisebutton.TabIndex = 5;
            this.Minimisebutton.UseVisualStyleBackColor = true;
            // 
            // Closebutton
            // 
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Location = new System.Drawing.Point(1461, 0);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(38, 39);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.UseVisualStyleBackColor = true;
            // 
            // SliddingPanel_Timer
            // 
            this.SliddingPanel_Timer.Interval = 10;
            this.SliddingPanel_Timer.Tick += new System.EventHandler(this.SliddingPanel_Timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contentpanel.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.wp2919334;
            this.contentpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contentpanel.Controls.Add(this.label3);
            this.contentpanel.Controls.Add(this.label2);
            this.contentpanel.Controls.Add(this.label1);
            this.contentpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(297, 42);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1106, 679);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(391, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "OUR SCHOOL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(431, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 185);
            this.label2.TabIndex = 1;
            this.label2.Text = "To\r\n\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 198);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SlidingPanel.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP__2_;
            this.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel.Controls.Add(this.ABOUTUS);
            this.SlidingPanel.Controls.Add(this.teacher_button);
            this.SlidingPanel.Controls.Add(this.class_button);
            this.SlidingPanel.Controls.Add(this.results_button);
            this.SlidingPanel.Controls.Add(this.exams_button);
            this.SlidingPanel.Controls.Add(this.student_button);
            this.SlidingPanel.Controls.Add(this.subject_button);
            this.SlidingPanel.Controls.Add(this.registration_button);
            this.SlidingPanel.Controls.Add(this.Slididngpanel_toggle_button);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 42);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(300, 679);
            this.SlidingPanel.TabIndex = 1;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Togglebutton_Paint);
            // 
            // ABOUTUS
            // 
            this.ABOUTUS.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf7;
            this.ABOUTUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABOUTUS.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABOUTUS.ForeColor = System.Drawing.Color.Transparent;
            this.ABOUTUS.Image = global::School_management_system2_laurels_.Properties.Resources.ABOUT_US2;
            this.ABOUTUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ABOUTUS.Location = new System.Drawing.Point(0, 590);
            this.ABOUTUS.Name = "ABOUTUS";
            this.ABOUTUS.Size = new System.Drawing.Size(300, 77);
            this.ABOUTUS.TabIndex = 8;
            this.ABOUTUS.Text = "ABOUT US";
            this.ABOUTUS.UseVisualStyleBackColor = true;
            this.ABOUTUS.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // teacher_button
            // 
            this.teacher_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP__2_6;
            this.teacher_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_button.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_button.ForeColor = System.Drawing.Color.Transparent;
            this.teacher_button.Image = global::School_management_system2_laurels_.Properties.Resources.R8cb6ae427fda50bcfe74f886bd540393;
            this.teacher_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacher_button.Location = new System.Drawing.Point(0, 514);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(300, 77);
            this.teacher_button.TabIndex = 4;
            this.teacher_button.Text = "TEACHER";
            this.teacher_button.UseVisualStyleBackColor = true;
            this.teacher_button.Click += new System.EventHandler(this.teacher_button_Click);
            // 
            // class_button
            // 
            this.class_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf5;
            this.class_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class_button.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_button.ForeColor = System.Drawing.Color.Transparent;
            this.class_button.Image = global::School_management_system2_laurels_.Properties.Resources.class3;
            this.class_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class_button.Location = new System.Drawing.Point(0, 443);
            this.class_button.Name = "class_button";
            this.class_button.Size = new System.Drawing.Size(300, 77);
            this.class_button.TabIndex = 3;
            this.class_button.Text = "CLASS";
            this.class_button.UseVisualStyleBackColor = true;
            this.class_button.Click += new System.EventHandler(this.class_button_Click);
            // 
            // results_button
            // 
            this.results_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP__2_5;
            this.results_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.results_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_button.ForeColor = System.Drawing.Color.Transparent;
            this.results_button.Image = global::School_management_system2_laurels_.Properties.Resources.results;
            this.results_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.results_button.Location = new System.Drawing.Point(-3, 369);
            this.results_button.Name = "results_button";
            this.results_button.Size = new System.Drawing.Size(300, 77);
            this.results_button.TabIndex = 4;
            this.results_button.Text = "RESULTS";
            this.results_button.UseVisualStyleBackColor = true;
            this.results_button.Click += new System.EventHandler(this.results_button_Click);
            // 
            // exams_button
            // 
            this.exams_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf8;
            this.exams_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exams_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exams_button.ForeColor = System.Drawing.Color.Transparent;
            this.exams_button.Image = global::School_management_system2_laurels_.Properties.Resources.OIP_3;
            this.exams_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exams_button.Location = new System.Drawing.Point(-3, 296);
            this.exams_button.Name = "exams_button";
            this.exams_button.Size = new System.Drawing.Size(300, 77);
            this.exams_button.TabIndex = 5;
            this.exams_button.Text = "EXAMS";
            this.exams_button.UseVisualStyleBackColor = true;
            this.exams_button.Click += new System.EventHandler(this.exams_button_Click);
            // 
            // student_button
            // 
            this.student_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP__2_3;
            this.student_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.ForeColor = System.Drawing.Color.Transparent;
            this.student_button.Image = global::School_management_system2_laurels_.Properties.Resources.Boy_child_kid_school_boy_student_;
            this.student_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student_button.Location = new System.Drawing.Point(0, 222);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(300, 77);
            this.student_button.TabIndex = 6;
            this.student_button.Text = "STUDENT";
            this.student_button.UseVisualStyleBackColor = true;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // subject_button
            // 
            this.subject_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf7;
            this.subject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_button.ForeColor = System.Drawing.Color.Transparent;
            this.subject_button.Image = global::School_management_system2_laurels_.Properties.Resources.Literature_21png;
            this.subject_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subject_button.Location = new System.Drawing.Point(0, 148);
            this.subject_button.Name = "subject_button";
            this.subject_button.Size = new System.Drawing.Size(300, 77);
            this.subject_button.TabIndex = 7;
            this.subject_button.Text = "SUBJECT";
            this.subject_button.UseVisualStyleBackColor = true;
            this.subject_button.Click += new System.EventHandler(this.subject_button_Click);
            // 
            // registration_button
            // 
            this.registration_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP__2_1;
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration_button.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.ForeColor = System.Drawing.Color.Transparent;
            this.registration_button.Image = global::School_management_system2_laurels_.Properties.Resources.registration2;
            this.registration_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.registration_button.Location = new System.Drawing.Point(0, 74);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(300, 77);
            this.registration_button.TabIndex = 20;
            this.registration_button.Text = "REGISTRATION";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // Slididngpanel_toggle_button
            // 
            this.Slididngpanel_toggle_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.purple_wall_texture_background1;
            this.Slididngpanel_toggle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slididngpanel_toggle_button.Image = global::School_management_system2_laurels_.Properties.Resources.right_arrow3123;
            this.Slididngpanel_toggle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Slididngpanel_toggle_button.Location = new System.Drawing.Point(0, 0);
            this.Slididngpanel_toggle_button.Name = "Slididngpanel_toggle_button";
            this.Slididngpanel_toggle_button.Size = new System.Drawing.Size(300, 77);
            this.Slididngpanel_toggle_button.TabIndex = 2;
            this.Slididngpanel_toggle_button.UseVisualStyleBackColor = true;
            this.Slididngpanel_toggle_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // logoff
            // 
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.ForeColor = System.Drawing.Color.DarkGray;
            this.logoff.Image = global::School_management_system2_laurels_.Properties.Resources.powelog0ff;
            this.logoff.Location = new System.Drawing.Point(1243, -1);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(49, 43);
            this.logoff.TabIndex = 5;
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimise
            // 
            this.Minimise.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.OIP3;
            this.Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimise.ForeColor = System.Drawing.Color.DarkGray;
            this.Minimise.Location = new System.Drawing.Point(1298, 0);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(41, 41);
            this.Minimise.TabIndex = 6;
            this.Minimise.UseVisualStyleBackColor = true;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.close42;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.DarkGray;
            this.close.Location = new System.Drawing.Point(1352, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 39);
            this.close.TabIndex = 4;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Logoffbutton_Click);
            // 
            // APPBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1403, 721);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.Titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APPBody";
            this.Text = "ABOUT";
            this.Load += new System.EventHandler(this.APPBody_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APPBody_MouseDown);
            this.Titlebar.ResumeLayout(false);
            this.contentpanel.ResumeLayout(false);
            this.contentpanel.PerformLayout();
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_In_timer;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Minimisebutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button Minimise;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button Slididngpanel_toggle_button;
        private System.Windows.Forms.Timer SliddingPanel_Timer;
        private System.Windows.Forms.Button class_button;
        private System.Windows.Forms.Button results_button;
        private System.Windows.Forms.Button exams_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button subject_button;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button teacher_button;
        private System.Windows.Forms.Button ABOUTUS;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}