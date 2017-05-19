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
        private string date;
        private string hour;






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

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
            }
        }

        public Appointment(string patientName, string doctorName, string date, string hour)
        {
            PatientName = patientName;
            DoctorName = doctorName;
            Date = date;
            Hour = hour;
        }
    }
}
