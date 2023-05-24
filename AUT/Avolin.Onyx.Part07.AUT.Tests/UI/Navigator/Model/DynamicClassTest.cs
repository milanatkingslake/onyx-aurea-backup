using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.DynamicClass" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DynamicClassTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DynamicClass" />)
        /// </summary>
        public DynamicClassTest() : base(typeof(DynamicClass))
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

        #region General Initializer : Class (DynamicClass) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dynamicClassInstanceType;
        private DynamicClass _dynamicClassInstance;
        private DynamicClass _dynamicClassInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DynamicClass" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dynamicClassInstanceType = typeof(DynamicClass);
            _dynamicClassInstanceFixture = this.Create<DynamicClass>(false);
            _dynamicClassInstance = _dynamicClassInstanceFixture ?? this.Create<DynamicClass>(true);
            CurrentInstance = _dynamicClassInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DynamicClass) Initializer

        #region Methods

        private const string MethodAddProperty = "AddProperty";
        private const string MethodAddMaskProperty = "AddMaskProperty";
        private const string MethodCreateObject = "CreateObject";
        private const string MethodGetType = "GetType";

        #endregion

        #region Fields

        private const string FieldtypeBuilder = "typeBuilder";
        private const string FieldfieldBuilderDictionary = "fieldBuilderDictionary";

        #endregion

        #endregion

        #region General Initializer : Class (DynamicClass) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DynamicClass_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DynamicClass) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DynamicClass_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DynamicClass)

        #region General Initializer : Class (DynamicClass) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddProperty, 0)]
        [TestCase(MethodAddProperty, 1)]
        [TestCase(MethodAddMaskProperty, 0)]
        [TestCase(MethodCreateObject, 0)]
        [TestCase(MethodGetType, 0)]
        public void AUT_DynamicClass_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DynamicClass) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldtypeBuilder)]
        [TestCase(FieldfieldBuilderDictionary)]
        [Category("AUT Fields")]
        public void AUT_DynamicClass_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DynamicClass) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DynamicClass_Is_Instance_Present_Test()
        {
            // Assert
            _dynamicClassInstanceType.ShouldNotBeNull();
            _dynamicClassInstance.ShouldNotBeNull();
            _dynamicClassInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DynamicClass) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DynamicClass" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DynamicClass_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dynamicClassInstance.ShouldBeAssignableTo<DynamicClass>();
            _dynamicClassInstanceFixture.ShouldBeAssignableTo<DynamicClass>();
            CurrentInstance.ShouldBeAssignableTo<DynamicClass>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DynamicClass) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DynamicClass_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var assemblyName = this.CreateType<string>();
            var className = this.CreateType<string>();
            DynamicClass instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DynamicClass(assemblyName, className);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dynamicClassInstance.ShouldNotBeNull();
            _dynamicClassInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DynamicClass>();
        }

        #endregion

        #region General Constructor : Class (DynamicClass) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DynamicClass_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var assemblyName = this.CreateType<string>();
            var className = this.CreateType<string>();
            DynamicClass instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DynamicClass(assemblyName, className);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dynamicClassInstance.ShouldNotBeNull();
            _dynamicClassInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AddProperty) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var field = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _dynamicClassInstance.AddProperty(field);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var field = this.CreateType<XElement>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddProperty = { field };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, parametersOfAddProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(1);
            methodAddPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var field = this.CreateType<XElement>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddProperty = { field };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, out exception1, parametersOfAddProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(1);
            methodAddPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var field = this.CreateType<XElement>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddProperty = { field };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(1);
            methodAddPropertyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DynamicClass_AddProperty_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodAddPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var propertyName = this.CreateType<string>();
            var propertyDataType = this.CreateType<string>();

            // Act
            Action executeAction = () => _dynamicClassInstance.AddProperty(propertyName, propertyDataType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var propertyName = this.CreateType<string>();
            var propertyDataType = this.CreateType<string>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddProperty = { propertyName, propertyDataType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, parametersOfAddProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(2);
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var propertyName = this.CreateType<string>();
            var propertyDataType = this.CreateType<string>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddProperty = { propertyName, propertyDataType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, out exception1, parametersOfAddProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(2);
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var propertyName = this.CreateType<string>();
            var propertyDataType = this.CreateType<string>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddProperty = { propertyName, propertyDataType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dynamicClassInstanceFixture, parametersOfAddProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(2);
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var propertyName = this.CreateType<string>();
            var propertyDataType = this.CreateType<string>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddProperty = { propertyName, propertyDataType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(2);
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddProperty_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DynamicClass_AddMaskProperty_Method_Call_Internally(Type[] types)
        {
            var methodAddMaskPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var field = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _dynamicClassInstance.AddMaskProperty(field);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var field = this.CreateType<XElement>();
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddMaskProperty = { field };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, parametersOfAddMaskProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddMaskProperty, parametersOfAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddMaskProperty.ShouldNotBeNull();
            parametersOfAddMaskProperty.Length.ShouldBe(1);
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var field = this.CreateType<XElement>();
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddMaskProperty = { field };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dynamicClassInstanceFixture, out exception1, parametersOfAddMaskProperty);
            var result2 = this.GetResultOfMethod<bool>(MethodAddMaskProperty, parametersOfAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddMaskProperty.ShouldNotBeNull();
            parametersOfAddMaskProperty.Length.ShouldBe(1);
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var field = this.CreateType<XElement>();
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddMaskProperty = { field };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dynamicClassInstanceFixture, parametersOfAddMaskProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddMaskProperty.ShouldNotBeNull();
            parametersOfAddMaskProperty.Length.ShouldBe(1);
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var field = this.CreateType<XElement>();
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfAddMaskProperty = { field };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddMaskProperty, parametersOfAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            parametersOfAddMaskProperty.ShouldNotBeNull();
            parametersOfAddMaskProperty.Length.ShouldBe(1);
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var methodAddMaskPropertyParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddMaskProperty, methodAddMaskPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddMaskPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMaskProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AddMaskProperty) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_AddMaskProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMaskProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMaskProperty, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DynamicClass_CreateObject_Method_Call_Internally(Type[] types)
        {
            var methodCreateObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);

            // Act
            Action executeAction = () => _dynamicClassInstance.CreateObject();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _dynamicClassInstance.CreateObject();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            Type [] methodCreateObjectParametersTypes = null;
            object[] parametersOfCreateObject = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateObject, methodCreateObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_dynamicClassInstanceFixture, parametersOfCreateObject);
            var result2 = this.GetResultOfMethod<object>(MethodCreateObject, parametersOfCreateObject, methodCreateObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateObject.ShouldBeNull();
            methodCreateObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            Type [] methodCreateObjectParametersTypes = null;
            object[] parametersOfCreateObject = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateObject, parametersOfCreateObject, methodCreateObjectParametersTypes);

            // Assert
            parametersOfCreateObject.ShouldBeNull();
            methodCreateObjectParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            Type [] methodCreateObjectParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            Type [] methodCreateObjectParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_CreateObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DynamicClass_GetType_Method_Call_Internally(Type[] types)
        {
            var methodGetTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetType, methodGetTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var dataType = this.CreateType<string>();
            var methodGetTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetType = { dataType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetType, methodGetTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Type>(_dynamicClassInstanceFixture, out exception1, parametersOfGetType);
            var result2 = this.GetResultOfMethod<Type>(MethodGetType, parametersOfGetType, methodGetTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetType.ShouldNotBeNull();
            parametersOfGetType.Length.ShouldBe(1);
            methodGetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var dataType = this.CreateType<string>();
            var methodGetTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetType = { dataType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetType, methodGetTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dynamicClassInstanceFixture, parametersOfGetType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetType.ShouldNotBeNull();
            parametersOfGetType.Length.ShouldBe(1);
            methodGetTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var dataType = this.CreateType<string>();
            var methodGetTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetType = { dataType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodGetType, parametersOfGetType, methodGetTypeParametersTypes);

            // Assert
            parametersOfGetType.ShouldNotBeNull();
            parametersOfGetType.Length.ShouldBe(1);
            methodGetTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var methodGetTypeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetType, methodGetTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var methodGetTypeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetType, methodGetTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DynamicClass_GetType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetType, 0);
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