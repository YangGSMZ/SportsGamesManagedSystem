namespace 学校运动会管理系统
{
    partial class Form_chaxun
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbdepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet1 = new 学校运动会管理系统.jwglDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dbfemaleTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jwglDataSet2 = new 学校运动会管理系统.jwglDataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dbmaleTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dbjGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dbtGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_departmentTableAdapter = new 学校运动会管理系统.jwglDataSet1TableAdapters.db_departmentTableAdapter();
            this.db_maleTeamTableAdapter = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_maleTeamTableAdapter();
            this.db_femaleTeamTableAdapter = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_femaleTeamTableAdapter();
            this.db_tGameTableAdapter = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_tGameTableAdapter();
            this.db_jGameTableAdapter = new 学校运动会管理系统.jwglDataSet2TableAdapters.db_jGameTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dbjGameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.dbtGameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jwglDataSet3 = new 学校运动会管理系统.jwglDataSet3();
            this.dbjGameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_jGameTableAdapter1 = new 学校运动会管理系统.jwglDataSet3TableAdapters.db_jGameTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmaleTeamBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "部门";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dbdepartmentBindingSource;
            this.comboBox1.DisplayMember = "department_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // dbdepartmentBindingSource
            // 
            this.dbdepartmentBindingSource.DataMember = "db_department";
            this.dbdepartmentBindingSource.DataSource = this.jwglDataSet1;
            // 
            // jwglDataSet1
            // 
            this.jwglDataSet1.DataSetName = "jwglDataSet1";
            this.jwglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动队查询";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.dbfemaleTeamBindingSource;
            this.comboBox4.DisplayMember = "femaleTeam_id";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(75, 54);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(78, 20);
            this.comboBox4.TabIndex = 4;
            // 
            // dbfemaleTeamBindingSource
            // 
            this.dbfemaleTeamBindingSource.DataMember = "db_femaleTeam";
            this.dbfemaleTeamBindingSource.DataSource = this.jwglDataSet2;
            // 
            // jwglDataSet2
            // 
            this.jwglDataSet2.DataSetName = "jwglDataSet2";
            this.jwglDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "女队";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dbmaleTeamBindingSource;
            this.comboBox2.DisplayMember = "maleTeam_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // dbmaleTeamBindingSource
            // 
            this.dbmaleTeamBindingSource.DataMember = "db_maleTeam";
            this.dbmaleTeamBindingSource.DataSource = this.jwglDataSet2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "男队";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(467, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "男子项目查询";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.dbjGameBindingSource2;
            this.comboBox5.DisplayMember = "jGame_name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(47, 51);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(76, 20);
            this.comboBox5.TabIndex = 4;
            // 
            // dbjGameBindingSource
            // 
            this.dbjGameBindingSource.DataMember = "db_jGame";
            this.dbjGameBindingSource.DataSource = this.jwglDataSet2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "径赛";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.dbtGameBindingSource;
            this.comboBox3.DisplayMember = "tGame_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(47, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(76, 20);
            this.comboBox3.TabIndex = 1;
            // 
            // dbtGameBindingSource
            // 
            this.dbtGameBindingSource.DataMember = "db_tGame";
            this.dbtGameBindingSource.DataSource = this.jwglDataSet2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "田赛";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(13, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(888, 237);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(871, 43);
            this.label4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(869, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_departmentTableAdapter
            // 
            this.db_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // db_maleTeamTableAdapter
            // 
            this.db_maleTeamTableAdapter.ClearBeforeFill = true;
            // 
            // db_femaleTeamTableAdapter
            // 
            this.db_femaleTeamTableAdapter.ClearBeforeFill = true;
            // 
            // db_tGameTableAdapter
            // 
            this.db_tGameTableAdapter.ClearBeforeFill = true;
            // 
            // db_jGameTableAdapter
            // 
            this.db_jGameTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.comboBox7);
            this.groupBox5.Controls.Add(this.comboBox6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(692, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 89);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "女子项目查询";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(137, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "查询";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(137, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.dbjGameBindingSource1;
            this.comboBox7.DisplayMember = "jGame_name";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(49, 57);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(81, 20);
            this.comboBox7.TabIndex = 3;
            // 
            // dbjGameBindingSource1
            // 
            this.dbjGameBindingSource1.DataMember = "db_jGame";
            this.dbjGameBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.dbtGameBindingSource1;
            this.comboBox6.DisplayMember = "tGame_name";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(49, 27);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(81, 20);
            this.comboBox6.TabIndex = 2;
            // 
            // dbtGameBindingSource1
            // 
            this.dbtGameBindingSource1.DataMember = "db_tGame";
            this.dbtGameBindingSource1.DataSource = this.jwglDataSet2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(10, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "径赛";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "田赛";
            // 
            // jwglDataSet3
            // 
            this.jwglDataSet3.DataSetName = "jwglDataSet3";
            this.jwglDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbjGameBindingSource2
            // 
            this.dbjGameBindingSource2.DataMember = "db_jGame";
            this.dbjGameBindingSource2.DataSource = this.jwglDataSet3;
            // 
            // db_jGameTableAdapter1
            // 
            this.db_jGameTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_chaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 382);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_chaxun";
            this.Text = "Form_chaxun";
            this.Load += new System.EventHandler(this.Form_chaxun_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbdepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbfemaleTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmaleTeamBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtGameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jwglDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjGameBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private jwglDataSet1 jwglDataSet1;
        private System.Windows.Forms.BindingSource dbdepartmentBindingSource;
        private jwglDataSet1TableAdapters.db_departmentTableAdapter db_departmentTableAdapter;
        private jwglDataSet2 jwglDataSet2;
        private System.Windows.Forms.BindingSource dbmaleTeamBindingSource;
        private jwglDataSet2TableAdapters.db_maleTeamTableAdapter db_maleTeamTableAdapter;
        private System.Windows.Forms.BindingSource dbfemaleTeamBindingSource;
        private jwglDataSet2TableAdapters.db_femaleTeamTableAdapter db_femaleTeamTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dbtGameBindingSource;
        private jwglDataSet2TableAdapters.db_tGameTableAdapter db_tGameTableAdapter;
        private System.Windows.Forms.BindingSource dbjGameBindingSource;
        private jwglDataSet2TableAdapters.db_jGameTableAdapter db_jGameTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.BindingSource dbjGameBindingSource1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource dbtGameBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private jwglDataSet3 jwglDataSet3;
        private System.Windows.Forms.BindingSource dbjGameBindingSource2;
        private jwglDataSet3TableAdapters.db_jGameTableAdapter db_jGameTableAdapter1;
    }
}