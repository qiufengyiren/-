using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
   public  class Cat:father
    {
        public Cat(string name, string cloao):base(name,cloao)
        { 
       
        }
        public  override string Bark()
        {
            string message = string.Format("我是{0},猫{1},喵喵",this.cloor,this.name);
            
            return message;
           
        }
    }
}
