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
    public partial class AppointmentDetailsForm : Form
    {
        HealthITDBContainer1 hcontainer;
        private Appointment selectedAppointment;

        public AppointmentDetailsForm(Appointment appointment)
        {
            InitializeComponent();
            hcontainer = new HealthITDBContainer1();
            selectedAppointment = appointment;
            preencherCampos();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void buttonCancel_Click(object sender, EventArgs e)
        {
            if (selectedAppointment.Date > DateTime.Today)
            {
                if (MessageBox.Show("Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hcontainer.AppointmentSet.Remove(selectedAppointment);
                }
            }
            else
            {
                MessageBox.Show("Impossible to take this action");
            }
        }

        private void preencherCampos()
        {
            //labelDoctorName.Text = selectedAppointment.DoctorName;
            labelPacientName.Text = selectedAppointment.PatientName;
            labelDate.Text = selectedAppointment.Date.ToString();
            labelHour.Text = selectedAppointment.Hour.ToString();
        }
    }
}
