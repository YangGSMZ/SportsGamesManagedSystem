namespace 学校运动会管理系统
{
    partial class Form_tiansai
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
            this.tGameidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.jwglDataSet = new 学校运动会管理系统.jwglDataSet();
            this.jwglDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_tGameTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_tGameTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbtGameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_tGameTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_tGameTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "田赛信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tGameidDataGridViewTextBoxColumn,
            this.tGamenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbtGameBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(392, 109);
            this.dataGridView1.TabIndex = 0;
            // 
            // tGameidDataGridViewTextBoxColumn
            // 
            this.tGameidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tGameidDataGridViewTextBoxColumn.DataPropertyName = "tGame_id";
            this.tGameidDataGridViewTextBoxColumn.HeaderText = "tGame_id";
            this.tGameidDataGridViewTextBoxColumn.Name = "tGameidDataGridViewTextBoxColumn";
            // 
            // tGamenameDataGridViewTextBoxColumn
            // 
            this.tGamenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tGamenameDataGridViewTextBoxColumn.DataPropertyName = "tGame_name";
            this.tGamenameDataGridViewTextBoxColumn.HeaderText = "tGame_name";
            this.tGamenameDataGridViewTextBoxColumn.Name = "tGamenameDataGridViewTextBoxColumn";
            // 
            // dbtGameBindingSource
            // 
            this.dbtGameBindingSource.DataMember = "db_tGame";
            this.dbtGameBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jwglDataSet
            // 
            this.jwglDataSet.DataSetName = "jwglDataSet";
            this.jwglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jwglDataSetBindingSource
            // 
            this.jwglDataSetBindingSource.DataSource = this.jwglDataSet;
            this.jwglDataSetBindingSource.Position = 0;
            // 
            // db_tGameTableAdapter
            // 
            this.db_tGameTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 153);
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
            // dbtGameBindingSource1
            // 
            this.dbtGameBindingSource1.DataMember = "db_tGame";
            this.dbtGameBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // db_tGameTableAdapter1
            // 
            this.db_tGameTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_tiansai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_tiansai";
            this.Text = "Form_tiansai";
            this.Load += new System.EventHandler(this.Form_tiansai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jwglDataSetBindingSource;
        private jwglDataSet jwglDataSet;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbtGameBindingSource;
        private jwglDataSet1TableAdapters.db_tGameTableAdapter db_tGameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGameidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbtGameBindingSource1;
        private jwglDataSet2TableAdapters.db_tGameTableAdapter db_tGameTableAdapter1;
    }
}