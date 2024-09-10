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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            stringVector2.Add("micontra1111");
            stringVector2.Add("estaesmia");
            stringVector2.Add("tiendainglesaesmejor");
            stringVector2.Add("profemeponesun12");
            stringVector.Add("Eriksil");
            stringVector.Add("Maikarobe");
            stringVector.Add("Tingles");
            stringVector.Add("juanito");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        public int temp;
        public string temp2;
        public string temp3;
        public List<string> stringVector = new List<string>();
        public List<string> stringVector2 = new List<string>();
        

        private void button1_Click(object sender, EventArgs e)
        {

            temp2 = textBox1.Text;
            temp3 = textBox2.Text;

            if (string.IsNullOrWhiteSpace(temp2) || string.IsNullOrWhiteSpace(temp3))
            {  
                MessageBox.Show("Los dos campos deben tener algo adentro");
            }

            else
            {
                ListViewItem item = new ListViewItem(temp2);
                listView1.Items.Add(item);
                stringVector.Add(temp2);
                stringVector2.Add(temp3);
                MessageBox.Show($"Se añadió usuario con nombre {temp3} y contraseña {temp2}");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                temp = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(temp);
                stringVector.RemoveAt(temp);
                stringVector2.RemoveAt(temp);
                MessageBox.Show("Removido.");

            }
            else MessageBox.Show("No item selected / Ningún objeto seleccionado");
        }

     }
 }
