using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Xml;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.HelperMethod" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\HelperMethod.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelperMethodTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelperMethod" />)
        /// </summary>
        public HelperMethodTest() : base(typeof(HelperMethod))
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

        #region General Initializer : Class (HelperMethod) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helperMethodInstanceType;
        private HelperMethod _helperMethodInstance;
        private HelperMethod _helperMethodInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelperMethod" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helperMethodInstanceType = typeof(HelperMethod);
            _helperMethodInstanceFixture = this.Create<HelperMethod>(false);
            _helperMethodInstance = _helperMethodInstanceFixture ?? this.Create<HelperMethod>(true);
            CurrentInstance = _helperMethodInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelperMethod) Initializer

        #region Methods

        private const string MethodGetPropertyValue = "GetPropertyValue";
        private const string MethodSetPropertyValue = "SetPropertyValue";
        private const string MethodGetProperty = "GetProperty";
        private const string MethodIsPropertyPresent = "IsPropertyPresent";
        private const string MethodPopulateXmlDataToObject = "PopulateXmlDataToObject";
        private const string MethodErrorXmlToObject = "ErrorXmlToObject";
        private const string MethodResultXmlToObject = "ResultXmlToObject";
        private const string MethodDataXmlToObject = "DataXmlToObject";
        private const string MethodQueryXmlToObject = "QueryXmlToObject";
        private const string MethodXmlToObject = "XmlToObject";

        #endregion

        #endregion

        #region General Initializer : Class (HelperMethod) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelperMethod_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelperMethod)

        #region General Initializer : Class (HelperMethod) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetPropertyValue, 0)]
        [TestCase(MethodSetPropertyValue, 0)]
        [TestCase(MethodGetProperty, 0)]
        [TestCase(MethodIsPropertyPresent, 0)]
        [TestCase(MethodSetPropertyValue, 1)]
        [TestCase(MethodPopulateXmlDataToObject, 0)]
        [TestCase(MethodErrorXmlToObject, 0)]
        [TestCase(MethodResultXmlToObject, 0)]
        [TestCase(MethodDataXmlToObject, 0)]
        [TestCase(MethodQueryXmlToObject, 0)]
        [TestCase(MethodXmlToObject, 0)]
        public void AUT_HelperMethod_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (HelperMethod) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelperMethod_Is_Instance_Present_Test()
        {
            // Assert
            _helperMethodInstanceType.ShouldNotBeNull();
            _helperMethodInstance.ShouldNotBeNull();
            _helperMethodInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HelperMethod) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelperMethod_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helperMethodInstance.ShouldBeAssignableTo<HelperMethod>();
            _helperMethodInstanceFixture.ShouldBeAssignableTo<HelperMethod>();
            CurrentInstance.ShouldBeAssignableTo<HelperMethod>();
        }

        #endregion

        #region General Constructor : Class (HelperMethod) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelperMethod_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HelperMethod instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.GetPropertyValue(propertyName, sourceObject);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.GetPropertyValue(propertyName, sourceObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodGetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfGetPropertyValue = { propertyName, sourceObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyValue, methodGetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfGetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetPropertyValue.ShouldNotBeNull();
            parametersOfGetPropertyValue.Length.ShouldBe(2);
            methodGetPropertyValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodGetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfGetPropertyValue = { propertyName, sourceObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetPropertyValue, parametersOfGetPropertyValue, methodGetPropertyValueParametersTypes);

            // Assert
            parametersOfGetPropertyValue.ShouldNotBeNull();
            parametersOfGetPropertyValue.Length.ShouldBe(2);
            methodGetPropertyValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var methodGetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPropertyValue, methodGetPropertyValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertyValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var methodGetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPropertyValue, methodGetPropertyValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyValue) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetPropertyValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.SetPropertyValue(propertyName, sourceObject, setValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(3);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes));
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(3);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(3);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.GetProperty(propertyName, sourceObject);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var returnedValue = default(PropertyInfo);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.GetProperty(propertyName, sourceObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodGetPropertyParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfGetProperty = { propertyName, sourceObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperty, methodGetPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfGetProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProperty.ShouldNotBeNull();
            parametersOfGetProperty.Length.ShouldBe(2);
            methodGetPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodGetPropertyParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfGetProperty = { propertyName, sourceObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<PropertyInfo>(MethodGetProperty, parametersOfGetProperty, methodGetPropertyParametersTypes);

            // Assert
            parametersOfGetProperty.ShouldNotBeNull();
            parametersOfGetProperty.Length.ShouldBe(2);
            methodGetPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var methodGetPropertyParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProperty, methodGetPropertyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var methodGetPropertyParametersTypes = new Type[] { typeof(string), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProperty, methodGetPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetProperty_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.IsPropertyPresent(propertyName, sourceObject);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfIsPropertyPresent = { propertyName, sourceObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsPropertyPresent, parametersOfIsPropertyPresent, methodIsPropertyPresentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsPropertyPresent.ShouldNotBeNull();
            parametersOfIsPropertyPresent.Length.ShouldBe(2);
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsPropertyPresent, parametersOfIsPropertyPresent, methodIsPropertyPresentParametersTypes));
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfIsPropertyPresent = { propertyName, sourceObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfIsPropertyPresent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsPropertyPresent.ShouldNotBeNull();
            parametersOfIsPropertyPresent.Length.ShouldBe(2);
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfIsPropertyPresent = { propertyName, sourceObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsPropertyPresent, parametersOfIsPropertyPresent, methodIsPropertyPresentParametersTypes);

            // Assert
            parametersOfIsPropertyPresent.ShouldNotBeNull();
            parametersOfIsPropertyPresent.Length.ShouldBe(2);
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var methodIsPropertyPresentParametersTypes = new Type[] { typeof(string), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsPropertyPresentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var currentMethodInfo = this.GetMethodInfo(MethodIsPropertyPresent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsPropertyPresent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsPropertyPresent);
            var currentMethodInfo = this.GetMethodInfo(MethodIsPropertyPresent, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.SetPropertyValue(propertyInfo, dataSource, data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(3);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(3);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            methodSetPropertyValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var className = this.CreateType<string>();
            var rootNode = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();

            // Act
            Action executeAction = () => HelperMethod.PopulateXmlDataToObject(className, rootNode, isAttributeHasData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var className = this.CreateType<string>();
            var rootNode = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.PopulateXmlDataToObject(className, rootNode, isAttributeHasData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var className = this.CreateType<string>();
            var rootNode = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodPopulateXmlDataToObjectParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            object[] parametersOfPopulateXmlDataToObject = { className, rootNode, isAttributeHasData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodPopulateXmlDataToObject, parametersOfPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfPopulateXmlDataToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPopulateXmlDataToObject.ShouldNotBeNull();
            parametersOfPopulateXmlDataToObject.Length.ShouldBe(3);
            methodPopulateXmlDataToObjectParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var className = this.CreateType<string>();
            var rootNode = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodPopulateXmlDataToObjectParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            object[] parametersOfPopulateXmlDataToObject = { className, rootNode, isAttributeHasData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodPopulateXmlDataToObject, parametersOfPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes);

            // Assert
            parametersOfPopulateXmlDataToObject.ShouldNotBeNull();
            parametersOfPopulateXmlDataToObject.Length.ShouldBe(3);
            methodPopulateXmlDataToObjectParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var methodPopulateXmlDataToObjectParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPopulateXmlDataToObjectParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var methodPopulateXmlDataToObjectParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateXmlDataToObject, methodPopulateXmlDataToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPopulateXmlDataToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlDataToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateXmlDataToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlDataToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlDataToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlDataToObject, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => HelperMethod.ErrorXmlToObject(xmlDocument);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.ErrorXmlToObject(xmlDocument);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodErrorXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfErrorXmlToObject = { xmlDocument };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodErrorXmlToObject, methodErrorXmlToObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfErrorXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfErrorXmlToObject.ShouldNotBeNull();
            parametersOfErrorXmlToObject.Length.ShouldBe(1);
            methodErrorXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodErrorXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfErrorXmlToObject = { xmlDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodErrorXmlToObject, parametersOfErrorXmlToObject, methodErrorXmlToObjectParametersTypes);

            // Assert
            parametersOfErrorXmlToObject.ShouldNotBeNull();
            parametersOfErrorXmlToObject.Length.ShouldBe(1);
            methodErrorXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var methodErrorXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodErrorXmlToObject, methodErrorXmlToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodErrorXmlToObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var methodErrorXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodErrorXmlToObject, methodErrorXmlToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodErrorXmlToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodErrorXmlToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ErrorXmlToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ErrorXmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodErrorXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodErrorXmlToObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => HelperMethod.ResultXmlToObject(xmlDocument);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.ResultXmlToObject(xmlDocument);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodResultXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfResultXmlToObject = { xmlDocument };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResultXmlToObject, methodResultXmlToObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodResultXmlToObject, methodResultXmlToObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodResultXmlToObject, parametersOfResultXmlToObject, methodResultXmlToObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfResultXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResultXmlToObject.ShouldNotBeNull();
            parametersOfResultXmlToObject.Length.ShouldBe(1);
            methodResultXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodResultXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfResultXmlToObject = { xmlDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodResultXmlToObject, parametersOfResultXmlToObject, methodResultXmlToObjectParametersTypes);

            // Assert
            parametersOfResultXmlToObject.ShouldNotBeNull();
            parametersOfResultXmlToObject.Length.ShouldBe(1);
            methodResultXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var methodResultXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResultXmlToObject, methodResultXmlToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResultXmlToObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var methodResultXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResultXmlToObject, methodResultXmlToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResultXmlToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodResultXmlToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResultXmlToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ResultXmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResultXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodResultXmlToObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();

            // Act
            Action executeAction = () => HelperMethod.DataXmlToObject(xmlDocument, isAttributeHasData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.DataXmlToObject(xmlDocument, isAttributeHasData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodDataXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            object[] parametersOfDataXmlToObject = { xmlDocument, isAttributeHasData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDataXmlToObject, methodDataXmlToObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDataXmlToObject, methodDataXmlToObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodDataXmlToObject, parametersOfDataXmlToObject, methodDataXmlToObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfDataXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDataXmlToObject.ShouldNotBeNull();
            parametersOfDataXmlToObject.Length.ShouldBe(2);
            methodDataXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodDataXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            object[] parametersOfDataXmlToObject = { xmlDocument, isAttributeHasData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodDataXmlToObject, parametersOfDataXmlToObject, methodDataXmlToObjectParametersTypes);

            // Assert
            parametersOfDataXmlToObject.ShouldNotBeNull();
            parametersOfDataXmlToObject.Length.ShouldBe(2);
            methodDataXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var methodDataXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDataXmlToObject, methodDataXmlToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDataXmlToObjectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var methodDataXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDataXmlToObject, methodDataXmlToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDataXmlToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodDataXmlToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DataXmlToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_DataXmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDataXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodDataXmlToObject, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();

            // Act
            Action executeAction = () => HelperMethod.QueryXmlToObject(xmlDocument, isAttributeHasData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.QueryXmlToObject(xmlDocument, isAttributeHasData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodQueryXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            object[] parametersOfQueryXmlToObject = { xmlDocument, isAttributeHasData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodQueryXmlToObject, methodQueryXmlToObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodQueryXmlToObject, methodQueryXmlToObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodQueryXmlToObject, parametersOfQueryXmlToObject, methodQueryXmlToObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfQueryXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfQueryXmlToObject.ShouldNotBeNull();
            parametersOfQueryXmlToObject.Length.ShouldBe(2);
            methodQueryXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var xmlDocument = this.CreateType<XmlNode>();
            var isAttributeHasData = this.CreateType<bool>();
            var methodQueryXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            object[] parametersOfQueryXmlToObject = { xmlDocument, isAttributeHasData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodQueryXmlToObject, parametersOfQueryXmlToObject, methodQueryXmlToObjectParametersTypes);

            // Assert
            parametersOfQueryXmlToObject.ShouldNotBeNull();
            parametersOfQueryXmlToObject.Length.ShouldBe(2);
            methodQueryXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var methodQueryXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodQueryXmlToObject, methodQueryXmlToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodQueryXmlToObjectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var methodQueryXmlToObjectParametersTypes = new Type[] { typeof(XmlNode), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodQueryXmlToObject, methodQueryXmlToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodQueryXmlToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodQueryXmlToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (QueryXmlToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_QueryXmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodQueryXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodQueryXmlToObject, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => HelperMethod.XmlToObject(xmlDocument);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.XmlToObject(xmlDocument);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfXmlToObject = { xmlDocument };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodXmlToObject, methodXmlToObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodXmlToObject, methodXmlToObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodXmlToObject, parametersOfXmlToObject, methodXmlToObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfXmlToObject.ShouldNotBeNull();
            parametersOfXmlToObject.Length.ShouldBe(1);
            methodXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfXmlToObject = { xmlDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodXmlToObject, parametersOfXmlToObject, methodXmlToObjectParametersTypes);

            // Assert
            parametersOfXmlToObject.ShouldNotBeNull();
            parametersOfXmlToObject.Length.ShouldBe(1);
            methodXmlToObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var methodXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodXmlToObject, methodXmlToObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodXmlToObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var methodXmlToObjectParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodXmlToObject, methodXmlToObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodXmlToObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlToObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (XmlToObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_XmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlToObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}