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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.WebHeadersConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WebHeadersConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WebHeadersConstants" />)
        /// </summary>
        public WebHeadersConstantsTest() : base(typeof(WebHeadersConstants))
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

        #region General Initializer : Class (WebHeadersConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _webHeadersConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="WebHeadersConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _webHeadersConstantsInstanceType = typeof(WebHeadersConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WebHeadersConstants) Initializer

        #region Fields

        private const string FieldCONTENT_TYPE_XML = "CONTENT_TYPE_XML";
        private const string FieldCONTENT_TYPE_JSON = "CONTENT_TYPE_JSON";
        private const string FieldHTTP_HEADER_ACCEPT = "HTTP_HEADER_ACCEPT";
        private const string FieldHTTP_HEADER_CONTENT_TYPE = "HTTP_HEADER_CONTENT_TYPE";

        #endregion

        #endregion

        #region General Initializer : Class (WebHeadersConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="WebHeadersConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WebHeadersConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WebHeadersConstants)

        #region General Initializer : Class (WebHeadersConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="WebHeadersConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCONTENT_TYPE_XML)]
        [TestCase(FieldCONTENT_TYPE_JSON)]
        [TestCase(FieldHTTP_HEADER_ACCEPT)]
        [TestCase(FieldHTTP_HEADER_CONTENT_TYPE)]
        [Category("AUT Fields")]
        public void AUT_WebHeadersConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (WebHeadersConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WebHeadersConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WebHeadersConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _webHeadersConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}