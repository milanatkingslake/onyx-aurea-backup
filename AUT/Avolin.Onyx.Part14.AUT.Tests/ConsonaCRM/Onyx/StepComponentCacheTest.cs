using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepComponentCache" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepComponentCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepComponentCache" />)
        /// </summary>
        public StepComponentCacheTest() : base(typeof(StepComponentCache))
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

        #region General Initializer : Class (StepComponentCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepComponentCacheInstanceType;
        private StepComponentCache _stepComponentCacheInstance;
        private StepComponentCache _stepComponentCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepComponentCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepComponentCacheInstanceType = typeof(StepComponentCache);
            _stepComponentCacheInstanceFixture = this.Create<StepComponentCache>(false);
            _stepComponentCacheInstance = _stepComponentCacheInstanceFixture ?? this.Create<StepComponentCache>(true);
            CurrentInstance = _stepComponentCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepComponentCache) Initializer

        #region Properties

        private const string Propertyprefix = "prefix";

        #endregion

        #region Methods

        private const string MethodWrite = "Write";
        private const string MethodRead = "Read";
        private const string MethodRemove = "Remove";
        private const string MethodClear = "Clear";
        private const string MethodContainsKey = "ContainsKey";
        private const string MethodGetCacheKey = "GetCacheKey";

        #endregion

        #region Fields

        private const string Fieldm_hashTable = "m_hashTable";
        private const string Fieldm_prefix = "m_prefix";

        #endregion

        #endregion

        #region General Initializer : Class (StepComponentCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepComponentCache)

        #region General Initializer : Class (StepComponentCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodWrite, 0)]
        [TestCase(MethodRead, 0)]
        [TestCase(MethodRemove, 0)]
        [TestCase(MethodClear, 0)]
        [TestCase(MethodContainsKey, 0)]
        [TestCase(MethodGetCacheKey, 0)]
        public void AUT_StepComponentCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepComponentCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyprefix)]
        [Category("AUT Property")]
        public void AUT_StepComponentCache_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (StepComponentCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_hashTable)]
        [TestCase(Fieldm_prefix)]
        [Category("AUT Fields")]
        public void AUT_StepComponentCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepComponentCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentCache_Is_Instance_Present_Test()
        {
            // Assert
            _stepComponentCacheInstanceType.ShouldNotBeNull();
            _stepComponentCacheInstance.ShouldNotBeNull();
            _stepComponentCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepComponentCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepComponentCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepComponentCacheInstance.ShouldBeAssignableTo<StepComponentCache>();
            _stepComponentCacheInstanceFixture.ShouldBeAssignableTo<StepComponentCache>();
            CurrentInstance.ShouldBeAssignableTo<StepComponentCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepComponentCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psPrefix = this.CreateType<string>();
            StepComponentCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentCache(psPrefix);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentCacheInstance.ShouldNotBeNull();
            _stepComponentCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<StepComponentCache>();
        }

        #endregion

        #region General Constructor : Class (StepComponentCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psPrefix = this.CreateType<string>();
            StepComponentCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentCache(psPrefix);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentCacheInstance.ShouldNotBeNull();
            _stepComponentCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepComponentCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyprefix)]
        public void AUT_StepComponentCache_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentCache) => Property (prefix) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentCache_Public_Class_prefix_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyprefix);
            var propertyInfo = this.GetPropertyInfo(Propertyprefix);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Write) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var psName = this.CreateType<string>();
            var pValue = this.CreateType<object>();

            // Act
            Action executeAction = () => _stepComponentCacheInstance.Write(psName, pValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var psName = this.CreateType<string>();
            var pValue = this.CreateType<object>();
            var methodWriteParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfWrite = { psName, pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentCacheInstanceFixture, parametersOfWrite);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(2);
            methodWriteParametersTypes.Length.ShouldBe(2);
            methodWriteParametersTypes.Length.ShouldBe(parametersOfWrite.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var psName = this.CreateType<string>();
            var pValue = this.CreateType<object>();
            var methodWriteParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfWrite = { psName, pValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(2);
            methodWriteParametersTypes.Length.ShouldBe(2);
            methodWriteParametersTypes.Length.ShouldBe(parametersOfWrite.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Write) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            methodWriteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Write_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentCache_Read_Method_Call_Internally(Type[] types)
        {
            var methodReadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentCacheInstance.Read(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var psName = this.CreateType<string>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _stepComponentCacheInstance.Read(psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var psName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_stepComponentCacheInstanceFixture, parametersOfRead);
            var result2 = this.GetResultOfMethod<object>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var psName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Read_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentCache_Remove_Method_Call_Internally(Type[] types)
        {
            var methodRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentCacheInstance.Remove(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var psName = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { psName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentCacheInstanceFixture, parametersOfRemove);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var psName = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { psName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodRemoveParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);

            // Assert
            methodRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Remove_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentCache_Clear_Method_Call_Internally(Type[] types)
        {
            var methodClearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentCacheInstance.Clear(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var psName = this.CreateType<string>();
            var methodClearParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfClear = { psName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentCacheInstanceFixture, parametersOfClear);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClear.ShouldNotBeNull();
            parametersOfClear.Length.ShouldBe(1);
            methodClearParametersTypes.Length.ShouldBe(1);
            methodClearParametersTypes.Length.ShouldBe(parametersOfClear.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var psName = this.CreateType<string>();
            var methodClearParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfClear = { psName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            parametersOfClear.ShouldNotBeNull();
            parametersOfClear.Length.ShouldBe(1);
            methodClearParametersTypes.Length.ShouldBe(1);
            methodClearParametersTypes.Length.ShouldBe(parametersOfClear.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var currentMethodInfo = this.GetMethodInfo(MethodClear, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var methodClearParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            methodClearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_Clear_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var currentMethodInfo = this.GetMethodInfo(MethodClear, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentCache_ContainsKey_Method_Call_Internally(Type[] types)
        {
            var methodContainsKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentCacheInstance.ContainsKey(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var psName = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, methodContainsKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_stepComponentCacheInstanceFixture, parametersOfContainsKey);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var psName = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { psName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, methodContainsKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_stepComponentCacheInstanceFixture, out exception1, parametersOfContainsKey);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var psName = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContainsKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_ContainsKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentCache_GetCacheKey_Method_Call_Internally(Type[] types)
        {
            var methodGetCacheKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var psName = this.CreateType<string>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCacheKey = { psName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_stepComponentCacheInstanceFixture, out exception1, parametersOfGetCacheKey);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var psName = this.CreateType<string>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCacheKey = { psName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentCacheInstanceFixture, parametersOfGetCacheKey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var psName = this.CreateType<string>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCacheKey = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentCache_GetCacheKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);
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