using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMarket
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BlackPearl")
            {
                if (textBox2.Text == "profemeponesun12")
                {
                    Form6 f6 = new Form6();
                    f6.Show();
                }
                else { MessageBox.Show(" Contraseña incorrecta / Incorrect password"); }

            }
            else if (textBox1.Text == "admin")
            {
                MessageBox.Show("Nice try, buddy.");

            }
            else { MessageBox.Show("Contraseña o nombre de usuario incorrectos / Incorrect username or password"); }
        }
    }
}
