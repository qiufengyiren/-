using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
    public class CodeJob : Job
    {
        public CodeJob() { }
        public CodeJob(string name, string desc, string type)
            : base(name, desc, type)
        {

        }
        //编码行数
        public int CodeingLines { get; set; }
        //遗留问题
        public int Bugs { get; set; }
        //工作天数
        public int WorkDay { get; set; }

        public override void Execute()
        {
            //传递当前对象
            FrmCodeExe fce = new FrmCodeExe(this);
            fce.ShowDialog();
        }
        //显示工作列表
        public override string Show()
        {
            string str = string.Format("有效的代码行数：{0}\n遗留的问题：{1}\n工作日：{2}", this.CodeingLines, this.Bugs, this.WorkDay);
            return str;
        }
    }
}
