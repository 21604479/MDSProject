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
    public partial class LoginDoctorForm : Form
    {

        HealthITDBContainer1 hcontainer;

        public LoginDoctorForm()
        {
            InitializeComponent();
            hcontainer = new HealthITDBContainer1();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Verify Login
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Invalid Login!");
            }

            var utilizadores = from user in hcontainer.UserSet.OfType<Doctor>() where user.Username == textBoxUsername.Text && user.Password == textBoxPassword.Text select user;

            try
            {
                //Se os dados correspondem aos da base de dados então vai devolver a vista.
                Doctor userSelecionado = utilizadores.First<Doctor>();
                RegisterConsultationDetails newVista = new RegisterConsultationDetails();
                newVista.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Login!"); 
            }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MenuLoginForm form = new MenuLoginForm();
            form.Show();

            Close();
        }
    }
}
