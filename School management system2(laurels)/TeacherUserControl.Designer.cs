namespace School_management_system2_laurels_
{
    partial class TeacherUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teacher_id_searchtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.Teacher_id_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone_numbertextbox = new System.Windows.Forms.TextBox();
            this.gender_textbox = new System.Windows.Forms.TextBox();
            this.joindate_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_id_searchtextbox
            // 
            this.teacher_id_searchtextbox.Location = new System.Drawing.Point(338, 37);
            this.teacher_id_searchtextbox.Name = "teacher_id_searchtextbox";
            this.teacher_id_searchtextbox.Size = new System.Drawing.Size(476, 22);
            this.teacher_id_searchtextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(195, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEACHER ID:";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.Window;
            this.search_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.search_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.Control;
            this.search_button.Image = global::School_management_system2_laurels_.Properties.Resources.search3;
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.Location = new System.Drawing.Point(405, 83);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(303, 45);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "Search Teacher";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(60, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1020, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Window;
            this.add_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.add_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Image = global::School_management_system2_laurels_.Properties.Resources.add;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(66, 329);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(246, 45);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Add New";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.Window;
            this.delete_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.delete_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Image = global::School_management_system2_laurels_.Properties.Resources.delete3;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_button.Location = new System.Drawing.Point(639, 329);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(208, 45);
            this.delete_button.TabIndex = 13;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.Window;
            this.update_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.update_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Image = global::School_management_system2_laurels_.Properties.Resources.update;
            this.update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_button.Location = new System.Drawing.Point(341, 329);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(274, 45);
            this.update_button.TabIndex = 12;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.SystemColors.Window;
            this.clear_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.clear_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_button.Image = global::School_management_system2_laurels_.Properties.Resources.clear2;
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_button.Location = new System.Drawing.Point(869, 329);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(224, 45);
            this.clear_button.TabIndex = 15;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Teacher_id_textbox
            // 
            this.Teacher_id_textbox.Location = new System.Drawing.Point(158, 427);
            this.Teacher_id_textbox.Name = "Teacher_id_textbox";
            this.Teacher_id_textbox.Size = new System.Drawing.Size(366, 22);
            this.Teacher_id_textbox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Teacher Id:";
            // 
            // Phone_numbertextbox
            // 
            this.Phone_numbertextbox.Location = new System.Drawing.Point(705, 579);
            this.Phone_numbertextbox.Name = "Phone_numbertextbox";
            this.Phone_numbertextbox.Size = new System.Drawing.Size(361, 22);
            this.Phone_numbertextbox.TabIndex = 38;
            // 
            // gender_textbox
            // 
            this.gender_textbox.Location = new System.Drawing.Point(678, 514);
            this.gender_textbox.Name = "gender_textbox";
            this.gender_textbox.Size = new System.Drawing.Size(402, 22);
            this.gender_textbox.TabIndex = 37;
            // 
            // joindate_textbox
            // 
            this.joindate_textbox.Location = new System.Drawing.Point(245, 640);
            this.joindate_textbox.Name = "joindate_textbox";
            this.joindate_textbox.Size = new System.Drawing.Size(370, 22);
            this.joindate_textbox.TabIndex = 36;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(104, 559);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(372, 22);
            this.email_textbox.TabIndex = 35;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(132, 485);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(360, 22);
            this.nametextbox.TabIndex = 34;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gender_label.Location = new System.Drawing.Point(558, 507);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(103, 29);
            this.gender_label.TabIndex = 32;
            this.gender_label.Text = "Gender:";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.age_label.Location = new System.Drawing.Point(13, 632);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(226, 29);
            this.age_label.TabIndex = 31;
            this.age_label.Text = "Teacher Join Date:";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone_label.Location = new System.Drawing.Point(558, 572);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(132, 29);
            this.phone_label.TabIndex = 30;
            this.phone_label.Text = "Phone No:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.SystemColors.Control;
            this.email_label.Location = new System.Drawing.Point(13, 552);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(85, 29);
            this.email_label.TabIndex = 29;
            this.email_label.Text = "Email:";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.namelabel.Location = new System.Drawing.Point(13, 478);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(88, 29);
            this.namelabel.TabIndex = 28;
            this.namelabel.Text = "Name:";
            // 
            // TeacherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.wp1920734;
            this.Controls.Add(this.Teacher_id_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone_numbertextbox);
            this.Controls.Add(this.gender_textbox);
            this.Controls.Add(this.joindate_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacher_id_searchtextbox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TeacherUserControl";
            this.Size = new System.Drawing.Size(1106, 679);
            this.Load += new System.EventHandler(this.TeacherUserControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teacher_id_searchtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox Teacher_id_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone_numbertextbox;
        private System.Windows.Forms.TextBox gender_textbox;
        private System.Windows.Forms.TextBox joindate_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label namelabel;
    }
}
