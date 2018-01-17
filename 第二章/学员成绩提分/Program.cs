using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学员成绩提分
{
    class Program
    {
        static void Main(string[] args)
        
        { 
            int [] score =new int[3];//原分数
           score [0]=55;
            score[1]=60;
            score[2]=63;
            int  [] newSocre =new int[3];//新分数
            Console.Write("原分数：");
            for (int i = 0; i < score.Length;i++ )
            {
                Console.Write(score[i]);
            }
            //数组复制
            Console.Write("\n"+"新分数：");
            for (int i = 0; i < score.Length; i++)
            {
               newSocre[i] =score[i];
               newSocre[i] = newSocre[i] + 5;
               Console.Write(newSocre[i]);
            }
            Console.ReadLine();
        }
    }
}
