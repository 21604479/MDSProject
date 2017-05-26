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
    public partial class CancelForm : Form
    {

        private List<Appointment> appointments;

        public CancelForm()
        {
            InitializeComponent();
            listBoxAppointment.Items.Add("Sarah");
            listBoxAppointment.Items.Add("Alex ");
            listBoxAppointment.Items.Add("Pedro");
            listBoxAppointment.Items.Add("Luis");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            AppointmentDetailsForm appointmentDetails = new AppointmentDetailsForm();
            appointmentDetails.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string myString = textBoxSearch.Text;
            
            int index = listBoxAppointment.FindString(myString, -1);
            if (index != -1)
            {

                listBoxAppointment.SetSelected(index, true);

            }
            else
            {
                MessageBox.Show("Item not found.");
            }  
        }

        private void refreshListBox()
        {
            listBoxAppointment.Items.Clear();
            listBoxAppointment.Items.AddRange(appointments.ToArray());
        }
    }
}
