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
    public partial class MenuLoginForm : Form
    {
        public MenuLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginDoctorForm newForm = new LoginDoctorForm();
            newForm.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginHelpdeskForm newForm = new LoginHelpdeskForm();
            newForm.Show();

            Hide();
        }
    }
}
