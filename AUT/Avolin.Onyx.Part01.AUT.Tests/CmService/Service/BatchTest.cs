using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Batch" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Batch.cs"/>
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

        private const string MethodBatchUpdate = "BatchUpdate";
        private const string MethodBatchUpdateRecallDate = "BatchUpdateRecallDate";
        private const string MethodGetBatchUpdatableFields = "GetBatchUpdatableFields";

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

        #region Explore Class for Coverage Gain : Class (Batch)

        #region General Initializer : Class (Batch) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Batch" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodBatchUpdate, 0)]
        [TestCase(MethodBatchUpdateRecallDate, 0)]
        [TestCase(MethodGetBatchUpdatableFields, 0)]
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

        #endregion

        #region General Instance : Class (Batch) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Batch" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Batch_Is_Instance_Present_Test()
        {
            // Assert
            _batchInstanceType.ShouldNotBeNull();
            _batchInstance.ShouldNotBeNull();
            _batchInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Batch) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Batch" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
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

        #region General Constructor : Class (Batch) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Batch_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Batch instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _batchInstance.BatchUpdate(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.BatchUpdate(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var message = this.CreateType<Stream>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfBatchUpdate = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, methodBatchUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_batchInstanceFixture, parametersOfBatchUpdate);
            var result2 = this.GetResultOfMethod<Message>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

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

        #region Method Call : (BatchUpdate) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var message = this.CreateType<Stream>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfBatchUpdate = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            parametersOfBatchUpdate.ShouldNotBeNull();
            parametersOfBatchUpdate.Length.ShouldBe(1);
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (BatchUpdate) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdate_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _batchInstance.BatchUpdateRecallDate(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.BatchUpdateRecallDate(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var message = this.CreateType<Stream>();
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfBatchUpdateRecallDate = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_batchInstanceFixture, parametersOfBatchUpdateRecallDate);
            var result2 = this.GetResultOfMethod<Message>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdateRecallDate.ShouldNotBeNull();
            parametersOfBatchUpdateRecallDate.Length.ShouldBe(1);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var message = this.CreateType<Stream>();
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfBatchUpdateRecallDate = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            parametersOfBatchUpdateRecallDate.ShouldNotBeNull();
            parametersOfBatchUpdateRecallDate.Length.ShouldBe(1);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (BatchUpdateRecallDate) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_BatchUpdateRecallDate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _batchInstance.GetBatchUpdatableFields(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _batchInstance.GetBatchUpdatableFields(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var message = this.CreateType<Message>();
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetBatchUpdatableFields = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_batchInstanceFixture, parametersOfGetBatchUpdatableFields);
            var result2 = this.GetResultOfMethod<Message>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBatchUpdatableFields.ShouldNotBeNull();
            parametersOfGetBatchUpdatableFields.Length.ShouldBe(1);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var message = this.CreateType<Message>();
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetBatchUpdatableFields = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdatableFields.ShouldNotBeNull();
            parametersOfGetBatchUpdatableFields.Length.ShouldBe(1);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetBatchUpdatableFields) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Batch_GetBatchUpdatableFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}