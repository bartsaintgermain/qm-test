using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Quamotion.Runtime;
using Quamotion.CodedUI.Controls;
using Quamotion.Runtime.UI;
using System.Linq;

namespace qm_test
{
    /// <summary>
    /// Summary description for MobileCodedUITest1
    /// </summary>
    [CodedUITest]
    public class MobileCodedUITest1 : MobileTest
    {

        /// <summary>
        /// Initializes the test. Deploys the app on the device, starts the app on the device and initializes
        /// a connection to the automation provider running ont he device.
        /// </summary>
        [TestInitialize]
        public override void Initialize()
        {
            //base.Initialize();
        }
        [TestMethod]
        [DeploymentItem("Settings.MobileTestSettings")]
        [DeploymentItem(@"apps\", @"apps\")]
        public void MobileCodedUITestMethod1()
        {
            
            var settings = MobileTestSettings.Open(this.MobileTestSettingsFile);
            TargetDevice targetDevice = settings.Devices.First();
            IDeviceProvider deviceprovider = DeviceProviderFactory.Instance.GetProvider(targetDevice.ProviderId);
            var devices = deviceprovider.Devices;
            Assert.IsTrue(devices.Count == 1, String.Format("{0} devices found", devices.Count));
            base.Initialize();

        }
    }
}
