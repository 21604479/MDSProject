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

        //private List<DoctorDet> doctorDets;

        public RegisterDoctorForm()
        {
            InitializeComponent();
            
            if (doctorDets!=null)
            {
                refreshDoc();
            }
        }

        //public DoctorDet newDoctor;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxSSN.Text.Length == 0 || comboBoxProficiency.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the blank boxes, Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxSSN.Text.Length !=9)
            {
                MessageBox.Show("Invalid SSN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DoctorDet newDoctor = new DoctorDet();
                newDoctor.Name= textBoxName.Text;
                newDoctor.Proficiency = comboBoxProficiency.Text;
                newDoctor.Ssn= textBoxSSN.Text;
                newDoctor.CheckIn = decimal.ToInt32(numericUpDownCheckIn.Value);
                newDoctor.CheckOut= decimal.ToInt32(numericUpDownCheckOut.Value);

                doctorDets.Add(newDoctor);
            }
        }

        private void refreshDoc()
        {
            listBoxDoctors.Items.Clear();
            listBoxDoctors.Items.AddRange(doctorDets.ToArray());
        }
    }
}
