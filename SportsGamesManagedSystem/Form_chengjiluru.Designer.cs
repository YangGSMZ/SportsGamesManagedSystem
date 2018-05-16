namespace 学校运动会管理系统
{
    partial class Form_chengjiluru
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
            this.dbattendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_attendTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_attendTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbattendBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_attendTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_attendTableAdapter();
            this.athleteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chengjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paimingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jifenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbattendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbattendBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成绩录入";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteidDataGridViewTextBoxColumn,
            this.gameidDataGridViewTextBoxColumn,
            this.game_name,
            this.chengjiDataGridViewTextBoxColumn,
            this.paimingDataGridViewTextBoxColumn,
            this.jifenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbattendBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(571, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbattendBindingSource
            // 
            this.dbattendBindingSource.DataMember = "db_attend";
            this.dbattendBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_attendTableAdapter
            // 
            this.db_attendTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbattendBindingSource1
            // 
            this.dbattendBindingSource1.DataMember = "db_attend";
            this.dbattendBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // db_attendTableAdapter1
            // 
            this.db_attendTableAdapter1.ClearBeforeFill = true;
            // 
            // athleteidDataGridViewTextBoxColumn
            // 
            this.athleteidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athleteidDataGridViewTextBoxColumn.DataPropertyName = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.HeaderText = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.Name = "athleteidDataGridViewTextBoxColumn";
            this.athleteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameidDataGridViewTextBoxColumn
            // 
            this.gameidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gameidDataGridViewTextBoxColumn.DataPropertyName = "game_id";
            this.gameidDataGridViewTextBoxColumn.HeaderText = "game_id";
            this.gameidDataGridViewTextBoxColumn.Name = "gameidDataGridViewTextBoxColumn";
            this.gameidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // game_name
            // 
            this.game_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.game_name.DataPropertyName = "game_name";
            this.game_name.HeaderText = "game_name";
            this.game_name.Name = "game_name";
            // 
            // chengjiDataGridViewTextBoxColumn
            // 
            this.chengjiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chengjiDataGridViewTextBoxColumn.DataPropertyName = "chengji";
            this.chengjiDataGridViewTextBoxColumn.HeaderText = "chengji";
            this.chengjiDataGridViewTextBoxColumn.Name = "chengjiDataGridViewTextBoxColumn";
            // 
            // paimingDataGridViewTextBoxColumn
            // 
            this.paimingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paimingDataGridViewTextBoxColumn.DataPropertyName = "paiming";
            this.paimingDataGridViewTextBoxColumn.HeaderText = "paiming";
            this.paimingDataGridViewTextBoxColumn.Name = "paimingDataGridViewTextBoxColumn";
            // 
            // jifenDataGridViewTextBoxColumn
            // 
            this.jifenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jifenDataGridViewTextBoxColumn.DataPropertyName = "jifen";
            this.jifenDataGridViewTextBoxColumn.HeaderText = "jifen";
            this.jifenDataGridViewTextBoxColumn.Name = "jifenDataGridViewTextBoxColumn";
            // 
            // Form_chengjiluru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_chengjiluru";
            this.Text = "Form_chengjiluru";
            this.Load += new System.EventHandler(this.Form_chengjiluru_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbattendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbattendBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbattendBindingSource;
        private jwglDataSet1TableAdapters.db_attendTableAdapter db_attendTableAdapter;
        private System.Windows.Forms.Button button1;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbattendBindingSource1;
        private jwglDataSet2TableAdapters.db_attendTableAdapter db_attendTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chengjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paimingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jifenDataGridViewTextBoxColumn;
    }
}