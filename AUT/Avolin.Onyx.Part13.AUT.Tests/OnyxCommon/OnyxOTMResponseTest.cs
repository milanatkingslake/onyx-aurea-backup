using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxOTMResponse" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOTMResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOTMResponse" />)
        /// </summary>
        public OnyxOTMResponseTest() : base(typeof(OnyxOTMResponse))
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

        #region General Initializer : Class (OnyxOTMResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOTMResponseInstanceType;
        private OnyxOTMResponse _onyxOTMResponseInstance;
        private OnyxOTMResponse _onyxOTMResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOTMResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOTMResponseInstanceType = typeof(OnyxOTMResponse);
            _onyxOTMResponseInstanceFixture = this.Create<OnyxOTMResponse>(false);
            _onyxOTMResponseInstance = _onyxOTMResponseInstanceFixture ?? this.Create<OnyxOTMResponse>(true);
            CurrentInstance = _onyxOTMResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOTMResponse) Initializer

        #region Properties

        private const string PropertyIsError = "IsError";
        private const string PropertyErrorDescription = "ErrorDescription";
        private const string PropertyErrorList = "ErrorList";
        private const string PropertyParamsReturn = "ParamsReturn";

        #endregion

        #region Methods

        private const string MethodStringifyErrorList = "StringifyErrorList";

        #endregion

        #region Fields

        private const string FieldisErrored = "isErrored";
        private const string FielderrList = "errList";
        private const string FieldparamsRet = "paramsRet";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOTMResponse) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOTMResponse_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOTMResponse) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOTMResponse_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOTMResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOTMResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOTMResponse)

        #region General Initializer : Class (OnyxOTMResponse) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodStringifyErrorList, 0)]
        public void AUT_OnyxOTMResponse_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOTMResponse) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsError)]
        [TestCase(PropertyErrorDescription)]
        [TestCase(PropertyErrorList)]
        [TestCase(PropertyParamsReturn)]
        [Category("AUT Property")]
        public void AUT_OnyxOTMResponse_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOTMResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldisErrored)]
        [TestCase(FielderrList)]
        [TestCase(FieldparamsRet)]
        [Category("AUT Fields")]
        public void AUT_OnyxOTMResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOTMResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOTMResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOTMResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOTMResponseInstance.ShouldBeAssignableTo<OnyxOTMResponse>();
            _onyxOTMResponseInstanceFixture.ShouldBeAssignableTo<OnyxOTMResponse>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOTMResponse>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOTMResponse) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsError)]
        [TestCase(PropertyErrorDescription)]
        [TestCase(PropertyErrorList)]
        [TestCase(PropertyParamsReturn)]
        public void AUT_OnyxOTMResponse_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOTMResponse) => Property (ErrorDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOTMResponse_ErrorDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyErrorDescription);
            Action currentAction = () => propertyInfo.SetValue(_onyxOTMResponseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOTMResponse) => Property (ErrorDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOTMResponse_Public_Class_ErrorDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOTMResponse) => Property (ErrorList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOTMResponse_Public_Class_ErrorList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorList);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOTMResponse) => Property (IsError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOTMResponse_Public_Class_IsError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsError);
            var propertyInfo = this.GetPropertyInfo(PropertyIsError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOTMResponse) => Property (ParamsReturn) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOTMResponse_Public_Class_ParamsReturn_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParamsReturn);
            var propertyInfo = this.GetPropertyInfo(PropertyParamsReturn);

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

        #region Method Call : (StringifyErrorList) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);

            // Act
            Action executeAction = () => _onyxOTMResponseInstance.StringifyErrorList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxOTMResponseInstance.StringifyErrorList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            Type [] methodStringifyErrorListParametersTypes = null;
            object[] parametersOfStringifyErrorList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodStringifyErrorList, methodStringifyErrorListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxOTMResponseInstanceFixture, parametersOfStringifyErrorList);
            var result2 = this.GetResultOfMethod<String>(MethodStringifyErrorList, parametersOfStringifyErrorList, methodStringifyErrorListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfStringifyErrorList.ShouldBeNull();
            methodStringifyErrorListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            Type [] methodStringifyErrorListParametersTypes = null;
            object[] parametersOfStringifyErrorList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodStringifyErrorList, parametersOfStringifyErrorList, methodStringifyErrorListParametersTypes);

            // Assert
            parametersOfStringifyErrorList.ShouldBeNull();
            methodStringifyErrorListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            Type [] methodStringifyErrorListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodStringifyErrorList, methodStringifyErrorListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodStringifyErrorListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            Type [] methodStringifyErrorListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStringifyErrorList, methodStringifyErrorListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStringifyErrorListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringifyErrorList) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOTMResponse_StringifyErrorList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringifyErrorList);
            var currentMethodInfo = this.GetMethodInfo(MethodStringifyErrorList, 0);

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