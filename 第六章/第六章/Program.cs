using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    class Program
    {
        static void Main(string[] args)
        {
             //父类对象
        Vehicle v = new Vehicle("中国111","北京现代");
       v.VehicleRun();//父类方法
            

       //子类对象
        Truck t=new Truck("中国","北京现代");
        t.TruckRun();//子类方法
       t.VehicleRun();//父类方法


       SmallTruck s = new SmallTruck();
       s.SmallTruckRun();//孙子方法
       //子类方法
       s.VehicleRun();//父类方法

        Console.ReadLine();
        
        }
    }
}
