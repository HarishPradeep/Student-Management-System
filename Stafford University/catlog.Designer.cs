namespace Stafford_University
{
    partial class catlog
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
            this.staffordUniversityDataSet12 = new Stafford_University.StaffordUniversityDataSet12();
            this.courseprofessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_professorTableAdapter = new Stafford_University.StaffordUniversityDataSet12TableAdapters.course_professorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Stafford_University.StaffordUniversityDataSet5TableAdapters.TableAdapterManager();
            this.staffordUniversityDataSet5 = new Stafford_University.StaffordUniversityDataSet5();
            this.courseTableAdapter = new Stafford_University.StaffordUniversityDataSet5TableAdapters.courseTableAdapter();
            this.staffordUniversityDataSet13 = new Stafford_University.StaffordUniversityDataSet13();
            this.courseprofessorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.course_professorTableAdapter1 = new Stafford_University.StaffordUniversityDataSet13TableAdapters.course_professorTableAdapter();
            this.staffordUniversityDataSet14 = new Stafford_University.StaffordUniversityDataSet14();
            this.courseprofessorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.course_professorTableAdapter2 = new Stafford_University.StaffordUniversityDataSet14TableAdapters.course_professorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffordUniversityDataSet12
            // 
            this.staffordUniversityDataSet12.DataSetName = "StaffordUniversityDataSet12";
            this.staffordUniversityDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseprofessorBindingSource
            // 
            this.courseprofessorBindingSource.DataMember = "course_professor";
            this.courseprofessorBindingSource.DataSource = this.staffordUniversityDataSet12;
            // 
            // course_professorTableAdapter
            // 
            this.course_professorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 283);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.UpdateOrder = Stafford_University.StaffordUniversityDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // staffordUniversityDataSet13
            // 
            this.staffordUniversityDataSet13.DataSetName = "StaffordUniversityDataSet13";
            this.staffordUniversityDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseprofessorBindingSource1
            // 
            this.courseprofessorBindingSource1.DataMember = "course_professor";
            this.courseprofessorBindingSource1.DataSource = this.staffordUniversityDataSet13;
            // 
            // course_professorTableAdapter1
            // 
            this.course_professorTableAdapter1.ClearBeforeFill = true;
            // 
            // staffordUniversityDataSet14
            // 
            this.staffordUniversityDataSet14.DataSetName = "StaffordUniversityDataSet14";
            this.staffordUniversityDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseprofessorBindingSource2
            // 
            this.courseprofessorBindingSource2.DataMember = "course_professor";
            this.courseprofessorBindingSource2.DataSource = this.staffordUniversityDataSet14;
            // 
            // course_professorTableAdapter2
            // 
            this.course_professorTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 252);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // catlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 311);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "catlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "catlog";
            this.Load += new System.EventHandler(this.catlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffordUniversityDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseprofessorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StaffordUniversityDataSet12 staffordUniversityDataSet12;
        private System.Windows.Forms.BindingSource courseprofessorBindingSource;
        private StaffordUniversityDataSet12TableAdapters.course_professorTableAdapter course_professorTableAdapter;
        private System.Windows.Forms.Button button1;
        private StaffordUniversityDataSet5 staffordUniversityDataSet5;
        private StaffordUniversityDataSet5TableAdapters.courseTableAdapter courseTableAdapter;
        private StaffordUniversityDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private StaffordUniversityDataSet13 staffordUniversityDataSet13;
        private System.Windows.Forms.BindingSource courseprofessorBindingSource1;
        private StaffordUniversityDataSet13TableAdapters.course_professorTableAdapter course_professorTableAdapter1;
        private StaffordUniversityDataSet14 staffordUniversityDataSet14;
        private System.Windows.Forms.BindingSource courseprofessorBindingSource2;
        private StaffordUniversityDataSet14TableAdapters.course_professorTableAdapter course_professorTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}