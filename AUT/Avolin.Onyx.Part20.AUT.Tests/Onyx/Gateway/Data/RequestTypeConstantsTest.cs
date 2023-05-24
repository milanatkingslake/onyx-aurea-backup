using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Gateway.Data;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.Gateway.Data
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Gateway.Data.RequestTypeConstants" />)
    ///     and namespace <see cref="Onyx.Gateway.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RequestTypeConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RequestTypeConstants" />)
        /// </summary>
        public RequestTypeConstantsTest() : base(typeof(RequestTypeConstants))
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

        #region General Initializer : Class (RequestTypeConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _requestTypeConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="RequestTypeConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _requestTypeConstantsInstanceType = typeof(RequestTypeConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RequestTypeConstants) Initializer

        #region Fields

        private const string FieldHTTP_GET = "HTTP_GET";
        private const string FieldHTTP_PUT = "HTTP_PUT";
        private const string FieldHTTP_POST = "HTTP_POST";
        private const string FieldHTTP_DELETE = "HTTP_DELETE";

        #endregion

        #endregion

        #region General Initializer : Class (RequestTypeConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RequestTypeConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RequestTypeConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RequestTypeConstants)

        #region General Initializer : Class (RequestTypeConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RequestTypeConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldHTTP_GET)]
        [TestCase(FieldHTTP_PUT)]
        [TestCase(FieldHTTP_POST)]
        [TestCase(FieldHTTP_DELETE)]
        [Category("AUT Fields")]
        public void AUT_RequestTypeConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RequestTypeConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RequestTypeConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestTypeConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _requestTypeConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}