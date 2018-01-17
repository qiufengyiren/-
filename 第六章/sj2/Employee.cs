using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    public class Employee
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string  Name { get; set; }
        public Gender gender { get; set; }
        public string WorkList { get; set; }
        public List<Job> WorkList1 { get; set; }
        //Employee类的构造函数
        public Employee() { }

        public Employee(int id, int age, string name, Gender gender, List<Job> list)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.gender = gender;
            this.WorkList1 = list;
        }
        public virtual string SayHi()
        {

            return "hhh";
        }
    }
}
