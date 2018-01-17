using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM取款机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //集合Dictionary<string,Card>dic =null;
        Dictionary<string, BankCard> dic = new Dictionary<string, BankCard>();
        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
            InitDictory();
        }
        public void InitData()
        {
            label11.Text = "";
            label9.Text = "";
            label10.Text = "";

            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;

            textBox1.Focus();
        }
        private void InitDictory()
        {
            LocalCard localCard = new LocalCard("11111", "1234", 10000, "秋风伊人");
            OtherCard otherCard = new OtherCard("22222", "1234", 100000, "傻逼");

            dic.Add(localCard.ID, localCard);
            dic.Add(otherCard.ID, otherCard);
        }
        //插卡操作
        private void button4_Click(object sender, EventArgs e)
        {
            //判空 null
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("请输入卡号");
                return;
            } if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("请输入密码");
                return;
            }
            string userCardNo = textBox7.Text.Trim();
            bool flag = dic.ContainsKey(userCardNo);
            if (flag)
            {

                string password = textBox6.Text;
                BankCard bankCard = dic[userCardNo];
                if (password.Equals(bankCard.Password))
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    if (bankCard is LocalCard)
                    {
                        //是本地卡，解锁本地按钮
                        button3.Enabled = true;
                    }
                    //赋值操作
                    label10.Text = userCardNo;
                    label11.Text = bankCard.Name;

                }
                else
                {
                    //密码不正确
                    MessageBox.Show("密码输入不正确，请重新输入");
                }

            }
            else 
            {
                //没有该卡
                MessageBox.Show("没有此卡");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = dic[textBox7.Text].levelMoney.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            label9.Text = Convert.ToString(dic[textBox7.Text].Bank(a));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox3.Text);
            dic[textBox7.Text].levelMoney -= b;
            label9.Text = dic[textBox7.Text].levelMoney.ToString();
            dic[textBox2.Text].levelMoney += b;
            //dic[textBox1.Text].levelMoney-=textBox4

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.label11.Text = "";
            this.label9.Text = "";
            this.label10.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
       
       
        }
       
        
       
    
}
