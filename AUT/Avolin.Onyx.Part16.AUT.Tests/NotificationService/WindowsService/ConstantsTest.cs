using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.WindowsService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.WindowsService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.WindowsService.Constants" />)
    ///     and namespace <see cref="NotificationService.WindowsService"/> class using generator(v:0.2.5)'s
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

        private const string FieldLOG4NET_CONFIG = "LOG4NET_CONFIG";
        private const string FieldFILEPATH = "FILEPATH";
        private const string FieldINSTALL_LOGFILE_NAME = "INSTALL_LOGFILE_NAME";
        private const string FieldEXE_NAME = "EXE_NAME";

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
        [TestCase(FieldLOG4NET_CONFIG)]
        [TestCase(FieldFILEPATH)]
        [TestCase(FieldINSTALL_LOGFILE_NAME)]
        [TestCase(FieldEXE_NAME)]
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