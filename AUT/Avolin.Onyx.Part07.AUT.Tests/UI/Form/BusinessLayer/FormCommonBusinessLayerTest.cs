using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Form.BusinessLayer;
using Onyx.UI.Form.Helper;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Form.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Form.BusinessLayer.FormCommonBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Form.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FormCommonBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FormCommonBusinessLayer" />)
        /// </summary>
        public FormCommonBusinessLayerTest() : base(typeof(FormCommonBusinessLayer))
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

        #region General Initializer : Class (FormCommonBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _formCommonBusinessLayerInstanceType;
        private FormCommonBusinessLayer _formCommonBusinessLayerInstance;
        private FormCommonBusinessLayer _formCommonBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FormCommonBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _formCommonBusinessLayerInstanceType = typeof(FormCommonBusinessLayer);
            _formCommonBusinessLayerInstanceFixture = this.Create<FormCommonBusinessLayer>(false);
            _formCommonBusinessLayerInstance = _formCommonBusinessLayerInstanceFixture ?? this.Create<FormCommonBusinessLayer>(true);
            CurrentInstance = _formCommonBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FormCommonBusinessLayer) Initializer

        #region Methods

        private const string MethodGetDetailFormMetaData = "GetDetailFormMetaData";
        private const string MethodGetDetailFormData = "GetDetailFormData";
        private const string MethodSaveDetailFormData = "SaveDetailFormData";
        private const string MethodGetListFormMetaData = "GetListFormMetaData";
        private const string MethodGetListFormData = "GetListFormData";

        #endregion

        #endregion

        #region General Initializer : Class (FormCommonBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FormCommonBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FormCommonBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FormCommonBusinessLayer)

        #region General Initializer : Class (FormCommonBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FormCommonBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDetailFormMetaData, 0)]
        [TestCase(MethodGetDetailFormData, 0)]
        [TestCase(MethodSaveDetailFormData, 0)]
        [TestCase(MethodGetListFormMetaData, 0)]
        [TestCase(MethodGetListFormData, 0)]
        public void AUT_FormCommonBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FormCommonBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FormCommonBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FormCommonBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _formCommonBusinessLayerInstanceType.ShouldNotBeNull();
            _formCommonBusinessLayerInstance.ShouldNotBeNull();
            _formCommonBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FormCommonBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FormCommonBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FormCommonBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _formCommonBusinessLayerInstance.ShouldBeAssignableTo<FormCommonBusinessLayer>();
            _formCommonBusinessLayerInstanceFixture.ShouldBeAssignableTo<FormCommonBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<FormCommonBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FormCommonBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FormCommonBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FormCommonBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();

            // Act
            Action executeAction = () => _formCommonBusinessLayerInstance.GetDetailFormMetaData(onyxHeaderDetail, queryString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _formCommonBusinessLayerInstance.GetDetailFormMetaData(onyxHeaderDetail, queryString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var methodGetDetailFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            object[] parametersOfGetDetailFormMetaData = { onyxHeaderDetail, queryString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormMetaData, methodGetDetailFormMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_formCommonBusinessLayerInstanceFixture, parametersOfGetDetailFormMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetDetailFormMetaData, parametersOfGetDetailFormMetaData, methodGetDetailFormMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailFormMetaData.ShouldNotBeNull();
            parametersOfGetDetailFormMetaData.Length.ShouldBe(2);
            methodGetDetailFormMetaDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var methodGetDetailFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            object[] parametersOfGetDetailFormMetaData = { onyxHeaderDetail, queryString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDetailFormMetaData, parametersOfGetDetailFormMetaData, methodGetDetailFormMetaDataParametersTypes);

            // Assert
            parametersOfGetDetailFormMetaData.ShouldNotBeNull();
            parametersOfGetDetailFormMetaData.Length.ShouldBe(2);
            methodGetDetailFormMetaDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var methodGetDetailFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailFormMetaData, methodGetDetailFormMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailFormMetaDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var methodGetDetailFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailFormMetaData, methodGetDetailFormMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailFormMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailFormMetaData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormMetaData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailFormData, methodGetDetailFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => _formCommonBusinessLayerInstance.GetDetailFormData(onyxHeaderDetail, queryString, postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _formCommonBusinessLayerInstance.GetDetailFormData(onyxHeaderDetail, queryString, postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodGetDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfGetDetailFormData = { onyxHeaderDetail, queryString, postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormData, methodGetDetailFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_formCommonBusinessLayerInstanceFixture, parametersOfGetDetailFormData);
            var result2 = this.GetResultOfMethod<string>(MethodGetDetailFormData, parametersOfGetDetailFormData, methodGetDetailFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailFormData.ShouldNotBeNull();
            parametersOfGetDetailFormData.Length.ShouldBe(3);
            methodGetDetailFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodGetDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfGetDetailFormData = { onyxHeaderDetail, queryString, postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDetailFormData, parametersOfGetDetailFormData, methodGetDetailFormDataParametersTypes);

            // Assert
            parametersOfGetDetailFormData.ShouldNotBeNull();
            parametersOfGetDetailFormData.Length.ShouldBe(3);
            methodGetDetailFormDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var methodGetDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailFormData, methodGetDetailFormDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var methodGetDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailFormData, methodGetDetailFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailFormData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetDetailFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailFormData, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_Internally(Type[] types)
        {
            var methodSaveDetailFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveDetailFormData, methodSaveDetailFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => _formCommonBusinessLayerInstance.SaveDetailFormData(onyxHeaderDetail, queryString, postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _formCommonBusinessLayerInstance.SaveDetailFormData(onyxHeaderDetail, queryString, postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodSaveDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfSaveDetailFormData = { onyxHeaderDetail, queryString, postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveDetailFormData, methodSaveDetailFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_formCommonBusinessLayerInstanceFixture, parametersOfSaveDetailFormData);
            var result2 = this.GetResultOfMethod<string>(MethodSaveDetailFormData, parametersOfSaveDetailFormData, methodSaveDetailFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveDetailFormData.ShouldNotBeNull();
            parametersOfSaveDetailFormData.Length.ShouldBe(3);
            methodSaveDetailFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodSaveDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfSaveDetailFormData = { onyxHeaderDetail, queryString, postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveDetailFormData, parametersOfSaveDetailFormData, methodSaveDetailFormDataParametersTypes);

            // Assert
            parametersOfSaveDetailFormData.ShouldNotBeNull();
            parametersOfSaveDetailFormData.Length.ShouldBe(3);
            methodSaveDetailFormDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var methodSaveDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveDetailFormData, methodSaveDetailFormDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveDetailFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var methodSaveDetailFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveDetailFormData, methodSaveDetailFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveDetailFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveDetailFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveDetailFormData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_SaveDetailFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveDetailFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveDetailFormData, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetListFormMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetListFormMetaData, methodGetListFormMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();

            // Act
            Action executeAction = () => _formCommonBusinessLayerInstance.GetListFormMetaData(onyxHeaderDetail, queryString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _formCommonBusinessLayerInstance.GetListFormMetaData(onyxHeaderDetail, queryString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var methodGetListFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            object[] parametersOfGetListFormMetaData = { onyxHeaderDetail, queryString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormMetaData, methodGetListFormMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_formCommonBusinessLayerInstanceFixture, parametersOfGetListFormMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetListFormMetaData, parametersOfGetListFormMetaData, methodGetListFormMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetListFormMetaData.ShouldNotBeNull();
            parametersOfGetListFormMetaData.Length.ShouldBe(2);
            methodGetListFormMetaDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var methodGetListFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            object[] parametersOfGetListFormMetaData = { onyxHeaderDetail, queryString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetListFormMetaData, parametersOfGetListFormMetaData, methodGetListFormMetaDataParametersTypes);

            // Assert
            parametersOfGetListFormMetaData.ShouldNotBeNull();
            parametersOfGetListFormMetaData.Length.ShouldBe(2);
            methodGetListFormMetaDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var methodGetListFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListFormMetaData, methodGetListFormMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetListFormMetaDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var methodGetListFormMetaDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListFormMetaData, methodGetListFormMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListFormMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListFormMetaData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormMetaData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_Internally(Type[] types)
        {
            var methodGetListFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => _formCommonBusinessLayerInstance.GetListFormData(onyxHeaderDetail, queryString, postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _formCommonBusinessLayerInstance.GetListFormData(onyxHeaderDetail, queryString, postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodGetListFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfGetListFormData = { onyxHeaderDetail, queryString, postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, methodGetListFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_formCommonBusinessLayerInstanceFixture, parametersOfGetListFormData);
            var result2 = this.GetResultOfMethod<string>(MethodGetListFormData, parametersOfGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetListFormData.ShouldNotBeNull();
            parametersOfGetListFormData.Length.ShouldBe(3);
            methodGetListFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var queryString = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodGetListFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            object[] parametersOfGetListFormData = { onyxHeaderDetail, queryString, postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetListFormData, parametersOfGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            parametersOfGetListFormData.ShouldNotBeNull();
            parametersOfGetListFormData.Length.ShouldBe(3);
            methodGetListFormDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var methodGetListFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetListFormDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var methodGetListFormDataParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormCommonBusinessLayer_GetListFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, 0);
            const int parametersCount = 3;

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