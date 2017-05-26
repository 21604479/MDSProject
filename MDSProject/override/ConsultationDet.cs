using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSProject
{
    public partial class ConsultationDet
{
        public override string ToString()
        {
            return Symptoms +" - " + Diagnostic;
        }
    }
}
