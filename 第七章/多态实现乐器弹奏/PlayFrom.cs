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
    public partial class PlayFrom : Form
    {
        public PlayFrom()
        {
            InitializeComponent();
        }

        private void PlayFrom_Load(object sender, EventArgs e)
        {

        }
        public string Title
        {
            set
            {
                this.groupBox1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SE engineer = new SE();
            Instrument instrument = null;
            //设置选中的乐器
            if(this.radioButton1.Checked)
            {
                instrument = new Piano();
                groupBox1.Text = Name;
                MessageBox.Show("钢琴在演奏！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                

            }
            else if (this.radioButton2.Checked)
            {
                instrument = new Violin();
                groupBox1.Text = Name;
                MessageBox.Show("小提琴在演奏！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (this.radioButton3.Checked)
            {
                instrument = new Sachs();
                groupBox1.Text = Name;
                MessageBox.Show("萨克斯在演奏！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            engineer.Play();
        }
    }
}
