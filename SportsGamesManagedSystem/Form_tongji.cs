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
    public partial class Form_tongji : Form
    {
        public Form_tongji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "bumentongji";
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
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void 男队_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from dbo.bumendanduichaxun1('"+comboBox1.Text+"')";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form_tongji_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jwglDataSet3.db_department”中。您可以根据需要移动或删除它。
            this.db_departmentTableAdapter.Fill(this.jwglDataSet3.db_department);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from dbo.bumendanduichaxun2('" + comboBox1.Text + "')";
            string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
            SqlDataAdapter sda;
            SqlCommand comm;
            SqlConnection conn;
            DataSet ds;
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
