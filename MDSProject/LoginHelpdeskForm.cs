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
    public partial class LoginHelpdeskForm : Form
    {
        HealthITDBContainer1 hcontainer;

        public LoginHelpdeskForm()
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

            var utilizadores = from user in hcontainer.UserSet.OfType<HelpDesk>() where user.Username == textBoxUsername.Text && user.Password == textBoxPassword.Text select user;

            try
            {
                //Se os dados correspondem aos da base de dados então vai devolver a vista.
                HelpDesk userSelecionado = utilizadores.First<HelpDesk>();
                MainMenuForm newVista = new MainMenuForm();
                newVista.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Login!"); ;
            }
        }
    }
}
