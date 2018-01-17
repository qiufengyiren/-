using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 更新数据积分
{
    class Program
    {
        static void Main(string[] args)
        {
            int []points =new int[5];
            int[] newpoints = new int[5];
            Console.WriteLine("请输入五位会员的积分");
            for (int i = 0; i < points.Length;i++ ) {
                Console.Write("第" + (i + 1) + "位会员的积分:");
                points[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < points.Length;i++ ) {
                newpoints [i]=points[i];
                newpoints[i] = newpoints[i] + 500;
            }
            Console.WriteLine("\n序号  历史积分  新年积分");
            for (int i = 0; i < newpoints.Length;i++ ) {
               
                Console.Write((i+1)+"\t");
                Console.Write(points[i] + "\t");
                Console.WriteLine(newpoints[i]);
            }
            Console.ReadLine();
        }
    }
}
