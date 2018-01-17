using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationList
{
    //套餐项的类
    public class HealthItmes
    {
        //项目的名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //项目的价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //项目的描述
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //带参构造和无参构造
        public HealthItmes()
        {
        }
        public HealthItmes(string name, int price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }



    }
}
