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
    public partial class FrmJobs : Form
    {
        public FrmJobs()
        {
            InitializeComponent();
        }
        Employee empl;
        //窗体加载事件
        private void FrmJobs_Load(object sender, EventArgs e)
        {
            Init();
            UpdateJob();
        }
        //初始化数据
        public void Init()
        {
            List<Job> listJob = new List<Job>();
            listJob.Add(new CodeJob("登录的编码", "实现登录功能", "编码"));
            listJob.Add(new CodeJob("后台的编码", "实现后台功能", "编码"));
            listJob.Add(new CodeJob("登录的测试", "实现登录功能", "测试"));
            //实例化员工对象
            empl = new SE("111", "王小毛", 20, Gender.famale, 99, listJob);


        }
        //绑定工作列表
        public void UpdateJob()
        {
            dataGridView1.DataSource = empl.WorkList;
        }

        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;//得到当前选中行的下标
            //调用执行的方法
            empl.WorkList[index].Execute();
        }

        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //得到当前选中的下标
            int index = dataGridView1.CurrentRow.Index;
            //调用显示的方法
            string str = empl.WorkList[index].Show();
            MessageBox.Show(str, "指标完成情况");
        }


    }
}
