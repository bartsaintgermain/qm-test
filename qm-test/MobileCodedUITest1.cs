using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Quamotion.Runtime;
using Quamotion.CodedUI.Controls;

namespace qm_test
{
    /// <summary>
    /// Summary description for MobileCodedUITest1
    /// </summary>
    [CodedUITest]
    public class MobileCodedUITest1 : MobileTest
    {
        [TestMethod]
        [DeploymentItem("Settings.MobileTestSettings")]
        [DeploymentItem(@"apps\", @"apps\")]
        public void MobileCodedUITestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}
