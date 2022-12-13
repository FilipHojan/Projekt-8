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
    public partial class Form2 : Form
    {
        


        Random random = new Random();

        bool gameOver = false;
        string trafienie;
        int proba = 0;
        
        List<PictureBox> zdj = new List<PictureBox>();
        PictureBox A;

        List<string> icons = new List<string>()
        {
            "W",
            "X","X","X","X",
            "X","X","X","X",
        };

        public Form2()
        {
            InitializeComponent();
            LoadPicture();
        }

        int czas = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(czas > 0)
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
        
        private void LoadPicture()
        {

        }

        private void Checkobrazek(PictureBox A)
        {

        }

        private void GameOver()
        {
            Form5 f5 = new Form5();
            f5.Show();

            Form6 f6 = new Form6();
            f6.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
