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

        public NewAppointementForm()
        {
            InitializeComponent();
             container = new HealthITDBContainer1();

        }


        private void buttonSelectDoctor_Click(object sender, EventArgs e)
        {
            SelectDoctorForm selectdoctor = new SelectDoctorForm();

            if (selectdoctor.ShowDialog() == DialogResult.OK)
            {
                textBoxDoctorsName.Text = selectdoctor.selectedDoctor;
            }
        }


        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            SelectDateTimeForm selectdate = new SelectDateTimeForm(textBoxDoctorsName.Text);
            DialogResult result = selectdate.ShowDialog();
            if (result == DialogResult.OK)
            {
                numericUpDown1.Value = selectdate.horas;

            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxDoctorsName.Text.Length == 0 || /*textBoxDateTime.Text.Length == 0 ||*/ textBox1.Text.Length == 0)
            {
                MessageBox.Show("Fill the blank spaces, Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Appointment newAPP = new Appointment()
                {
                    DoctorName = textBoxDoctorsName.Text,
                    //Hour = labelHour.Text,
                    

                    //Date = (textBoxDateTime.Text),


                };
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm cancelar = new MainMenuForm();
            cancelar.Show();
            this.Close();
        }
    }
}
