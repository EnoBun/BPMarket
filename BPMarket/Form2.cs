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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Eriksil")
            {
                if (textBox2.Text == "micontra1111")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else { MessageBox.Show(" Contraseña incorrecta / Incorrect password"); }
            }
            else if (textBox1.Text == "Maikarobe")
            {
                if (textBox2.Text == "estaesmia")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else { MessageBox.Show(" Contraseña incorrecta / Incorrect password"); }
            }
            else if (textBox1.Text == "Tingles")
            {
                if (textBox2.Text == "tiendainglesaesmejor")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else { MessageBox.Show(" Contraseña incorrecta / Incorrect password"); }
            }
            else if (textBox1.Text == "juanito")
            {
                if (textBox2.Text == "profemeponesun12")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else { MessageBox.Show(" Contraseña incorrecta / Incorrect password");}

            }
            else if (textBox1.Text == "admin")
            {
                MessageBox.Show("Nice try, buddy.");

            }
            else {MessageBox.Show("Contraseña o nombre de usuario incorrectos / Incorrect username or password"); }
        }

    }
}
