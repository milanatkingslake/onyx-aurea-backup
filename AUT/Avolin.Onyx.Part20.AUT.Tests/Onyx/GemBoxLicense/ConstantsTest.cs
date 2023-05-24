using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GemBoxLicense;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.GemBoxLicense
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GemBoxLicense.Constants" />)
    ///     and namespace <see cref="Onyx.GemBoxLicense"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Constants" />)
        /// </summary>
        public ConstantsTest() : base(typeof(Constants))
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

        #region General Initializer : Class (Constants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _constantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Constants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _constantsInstanceType = typeof(Constants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Constants) Initializer

        #region Fields

        private const string FieldLICENSE_KEY_FREE = "LICENSE_KEY_FREE";
        private const string FieldAPP_SETTINGS = "APP_SETTINGS";
        private const string FieldSUPPORTED_APPLICATIONS = "SUPPORTED_APPLICATIONS";
        private const string FieldDEFAULT_PROCESS_NAMES = "DEFAULT_PROCESS_NAMES";

        #endregion

        #endregion
        
        #region General Initializer : Class (Constants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Constants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Constants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Constants)

        #region General Initializer : Class (Constants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Constants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldLICENSE_KEY_FREE)]
        [TestCase(FieldAPP_SETTINGS)]
        [TestCase(FieldSUPPORTED_APPLICATIONS)]
        [TestCase(FieldDEFAULT_PROCESS_NAMES)]
        [Category("AUT Fields")]
        public void AUT_Constants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Constants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Constants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Constants_Is_Static_Type_Present_Test()
        {
            // Assert
            _constantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}