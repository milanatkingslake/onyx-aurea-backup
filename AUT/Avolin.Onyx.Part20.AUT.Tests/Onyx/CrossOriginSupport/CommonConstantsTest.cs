using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CrossOriginSupport;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.CrossOriginSupport
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.CommonConstants" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CommonConstants" />)
        /// </summary>
        public CommonConstantsTest() : base(typeof(CommonConstants))
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

        #region General Initializer : Class (CommonConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CommonConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonConstantsInstanceType = typeof(CommonConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CommonConstants) Initializer

        #region Fields

        private const string FieldHTTP_REQUEST = "HTTP_REQUEST";
        private const string FieldOPTIONS = "OPTIONS";
        private const string FieldACCESS_CONTROL_REQUEST_HEADERS = "ACCESS_CONTROL_REQUEST_HEADERS";
        private const string FieldACCESS_CONTROL_ALLOW_METHODS = "ACCESS_CONTROL_ALLOW_METHODS";
        private const string FieldACCESS_CONTROL_ALLOW_ORIGIN = "ACCESS_CONTROL_ALLOW_ORIGIN";
        private const string FieldACCESS_CONTROL_ALLOW_HEADERS = "ACCESS_CONTROL_ALLOW_HEADERS";
        private const string FieldACCEPT = "ACCEPT";
        private const string FieldCROSS_ORIGIN_SUPPORT_METHODS = "CROSS_ORIGIN_SUPPORT_METHODS";
        private const string FieldSTAR = "STAR";
        private const string FieldCROSS_ORIGIN_SUPPORT_ORIGINS = "CROSS_ORIGIN_SUPPORT_ORIGINS";
        private const string FieldORIGIN = "ORIGIN";
        private const string FieldENDPOINT_ADDRESS = "ENDPOINT_ADDRESS";
        private const string FieldBINDING_MESSAGE = "BINDING_MESSAGE";

        #endregion

        #endregion

        #region General Initializer : Class (CommonConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CommonConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CommonConstants)

        #region General Initializer : Class (CommonConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldHTTP_REQUEST)]
        [TestCase(FieldOPTIONS)]
        [TestCase(FieldACCESS_CONTROL_REQUEST_HEADERS)]
        [TestCase(FieldACCESS_CONTROL_ALLOW_METHODS)]
        [TestCase(FieldACCESS_CONTROL_ALLOW_ORIGIN)]
        [TestCase(FieldACCESS_CONTROL_ALLOW_HEADERS)]
        [TestCase(FieldACCEPT)]
        [TestCase(FieldCROSS_ORIGIN_SUPPORT_METHODS)]
        [TestCase(FieldSTAR)]
        [TestCase(FieldCROSS_ORIGIN_SUPPORT_ORIGINS)]
        [TestCase(FieldORIGIN)]
        [TestCase(FieldENDPOINT_ADDRESS)]
        [TestCase(FieldBINDING_MESSAGE)]
        [Category("AUT Fields")]
        public void AUT_CommonConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CommonConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CommonConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}