using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationList
{
    public partial class FrmMain : Form
    {
        //用于保存所有单个套餐项目
        HealthItmes height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //allitem用于保存所有的套餐项目
        Dictionary<string, HealthItmes> allitem = new Dictionary<string, HealthItmes>();
        //定义一个套餐
        HealthSet set;
        //定义一个套餐内的套餐项目列表
        Dictionary<string, HealthItmes> item = new Dictionary<string, HealthItmes>();
        //定义一个套餐的集合
        Dictionary<string, HealthSet> allset = new Dictionary<string, HealthSet>();
        public FrmMain()
        {
            InitializeComponent();
        }

        //用于初始化所有套餐项
        public void Init()
        {
            height = new HealthItmes("身高", 5, "用于检查身高.");
            weight = new HealthItmes("体重", 5, "用于检查体重.");
            sight = new HealthItmes("视力", 10, "用于检查视力.");
            hearing = new HealthItmes("听力", 10, "用于检查听力.");
            liverFun = new HealthItmes("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthItmes("B超", 30, "用于检查B超.");
            ekg = new HealthItmes("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthItmes("血压", 20, "用于检查血压.");
            bloodTest = new HealthItmes("血常规", 20, "用于检查血常规.");
            allitem.Add(height.Name,height);
            allitem.Add(weight.Name, weight);
            allitem.Add(sight.Name, sight);
            allitem.Add(hearing.Name, hearing);
            allitem.Add(liverFun.Name, liverFun);
            allitem.Add(bWaves.Name, bWaves);
            allitem.Add(ekg.Name, ekg);
            allitem.Add(bloodPressure.Name, bloodPressure);
            allitem.Add(bloodTest.Name, bloodTest);
        }

        //初始化一个套餐
        public void InitHealth()
        {
            item.Add(height.Name,height);
            item.Add(weight.Name, weight);
            item.Add(sight.Name, sight);
            set = new HealthSet("入学体检",item);
            set.SumPirce();
            allset.Add("入学体检",set);
        }
        //将初始化套餐信息绑定到下拉框当中
        public void InitSet()
        {
            this.cboSets.Items.Clear();
            this.cboSets.Items.Add("请选择");
            foreach(string item in allset.Keys)
            {
                this.cboSets.Items.Add(item);
            }
            this.cboSets.SelectedIndex = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblSetName.Text = "";
            this.lblSetPrice.Text = "";
            Init();
            InitHealth();
            InitSet();
        }
        public void UpdateSet(HealthSet set)
        {
            this.dgvHealthList.DataSource = new BindingList<HealthItmes>(set.Items.Values.ToList());
        }
        private void cboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.cboSets.Text;
            if (name == "请选择")
            {
                this.dgvHealthList.DataSource = new BindingList<HealthItmes>();
                this.lblSetName.Text = "";
                this.lblSetPrice.Text = "";
                return;
            }
            this.lblSetName.Text = name;
            this.lblSetPrice.Text = allset[name].Price.ToString();
            UpdateSet(allset[name]);    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.cboItems.SelectedIndex == 0)
            {
                MessageBox.Show("请选择套餐项");
                return;
            }
            string name=this.cboSets.Text;
            if(name=="请选择")
            {
                MessageBox.Show("请选择套餐");
                return;
            }
            if (!allset[name].Items.Keys.ToList().Contains(this.cboItems.Text))
            {
                allset[name].Items.Add(this.cboItems.Text, allitem[this.cboItems.Text]);
                allset[name].SumPirce();
                this.lblSetName.Text = name;
                this.lblSetPrice.Text = allset[name].Price.ToString();
                UpdateSet(allset[name]);    
            }
            else
            {
                MessageBox.Show("该项已经存在！");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtHealthName.Text.Trim() != null && this.txtHealthName.Text.Trim() != "")
            {
                HealthSet set=new HealthSet();
                allset.Add(this.txtHealthName.Text.Trim(), set);
                InitSet();
              
                this.cboSets.SelectedIndex = allset.Count;
            }
            else
            {
                MessageBox.Show("请输入添加的套餐名称");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = this.dgvHealthList.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(name);
            string healthname = this.cboSets.Text;
            MessageBox.Show(healthname);
            allset[healthname].Items.Remove(name);
            UpdateSet(allset[healthname]);
            allset[healthname].SumPirce();
            this.lblSetPrice.Text = allset[healthname].Price.ToString();
        }
    }
}
