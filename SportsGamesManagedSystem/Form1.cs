using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学校运动会管理系统
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Text = "学校运动会管理系统";
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_guanyu formGuanyu = new Form_guanyu();
            formGuanyu.Show();
        }

        /// <summary>
        /// Main窗体时间显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void 参赛部门录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cansaibumenluru formCanssaibumen = new Form_cansaibumenluru();
            formCanssaibumen.Show();
        }

        private void 男队ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_nandui formNandui = new Form_nandui();
            formNandui.Show();
        }

        private void 女队ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_nvdui formNvdui = new Form_nvdui();
            formNvdui.Show();
        }

        private void 运动员录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_yundongyuan formYundongyuan = new Form_yundongyuan();
            formYundongyuan.Show();
        }

        private void 田赛ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_tiansai formTiansai = new Form_tiansai();
            formTiansai.Show();
        }

        private void 径赛ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_jingsai formJingsai = new Form_jingsai();
            formJingsai.Show();
        }

        private void 运动员参赛项目录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cansai formCansai = new Form_cansai();
            formCansai.Show();
        }

        private void 队员归属录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_duiyuanguishu formDuiyuanguishu = new Form_duiyuanguishu();
            formDuiyuanguishu.Show();
        }

        private void 成绩录入ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_chengjiluru formChengjiluru = new Form_chengjiluru();
            formChengjiluru.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_chaxun formChaxun = new Form_chaxun();
            formChaxun.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_tongji formTontji = new Form_tongji();
            formTontji.Show();
        }
    }
}
