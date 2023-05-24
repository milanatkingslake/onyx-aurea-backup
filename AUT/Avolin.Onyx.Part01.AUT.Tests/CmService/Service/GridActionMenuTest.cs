using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.GridActionMenu" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\GridActionMenu.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GridActionMenuTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GridActionMenu" />)
        /// </summary>
        public GridActionMenuTest() : base(typeof(GridActionMenu))
        { }

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

        #region General Initializer : Class (GridActionMenu) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _gridActionMenuInstanceType;
        private GridActionMenu _gridActionMenuInstance;
        private GridActionMenu _gridActionMenuInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GridActionMenu" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _gridActionMenuInstanceType = typeof(GridActionMenu);
            _gridActionMenuInstanceFixture = this.Create<GridActionMenu>(false);
            _gridActionMenuInstance = _gridActionMenuInstanceFixture ?? this.Create<GridActionMenu>(true);
            CurrentInstance = _gridActionMenuInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GridActionMenu) Initializer

        #region Methods

        private const string MethodGetGamConfiguration = "GetGamConfiguration";

        #endregion

        #endregion

        #region General Initializer : Class (GridActionMenu) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GridActionMenu_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GridActionMenu)

        #region General Initializer : Class (GridActionMenu) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetGamConfiguration, 0)]
        public void AUT_GridActionMenu_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region General Instance : Class (GridActionMenu) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GridActionMenu_Is_Instance_Present_Test()
        {
            // Assert
            _gridActionMenuInstanceType.ShouldNotBeNull();
            _gridActionMenuInstance.ShouldNotBeNull();
            _gridActionMenuInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GridActionMenu) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GridActionMenu_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _gridActionMenuInstance.ShouldBeAssignableTo<GridActionMenu>();
            _gridActionMenuInstanceFixture.ShouldBeAssignableTo<GridActionMenu>();
            CurrentInstance.ShouldBeAssignableTo<GridActionMenu>();
        }

        #endregion

        #region General Constructor : Class (GridActionMenu) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GridActionMenu_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            GridActionMenu instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Test Try-Catch Verify Exception Throw - Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT TryCatch")]
        public void AUT_GridActionMenu_GetGamConfiguration_Try_Catch_Should_Not_Throw_Exception()
        {
            // Arrange
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(Message) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _gridActionMenuInstance.GetGamConfiguration(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _gridActionMenuInstance.GetGamConfiguration(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var message = this.CreateType<Message>();
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetGamConfiguration = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_gridActionMenuInstanceFixture, parametersOfGetGamConfiguration);
            var result2 = this.GetResultOfMethod<Message>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGamConfiguration.ShouldNotBeNull();
            parametersOfGetGamConfiguration.Length.ShouldBe(1);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var message = this.CreateType<Message>();
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetGamConfiguration = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            parametersOfGetGamConfiguration.ShouldNotBeNull();
            parametersOfGetGamConfiguration.Length.ShouldBe(1);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}