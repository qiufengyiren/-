using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目经理评分
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
      
        public SE[] se = new SE[3];
        private void frmMain_Load(object sender, EventArgs e)
        {
            Add();
            binding();
        }
        public void Add() { 
            SE se01 = new SE();
            se01.Number = "101";
            se01.Age = 22;
            se01.Name = "王小毛";
            se01.Pingfen1 = 0;
            se01.Pingfen = "未评价";
            se[0] = se01;
            SE se02 = new SE();
            se02.Number = "102";
            se02.Age = 26;
            se02.Name = "周新雨";
            se02.Pingfen1 = 0;
            se02.Pingfen = "未评价";
            se[1] = se02;
            SE se03 = new SE();
            se03.Number = "103";
            se03.Age = 30;
            se03.Name = "张烨";
            se03.Pingfen1 = 0;
            se03.Pingfen = "未评价";
            se[2] = se03;
        }
        public void binding()
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i] != null)
                {
                    ListViewItem item = new ListViewItem(se[i].Number);
                    item.SubItems.Add(se[i].Name);
                    item.SubItems.Add(se[i].Age.ToString());
                    item.SubItems.Add(se[i].Pingfen);
                    item.SubItems.Add(se[i].Pingfen1.ToString());
                    this.listView1.Items.Add(item);
                    continue;
                }


            }
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
     
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i].Number == this.listView1.SelectedItems[0].Text)
                {
                    index = i;

                    break;
                }
            }
            FrmJudge offic = new FrmJudge(this, index);
            offic.Show();
        }
        }
    }

