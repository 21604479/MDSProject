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
    public partial class SelectDateTimeForm : Form
    {
        HealthITDBContainer1 container;

        public Doctor NewDoctor { get; private set; }

        public decimal horas
        {
            get
            {
                return numericUpDown1.Value;
            }
        }

        public SelectDateTimeForm(string text)
        {
            InitializeComponent();

            container = new HealthITDBContainer1();

            NewAppointementForm newapp = new NewAppointementForm();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*if (numericUpDown1.Value > Doctor.CheckOut)
            {
                MessageBox.Show("The hour you picked for the appointment is superior of his check out hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numericUpDown1.Value < Doctor.CheckIn)
            {
                MessageBox.Show("The hour you picked for the appointment is inferior of his check out hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ()
            {
                MessageBox.Show("There is already a registered appointment at this time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {*/
                
                numericUpDown1.Value = horas;
                DialogResult = DialogResult.OK;
                Close();
            /*}
        if (dateTimePickerAppointment < DateTime.Today)
            MessageBox.Show("Invalid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
        }

        
    }
}
