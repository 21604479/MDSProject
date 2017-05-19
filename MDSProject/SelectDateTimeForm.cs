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
    public partial class SelectDateTimeForm : Form
    {
        public SelectDateTimeForm(string text)
        {
            InitializeComponent();

            NewAppointementForm newapp = new NewAppointementForm();

            labelDoctorsName.Text = text;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*if (dateTimePickerAppointment < DateTime.Today)
                MessageBox.Show("Invalid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
        }
    }
}
