using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.OnyxStepInterface" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxStepInterfaceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxStepInterface" />)
        /// </summary>
        public OnyxStepInterfaceTest() : base(typeof(OnyxStepInterface))
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

        #region General Initializer : Class (OnyxStepInterface) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxStepInterfaceInstanceType;
        private OnyxStepInterface _onyxStepInterfaceInstance;
        private OnyxStepInterface _onyxStepInterfaceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxStepInterface" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxStepInterfaceInstanceType = typeof(OnyxStepInterface);
            _onyxStepInterfaceInstanceFixture = this.Create<OnyxStepInterface>(false);
            _onyxStepInterfaceInstance = _onyxStepInterfaceInstanceFixture ?? this.Create<OnyxStepInterface>(true);
            CurrentInstance = _onyxStepInterfaceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxStepInterface) Initializer

        #region Methods

        private const string MethodExecuteMain = "ExecuteMain";
        private const string MethodHandleException = "HandleException";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxStepInterface) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxStepInterface" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxStepInterface_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxStepInterface)

        #region General Initializer : Class (OnyxStepInterface) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxStepInterface" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecuteMain, 0)]
        [TestCase(MethodHandleException, 0)]
        public void AUT_OnyxStepInterface_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxStepInterface) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxStepInterface" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxStepInterface_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxStepInterfaceInstance.ShouldBeAssignableTo<OnyxStepInterface>();
            _onyxStepInterfaceInstanceFixture.ShouldBeAssignableTo<OnyxStepInterface>();
            CurrentInstance.ShouldBeAssignableTo<OnyxStepInterface>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ExecuteMain) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_ExecuteMain_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMain);
            Type [] methodExecuteMainParametersTypes = null;
            object[] parametersOfExecuteMain = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteMain, methodExecuteMainParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxStepInterfaceInstanceFixture, parametersOfExecuteMain);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecuteMain.ShouldBeNull();
            methodExecuteMainParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMain) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_ExecuteMain_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMain);
            Type [] methodExecuteMainParametersTypes = null;
            object[] parametersOfExecuteMain = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecuteMain, parametersOfExecuteMain, methodExecuteMainParametersTypes);

            // Assert
            parametersOfExecuteMain.ShouldBeNull();
            methodExecuteMainParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMain) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_ExecuteMain_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMain);
            Type [] methodExecuteMainParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteMain, methodExecuteMainParametersTypes);

            // Assert
            methodExecuteMainParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMain) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_ExecuteMain_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMain);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteMain, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxStepInterface_HandleException_Method_Call_Internally(Type[] types)
        {
            var methodHandleExceptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHandleException, methodHandleExceptionParametersTypes);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_HandleException_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var e = this.CreateType<Exception>();
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfHandleException = { e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, methodHandleExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxStepInterfaceInstanceFixture, parametersOfHandleException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfHandleException.ShouldNotBeNull();
            parametersOfHandleException.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(parametersOfHandleException.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_HandleException_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var e = this.CreateType<Exception>();
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfHandleException = { e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodHandleException, parametersOfHandleException, methodHandleExceptionParametersTypes);

            // Assert
            parametersOfHandleException.ShouldNotBeNull();
            parametersOfHandleException.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(parametersOfHandleException.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_HandleException_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_HandleException_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHandleException, methodHandleExceptionParametersTypes);

            // Assert
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxStepInterface_HandleException_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}