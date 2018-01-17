using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商品打折促销
{
    class Program
    {
        private int _money;

        public int Money
        {
            get { return _money; }
            set {
                if (value > 100)
                {
                    _money = value - 50;
                }
                else {
                    _money = value;
                }
            }
        }

        static void Main(string[] args)
        {
          
          Program mo =new Program();
            Console.WriteLine("请输入金额");
            mo.Money = int.Parse(Console.ReadLine());
            Console.WriteLine("实际值："+mo.Money);
       
            Console.ReadLine();
        }
    }
}
