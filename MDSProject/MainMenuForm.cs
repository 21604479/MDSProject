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
    public partial class MainMenuForm : Form
    {

        private List<Appointment> appointments;
        private List<DoctorDet> doctorDets;

        public MainMenuForm()
        {
            InitializeComponent();
            appointments = new List<Appointment>();
            doctorDets = new List<DoctorDet>();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelForm cancel = new CancelForm();
            cancel.ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            NewAppointementForm appointment = new NewAppointementForm();
            appointment.Show();
            this.Hide();
        }

        private void buttonRegistDoctor_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm regDoc = new RegisterDoctorForm();
            regDoc.ShowDialog();
        }

        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*public void AdicionarAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
            refreshListAppointments();
        }

        public void AdicionarDoctor(DoctorDet doctorDet)
        {
            doctorDets.Add(doctorDet);
            refreshListDoctors();
        }

        private void refreshListAppointments()
        {
            
        }

        private void refreshListDoctors()
        {

        }*/
    }
}
