using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.GrammarBase" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GrammarBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GrammarBase" />)
        /// </summary>
        public GrammarBaseTest() : base(typeof(GrammarBase))
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

        #region General Initializer : Class (GrammarBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _grammarBaseInstanceType;
        private GrammarBase _grammarBaseInstance;
        private GrammarBase _grammarBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GrammarBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _grammarBaseInstanceType = typeof(GrammarBase);
            _grammarBaseInstanceFixture = this.Create<GrammarBase>(false);
            _grammarBaseInstance = _grammarBaseInstanceFixture ?? this.Create<GrammarBase>(true);
            CurrentInstance = _grammarBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GrammarBase) Initializer

        #region Properties

        private const string Propertyengine = "engine";
        private const string PropertymetadataNode = "metadataNode";
        private const string PropertyisActive = "isActive";
        private const string PropertynamespaceManager = "namespaceManager";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodCreateInstance = "CreateInstance";
        private const string MethodGetChildElements = "GetChildElements";

        #endregion

        #region Fields

        private const string Fieldm_engine = "m_engine";
        private const string Fieldm_metadataNode = "m_metadataNode";
        private const string Fieldm_namespaceManager = "m_namespaceManager";

        #endregion

        #endregion

        #region General Initializer : Class (GrammarBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarBase) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarBase_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarBase) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarBase_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GrammarBase)

        #region General Initializer : Class (GrammarBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateInstance, 0)]
        [TestCase(MethodCreateInstance, 1)]
        [TestCase(MethodGetChildElements, 0)]
        [TestCase(MethodGetChildElements, 1)]
        public void AUT_GrammarBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GrammarBase) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyengine)]
        [TestCase(PropertymetadataNode)]
        [TestCase(PropertyisActive)]
        [TestCase(PropertynamespaceManager)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_GrammarBase_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GrammarBase) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_engine)]
        [TestCase(Fieldm_metadataNode)]
        [TestCase(Fieldm_namespaceManager)]
        [Category("AUT Fields")]
        public void AUT_GrammarBase_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GrammarBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarBase_Is_Instance_Present_Test()
        {
            // Assert
            _grammarBaseInstanceType.ShouldNotBeNull();
            _grammarBaseInstance.ShouldNotBeNull();
            _grammarBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GrammarBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _grammarBaseInstance.ShouldBeAssignableTo<GrammarBase>();
            _grammarBaseInstanceFixture.ShouldBeAssignableTo<GrammarBase>();
            CurrentInstance.ShouldBeAssignableTo<GrammarBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GrammarBase) instance created

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarBase_Is_Created_Test()
        {
            // Assert
            _grammarBaseInstance.ShouldNotBeNull();
            _grammarBaseInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (GrammarBase) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="GrammarBase" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_GrammarBase_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (GrammarBase) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="GrammarBase" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarBase_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (GrammarBase) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="GrammarBase" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarBase_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodGrammarBaseParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodGrammarBaseParametersTypes);
        }

        #endregion

        #region General Constructor : Class (GrammarBase) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="GrammarBase" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarBase_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodGrammarBaseParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodGrammarBaseParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GrammarBase) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyengine)]
        [TestCase(PropertymetadataNode)]
        [TestCase(PropertyisActive)]
        [TestCase(PropertynamespaceManager)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_GrammarBase_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GrammarBase) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyassemblyClassName);
            var propertyInfo = this.GetPropertyInfo(PropertyassemblyClassName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (engine) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_engine_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyengine);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyengine);
            Action currentAction = () => propertyInfo.SetValue(_grammarBaseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (engine) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_Public_Class_engine_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyengine);
            var propertyInfo = this.GetPropertyInfo(Propertyengine);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (isActive) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_Public_Class_isActive_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyisActive);
            var propertyInfo = this.GetPropertyInfo(PropertyisActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (metadataNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_metadataNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymetadataNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertymetadataNode);
            Action currentAction = () => propertyInfo.SetValue(_grammarBaseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (metadataNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_Public_Class_metadataNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymetadataNode);
            var propertyInfo = this.GetPropertyInfo(PropertymetadataNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (namespaceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_namespaceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynamespaceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertynamespaceManager);
            Action currentAction = () => propertyInfo.SetValue(_grammarBaseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarBase) => Property (namespaceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarBase_Public_Class_namespaceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynamespaceManager);
            var propertyInfo = this.GetPropertyInfo(PropertynamespaceManager);

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

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => GrammarBase.CreateInstance(pMetadataNode, pRequiredInterfaceType, pEngine, pNamespaceManager);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(GrammarBase);

            // Act
            Action executeAction = () => returnedValue = GrammarBase.CreateInstance(pMetadataNode, pRequiredInterfaceType, pEngine, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(InternalEngine), typeof(XmlNamespaceManager) };
            object[] parametersOfCreateInstance = { pMetadataNode, pRequiredInterfaceType, pEngine, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, methodCreateInstanceParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);
            var result2 = this.GetResultOfMethod<GrammarBase>(MethodCreateInstance, parametersOfCreateInstance, methodCreateInstanceParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_grammarBaseInstanceFixture, parametersOfCreateInstance);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateInstance.ShouldNotBeNull();
            parametersOfCreateInstance.Length.ShouldBe(4);
            methodCreateInstanceParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(InternalEngine), typeof(XmlNamespaceManager) };
            object[] parametersOfCreateInstance = { pMetadataNode, pRequiredInterfaceType, pEngine, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GrammarBase>(MethodCreateInstance, parametersOfCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            parametersOfCreateInstance.ShouldNotBeNull();
            parametersOfCreateInstance.Length.ShouldBe(4);
            methodCreateInstanceParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateInstanceParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(InternalEngine), typeof(XmlNamespaceManager) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateInstanceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GrammarBase_CreateInstance_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateInstanceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pGrammarBase = this.CreateType<GrammarBase>();

            // Act
            Action executeAction = () => GrammarBase.CreateInstance(pMetadataNode, pRequiredInterfaceType, pGrammarBase);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pGrammarBase = this.CreateType<GrammarBase>();
            var returnedValue = default(GrammarBase);

            // Act
            Action executeAction = () => returnedValue = GrammarBase.CreateInstance(pMetadataNode, pRequiredInterfaceType, pGrammarBase);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pGrammarBase = this.CreateType<GrammarBase>();
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(GrammarBase) };
            object[] parametersOfCreateInstance = { pMetadataNode, pRequiredInterfaceType, pGrammarBase };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, methodCreateInstanceParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);
            var result2 = this.GetResultOfMethod<GrammarBase>(MethodCreateInstance, parametersOfCreateInstance, methodCreateInstanceParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_grammarBaseInstanceFixture, parametersOfCreateInstance);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateInstance.ShouldNotBeNull();
            parametersOfCreateInstance.Length.ShouldBe(3);
            methodCreateInstanceParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pRequiredInterfaceType = this.CreateType<Type>();
            var pGrammarBase = this.CreateType<GrammarBase>();
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(GrammarBase) };
            object[] parametersOfCreateInstance = { pMetadataNode, pRequiredInterfaceType, pGrammarBase };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GrammarBase>(MethodCreateInstance, parametersOfCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            parametersOfCreateInstance.ShouldNotBeNull();
            parametersOfCreateInstance.Length.ShouldBe(3);
            methodCreateInstanceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(GrammarBase) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateInstanceParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var methodCreateInstanceParametersTypes = new Type[] { typeof(XmlNode), typeof(Type), typeof(GrammarBase) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateInstance, methodCreateInstanceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateInstanceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateInstance) (Return Type : GrammarBase) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_CreateInstance_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateInstance, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GrammarBase_GetChildElements_Method_Call_Internally(Type[] types)
        {
            var methodGetChildElementsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            Type [] methodGetChildElementsParametersTypes = null;
            object[] parametersOfGetChildElements = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildElements, methodGetChildElementsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNodeList>(_grammarBaseInstanceFixture, parametersOfGetChildElements);
            var result2 = this.GetResultOfMethod<XmlNodeList>(MethodGetChildElements, parametersOfGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetChildElements.ShouldBeNull();
            methodGetChildElementsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            Type [] methodGetChildElementsParametersTypes = null;
            object[] parametersOfGetChildElements = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNodeList>(MethodGetChildElements, parametersOfGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            parametersOfGetChildElements.ShouldBeNull();
            methodGetChildElementsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            Type [] methodGetChildElementsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetChildElementsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            Type [] methodGetChildElementsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetChildElementsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildElements, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GrammarBase_GetChildElements_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetChildElementsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var pParentNode = this.CreateType<XmlNode>();
            var methodGetChildElementsParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetChildElements = { pParentNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildElements, methodGetChildElementsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNodeList>(_grammarBaseInstanceFixture, parametersOfGetChildElements);
            var result2 = this.GetResultOfMethod<XmlNodeList>(MethodGetChildElements, parametersOfGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetChildElements.ShouldNotBeNull();
            parametersOfGetChildElements.Length.ShouldBe(1);
            methodGetChildElementsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var pParentNode = this.CreateType<XmlNode>();
            var methodGetChildElementsParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetChildElements = { pParentNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNodeList>(MethodGetChildElements, parametersOfGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            parametersOfGetChildElements.ShouldNotBeNull();
            parametersOfGetChildElements.Length.ShouldBe(1);
            methodGetChildElementsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var methodGetChildElementsParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetChildElementsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var methodGetChildElementsParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetChildElements, methodGetChildElementsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetChildElementsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildElements, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildElements) (Return Type : XmlNodeList) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarBase_GetChildElements_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildElements);
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildElements, 1);
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