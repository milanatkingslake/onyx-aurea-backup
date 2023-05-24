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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoSearchRequest" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoSearchRequestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoSearchRequest" />)
        /// </summary>
        public DoSearchRequestTest() : base(typeof(DoSearchRequest))
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

        #region General Initializer : Class (DoSearchRequest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doSearchRequestInstanceType;
        private DoSearchRequest _doSearchRequestInstance;
        private DoSearchRequest _doSearchRequestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoSearchRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doSearchRequestInstanceType = typeof(DoSearchRequest);
            _doSearchRequestInstanceFixture = this.Create<DoSearchRequest>(false);
            _doSearchRequestInstance = _doSearchRequestInstanceFixture ?? this.Create<DoSearchRequest>(true);
            CurrentInstance = _doSearchRequestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoSearchRequest) Initializer

        #region Fields

        private const string FieldauthenticationHeader = "authenticationHeader";
        private const string FieldlookupRequest = "lookupRequest";

        #endregion

        #endregion

        #region General Initializer : Class (DoSearchRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoSearchRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoSearchRequest)

        #region General Initializer : Class (DoSearchRequest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldauthenticationHeader)]
        [TestCase(FieldlookupRequest)]
        [Category("AUT Fields")]
        public void AUT_DoSearchRequest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoSearchRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoSearchRequest_Is_Instance_Present_Test()
        {
            // Assert
            _doSearchRequestInstanceType.ShouldNotBeNull();
            _doSearchRequestInstance.ShouldNotBeNull();
            _doSearchRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoSearchRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoSearchRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doSearchRequestInstance.ShouldBeAssignableTo<DoSearchRequest>();
            _doSearchRequestInstanceFixture.ShouldBeAssignableTo<DoSearchRequest>();
            CurrentInstance.ShouldBeAssignableTo<DoSearchRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoSearchRequest) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoSearchRequest instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            DoSearchRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoSearchRequest(authenticationHeader, lookupRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doSearchRequestInstance.ShouldNotBeNull();
            _doSearchRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoSearchRequest>();
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            DoSearchRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoSearchRequest(authenticationHeader, lookupRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doSearchRequestInstance.ShouldNotBeNull();
            _doSearchRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) instance created

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Is_Created_Test()
        {
            // Assert
            _doSearchRequestInstance.ShouldNotBeNull();
            _doSearchRequestInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoSearchRequest" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoSearchRequest_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoSearchRequest) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoSearchRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoSearchRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoSearchRequestParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoSearchRequestParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoSearchRequest) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoSearchRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoSearchRequest_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoSearchRequestParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoSearchRequestParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}