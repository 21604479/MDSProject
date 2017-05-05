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

        public string labelname
        {
            get
            {
                return labelDoctorsName.Text;
                
            }

            set
            {
                labelDoctorsName.Text = value;
                
            }
        }

        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {
            SelectDoctorForm selectdoctor = new SelectDoctorForm();
            selectdoctor.ShowDialog();
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            SelectDateTimeForm selectdate = new SelectDateTimeForm();
            selectdate.ShowDialog();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm cancelar = new MainMenuForm();
            cancelar.Show();
            this.Close();
        }
    }
}
