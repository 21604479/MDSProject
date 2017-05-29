using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSProject
{
    public partial class Appointment
{
        public override string ToString()
        {
            return PatientName + " - " + Date;
        }
    }
}
