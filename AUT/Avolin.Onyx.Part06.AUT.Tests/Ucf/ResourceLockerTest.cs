using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.ResourceLocker" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResourceLockerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResourceLocker" />)
        /// </summary>
        public ResourceLockerTest() : base(typeof(ResourceLocker))
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

        #region General Initializer : Class (ResourceLocker) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resourceLockerInstanceType;
        private ResourceLocker _resourceLockerInstance;
        private ResourceLocker _resourceLockerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResourceLocker" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resourceLockerInstanceType = typeof(ResourceLocker);
            _resourceLockerInstanceFixture = this.Create<ResourceLocker>(false);
            _resourceLockerInstance = _resourceLockerInstanceFixture ?? this.Create<ResourceLocker>(true);
            CurrentInstance = _resourceLockerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResourceLocker) Initializer

        #region Methods

        private const string MethodTryLock = "TryLock";
        private const string MethodReleaseLock = "ReleaseLock";
        private const string MethodHashString = "HashString";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Field_resourceMutex = "_resourceMutex";
        private const string Field_resourcePath = "_resourcePath";
        private const string Field_resourceHash = "_resourceHash";
        private const string Field_locked = "_locked";

        #endregion

        #endregion

        #region General Initializer : Class (ResourceLocker) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResourceLocker_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResourceLocker) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResourceLocker_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResourceLocker)

        #region General Initializer : Class (ResourceLocker) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTryLock, 0)]
        [TestCase(MethodTryLock, 1)]
        [TestCase(MethodReleaseLock, 0)]
        [TestCase(MethodHashString, 0)]
        public void AUT_ResourceLocker_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ResourceLocker) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_resourceMutex)]
        [TestCase(Field_resourcePath)]
        [TestCase(Field_resourceHash)]
        [TestCase(Field_locked)]
        [Category("AUT Fields")]
        public void AUT_ResourceLocker_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResourceLocker) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResourceLocker_Is_Instance_Present_Test()
        {
            // Assert
            _resourceLockerInstanceType.ShouldNotBeNull();
            _resourceLockerInstance.ShouldNotBeNull();
            _resourceLockerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResourceLocker) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResourceLocker" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResourceLocker_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resourceLockerInstance.ShouldBeAssignableTo<ResourceLocker>();
            _resourceLockerInstanceFixture.ShouldBeAssignableTo<ResourceLocker>();
            CurrentInstance.ShouldBeAssignableTo<ResourceLocker>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResourceLocker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResourceLocker_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var resourcePath = this.CreateType<string>();
            ResourceLocker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResourceLocker(resourcePath);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _resourceLockerInstance.ShouldNotBeNull();
            _resourceLockerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ResourceLocker>();
        }

        #endregion

        #region General Constructor : Class (ResourceLocker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResourceLocker_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var resourcePath = this.CreateType<string>();
            ResourceLocker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResourceLocker(resourcePath);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _resourceLockerInstance.ShouldNotBeNull();
            _resourceLockerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (TryLock) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ResourceLocker_TryLock_Method_Call_Internally(Type[] types)
        {
            var methodTryLockParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);

            // Act
            Action executeAction = () => _resourceLockerInstance.TryLock();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;
            object[] parametersOfTryLock = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_resourceLockerInstanceFixture, parametersOfTryLock);
            var result2 = this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryLock.ShouldBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;
            object[] parametersOfTryLock = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_resourceLockerInstanceFixture, out exception1, parametersOfTryLock);
            var result2 = this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryLock.ShouldBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;
            object[] parametersOfTryLock = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_resourceLockerInstanceFixture, parametersOfTryLock);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryLock.ShouldBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;
            object[] parametersOfTryLock = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            parametersOfTryLock.ShouldBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryLockParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            Type [] methodTryLockParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryLockParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ResourceLocker_TryLock_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodTryLockParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var waitMilliseconds = this.CreateType<int>();

            // Act
            Action executeAction = () => _resourceLockerInstance.TryLock(waitMilliseconds);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var waitMilliseconds = this.CreateType<int>();
            var methodTryLockParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfTryLock = { waitMilliseconds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_resourceLockerInstanceFixture, parametersOfTryLock);
            var result2 = this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryLock.ShouldNotBeNull();
            parametersOfTryLock.Length.ShouldBe(1);
            methodTryLockParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var waitMilliseconds = this.CreateType<int>();
            var methodTryLockParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfTryLock = { waitMilliseconds };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_resourceLockerInstanceFixture, out exception1, parametersOfTryLock);
            var result2 = this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryLock.ShouldNotBeNull();
            parametersOfTryLock.Length.ShouldBe(1);
            methodTryLockParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var waitMilliseconds = this.CreateType<int>();
            var methodTryLockParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfTryLock = { waitMilliseconds };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, methodTryLockParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_resourceLockerInstanceFixture, parametersOfTryLock);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryLock.ShouldNotBeNull();
            parametersOfTryLock.Length.ShouldBe(1);
            methodTryLockParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var waitMilliseconds = this.CreateType<int>();
            var methodTryLockParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfTryLock = { waitMilliseconds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodTryLock, parametersOfTryLock, methodTryLockParametersTypes);

            // Assert
            parametersOfTryLock.ShouldNotBeNull();
            parametersOfTryLock.Length.ShouldBe(1);
            methodTryLockParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var methodTryLockParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryLockParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var methodTryLockParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryLockParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var methodTryLockParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryLock, methodTryLockParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryLockParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryLock) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_TryLock_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryLock);
            var currentMethodInfo = this.GetMethodInfo(MethodTryLock, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ResourceLocker_ReleaseLock_Method_Call_Internally(Type[] types)
        {
            var methodReleaseLockParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReleaseLock, methodReleaseLockParametersTypes);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_ReleaseLock_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReleaseLock);

            // Act
            Action executeAction = () => _resourceLockerInstance.ReleaseLock();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_ReleaseLock_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReleaseLock);
            Type [] methodReleaseLockParametersTypes = null;
            object[] parametersOfReleaseLock = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodReleaseLock, methodReleaseLockParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_resourceLockerInstanceFixture, parametersOfReleaseLock);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReleaseLock.ShouldBeNull();
            methodReleaseLockParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_ReleaseLock_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReleaseLock);
            Type [] methodReleaseLockParametersTypes = null;
            object[] parametersOfReleaseLock = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodReleaseLock, parametersOfReleaseLock, methodReleaseLockParametersTypes);

            // Assert
            parametersOfReleaseLock.ShouldBeNull();
            methodReleaseLockParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_ReleaseLock_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReleaseLock);
            Type [] methodReleaseLockParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReleaseLock, methodReleaseLockParametersTypes);

            // Assert
            methodReleaseLockParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReleaseLock) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_ReleaseLock_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReleaseLock);
            var currentMethodInfo = this.GetMethodInfo(MethodReleaseLock, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ResourceLocker_HashString_Method_Call_Internally(Type[] types)
        {
            var methodHashStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHashString, methodHashStringParametersTypes);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var stringToHash = this.CreateType<string>();
            var methodHashStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHashString = { stringToHash };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHashString, methodHashStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_resourceLockerInstanceFixture, out exception1, parametersOfHashString);
            var result2 = this.GetResultOfMethod<string>(MethodHashString, parametersOfHashString, methodHashStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHashString.ShouldNotBeNull();
            parametersOfHashString.Length.ShouldBe(1);
            methodHashStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var stringToHash = this.CreateType<string>();
            var methodHashStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHashString = { stringToHash };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodHashString, methodHashStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_resourceLockerInstanceFixture, parametersOfHashString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfHashString.ShouldNotBeNull();
            parametersOfHashString.Length.ShouldBe(1);
            methodHashStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var stringToHash = this.CreateType<string>();
            var methodHashStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHashString = { stringToHash };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodHashString, parametersOfHashString, methodHashStringParametersTypes);

            // Assert
            parametersOfHashString.ShouldNotBeNull();
            parametersOfHashString.Length.ShouldBe(1);
            methodHashStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var methodHashStringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodHashString, methodHashStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodHashStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var methodHashStringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHashString, methodHashStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHashStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var currentMethodInfo = this.GetMethodInfo(MethodHashString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (HashString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ResourceLocker_HashString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHashString);
            var currentMethodInfo = this.GetMethodInfo(MethodHashString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ResourceLocker_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}