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
    public partial class Form_nvdui : Form
    {
        public Form_nvdui()
        {
            InitializeComponent();
        }
        string sqlStr = "addfemaleTeam";
        string connection = @"server=PC-20160528TLMD\SQLEXPRESS;database=jwgl;Integrated Security=true";
        SqlDataAdapter sda;
        SqlCommand comm;
        SqlConnection conn;
        DataSet ds;
        private void Form_nvdui_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jwglDataSet2.db_femaleTeam”中。您可以根据需要移动或删除它。
            this.db_femaleTeamTableAdapter1.Fill(this.jwglDataSet2.db_femaleTeam);
            // TODO:  这行代码将数据加载到表“jwglDataSet1.db_femaleTeam”中。您可以根据需要移动或删除它。
            this.db_femaleTeamTableAdapter.Fill(this.jwglDataSet1.db_femaleTeam);
            comm = new SqlCommand();
            conn = new SqlConnection(connection);
            comm.CommandText = sqlStr;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Connection.Open();
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds, "db_femaleTeam");
            this.bindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = this.bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(ds.Tables[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(ds.Tables[0]);
        }
    }
}
