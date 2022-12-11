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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((comboBox1.SelectedItem == null && comboBox2.SelectedItem == null) || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("ERROR :( \n Brak wybranej opcji");
            }
            else
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    Form4 f4 = new Form4();
                    f4.Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
