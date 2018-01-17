using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机2
{
    class Computer
    {
        public string  ID;
        public string Number;
        public string time;

        public void show(Computer[] s)
        {
            Console.WriteLine("******计算机ID前******");
            Console.WriteLine("计算机型号" + "\t" + "计算机ID" + "\t" + "日期");
            foreach (Computer con in s)
            {
                Console.Write(con.Number + "\t");
                Console.Write(this.ID + "\t " + "\t");
                Console.WriteLine(con.time + "\t");

            }
            Console.WriteLine("******计算机ID后******");
            Console.WriteLine("计算机型号" + "\t" + "计算机ID" + "\t" + "日期");
            foreach (Computer con in s)
            {
                Console.Write(con.Number + "\t");
                Console.Write(con.ID + "\t");
                Console.WriteLine(con.time + "\t");


            }
        }
    }
}