using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;//是选择运算符号的下拉表变量
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Operation opr = new Operation();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //验证
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("操作数1不能为空");
                this.textBox1.Focus();
                return;

            } if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("操作数1不能为空");
                this.textBox1.Focus();
                return;
            }
            //设置符号
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               //MessageBox.Show(comboBox1.SelectedItem.ToString());
                switch (this.comboBox1.SelectedItem.ToString().Trim())
                {
                        
                    case "+":
                        {
                            jia ja = new jia();
                            ja.NumberA = Convert.ToDouble(textBox1.Text);
                            ja.NumberB = Convert.ToDouble(textBox2.Text);
                            textBox3.Text = ja.GetResult().ToString();
                            break;
                        }
                    case "-":
                        {
                            opr = new jian();
                            opr.NumberA = Convert.ToDouble(textBox1.Text);
                            opr.NumberB = Convert.ToDouble(textBox2.Text);
                            textBox3.Text = opr.GetResult().ToString();
                            break;

                        }
                    case "*":
                        {

                            opr = new cheng();
                            opr.NumberA = Convert.ToDouble(textBox1.Text);
                            opr.NumberB = Convert.ToDouble(textBox2.Text);
                            textBox3.Text = opr.GetResult().ToString();
                            break;
                        }
                    case "/":
                        {
                            opr = new chu();
                            opr.NumberA = Convert.ToDouble(textBox1.Text);
                            opr.NumberB = Convert.ToDouble(textBox2.Text);
                            textBox3.Text = opr.GetResult().ToString();
                            break;
                        }
                        //设置参与计算器的数据
                        opr.NumberA = double.Parse(this.textBox1.Text.Trim());
                        opr.NumberB = double.Parse(this.textBox2.Text.Trim());
                        //计算
                        this.label1.Text = opr.GetResult().ToString();

                        this.label1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！");

            }
            finally
            {

            }
        }

     
    }
}
