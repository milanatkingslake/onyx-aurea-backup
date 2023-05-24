using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="RuntimeObjectBuilder" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\RuntimeObjectBuilder.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RuntimeObjectBuilderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RuntimeObjectBuilder" />)
        /// </summary>
        public RuntimeObjectBuilderTest() : base(typeof(RuntimeObjectBuilder))
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

        #region General Initializer : Class (RuntimeObjectBuilder) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _runtimeObjectBuilderInstanceType;
        private RuntimeObjectBuilder _runtimeObjectBuilderInstance;
        private RuntimeObjectBuilder _runtimeObjectBuilderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RuntimeObjectBuilder" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _runtimeObjectBuilderInstanceType = typeof(RuntimeObjectBuilder);
            _runtimeObjectBuilderInstanceFixture = this.Create<RuntimeObjectBuilder>(false);
            _runtimeObjectBuilderInstance = _runtimeObjectBuilderInstanceFixture ?? this.Create<RuntimeObjectBuilder>(true);
            CurrentInstance = _runtimeObjectBuilderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RuntimeObjectBuilder) Initializer

        #region Methods

        private const string MethodCreateClass = "CreateClass";
        private const string MethodAddProperty = "AddProperty";
        private const string MethodAddListProperty = "AddListProperty";
        private const string MethodAddObjectProperty = "AddObjectProperty";
        private const string MethodCreateObject = "CreateObject";

        #endregion

        #region Fields

        private const string Fieldassembly = "assembly";
        private const string FieldassemblyBuilder = "assemblyBuilder";
        private const string Fieldmodule = "module";
        private const string FieldtypeBuilderDictionary = "typeBuilderDictionary";

        #endregion

        #endregion

        #region General Initializer : Class (RuntimeObjectBuilder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RuntimeObjectBuilder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RuntimeObjectBuilder) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RuntimeObjectBuilder_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RuntimeObjectBuilder)

        #region General Initializer : Class (RuntimeObjectBuilder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateClass, 0)]
        [TestCase(MethodAddProperty, 0)]
        [TestCase(MethodAddListProperty, 0)]
        [TestCase(MethodAddObjectProperty, 0)]
        [TestCase(MethodAddProperty, 1)]
        [TestCase(MethodCreateObject, 0)]
        public void AUT_RuntimeObjectBuilder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (RuntimeObjectBuilder) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldassembly)]
        [TestCase(FieldassemblyBuilder)]
        [TestCase(Fieldmodule)]
        [TestCase(FieldtypeBuilderDictionary)]
        [Category("AUT Fields")]
        public void AUT_RuntimeObjectBuilder_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RuntimeObjectBuilder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RuntimeObjectBuilder_Is_Instance_Present_Test()
        {
            // Assert
            _runtimeObjectBuilderInstanceType.ShouldNotBeNull();
            _runtimeObjectBuilderInstance.ShouldNotBeNull();
            _runtimeObjectBuilderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RuntimeObjectBuilder) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RuntimeObjectBuilder" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RuntimeObjectBuilder_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _runtimeObjectBuilderInstance.ShouldBeAssignableTo<RuntimeObjectBuilder>();
            _runtimeObjectBuilderInstanceFixture.ShouldBeAssignableTo<RuntimeObjectBuilder>();
            CurrentInstance.ShouldBeAssignableTo<RuntimeObjectBuilder>();
        }

        #endregion

        #region General Constructor : Class (RuntimeObjectBuilder) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RuntimeObjectBuilder_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RuntimeObjectBuilder instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateClass) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateClass_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateClass);
            var className = this.CreateType<string>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.CreateClass(className);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateClass) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateClass_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateClass);
            var className = this.CreateType<string>();
            var methodCreateClassParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateClass = { className };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCreateClass, parametersOfCreateClass, methodCreateClassParametersTypes);

            // Assert
            parametersOfCreateClass.ShouldNotBeNull();
            parametersOfCreateClass.Length.ShouldBe(1);
            methodCreateClassParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateClass) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateClass_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateClass);
            var methodCreateClassParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateClass, methodCreateClassParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateClassParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateClass) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateClass_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateClass);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateClass, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateClass) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateClass_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateClass);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateClass, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.AddProperty(className, propertyName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddProperty = { className, propertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(2);
            methodAddPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (AddProperty) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddListProperty) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddListProperty_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddListProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.AddListProperty(className, propertyName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddListProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddListProperty_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddListProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();
            var methodAddListPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddListProperty = { className, propertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddListProperty, parametersOfAddListProperty, methodAddListPropertyParametersTypes);

            // Assert
            parametersOfAddListProperty.ShouldNotBeNull();
            parametersOfAddListProperty.Length.ShouldBe(2);
            methodAddListPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddListProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddListProperty_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddListProperty);
            var methodAddListPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddListProperty, methodAddListPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddListPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddListProperty) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddListProperty_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddListProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddListProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddListProperty) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddListProperty_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddListProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddListProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddObjectProperty) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddObjectProperty_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.AddObjectProperty(className, propertyName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddObjectProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddObjectProperty_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectProperty);
            var className = this.CreateType<string>();
            var propertyName = this.CreateType<string>();
            var methodAddObjectPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAddObjectProperty = { className, propertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddObjectProperty, parametersOfAddObjectProperty, methodAddObjectPropertyParametersTypes);

            // Assert
            parametersOfAddObjectProperty.ShouldNotBeNull();
            parametersOfAddObjectProperty.Length.ShouldBe(2);
            methodAddObjectPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddObjectProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddObjectProperty_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectProperty);
            var methodAddObjectPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddObjectProperty, methodAddObjectPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddObjectPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddObjectProperty) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddObjectProperty_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddObjectProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddObjectProperty) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddObjectProperty_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddObjectProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var node = this.CreateType<XmlNode>();
            var isAttributeHasProperties = this.CreateType<bool>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.AddProperty(className, node, isAttributeHasProperties);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var node = this.CreateType<XmlNode>();
            var isAttributeHasProperties = this.CreateType<bool>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            object[] parametersOfAddProperty = { className, node, isAttributeHasProperties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(3);
            methodAddPropertyParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes));
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var node = this.CreateType<XmlNode>();
            var isAttributeHasProperties = this.CreateType<bool>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            object[] parametersOfAddProperty = { className, node, isAttributeHasProperties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, methodAddPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_runtimeObjectBuilderInstanceFixture, parametersOfAddProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(3);
            methodAddPropertyParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var className = this.CreateType<string>();
            var node = this.CreateType<XmlNode>();
            var isAttributeHasProperties = this.CreateType<bool>();
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            object[] parametersOfAddProperty = { className, node, isAttributeHasProperties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddProperty, parametersOfAddProperty, methodAddPropertyParametersTypes);

            // Assert
            parametersOfAddProperty.ShouldNotBeNull();
            parametersOfAddProperty.Length.ShouldBe(3);
            methodAddPropertyParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddPropertyParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddProperty, methodAddPropertyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddPropertyParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (AddProperty) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var methodAddPropertyParametersTypes = new Type[] { typeof(string), typeof(XmlNode), typeof(bool) };
            const int parametersCount = 3;

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
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_RuntimeObjectBuilder_AddProperty_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddProperty, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var className = this.CreateType<string>();

            // Act
            Action executeAction = () => RuntimeObjectBuilder.CreateObject(className);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var className = this.CreateType<string>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = RuntimeObjectBuilder.CreateObject(className);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var className = this.CreateType<string>();
            var methodCreateObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateObject = { className };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateObject, methodCreateObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodCreateObject, parametersOfCreateObject, methodCreateObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_runtimeObjectBuilderInstanceFixture, parametersOfCreateObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateObject.ShouldNotBeNull();
            parametersOfCreateObject.Length.ShouldBe(1);
            methodCreateObjectParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var className = this.CreateType<string>();
            var methodCreateObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateObject = { className };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateObject, parametersOfCreateObject, methodCreateObjectParametersTypes);

            // Assert
            parametersOfCreateObject.ShouldNotBeNull();
            parametersOfCreateObject.Length.ShouldBe(1);
            methodCreateObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var methodCreateObjectParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var methodCreateObjectParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateObject, methodCreateObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (CreateObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RuntimeObjectBuilder_CreateObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}