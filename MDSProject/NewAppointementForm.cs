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
        public NewAppointementForm()
        {
            InitializeComponent();
        }

        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {
            SelectDoctorForm selectdoctor = new SelectDoctorForm();
            selectdoctor.ShowDialog();
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
