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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoBatchValidateResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoBatchValidateResponse" />)
        /// </summary>
        public DoBatchValidateResponseTest() : base(typeof(DoBatchValidateResponse))
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

        #region General Initializer : Class (DoBatchValidateResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doBatchValidateResponseInstanceType;
        private DoBatchValidateResponse _doBatchValidateResponseInstance;
        private DoBatchValidateResponse _doBatchValidateResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoBatchValidateResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doBatchValidateResponseInstanceType = typeof(DoBatchValidateResponse);
            _doBatchValidateResponseInstanceFixture = this.Create<DoBatchValidateResponse>(false);
            _doBatchValidateResponseInstance = _doBatchValidateResponseInstanceFixture ?? this.Create<DoBatchValidateResponse>(true);
            CurrentInstance = _doBatchValidateResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoBatchValidateResponse) Initializer

        #region Fields

        private const string FieldDoBatchValidateResult = "DoBatchValidateResult";
        private const string FieldbatchResponse = "batchResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoBatchValidateResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoBatchValidateResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoBatchValidateResponse)

        #region General Initializer : Class (DoBatchValidateResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoBatchValidateResult)]
        [TestCase(FieldbatchResponse)]
        [Category("AUT Fields")]
        public void AUT_DoBatchValidateResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoBatchValidateResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchValidateResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doBatchValidateResponseInstanceType.ShouldNotBeNull();
            _doBatchValidateResponseInstance.ShouldNotBeNull();
            _doBatchValidateResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoBatchValidateResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchValidateResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doBatchValidateResponseInstance.ShouldBeAssignableTo<DoBatchValidateResponse>();
            _doBatchValidateResponseInstanceFixture.ShouldBeAssignableTo<DoBatchValidateResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoBatchValidateResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoBatchValidateResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoBatchValidateResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoBatchValidateResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();
            DoBatchValidateResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchValidateResponse(DoBatchValidateResult, batchResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchValidateResponseInstance.ShouldNotBeNull();
            _doBatchValidateResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoBatchValidateResponse>();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoBatchValidateResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();
            DoBatchValidateResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchValidateResponse(DoBatchValidateResult, batchResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchValidateResponseInstance.ShouldNotBeNull();
            _doBatchValidateResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Is_Created_Test()
        {
            // Assert
            _doBatchValidateResponseInstance.ShouldNotBeNull();
            _doBatchValidateResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoBatchValidateResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoBatchValidateResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoBatchValidateResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoBatchValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoBatchValidateResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchValidateResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoBatchValidateResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchValidateResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchValidateResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoBatchValidateResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchValidateResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}