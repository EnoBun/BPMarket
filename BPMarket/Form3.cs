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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            
        }
        public int Carttemp = 0;
        public int Cart = 0;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Carttemp = listView1.SelectedIndices[0];
                if(Carttemp == 0){ Cart += 27;}
                else if (Carttemp == 1) { Cart += 35;}
                else if (Carttemp == 2) { Cart += 50; }

                MessageBox.Show($"Added item. Current Cart value / Añadido objeto. Valor actual del carro: {Cart}");

            }
            else MessageBox.Show("No item selected / Ningún objeto seleccionado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Procesando pedido, valor del caro / Processing order, cart value: {Cart}");
            
            Cart = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool itemFound;
            string searchTerm = textBox1.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))

            {
                itemFound = false;
                MessageBox.Show("Please write a search term / Por favor ingrese su objeto a buscar.");
            }

            else { foreach (ListViewItem item in listView1.Items)
                    if(item.Text.ToLower().Contains(searchTerm.ToLower())){ item.Selected = true;
                        item.EnsureVisible();
                        itemFound = true;
                    

            if (itemFound==false) { MessageBox.Show("No item with such name found / No se encontró un objeto con este nombre."); }
                    }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
