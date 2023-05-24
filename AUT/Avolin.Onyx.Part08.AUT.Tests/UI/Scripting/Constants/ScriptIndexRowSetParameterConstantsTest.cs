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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.ScriptIndexRowSetParameterConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptIndexRowSetParameterConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptIndexRowSetParameterConstants" />)
        /// </summary>
        public ScriptIndexRowSetParameterConstantsTest() : base(typeof(ScriptIndexRowSetParameterConstants))
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

        #region General Initializer : Class (ScriptIndexRowSetParameterConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptIndexRowSetParameterConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptIndexRowSetParameterConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptIndexRowSetParameterConstantsInstanceType = typeof(ScriptIndexRowSetParameterConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptIndexRowSetParameterConstants) Initializer

        #region Fields

        private const string FieldTYPE_SCRIPT = "TYPE_SCRIPT";
        private const string FieldTYPE_SCRIPT_GROUP = "TYPE_SCRIPT_GROUP";
        private const string FieldTYPE = "TYPE";
        private const string FieldPRIMARY_ID = "PRIMARY_ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldACTIVE = "ACTIVE";
        private const string FieldPARENT_ID = "PARENT_ID";
        private const string FieldINITIAL_SCRIPT_STEP_ID = "INITIAL_SCRIPT_STEP_ID";
        private const string FieldOWNER_TYPE_LIST = "OWNER_TYPE_LIST";
        private const string FieldEFFECTIVE_DATE = "EFFECTIVE_DATE";
        private const string FieldEXPIRATION_DATE = "EXPIRATION_DATE";
        private const string FieldPUBLISHED = "PUBLISHED";
        private const string FieldALLOW_QUICK_EDIT = "ALLOW_QUICK_EDIT";
        private const string FieldSUPPORT_CONTEXT_VARIABLES = "SUPPORT_CONTEXT_VARIABLES";
        private const string FieldSHOW_STEP_HISTORY_LIST = "SHOW_STEP_HISTORY_LIST";
        private const string FieldSHOW_SCRIPT_BANNER = "SHOW_SCRIPT_BANNER";
        private const string FieldSHOW_BANNER_CONTEXT_DATA = "SHOW_BANNER_CONTEXT_DATA";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptIndexRowSetParameterConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptIndexRowSetParameterConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptIndexRowSetParameterConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptIndexRowSetParameterConstants)

        #region General Initializer : Class (ScriptIndexRowSetParameterConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptIndexRowSetParameterConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldTYPE_SCRIPT)]
        [TestCase(FieldTYPE_SCRIPT_GROUP)]
        [TestCase(FieldTYPE)]
        [TestCase(FieldPRIMARY_ID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldACTIVE)]
        [TestCase(FieldPARENT_ID)]
        [TestCase(FieldINITIAL_SCRIPT_STEP_ID)]
        [TestCase(FieldOWNER_TYPE_LIST)]
        [TestCase(FieldEFFECTIVE_DATE)]
        [TestCase(FieldEXPIRATION_DATE)]
        [TestCase(FieldPUBLISHED)]
        [TestCase(FieldALLOW_QUICK_EDIT)]
        [TestCase(FieldSUPPORT_CONTEXT_VARIABLES)]
        [TestCase(FieldSHOW_STEP_HISTORY_LIST)]
        [TestCase(FieldSHOW_SCRIPT_BANNER)]
        [TestCase(FieldSHOW_BANNER_CONTEXT_DATA)]
        [Category("AUT Fields")]
        public void AUT_ScriptIndexRowSetParameterConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptIndexRowSetParameterConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptIndexRowSetParameterConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptIndexRowSetParameterConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _scriptIndexRowSetParameterConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}