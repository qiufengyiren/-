using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工执行工作列表
{
    public class Employee
    {
        public Employee() { }
        public Employee(string id, string name, int age, Gender gender, List<Job> list)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.WorkList = list;

        }
        //工号
        public string ID { get; set; }
        //年龄
        public int Age { get; set; }
        //姓名
        public string Name { get; set; }
        //性别
        public Gender Gender { get; set; }
        //工作列表
        public List<Job> WorkList { get; set; }
        public virtual string Dowork()
        {
            return "工作列表";
        }
    }
}
