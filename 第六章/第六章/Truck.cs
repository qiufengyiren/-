using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    public class Truck : Vehicle
    {
        public Truck() { }
        public Truck(string place, string type)
            : base(place, type)
        {

        }
        public void TruckRun()
        {
            Console.WriteLine("型号为{0}产地为{1}的卡车在行驶", this.Type, this.Place);
        }
    }
}
