using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Entity" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EntityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Entity" />)
        /// </summary>
        public EntityTest() : base(typeof(Entity))
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

        #region General Initializer : Class (Entity) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _entityInstanceType;
        private Entity _entityInstance;
        private Entity _entityInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Entity" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _entityInstanceType = typeof(Entity);
            _entityInstanceFixture = this.Create<Entity>(false);
            _entityInstance = _entityInstanceFixture ?? this.Create<Entity>(true);
            CurrentInstance = _entityInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Entity) Initializer

        #region Methods

        private const string MethodGetLboObjectName = "GetLboObjectName";
        private const string MethodGetEntityName = "GetEntityName";
        private const string MethodGetLboMethodName = "GetLboMethodName";
        private const string MethodGetEntityId = "GetEntityId";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

        #endregion

        #endregion

        #region General Initializer : Class (Entity) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Entity" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Entity_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Entity) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Entity" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Entity_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Entity)

        #region General Initializer : Class (Entity) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Entity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetLboObjectName, 0)]
        [TestCase(MethodGetEntityName, 0)]
        [TestCase(MethodGetLboMethodName, 0)]
        [TestCase(MethodGetEntityId, 0)]
        public void AUT_Entity_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Entity) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Entity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_Entity_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Entity) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Entity" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Entity_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _entityInstance.ShouldBeAssignableTo<Entity>();
            _entityInstanceFixture.ShouldBeAssignableTo<Entity>();
            CurrentInstance.ShouldBeAssignableTo<Entity>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetLboObjectName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _entityInstance.GetLboObjectName(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityInstance.GetLboObjectName(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityName = this.CreateType<string>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboObjectName = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityInstanceFixture, parametersOfGetLboObjectName);
            var result2 = this.GetResultOfMethod<string>(MethodGetLboObjectName, parametersOfGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboObjectName.ShouldNotBeNull();
            parametersOfGetLboObjectName.Length.ShouldBe(1);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityName = this.CreateType<string>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboObjectName = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLboObjectName, parametersOfGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            parametersOfGetLboObjectName.ShouldNotBeNull();
            parametersOfGetLboObjectName.Length.ShouldBe(1);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboObjectName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Entity_GetEntityName_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityId = this.CreateType<int>();

            // Act
            Action executeAction = () => _entityInstance.GetEntityName(entityId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityId = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityInstance.GetEntityName(entityId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityId = this.CreateType<int>();
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetEntityName = { entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, methodGetEntityNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityInstanceFixture, parametersOfGetEntityName);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntityName, parametersOfGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityName.ShouldNotBeNull();
            parametersOfGetEntityName.Length.ShouldBe(1);
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityId = this.CreateType<int>();
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetEntityName = { entityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntityName, parametersOfGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            parametersOfGetEntityName.ShouldNotBeNull();
            parametersOfGetEntityName.Length.ShouldBe(1);
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Entity_GetLboMethodName_Method_Call_Internally(Type[] types)
        {
            var methodGetLboMethodNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboMethodName, methodGetLboMethodNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _entityInstance.GetLboMethodName(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var entityName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityInstance.GetLboMethodName(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var entityName = this.CreateType<string>();
            var methodGetLboMethodNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboMethodName = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethodName, methodGetLboMethodNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityInstanceFixture, parametersOfGetLboMethodName);
            var result2 = this.GetResultOfMethod<string>(MethodGetLboMethodName, parametersOfGetLboMethodName, methodGetLboMethodNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMethodName.ShouldNotBeNull();
            parametersOfGetLboMethodName.Length.ShouldBe(1);
            methodGetLboMethodNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var entityName = this.CreateType<string>();
            var methodGetLboMethodNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboMethodName = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLboMethodName, parametersOfGetLboMethodName, methodGetLboMethodNameParametersTypes);

            // Assert
            parametersOfGetLboMethodName.ShouldNotBeNull();
            parametersOfGetLboMethodName.Length.ShouldBe(1);
            methodGetLboMethodNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var methodGetLboMethodNameParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMethodName, methodGetLboMethodNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMethodNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var methodGetLboMethodNameParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMethodName, methodGetLboMethodNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMethodNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethodName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMethodName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetLboMethodName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethodName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethodName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Entity_GetEntityId_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityId, methodGetEntityIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _entityInstance.GetEntityId(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<Guid>();
            var methodGetEntityIdParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetEntityId = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, methodGetEntityIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_entityInstanceFixture, parametersOfGetEntityId);
            var result2 = this.GetResultOfMethod<int>(MethodGetEntityId, parametersOfGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEntityId.ShouldNotBeNull();
            parametersOfGetEntityId.Length.ShouldBe(1);
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<Guid>();
            var methodGetEntityIdParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetEntityId = { queryId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, methodGetEntityIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_entityInstanceFixture, out exception1, parametersOfGetEntityId);
            var result2 = this.GetResultOfMethod<int>(MethodGetEntityId, parametersOfGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEntityId.ShouldNotBeNull();
            parametersOfGetEntityId.Length.ShouldBe(1);
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<Guid>();
            var methodGetEntityIdParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetEntityId = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetEntityId, parametersOfGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            parametersOfGetEntityId.ShouldNotBeNull();
            parametersOfGetEntityId.Length.ShouldBe(1);
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var methodGetEntityIdParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Entity_GetEntityId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, 0);
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