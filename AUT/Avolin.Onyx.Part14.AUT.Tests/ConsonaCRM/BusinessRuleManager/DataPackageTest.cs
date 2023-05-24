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
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.DataPackage" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DataPackageTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DataPackage" />)
        /// </summary>
        public DataPackageTest() : base(typeof(DataPackage))
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

        #region General Initializer : Class (DataPackage) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dataPackageInstanceType;
        private DataPackage _dataPackageInstance;
        private DataPackage _dataPackageInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DataPackage" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dataPackageInstanceType = typeof(DataPackage);
            _dataPackageInstanceFixture = this.Create<DataPackage>(false);
            _dataPackageInstance = _dataPackageInstanceFixture ?? this.Create<DataPackage>(true);
            CurrentInstance = _dataPackageInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DataPackage) Initializer

        #region Properties

        private const string PropertyxmlDoc = "xmlDoc";
        private const string PropertycontextNode = "contextNode";
        private const string Propertyinitialized = "initialized";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodSetDocument = "SetDocument";

        #endregion

        #region Fields

        private const string Fieldm_xmlDoc = "m_xmlDoc";
        private const string Fieldm_contextNode = "m_contextNode";
        private const string Fieldm_initialized = "m_initialized";

        #endregion

        #endregion

        #region General Initializer : Class (DataPackage) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataPackage_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataPackage) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataPackage_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataPackage) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataPackage_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DataPackage)

        #region General Initializer : Class (DataPackage) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetDocument, 0)]
        [TestCase(MethodSetDocument, 1)]
        [TestCase(MethodSetDocument, 2)]
        public void AUT_DataPackage_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DataPackage) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycontextNode)]
        [TestCase(Propertyinitialized)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_DataPackage_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DataPackage) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_xmlDoc)]
        [TestCase(Fieldm_contextNode)]
        [TestCase(Fieldm_initialized)]
        [Category("AUT Fields")]
        public void AUT_DataPackage_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DataPackage) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DataPackage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DataPackage_Is_Instance_Present_Test()
        {
            // Assert
            _dataPackageInstanceType.ShouldNotBeNull();
            _dataPackageInstance.ShouldNotBeNull();
            _dataPackageInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DataPackage) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DataPackage" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DataPackage_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dataPackageInstance.ShouldBeAssignableTo<DataPackage>();
            _dataPackageInstanceFixture.ShouldBeAssignableTo<DataPackage>();
            CurrentInstance.ShouldBeAssignableTo<DataPackage>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DataPackage) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DataPackage instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DataPackage) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pXmlDoc = this.CreateType<XmlDocument>();
            var pContextNode = this.CreateType<XmlNode>();
            DataPackage instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DataPackage(pXmlDoc, pContextNode);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dataPackageInstance.ShouldNotBeNull();
            _dataPackageInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DataPackage>();
        }

        #endregion

        #region General Constructor : Class (DataPackage) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pXmlDoc = this.CreateType<XmlDocument>();
            var pContextNode = this.CreateType<XmlNode>();
            DataPackage instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DataPackage(pXmlDoc, pContextNode);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dataPackageInstance.ShouldNotBeNull();
            _dataPackageInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DataPackage) instance created

        /// <summary>
        ///     Class (<see cref="DataPackage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Is_Created_Test()
        {
            // Assert
            _dataPackageInstance.ShouldNotBeNull();
            _dataPackageInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DataPackage) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DataPackage" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DataPackage_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (DataPackage) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DataPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DataPackage) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DataPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDataPackageParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDataPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DataPackage) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DataPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDataPackageParametersTypes = new Type[] { typeof(XmlDocument), typeof(XmlNode) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDataPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DataPackage) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DataPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDataPackageParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDataPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DataPackage) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DataPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataPackage_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDataPackageParametersTypes = new Type[] { typeof(DataPackage) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDataPackageParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DataPackage) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycontextNode)]
        [TestCase(Propertyinitialized)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_DataPackage_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DataPackage) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (DataPackage) => Property (contextNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_contextNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycontextNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertycontextNode);
            Action currentAction = () => propertyInfo.SetValue(_dataPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataPackage) => Property (contextNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_Public_Class_contextNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycontextNode);
            var propertyInfo = this.GetPropertyInfo(PropertycontextNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataPackage) => Property (initialized) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_Public_Class_initialized_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinitialized);
            var propertyInfo = this.GetPropertyInfo(Propertyinitialized);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataPackage) => Property (xmlDoc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_xmlDoc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyxmlDoc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyxmlDoc);
            Action currentAction = () => propertyInfo.SetValue(_dataPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataPackage) => Property (xmlDoc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataPackage_Public_Class_xmlDoc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyxmlDoc);
            var propertyInfo = this.GetPropertyInfo(PropertyxmlDoc);

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

        #region Method Call : (SetDocument) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();
            var pContextNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _dataPackageInstance.SetDocument(pXmlDoc, pContextNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();
            var pContextNode = this.CreateType<XmlNode>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(XmlNode) };
            object[] parametersOfSetDocument = { pXmlDoc, pContextNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dataPackageInstanceFixture, parametersOfSetDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(2);
            methodSetDocumentParametersTypes.Length.ShouldBe(2);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();
            var pContextNode = this.CreateType<XmlNode>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(XmlNode) };
            object[] parametersOfSetDocument = { pXmlDoc, pContextNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDocument, parametersOfSetDocument, methodSetDocumentParametersTypes);

            // Assert
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(2);
            methodSetDocumentParametersTypes.Length.ShouldBe(2);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);

            // Assert
            methodSetDocumentParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DataPackage_SetDocument_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var psXmlString = this.CreateType<string>();

            // Act
            Action executeAction = () => _dataPackageInstance.SetDocument(psXmlString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var psXmlString = this.CreateType<string>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetDocument = { psXmlString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dataPackageInstanceFixture, parametersOfSetDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var psXmlString = this.CreateType<string>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetDocument = { psXmlString };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDocument, parametersOfSetDocument, methodSetDocumentParametersTypes);

            // Assert
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var methodSetDocumentParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);

            // Assert
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DataPackage_SetDocument_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodSetDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<DataPackage>();

            // Act
            Action executeAction = () => _dataPackageInstance.SetDocument(pSourcePackage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<DataPackage>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(DataPackage) };
            object[] parametersOfSetDocument = { pSourcePackage };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dataPackageInstanceFixture, parametersOfSetDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<DataPackage>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(DataPackage) };
            object[] parametersOfSetDocument = { pSourcePackage };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDocument, parametersOfSetDocument, methodSetDocumentParametersTypes);

            // Assert
            parametersOfSetDocument.ShouldNotBeNull();
            parametersOfSetDocument.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            methodSetDocumentParametersTypes.Length.ShouldBe(parametersOfSetDocument.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var methodSetDocumentParametersTypes = new Type[] { typeof(DataPackage) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);

            // Assert
            methodSetDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DataPackage_SetDocument_Method_Call_Overloading_Of_2_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 2);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}