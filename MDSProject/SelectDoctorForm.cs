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
        HealthITDBContainer1 container = new HealthITDBContainer1();

        public SelectDoctorForm()
        {
            InitializeComponent();

            refreshdoctors();
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
            {
                MessageBox.Show("No doctor was selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();  
        }

        private void refreshdoctors()
        {
            listBoxRegisteredDoctors.Items.AddRange(container.DoctorSet.ToArray());
        }
    }
}
