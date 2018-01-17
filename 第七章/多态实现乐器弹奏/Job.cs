using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态实现乐器弹奏
{
    public abstract class Job
    {
        //无参构造方法
        public Job() { }
        //带参构造方法
        public Job(string name, string desc, string type)
        {
            this.Name = name;
            this.Description = desc;
            this.Type = type;
        }
        //属性
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        //执行工作
        public abstract void Execute();
        //显示工作列表
        public abstract string Show();
    }
}
