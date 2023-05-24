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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoEmailRequest" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoEmailRequestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoEmailRequest" />)
        /// </summary>
        public DoEmailRequestTest() : base(typeof(DoEmailRequest))
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

        #region General Initializer : Class (DoEmailRequest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doEmailRequestInstanceType;
        private DoEmailRequest _doEmailRequestInstance;
        private DoEmailRequest _doEmailRequestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoEmailRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doEmailRequestInstanceType = typeof(DoEmailRequest);
            _doEmailRequestInstanceFixture = this.Create<DoEmailRequest>(false);
            _doEmailRequestInstance = _doEmailRequestInstanceFixture ?? this.Create<DoEmailRequest>(true);
            CurrentInstance = _doEmailRequestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoEmailRequest) Initializer

        #region Fields

        private const string FieldauthenticationHeader = "authenticationHeader";
        private const string FieldemailRequest = "emailRequest";

        #endregion

        #endregion

        #region General Initializer : Class (DoEmailRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoEmailRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoEmailRequest)

        #region General Initializer : Class (DoEmailRequest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldauthenticationHeader)]
        [TestCase(FieldemailRequest)]
        [Category("AUT Fields")]
        public void AUT_DoEmailRequest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoEmailRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoEmailRequest_Is_Instance_Present_Test()
        {
            // Assert
            _doEmailRequestInstanceType.ShouldNotBeNull();
            _doEmailRequestInstance.ShouldNotBeNull();
            _doEmailRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoEmailRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoEmailRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doEmailRequestInstance.ShouldBeAssignableTo<DoEmailRequest>();
            _doEmailRequestInstanceFixture.ShouldBeAssignableTo<DoEmailRequest>();
            CurrentInstance.ShouldBeAssignableTo<DoEmailRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoEmailRequest) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoEmailRequest instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            DoEmailRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoEmailRequest(authenticationHeader, emailRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doEmailRequestInstance.ShouldNotBeNull();
            _doEmailRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoEmailRequest>();
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            DoEmailRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoEmailRequest(authenticationHeader, emailRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doEmailRequestInstance.ShouldNotBeNull();
            _doEmailRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) instance created

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Is_Created_Test()
        {
            // Assert
            _doEmailRequestInstance.ShouldNotBeNull();
            _doEmailRequestInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoEmailRequest" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoEmailRequest_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoEmailRequest) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoEmailRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoEmailRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoEmailRequestParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoEmailRequestParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoEmailRequest) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoEmailRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailRequest_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoEmailRequestParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailRequest) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoEmailRequestParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}