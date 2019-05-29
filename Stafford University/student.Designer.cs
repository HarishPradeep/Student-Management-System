namespace Stafford_University
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.std_id = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.std_name = new System.Windows.Forms.TextBox();
            this.mob_num = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.reg_id = new System.Windows.Forms.ComboBox();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffordUniversityDataSet4 = new Stafford_University.StaffordUniversityDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.AddStd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.registerTableAdapter = new Stafford_University.StaffordUniversityDataSet4TableAdapters.registerTableAdapter();
            this.staffordUniversityDataSet6 = new Stafford_University.StaffordUniversityDataSet6();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Stafford_University.StaffordUniversityDataSet6TableAdapters.courseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // std_id
            // 
            this.std_id.Location = new System.Drawing.Point(156, 60);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(137, 20);
            this.std_id.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(156, 209);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(137, 20);
            this.address.TabIndex = 1;
            // 
            // std_name
            // 
            this.std_name.Location = new System.Drawing.Point(156, 98);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(137, 20);
            this.std_name.TabIndex = 4;
            // 
            // mob_num
            // 
            this.mob_num.Location = new System.Drawing.Point(156, 136);
            this.mob_num.Name = "mob_num";
            this.mob_num.Size = new System.Drawing.Size(137, 20);
            this.mob_num.TabIndex = 5;
            // 
            // course
            // 
            this.course.DataSource = this.courseBindingSource;
            this.course.DisplayMember = "cou_name";
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(156, 173);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(137, 21);
            this.course.TabIndex = 7;
            this.course.ValueMember = "cou_name";
            // 
            // reg_id
            // 
            this.reg_id.DataSource = this.registerBindingSource;
            this.reg_id.DisplayMember = "name";
            this.reg_id.FormattingEnabled = true;
            this.reg_id.Location = new System.Drawing.Point(156, 296);
            this.reg_id.Name = "reg_id";
            this.reg_id.Size = new System.Drawing.Size(137, 21);
            this.reg_id.TabIndex = 8;
            this.reg_id.ValueMember = "reg_id";
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.staffordUniversityDataSet4;
            // 
            // staffordUniversityDataSet4
            // 
            this.staffordUniversityDataSet4.DataSetName = "StaffordUniversityDataSet4";
            this.staffordUniversityDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date OF Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Register ID";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(156, 256);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(137, 20);
            this.dob.TabIndex = 17;
            this.dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddStd
            // 
            this.AddStd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddStd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStd.ForeColor = System.Drawing.SystemColors.Control;
            this.AddStd.Location = new System.Drawing.Point(181, 333);
            this.AddStd.Name = "AddStd";
            this.AddStd.Size = new System.Drawing.Size(75, 35);
            this.AddStd.TabIndex = 18;
            this.AddStd.Text = "Register";
            this.AddStd.UseVisualStyleBackColor = false;
            this.AddStd.Click += new System.EventHandler(this.AddStd_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(332, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 47);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // staffordUniversityDataSet6
            // 
            this.staffordUniversityDataSet6.DataSetName = "StaffordUniversityDataSet6";
            this.staffordUniversityDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.staffordUniversityDataSet6;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddStd);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_id);
            this.Controls.Add(this.course);
            this.Controls.Add(this.mob_num);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.std_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox std_id;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.TextBox mob_num;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.ComboBox reg_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button AddStd;
        private System.Windows.Forms.Button button1;
        private StaffordUniversityDataSet4 staffordUniversityDataSet4;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private StaffordUniversityDataSet4TableAdapters.registerTableAdapter registerTableAdapter;
        private StaffordUniversityDataSet6 staffordUniversityDataSet6;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StaffordUniversityDataSet6TableAdapters.courseTableAdapter courseTableAdapter;
    }
}