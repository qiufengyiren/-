using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //员工集合
        List<Employee> empls = new List<Employee>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            SE structc = new SE();
            structc.Name = "有病吧你";
            structc.Age = 25;
            structc.ID= 0001;
            structc.popularity =100;
            PM p = new PM();
            p.Name = "真的是有病";
            p.ID= 1;
            p.gender = Gender.famale;
            p.Age = 34;
            p._yearOfExperience= 11;
            
            empls.Add(p);
            empls.Add(structc);
            foreach (Employee item in empls)
            {
                MessageBox.Show(item.SayHi());
            }
        }
    }
}
