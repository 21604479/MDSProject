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
    public partial class SelectDoctorForm : Form
    {
        public SelectDoctorForm()
        {
            InitializeComponent();
        }

        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {
            //labelDoctorsName.Text = listBoxRegisteredDoctors.SelectedItem.ToString();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
