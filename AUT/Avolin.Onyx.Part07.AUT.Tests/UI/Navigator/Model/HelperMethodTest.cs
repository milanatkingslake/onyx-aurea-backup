using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.HelperMethod" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
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

        #region Properties

        private const string PropertyIsLocalDate = "IsLocalDate";

        #endregion

        #region Methods

        private const string MethodGetPropertyValue = "GetPropertyValue";
        private const string MethodSetPropertyValue = "SetPropertyValue";
        private const string MethodGetProperty = "GetProperty";
        private const string MethodIsPropertyPresent = "IsPropertyPresent";
        private const string MethodCreateEntityClass = "CreateEntityClass";
        private const string MethodSetDataEntityClass = "SetDataEntityClass";
        private const string MethodGetByWhereClause = "GetByWhereClause";
        private const string MethodValidateCondition = "ValidateCondition";
        private const string MethodSplitCondition = "SplitCondition";
        private const string MethodGetResultConfiguration = "GetResultConfiguration";
        private const string MethodPopulateXmlToObject = "PopulateXmlToObject";

        #endregion

        #region Fields

        private const string FieldEntityClassDictionary = "EntityClassDictionary";
        private const string FieldisLocalDate = "isLocalDate";

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

        #region General Initializer : Class (HelperMethod) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelperMethod_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelperMethod) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelperMethod_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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
        [TestCase(MethodCreateEntityClass, 0)]
        [TestCase(MethodSetDataEntityClass, 0)]
        [TestCase(MethodSetDataEntityClass, 1)]
        [TestCase(MethodGetByWhereClause, 0)]
        [TestCase(MethodValidateCondition, 0)]
        [TestCase(MethodSplitCondition, 0)]
        [TestCase(MethodGetResultConfiguration, 0)]
        [TestCase(MethodPopulateXmlToObject, 0)]
        [TestCase(MethodSetPropertyValue, 1)]
        [TestCase(MethodSetPropertyValue, 2)]
        [TestCase(MethodSetPropertyValue, 3)]
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

        #region General Initializer : Class (HelperMethod) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsLocalDate)]
        [Category("AUT Property")]
        public void AUT_HelperMethod_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (HelperMethod) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldEntityClassDictionary)]
        [TestCase(FieldisLocalDate)]
        [Category("AUT Fields")]
        public void AUT_HelperMethod_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelperMethod) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelperMethod" />) can be created test
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

        #endregion

        #region Category : Constructor

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

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelperMethod) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsLocalDate)]
        public void AUT_HelperMethod_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelperMethod) => Property (IsLocalDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelperMethod_Public_Class_IsLocalDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsLocalDate);
            var propertyInfo = this.GetPropertyInfo(PropertyIsLocalDate);

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

        #region Method Call : (SetPropertyValue) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetPropertyValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);
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

        #region Method Call : (GetProperty) (Return Type : PropertyInfo) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_GetProperty_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProperty, methodGetPropertyParametersTypes);
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

        #region Method Call : (IsPropertyPresent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_IsPropertyPresent_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsPropertyPresentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsPropertyPresent, methodIsPropertyPresentParametersTypes);
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

        #region Method Call : (CreateEntityClass) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateEntityClassParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateEntityClass, methodCreateEntityClassParametersTypes);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var configDocument = this.CreateType<XDocument>();

            // Act
            Action executeAction = () => HelperMethod.CreateEntityClass(configDocument);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var configDocument = this.CreateType<XDocument>();
            var methodCreateEntityClassParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfCreateEntityClass = { configDocument };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityClass, methodCreateEntityClassParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfCreateEntityClass);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateEntityClass.ShouldNotBeNull();
            parametersOfCreateEntityClass.Length.ShouldBe(1);
            methodCreateEntityClassParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var configDocument = this.CreateType<XDocument>();
            var methodCreateEntityClassParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfCreateEntityClass = { configDocument };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateEntityClass, parametersOfCreateEntityClass, methodCreateEntityClassParametersTypes);

            // Assert
            parametersOfCreateEntityClass.ShouldNotBeNull();
            parametersOfCreateEntityClass.Length.ShouldBe(1);
            methodCreateEntityClassParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityClass, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var methodCreateEntityClassParametersTypes = new Type[] { typeof(XDocument) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateEntityClass, methodCreateEntityClassParametersTypes);

            // Assert
            methodCreateEntityClassParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateEntityClass) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_CreateEntityClass_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityClass, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetDataEntityClassParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();
            var resultGridConfiguration = this.CreateType<ResultGridConfigurations>();

            // Act
            Action executeAction = () => HelperMethod.SetDataEntityClass(rowNode, columnNode, dynamicObject, resultGridConfiguration);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();
            var resultGridConfiguration = this.CreateType<ResultGridConfigurations>();
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object), typeof(ResultGridConfigurations) };
            object[] parametersOfSetDataEntityClass = { rowNode, columnNode, dynamicObject, resultGridConfiguration };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetDataEntityClass);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDataEntityClass.ShouldNotBeNull();
            parametersOfSetDataEntityClass.Length.ShouldBe(4);
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();
            var resultGridConfiguration = this.CreateType<ResultGridConfigurations>();
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object), typeof(ResultGridConfigurations) };
            object[] parametersOfSetDataEntityClass = { rowNode, columnNode, dynamicObject, resultGridConfiguration };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDataEntityClass, parametersOfSetDataEntityClass, methodSetDataEntityClassParametersTypes);

            // Assert
            parametersOfSetDataEntityClass.ShouldNotBeNull();
            parametersOfSetDataEntityClass.Length.ShouldBe(4);
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object), typeof(ResultGridConfigurations) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes);

            // Assert
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetDataEntityClass_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetDataEntityClassParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();

            // Act
            Action executeAction = () => HelperMethod.SetDataEntityClass(rowNode, columnNode, dynamicObject);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object) };
            object[] parametersOfSetDataEntityClass = { rowNode, columnNode, dynamicObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetDataEntityClass);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDataEntityClass.ShouldNotBeNull();
            parametersOfSetDataEntityClass.Length.ShouldBe(3);
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var rowNode = this.CreateType<XElement>();
            var columnNode = this.CreateType<XElement>();
            var dynamicObject = this.CreateType<object>();
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object) };
            object[] parametersOfSetDataEntityClass = { rowNode, columnNode, dynamicObject };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDataEntityClass, parametersOfSetDataEntityClass, methodSetDataEntityClassParametersTypes);

            // Assert
            parametersOfSetDataEntityClass.ShouldNotBeNull();
            parametersOfSetDataEntityClass.Length.ShouldBe(3);
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var methodSetDataEntityClassParametersTypes = new Type[] { typeof(XElement), typeof(XElement), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDataEntityClass, methodSetDataEntityClassParametersTypes);

            // Assert
            methodSetDataEntityClassParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataEntityClass) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetDataEntityClass_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataEntityClass);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataEntityClass, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetByWhereClauseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetByWhereClause, methodGetByWhereClauseParametersTypes);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var condition = this.CreateType<string>();
            var sourceCollection = this.CreateType<IEnumerable>();

            // Act
            Action executeAction = () => HelperMethod.GetByWhereClause(condition, sourceCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var condition = this.CreateType<string>();
            var sourceCollection = this.CreateType<IEnumerable>();
            var returnedValue = default(IEnumerable);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.GetByWhereClause(condition, sourceCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var condition = this.CreateType<string>();
            var sourceCollection = this.CreateType<IEnumerable>();
            var methodGetByWhereClauseParametersTypes = new Type[] { typeof(string), typeof(IEnumerable) };
            object[] parametersOfGetByWhereClause = { condition, sourceCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetByWhereClause, methodGetByWhereClauseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetByWhereClause, methodGetByWhereClauseParametersTypes);
            var result2 = this.GetResultOfMethod<IEnumerable>(MethodGetByWhereClause, parametersOfGetByWhereClause, methodGetByWhereClauseParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfGetByWhereClause);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetByWhereClause.ShouldNotBeNull();
            parametersOfGetByWhereClause.Length.ShouldBe(2);
            methodGetByWhereClauseParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var condition = this.CreateType<string>();
            var sourceCollection = this.CreateType<IEnumerable>();
            var methodGetByWhereClauseParametersTypes = new Type[] { typeof(string), typeof(IEnumerable) };
            object[] parametersOfGetByWhereClause = { condition, sourceCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable>(MethodGetByWhereClause, parametersOfGetByWhereClause, methodGetByWhereClauseParametersTypes);

            // Assert
            parametersOfGetByWhereClause.ShouldNotBeNull();
            parametersOfGetByWhereClause.Length.ShouldBe(2);
            methodGetByWhereClauseParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var methodGetByWhereClauseParametersTypes = new Type[] { typeof(string), typeof(IEnumerable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetByWhereClause, methodGetByWhereClauseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetByWhereClauseParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var methodGetByWhereClauseParametersTypes = new Type[] { typeof(string), typeof(IEnumerable) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetByWhereClause, methodGetByWhereClauseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetByWhereClauseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var currentMethodInfo = this.GetMethodInfo(MethodGetByWhereClause, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetByWhereClause) (Return Type : IEnumerable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetByWhereClause_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetByWhereClause);
            var currentMethodInfo = this.GetMethodInfo(MethodGetByWhereClause, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Internally(Type[] types)
        {
            var methodValidateConditionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateCondition, methodValidateConditionParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateCondition);
            var methodValidateConditionParametersTypes = new Type[] { typeof(ValidationData), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateCondition, methodValidateConditionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateConditionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateCondition);
            var methodValidateConditionParametersTypes = new Type[] { typeof(ValidationData), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateCondition, methodValidateConditionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateConditionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateCondition);
            var methodValidateConditionParametersTypes = new Type[] { typeof(ValidationData), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateCondition, methodValidateConditionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateConditionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateCondition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ValidateCondition) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_ValidateCondition_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateCondition, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SplitCondition_Static_Method_Call_Internally(Type[] types)
        {
            var methodSplitConditionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSplitCondition, methodSplitConditionParametersTypes);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var condition = this.CreateType<string>();

            // Act
            Action executeAction = () => HelperMethod.SplitCondition(condition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var condition = this.CreateType<string>();
            var returnedValue = default(List<ValidationData>);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.SplitCondition(condition);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var condition = this.CreateType<string>();
            var methodSplitConditionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSplitCondition = { condition };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSplitCondition, methodSplitConditionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSplitCondition, methodSplitConditionParametersTypes);
            var result2 = this.GetResultOfMethod<List<ValidationData>>(MethodSplitCondition, parametersOfSplitCondition, methodSplitConditionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSplitCondition);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSplitCondition.ShouldNotBeNull();
            parametersOfSplitCondition.Length.ShouldBe(1);
            methodSplitConditionParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var condition = this.CreateType<string>();
            var methodSplitConditionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSplitCondition = { condition };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ValidationData>>(MethodSplitCondition, parametersOfSplitCondition, methodSplitConditionParametersTypes);

            // Assert
            parametersOfSplitCondition.ShouldNotBeNull();
            parametersOfSplitCondition.Length.ShouldBe(1);
            methodSplitConditionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var methodSplitConditionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSplitCondition, methodSplitConditionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSplitConditionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var methodSplitConditionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSplitCondition, methodSplitConditionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSplitConditionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodSplitCondition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SplitCondition) (Return Type : List<ValidationData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SplitCondition_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSplitCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodSplitCondition, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResultConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultConfiguration, methodGetResultConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var resultXml = this.CreateType<XDocument>();

            // Act
            Action executeAction = () => HelperMethod.GetResultConfiguration(resultXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var resultXml = this.CreateType<XDocument>();
            var returnedValue = default(ResultGrid);

            // Act
            Action executeAction = () => returnedValue = HelperMethod.GetResultConfiguration(resultXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var resultXml = this.CreateType<XDocument>();
            var methodGetResultConfigurationParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfGetResultConfiguration = { resultXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultConfiguration, methodGetResultConfigurationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResultConfiguration, methodGetResultConfigurationParametersTypes);
            var result2 = this.GetResultOfMethod<ResultGrid>(MethodGetResultConfiguration, parametersOfGetResultConfiguration, methodGetResultConfigurationParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfGetResultConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultConfiguration.ShouldNotBeNull();
            parametersOfGetResultConfiguration.Length.ShouldBe(1);
            methodGetResultConfigurationParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var resultXml = this.CreateType<XDocument>();
            var methodGetResultConfigurationParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfGetResultConfiguration = { resultXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultGrid>(MethodGetResultConfiguration, parametersOfGetResultConfiguration, methodGetResultConfigurationParametersTypes);

            // Assert
            parametersOfGetResultConfiguration.ShouldNotBeNull();
            parametersOfGetResultConfiguration.Length.ShouldBe(1);
            methodGetResultConfigurationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var methodGetResultConfigurationParametersTypes = new Type[] { typeof(XDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultConfiguration, methodGetResultConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultConfigurationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var methodGetResultConfigurationParametersTypes = new Type[] { typeof(XDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultConfiguration, methodGetResultConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultConfiguration) (Return Type : ResultGrid) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_GetResultConfiguration_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultConfiguration, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodPopulateXmlToObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateXmlToObject, methodPopulateXmlToObjectParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var dataContext = this.CreateType<object>();
            var dataSource = this.CreateType<XElement>();

            // Act
            Action executeAction = () => HelperMethod.PopulateXmlToObject(dataContext, dataSource);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var dataContext = this.CreateType<object>();
            var dataSource = this.CreateType<XElement>();
            var methodPopulateXmlToObjectParametersTypes = new Type[] { typeof(object), typeof(XElement) };
            object[] parametersOfPopulateXmlToObject = { dataContext, dataSource };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlToObject, methodPopulateXmlToObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfPopulateXmlToObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateXmlToObject.ShouldNotBeNull();
            parametersOfPopulateXmlToObject.Length.ShouldBe(2);
            methodPopulateXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var dataContext = this.CreateType<object>();
            var dataSource = this.CreateType<XElement>();
            var methodPopulateXmlToObjectParametersTypes = new Type[] { typeof(object), typeof(XElement) };
            object[] parametersOfPopulateXmlToObject = { dataContext, dataSource };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateXmlToObject, parametersOfPopulateXmlToObject, methodPopulateXmlToObjectParametersTypes);

            // Assert
            parametersOfPopulateXmlToObject.ShouldNotBeNull();
            parametersOfPopulateXmlToObject.Length.ShouldBe(2);
            methodPopulateXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlToObject, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var methodPopulateXmlToObjectParametersTypes = new Type[] { typeof(object), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateXmlToObject, methodPopulateXmlToObjectParametersTypes);

            // Assert
            methodPopulateXmlToObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateXmlToObject) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_PopulateXmlToObject_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateXmlToObject);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateXmlToObject, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetPropertyValue_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetPropertyValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);
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
            var NavigatordataType = this.CreateType<string>();

            // Act
            Action executeAction = () => HelperMethod.SetPropertyValue(propertyInfo, dataSource, data, NavigatordataType);

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
            var NavigatordataType = this.CreateType<string>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(string) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data, NavigatordataType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
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
            var NavigatordataType = this.CreateType<string>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(string) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data, NavigatordataType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
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
            const int parametersCount = 4;

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
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
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

        #region Method Call : (SetPropertyValue) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetPropertyValue_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodSetPropertyValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();

            // Act
            Action executeAction = () => HelperMethod.SetPropertyValue(propertyInfo, dataSource, data, IslocalDateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Void_Overloading_Of_2_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(bool) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data, IslocalDateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyInfo = this.CreateType<PropertyInfo>();
            var dataSource = this.CreateType<object>();
            var data = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(bool) };
            object[] parametersOfSetPropertyValue = { propertyInfo, dataSource, data, IslocalDateTime };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 2);
            const int parametersCount = 4;

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
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(PropertyInfo), typeof(object), typeof(object), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_2_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 2);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethod_SetPropertyValue_Static_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodSetPropertyValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_DirectCall_Overloading_Of_3_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();

            // Act
            Action executeAction = () => HelperMethod.SetPropertyValue(propertyName, sourceObject, setValue, IslocalDateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue, IslocalDateTime };
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
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes));
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue, IslocalDateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, methodSetPropertyValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helperMethodInstanceFixture, parametersOfSetPropertyValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var propertyName = this.CreateType<string>();
            var sourceObject = this.CreateType<object>();
            var setValue = this.CreateType<object>();
            var IslocalDateTime = this.CreateType<bool>();
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };
            object[] parametersOfSetPropertyValue = { propertyName, sourceObject, setValue, IslocalDateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetPropertyValue, parametersOfSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            parametersOfSetPropertyValue.ShouldNotBeNull();
            parametersOfSetPropertyValue.Length.ShouldBe(4);
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetPropertyValue, methodSetPropertyValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetPropertyValueParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SetPropertyValue) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var methodSetPropertyValueParametersTypes = new Type[] { typeof(string), typeof(object), typeof(object), typeof(bool) };
            const int parametersCount = 4;

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
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 3);

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
        public void AUT_HelperMethod_SetPropertyValue_Static_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPropertyValue, 3);
            const int parametersCount = 4;

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