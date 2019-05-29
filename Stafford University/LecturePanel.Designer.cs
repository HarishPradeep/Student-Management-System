namespace Stafford_University
{
    partial class LecturePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturePanel));
            this.lec_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lecID = new System.Windows.Forms.TextBox();
            this.lecName = new System.Windows.Forms.TextBox();
            this.lecStatus = new System.Windows.Forms.TextBox();
            this.lecSpl = new System.Windows.Forms.TextBox();
            this.lecAdd = new System.Windows.Forms.TextBox();
            this.addedDate = new System.Windows.Forms.DateTimePicker();
            this.lecDOB = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.reg_id = new System.Windows.Forms.ComboBox();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffordUniversityDataSet1 = new Stafford_University.StaffordUniversityDataSet1();
            this.staffordUniversityDataSet = new Stafford_University.StaffordUniversityDataSet();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Stafford_University.StaffordUniversityDataSetTableAdapters.lectureTableAdapter();
            this.registerTableAdapter = new Stafford_University.StaffordUniversityDataSet1TableAdapters.registerTableAdapter();
            this.staffordUniversityDataSet2 = new Stafford_University.StaffordUniversityDataSet2();
            this.lectureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter1 = new Stafford_University.StaffordUniversityDataSet2TableAdapters.lectureTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lecidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffordUniversityDataSet3 = new Stafford_University.StaffordUniversityDataSet3();
            this.lec_tableTableAdapter = new Stafford_University.StaffordUniversityDataSet3TableAdapters.lec_tableTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lec_id
            // 
            this.lec_id.AutoSize = true;
            this.lec_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_id.Location = new System.Drawing.Point(72, 92);
            this.lec_id.Name = "lec_id";
            this.lec_id.Size = new System.Drawing.Size(80, 19);
            this.lec_id.TabIndex = 0;
            this.lec_id.Text = "Lecture Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speciality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Register Id";
            // 
            // lecID
            // 
            this.lecID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecID.Location = new System.Drawing.Point(188, 91);
            this.lecID.Name = "lecID";
            this.lecID.Size = new System.Drawing.Size(126, 23);
            this.lecID.TabIndex = 8;
            // 
            // lecName
            // 
            this.lecName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecName.Location = new System.Drawing.Point(188, 127);
            this.lecName.Name = "lecName";
            this.lecName.Size = new System.Drawing.Size(126, 23);
            this.lecName.TabIndex = 9;
            this.lecName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lecStatus
            // 
            this.lecStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecStatus.Location = new System.Drawing.Point(188, 159);
            this.lecStatus.Name = "lecStatus";
            this.lecStatus.Size = new System.Drawing.Size(126, 23);
            this.lecStatus.TabIndex = 10;
            // 
            // lecSpl
            // 
            this.lecSpl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecSpl.Location = new System.Drawing.Point(188, 191);
            this.lecSpl.Name = "lecSpl";
            this.lecSpl.Size = new System.Drawing.Size(126, 23);
            this.lecSpl.TabIndex = 11;
            // 
            // lecAdd
            // 
            this.lecAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecAdd.Location = new System.Drawing.Point(188, 263);
            this.lecAdd.Name = "lecAdd";
            this.lecAdd.Size = new System.Drawing.Size(126, 23);
            this.lecAdd.TabIndex = 13;
            // 
            // addedDate
            // 
            this.addedDate.Location = new System.Drawing.Point(188, 294);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(126, 20);
            this.addedDate.TabIndex = 16;
            // 
            // lecDOB
            // 
            this.lecDOB.Location = new System.Drawing.Point(188, 227);
            this.lecDOB.Name = "lecDOB";
            this.lecDOB.Size = new System.Drawing.Size(126, 20);
            this.lecDOB.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(188, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reg_id
            // 
            this.reg_id.DataSource = this.registerBindingSource;
            this.reg_id.DisplayMember = "name";
            this.reg_id.FormattingEnabled = true;
            this.reg_id.Location = new System.Drawing.Point(188, 326);
            this.reg_id.Name = "reg_id";
            this.reg_id.Size = new System.Drawing.Size(126, 21);
            this.reg_id.TabIndex = 21;
            this.reg_id.ValueMember = "reg_id";
            this.reg_id.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.staffordUniversityDataSet1;
            // 
            // staffordUniversityDataSet1
            // 
            this.staffordUniversityDataSet1.DataSetName = "StaffordUniversityDataSet1";
            this.staffordUniversityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffordUniversityDataSet
            // 
            this.staffordUniversityDataSet.DataSetName = "StaffordUniversityDataSet";
            this.staffordUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "lecture";
            this.lectureBindingSource.DataSource = this.staffordUniversityDataSet;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // staffordUniversityDataSet2
            // 
            this.staffordUniversityDataSet2.DataSetName = "StaffordUniversityDataSet2";
            this.staffordUniversityDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource1
            // 
            this.lectureBindingSource1.DataMember = "lecture";
            this.lectureBindingSource1.DataSource = this.staffordUniversityDataSet2;
            // 
            // lectureTableAdapter1
            // 
            this.lectureTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecidDataGridViewTextBoxColumn,
            this.lecnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.splDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.adddateDataGridViewTextBoxColumn,
            this.regidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lectableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 231);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lecidDataGridViewTextBoxColumn
            // 
            this.lecidDataGridViewTextBoxColumn.DataPropertyName = "lec_id";
            this.lecidDataGridViewTextBoxColumn.HeaderText = "lec_id";
            this.lecidDataGridViewTextBoxColumn.Name = "lecidDataGridViewTextBoxColumn";
            // 
            // lecnameDataGridViewTextBoxColumn
            // 
            this.lecnameDataGridViewTextBoxColumn.DataPropertyName = "lec_name";
            this.lecnameDataGridViewTextBoxColumn.HeaderText = "lec_name";
            this.lecnameDataGridViewTextBoxColumn.Name = "lecnameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // splDataGridViewTextBoxColumn
            // 
            this.splDataGridViewTextBoxColumn.DataPropertyName = "spl";
            this.splDataGridViewTextBoxColumn.HeaderText = "spl";
            this.splDataGridViewTextBoxColumn.Name = "splDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // adddateDataGridViewTextBoxColumn
            // 
            this.adddateDataGridViewTextBoxColumn.DataPropertyName = "adddate";
            this.adddateDataGridViewTextBoxColumn.HeaderText = "adddate";
            this.adddateDataGridViewTextBoxColumn.Name = "adddateDataGridViewTextBoxColumn";
            // 
            // regidDataGridViewTextBoxColumn
            // 
            this.regidDataGridViewTextBoxColumn.DataPropertyName = "reg_id";
            this.regidDataGridViewTextBoxColumn.HeaderText = "reg_id";
            this.regidDataGridViewTextBoxColumn.Name = "regidDataGridViewTextBoxColumn";
            // 
            // lectableBindingSource
            // 
            this.lectableBindingSource.DataMember = "lec_table";
            this.lectableBindingSource.DataSource = this.staffordUniversityDataSet3;
            // 
            // staffordUniversityDataSet3
            // 
            this.staffordUniversityDataSet3.DataSetName = "StaffordUniversityDataSet3";
            this.staffordUniversityDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lec_tableTableAdapter
            // 
            this.lec_tableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(730, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 40);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(320, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 35);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Olive;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(335, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 43);
            this.button4.TabIndex = 26;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LecturePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 456);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reg_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lecDOB);
            this.Controls.Add(this.addedDate);
            this.Controls.Add(this.lecAdd);
            this.Controls.Add(this.lecSpl);
            this.Controls.Add(this.lecStatus);
            this.Controls.Add(this.lecName);
            this.Controls.Add(this.lecID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lec_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturePanel";
            this.Load += new System.EventHandler(this.LecturePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lec_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lecName;
        private System.Windows.Forms.TextBox lecStatus;
        private System.Windows.Forms.TextBox lecSpl;
        private System.Windows.Forms.TextBox lecAdd;
        private System.Windows.Forms.DateTimePicker addedDate;
        private System.Windows.Forms.DateTimePicker lecDOB;
        private System.Windows.Forms.TextBox lecID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox reg_id;
        private StaffordUniversityDataSet staffordUniversityDataSet;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private StaffordUniversityDataSetTableAdapters.lectureTableAdapter lectureTableAdapter;
        private StaffordUniversityDataSet1 staffordUniversityDataSet1;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private StaffordUniversityDataSet1TableAdapters.registerTableAdapter registerTableAdapter;
        private StaffordUniversityDataSet2 staffordUniversityDataSet2;
        private System.Windows.Forms.BindingSource lectureBindingSource1;
        private StaffordUniversityDataSet2TableAdapters.lectureTableAdapter lectureTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StaffordUniversityDataSet3 staffordUniversityDataSet3;
        private System.Windows.Forms.BindingSource lectableBindingSource;
        private StaffordUniversityDataSet3TableAdapters.lec_tableTableAdapter lec_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn splDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}