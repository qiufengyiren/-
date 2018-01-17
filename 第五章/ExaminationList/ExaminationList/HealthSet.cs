using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationList
{
    public class HealthSet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            
        }
        private Dictionary<string, HealthItmes> items;

        public Dictionary<string, HealthItmes> Items
        {
            get { return items; }
            set { items = value; }
        }
        public HealthSet()
        {
            items = new Dictionary<string, HealthItmes>();
        }
        public HealthSet(string name,Dictionary<string, HealthItmes> item)
        {
            this.Name = name;
            this.Items = item;
        }

        //计算套餐内所有套餐项的总价格
        public void SumPirce()
        {
            //定义一个变量，来保存总价格
            int totalprice = 0;
            //
            foreach(HealthItmes item in items.Values)
            {
                totalprice+=item.Price;
            }
            this.price = totalprice;
        }
    }
}
