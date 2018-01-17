using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多态实现乐器弹奏
{
    public class Instrument
    {
        public Instrument() { }

        public Instrument(string id, string name, int age, Gender gender, int popularity)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.gender = gender;
            this.Popularity=popularity;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public int Popularity { get; set; }


        public virtual void Play()
        {
            //MessageBox.Show("乐器在演奏", "信息!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
    }
}