using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSProject
{
    class Appointment
    {
        private string patientName;
        private string doctorName;






        public string PatientName
        {
            get
            {
                return patientName;
            }

            set
            {
                patientName = value;
            }
        }



        public string DoctorName
        {
            get
            {
                return doctorName;
            }

            set
            {
                doctorName = value;
            }
        }




        public Appointment(string patientName, string doctorName)
        {
            PatientName = patientName;
            DoctorName = doctorName;
        }
    }
}
