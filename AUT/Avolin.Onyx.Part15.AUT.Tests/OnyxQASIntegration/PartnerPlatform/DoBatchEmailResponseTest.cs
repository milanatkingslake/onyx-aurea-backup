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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoBatchEmailResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoBatchEmailResponse" />)
        /// </summary>
        public DoBatchEmailResponseTest() : base(typeof(DoBatchEmailResponse))
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

        #region General Initializer : Class (DoBatchEmailResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doBatchEmailResponseInstanceType;
        private DoBatchEmailResponse _doBatchEmailResponseInstance;
        private DoBatchEmailResponse _doBatchEmailResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoBatchEmailResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doBatchEmailResponseInstanceType = typeof(DoBatchEmailResponse);
            _doBatchEmailResponseInstanceFixture = this.Create<DoBatchEmailResponse>(false);
            _doBatchEmailResponseInstance = _doBatchEmailResponseInstanceFixture ?? this.Create<DoBatchEmailResponse>(true);
            CurrentInstance = _doBatchEmailResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoBatchEmailResponse) Initializer

        #region Fields

        private const string FieldDoBatchEmailResult = "DoBatchEmailResult";
        private const string FieldemailBatchResponse = "emailBatchResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoBatchEmailResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoBatchEmailResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoBatchEmailResponse)

        #region General Initializer : Class (DoBatchEmailResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoBatchEmailResult)]
        [TestCase(FieldemailBatchResponse)]
        [Category("AUT Fields")]
        public void AUT_DoBatchEmailResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoBatchEmailResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchEmailResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doBatchEmailResponseInstanceType.ShouldNotBeNull();
            _doBatchEmailResponseInstance.ShouldNotBeNull();
            _doBatchEmailResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoBatchEmailResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoBatchEmailResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doBatchEmailResponseInstance.ShouldBeAssignableTo<DoBatchEmailResponse>();
            _doBatchEmailResponseInstanceFixture.ShouldBeAssignableTo<DoBatchEmailResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoBatchEmailResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoBatchEmailResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoBatchEmailResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoBatchEmailResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();
            DoBatchEmailResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchEmailResponse(DoBatchEmailResult, emailBatchResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchEmailResponseInstance.ShouldNotBeNull();
            _doBatchEmailResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoBatchEmailResponse>();
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoBatchEmailResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();
            DoBatchEmailResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoBatchEmailResponse(DoBatchEmailResult, emailBatchResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doBatchEmailResponseInstance.ShouldNotBeNull();
            _doBatchEmailResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Is_Created_Test()
        {
            // Assert
            _doBatchEmailResponseInstance.ShouldNotBeNull();
            _doBatchEmailResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoBatchEmailResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoBatchEmailResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoBatchEmailResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoBatchEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoBatchEmailResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchEmailResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoBatchEmailResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoBatchEmailResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoBatchEmailResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoBatchEmailResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoBatchEmailResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}