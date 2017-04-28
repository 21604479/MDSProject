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
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelForm cancel = new CancelForm();
            cancel.ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            NewAppointementForm appointment = new NewAppointementForm();
            appointment.ShowDialog();
            
        }

        private void buttonRegistDoctor_Click(object sender, EventArgs e)
        {
            RegisterDoctorForm regDoc = new RegisterDoctorForm();
            regDoc.ShowDialog();
        }
    }
}
