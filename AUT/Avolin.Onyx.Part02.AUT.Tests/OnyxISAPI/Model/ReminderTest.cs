using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Reminder" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReminderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Reminder" />)
        /// </summary>
        public ReminderTest() : base(typeof(Reminder))
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

        #region General Initializer : Class (Reminder) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _reminderInstanceType;
        private Reminder _reminderInstance;
        private Reminder _reminderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Reminder" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reminderInstanceType = typeof(Reminder);
            _reminderInstanceFixture = this.Create<Reminder>(false);
            _reminderInstance = _reminderInstanceFixture ?? this.Create<Reminder>(true);
            CurrentInstance = _reminderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Reminder) Initializer

        #region Methods

        private const string MethodUpdate = "Update";
        private const string MethodBatchUpdate = "BatchUpdate";

        #endregion

        #endregion

        #region General Initializer : Class (Reminder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Reminder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Reminder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Reminder)

        #region General Initializer : Class (Reminder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Reminder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodBatchUpdate, 0)]
        public void AUT_Reminder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Reminder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Reminder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Reminder_Is_Instance_Present_Test()
        {
            // Assert
            _reminderInstanceType.ShouldNotBeNull();
            _reminderInstance.ShouldNotBeNull();
            _reminderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Reminder) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Reminder" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Reminder_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _reminderInstance.ShouldBeAssignableTo<Reminder>();
            _reminderInstanceFixture.ShouldBeAssignableTo<Reminder>();
            CurrentInstance.ShouldBeAssignableTo<Reminder>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Reminder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            Reminder instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Reminder(applicationName, sessionId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _reminderInstance.ShouldNotBeNull();
            _reminderInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Reminder>();
        }

        #endregion

        #region General Constructor : Class (Reminder) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            Reminder instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Reminder(applicationName, sessionId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _reminderInstance.ShouldNotBeNull();
            _reminderInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Reminder) instance created

        /// <summary>
        ///     Class (<see cref="Reminder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_Is_Created_Test()
        {
            // Assert
            _reminderInstance.ShouldNotBeNull();
            _reminderInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Reminder) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Reminder" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_Reminder_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (Reminder) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Reminder" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Reminder) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Reminder" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodReminderParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodReminderParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Reminder) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Reminder" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Reminder_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodReminderParametersTypes = new Type[] { typeof(Hashtable) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodReminderParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _reminderInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reminderInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reminderInstanceFixture, parametersOfUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Reminder_BatchUpdate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _reminderInstance.BatchUpdate(parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reminderInstance.BatchUpdate(parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfBatchUpdate = { parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, methodBatchUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reminderInstanceFixture, parametersOfBatchUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdate.ShouldNotBeNull();
            parametersOfBatchUpdate.Length.ShouldBe(1);
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfBatchUpdate = { parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            parametersOfBatchUpdate.ShouldNotBeNull();
            parametersOfBatchUpdate.Length.ShouldBe(1);
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Hashtable) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Reminder_BatchUpdate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}