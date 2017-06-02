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

        HealthITDBContainer1 hcontainer;
        private Appointment selectedAppointment;

        public CancelForm()
        {
            InitializeComponent();
            hcontainer = new HealthITDBContainer1();
            refreshListBox();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxAppointment.SelectedIndex != -1)
            {
                selectedAppointment = (Appointment)listBoxAppointment.SelectedItem;
                labelDoctorName.Text = selectedAppointment.Doctor.Name;
                labelPacientName.Text = selectedAppointment.PatientName;
                labelDate.Text = selectedAppointment.Date.ToString();
                labelHour.Text = selectedAppointment.Hour.ToString();
            }
            else
            {
                MessageBox.Show("Select one appointment, please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            listBoxAppointment.Items.AddRange(hcontainer.AppointmentSet.ToArray());
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            if (listBoxAppointment.SelectedIndex != -1)
            {
                if (selectedAppointment.Date > DateTime.Today)
                {
                    if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        hcontainer.AppointmentSet.Remove(selectedAppointment);
                        hcontainer.SaveChanges();
                        refreshListBox();
                        limparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Impossible to take this action");
                }
            }
            else
            {
                MessageBox.Show("No Appoitment was selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCampos()
        {
            selectedAppointment = null;
            labelDoctorName.Text = "";
            labelPacientName.Text = "";
            labelDate.Text = "";
            labelHour.Text = "";
        }

    }
}
