namespace School_management_system2_laurels_
{
    partial class ResultsUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.student_id_searchresulttextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESULTS";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 123);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(986, 553);
            this.dataGridView3.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.Window;
            this.search_button.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources._866685bdd4bbc516ec1a13c956d4d7bf10;
            this.search_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_button.Image = global::School_management_system2_laurels_.Properties.Resources.search3;
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.Location = new System.Drawing.Point(634, 59);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(379, 45);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Search By Student Id";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // student_id_searchresulttextbox
            // 
            this.student_id_searchresulttextbox.Location = new System.Drawing.Point(609, 18);
            this.student_id_searchresulttextbox.Name = "student_id_searchresulttextbox";
            this.student_id_searchresulttextbox.Size = new System.Drawing.Size(476, 22);
            this.student_id_searchresulttextbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(434, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "STUDENT ID:";
            // 
            // ResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_management_system2_laurels_.Properties.Resources.Dark_Blue_grunge_Texture_Background;
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.student_id_searchresulttextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Name = "ResultsUserControl";
            this.Size = new System.Drawing.Size(1106, 679);
            this.Load += new System.EventHandler(this.ResultsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox student_id_searchresulttextbox;
        private System.Windows.Forms.Label label2;
    }
}
