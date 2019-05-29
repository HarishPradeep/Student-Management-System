namespace Stafford_University
{
    partial class assignStudents
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
            this.ass_id = new System.Windows.Forms.TextBox();
            this.stdid = new System.Windows.Forms.ComboBox();
            this.couid = new System.Windows.Forms.ComboBox();
            this.adddate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.staffordUniversityDataSet15 = new Stafford_University.StaffordUniversityDataSet15();
            this.stdtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.std_tableTableAdapter = new Stafford_University.StaffordUniversityDataSet15TableAdapters.std_tableTableAdapter();
            this.staffordUniversityDataSet16 = new Stafford_University.StaffordUniversityDataSet16();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Stafford_University.StaffordUniversityDataSet16TableAdapters.courseTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ass_id
            // 
            this.ass_id.Location = new System.Drawing.Point(123, 73);
            this.ass_id.Name = "ass_id";
            this.ass_id.Size = new System.Drawing.Size(127, 20);
            this.ass_id.TabIndex = 0;
            // 
            // stdid
            // 
            this.stdid.DataSource = this.stdtableBindingSource;
            this.stdid.DisplayMember = "std_name";
            this.stdid.FormattingEnabled = true;
            this.stdid.Location = new System.Drawing.Point(123, 111);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(127, 21);
            this.stdid.TabIndex = 1;
            this.stdid.ValueMember = "std_id";
            // 
            // couid
            // 
            this.couid.DataSource = this.courseBindingSource;
            this.couid.DisplayMember = "cou_name";
            this.couid.FormattingEnabled = true;
            this.couid.Location = new System.Drawing.Point(123, 150);
            this.couid.Name = "couid";
            this.couid.Size = new System.Drawing.Size(127, 21);
            this.couid.TabIndex = 2;
            this.couid.ValueMember = "cou_id";
            // 
            // adddate
            // 
            this.adddate.Location = new System.Drawing.Point(123, 194);
            this.adddate.Name = "adddate";
            this.adddate.Size = new System.Drawing.Size(127, 20);
            this.adddate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 225);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(123, 234);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(127, 20);
            this.status.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(143, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(91, 77);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 16);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Added Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // staffordUniversityDataSet15
            // 
            this.staffordUniversityDataSet15.DataSetName = "StaffordUniversityDataSet15";
            this.staffordUniversityDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdtableBindingSource
            // 
            this.stdtableBindingSource.DataMember = "std_table";
            this.stdtableBindingSource.DataSource = this.staffordUniversityDataSet15;
            // 
            // std_tableTableAdapter
            // 
            this.std_tableTableAdapter.ClearBeforeFill = true;
            // 
            // staffordUniversityDataSet16
            // 
            this.staffordUniversityDataSet16.DataSetName = "StaffordUniversityDataSet16";
            this.staffordUniversityDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.staffordUniversityDataSet16;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // assignStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adddate);
            this.Controls.Add(this.couid);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.ass_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assignStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assignStudents";
            this.Load += new System.EventHandler(this.assignStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ass_id;
        private System.Windows.Forms.ComboBox stdid;
        private System.Windows.Forms.ComboBox couid;
        private System.Windows.Forms.DateTimePicker adddate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private StaffordUniversityDataSet15 staffordUniversityDataSet15;
        private System.Windows.Forms.BindingSource stdtableBindingSource;
        private StaffordUniversityDataSet15TableAdapters.std_tableTableAdapter std_tableTableAdapter;
        private StaffordUniversityDataSet16 staffordUniversityDataSet16;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StaffordUniversityDataSet16TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}