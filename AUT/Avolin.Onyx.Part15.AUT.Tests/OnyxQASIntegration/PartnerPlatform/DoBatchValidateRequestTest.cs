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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoBatchValidateRequestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoBatchValidateRequest" />)
        /// </summary>
        public DoBatchValidateRequestTest() : base(typeof(DoBatchValidateRequest))
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

        #region General Initializer : Class (DoBatchValidateRequest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doBatchValidateRequestInstanceType;
        private DoBatchValidateRequest _doBatchValidateRequestInstance;
        private DoBatchValidateRequest _doBatchValidateRequestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoBatchValidateRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doBatchValidateRequestInstanceType = typeof(DoBatchValidateRequest);
            _doBatchValidateRequestInstanceFixture = this.Create<DoBatchValidateRequest>(false);
            _doBatchValidateRequestInstance = _doBatchValidateRequestInstanceFixture ?? this.Create<DoBatchValidateRequest>(true);
            CurrentInstance = _doBatchValidateRequestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoBatchValidateRequest) Initializer

        #region Fields

        private const string FieldauthenticationHeader = "authenticationHeader";
        private const string FieldbatchRequest = "batchRequest";

        #endregion

        #endregion

        #region General Initializer : Class (DoBatchValidateRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoBatchValidateRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoBatchValidateRequest)

        #region General Initializer : Class (DoBatchValidateRequest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldauthenticationHeader)]
        [TestCase(FieldbatchRequest)]
        [Category("AUT Fields")]
        public void AUT_DoBatchValidateRequest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoBatchValidateRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchValidateRequest_Is_Instance_Present_Test()
        {
            // Assert
            _doBatchValidateRequestInstanceType.ShouldNotBeNull();
            _doBatchValidateRequestInstance.ShouldNotBeNull();
            _doBatchValidateRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoBatchValidateRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchValidateRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doBatchValidateRequestInstance.ShouldBeAssignableTo<DoBatchValidateRequest>();
            _doBatchValidateRequestInstanceFixture.ShouldBeAssignableTo<DoBatchValidateRequest>();
            CurrentInstance.ShouldBeAssignableTo<DoBatchValidateRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoBatchValidateRequest) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoBatchValidateRequest instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            DoBatchValidateRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchValidateRequest(authenticationHeader, batchRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchValidateRequestInstance.ShouldNotBeNull();
            _doBatchValidateRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoBatchValidateRequest>();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            DoBatchValidateRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchValidateRequest(authenticationHeader, batchRequest);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchValidateRequestInstance.ShouldNotBeNull();
            _doBatchValidateRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) instance created

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Is_Created_Test()
        {
            // Assert
            _doBatchValidateRequestInstance.ShouldNotBeNull();
            _doBatchValidateRequestInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoBatchValidateRequest" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoBatchValidateRequest_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoBatchValidateRequest) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoBatchValidateRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchValidateRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoBatchValidateRequestParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchValidateRequestParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateRequest) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchValidateRequest" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateRequest_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoBatchValidateRequestParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchRequest) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchValidateRequestParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}