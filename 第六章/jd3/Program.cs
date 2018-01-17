using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<father> li = new List<father>();
            Cat c = new Cat("呵呵","白色");
        
            Dog d = new Dog("哈哈","黑色");
            li.Add(c);
            li.Add(d);
            foreach (father item in li)
            {
                Console.WriteLine(item.Bark());
            }
            Console.ReadLine();
        
        }
    }
}
