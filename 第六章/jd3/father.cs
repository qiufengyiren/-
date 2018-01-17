using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
   public  class father
    {
       public father(string name, string cloor)
       {
           this.name = name;
           this.cloor = cloor;
       }
        public string name { get; set; }
        public string cloor { get; set; }
        public virtual string Bark()
        {
            string a = null;
            return a;
        }
    }
}
