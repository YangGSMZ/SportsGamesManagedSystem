namespace 学校运动会管理系统
{
    partial class Form_yundongyuan
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
            this.dbathleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db_athleteTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_athleteTableAdapter();
            this.dbathleteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbathleteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbathleteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_athleteTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_athleteTableAdapter();
            this.jwglDataSet3 = new 学校运动会管理系统.jwglDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbathleteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.athleteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletesexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletegameNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运动员信息";
            // 
            // dbathleteBindingSource
            // 
            this.dbathleteBindingSource.DataMember = "db_athlete";
            this.dbathleteBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_athleteTableAdapter
            // 
            this.db_athleteTableAdapter.ClearBeforeFill = true;
            // 
            // dbathleteBindingSource1
            // 
            this.dbathleteBindingSource1.DataMember = "db_athlete";
            this.dbathleteBindingSource1.DataSource = this.jwglDataSet1;
            // 
            // dbathleteBindingSource2
            // 
            this.dbathleteBindingSource2.DataMember = "db_athlete";
            this.dbathleteBindingSource2.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbathleteBindingSource3
            // 
            this.dbathleteBindingSource3.DataMember = "db_athlete";
            this.dbathleteBindingSource3.DataSource = this.jwglDataSet2;
            // 
            // db_athleteTableAdapter1
            // 
            this.db_athleteTableAdapter1.ClearBeforeFill = true;
            // 
            // jwglDataSet3
            // 
            this.jwglDataSet3.DataSetName = "jwglDataSet";
            this.jwglDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteidDataGridViewTextBoxColumn,
            this.athletenameDataGridViewTextBoxColumn,
            this.athletesexDataGridViewTextBoxColumn,
            this.athletegameNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbathleteBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(468, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbathleteBindingSource4
            // 
            this.dbathleteBindingSource4.DataMember = "db_athlete";
            this.dbathleteBindingSource4.DataSource = this.jwglDataSet2;
            // 
            // athleteidDataGridViewTextBoxColumn
            // 
            this.athleteidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athleteidDataGridViewTextBoxColumn.DataPropertyName = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.HeaderText = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.Name = "athleteidDataGridViewTextBoxColumn";
            // 
            // athletenameDataGridViewTextBoxColumn
            // 
            this.athletenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athletenameDataGridViewTextBoxColumn.DataPropertyName = "athlete_name";
            this.athletenameDataGridViewTextBoxColumn.HeaderText = "athlete_name";
            this.athletenameDataGridViewTextBoxColumn.Name = "athletenameDataGridViewTextBoxColumn";
            // 
            // athletesexDataGridViewTextBoxColumn
            // 
            this.athletesexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athletesexDataGridViewTextBoxColumn.DataPropertyName = "athlete_sex";
            this.athletesexDataGridViewTextBoxColumn.HeaderText = "athlete_sex";
            this.athletesexDataGridViewTextBoxColumn.Name = "athletesexDataGridViewTextBoxColumn";
            // 
            // athletegameNumDataGridViewTextBoxColumn
            // 
            this.athletegameNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athletegameNumDataGridViewTextBoxColumn.DataPropertyName = "athlete_gameNum";
            this.athletegameNumDataGridViewTextBoxColumn.HeaderText = "athlete_gameNum";
            this.athletegameNumDataGridViewTextBoxColumn.Name = "athletegameNumDataGridViewTextBoxColumn";
            // 
            // Form_yundongyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_yundongyuan";
            this.Text = "Form_yundongyuan";
            this.Load += new System.EventHandler(this.Form_yundongyuan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbathleteBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbathleteBindingSource;
        private jwglDataSet1TableAdapters.db_athleteTableAdapter db_athleteTableAdapter;
        private System.Windows.Forms.BindingSource dbathleteBindingSource2;
        private System.Windows.Forms.BindingSource dbathleteBindingSource1;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbathleteBindingSource3;
        private jwglDataSet2TableAdapters.db_athleteTableAdapter db_athleteTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletesexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletegameNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dbathleteBindingSource4;
        private jwglDataSet jwglDataSet3;
    }
}