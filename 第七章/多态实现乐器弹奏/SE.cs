using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态实现乐器弹奏
{
    public class SE:Instrument
    {
        public SE() { }
        public SE(string id, string name, int age, Gender gender, int popularity) :base(id,name,age,gender,popularity)
        { }
        
    }
}
