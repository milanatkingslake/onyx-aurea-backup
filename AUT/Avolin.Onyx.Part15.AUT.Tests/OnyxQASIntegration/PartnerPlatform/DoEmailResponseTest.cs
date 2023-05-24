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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoEmailResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoEmailResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoEmailResponse" />)
        /// </summary>
        public DoEmailResponseTest() : base(typeof(DoEmailResponse))
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

        #region General Initializer : Class (DoEmailResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doEmailResponseInstanceType;
        private DoEmailResponse _doEmailResponseInstance;
        private DoEmailResponse _doEmailResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoEmailResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doEmailResponseInstanceType = typeof(DoEmailResponse);
            _doEmailResponseInstanceFixture = this.Create<DoEmailResponse>(false);
            _doEmailResponseInstance = _doEmailResponseInstanceFixture ?? this.Create<DoEmailResponse>(true);
            CurrentInstance = _doEmailResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoEmailResponse) Initializer

        #region Fields

        private const string FieldDoEmailResult = "DoEmailResult";
        private const string FieldemailResponse = "emailResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoEmailResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoEmailResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoEmailResponse)

        #region General Initializer : Class (DoEmailResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoEmailResult)]
        [TestCase(FieldemailResponse)]
        [Category("AUT Fields")]
        public void AUT_DoEmailResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoEmailResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoEmailResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doEmailResponseInstanceType.ShouldNotBeNull();
            _doEmailResponseInstance.ShouldNotBeNull();
            _doEmailResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoEmailResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoEmailResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doEmailResponseInstance.ShouldBeAssignableTo<DoEmailResponse>();
            _doEmailResponseInstanceFixture.ShouldBeAssignableTo<DoEmailResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoEmailResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoEmailResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoEmailResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoEmailResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();
            DoEmailResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoEmailResponse(DoEmailResult, emailResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doEmailResponseInstance.ShouldNotBeNull();
            _doEmailResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoEmailResponse>();
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoEmailResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();
            DoEmailResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoEmailResponse(DoEmailResult, emailResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doEmailResponseInstance.ShouldNotBeNull();
            _doEmailResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Is_Created_Test()
        {
            // Assert
            _doEmailResponseInstance.ShouldNotBeNull();
            _doEmailResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoEmailResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoEmailResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoEmailResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoEmailResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoEmailResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoEmailResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoEmailResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoEmailResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoEmailResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}