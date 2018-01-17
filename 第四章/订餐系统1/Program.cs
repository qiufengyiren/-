using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订餐系统1
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化客户，服务员，厨师
            Client wang = new Client();
            Waitress waitress = new Waitress();
            Waitress zhang = new Waitress();
            Chef chef = new Chef();

            //初始化菜单
            Order order = new Order();

            //设置订了改菜单的客户            
            order.customer = wang;
            order.id = 100;
            order.mealList = "水煮鱼";

            //顾客wang选中的waitress服务员给自己服务
            wang.Order(waitress,order);

            //服务员将菜单信息告知厨师chef
            waitress.SendOrder(chef);

            //厨师根据菜单做菜
            chef.Cook();
            chef.Sendalert(waitress);
            waitress.TransCook();
            Console.Read();
        }
    }
}
