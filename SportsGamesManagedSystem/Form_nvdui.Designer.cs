namespace 学校运动会管理系统
{
    partial class Form_nvdui
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
            this.femaleTeamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femaleTeamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbfemaleTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db_femaleTeamTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_femaleTeamTableAdapter();
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbfemaleTeamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_femaleTeamTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_femaleTeamTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "女队信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.femaleTeamidDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.femaleTeamnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbfemaleTeamBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(382, 103);
            this.dataGridView1.TabIndex = 0;
            // 
            // femaleTeamidDataGridViewTextBoxColumn
            // 
            this.femaleTeamidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.femaleTeamidDataGridViewTextBoxColumn.DataPropertyName = "femaleTeam_id";
            this.femaleTeamidDataGridViewTextBoxColumn.HeaderText = "femaleTeam_id";
            this.femaleTeamidDataGridViewTextBoxColumn.Name = "femaleTeamidDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // femaleTeamnameDataGridViewTextBoxColumn
            // 
            this.femaleTeamnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.femaleTeamnameDataGridViewTextBoxColumn.DataPropertyName = "femaleTeam_name";
            this.femaleTeamnameDataGridViewTextBoxColumn.HeaderText = "femaleTeam_name";
            this.femaleTeamnameDataGridViewTextBoxColumn.Name = "femaleTeamnameDataGridViewTextBoxColumn";
            // 
            // dbfemaleTeamBindingSource
            // 
            this.dbfemaleTeamBindingSource.DataMember = "db_femaleTeam";
            this.dbfemaleTeamBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_femaleTeamTableAdapter
            // 
            this.db_femaleTeamTableAdapter.ClearBeforeFill = true;
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbfemaleTeamBindingSource1
            // 
            this.dbfemaleTeamBindingSource1.DataMember = "db_femaleTeam";
            this.dbfemaleTeamBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // db_femaleTeamTableAdapter1
            // 
            this.db_femaleTeamTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_nvdui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_nvdui";
            this.Text = "Form_nvdui";
            this.Load += new System.EventHandler(this.Form_nvdui_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbfemaleTeamBindingSource;
        private jwglDataSet1TableAdapters.db_femaleTeamTableAdapter db_femaleTeamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn femaleTeamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn femaleTeamnameDataGridViewTextBoxColumn;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbfemaleTeamBindingSource1;
        private jwglDataSet2TableAdapters.db_femaleTeamTableAdapter db_femaleTeamTableAdapter1;
    }
}