namespace 学校运动会管理系统
{
    partial class Form_jingsai
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
            this.jGameidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jGamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbjGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.db_jGameTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_jGameTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbjGameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_jGameTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_jGameTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "径赛信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jGameidDataGridViewTextBoxColumn,
            this.jGamenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbjGameBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(376, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // jGameidDataGridViewTextBoxColumn
            // 
            this.jGameidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jGameidDataGridViewTextBoxColumn.DataPropertyName = "jGame_id";
            this.jGameidDataGridViewTextBoxColumn.HeaderText = "jGame_id";
            this.jGameidDataGridViewTextBoxColumn.Name = "jGameidDataGridViewTextBoxColumn";
            // 
            // jGamenameDataGridViewTextBoxColumn
            // 
            this.jGamenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jGamenameDataGridViewTextBoxColumn.DataPropertyName = "jGame_name";
            this.jGamenameDataGridViewTextBoxColumn.HeaderText = "jGame_name";
            this.jGamenameDataGridViewTextBoxColumn.Name = "jGamenameDataGridViewTextBoxColumn";
            // 
            // dbjGameBindingSource
            // 
            this.dbjGameBindingSource.DataMember = "db_jGame";
            this.dbjGameBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_jGameTableAdapter
            // 
            this.db_jGameTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 155);
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
            // dbjGameBindingSource1
            // 
            this.dbjGameBindingSource1.DataMember = "db_jGame";
            this.dbjGameBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // db_jGameTableAdapter1
            // 
            this.db_jGameTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_jingsai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_jingsai";
            this.Text = "Form_jingsai";
            this.Load += new System.EventHandler(this.Form_jingsai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbjGameBindingSource;
        private jwglDataSet1TableAdapters.db_jGameTableAdapter db_jGameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jGameidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jGamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbjGameBindingSource1;
        private jwglDataSet2TableAdapters.db_jGameTableAdapter db_jGameTableAdapter1;
    }
}