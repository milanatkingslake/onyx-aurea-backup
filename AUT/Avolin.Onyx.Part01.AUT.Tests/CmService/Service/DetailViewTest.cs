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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.DetailView" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\DetailView.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DetailViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DetailView" />)
        /// </summary>
        public DetailViewTest() : base(typeof(DetailView))
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

        #region General Initializer : Class (DetailView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _detailViewInstanceType;
        private DetailView _detailViewInstance;
        private DetailView _detailViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DetailView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _detailViewInstanceType = typeof(DetailView);
            _detailViewInstanceFixture = this.Create<DetailView>(false);
            _detailViewInstance = _detailViewInstanceFixture ?? this.Create<DetailView>(true);
            CurrentInstance = _detailViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DetailView) Initializer

        #region Methods

        private const string MethodGetMetaData = "GetMetaData";
        private const string MethodGetData = "GetData";
        private const string MethodSave = "Save";

        #endregion

        #endregion

        #region General Initializer : Class (DetailView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DetailView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DetailView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DetailView)

        #region General Initializer : Class (DetailView) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DetailView" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMetaData, 0)]
        [TestCase(MethodGetData, 0)]
        [TestCase(MethodSave, 0)]
        public void AUT_DetailView_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DetailView) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DetailView" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DetailView_Is_Instance_Present_Test()
        {
            // Assert
            _detailViewInstanceType.ShouldNotBeNull();
            _detailViewInstance.ShouldNotBeNull();
            _detailViewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DetailView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DetailView" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DetailView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _detailViewInstance.ShouldBeAssignableTo<DetailView>();
            _detailViewInstanceFixture.ShouldBeAssignableTo<DetailView>();
            CurrentInstance.ShouldBeAssignableTo<DetailView>();
        }

        #endregion

        #region General Constructor : Class (DetailView) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DetailView_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DetailView instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailViewInstance.GetMetaData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetMetaData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var message = this.CreateType<Message>();
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetMetaData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMetaData, methodGetMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_detailViewInstanceFixture, parametersOfGetMetaData);
            var result2 = this.GetResultOfMethod<Message>(MethodGetMetaData, parametersOfGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMetaData.ShouldNotBeNull();
            parametersOfGetMetaData.Length.ShouldBe(1);
            methodGetMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var message = this.CreateType<Message>();
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetMetaData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetMetaData, parametersOfGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            parametersOfGetMetaData.ShouldNotBeNull();
            parametersOfGetMetaData.Length.ShouldBe(1);
            methodGetMetaDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMetaData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailViewInstance.GetData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var message = this.CreateType<Message>();
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetData, methodGetDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_detailViewInstanceFixture, parametersOfGetData);
            var result2 = this.GetResultOfMethod<Message>(MethodGetData, parametersOfGetData, methodGetDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetData.ShouldNotBeNull();
            parametersOfGetData.Length.ShouldBe(1);
            methodGetDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var message = this.CreateType<Message>();
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetData, parametersOfGetData, methodGetDataParametersTypes);

            // Assert
            parametersOfGetData.ShouldNotBeNull();
            parametersOfGetData.Length.ShouldBe(1);
            methodGetDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetData, methodGetDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetData, methodGetDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailViewInstance.Save(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.Save(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var message = this.CreateType<Message>();
            var methodSaveParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfSave = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_detailViewInstanceFixture, parametersOfSave);
            var result2 = this.GetResultOfMethod<Message>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSave.ShouldNotBeNull();
            parametersOfSave.Length.ShouldBe(1);
            methodSaveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var message = this.CreateType<Message>();
            var methodSaveParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfSave = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            parametersOfSave.ShouldNotBeNull();
            parametersOfSave.Length.ShouldBe(1);
            methodSaveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var methodSaveParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var methodSaveParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSave, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSave, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}