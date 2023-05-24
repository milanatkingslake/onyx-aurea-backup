using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepPackage" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepPackageTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepPackage" />)
        /// </summary>
        public StepPackageTest() : base(typeof(StepPackage))
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

        #region General Initializer : Class (StepPackage) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepPackageInstanceType;
        private StepPackage _stepPackageInstance;
        private StepPackage _stepPackageInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepPackage" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepPackageInstanceType = typeof(StepPackage);
            _stepPackageInstanceFixture = this.Create<StepPackage>(false);
            _stepPackageInstance = _stepPackageInstanceFixture ?? this.Create<StepPackage>(true);
            CurrentInstance = _stepPackageInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepPackage) Initializer

        #region Properties

        private const string PropertyxmlDoc = "xmlDoc";
        private const string PropertycontextNode = "contextNode";
        private const string PropertymethodStatusNode = "methodStatusNode";
        private const string PropertyparamsNode = "paramsNode";
        private const string PropertyparamsReturnNode = "paramsReturnNode";
        private const string PropertystatusTypeNode = "statusTypeNode";
        private const string PropertyreturnXmlNode = "returnXmlNode";
        private const string PropertystatusType = "statusType";
        private const string Propertycontext = "context";
        private const string Propertyinitialized = "initialized";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodAddErrorOrWarning = "AddErrorOrWarning";
        private const string MethodSetDocument = "SetDocument";
        private const string MethodAddMessage = "AddMessage";
        private const string MethodAddWarning = "AddWarning";
        private const string MethodAddError = "AddError";
        private const string MethodSetStatusType = "SetStatusType";
        private const string MethodGetContextProperty = "GetContextProperty";
        private const string MethodSetContextProperty = "SetContextProperty";
        private const string MethodReset = "Reset";
        private const string MethodGetMessageList = "GetMessageList";
        private const string MethodMergeMethodStatus = "MergeMethodStatus";

        #endregion

        #region Fields

        private const string Fieldm_xmlDoc = "m_xmlDoc";
        private const string Fieldm_contextNode = "m_contextNode";
        private const string Fieldm_methodStatusNode = "m_methodStatusNode";
        private const string Fieldm_statusTypeNode = "m_statusTypeNode";
        private const string Fieldm_paramsNode = "m_paramsNode";
        private const string Fieldm_paramsReturnNode = "m_paramsReturnNode";
        private const string Fieldm_returnXmlNode = "m_returnXmlNode";
        private const string Fieldm_context = "m_context";
        private const string Fieldm_initialized = "m_initialized";

        #endregion

        #endregion

        #region General Initializer : Class (StepPackage) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackage_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepPackage) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackage_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepPackage) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackage_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepPackage)

        #region General Initializer : Class (StepPackage) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddErrorOrWarning, 0)]
        [TestCase(MethodSetDocument, 0)]
        [TestCase(MethodSetDocument, 1)]
        [TestCase(MethodSetDocument, 2)]
        [TestCase(MethodAddMessage, 0)]
        [TestCase(MethodAddWarning, 0)]
        [TestCase(MethodAddError, 0)]
        [TestCase(MethodSetStatusType, 0)]
        [TestCase(MethodGetContextProperty, 0)]
        [TestCase(MethodSetContextProperty, 0)]
        [TestCase(MethodReset, 0)]
        [TestCase(MethodGetMessageList, 0)]
        [TestCase(MethodMergeMethodStatus, 0)]
        public void AUT_StepPackage_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepPackage) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycontextNode)]
        [TestCase(PropertymethodStatusNode)]
        [TestCase(PropertyparamsNode)]
        [TestCase(PropertyparamsReturnNode)]
        [TestCase(PropertystatusTypeNode)]
        [TestCase(PropertyreturnXmlNode)]
        [TestCase(PropertystatusType)]
        [TestCase(Propertycontext)]
        [TestCase(Propertyinitialized)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_StepPackage_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepPackage) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_xmlDoc)]
        [TestCase(Fieldm_contextNode)]
        [TestCase(Fieldm_methodStatusNode)]
        [TestCase(Fieldm_statusTypeNode)]
        [TestCase(Fieldm_paramsNode)]
        [TestCase(Fieldm_paramsReturnNode)]
        [TestCase(Fieldm_returnXmlNode)]
        [TestCase(Fieldm_context)]
        [TestCase(Fieldm_initialized)]
        [Category("AUT Fields")]
        public void AUT_StepPackage_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepPackage) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepPackage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepPackage_Is_Instance_Present_Test()
        {
            // Assert
            _stepPackageInstanceType.ShouldNotBeNull();
            _stepPackageInstance.ShouldNotBeNull();
            _stepPackageInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepPackage) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepPackage" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepPackage_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepPackageInstance.ShouldBeAssignableTo<StepPackage>();
            _stepPackageInstanceFixture.ShouldBeAssignableTo<StepPackage>();
            CurrentInstance.ShouldBeAssignableTo<StepPackage>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepPackage) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StepPackage instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (StepPackage) instance created

        /// <summary>
        ///     Class (<see cref="StepPackage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Is_Created_Test()
        {
            // Assert
            _stepPackageInstance.ShouldNotBeNull();
            _stepPackageInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (StepPackage) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="StepPackage" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_StepPackage_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (StepPackage) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="StepPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (StepPackage) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodStepPackageParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepPackage) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepPackageParametersTypes = new Type[] { typeof(XmlDocument) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepPackage) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepPackageParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepPackageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepPackage) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepPackage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackage_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepPackageParametersTypes = new Type[] { typeof(StepPackage) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepPackageParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepPackage) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycontextNode)]
        [TestCase(PropertymethodStatusNode)]
        [TestCase(PropertyparamsNode)]
        [TestCase(PropertyparamsReturnNode)]
        [TestCase(PropertystatusTypeNode)]
        [TestCase(PropertyreturnXmlNode)]
        [TestCase(PropertystatusType)]
        [TestCase(Propertycontext)]
        [TestCase(Propertyinitialized)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_StepPackage_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepPackage) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (StepPackage) => Property (context) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_context_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycontext);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertycontext);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (context) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_context_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycontext);
            var propertyInfo = this.GetPropertyInfo(Propertycontext);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (contextNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_contextNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycontextNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertycontextNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (contextNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_contextNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (StepPackage) => Property (initialized) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_initialized_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (StepPackage) => Property (methodStatusNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_methodStatusNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymethodStatusNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertymethodStatusNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (methodStatusNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_methodStatusNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymethodStatusNode);
            var propertyInfo = this.GetPropertyInfo(PropertymethodStatusNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (paramsNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_paramsNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparamsNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyparamsNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (paramsNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_paramsNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparamsNode);
            var propertyInfo = this.GetPropertyInfo(PropertyparamsNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (paramsReturnNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_paramsReturnNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparamsReturnNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyparamsReturnNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (paramsReturnNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_paramsReturnNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparamsReturnNode);
            var propertyInfo = this.GetPropertyInfo(PropertyparamsReturnNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (returnXmlNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_returnXmlNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyreturnXmlNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyreturnXmlNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (returnXmlNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_returnXmlNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyreturnXmlNode);
            var propertyInfo = this.GetPropertyInfo(PropertyreturnXmlNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (statusType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_statusType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystatusType);
            var propertyInfo = this.GetPropertyInfo(PropertystatusType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (statusTypeNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_statusTypeNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystatusTypeNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertystatusTypeNode);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (statusTypeNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_statusTypeNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystatusTypeNode);
            var propertyInfo = this.GetPropertyInfo(PropertystatusTypeNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (xmlDoc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_xmlDoc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyxmlDoc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyxmlDoc);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackage) => Property (xmlDoc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackage_Public_Class_xmlDoc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (AddErrorOrWarning) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddErrorOrWarning_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddErrorOrWarning);
            var pbError = this.CreateType<bool>();
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddErrorOrWarningParametersTypes = new Type[] { typeof(bool), typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddErrorOrWarning = { pbError, piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddErrorOrWarning, methodAddErrorOrWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfAddErrorOrWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddErrorOrWarning.ShouldNotBeNull();
            parametersOfAddErrorOrWarning.Length.ShouldBe(7);
            methodAddErrorOrWarningParametersTypes.Length.ShouldBe(7);
            methodAddErrorOrWarningParametersTypes.Length.ShouldBe(parametersOfAddErrorOrWarning.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddErrorOrWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddErrorOrWarning_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddErrorOrWarning);
            var pbError = this.CreateType<bool>();
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddErrorOrWarningParametersTypes = new Type[] { typeof(bool), typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddErrorOrWarning = { pbError, piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddErrorOrWarning, parametersOfAddErrorOrWarning, methodAddErrorOrWarningParametersTypes);

            // Assert
            parametersOfAddErrorOrWarning.ShouldNotBeNull();
            parametersOfAddErrorOrWarning.Length.ShouldBe(7);
            methodAddErrorOrWarningParametersTypes.Length.ShouldBe(7);
            methodAddErrorOrWarningParametersTypes.Length.ShouldBe(parametersOfAddErrorOrWarning.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddErrorOrWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddErrorOrWarning_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddErrorOrWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodAddErrorOrWarning, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddErrorOrWarning) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddErrorOrWarning_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddErrorOrWarning);
            var methodAddErrorOrWarningParametersTypes = new Type[] { typeof(bool), typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddErrorOrWarning, methodAddErrorOrWarningParametersTypes);

            // Assert
            methodAddErrorOrWarningParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddErrorOrWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddErrorOrWarning_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddErrorOrWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodAddErrorOrWarning, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_SetDocument_Method_Call_Internally(Type[] types)
        {
            var methodSetDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => _stepPackageInstance.SetDocument(pXmlDoc);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfSetDocument = { pXmlDoc };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfSetDocument);

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
        public void AUT_StepPackage_SetDocument_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pXmlDoc = this.CreateType<XmlDocument>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfSetDocument = { pXmlDoc };

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
        public void AUT_StepPackage_SetDocument_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, 0);
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
        public void AUT_StepPackage_SetDocument_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var methodSetDocumentParametersTypes = new Type[] { typeof(XmlDocument) };

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
        public void AUT_StepPackage_SetDocument_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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
        private void AUT_StepPackage_SetDocument_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var psXmlString = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.SetDocument(psXmlString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var psXmlString = this.CreateType<string>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetDocument = { psXmlString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfSetDocument);

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
        public void AUT_StepPackage_SetDocument_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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
        private void AUT_StepPackage_SetDocument_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodSetDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetDocument, methodSetDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<StepPackage>();

            // Act
            Action executeAction = () => _stepPackageInstance.SetDocument(pSourcePackage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocument) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetDocument_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<StepPackage>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(StepPackage) };
            object[] parametersOfSetDocument = { pSourcePackage };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocument, methodSetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfSetDocument);

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
        public void AUT_StepPackage_SetDocument_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var pSourcePackage = this.CreateType<StepPackage>();
            var methodSetDocumentParametersTypes = new Type[] { typeof(StepPackage) };
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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocument);
            var methodSetDocumentParametersTypes = new Type[] { typeof(StepPackage) };

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
        public void AUT_StepPackage_SetDocument_Method_Call_Overloading_Of_2_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (AddMessage) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_AddMessage_Method_Call_Internally(Type[] types)
        {
            var methodAddMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddMessage, methodAddMessageParametersTypes);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var piMessageId = this.CreateType<long>();
            var psMessageText = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.AddMessage(piMessageId, psMessageText);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var piMessageId = this.CreateType<long>();
            var psMessageText = this.CreateType<string>();
            var methodAddMessageParametersTypes = new Type[] { typeof(long), typeof(string) };
            object[] parametersOfAddMessage = { piMessageId, psMessageText };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMessage, methodAddMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfAddMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddMessage.ShouldNotBeNull();
            parametersOfAddMessage.Length.ShouldBe(2);
            methodAddMessageParametersTypes.Length.ShouldBe(2);
            methodAddMessageParametersTypes.Length.ShouldBe(parametersOfAddMessage.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var piMessageId = this.CreateType<long>();
            var psMessageText = this.CreateType<string>();
            var methodAddMessageParametersTypes = new Type[] { typeof(long), typeof(string) };
            object[] parametersOfAddMessage = { piMessageId, psMessageText };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddMessage, parametersOfAddMessage, methodAddMessageParametersTypes);

            // Assert
            parametersOfAddMessage.ShouldNotBeNull();
            parametersOfAddMessage.Length.ShouldBe(2);
            methodAddMessageParametersTypes.Length.ShouldBe(2);
            methodAddMessageParametersTypes.Length.ShouldBe(parametersOfAddMessage.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMessage, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var methodAddMessageParametersTypes = new Type[] { typeof(long), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddMessage, methodAddMessageParametersTypes);

            // Assert
            methodAddMessageParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMessage) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddMessage_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMessage, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_AddWarning_Method_Call_Internally(Type[] types)
        {
            var methodAddWarningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddWarning, methodAddWarningParametersTypes);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.AddWarning(piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddWarningParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddWarning = { piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddWarning, methodAddWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfAddWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddWarning.ShouldNotBeNull();
            parametersOfAddWarning.Length.ShouldBe(6);
            methodAddWarningParametersTypes.Length.ShouldBe(6);
            methodAddWarningParametersTypes.Length.ShouldBe(parametersOfAddWarning.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddWarningParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddWarning = { piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddWarning, parametersOfAddWarning, methodAddWarningParametersTypes);

            // Assert
            parametersOfAddWarning.ShouldNotBeNull();
            parametersOfAddWarning.Length.ShouldBe(6);
            methodAddWarningParametersTypes.Length.ShouldBe(6);
            methodAddWarningParametersTypes.Length.ShouldBe(parametersOfAddWarning.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodAddWarning, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var methodAddWarningParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddWarning, methodAddWarningParametersTypes);

            // Assert
            methodAddWarningParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddWarning_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodAddWarning, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_AddError_Method_Call_Internally(Type[] types)
        {
            var methodAddErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddError, methodAddErrorParametersTypes);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.AddError(piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddErrorParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddError = { piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddError, methodAddErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfAddError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddError.ShouldNotBeNull();
            parametersOfAddError.Length.ShouldBe(6);
            methodAddErrorParametersTypes.Length.ShouldBe(6);
            methodAddErrorParametersTypes.Length.ShouldBe(parametersOfAddError.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var piErrorNumber = this.CreateType<long>();
            var psErrorType = this.CreateType<string>();
            var psErrorDescription = this.CreateType<string>();
            var piNatLangID = this.CreateType<long>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            var methodAddErrorParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfAddError = { piErrorNumber, psErrorType, psErrorDescription, piNatLangID, psSourceType, psSourceName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddError, parametersOfAddError, methodAddErrorParametersTypes);

            // Assert
            parametersOfAddError.ShouldNotBeNull();
            parametersOfAddError.Length.ShouldBe(6);
            methodAddErrorParametersTypes.Length.ShouldBe(6);
            methodAddErrorParametersTypes.Length.ShouldBe(parametersOfAddError.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var currentMethodInfo = this.GetMethodInfo(MethodAddError, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var methodAddErrorParametersTypes = new Type[] { typeof(long), typeof(string), typeof(string), typeof(long), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddError, methodAddErrorParametersTypes);

            // Assert
            methodAddErrorParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_AddError_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddError);
            var currentMethodInfo = this.GetMethodInfo(MethodAddError, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_SetStatusType_Method_Call_Internally(Type[] types)
        {
            var methodSetStatusTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetStatusType, methodSetStatusTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var psStatusType = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.SetStatusType(psStatusType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var psStatusType = this.CreateType<string>();
            var methodSetStatusTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetStatusType = { psStatusType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetStatusType, methodSetStatusTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfSetStatusType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetStatusType.ShouldNotBeNull();
            parametersOfSetStatusType.Length.ShouldBe(1);
            methodSetStatusTypeParametersTypes.Length.ShouldBe(1);
            methodSetStatusTypeParametersTypes.Length.ShouldBe(parametersOfSetStatusType.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var psStatusType = this.CreateType<string>();
            var methodSetStatusTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetStatusType = { psStatusType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetStatusType, parametersOfSetStatusType, methodSetStatusTypeParametersTypes);

            // Assert
            parametersOfSetStatusType.ShouldNotBeNull();
            parametersOfSetStatusType.Length.ShouldBe(1);
            methodSetStatusTypeParametersTypes.Length.ShouldBe(1);
            methodSetStatusTypeParametersTypes.Length.ShouldBe(parametersOfSetStatusType.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetStatusType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var methodSetStatusTypeParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetStatusType, methodSetStatusTypeParametersTypes);

            // Assert
            methodSetStatusTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStatusType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetStatusType_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStatusType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetStatusType, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_GetContextProperty_Method_Call_Internally(Type[] types)
        {
            var methodGetContextPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextProperty, methodGetContextPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.GetContextProperty(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var psName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _stepPackageInstance.GetContextProperty(psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var psName = this.CreateType<string>();
            var methodGetContextPropertyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContextProperty = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextProperty, methodGetContextPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_stepPackageInstanceFixture, parametersOfGetContextProperty);
            var result2 = this.GetResultOfMethod<string>(MethodGetContextProperty, parametersOfGetContextProperty, methodGetContextPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextProperty.ShouldNotBeNull();
            parametersOfGetContextProperty.Length.ShouldBe(1);
            methodGetContextPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var psName = this.CreateType<string>();
            var methodGetContextPropertyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContextProperty = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContextProperty, parametersOfGetContextProperty, methodGetContextPropertyParametersTypes);

            // Assert
            parametersOfGetContextProperty.ShouldNotBeNull();
            parametersOfGetContextProperty.Length.ShouldBe(1);
            methodGetContextPropertyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var methodGetContextPropertyParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextProperty, methodGetContextPropertyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextPropertyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var methodGetContextPropertyParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextProperty, methodGetContextPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextPropertyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextProperty) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetContextProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextProperty, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_SetContextProperty_Method_Call_Internally(Type[] types)
        {
            var methodSetContextPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetContextProperty, methodSetContextPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepPackageInstance.SetContextProperty(psName, psValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSetContextPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetContextProperty = { psName, psValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetContextProperty, methodSetContextPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfSetContextProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetContextProperty.ShouldNotBeNull();
            parametersOfSetContextProperty.Length.ShouldBe(2);
            methodSetContextPropertyParametersTypes.Length.ShouldBe(2);
            methodSetContextPropertyParametersTypes.Length.ShouldBe(parametersOfSetContextProperty.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSetContextPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetContextProperty = { psName, psValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetContextProperty, parametersOfSetContextProperty, methodSetContextPropertyParametersTypes);

            // Assert
            parametersOfSetContextProperty.ShouldNotBeNull();
            parametersOfSetContextProperty.Length.ShouldBe(2);
            methodSetContextPropertyParametersTypes.Length.ShouldBe(2);
            methodSetContextPropertyParametersTypes.Length.ShouldBe(parametersOfSetContextProperty.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetContextProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var methodSetContextPropertyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetContextProperty, methodSetContextPropertyParametersTypes);

            // Assert
            methodSetContextPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetContextProperty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_SetContextProperty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetContextProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetContextProperty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_Reset_Method_Call_Internally(Type[] types)
        {
            var methodResetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReset, methodResetParametersTypes);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_Reset_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReset);

            // Act
            Action executeAction = () => _stepPackageInstance.Reset();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_Reset_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReset);
            Type [] methodResetParametersTypes = null;
            object[] parametersOfReset = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodReset, methodResetParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfReset);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReset.ShouldBeNull();
            methodResetParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_Reset_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReset);
            Type [] methodResetParametersTypes = null;
            object[] parametersOfReset = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodReset, parametersOfReset, methodResetParametersTypes);

            // Assert
            parametersOfReset.ShouldBeNull();
            methodResetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_Reset_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReset);
            Type [] methodResetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReset, methodResetParametersTypes);

            // Assert
            methodResetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Reset) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_Reset_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReset);
            var currentMethodInfo = this.GetMethodInfo(MethodReset, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_GetMessageList_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessageList, methodGetMessageListParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);

            // Act
            Action executeAction = () => _stepPackageInstance.GetMessageList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            var returnedValue = default(XmlNodeList);

            // Act
            Action executeAction = () => returnedValue = _stepPackageInstance.GetMessageList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            Type [] methodGetMessageListParametersTypes = null;
            object[] parametersOfGetMessageList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageList, methodGetMessageListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNodeList>(_stepPackageInstanceFixture, parametersOfGetMessageList);
            var result2 = this.GetResultOfMethod<XmlNodeList>(MethodGetMessageList, parametersOfGetMessageList, methodGetMessageListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMessageList.ShouldBeNull();
            methodGetMessageListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            Type [] methodGetMessageListParametersTypes = null;
            object[] parametersOfGetMessageList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNodeList>(MethodGetMessageList, parametersOfGetMessageList, methodGetMessageListParametersTypes);

            // Assert
            parametersOfGetMessageList.ShouldBeNull();
            methodGetMessageListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            Type [] methodGetMessageListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessageList, methodGetMessageListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMessageListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            Type [] methodGetMessageListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessageList, methodGetMessageListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageList) (Return Type : XmlNodeList) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_GetMessageList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepPackage_MergeMethodStatus_Method_Call_Internally(Type[] types)
        {
            var methodMergeMethodStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeMethodStatus, methodMergeMethodStatusParametersTypes);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var pStepPackage = this.CreateType<StepPackage>();

            // Act
            Action executeAction = () => _stepPackageInstance.MergeMethodStatus(pStepPackage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var pStepPackage = this.CreateType<StepPackage>();
            var methodMergeMethodStatusParametersTypes = new Type[] { typeof(StepPackage) };
            object[] parametersOfMergeMethodStatus = { pStepPackage };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeMethodStatus, methodMergeMethodStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepPackageInstanceFixture, parametersOfMergeMethodStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMergeMethodStatus.ShouldNotBeNull();
            parametersOfMergeMethodStatus.Length.ShouldBe(1);
            methodMergeMethodStatusParametersTypes.Length.ShouldBe(1);
            methodMergeMethodStatusParametersTypes.Length.ShouldBe(parametersOfMergeMethodStatus.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var pStepPackage = this.CreateType<StepPackage>();
            var methodMergeMethodStatusParametersTypes = new Type[] { typeof(StepPackage) };
            object[] parametersOfMergeMethodStatus = { pStepPackage };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMergeMethodStatus, parametersOfMergeMethodStatus, methodMergeMethodStatusParametersTypes);

            // Assert
            parametersOfMergeMethodStatus.ShouldNotBeNull();
            parametersOfMergeMethodStatus.Length.ShouldBe(1);
            methodMergeMethodStatusParametersTypes.Length.ShouldBe(1);
            methodMergeMethodStatusParametersTypes.Length.ShouldBe(parametersOfMergeMethodStatus.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeMethodStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var methodMergeMethodStatusParametersTypes = new Type[] { typeof(StepPackage) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeMethodStatus, methodMergeMethodStatusParametersTypes);

            // Assert
            methodMergeMethodStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeMethodStatus) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepPackage_MergeMethodStatus_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeMethodStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeMethodStatus, 0);

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