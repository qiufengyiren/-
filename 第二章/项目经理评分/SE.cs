using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 项目经理评分
{
       public class SE
    {
           //工号
       private  string   _Number;

       public string Number
{
  get { return _Number; }
  set { _Number = value; }
}
           //年龄
        private int  _age;

public int Age
{
  get { return _age; }
  set { _age = value; }
}
           //姓名
        private string _Name;

public string Name
{
  get { return _Name; }
  set { _Name = value; }
}
           //性别
        private char _Sex;

public char Sex
{
  get { return _Sex; }
  set { _Sex = value; }
}
       
         //项目经理年度评分
private string _pingfen;

public string Pingfen
{
    get { return _pingfen; }
    set { _pingfen = value; }
}
           //经理评分
private int _pingfen1;

public int Pingfen1
{
    get { return _pingfen1; }
    set { _pingfen1 = value; }
}   
           

    }
}
