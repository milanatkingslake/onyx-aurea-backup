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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DetailListView" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DetailListViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DetailListView" />)
        /// </summary>
        public DetailListViewTest() : base(typeof(DetailListView))
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

        #region General Initializer : Class (DetailListView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _detailListViewInstanceType;
        private DetailListView _detailListViewInstance;
        private DetailListView _detailListViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DetailListView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _detailListViewInstanceType = typeof(DetailListView);
            _detailListViewInstanceFixture = this.Create<DetailListView>(false);
            _detailListViewInstance = _detailListViewInstanceFixture ?? this.Create<DetailListView>(true);
            CurrentInstance = _detailListViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DetailListView) Initializer

        #region Methods

        private const string MethodGetMetaData = "GetMetaData";
        private const string MethodGetData = "GetData";
        private const string MethodConvertRetrieveListToRetrieve = "ConvertRetrieveListToRetrieve";
        private const string MethodgetListViewFormView = "getListViewFormView";
        private const string MethodgetListViewGroupMlView = "getListViewGroupMlView";
        private const string MethodgetListViewMlView = "getListViewMlView";
        private const string MethodgetListViewColumnMlView = "getListViewColumnMlView";
        private const string MethodCheckPermission = "CheckPermission";
        private const string MethodGetParamXml = "GetParamXml";
        private const string MethodGetDetailListViewIdByDetailViewId = "GetDetailListViewIdByDetailViewId";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string Fieldsession = "session";

        #endregion

        #endregion

        #region General Initializer : Class (DetailListView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DetailListView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DetailListView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DetailListView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DetailListView)

        #region General Initializer : Class (DetailListView) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMetaData, 0)]
        [TestCase(MethodGetData, 0)]
        [TestCase(MethodConvertRetrieveListToRetrieve, 0)]
        [TestCase(MethodgetListViewFormView, 0)]
        [TestCase(MethodgetListViewGroupMlView, 0)]
        [TestCase(MethodgetListViewMlView, 0)]
        [TestCase(MethodgetListViewColumnMlView, 0)]
        [TestCase(MethodCheckPermission, 0)]
        [TestCase(MethodGetParamXml, 0)]
        [TestCase(MethodGetDetailListViewIdByDetailViewId, 0)]
        public void AUT_DetailListView_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DetailListView) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(Fieldsession)]
        [Category("AUT Fields")]
        public void AUT_DetailListView_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DetailListView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DetailListView" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DetailListView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _detailListViewInstance.ShouldBeAssignableTo<DetailListView>();
            _detailListViewInstanceFixture.ShouldBeAssignableTo<DetailListView>();
            CurrentInstance.ShouldBeAssignableTo<DetailListView>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _detailListViewInstance.GetMetaData(parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailListViewInstance.GetMetaData(parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMetaData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetMetaDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetMetaData = { parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMetaData, methodGetMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailListViewInstanceFixture, parametersOfGetMetaData);
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
        public void AUT_DetailListView_GetMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DetailListView_GetMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DetailListView_GetMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DetailListView_GetMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DetailListView_GetMetaData_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_DetailListView_GetData_Method_Call_Internally(Type[] types)
        {
            var methodGetDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetData, methodGetDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();

            // Act
            Action executeAction = () => _detailListViewInstance.GetData(postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailListViewInstance.GetData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetData);
            var postData = this.CreateType<Message>();
            var methodGetDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetData = { postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetData, methodGetDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailListViewInstanceFixture, parametersOfGetData);
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
        public void AUT_DetailListView_GetData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DetailListView_GetData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DetailListView_GetData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DetailListView_GetData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DetailListView_GetData_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_Internally(Type[] types)
        {
            var methodConvertRetrieveListToRetrieveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _detailListViewInstance.ConvertRetrieveListToRetrieve(retrieveList, lboObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _detailListViewInstance.ConvertRetrieveListToRetrieve(retrieveList, lboObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_detailListViewInstanceFixture, parametersOfConvertRetrieveListToRetrieve);
            var result2 = this.GetResultOfMethod<string>(MethodConvertRetrieveListToRetrieve, parametersOfConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

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

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRetrieveListToRetrieve);
            var retrieveList = this.CreateType<string>();
            var lboObjectName = this.CreateType<string>();
            var methodConvertRetrieveListToRetrieveParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertRetrieveListToRetrieve = { retrieveList, lboObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertRetrieveListToRetrieve, parametersOfConvertRetrieveListToRetrieve, methodConvertRetrieveListToRetrieveParametersTypes);

            // Assert
            parametersOfConvertRetrieveListToRetrieve.ShouldNotBeNull();
            parametersOfConvertRetrieveListToRetrieve.Length.ShouldBe(2);
            methodConvertRetrieveListToRetrieveParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (ConvertRetrieveListToRetrieve) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_ConvertRetrieveListToRetrieve_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_getListViewFormView_Method_Call_Internally(Type[] types)
        {
            var methodgetListViewFormViewParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetListViewFormView, methodgetListViewFormViewParametersTypes);
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewFormViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewFormView = { listViewFormId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewFormView, methodgetListViewFormViewParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailListViewFormView>>(_detailListViewInstanceFixture, parametersOfgetListViewFormView);
            var result2 = this.GetResultOfMethod<List<DetailListViewFormView>>(MethodgetListViewFormView, parametersOfgetListViewFormView, methodgetListViewFormViewParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetListViewFormView.ShouldNotBeNull();
            parametersOfgetListViewFormView.Length.ShouldBe(1);
            methodgetListViewFormViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewFormViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewFormView = { listViewFormId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailListViewFormView>>(MethodgetListViewFormView, parametersOfgetListViewFormView, methodgetListViewFormViewParametersTypes);

            // Assert
            parametersOfgetListViewFormView.ShouldNotBeNull();
            parametersOfgetListViewFormView.Length.ShouldBe(1);
            methodgetListViewFormViewParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var methodgetListViewFormViewParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetListViewFormView, methodgetListViewFormViewParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetListViewFormViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var methodgetListViewFormViewParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetListViewFormView, methodgetListViewFormViewParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetListViewFormViewParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewFormView, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getListViewFormView) (Return Type : List<DetailListViewFormView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewFormView_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewFormView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewFormView, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_getListViewGroupMlView_Method_Call_Internally(Type[] types)
        {
            var methodgetListViewGroupMlViewParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewGroupMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewGroupMlView = { listViewFormId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailListViewGroupMlView>>(_detailListViewInstanceFixture, parametersOfgetListViewGroupMlView);
            var result2 = this.GetResultOfMethod<List<DetailListViewGroupMlView>>(MethodgetListViewGroupMlView, parametersOfgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetListViewGroupMlView.ShouldNotBeNull();
            parametersOfgetListViewGroupMlView.Length.ShouldBe(1);
            methodgetListViewGroupMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewGroupMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewGroupMlView = { listViewFormId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailListViewGroupMlView>>(MethodgetListViewGroupMlView, parametersOfgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes);

            // Assert
            parametersOfgetListViewGroupMlView.ShouldNotBeNull();
            parametersOfgetListViewGroupMlView.Length.ShouldBe(1);
            methodgetListViewGroupMlViewParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var methodgetListViewGroupMlViewParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetListViewGroupMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var methodgetListViewGroupMlViewParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetListViewGroupMlView, methodgetListViewGroupMlViewParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetListViewGroupMlViewParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewGroupMlView, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getListViewGroupMlView) (Return Type : List<DetailListViewGroupMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewGroupMlView_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewGroupMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewGroupMlView, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_getListViewMlView_Method_Call_Internally(Type[] types)
        {
            var methodgetListViewMlViewParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetListViewMlView, methodgetListViewMlViewParametersTypes);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewMlView = { listViewFormId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewMlView, methodgetListViewMlViewParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailListViewMlView>>(_detailListViewInstanceFixture, parametersOfgetListViewMlView);
            var result2 = this.GetResultOfMethod<List<DetailListViewMlView>>(MethodgetListViewMlView, parametersOfgetListViewMlView, methodgetListViewMlViewParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetListViewMlView.ShouldNotBeNull();
            parametersOfgetListViewMlView.Length.ShouldBe(1);
            methodgetListViewMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewMlView = { listViewFormId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailListViewMlView>>(MethodgetListViewMlView, parametersOfgetListViewMlView, methodgetListViewMlViewParametersTypes);

            // Assert
            parametersOfgetListViewMlView.ShouldNotBeNull();
            parametersOfgetListViewMlView.Length.ShouldBe(1);
            methodgetListViewMlViewParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var methodgetListViewMlViewParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetListViewMlView, methodgetListViewMlViewParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetListViewMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var methodgetListViewMlViewParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetListViewMlView, methodgetListViewMlViewParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetListViewMlViewParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewMlView, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getListViewMlView) (Return Type : List<DetailListViewMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewMlView_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewMlView, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_getListViewColumnMlView_Method_Call_Internally(Type[] types)
        {
            var methodgetListViewColumnMlViewParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewColumnMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewColumnMlView = { listViewFormId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DetailListViewColumnMlView>>(_detailListViewInstanceFixture, parametersOfgetListViewColumnMlView);
            var result2 = this.GetResultOfMethod<List<DetailListViewColumnMlView>>(MethodgetListViewColumnMlView, parametersOfgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetListViewColumnMlView.ShouldNotBeNull();
            parametersOfgetListViewColumnMlView.Length.ShouldBe(1);
            methodgetListViewColumnMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var listViewFormId = this.CreateType<int>();
            var methodgetListViewColumnMlViewParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfgetListViewColumnMlView = { listViewFormId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DetailListViewColumnMlView>>(MethodgetListViewColumnMlView, parametersOfgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes);

            // Assert
            parametersOfgetListViewColumnMlView.ShouldNotBeNull();
            parametersOfgetListViewColumnMlView.Length.ShouldBe(1);
            methodgetListViewColumnMlViewParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var methodgetListViewColumnMlViewParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetListViewColumnMlViewParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var methodgetListViewColumnMlViewParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetListViewColumnMlView, methodgetListViewColumnMlViewParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetListViewColumnMlViewParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewColumnMlView, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getListViewColumnMlView) (Return Type : List<DetailListViewColumnMlView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_getListViewColumnMlView_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetListViewColumnMlView);
            var currentMethodInfo = this.GetMethodInfo(MethodgetListViewColumnMlView, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_CheckPermission_Method_Call_Internally(Type[] types)
        {
            var methodCheckPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckPermission, methodCheckPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (CheckPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_CheckPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var uiResource = this.CreateType<string>();
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckPermission = { uiResource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, methodCheckPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_detailListViewInstanceFixture, parametersOfCheckPermission);
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
        public void AUT_DetailListView_CheckPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckPermission);
            var uiResource = this.CreateType<string>();
            var methodCheckPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckPermission = { uiResource };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckPermission, methodCheckPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_detailListViewInstanceFixture, out exception1, parametersOfCheckPermission);
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
        public void AUT_DetailListView_CheckPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DetailListView_CheckPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DetailListView_CheckPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DetailListView_CheckPermission_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_DetailListView_GetParamXml_Method_Call_Internally(Type[] types)
        {
            var methodGetParamXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParamXml, methodGetParamXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetParamXml) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetParamXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParamXml);
            var paramXml = this.CreateType<string>();
            var methodGetParamXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParamXml = { paramXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParamXml, methodGetParamXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_detailListViewInstanceFixture, parametersOfGetParamXml);
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
        public void AUT_DetailListView_GetParamXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DetailListView_GetParamXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DetailListView_GetParamXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DetailListView_GetParamXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_DetailListView_GetParamXml_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailListViewIdByDetailViewIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailListViewIdByDetailViewIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailListViewIdByDetailViewId = { detailViewId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_detailListViewInstanceFixture, parametersOfGetDetailListViewIdByDetailViewId);
            var result2 = this.GetResultOfMethod<int>(MethodGetDetailListViewIdByDetailViewId, parametersOfGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetDetailListViewIdByDetailViewId.ShouldNotBeNull();
            parametersOfGetDetailListViewIdByDetailViewId.Length.ShouldBe(1);
            methodGetDetailListViewIdByDetailViewIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailListViewIdByDetailViewIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailListViewIdByDetailViewId = { detailViewId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_detailListViewInstanceFixture, out exception1, parametersOfGetDetailListViewIdByDetailViewId);
            var result2 = this.GetResultOfMethod<int>(MethodGetDetailListViewIdByDetailViewId, parametersOfGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetDetailListViewIdByDetailViewId.ShouldNotBeNull();
            parametersOfGetDetailListViewIdByDetailViewId.Length.ShouldBe(1);
            methodGetDetailListViewIdByDetailViewIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var detailViewId = this.CreateType<int>();
            var methodGetDetailListViewIdByDetailViewIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetDetailListViewIdByDetailViewId = { detailViewId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetDetailListViewIdByDetailViewId, parametersOfGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes);

            // Assert
            parametersOfGetDetailListViewIdByDetailViewId.ShouldNotBeNull();
            parametersOfGetDetailListViewIdByDetailViewId.Length.ShouldBe(1);
            methodGetDetailListViewIdByDetailViewIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var methodGetDetailListViewIdByDetailViewIdParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailListViewIdByDetailViewId, methodGetDetailListViewIdByDetailViewIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailListViewIdByDetailViewIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailListViewIdByDetailViewId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailListViewIdByDetailViewId) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DetailListView_GetDetailListViewIdByDetailViewId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailListViewIdByDetailViewId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailListViewIdByDetailViewId, 0);
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