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
        public SelectDateTimeForm()
        {
            InitializeComponent();

            NewAppointementForm newapp = new NewAppointementForm();

            labelDoctorsName.Text = newapp.labelname;

        }

    }
}
