using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class lms : Form
    {
        public lms()
        {
            InitializeComponent();
        }

        private void tsjs_Click(object sender, EventArgs e)
        {
            js gh = new js();
            gh.ShowDialog();
        }

        private void tshs_Click(object sender, EventArgs e)
        {
            hs gh = new hs();
            gh.ShowDialog();
        }

        private void tsgy_Click(object sender, EventArgs e)
        {
            gy sd = new gy();
            sd.ShowDialog();
            this.Hide();
        }

        private void tszjdz_Click(object sender, EventArgs e)
        {
            addread sd = new addread();
            sd.ShowDialog();
        }

        private void tsxsrk_Click(object sender, EventArgs e)
        {
            tjts gh = new tjts();
            gh.ShowDialog();
        }

        private void tssbxg_Click(object sender, EventArgs e)
        {
            sbxg gh = new sbxg();
            gh.ShowDialog();
        }

        private void tsjstt_Click(object sender, EventArgs e)
        {
            jstt gh = new jstt();
            gh.ShowDialog();
        }

        private void tsxgdzxx_Click(object sender, EventArgs e)
        {
            xgyhxx gh = new xgyhxx();
            gh.ShowDialog();
        }

        private void tscxdzjylb_Click(object sender, EventArgs e)
        {
            dzjylb gh = new dzjylb();
            gh.ShowDialog();
        }

        private void tsdzjypm_Click(object sender, EventArgs e)
        {
            dzjylb gh = new dzjylb();
            gh.ShowDialog();
        }
    }
}
