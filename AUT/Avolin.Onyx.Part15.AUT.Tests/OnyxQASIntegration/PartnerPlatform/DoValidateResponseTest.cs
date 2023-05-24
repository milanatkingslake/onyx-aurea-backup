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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoValidateResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoValidateResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoValidateResponse" />)
        /// </summary>
        public DoValidateResponseTest() : base(typeof(DoValidateResponse))
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

        #region General Initializer : Class (DoValidateResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doValidateResponseInstanceType;
        private DoValidateResponse _doValidateResponseInstance;
        private DoValidateResponse _doValidateResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoValidateResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doValidateResponseInstanceType = typeof(DoValidateResponse);
            _doValidateResponseInstanceFixture = this.Create<DoValidateResponse>(false);
            _doValidateResponseInstance = _doValidateResponseInstanceFixture ?? this.Create<DoValidateResponse>(true);
            CurrentInstance = _doValidateResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoValidateResponse) Initializer

        #region Fields

        private const string FieldDoValidateResult = "DoValidateResult";
        private const string FieldvalidateResponse = "validateResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoValidateResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoValidateResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoValidateResponse)

        #region General Initializer : Class (DoValidateResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoValidateResult)]
        [TestCase(FieldvalidateResponse)]
        [Category("AUT Fields")]
        public void AUT_DoValidateResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoValidateResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoValidateResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doValidateResponseInstanceType.ShouldNotBeNull();
            _doValidateResponseInstance.ShouldNotBeNull();
            _doValidateResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoValidateResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoValidateResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doValidateResponseInstance.ShouldBeAssignableTo<DoValidateResponse>();
            _doValidateResponseInstanceFixture.ShouldBeAssignableTo<DoValidateResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoValidateResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoValidateResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoValidateResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoValidateResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();
            DoValidateResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoValidateResponse(DoValidateResult, validateResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doValidateResponseInstance.ShouldNotBeNull();
            _doValidateResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoValidateResponse>();
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoValidateResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();
            DoValidateResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoValidateResponse(DoValidateResult, validateResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doValidateResponseInstance.ShouldNotBeNull();
            _doValidateResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Is_Created_Test()
        {
            // Assert
            _doValidateResponseInstance.ShouldNotBeNull();
            _doValidateResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoValidateResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoValidateResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoValidateResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoValidateResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoValidateResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoValidateResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoValidateResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoValidateResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoValidateResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}