namespace 学校运动会管理系统
{
    partial class Form_duiyuanguishu
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
            this.dbbelongBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet3 = new 学校运动会管理系统.jwglDataSet3();
            this.dbbelongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.dbbelongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbbelongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_belongTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_belongTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db_belongTableAdapter1 = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_belongTableAdapter();
            this.dbbelongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_belongTableAdapter2 = new 学校运动会管理系统.jwglDataSet3TableAdapters.db_belongTableAdapter();
            this.jwglDataSet4 = new 学校运动会管理系统.jwglDataSet4();
            this.dbbelongBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.db_belongTableAdapter3 = new 学校运动会管理系统.jwglDataSet4TableAdapters.db_belongTableAdapter();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depertment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depertment_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "队员与队伍关系";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamidDataGridViewTextBoxColumn,
            this.depertment_id,
            this.depertment_name,
            this.athleteidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbbelongBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbbelongBindingSource4
            // 
            this.dbbelongBindingSource4.DataMember = "db_belong";
            this.dbbelongBindingSource4.DataSource = this.jwglDataSet3;
            // 
            // jwglDataSet3
            // 
            this.jwglDataSet3.DataSetName = "jwglDataSet3";
            this.jwglDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbbelongBindingSource2
            // 
            this.dbbelongBindingSource2.DataMember = "db_belong";
            this.dbbelongBindingSource2.DataSource = this.jwglDataSet2;
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbbelongBindingSource1
            // 
            this.dbbelongBindingSource1.DataMember = "db_belong";
            this.dbbelongBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // dbbelongBindingSource
            // 
            this.dbbelongBindingSource.DataMember = "db_belong";
            this.dbbelongBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_belongTableAdapter
            // 
            this.db_belongTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_belongTableAdapter1
            // 
            this.db_belongTableAdapter1.ClearBeforeFill = true;
            // 
            // dbbelongBindingSource3
            // 
            this.dbbelongBindingSource3.DataMember = "db_belong";
            this.dbbelongBindingSource3.DataSource = this.jwglDataSet2;
            // 
            // db_belongTableAdapter2
            // 
            this.db_belongTableAdapter2.ClearBeforeFill = true;
            // 
            // jwglDataSet4
            // 
            this.jwglDataSet4.DataSetName = "jwglDataSet4";
            this.jwglDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbbelongBindingSource5
            // 
            this.dbbelongBindingSource5.DataMember = "db_belong";
            this.dbbelongBindingSource5.DataSource = this.jwglDataSet4;
            // 
            // db_belongTableAdapter3
            // 
            this.db_belongTableAdapter3.ClearBeforeFill = true;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "team_id";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "team_id";
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            // 
            // depertment_id
            // 
            this.depertment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depertment_id.DataPropertyName = "depertment_id";
            this.depertment_id.HeaderText = "depertment_id";
            this.depertment_id.Name = "depertment_id";
            // 
            // depertment_name
            // 
            this.depertment_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depertment_name.DataPropertyName = "depertment_name";
            this.depertment_name.HeaderText = "depertment_name";
            this.depertment_name.Name = "depertment_name";
            // 
            // athleteidDataGridViewTextBoxColumn
            // 
            this.athleteidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.athleteidDataGridViewTextBoxColumn.DataPropertyName = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.HeaderText = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.Name = "athleteidDataGridViewTextBoxColumn";
            // 
            // Form_duiyuanguishu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_duiyuanguishu";
            this.Text = "Form_duiyuanguishu";
            this.Load += new System.EventHandler(this.Form_duiyuanguishu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbelongBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbbelongBindingSource;
        private jwglDataSet1TableAdapters.db_belongTableAdapter db_belongTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbbelongBindingSource1;
        private jwglDataSet2TableAdapters.db_belongTableAdapter db_belongTableAdapter1;
        private System.Windows.Forms.BindingSource dbbelongBindingSource2;
        private System.Windows.Forms.BindingSource dbbelongBindingSource3;
        private jwglDataSet3 jwglDataSet3;
        private System.Windows.Forms.BindingSource dbbelongBindingSource4;
        private jwglDataSet3TableAdapters.db_belongTableAdapter db_belongTableAdapter2;
        private jwglDataSet4 jwglDataSet4;
        private System.Windows.Forms.BindingSource dbbelongBindingSource5;
        private jwglDataSet4TableAdapters.db_belongTableAdapter db_belongTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depertment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn depertment_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteidDataGridViewTextBoxColumn;
    }
}