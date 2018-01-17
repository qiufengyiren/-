using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订餐系统1
{
    public class Chef
    {
        private Order order;
        //获得传菜
            public void GetOrder(Order order)
            {
                this.order = order;
            }
        //厨师做菜
            public void Cook()
            {
                Console.WriteLine("厨师烹饪:{0}",order.mealList);
                Console.WriteLine("制作完毕");
            }
        //提醒饭菜制作完毕
            public void Sendalert(Waitress waitress)
            {
                Console.WriteLine("厨师提示服务员取菜！");
                waitress.GetOrder(order);
            }
    }
}
