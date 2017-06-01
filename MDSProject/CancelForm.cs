﻿using System;
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
    public partial class CancelForm : Form
    {

        HealthITDBContainer1 hcontainer;
        private Appointment selectedAppointment;

        public CancelForm()
        {
            InitializeComponent();
            hcontainer = new HealthITDBContainer1();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            selectedAppointment = (Appointment)listBoxAppointment.SelectedItem;
            hcontainer.AppointmentSet.Remove(selectedAppointment);
            refreshListBox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string myString = textBoxSearch.Text;
            
            int index = listBoxAppointment.FindString(myString, -1);
            if (index != -1)
            {

                listBoxAppointment.SetSelected(index, true);

            }
            else
            {
                MessageBox.Show("Item not found.");
            }  
        }

        private void refreshListBox()
        {
            listBoxAppointment.Items.Clear();
            listBoxAppointment.Items.AddRange(hcontainer.AppointmentSet.ToArray());
        }
    }
}
