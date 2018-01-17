using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订餐系统1
{
    public class Waitress
    {
        private Order order;
        //记录客人的点餐
        public void GetOrder(Order order) 
        {
            this.order = order;
        }
        //给厨师提交菜单
        public void SendOrder(Chef chef)
        {
            Console.WriteLine("服务员将菜单{0}传给厨师",order.mealList);
            chef.GetOrder(order);
        }
        //传菜
        public void TransCook() 
        {
            Console.WriteLine("服务员将菜{0}送给客户{1}！",order.mealList,order.id);
            order.customer.Eat();
        }
    }
}
