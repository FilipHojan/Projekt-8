using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_1
{
    public partial class Form3 : Form
    {

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "W",
            "X","X","X",
            "X","X","X","X",
            "X","X","X","X",
            "X","X","X","X",
        };

        public Form3()
        {
            InitializeComponent();
        }

        int czas = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czas > 0)
            {
                czas = czas - 1;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
