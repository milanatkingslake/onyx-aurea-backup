using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Gateway.Data.HttpHeaderConstants" />)
    ///     and namespace <see cref="Onyx.Gateway.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HttpHeaderConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HttpHeaderConstants" />)
        /// </summary>
        public HttpHeaderConstantsTest() : base(typeof(HttpHeaderConstants))
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

        #region General Initializer : Class (HttpHeaderConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _httpHeaderConstantsInstanceType;
        private HttpHeaderConstants _httpHeaderConstantsInstance;
        private HttpHeaderConstants _httpHeaderConstantsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HttpHeaderConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _httpHeaderConstantsInstanceType = typeof(HttpHeaderConstants);
            _httpHeaderConstantsInstanceFixture = this.Create<HttpHeaderConstants>(false);
            _httpHeaderConstantsInstance = _httpHeaderConstantsInstanceFixture ?? this.Create<HttpHeaderConstants>(true);
            CurrentInstance = _httpHeaderConstantsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HttpHeaderConstants) Initializer

        #region Fields

        private const string FieldCUSTOM_REMOVE = "CUSTOM_REMOVE";
        private const string FieldCUSTOM_ADD = "CUSTOM_ADD";
        private const string FieldCUSTOM_SKIP = "CUSTOM_SKIP";
        private const string FieldCUSTOM_ALL = "CUSTOM_ALL";
        private const string FieldCUSTOM_NONE = "CUSTOM_NONE";
        private const string FieldHTTP_HEADER_CUSTOMER_HEADER = "HTTP_HEADER_CUSTOMER_HEADER";
        private const string FieldHTTP_HEADER_CUSTOMER_HEADER_VALUE = "HTTP_HEADER_CUSTOMER_HEADER_VALUE";
        private const string FieldHTTP_HEADER_CACHE_CONTROL = "HTTP_HEADER_CACHE_CONTROL";
        private const string FieldHTTP_HEADER_CACHE_CONTROL_NO_CACHE = "HTTP_HEADER_CACHE_CONTROL_NO_CACHE";

        #endregion

        #endregion
        
        #region General Initializer : Class (HttpHeaderConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HttpHeaderConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HttpHeaderConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HttpHeaderConstants)

        #region General Initializer : Class (HttpHeaderConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HttpHeaderConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCUSTOM_REMOVE)]
        [TestCase(FieldCUSTOM_ADD)]
        [TestCase(FieldCUSTOM_SKIP)]
        [TestCase(FieldCUSTOM_ALL)]
        [TestCase(FieldCUSTOM_NONE)]
        [TestCase(FieldHTTP_HEADER_CUSTOMER_HEADER)]
        [TestCase(FieldHTTP_HEADER_CUSTOMER_HEADER_VALUE)]
        [TestCase(FieldHTTP_HEADER_CACHE_CONTROL)]
        [TestCase(FieldHTTP_HEADER_CACHE_CONTROL_NO_CACHE)]
        [Category("AUT Fields")]
        public void AUT_HttpHeaderConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HttpHeaderConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HttpHeaderConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HttpHeaderConstants_Is_Instance_Present_Test()
        {
            // Assert
            _httpHeaderConstantsInstanceType.ShouldNotBeNull();
            _httpHeaderConstantsInstance.ShouldNotBeNull();
            _httpHeaderConstantsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HttpHeaderConstants) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HttpHeaderConstants" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HttpHeaderConstants_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _httpHeaderConstantsInstance.ShouldBeAssignableTo<HttpHeaderConstants>();
            _httpHeaderConstantsInstanceFixture.ShouldBeAssignableTo<HttpHeaderConstants>();
            CurrentInstance.ShouldBeAssignableTo<HttpHeaderConstants>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HttpHeaderConstants) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HttpHeaderConstants_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HttpHeaderConstants instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}