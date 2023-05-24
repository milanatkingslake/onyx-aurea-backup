using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Constants;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Core.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.Constants.CoreConstants" />)
    ///     and namespace <see cref="Onyx.UI.Core.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CoreConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CoreConstants" />)
        /// </summary>
        public CoreConstantsTest() : base(typeof(CoreConstants))
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

        #region General Initializer : Class (CoreConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _coreConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CoreConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _coreConstantsInstanceType = typeof(CoreConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CoreConstants) Initializer

        #region Fields

        private const string FieldQUERY_SESSION_ID = "QUERY_SESSION_ID";
        private const string FieldQUERY_APP_NAME = "QUERY_APP_NAME";
        private const string FieldHEADER_APP_NAME = "HEADER_APP_NAME";
        private const string FieldHEADER_SITE_ID = "HEADER_SITE_ID";
        private const string FieldHEADER_LANG = "HEADER_LANG";
        private const string FieldHEADER_USER_ID = "HEADER_USER_ID";
        private const string FieldHEADER_SESSION_ID = "HEADER_SESSION_ID";
        private const string FieldHEADER_PASSWORD = "HEADER_PASSWORD";
        private const string FieldHEADER_NEW_PASSOWRD = "HEADER_NEW_PASSOWRD";
        private const string FieldHEADER_AUTH_MODE = "HEADER_AUTH_MODE";
        private const string FieldHEADER_APP_TYPE = "HEADER_APP_TYPE";
        private const string FieldHEADER_CLIENT_TIMEZONE_OFFSET = "HEADER_CLIENT_TIMEZONE_OFFSET";

        #endregion

        #endregion

        #region General Initializer : Class (CoreConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CoreConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CoreConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CoreConstants)

        #region General Initializer : Class (CoreConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CoreConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldQUERY_SESSION_ID)]
        [TestCase(FieldQUERY_APP_NAME)]
        [TestCase(FieldHEADER_APP_NAME)]
        [TestCase(FieldHEADER_SITE_ID)]
        [TestCase(FieldHEADER_LANG)]
        [TestCase(FieldHEADER_USER_ID)]
        [TestCase(FieldHEADER_SESSION_ID)]
        [TestCase(FieldHEADER_PASSWORD)]
        [TestCase(FieldHEADER_NEW_PASSOWRD)]
        [TestCase(FieldHEADER_AUTH_MODE)]
        [TestCase(FieldHEADER_APP_TYPE)]
        [TestCase(FieldHEADER_CLIENT_TIMEZONE_OFFSET)]
        [Category("AUT Fields")]
        public void AUT_CoreConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CoreConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CoreConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CoreConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _coreConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}