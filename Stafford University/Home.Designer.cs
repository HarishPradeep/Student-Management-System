namespace Stafford_University
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lecture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Button();
            this.Course = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 533);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lecture
            // 
            this.Lecture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecture.Image = ((System.Drawing.Image)(resources.GetObject("Lecture.Image")));
            this.Lecture.Location = new System.Drawing.Point(106, 130);
            this.Lecture.Name = "Lecture";
            this.Lecture.Size = new System.Drawing.Size(124, 109);
            this.Lecture.TabIndex = 1;
            this.Lecture.Text = "PROFESSOR";
            this.Lecture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lecture.UseVisualStyleBackColor = true;
            this.Lecture.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copyrights @ 2018 - All Rights Reserved Stafford University ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Student
            // 
            this.Student.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Image = ((System.Drawing.Image)(resources.GetObject("Student.Image")));
            this.Student.Location = new System.Drawing.Point(309, 130);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(124, 109);
            this.Student.TabIndex = 3;
            this.Student.Text = "STUDENT";
            this.Student.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.button2_Click);
            // 
            // Course
            // 
            this.Course.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Image = ((System.Drawing.Image)(resources.GetObject("Course.Image")));
            this.Course.Location = new System.Drawing.Point(510, 130);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(124, 109);
            this.Course.TabIndex = 4;
            this.Course.Text = "COURSES";
            this.Course.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Course.UseVisualStyleBackColor = true;
            this.Course.Click += new System.EventHandler(this.Course_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(622, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 109);
            this.button2.TabIndex = 6;
            this.button2.Text = "Assign For Course Professors";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(309, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 109);
            this.button3.TabIndex = 7;
            this.button3.Text = "Course Catlog";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(511, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "        Logged As Register";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(510, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 109);
            this.button4.TabIndex = 9;
            this.button4.Text = "Payments";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(309, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 117);
            this.button5.TabIndex = 10;
            this.button5.Text = "Assign for Courses Students";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(709, 521);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Lecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Course;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

