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
    public partial class Form4 : Form
    {

        Random random = new Random();
        bool gameOver = false;
        string trafienie;
        int proba = 0;
        int czas = 5;
        List<PictureBox> zdj = new List<PictureBox>();
        PictureBox A;

        List<string> icons = new List<string>()
        {
            "W",
            "X","X","X","X",
            "X","X","X","X","X",
            "X","X","X","X","X",
            "X","X","X","X","X",
        };


        public Form4()
        {
            InitializeComponent();
            LoadPicture();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czas > 0)
            {
                czas--;
                label1.Text = czas.ToString();
            }
            else
            {
                timer1.Stop();
                GameOver();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (gameOver)
                return;

            int randomNumber = random.Next(icons.Count);
            trafienie = icons[randomNumber];
            icons.RemoveAt(randomNumber);

            A.Image = Image.FromFile("obraz" + trafienie + ".png");
            if (trafienie == "X")
            {
                gameOver = true;
                MessageBox.Show("Wygrałeś!");
                GameOver();
            }
            else
            {
                proba++;
                if (proba == 5)
                {
                    gameOver = true;
                    MessageBox.Show("Przegrałeś!");
                    GameOver();
                }
            }
        }

        private void LoadPicture()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is PictureBox)
                {
                    zdj.Add((PictureBox)tableLayoutPanel1.Controls[i]);
                    zdj[i].Click += new EventHandler(Checkobrazek);
                }
            }
        }

        private void Checkobrazek(object sender, EventArgs e)
        {
            A = (PictureBox)sender;
            tableLayoutPanel1_Paint(sender, null);
        }

        private void GameOver()
        {
            if (trafienie == "X")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();

            }
        }
    }
}
