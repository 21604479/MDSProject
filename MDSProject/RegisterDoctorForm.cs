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
    public partial class RegisterDoctorForm : Form
    {

        public Doctor NewDoctor { get; private set; }

        HealthITDBContainer1 container;

        public RegisterDoctorForm()
        {
            InitializeComponent();

            container = new HealthITDBContainer1();

            refreshDoc();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxSSN.Text.Length == 0 || comboBoxProficiency.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the blank boxes, Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxSSN.Text.Length != 9)
            {
                MessageBox.Show("Invalid SSN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numericUpDownCheckOut.Value <= numericUpDownCheckIn.Value)
            {
                MessageBox.Show("A doctor can't check out before check in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Please insert a username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if ( listBoxDoctors.SelectedIndex != -1)
                {

                DialogResult result = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                {
                    Doctor selectDoctor = (Doctor)listBoxDoctors.SelectedItem;

                    selectDoctor.Name = textBoxName.Text;
                    selectDoctor.Proficiency = comboBoxProficiency.Text;
                    selectDoctor.Ssn = textBoxSSN.Text;
                    selectDoctor.CheckIn = decimal.ToInt32(numericUpDownCheckIn.Value);
                    selectDoctor.CheckOut = decimal.ToInt32(numericUpDownCheckOut.Value);

                    container.SaveChanges();
                    refreshDoc();

                    clearInfo();

                    buttonRegister.Text = "Register";

                    MessageBox.Show("Data saved with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                NewDoctor = new Doctor()
                {
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    Name = textBoxName.Text,
                    Proficiency = comboBoxProficiency.Text,
                    Ssn = textBoxSSN.Text,
                    CheckIn = decimal.ToInt32(numericUpDownCheckIn.Value),
                    CheckOut = decimal.ToInt32(numericUpDownCheckOut.Value),
                };

                container.UserSet.Add(NewDoctor);
                container.SaveChanges();
                refreshDoc();

                MessageBox.Show("Doctor registered with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearInfo();
            }
        }

        private void refreshDoc()
        {
            listBoxDoctors.Items.Clear();
            listBoxDoctors.Items.AddRange(container.UserSet.OfType<Doctor>().ToArray());
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void clearInfo()
        {
            buttonRegister.Text = "Register";
            textBoxName.Clear();
            textBoxSSN.Clear();
            comboBoxProficiency.SelectedIndex = -1;
            numericUpDownCheckIn.Value = 0;
            numericUpDownCheckOut.Value = 8;
            textBoxUsername.Clear();
            textBoxPassword.Clear();

            textBoxUsername.ReadOnly = false;

            listBoxDoctors.SelectedIndex = -1;
        }

        private void listBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor selectDoctor = (Doctor)listBoxDoctors.SelectedItem;

            if (selectDoctor != null)
            {
                buttonRegister.Text = "Save";

                textBoxName.Text = selectDoctor.Name;
                textBoxSSN.Text = selectDoctor.Ssn;
                comboBoxProficiency.Text = selectDoctor.Proficiency;
                numericUpDownCheckIn.Value = selectDoctor.CheckIn;
                numericUpDownCheckOut.Value = selectDoctor.CheckOut;
                textBoxUsername.Text = selectDoctor.Username;
                textBoxPassword.Text = selectDoctor.Password;

                textBoxUsername.ReadOnly = true;

            }
            else if (selectDoctor == null)
            {
                buttonRegister.Text = "Register";
            }
        }

        private void textBoxSSN_TextChanged(object sender, EventArgs e)
        {
            textBoxSSN.MaxLength = 9;

            double parsedValue;

            if (!double.TryParse(textBoxSSN.Text, out parsedValue))
            {
                textBoxSSN.Text = "";
            }
        }
    }
}
