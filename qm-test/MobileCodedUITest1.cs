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
using System.Diagnostics;
using System.Threading;

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
            var continueAsGuest = UIMap.UILoginActivityactivity.UIGroupgroup.UIDrawer_layoutgroup.UIGroupgroup.UIGroupgroup1.UIGroupgroup.UILinearLayoutLinearLayout.UILinearLayoutLinearLayout1.ContinueAsGuest;
            var checkFlightStatus = UIMap.UILoginActivityactivity.UIGroupgroup.UIDrawer_layoutgroup.UIGroupgroup.UILinearLayoutLinearLayout.UIGroupgroup.UIGroupgroup1.UILinearLayoutLinearLayout.UILinearLayoutLinearLayout1.UIGroupgroup.CheckFlightStatus;

            Gesture.Tap(continueAsGuest);
            Assert.IsTrue(checkFlightStatus.WaitForControlExist(3000));
        }

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
