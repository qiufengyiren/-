using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4_1
{
    public class jian : Operation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }
}