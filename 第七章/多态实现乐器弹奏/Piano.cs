using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多态实现乐器弹奏
{
    public class Piano:Instrument
    {
        public virtual void Play()
        {
            //MessageBox.Show("钢琴在演奏", "信息!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
