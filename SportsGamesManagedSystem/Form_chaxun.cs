using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学校运动会管理系统
{
    public partial class Form_chaxun : Form
    {
        public Form_chaxun()
        {
            InitializeComponent();
        }

        private void Form_chaxun_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jwglDataSet3.db_jGame”中。您可以根据需要移动或删除它。
            this.db_jGameTableAdapter1.Fill(this.jwglDataSet3.db_jGame);
            // TODO:  这行代码将数据加载到表“jwglDataSet2.db_jGame”中。您可以根据需要移动或删除它。
            this.db_jGameTableAdapter.Fill(this.jwglDataSet2.db_jGame);
            // TODO:  这行代码将数据加载到表“jwglDataSet2.db_tGame”中。您可以根据需要移动或删除它。
            this.db_tGameTableAdapter.Fill(this.jwglDataSet2.db_tGame);
            // TODO:  这行代码将数据加载到表“jwglDataSet2.db_femaleTeam”中。您可以根据需要移动或删除它。
            this.db_femaleTeamTableAdapter.Fill(this.jwglDataSet2.db_femaleTeam);
            // TODO:  这行代码将数据加载到表“jwglDataSet2.db_maleTeam”中。您可以根据需要移动或删除它。
            this.db_maleTeamTableAdapter.Fill(this.jwglDataSet2.db_maleTeam);
            // TODO:  这行代码将数据加载到表“jwglDataSet1.db_department”中。您可以根据需要移动或删除它。
            this.db_departmentTableAdapter.Fill(this.jwglDataSet1.db_department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "bumenchaxun";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@id", SqlDbType.Char, 5);
            comm.Parameters["@id"].Value = comboBox1.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_department");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sqlStr = "select department_name from db_department where department_id ='" + comboBox1.Text + "'";
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            label4.Text = "课题：" + dr[0].ToString() + "\n";
            //int c =(int) dataGridView1.Rows[0].Cells[4].Value;
            int nanzongfen = 0;
            int nvzongfen = 0;
            for(int x=0;x<dataGridView1.Rows.Count-1;x++)
            {
                if (dataGridView1.Rows[x].Cells[1].Value.Equals("男"))
                {
                    nanzongfen = nanzongfen + (int)dataGridView1.Rows[x].Cells[5].Value;
                }
                if(dataGridView1.Rows[x].Cells[1].Value.Equals("女"))
                {
                    nvzongfen = nvzongfen + (int)dataGridView1.Rows[x].Cells[5].Value;
                }
                
            }
            label4.Text += "男队：" + nanzongfen.ToString()+"     女队："+nvzongfen.ToString()+"    合计："+(nanzongfen+nvzongfen).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlStr = "duiwuchaxun";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@id", SqlDbType.Char, 6);
            comm.Parameters["@id"].Value = comboBox2.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_maleTeam");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sqlStr = "select depertment_name from db_belong where team_id ='" + comboBox2.Text + "'";
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            label4.Text = "课题：" + dr[0].ToString() + "代表队（男队：";
            int zongfen = 0;
            for (int x = 0; x < dataGridView1.Rows.Count - 1; x++)
            {
                zongfen=zongfen+(int)dataGridView1.Rows[x].Cells[5].Value;
            }
            label4.Text += zongfen.ToString() + "分)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlStr = "duiwuchaxun";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@id", SqlDbType.Char, 6);
            comm.Parameters["@id"].Value = comboBox4.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_femaleTeam");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sqlStr = "select depertment_name from db_belong where team_id ='" + comboBox4.Text + "'";
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            label4.Text = "课题：" + dr[0].ToString() + "代表队（女队：";
            int zongfen = 0;
            for (int x = 0; x < dataGridView1.Rows.Count - 1; x++)
            {
                zongfen = zongfen + (int)dataGridView1.Rows[x].Cells[5].Value;
            }
            label4.Text += zongfen.ToString() + "分)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlStr = "xiangmuchaxun1";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@name", SqlDbType.VarChar,20);
            comm.Parameters["@name"].Value = comboBox3.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label4.Text ="    "+comboBox3.Text + " 成绩";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlStr = "xiangmuchaxun1";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@name", SqlDbType.VarChar, 20);
            comm.Parameters["@name"].Value = comboBox5.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label4.Text = "    " + comboBox5.Text + " 成绩";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlStr = "xiangmuchaxun2";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@name", SqlDbType.VarChar, 20);
            comm.Parameters["@name"].Value = comboBox6.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_femaleTeam");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label4.Text = "    " + comboBox6.Text + " 成绩";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sqlStr = "xiangmuchaxun2";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.Add("@name", SqlDbType.VarChar, 20);
            comm.Parameters["@name"].Value = comboBox7.Text;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_femaleTeam");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label4.Text = "    " + comboBox7.Text + " 成绩";
        }   
    }
}
