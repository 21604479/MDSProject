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

            dateTimePickeAppointment.MinDate = DateTime.Today;

        }


        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {
            SelectDoctorForm selectdoctor = new SelectDoctorForm();

            if (selectdoctor.ShowDialog() == DialogResult.OK)
            {
                textBoxDoctorsName.Text = selectdoctor.selectedDoctor;
            }
        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SelectDoctorForm selectdoctor = new SelectDoctorForm();

            if (textBoxDoctorsName.Text.Length == 0)
            {
                MessageBox.Show("Fill the blank spaces, Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Decimal.ToInt32(numericUpDownHoras.Value) > selecdoctor.CheckOut)
            {
                MessageBox.Show("The hour you picked for the appointment is superior to the doctor's check out hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Decimal.ToInt32(numericUpDownHoras.Value) < NewDoctor.CheckIn)
            {
                MessageBox.Show("The hour you picked for the appointment is inferior to the doctor's check in hour.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*else if ()
            {
                MessageBox.Show("There is already a registered appointment at this time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            else { 

                Appointment newAPP = new Appointment()
                {
                    DoctorName = textBoxDoctorsName.Text,
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
    }
}
