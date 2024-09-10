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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BlackPearl")
            {
                if (textBox2.Text == "profemeponesun12")
                {
                    Form5 f5 = new Form5();
                    f5.Show();
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
