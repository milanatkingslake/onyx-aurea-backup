using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Constants;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.ScriptingSecurityResourcesConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingSecurityResourcesConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingSecurityResourcesConstants" />)
        /// </summary>
        public ScriptingSecurityResourcesConstantsTest() : base(typeof(ScriptingSecurityResourcesConstants))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingSecurityResourcesConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingSecurityResourcesConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingSecurityResourcesConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingSecurityResourcesConstantsInstanceType = typeof(ScriptingSecurityResourcesConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingSecurityResourcesConstants) Initializer

        #region Fields

        private const string FieldUI_OEP_SCRIPTING_DESIGNER = "UI_OEP_SCRIPTING_DESIGNER";
        private const string FieldUI_OEP_SCRIPT_SESSION_DELETE = "UI_OEP_SCRIPT_SESSION_DELETE";
        private const string FieldUI_OEP_SCRIPT_SESSION_UPDATE = "UI_OEP_SCRIPT_SESSION_UPDATE";
        private const string FieldUI_OEP_SCRIPT_SESSION_RETRIEVE = "UI_OEP_SCRIPT_SESSION_RETRIEVE";
        private const string FieldUI_OEP_ADDRESS_VALIDATE = "UI_OEP_ADDRESS_VALIDATE";
        private const string FieldUI_OEP_EMAIL_VALIDATE = "UI_OEP_EMAIL_VALIDATE";
        private const string FieldSECURITY_DESIGNER = "SECURITY_DESIGNER";
        private const string FieldSECURITY_DELETE = "SECURITY_DELETE";
        private const string FieldSECURITY_UPDATE = "SECURITY_UPDATE";
        private const string FieldSECURITY_RETRIEVE = "SECURITY_RETRIEVE";
        private const string FieldSECURITY_ADDRESS_VALIDATE = "SECURITY_ADDRESS_VALIDATE";
        private const string FieldSECURITY_EMAIL_VALIDATE = "SECURITY_EMAIL_VALIDATE";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptingSecurityResourcesConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptingSecurityResourcesConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingSecurityResourcesConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptingSecurityResourcesConstants)

        #region General Initializer : Class (ScriptingSecurityResourcesConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptingSecurityResourcesConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldUI_OEP_SCRIPTING_DESIGNER)]
        [TestCase(FieldUI_OEP_SCRIPT_SESSION_DELETE)]
        [TestCase(FieldUI_OEP_SCRIPT_SESSION_UPDATE)]
        [TestCase(FieldUI_OEP_SCRIPT_SESSION_RETRIEVE)]
        [TestCase(FieldUI_OEP_ADDRESS_VALIDATE)]
        [TestCase(FieldUI_OEP_EMAIL_VALIDATE)]
        [TestCase(FieldSECURITY_DESIGNER)]
        [TestCase(FieldSECURITY_DELETE)]
        [TestCase(FieldSECURITY_UPDATE)]
        [TestCase(FieldSECURITY_RETRIEVE)]
        [TestCase(FieldSECURITY_ADDRESS_VALIDATE)]
        [TestCase(FieldSECURITY_EMAIL_VALIDATE)]
        [Category("AUT Fields")]
        public void AUT_ScriptingSecurityResourcesConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScriptingSecurityResourcesConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingSecurityResourcesConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingSecurityResourcesConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _scriptingSecurityResourcesConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}