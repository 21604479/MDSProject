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
        public AppointmentDetailsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {

            if ()
            {
                Close();
                ErrorMessageForm errorMessage = new ErrorMessageForm();
            }
            else
            {
                Close();
                ConfirmationForm confirmation = new ConfirmationForm();
            }

            
        }
    }
}
