using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多态实现乐器弹奏
{
    public class Violin : Instrument
    {
        public override void Play()
        {
            MessageBox.Show("小提琴在演奏", "信息!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
