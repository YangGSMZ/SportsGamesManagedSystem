namespace 学校运动会管理系统
{
    partial class Form_cansaibumenluru
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbdepartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet = new 学校运动会管理系统.jwglDataSet();
            this.dbdepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_departmentTableAdapter = new 学校运动会管理系统.jwglDataSetTableAdapters.db_departmentTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbdepartmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_departmentTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_departmentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentidDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbdepartmentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(356, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            // 
            // dbdepartmentBindingSource1
            // 
            this.dbdepartmentBindingSource1.DataMember = "db_department";
            this.dbdepartmentBindingSource1.DataSource = this.jwglDataSet;
            // 
            // jwglDataSet
            // 
            this.jwglDataSet.DataSetName = "jwglDataSet";
            this.jwglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbdepartmentBindingSource
            // 
            this.dbdepartmentBindingSource.DataMember = "db_department";
            this.dbdepartmentBindingSource.DataSource = this.jwglDataSet;
            // 
            // db_departmentTableAdapter
            // 
            this.db_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbdepartmentBindingSource2
            // 
            this.dbdepartmentBindingSource2.DataMember = "db_department";
            this.dbdepartmentBindingSource2.DataSource = this.jwglDataSet2;
            // 
            // db_departmentTableAdapter1
            // 
            this.db_departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_cansaibumenluru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_cansaibumenluru";
            this.Text = "Form_cansaibumenluru";
            this.Load += new System.EventHandler(this.Form_cansaibumenluru_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private jwglDataSet jwglDataSet;
        private System.Windows.Forms.BindingSource dbdepartmentBindingSource;
        private jwglDataSetTableAdapters.db_departmentTableAdapter db_departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dbdepartmentBindingSource1;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbdepartmentBindingSource2;
        private jwglDataSet2TableAdapters.db_departmentTableAdapter db_departmentTableAdapter1;
    }
}