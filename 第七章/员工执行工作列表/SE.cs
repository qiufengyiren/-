using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{

    public class SE : Employee
    {
        public SE(string id, string name, int age, Gender gender, int popularity, List<Job> list)
            : base(id, name, age, gender, list)
        {
            this.PoPularity = popularity;
        }
        public SE() { }
        //人气值
        public int PoPularity { get; set; }
        //工作
        public override string Dowork()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name + ":\n");
            for (int i = 0; i < this.WorkList.Count; i++)
            {
                sb.Append((i + 1) + "," + WorkList[i].Name + ":" + WorkList[i].Description + "\n");
            }
            return sb.ToString();
        }
    }
}
