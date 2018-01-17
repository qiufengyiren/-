using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订餐系统1
{
    //顾客类
    public class Client
    {
        //点菜
        public void Order(Waitress waitress, Order order)
        {
            Console.WriteLine("顾客开始点菜：{0}！",order.mealList);
            waitress.GetOrder(order);
        }
        //用餐
        public void Eat() 
        {
            Console.WriteLine("客人用餐");
        }
    }
}
