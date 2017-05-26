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

        public string selectedDoctor
        {
            get
            {
                return listBoxRegisteredDoctors.SelectedItem.ToString();
            }
        }

        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {

            if (listBoxRegisteredDoctors.SelectedIndex == -1)
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();  
        }
    }
}
