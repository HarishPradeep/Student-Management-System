namespace Stafford_University
{
    partial class course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course));
            this.cou_id = new System.Windows.Forms.TextBox();
            this.cou_name = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.couidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffordUniversityDataSet5 = new Stafford_University.StaffordUniversityDataSet5();
            this.courseTableAdapter = new Stafford_University.StaffordUniversityDataSet5TableAdapters.courseTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // cou_id
            // 
            this.cou_id.Location = new System.Drawing.Point(152, 38);
            this.cou_id.Name = "cou_id";
            this.cou_id.Size = new System.Drawing.Size(123, 20);
            this.cou_id.TabIndex = 0;
            // 
            // cou_name
            // 
            this.cou_name.Location = new System.Drawing.Point(152, 74);
            this.cou_name.Name = "cou_name";
            this.cou_name.Size = new System.Drawing.Size(123, 20);
            this.cou_name.TabIndex = 1;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(152, 111);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(123, 20);
            this.status.TabIndex = 2;
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(152, 150);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(123, 20);
            this.fee.TabIndex = 3;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(152, 190);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(123, 20);
            this.duration.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duration";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(174, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.couidDataGridViewTextBoxColumn,
            this.counameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(301, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 215);
            this.dataGridView1.TabIndex = 11;
            // 
            // couidDataGridViewTextBoxColumn
            // 
            this.couidDataGridViewTextBoxColumn.DataPropertyName = "cou_id";
            this.couidDataGridViewTextBoxColumn.HeaderText = "cou_id";
            this.couidDataGridViewTextBoxColumn.Name = "couidDataGridViewTextBoxColumn";
            // 
            // counameDataGridViewTextBoxColumn
            // 
            this.counameDataGridViewTextBoxColumn.DataPropertyName = "cou_name";
            this.counameDataGridViewTextBoxColumn.HeaderText = "cou_name";
            this.counameDataGridViewTextBoxColumn.Name = "counameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.staffordUniversityDataSet5;
            // 
            // staffordUniversityDataSet5
            // 
            this.staffordUniversityDataSet5.DataSetName = "StaffordUniversityDataSet5";
            this.staffordUniversityDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(622, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.status);
            this.Controls.Add(this.cou_name);
            this.Controls.Add(this.cou_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "course";
            this.Load += new System.EventHandler(this.course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cou_id;
        private System.Windows.Forms.TextBox cou_name;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StaffordUniversityDataSet5 staffordUniversityDataSet5;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StaffordUniversityDataSet5TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn couidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}