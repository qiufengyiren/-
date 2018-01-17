using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 项目经理评分
{
    public  class PM
    {
        //ID
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        //年龄
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //性别
        private char sex;
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
         //资历
        private string _qualifications;

        public string Qualifications
        {
            get { return _qualifications; }
            set { _qualifications = value; }
        }


        //经理评分
        private int _pingfen1;

        public int Pingfen1
        {
            get { return _pingfen1; }
            set { _pingfen1 = value; }
        }

        //评分的方法
        public void Rating(SE se, string Evaluation, int Rating)
        {
            se.Pingfen = Evaluation;
            se.Pingfen1 = Rating;
        }
    }
}
