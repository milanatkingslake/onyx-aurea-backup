using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Cache;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Cache
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Cache.GrammarDefinition" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Cache"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GrammarDefinitionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GrammarDefinition" />)
        /// </summary>
        public GrammarDefinitionTest() : base(typeof(GrammarDefinition))
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

        #region General Initializer : Class (GrammarDefinition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _grammarDefinitionInstanceType;
        private GrammarDefinition _grammarDefinitionInstance;
        private GrammarDefinition _grammarDefinitionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GrammarDefinition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _grammarDefinitionInstanceType = typeof(GrammarDefinition);
            _grammarDefinitionInstanceFixture = this.Create<GrammarDefinition>(false);
            _grammarDefinitionInstance = _grammarDefinitionInstanceFixture ?? this.Create<GrammarDefinition>(true);
            CurrentInstance = _grammarDefinitionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GrammarDefinition) Initializer

        #region Properties

        private const string Propertyname = "name";
        private const string PropertyclassName = "className";
        private const string PropertymoduleName = "moduleName";
        private const string PropertyassemblyName = "assemblyName";
        private const string Propertytype = "type";

        #endregion

        #region Methods

        private const string MethodDeserialise = "Deserialise";
        private const string MethodImplementsInterface = "ImplementsInterface";

        #endregion

        #region Fields

        private const string Fieldm_name = "m_name";
        private const string Fieldm_className = "m_className";
        private const string Fieldm_moduleName = "m_moduleName";
        private const string Fieldm_assemblyName = "m_assemblyName";
        private const string Fieldm_type = "m_type";

        #endregion

        #endregion

        #region General Initializer : Class (GrammarDefinition) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinition_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarDefinition) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinition_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarDefinition) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinition_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GrammarDefinition)

        #region General Initializer : Class (GrammarDefinition) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodDeserialise, 0)]
        [TestCase(MethodImplementsInterface, 0)]
        public void AUT_GrammarDefinition_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GrammarDefinition) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyname)]
        [TestCase(PropertyclassName)]
        [TestCase(PropertymoduleName)]
        [TestCase(PropertyassemblyName)]
        [TestCase(Propertytype)]
        [Category("AUT Property")]
        public void AUT_GrammarDefinition_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GrammarDefinition) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_name)]
        [TestCase(Fieldm_className)]
        [TestCase(Fieldm_moduleName)]
        [TestCase(Fieldm_assemblyName)]
        [TestCase(Fieldm_type)]
        [Category("AUT Fields")]
        public void AUT_GrammarDefinition_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GrammarDefinition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarDefinition_Is_Instance_Present_Test()
        {
            // Assert
            _grammarDefinitionInstanceType.ShouldNotBeNull();
            _grammarDefinitionInstance.ShouldNotBeNull();
            _grammarDefinitionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GrammarDefinition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GrammarDefinition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarDefinition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _grammarDefinitionInstance.ShouldBeAssignableTo<GrammarDefinition>();
            _grammarDefinitionInstanceFixture.ShouldBeAssignableTo<GrammarDefinition>();
            CurrentInstance.ShouldBeAssignableTo<GrammarDefinition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GrammarDefinition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarDefinition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            GrammarDefinition instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GrammarDefinition) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyname)]
        [TestCase(PropertyclassName)]
        [TestCase(PropertymoduleName)]
        [TestCase(PropertyassemblyName)]
        [TestCase(Propertytype)]
        public void AUT_GrammarDefinition_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GrammarDefinition) => Property (assemblyName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_assemblyName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyassemblyName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyassemblyName);
            Action currentAction = () => propertyInfo.SetValue(_grammarDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (assemblyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_Public_Class_assemblyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyassemblyName);
            var propertyInfo = this.GetPropertyInfo(PropertyassemblyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (className) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_Public_Class_className_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyclassName);
            var propertyInfo = this.GetPropertyInfo(PropertyclassName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (moduleName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_Public_Class_moduleName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymoduleName);
            var propertyInfo = this.GetPropertyInfo(PropertymoduleName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_Public_Class_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyname);
            var propertyInfo = this.GetPropertyInfo(Propertyname);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytype);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertytype);
            Action currentAction = () => propertyInfo.SetValue(_grammarDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinition) => Property (type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinition_Public_Class_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytype);
            var propertyInfo = this.GetPropertyInfo(Propertytype);

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

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var definitionNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => GrammarDefinition.Deserialise(definitionNode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var definitionNode = this.CreateType<XmlNode>();
            var returnedValue = default(GrammarDefinition);

            // Act
            Action executeAction = () => returnedValue = GrammarDefinition.Deserialise(definitionNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var definitionNode = this.CreateType<XmlNode>();
            var methodDeserialiseParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfDeserialise = { definitionNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeserialise, methodDeserialiseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDeserialise, methodDeserialiseParametersTypes);
            var result2 = this.GetResultOfMethod<GrammarDefinition>(MethodDeserialise, parametersOfDeserialise, methodDeserialiseParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_grammarDefinitionInstanceFixture, parametersOfDeserialise);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeserialise.ShouldNotBeNull();
            parametersOfDeserialise.Length.ShouldBe(1);
            methodDeserialiseParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var definitionNode = this.CreateType<XmlNode>();
            var methodDeserialiseParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfDeserialise = { definitionNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GrammarDefinition>(MethodDeserialise, parametersOfDeserialise, methodDeserialiseParametersTypes);

            // Assert
            parametersOfDeserialise.ShouldNotBeNull();
            parametersOfDeserialise.Length.ShouldBe(1);
            methodDeserialiseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var methodDeserialiseParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeserialise, methodDeserialiseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeserialiseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var methodDeserialiseParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeserialise, methodDeserialiseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeserialiseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var currentMethodInfo = this.GetMethodInfo(MethodDeserialise, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Deserialise) (Return Type : GrammarDefinition) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_Deserialise_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeserialise);
            var currentMethodInfo = this.GetMethodInfo(MethodDeserialise, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GrammarDefinition_ImplementsInterface_Method_Call_Internally(Type[] types)
        {
            var methodImplementsInterfaceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodImplementsInterface, methodImplementsInterfaceParametersTypes);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var pInterfaceType = this.CreateType<Type>();

            // Act
            Action executeAction = () => _grammarDefinitionInstance.ImplementsInterface(pInterfaceType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var pInterfaceType = this.CreateType<Type>();
            var methodImplementsInterfaceParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfImplementsInterface = { pInterfaceType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodImplementsInterface, methodImplementsInterfaceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_grammarDefinitionInstanceFixture, parametersOfImplementsInterface);
            var result2 = this.GetResultOfMethod<bool>(MethodImplementsInterface, parametersOfImplementsInterface, methodImplementsInterfaceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfImplementsInterface.ShouldNotBeNull();
            parametersOfImplementsInterface.Length.ShouldBe(1);
            methodImplementsInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var pInterfaceType = this.CreateType<Type>();
            var methodImplementsInterfaceParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfImplementsInterface = { pInterfaceType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodImplementsInterface, methodImplementsInterfaceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_grammarDefinitionInstanceFixture, out exception1, parametersOfImplementsInterface);
            var result2 = this.GetResultOfMethod<bool>(MethodImplementsInterface, parametersOfImplementsInterface, methodImplementsInterfaceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfImplementsInterface.ShouldNotBeNull();
            parametersOfImplementsInterface.Length.ShouldBe(1);
            methodImplementsInterfaceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var pInterfaceType = this.CreateType<Type>();
            var methodImplementsInterfaceParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfImplementsInterface = { pInterfaceType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodImplementsInterface, parametersOfImplementsInterface, methodImplementsInterfaceParametersTypes);

            // Assert
            parametersOfImplementsInterface.ShouldNotBeNull();
            parametersOfImplementsInterface.Length.ShouldBe(1);
            methodImplementsInterfaceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var methodImplementsInterfaceParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodImplementsInterface, methodImplementsInterfaceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodImplementsInterfaceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var currentMethodInfo = this.GetMethodInfo(MethodImplementsInterface, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ImplementsInterface) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinition_ImplementsInterface_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodImplementsInterface);
            var currentMethodInfo = this.GetMethodInfo(MethodImplementsInterface, 0);
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