using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目经理评分
{
    public partial class FrmJudge : Form
    {
        private SE se;
        private frmMain main;
        public FrmJudge(frmMain show, int index)
        {
            this.main = show;
            this.se = main.se[index];
            InitializeComponent();
        }

        private void FrmJudge_Load(object sender, EventArgs e)
        {
            this.txtName.Text = se.Name;
            this.txtRating.Text = se.Pingfen1.ToString();
            this.txtEvaluation.Text = se.Pingfen;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {

            PM pm = new PM();
            pm.Rating(se, this.txtEvaluation.Text.Trim(), int.Parse(this.txtRating.Text.Trim()));
            this.main.binding();
        }
    }
}
