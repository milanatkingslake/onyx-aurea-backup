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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboMethodConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboMethodConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboMethodConstants" />)
        /// </summary>
        public LboMethodConstantsTest() : base(typeof(LboMethodConstants))
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

        #region General Initializer : Class (LboMethodConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboMethodConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboMethodConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboMethodConstantsInstanceType = typeof(LboMethodConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboMethodConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldINSTALLED_BY = "INSTALLED_BY";
        private const string FieldDISABLED = "DISABLED";
        private const string FieldMETHOD_TYPE = "METHOD_TYPE";
        private const string FieldPARAMETERS = "PARAMETERS";
        private const string FieldPARAMETER = "PARAMETER";
        private const string FieldSORT_PROPERTIES = "SORT_PROPERTIES";
        private const string FieldSORT_PROPERTY = "SORT_PROPERTY";
        private const string FieldSTEPS = "STEPS";
        private const string FieldSTEP = "STEP";
        private const string FieldMETHOD = "METHOD";

        #endregion

        #endregion

        #region General Initializer : Class (LboMethodConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboMethodConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethodConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboMethodConstants)

        #region General Initializer : Class (LboMethodConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboMethodConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldINSTALLED_BY)]
        [TestCase(FieldDISABLED)]
        [TestCase(FieldMETHOD_TYPE)]
        [TestCase(FieldPARAMETERS)]
        [TestCase(FieldPARAMETER)]
        [TestCase(FieldSORT_PROPERTIES)]
        [TestCase(FieldSORT_PROPERTY)]
        [TestCase(FieldSTEPS)]
        [TestCase(FieldSTEP)]
        [TestCase(FieldMETHOD)]
        [Category("AUT Fields")]
        public void AUT_LboMethodConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboMethodConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboMethodConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboMethodConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboMethodConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}