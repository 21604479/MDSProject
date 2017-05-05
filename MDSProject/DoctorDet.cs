using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSProject
{
    public class DoctorDet
    {
        private string name;
        private string proficiency;
        private string ssn;
        private int checkIn;
        private int checkOut;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Proficiency
        {
            get
            {
                return proficiency;
            }

            set
            {
                proficiency = value;
            }
        }

        public string Ssn
        {
            get
            {
                return ssn;
            }

            set
            {
                ssn = value;
            }
        }

        public int CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public int CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }

        public DoctorDet(string name, string proficiency, string ssn, int checkIn, int CheckOut)
        {
            Name = name;
            Proficiency = proficiency;
            Ssn = ssn;
            CheckIn = checkIn;
            this.CheckOut = checkOut;

        }

        public override string ToString()
        {
            return Name + "  -  " + Proficiency;
        }
    }
}
