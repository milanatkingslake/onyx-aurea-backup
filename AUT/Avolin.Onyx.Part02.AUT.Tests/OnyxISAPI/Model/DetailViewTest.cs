using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DetailView" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
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
        private const string MethodClearJsonAttributes = "ClearJsonAttributes";
        private const string MethodGetPrimaryRetrieveData = "GetPrimaryRetrieveData";
        private const string MethodGetSecondaryRetrieveListData = "GetSecondaryRetrieveListData";
        private const string MethodConvertRetrieveListToRetrieve = "ConvertRetrieveListToRetrieve";
        private const string MethodGetDetailViewMetaData = "GetDetailViewMetaData";
        private const string MethodGetDetailViewGroupData = "GetDetailViewGroupData";
        private const string MethodGetDetailViewFieldData = "GetDetailViewFieldData";
        private const string MethodCheckPermission = "CheckPermission";
        private const string MethodGetParamXml = "GetParamXml";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string Fieldsession = "session";

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

        #region General Initializer : Class (DetailView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DetailView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DetailView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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
        [TestCase(MethodClearJsonAttributes, 0)]
        [TestCase(MethodGetPrimaryRetrieveData, 0)]
        [TestCase(MethodGetSecondaryRetrieveListData, 0)]
        [TestCase(MethodConvertRetrieveListToRetrieve, 0)]
        [TestCase(MethodGetDetailViewMetaData, 0)]
        [TestCase(MethodGetDetailViewGroupData, 0)]
        [TestCase(MethodGetDetailViewFieldData, 0)]
        [TestCase(MethodCheckPermission, 0)]
        [TestCase(MethodGetParamXml, 0)]
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

        #region General Initializer : Class (DetailView) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DetailView" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(Fieldsession)]
        [Category("AUT Fields")]
        public void AUT_DetailView_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DetailView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DetailView" />) instance type verify test.
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _detailViewInstance.GetMetaData(parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetMetaData(parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetMetaData = { parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMetaData, methodGetMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailViewInstanceFixture, parametersOfGetMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetMetaData, parametersOfGetMetaData, methodGetMetaDataParametersTypes);

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

        #region Method Call : (GetMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetMetaData = { parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMetaData, parametersOfGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            parametersOfGetMetaData.ShouldNotBeNull();
            parametersOfGetMetaData.Length.ShouldBe(1);
            methodGetMetaDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Hashtable) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMetaData, methodGetMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (GetMetaData) (Return Type : string) Parameters Count verify

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

        #region Method Call : (GetData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetData_Method_Call_Internally(Type[] types)
        {
            var methodGetDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetData, methodGetDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailViewInstance.GetData(postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetData = { postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetData, methodGetDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailViewInstanceFixture, parametersOfGetData);
            var result2 = this.GetResultOfMethod<string>(MethodGetData, parametersOfGetData, methodGetDataParametersTypes);

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

        #region Method Call : (GetData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetData, parametersOfGetData, methodGetDataParametersTypes);

            // Assert
            parametersOfGetData.ShouldNotBeNull();
            parametersOfGetData.Length.ShouldBe(1);
            methodGetDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Results Null (if not primitive type) Test

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

        #region Method Call : (GetData) (Return Type : string) Invoke Should Not Throw

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

        #region Method Call : (GetData) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (GetData) (Return Type : string) Parameters Count verify

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

        #region Method Call : (Save) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var postData = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailViewInstance.Save(postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var postData = this.CreateType<Message>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.Save(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var postData = this.CreateType<Message>();
            var methodSaveParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfSave = { postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailViewInstanceFixture, parametersOfSave);
            var result2 = this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

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

        #region Method Call : (Save) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var postData = this.CreateType<Message>();
            var methodSaveParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfSave = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            parametersOfSave.ShouldNotBeNull();
            parametersOfSave.Length.ShouldBe(1);
            methodSaveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

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

        #region Method Call : (Save) (Return Type : string) Invoke Should Not Throw

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

        #region Method Call : (Save) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (Save) (Return Type : string) Parameters Count verify

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

        #region Method Call : (ClearJsonAttributes) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_ClearJsonAttributes_Method_Call_Internally(Type[] types)
        {
            var methodClearJsonAttributesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearJsonAttributes, methodClearJsonAttributesParametersTypes);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var paramXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _detailViewInstance.ClearJsonAttributes(paramXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var paramXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.ClearJsonAttributes(paramXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var paramXml = this.CreateType<string>();
            var methodClearJsonAttributesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfClearJsonAttributes = { paramXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodClearJsonAttributes, methodClearJsonAttributesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailViewInstanceFixture, parametersOfClearJsonAttributes);
            var result2 = this.GetResultOfMethod<string>(MethodClearJsonAttributes, parametersOfClearJsonAttributes, methodClearJsonAttributesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfClearJsonAttributes.ShouldNotBeNull();
            parametersOfClearJsonAttributes.Length.ShouldBe(1);
            methodClearJsonAttributesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var paramXml = this.CreateType<string>();
            var methodClearJsonAttributesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfClearJsonAttributes = { paramXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodClearJsonAttributes, parametersOfClearJsonAttributes, methodClearJsonAttributesParametersTypes);

            // Assert
            parametersOfClearJsonAttributes.ShouldNotBeNull();
            parametersOfClearJsonAttributes.Length.ShouldBe(1);
            methodClearJsonAttributesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var methodClearJsonAttributesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodClearJsonAttributes, methodClearJsonAttributesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodClearJsonAttributesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var methodClearJsonAttributesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearJsonAttributes, methodClearJsonAttributesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodClearJsonAttributesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var currentMethodInfo = this.GetMethodInfo(MethodClearJsonAttributes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ClearJsonAttributes) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ClearJsonAttributes_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearJsonAttributes);
            var currentMethodInfo = this.GetMethodInfo(MethodClearJsonAttributes, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_Internally(Type[] types)
        {
            var methodGetPrimaryRetrieveDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => _detailViewInstance.GetPrimaryRetrieveData(postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var postData = this.CreateType<string>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetPrimaryRetrieveData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var postData = this.CreateType<string>();
            var methodGetPrimaryRetrieveDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPrimaryRetrieveData = { postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_detailViewInstanceFixture, parametersOfGetPrimaryRetrieveData);
            var result2 = this.GetResultOfMethod<XDocument>(MethodGetPrimaryRetrieveData, parametersOfGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPrimaryRetrieveData.ShouldNotBeNull();
            parametersOfGetPrimaryRetrieveData.Length.ShouldBe(1);
            methodGetPrimaryRetrieveDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var postData = this.CreateType<string>();
            var methodGetPrimaryRetrieveDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPrimaryRetrieveData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodGetPrimaryRetrieveData, parametersOfGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes);

            // Assert
            parametersOfGetPrimaryRetrieveData.ShouldNotBeNull();
            parametersOfGetPrimaryRetrieveData.Length.ShouldBe(1);
            methodGetPrimaryRetrieveDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var methodGetPrimaryRetrieveDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPrimaryRetrieveDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var methodGetPrimaryRetrieveDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPrimaryRetrieveData, methodGetPrimaryRetrieveDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPrimaryRetrieveDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPrimaryRetrieveData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPrimaryRetrieveData) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetPrimaryRetrieveData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPrimaryRetrieveData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPrimaryRetrieveData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_Internally(Type[] types)
        {
            var methodGetSecondaryRetrieveListDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => _detailViewInstance.GetSecondaryRetrieveListData(postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var postData = this.CreateType<string>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.GetSecondaryRetrieveListData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var postData = this.CreateType<string>();
            var methodGetSecondaryRetrieveListDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSecondaryRetrieveListData = { postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_detailViewInstanceFixture, parametersOfGetSecondaryRetrieveListData);
            var result2 = this.GetResultOfMethod<XDocument>(MethodGetSecondaryRetrieveListData, parametersOfGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSecondaryRetrieveListData.ShouldNotBeNull();
            parametersOfGetSecondaryRetrieveListData.Length.ShouldBe(1);
            methodGetSecondaryRetrieveListDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var postData = this.CreateType<string>();
            var methodGetSecondaryRetrieveListDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSecondaryRetrieveListData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodGetSecondaryRetrieveListData, parametersOfGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes);

            // Assert
            parametersOfGetSecondaryRetrieveListData.ShouldNotBeNull();
            parametersOfGetSecondaryRetrieveListData.Length.ShouldBe(1);
            methodGetSecondaryRetrieveListDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var methodGetSecondaryRetrieveListDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSecondaryRetrieveListDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var methodGetSecondaryRetrieveListDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecondaryRetrieveListData, methodGetSecondaryRetrieveListDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecondaryRetrieveListDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecondaryRetrieveListData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecondaryRetrieveListData) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetSecondaryRetrieveListData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecondaryRetrieveListData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecondaryRetrieveListData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_Internally(Type[] types)
        {
            var methodConvertRetrieveListToRetrieveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _detailViewInstance.ConvertRetrieveListToRetrieve(retrieveList, lboObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _detailViewInstance.ConvertRetrieveListToRetrieve(retrieveList, lboObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();
            var methodConvertRetrieveListToRetrieveParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertRetrieveListToRetrieve = { retrieveList, lboObjectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_detailViewInstanceFixture, parametersOfConvertRetrieveListToRetrieve);
            var result2 = this.GetResultOfMethod<XDocument>(MethodConvertRetrieveListToRetrieve, parametersOfConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConvertRetrieveListToRetrieve.ShouldNotBeNull();
            parametersOfConvertRetrieveListToRetrieve.Length.ShouldBe(2);
            methodConvertRetrieveListToRetrieveParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();
            var methodConvertRetrieveListToRetrieveParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertRetrieveListToRetrieve = { retrieveList, lboObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodConvertRetrieveListToRetrieve, parametersOfConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

            // Assert
            parametersOfConvertRetrieveListToRetrieve.ShouldNotBeNull();
            parametersOfConvertRetrieveListToRetrieve.Length.ShouldBe(2);
            methodConvertRetrieveListToRetrieveParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var methodConvertRetrieveListToRetrieveParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertRetrieveListToRetrieveParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var methodConvertRetrieveListToRetrieveParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertRetrieveListToRetrieveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertRetrieveListToRetrieve, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_ConvertRetrieveListToRetrieve_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertRetrieveListToRetrieve, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetDetailViewMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailViewMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewMetaDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewMetaData = { detailViewId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailViewMlView>>(_detailViewInstanceFixture, parametersOfGetDetailViewMetaData);
            var result2 = this.GetResultOfMethod<List<DetailViewMlView>>(MethodGetDetailViewMetaData, parametersOfGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailViewMetaData.ShouldNotBeNull();
            parametersOfGetDetailViewMetaData.Length.ShouldBe(1);
            methodGetDetailViewMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewMetaDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewMetaData = { detailViewId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailViewMlView>>(MethodGetDetailViewMetaData, parametersOfGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes);

            // Assert
            parametersOfGetDetailViewMetaData.ShouldNotBeNull();
            parametersOfGetDetailViewMetaData.Length.ShouldBe(1);
            methodGetDetailViewMetaDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var methodGetDetailViewMetaDataParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailViewMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var methodGetDetailViewMetaDataParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailViewMetaData, methodGetDetailViewMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailViewMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailViewMetaData) (Return Type : List<DetailViewMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewMetaData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetDetailViewGroupData_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailViewGroupDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewGroupDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewGroupData = { detailViewId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailViewGroupMlView>>(_detailViewInstanceFixture, parametersOfGetDetailViewGroupData);
            var result2 = this.GetResultOfMethod<List<DetailViewGroupMlView>>(MethodGetDetailViewGroupData, parametersOfGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailViewGroupData.ShouldNotBeNull();
            parametersOfGetDetailViewGroupData.Length.ShouldBe(1);
            methodGetDetailViewGroupDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewGroupDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewGroupData = { detailViewId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailViewGroupMlView>>(MethodGetDetailViewGroupData, parametersOfGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes);

            // Assert
            parametersOfGetDetailViewGroupData.ShouldNotBeNull();
            parametersOfGetDetailViewGroupData.Length.ShouldBe(1);
            methodGetDetailViewGroupDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var methodGetDetailViewGroupDataParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailViewGroupDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var methodGetDetailViewGroupDataParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailViewGroupData, methodGetDetailViewGroupDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailViewGroupDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewGroupData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailViewGroupData) (Return Type : List<DetailViewGroupMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewGroupData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewGroupData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewGroupData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetDetailViewFieldData_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailViewFieldDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewFieldDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewFieldData = { detailViewId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailViewFieldMlView>>(_detailViewInstanceFixture, parametersOfGetDetailViewFieldData);
            var result2 = this.GetResultOfMethod<List<DetailViewFieldMlView>>(MethodGetDetailViewFieldData, parametersOfGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailViewFieldData.ShouldNotBeNull();
            parametersOfGetDetailViewFieldData.Length.ShouldBe(1);
            methodGetDetailViewFieldDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailViewFieldDataParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailViewFieldData = { detailViewId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailViewFieldMlView>>(MethodGetDetailViewFieldData, parametersOfGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes);

            // Assert
            parametersOfGetDetailViewFieldData.ShouldNotBeNull();
            parametersOfGetDetailViewFieldData.Length.ShouldBe(1);
            methodGetDetailViewFieldDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var methodGetDetailViewFieldDataParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailViewFieldDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var methodGetDetailViewFieldDataParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailViewFieldData, methodGetDetailViewFieldDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailViewFieldDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewFieldData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailViewFieldData) (Return Type : List<DetailViewFieldMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetDetailViewFieldData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailViewFieldData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailViewFieldData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_CheckPermission_Method_Call_Internally(Type[] types)
        {
            var methodCheckPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckPermission, methodCheckPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var uiResource = this.CreateType<string>();
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckPermission = { uiResource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, methodCheckPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_detailViewInstanceFixture, parametersOfCheckPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckPermission, parametersOfCheckPermission, methodCheckPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckPermission.ShouldNotBeNull();
            parametersOfCheckPermission.Length.ShouldBe(1);
            methodCheckPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var uiResource = this.CreateType<string>();
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckPermission = { uiResource };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, methodCheckPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_detailViewInstanceFixture, out exception1, parametersOfCheckPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckPermission, parametersOfCheckPermission, methodCheckPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckPermission.ShouldNotBeNull();
            parametersOfCheckPermission.Length.ShouldBe(1);
            methodCheckPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var uiResource = this.CreateType<string>();
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckPermission = { uiResource };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckPermission, parametersOfCheckPermission, methodCheckPermissionParametersTypes);

            // Assert
            parametersOfCheckPermission.ShouldNotBeNull();
            parametersOfCheckPermission.Length.ShouldBe(1);
            methodCheckPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckPermission, methodCheckPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_CheckPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailView_GetParamXml_Method_Call_Internally(Type[] types)
        {
            var methodGetParamXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParamXml, methodGetParamXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var paramXml = this.CreateType<string>();
            var methodGetParamXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParamXml = { paramXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParamXml, methodGetParamXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_detailViewInstanceFixture, parametersOfGetParamXml);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetParamXml, parametersOfGetParamXml, methodGetParamXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParamXml.ShouldNotBeNull();
            parametersOfGetParamXml.Length.ShouldBe(1);
            methodGetParamXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var paramXml = this.CreateType<string>();
            var methodGetParamXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParamXml = { paramXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetParamXml, parametersOfGetParamXml, methodGetParamXmlParametersTypes);

            // Assert
            parametersOfGetParamXml.ShouldNotBeNull();
            parametersOfGetParamXml.Length.ShouldBe(1);
            methodGetParamXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var methodGetParamXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParamXml, methodGetParamXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParamXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var methodGetParamXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParamXml, methodGetParamXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParamXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParamXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailView_GetParamXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParamXml, 0);
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