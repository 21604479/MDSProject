using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSProject
{
    using System;
    using System.Collections.Generic;

    public partial class Doctor
{
        public override string ToString()
        {
            return this.Name; //+ " - " + this.Proficiency;
        }
    }
}
