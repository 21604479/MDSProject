
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using MDSProject;
using System;

namespace MDSUnitTest
{
    [TestClass]
    public class UnitTestCancel
    {
        HealthITDBContainer1 hcontainer;
        private Appointment selectedAppointment = new Appointment();

        [TestMethod]
        public void TestMethodCancel()
        {

            AppointmentDetailsForm x = new AppointmentDetailsForm(selectedAppointment);
            
            selectedAppointment.Date = new DateTime(2017, 08, 01);

            if (selectedAppointment.Date > DateTime.Today)
            {

                Assert.Fail("Are you sure to cancel?");
                /*if (MessageBox.Show("Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                }*/
            }
        }
    }
}
