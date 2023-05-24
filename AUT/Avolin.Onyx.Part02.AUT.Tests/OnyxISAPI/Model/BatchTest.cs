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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Batch" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BatchTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Batch" />)
        /// </summary>
        public BatchTest() : base(typeof(Batch))
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

        #region General Initializer : Class (Batch) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _batchInstanceType;
        private Batch _batchInstance;
        private Batch _batchInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Batch" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _batchInstanceType = typeof(Batch);
            _batchInstanceFixture = this.Create<Batch>(false);
            _batchInstance = _batchInstanceFixture ?? this.Create<Batch>(true);
            CurrentInstance = _batchInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Batch) Initializer

        #region Methods

        private const string MethodGet = "Get";
        private const string MethodBatchUpdate = "BatchUpdate";
        private const string MethodBatchUpdateRecallDate = "BatchUpdateRecallDate";
        private const string MethodGetBatchUpdatableFields = "GetBatchUpdatableFields";
        private const string MethodGetLboObjectName = "GetLboObjectName";
        private const string MethodGetEntityName = "GetEntityName";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

        #endregion

        #endregion

        #region General Initializer : Class (Batch) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Batch" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Batch_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Batch) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Batch" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Batch_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Batch)

        #region General Initializer : Class (Batch) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Batch" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodBatchUpdate, 0)]
        [TestCase(MethodBatchUpdateRecallDate, 0)]
        [TestCase(MethodGetBatchUpdatableFields, 0)]
        [TestCase(MethodGetLboObjectName, 0)]
        [TestCase(MethodGetEntityName, 0)]
        public void AUT_Batch_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Batch) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Batch" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_Batch_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Batch) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Batch" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Batch_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _batchInstance.ShouldBeAssignableTo<Batch>();
            _batchInstanceFixture.ShouldBeAssignableTo<Batch>();
            CurrentInstance.ShouldBeAssignableTo<Batch>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfGet);
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
        public void AUT_Batch_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Batch_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Batch_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Batch_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (BatchUpdate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Batch_BatchUpdate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);

            // Act
            Action executeAction = () => _batchInstance.BatchUpdate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.BatchUpdate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;
            object[] parametersOfBatchUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, methodBatchUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfBatchUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdate.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;
            object[] parametersOfBatchUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            parametersOfBatchUpdate.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Batch_BatchUpdateRecallDate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);

            // Act
            Action executeAction = () => _batchInstance.BatchUpdateRecallDate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.BatchUpdateRecallDate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            Type [] methodBatchUpdateRecallDateParametersTypes = null;
            object[] parametersOfBatchUpdateRecallDate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfBatchUpdateRecallDate);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdateRecallDate.ShouldBeNull();
            methodBatchUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            Type [] methodBatchUpdateRecallDateParametersTypes = null;
            object[] parametersOfBatchUpdateRecallDate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            parametersOfBatchUpdateRecallDate.ShouldBeNull();
            methodBatchUpdateRecallDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            Type [] methodBatchUpdateRecallDateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            Type [] methodBatchUpdateRecallDateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Batch_GetBatchUpdatableFields_Method_Call_Internally(Type[] types)
        {
            var methodGetBatchUpdatableFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);

            // Act
            Action executeAction = () => _batchInstance.GetBatchUpdatableFields();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.GetBatchUpdatableFields();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            Type [] methodGetBatchUpdatableFieldsParametersTypes = null;
            object[] parametersOfGetBatchUpdatableFields = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfGetBatchUpdatableFields);
            var result2 = this.GetResultOfMethod<string>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBatchUpdatableFields.ShouldBeNull();
            methodGetBatchUpdatableFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            Type [] methodGetBatchUpdatableFieldsParametersTypes = null;
            object[] parametersOfGetBatchUpdatableFields = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdatableFields.ShouldBeNull();
            methodGetBatchUpdatableFieldsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            Type [] methodGetBatchUpdatableFieldsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdatableFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            Type [] methodGetBatchUpdatableFieldsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdatableFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Batch_GetLboObjectName_Method_Call_Internally(Type[] types)
        {
            var methodGetLboObjectNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetLboObjectName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityId = this.CreateType<int>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetLboObjectName = { entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfGetLboObjectName);
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
        public void AUT_Batch_GetLboObjectName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityId = this.CreateType<int>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetLboObjectName = { entityId };

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
        public void AUT_Batch_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };

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
        public void AUT_Batch_GetLboObjectName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
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
        public void AUT_Batch_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_Batch_GetLboObjectName_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_Batch_GetEntityName_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetEntityName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityId = this.CreateType<int>();
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetEntityName = { entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, methodGetEntityNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_batchInstanceFixture, parametersOfGetEntityName);
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
        public void AUT_Batch_GetEntityName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Batch_GetEntityName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Batch_GetEntityName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Batch_GetEntityName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_Batch_GetEntityName_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}