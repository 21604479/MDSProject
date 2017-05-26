using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSProject
{
    public partial class RegisterConsultationDetails : Form
    {
        public RegisterConsultationDetails()
        {
            InitializeComponent();
            listBox1.Items.Add("Joana Paião");
            listBox1.Items.Add("Tiago Foncseca");
            listBox1.Items.Add("Vasco Leal");
            listBox1.Items.Add("Walter Klit");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string myString = textBox1.Text;
            int index = listBox1.FindString(myString, -1);
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
                MessageBox.Show("Found the item \"" + myString + "\" at index: " + index);
            }
            else
                MessageBox.Show("Item not found.");
        }
    }
}
