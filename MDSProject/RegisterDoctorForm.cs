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
    public partial class RegisterDoctorForm : Form
    {
        public RegisterDoctorForm()
        {
            InitializeComponent();
        }

        public DoctorDet newDoctor;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            newDoctor = new DoctorDet(textBoxName.Text, comboBoxProficiency.Text, textBoxSSN.Text, decimal.ToInt32(numericUpDownCheckIn.Value), decimal.ToInt32(numericUpDownCheckOut.Value));

            listBoxDoctors.Items.Add(newDoctor);

        }
    }
}
