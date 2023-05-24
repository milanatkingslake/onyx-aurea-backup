using System;
using System.Collections;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.EntityBase" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class EntityBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EntityBase" />)
        /// </summary>
        public EntityBaseTest() : base(typeof(EntityBase))
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

        #region General Initializer : Class (EntityBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _entityBaseInstanceType;
        private EntityBase _entityBaseInstance;
        private EntityBase _entityBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EntityBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _entityBaseInstanceType = typeof(EntityBase);
            _entityBaseInstanceFixture = this.Create<EntityBase>(false);
            _entityBaseInstance = _entityBaseInstanceFixture ?? this.Create<EntityBase>(true);
            CurrentInstance = _entityBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EntityBase) Initializer

        #region Methods

        private const string MethodWatch = "Watch";
        private const string MethodGetWatchListByUserId = "GetWatchListByUserId";
        private const string MethodGetEntities = "GetEntities";
        private const string MethodUpdate = "Update";
        private const string MethodGet = "Get";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (EntityBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EntityBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EntityBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EntityBase) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EntityBase" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EntityBase_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EntityBase)

        #region General Initializer : Class (EntityBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="EntityBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodWatch, 0)]
        [TestCase(MethodGetWatchListByUserId, 0)]
        [TestCase(MethodGetEntities, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodGet, 0)]
        public void AUT_EntityBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (EntityBase) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="EntityBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_EntityBase_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EntityBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EntityBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EntityBase_Is_Instance_Present_Test()
        {
            // Assert
            _entityBaseInstanceType.ShouldNotBeNull();
            _entityBaseInstance.ShouldNotBeNull();
            _entityBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EntityBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EntityBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EntityBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _entityBaseInstance.ShouldBeAssignableTo<EntityBase>();
            _entityBaseInstanceFixture.ShouldBeAssignableTo<EntityBase>();
            CurrentInstance.ShouldBeAssignableTo<EntityBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EntityBase) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EntityBase_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            EntityBase instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new EntityBase(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _entityBaseInstance.ShouldNotBeNull();
            _entityBaseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<EntityBase>();
        }

        #endregion

        #region General Constructor : Class (EntityBase) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EntityBase_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            EntityBase instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new EntityBase(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _entityBaseInstance.ShouldNotBeNull();
            _entityBaseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Watch) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);

            // Act
            Action executeAction = () => _entityBaseInstance.Watch();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityBaseInstance.Watch();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            Type [] methodWatchParametersTypes = null;
            object[] parametersOfWatch = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWatch, methodWatchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityBaseInstanceFixture, parametersOfWatch);
            var result2 = this.GetResultOfMethod<string>(MethodWatch, parametersOfWatch, methodWatchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfWatch.ShouldBeNull();
            methodWatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            Type [] methodWatchParametersTypes = null;
            object[] parametersOfWatch = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodWatch, parametersOfWatch, methodWatchParametersTypes);

            // Assert
            parametersOfWatch.ShouldBeNull();
            methodWatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            Type [] methodWatchParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWatch, methodWatchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodWatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            Type [] methodWatchParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWatch, methodWatchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Watch) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Watch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatch);
            var currentMethodInfo = this.GetMethodInfo(MethodWatch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EntityBase_GetWatchListByUserId_Method_Call_Internally(Type[] types)
        {
            var methodGetWatchListByUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);

            // Act
            Action executeAction = () => _entityBaseInstance.GetWatchListByUserId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityBaseInstance.GetWatchListByUserId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            Type [] methodGetWatchListByUserIdParametersTypes = null;
            object[] parametersOfGetWatchListByUserId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityBaseInstanceFixture, parametersOfGetWatchListByUserId);
            var result2 = this.GetResultOfMethod<string>(MethodGetWatchListByUserId, parametersOfGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWatchListByUserId.ShouldBeNull();
            methodGetWatchListByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            Type [] methodGetWatchListByUserIdParametersTypes = null;
            object[] parametersOfGetWatchListByUserId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWatchListByUserId, parametersOfGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes);

            // Assert
            parametersOfGetWatchListByUserId.ShouldBeNull();
            methodGetWatchListByUserIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            Type [] methodGetWatchListByUserIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWatchListByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            Type [] methodGetWatchListByUserIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWatchListByUserId, methodGetWatchListByUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWatchListByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchListByUserId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetWatchListByUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchListByUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchListByUserId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EntityBase_GetEntities_Method_Call_Internally(Type[] types)
        {
            var methodGetEntitiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntities, methodGetEntitiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);

            // Act
            Action executeAction = () => _entityBaseInstance.GetEntities();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityBaseInstance.GetEntities();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            Type [] methodGetEntitiesParametersTypes = null;
            object[] parametersOfGetEntities = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntities, methodGetEntitiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityBaseInstanceFixture, parametersOfGetEntities);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntities, parametersOfGetEntities, methodGetEntitiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntities.ShouldBeNull();
            methodGetEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            Type [] methodGetEntitiesParametersTypes = null;
            object[] parametersOfGetEntities = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntities, parametersOfGetEntities, methodGetEntitiesParametersTypes);

            // Assert
            parametersOfGetEntities.ShouldBeNull();
            methodGetEntitiesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            Type [] methodGetEntitiesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntities, methodGetEntitiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            Type [] methodGetEntitiesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntities, methodGetEntitiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntities) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_GetEntities_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntities);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntities, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EntityBase_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _entityBaseInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _entityBaseInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityBaseInstanceFixture, parametersOfUpdate);
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
        public void AUT_EntityBase_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_EntityBase_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_EntityBase_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_EntityBase_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (Get) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EntityBase_Get_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_entityBaseInstanceFixture, parametersOfGet);
            var result2 = this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EntityBase_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            var currentMethodInfo = this.GetMethodInfo(MethodGet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}