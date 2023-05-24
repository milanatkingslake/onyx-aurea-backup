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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.ScriptingSystemParametersConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingSystemParametersConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingSystemParametersConstants" />)
        /// </summary>
        public ScriptingSystemParametersConstantsTest() : base(typeof(ScriptingSystemParametersConstants))
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

        #region General Initializer : Class (ScriptingSystemParametersConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingSystemParametersConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingSystemParametersConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingSystemParametersConstantsInstanceType = typeof(ScriptingSystemParametersConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingSystemParametersConstants) Initializer

        #region Fields

        private const string FieldQAS_VALIDATE_ADDRESS = "QAS_VALIDATE_ADDRESS";
        private const string FieldQAS_VALIDATE_EMAIL = "QAS_VALIDATE_EMAIL";
        private const string FieldQAS_ADDRESS_TYPES_TO_VALIDATE = "QAS_ADDRESS_TYPES_TO_VALIDATE";
        private const string FieldQAS_EMAIL_TYPES_TO_VALIDATE = "QAS_EMAIL_TYPES_TO_VALIDATE";
        private const string FieldQAS_ALLOW_SUGGESSTIONS = "QAS_ALLOW_SUGGESSTIONS";
        private const string FieldQAS_NO_RECORDS_PER_PAGE = "QAS_NO_RECORDS_PER_PAGE";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptingSystemParametersConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptingSystemParametersConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingSystemParametersConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptingSystemParametersConstants)

        #region General Initializer : Class (ScriptingSystemParametersConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptingSystemParametersConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldQAS_VALIDATE_ADDRESS)]
        [TestCase(FieldQAS_VALIDATE_EMAIL)]
        [TestCase(FieldQAS_ADDRESS_TYPES_TO_VALIDATE)]
        [TestCase(FieldQAS_EMAIL_TYPES_TO_VALIDATE)]
        [TestCase(FieldQAS_ALLOW_SUGGESSTIONS)]
        [TestCase(FieldQAS_NO_RECORDS_PER_PAGE)]
        [Category("AUT Fields")]
        public void AUT_ScriptingSystemParametersConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptingSystemParametersConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingSystemParametersConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingSystemParametersConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _scriptingSystemParametersConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}