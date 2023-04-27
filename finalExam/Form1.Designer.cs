namespace finalExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_student = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.ComboBox();
            this.txt_session = new System.Windows.Forms.ComboBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "OOP C# - Final Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name and ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Schedule: Tu. 8:00-11:00   Th. 13:00-16:00 (4409)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Session:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "(Fall, Winter, Summer)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teacher Name:\r\nMihai Maftei";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "Course Number:\r\n420-CT2-AS\r\ngr. 7194";
            // 
            // txt_student
            // 
            this.txt_student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_student.Location = new System.Drawing.Point(168, 61);
            this.txt_student.Name = "txt_student";
            this.txt_student.ReadOnly = true;
            this.txt_student.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_student.Size = new System.Drawing.Size(360, 22);
            this.txt_student.TabIndex = 0;
            this.txt_student.TabStop = false;
            this.txt_student.Text = "Full name and student number at run time";
            // 
            // txt_year
            // 
            this.txt_year.FormattingEnabled = true;
            this.txt_year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.txt_year.Location = new System.Drawing.Point(156, 154);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(83, 24);
            this.txt_year.TabIndex = 9;
            this.txt_year.Text = "2023";
            // 
            // txt_session
            // 
            this.txt_session.FormattingEnabled = true;
            this.txt_session.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Summer"});
            this.txt_session.Location = new System.Drawing.Point(342, 153);
            this.txt_session.Name = "txt_session";
            this.txt_session.Size = new System.Drawing.Size(83, 24);
            this.txt_session.TabIndex = 10;
            this.txt_session.Text = "Winter";
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.SystemColors.Control;
            this.btn_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_image.BackgroundImage")));
            this.btn_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_image.Location = new System.Drawing.Point(15, 221);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(142, 140);
            this.btn_image.TabIndex = 11;
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_reset.Location = new System.Drawing.Point(196, 329);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 32);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "&Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(474, 329);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 32);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.txt_session);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_student);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_student;
        private System.Windows.Forms.ComboBox txt_year;
        private System.Windows.Forms.ComboBox txt_session;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
    }
}

