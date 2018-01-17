using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
    public class TestJob:Job
    {
        //无参构造
        public TestJob() { }
        //带参构造
        public TestJob(string name, string desc, string type): base(name, desc, type)
        {

        }
        //测试用例个数
        public int CaseNum { get; set; }
        //发现问题数
        public int FindBugs { get; set; }
        //需要的工作日
        public int WorkDay { get; set; }

        //执行工作
        public override void Execute()
        {
            //传递当前对象
            FrmTestExe ftx = new FrmTestExe(this);
            ftx.ShowDialog();
        }
        //显示工作列表
        public override string Show()
        {
            string str = string.Format("测试用例个数：{0}\n发现的问题数：{1}\n工作日{2}", this.CaseNum, this.FindBugs, this.WorkDay);

            return str;
        }
    }
}
