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
    public partial class NewAppointementForm : Form
    {
        HealthITDBContainer1 container;

        public Appointment NewApp { get; private set; }

        public Doctor NewDoctor { get; private set; }

        public NewAppointementForm()
        {
            InitializeComponent();
             container = new HealthITDBContainer1();


            refreshdoctors();
            dateTimePickeAppointment.MinDate = DateTime.Today;

        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Doctor doctorselecionado = (Doctor)listBoxRegisteredDoctors.SelectedItem;

            if (listBoxRegisteredDoctors.SelectedIndex != -1)
            {
                int checkout = doctorselecionado.CheckOut;
                int checkin = doctorselecionado.CheckIn;
            }
            else if (listBoxRegisteredDoctors.SelectedIndex == -1)
            {
                MessageBox.Show("No doctor was selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxDoctorsName.Text.Length == 0)
            {
                MessageBox.Show("Fill the blank spaces, Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Decimal.ToInt32(numericUpDownHoras.Value) > doctorselecionado.CheckOut)
            {
                MessageBox.Show("The hour you picked for the appointment is superior to the doctor's check out hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Decimal.ToInt32(numericUpDownHoras.Value) < doctorselecionado.CheckIn)
            {
                MessageBox.Show("The hour you picked for the appointment is inferior to the doctor's check in hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           /* else if ()
            {
                MessageBox.Show("There is already a registered appointment at this time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            else {

                Appointment newAPP = new Appointment()
                {
                    Doctor = (Doctor)listBoxRegisteredDoctors.SelectedItem,
                    Hour = Decimal.ToInt32(numericUpDownHoras.Value),
                    PatientName = textBoxPatientName.Text,
                    Date = dateTimePickeAppointment.Value
                };
                container.AppointmentSet.Add(newAPP);
                container.SaveChanges();
                Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshdoctors()
        {
            listBoxRegisteredDoctors.Items.Clear();
            listBoxRegisteredDoctors.Items.AddRange(container.UserSet.OfType<Doctor>().ToArray());
        }

        private void listBoxRegisteredDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor doctorselecionado = (Doctor)listBoxRegisteredDoctors.SelectedItem;

            textBoxDoctorsName.Text = doctorselecionado.Name;
        }
    }
}
