using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    public class Vehicle
    {
        public Vehicle() { }
        //带参构造函数
        public Vehicle(string place, string type)
        {
            this.Place = place;
            this.Type = type;
        }
        //属性
        public string Place { get; set; }
        public string Type { get; set; }

        public void VehicleRun()
        {
            Console.WriteLine("{0},{1}汽车在奔跑", this.Type, this.Place);
        }
    }
}
