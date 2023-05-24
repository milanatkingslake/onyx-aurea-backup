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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.DoRefineResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoRefineResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoRefineResponse" />)
        /// </summary>
        public DoRefineResponseTest() : base(typeof(DoRefineResponse))
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

        #region General Initializer : Class (DoRefineResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doRefineResponseInstanceType;
        private DoRefineResponse _doRefineResponseInstance;
        private DoRefineResponse _doRefineResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoRefineResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doRefineResponseInstanceType = typeof(DoRefineResponse);
            _doRefineResponseInstanceFixture = this.Create<DoRefineResponse>(false);
            _doRefineResponseInstance = _doRefineResponseInstanceFixture ?? this.Create<DoRefineResponse>(true);
            CurrentInstance = _doRefineResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoRefineResponse) Initializer

        #region Fields

        private const string FieldDoRefineResult = "DoRefineResult";
        private const string FieldlookupResponse = "lookupResponse";

        #endregion

        #endregion

        #region General Initializer : Class (DoRefineResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoRefineResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoRefineResponse)

        #region General Initializer : Class (DoRefineResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDoRefineResult)]
        [TestCase(FieldlookupResponse)]
        [Category("AUT Fields")]
        public void AUT_DoRefineResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoRefineResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoRefineResponse_Is_Instance_Present_Test()
        {
            // Assert
            _doRefineResponseInstanceType.ShouldNotBeNull();
            _doRefineResponseInstance.ShouldNotBeNull();
            _doRefineResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoRefineResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoRefineResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doRefineResponseInstance.ShouldBeAssignableTo<DoRefineResponse>();
            _doRefineResponseInstanceFixture.ShouldBeAssignableTo<DoRefineResponse>();
            CurrentInstance.ShouldBeAssignableTo<DoRefineResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoRefineResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DoRefineResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var DoRefineResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            DoRefineResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoRefineResponse(DoRefineResult, lookupResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doRefineResponseInstance.ShouldNotBeNull();
            _doRefineResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoRefineResponse>();
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var DoRefineResult = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.Information>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            DoRefineResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoRefineResponse(DoRefineResult, lookupResponse);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doRefineResponseInstance.ShouldNotBeNull();
            _doRefineResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) instance created

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Is_Created_Test()
        {
            // Assert
            _doRefineResponseInstance.ShouldNotBeNull();
            _doRefineResponseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DoRefineResponse" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DoRefineResponse_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DoRefineResponse) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DoRefineResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoRefineResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDoRefineResponseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoRefineResponseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DoRefineResponse) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DoRefineResponse" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoRefineResponse_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDoRefineResponseParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.Information), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDoRefineResponseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}