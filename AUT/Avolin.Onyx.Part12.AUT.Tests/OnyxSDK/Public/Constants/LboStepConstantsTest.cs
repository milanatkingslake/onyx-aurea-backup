using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Constants;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboStepConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboStepConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboStepConstants" />)
        /// </summary>
        public LboStepConstantsTest() : base(typeof(LboStepConstants))
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

        #region General Initializer : Class (LboStepConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboStepConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboStepConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboStepConstantsInstanceType = typeof(LboStepConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboStepConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldSTEP_DATA = "STEP_DATA";
        private const string FieldSTEP_ADDITIONAL_DATA = "STEP_ADDITIONAL_DATA";
        private const string FieldODM_TEMPLATE = "ODM_TEMPLATE";
        private const string FieldSTEP_TYPE = "STEP_TYPE";
        private const string FieldINSTALLED_TYPE = "INSTALLED_TYPE";
        private const string FieldDISABLED = "DISABLED";
        private const string FieldSTEP = "STEP";

        #endregion

        #endregion

        #region General Initializer : Class (LboStepConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboStepConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboStepConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboStepConstants)

        #region General Initializer : Class (LboStepConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboStepConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldSTEP_DATA)]
        [TestCase(FieldSTEP_ADDITIONAL_DATA)]
        [TestCase(FieldODM_TEMPLATE)]
        [TestCase(FieldSTEP_TYPE)]
        [TestCase(FieldINSTALLED_TYPE)]
        [TestCase(FieldDISABLED)]
        [TestCase(FieldSTEP)]
        [Category("AUT Fields")]
        public void AUT_LboStepConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboStepConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboStepConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboStepConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboStepConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}