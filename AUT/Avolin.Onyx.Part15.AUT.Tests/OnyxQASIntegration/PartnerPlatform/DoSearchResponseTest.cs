using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration.PartnerPlatform;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration.PartnerPlatform
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoSearchResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoSearchResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoSearchResponse" />)
        /// </summary>
        public DoSearchResponseTest() : base(typeof(DoSearchResponse))
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

        #region General Initializer : Class (DoSearchResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doSearchResponseInstanceType;
        private DoSearchResponse _doSearchResponseInstance;
        private DoSearchResponse _doSearchResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoSearchResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doSearchResponseInstanceType = typeof(DoSearchResponse);
            _doSearchResponseInstanceFixture = this.Create<DoSearchResponse>(false);
            _doSearchResponseInstance = _doSearchResponseInstanceFixture ?? this.Create<DoSearchResponse>(true);
            CurrentInstance = _doSearchResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoSearchResponse) Initializer

        #region Fields

        private const string FieldDoSearchResult = "DoSearchResult";
        private const string FieldlookupResponse = "lookupResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoSearchResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoSearchResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoSearchResponse)

        #region General Initializer : Class (DoSearchResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoSearchResult)]
        [TestCase(FieldlookupResponse)]
        [Category("AUT Fields")]
        public void AUT_DoSearchResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoSearchResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoSearchResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doSearchResponseInstanceType.ShouldNotBeNull();
            _doSearchResponseInstance.ShouldNotBeNull();
            _doSearchResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoSearchResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoSearchResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doSearchResponseInstance.ShouldBeAssignableTo<DoSearchResponse>();
            _doSearchResponseInstanceFixture.ShouldBeAssignableTo<DoSearchResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoSearchResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoSearchResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoSearchResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoSearchResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            DoSearchResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoSearchResponse(DoSearchResult, lookupResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doSearchResponseInstance.ShouldNotBeNull();
            _doSearchResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoSearchResponse>();
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoSearchResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            DoSearchResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoSearchResponse(DoSearchResult, lookupResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doSearchResponseInstance.ShouldNotBeNull();
            _doSearchResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Is_Created_Test()
        {
            // Assert
            _doSearchResponseInstance.ShouldNotBeNull();
            _doSearchResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoSearchResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoSearchResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoSearchResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoSearchResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoSearchResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoSearchResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoSearchResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoSearchResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoSearchResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoSearchResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}