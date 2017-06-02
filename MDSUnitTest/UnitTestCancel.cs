
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using MDSProject;
using System;

namespace MDSProject.Tests
{
    [TestClass()]
    public class UnitTestCancel
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.Fail();
            if (selectedAppointment.Date > DateTime.Today)
            {
                MessageBox.Show("Cancela o appointment");
            }
        }
    }
}
