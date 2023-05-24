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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.ScriptSessionVariableConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionVariableConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionVariableConstants" />)
        /// </summary>
        public ScriptSessionVariableConstantsTest() : base(typeof(ScriptSessionVariableConstants))
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

        #region General Initializer : Class (ScriptSessionVariableConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionVariableConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionVariableConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionVariableConstantsInstanceType = typeof(ScriptSessionVariableConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionVariableConstants) Initializer

        #region Fields

        private const string FieldOWNER_ID = "OWNER_ID";
        private const string FieldOWNER_TYPE = "OWNER_TYPE";
        private const string FieldOWNER_NAME = "OWNER_NAME";
        private const string FieldUSER_ID = "USER_ID";
        private const string FieldSCRIPT_SESSION_ID = "SCRIPT_SESSION_ID";
        private const string FieldADDRESS_1 = "ADDRESS_1";
        private const string FieldADDRESS_2 = "ADDRESS_2";
        private const string FieldADDRESS_3 = "ADDRESS_3";
        private const string FieldCITY = "CITY";
        private const string FieldREGION = "REGION";
        private const string FieldCOUNTRY = "COUNTRY";
        private const string FieldPOSTAL_CODE = "POSTAL_CODE";
        private const string FieldADDRESS_TYPE = "ADDRESS_TYPE";
        private const string FieldIS_ADDRESS_VALIDATED = "IS_ADDRESS_VALIDATED";
        private const string FieldEMAIL_ADDRESS = "EMAIL_ADDRESS";
        private const string FieldEMAIL_ADDRESS_TYPE = "EMAIL_ADDRESS_TYPE";
        private const string FieldIS_EMAIL_ADDRESS_VALIDATED = "IS_EMAIL_ADDRESS_VALIDATED";
        private const string FieldINCIDENT_CATEGORY = "INCIDENT_CATEGORY";
        private const string FieldCUSTOMER = "CUSTOMER";
        private const string FieldSCALAR = "SCALAR";
        private const string FieldLIST = "LIST";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionVariableConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionVariableConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionVariableConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionVariableConstants)

        #region General Initializer : Class (ScriptSessionVariableConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionVariableConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldOWNER_ID)]
        [TestCase(FieldOWNER_TYPE)]
        [TestCase(FieldOWNER_NAME)]
        [TestCase(FieldUSER_ID)]
        [TestCase(FieldSCRIPT_SESSION_ID)]
        [TestCase(FieldADDRESS_1)]
        [TestCase(FieldADDRESS_2)]
        [TestCase(FieldADDRESS_3)]
        [TestCase(FieldCITY)]
        [TestCase(FieldREGION)]
        [TestCase(FieldCOUNTRY)]
        [TestCase(FieldPOSTAL_CODE)]
        [TestCase(FieldADDRESS_TYPE)]
        [TestCase(FieldIS_ADDRESS_VALIDATED)]
        [TestCase(FieldEMAIL_ADDRESS)]
        [TestCase(FieldEMAIL_ADDRESS_TYPE)]
        [TestCase(FieldIS_EMAIL_ADDRESS_VALIDATED)]
        [TestCase(FieldINCIDENT_CATEGORY)]
        [TestCase(FieldCUSTOMER)]
        [TestCase(FieldSCALAR)]
        [TestCase(FieldLIST)]
        [Category("AUT Fields")]
        public void AUT_ScriptSessionVariableConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionVariableConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionVariableConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionVariableConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _scriptSessionVariableConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}