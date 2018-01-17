using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 员工执行工作列表
{
    public partial class FrmCodeExe : Form
    {
        CodeJob job;
        public FrmCodeExe(CodeJob cj)
        {
            InitializeComponent();
            this.job = cj;
        }

        private void FrmCodeExe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //测试提交
        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                job.CodeingLines = Convert.ToInt32(textBox1.Text.Trim());//编码行数
                job.Bugs = Convert.ToInt32(textBox2.Text.Trim());//遗留问题
                job.WorkDay = Convert.ToInt32(textBox3.Text.Trim());//所需天数
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                isError = true;
            }
            if (!isError)
            {
                MessageBox.Show("提交成功");
                this.Close();
            }
        }
        
    }
}
