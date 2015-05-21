using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quamotion.CodedUI.Controls;

namespace qm_test
{
    /// <summary>
    /// Provides methods for initializing and cleaning up resources used
    /// by the Mobile Coded UI Test framework.
    /// </summary>
    /// <remarks>
    /// The methods in this class are called by the Visual Studio Unit Test framework.
    /// </remarks>
    [TestClass]
    public class AssemblyMethods
    {
        /// <summary>
        /// Initializes the Mobile Coded UI Test framework.
        /// </summary>
        /// <param name="context">
        /// An instance of the <see cref="TetContext"/> class.
        /// </param>
        /// <remarks>
        /// This method is called by the Visual Studio Unit Test framework.
        /// </remarks>
        [AssemblyInitialize]
        public static void Intialize(TestContext context)
        {
            AssemblyHelpers.Initialize(context);
        }

        /// <summary>
        /// Cleans up any resources used by the Mobile Coded UI Test framework.
        /// </summary>
        /// <remarks>
        /// This method is called by the Visual Studio Unit Test framework.
        /// </remarks>
        [AssemblyCleanup]
        public static void Cleanup()
        {
            AssemblyHelpers.Cleanup();
        }
    }
}
