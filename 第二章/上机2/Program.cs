using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机2
{
    class Program
    {
        static void Main(string[] args)
        {
      Computer [] com =new Computer[3];
      com[0] = new Computer();
      com[0].Number = "hpCQ-217Tx";
      com[0].time = "2017-08-01";

      com[1] = new Computer();
      com[1].Number = "erewf-217Tx";
      com[1].time = "2017-08-01";

      com[2] = new Computer();
      com[2].Number = "qefwv-217Tx";
      com[2].time = "2017-08-01";
      Console.WriteLine("*******计算机ID前******");
      Console.WriteLine("\n计算机ID    计算机型号    购买时间");
             for(int i=0;i<com.Length;i++){

                 Console.WriteLine(com[i].Number + "\t" + com[i].ID + "\t" + com[i].time);
             }
             Computer[] con = new Computer[4];
             con[0] = new Computer();
             con[0].Number = "hpCQ-217Tx";
             con[0].ID = "hpCQ-217Tx-1234";
             con[0].time = "2017-08-01";

             con[1] = new Computer();
             con[1].Number = "erewf-217Tx";
             con[1].ID = "erewf-217Tx-12354";
             con[1].time = "2017-08-01";

             con[2] = new Computer();
             con[2].Number = "qefwv-217Tx";
             con[2].ID = "qefwv-217Tx-12334";
             con[2].time = "2017-08-01";
 
             Console.WriteLine("*******计算机ID后******");
             Console.WriteLine("\n计算机ID            计算机型号         购买时间");
             for (int i = 0; i < com.Length; i++)
             {

                 Console.WriteLine(con[i].Number + "\t" + con[i].ID + "\t" + con[i].time);
             }
            Console.ReadLine();

        }
    }
}
