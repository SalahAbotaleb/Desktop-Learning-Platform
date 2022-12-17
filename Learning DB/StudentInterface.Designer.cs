namespace Learning_DB
{
    partial class StudentInterface
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upcomingevents_label = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.upcomingevents_gridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.backtologin_label = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.view_classrooms_button = new System.Windows.Forms.Button();
            this.Std_Profile_button = new System.Windows.Forms.Button();
            this.view_grades_button = new System.Windows.Forms.Button();
            this.recent_submissions_button = new System.Windows.Forms.Button();
            this.enroll_in_new_classroom_button = new System.Windows.Forms.Button();
            this.Student_view_calender_button = new System.Windows.Forms.Button();
            this.take_an_exam_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingevents_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(299, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "[read student name]!";
            // 
            // upcomingevents_label
            // 
            this.upcomingevents_label.Location = new System.Drawing.Point(21, 86);
            this.upcomingevents_label.Name = "upcomingevents_label";
            this.upcomingevents_label.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.upcomingevents_label.Size = new System.Drawing.Size(156, 27);
            this.upcomingevents_label.TabIndex = 3;
            this.upcomingevents_label.Values.Text = "Upcoming Events";
            // 
            // upcomingevents_gridview
            // 
            this.upcomingevents_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingevents_gridview.HideOuterBorders = true;
            this.upcomingevents_gridview.Location = new System.Drawing.Point(21, 119);
            this.upcomingevents_gridview.Name = "upcomingevents_gridview";
            this.upcomingevents_gridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.upcomingevents_gridview.RowHeadersWidth = 51;
            this.upcomingevents_gridview.RowTemplate.Height = 24;
            this.upcomingevents_gridview.Size = new System.Drawing.Size(567, 150);
            this.upcomingevents_gridview.TabIndex = 4;
            this.upcomingevents_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upcomingevents_gridview_CellContentClick);
            // 
            // backtologin_label
            // 
            this.backtologin_label.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            this.backtologin_label.Location = new System.Drawing.Point(703, 22);
            this.backtologin_label.Name = "backtologin_label";
            this.backtologin_label.Palette = this.kryptonPalette1;
            this.backtologin_label.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.backtologin_label.Size = new System.Drawing.Size(165, 27);
            this.backtologin_label.TabIndex = 5;
            this.backtologin_label.Values.Text = "Back to login page";
            this.backtologin_label.LinkClicked += new System.EventHandler(this.backtologin_label_LinkClicked);
            // 
            // view_classrooms_button
            // 
            this.view_classrooms_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_classrooms_button.Location = new System.Drawing.Point(34, 317);
            this.view_classrooms_button.Name = "view_classrooms_button";
            this.view_classrooms_button.Size = new System.Drawing.Size(187, 36);
            this.view_classrooms_button.TabIndex = 6;
            this.view_classrooms_button.Text = "View Classrooms";
            this.view_classrooms_button.UseVisualStyleBackColor = true;
            this.view_classrooms_button.Click += new System.EventHandler(this.view_classrooms_button_Click);
            // 
            // Std_Profile_button
            // 
            this.Std_Profile_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Std_Profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Std_Profile_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Std_Profile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Std_Profile_button.Location = new System.Drawing.Point(648, 119);
            this.Std_Profile_button.Name = "Std_Profile_button";
            this.Std_Profile_button.Size = new System.Drawing.Size(161, 36);
            this.Std_Profile_button.TabIndex = 7;
            this.Std_Profile_button.Text = "Go to Profile";
            this.Std_Profile_button.UseVisualStyleBackColor = false;
            this.Std_Profile_button.Click += new System.EventHandler(this.Std_Profile_button_Click);
            // 
            // view_grades_button
            // 
            this.view_grades_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_grades_button.Location = new System.Drawing.Point(34, 373);
            this.view_grades_button.Name = "view_grades_button";
            this.view_grades_button.Size = new System.Drawing.Size(187, 36);
            this.view_grades_button.TabIndex = 8;
            this.view_grades_button.Text = "View Grades";
            this.view_grades_button.UseVisualStyleBackColor = true;
            this.view_grades_button.Click += new System.EventHandler(this.view_grades_button_Click);
            // 
            // recent_submissions_button
            // 
            this.recent_submissions_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent_submissions_button.Location = new System.Drawing.Point(34, 430);
            this.recent_submissions_button.Name = "recent_submissions_button";
            this.recent_submissions_button.Size = new System.Drawing.Size(187, 36);
            this.recent_submissions_button.TabIndex = 9;
            this.recent_submissions_button.Text = "Recent Submissions";
            this.recent_submissions_button.UseVisualStyleBackColor = true;
            // 
            // enroll_in_new_classroom_button
            // 
            this.enroll_in_new_classroom_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enroll_in_new_classroom_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll_in_new_classroom_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll_in_new_classroom_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enroll_in_new_classroom_button.Location = new System.Drawing.Point(602, 302);
            this.enroll_in_new_classroom_button.Name = "enroll_in_new_classroom_button";
            this.enroll_in_new_classroom_button.Size = new System.Drawing.Size(218, 36);
            this.enroll_in_new_classroom_button.TabIndex = 10;
            this.enroll_in_new_classroom_button.Text = "Enroll in new classroom";
            this.enroll_in_new_classroom_button.UseVisualStyleBackColor = false;
            // 
            // Student_view_calender_button
            // 
            this.Student_view_calender_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Student_view_calender_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_view_calender_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_view_calender_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Student_view_calender_button.Location = new System.Drawing.Point(602, 358);
            this.Student_view_calender_button.Name = "Student_view_calender_button";
            this.Student_view_calender_button.Size = new System.Drawing.Size(218, 36);
            this.Student_view_calender_button.TabIndex = 11;
            this.Student_view_calender_button.Text = "View Calender";
            this.Student_view_calender_button.UseVisualStyleBackColor = false;
            // 
            // take_an_exam_button
            // 
            this.take_an_exam_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.take_an_exam_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.take_an_exam_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_an_exam_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.take_an_exam_button.Location = new System.Drawing.Point(346, 383);
            this.take_an_exam_button.Name = "take_an_exam_button";
            this.take_an_exam_button.Size = new System.Drawing.Size(161, 36);
            this.take_an_exam_button.TabIndex = 12;
            this.take_an_exam_button.Text = "Take an exam";
            this.take_an_exam_button.UseVisualStyleBackColor = false;
            // 
            // StudentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 478);
            this.Controls.Add(this.take_an_exam_button);
            this.Controls.Add(this.Student_view_calender_button);
            this.Controls.Add(this.enroll_in_new_classroom_button);
            this.Controls.Add(this.recent_submissions_button);
            this.Controls.Add(this.view_grades_button);
            this.Controls.Add(this.Std_Profile_button);
            this.Controls.Add(this.view_classrooms_button);
            this.Controls.Add(this.backtologin_label);
            this.Controls.Add(this.upcomingevents_gridview);
            this.Controls.Add(this.upcomingevents_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentInterface";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Student!";
            this.Load += new System.EventHandler(this.StudentInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingevents_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel upcomingevents_label;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView upcomingevents_gridview;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel backtologin_label;
        private System.Windows.Forms.Button view_classrooms_button;
        private System.Windows.Forms.Button Std_Profile_button;
        private System.Windows.Forms.Button view_grades_button;
        private System.Windows.Forms.Button recent_submissions_button;
        private System.Windows.Forms.Button enroll_in_new_classroom_button;
        private System.Windows.Forms.Button Student_view_calender_button;
        private System.Windows.Forms.Button take_an_exam_button;
    }
}