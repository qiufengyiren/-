using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多态实现乐器弹奏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            init();
        }
        //格式化
        public void init() 
        {
            List<Instrument> engineers = new List<Instrument>();
            SE jack = new SE("001","王小毛",22,Gender.famale,100);
            SE joe = new SE("002", "周新宇", 23, Gender.male, 200);
            SE ema = new SE("003", "盖茨", 24, Gender.male, 300);
            engineers.Add(jack);
            engineers.Add(joe);
            engineers.Add(ema);
            //绑定DataGrideView对象
            this.dataGridView1.DataSource = engineers;


        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayFrom frm = new PlayFrom();
            DataGridViewRow dr = this.dataGridView1.CurrentRow;
            if (dr==null)
            {
                return;
            }
            string seName = dr.Cells[1].Value.ToString();
            frm.Title = seName + "开始演奏";
            frm.ShowDialog();
        }

       
    }
}
