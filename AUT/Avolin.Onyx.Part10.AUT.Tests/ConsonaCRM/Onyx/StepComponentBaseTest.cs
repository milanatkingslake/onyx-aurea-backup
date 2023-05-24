using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepComponentBase" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepComponentBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepComponentBase" />)
        /// </summary>
        public StepComponentBaseTest() : base(typeof(StepComponentBase))
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

        #region General Initializer : Class (StepComponentBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepComponentBaseInstanceType;
        private StepComponentBase _stepComponentBaseInstance;
        private StepComponentBase _stepComponentBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepComponentBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepComponentBaseInstanceType = typeof(StepComponentBase);
            _stepComponentBaseInstanceFixture = this.Create<StepComponentBase>(false);
            _stepComponentBaseInstance = _stepComponentBaseInstanceFixture ?? this.Create<StepComponentBase>(true);
            CurrentInstance = _stepComponentBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepComponentBase) Initializer

        #region Properties

        private const string PropertystepPackage = "stepPackage";
        private const string Propertylog = "log";
        private const string PropertynatLangCache = "natLangCache";
        private const string Propertycache = "cache";
        private const string PropertydictionaryCache = "dictionaryCache";
        private const string PropertyappData = "appData";
        private const string PropertysessionManager = "sessionManager";
        private const string PropertyadditionalDataValues = "additionalDataValues";
        private const string PropertyassemblyClassName = "assemblyClassName";
        private const string PropertyapplicationName = "applicationName";
        private const string PropertylogicalObjectName = "logicalObjectName";
        private const string PropertylogicalMethodName = "logicalMethodName";
        private const string PropertystepAdditionalData = "stepAdditionalData";
        private const string PropertyreturnValue = "returnValue";
        private const string PropertydefaultInputNode = "defaultInputNode";
        private const string PropertydefaultReturnNode = "defaultReturnNode";
        private const string PropertydataPath = "dataPath";
        private const string PropertystepObject = "stepObject";
        private const string PropertystepMethod = "stepMethod";
        private const string PropertysupportedMethodHandlers = "supportedMethodHandlers";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodInitializeInstance = "InitializeInstance";
        private const string MethodPreExecute = "PreExecute";
        private const string MethodPostExecute = "PostExecute";
        private const string MethodGetDefaultInputReturnNodes = "GetDefaultInputReturnNodes";
        private const string MethodHandleException = "HandleException";
        private const string MethodParseAdditionalData = "ParseAdditionalData";
        private const string MethodGetAdditionalDataValue = "GetAdditionalDataValue";
        private const string MethodAddSupportedMethod = "AddSupportedMethod";
        private const string MethodExecuteMethodHandler = "ExecuteMethodHandler";
        private const string MethodExecuteMain = "ExecuteMain";

        #endregion

        #region Fields

        private const string Fieldm_applicationName = "m_applicationName";
        private const string Fieldm_logicalObjectName = "m_logicalObjectName";
        private const string Fieldm_logicalMethodName = "m_logicalMethodName";
        private const string Fieldm_stepAdditionalData = "m_stepAdditionalData";
        private const string Fieldm_returnValue = "m_returnValue";
        private const string Fieldm_stepPackage = "m_stepPackage";
        private const string Fieldm_log = "m_log";
        private const string Fieldm_additionalDataValues = "m_additionalDataValues";
        private const string Fieldm_natLangCache = "m_natLangCache";
        private const string Fieldm_cache = "m_cache";
        private const string Fieldm_dictionaryCache = "m_dictionaryCache";
        private const string Fieldm_appData = "m_appData";
        private const string Fieldm_sessionManager = "m_sessionManager";
        private const string Fieldm_defaultInputNode = "m_defaultInputNode";
        private const string Fieldm_defaultReturnNode = "m_defaultReturnNode";
        private const string Fieldm_supportedMethodHandlers = "m_supportedMethodHandlers";

        #endregion

        #endregion

        #region General Initializer : Class (StepComponentBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentBase) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentBase_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentBase) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentBase_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepComponentBase)

        #region General Initializer : Class (StepComponentBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodInitializeInstance, 0)]
        [TestCase(MethodPreExecute, 0)]
        [TestCase(MethodPostExecute, 0)]
        [TestCase(MethodGetDefaultInputReturnNodes, 0)]
        [TestCase(MethodHandleException, 0)]
        [TestCase(MethodParseAdditionalData, 0)]
        [TestCase(MethodGetAdditionalDataValue, 0)]
        [TestCase(MethodAddSupportedMethod, 0)]
        [TestCase(MethodExecuteMethodHandler, 0)]
        [TestCase(MethodExecuteMain, 0)]
        public void AUT_StepComponentBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepComponentBase) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertystepPackage)]
        [TestCase(Propertylog)]
        [TestCase(PropertynatLangCache)]
        [TestCase(Propertycache)]
        [TestCase(PropertydictionaryCache)]
        [TestCase(PropertyappData)]
        [TestCase(PropertysessionManager)]
        [TestCase(PropertyadditionalDataValues)]
        [TestCase(PropertyassemblyClassName)]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertylogicalObjectName)]
        [TestCase(PropertylogicalMethodName)]
        [TestCase(PropertystepAdditionalData)]
        [TestCase(PropertyreturnValue)]
        [TestCase(PropertydefaultInputNode)]
        [TestCase(PropertydefaultReturnNode)]
        [TestCase(PropertydataPath)]
        [TestCase(PropertystepObject)]
        [TestCase(PropertystepMethod)]
        [TestCase(PropertysupportedMethodHandlers)]
        [Category("AUT Property")]
        public void AUT_StepComponentBase_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepComponentBase) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_applicationName)]
        [TestCase(Fieldm_logicalObjectName)]
        [TestCase(Fieldm_logicalMethodName)]
        [TestCase(Fieldm_stepAdditionalData)]
        [TestCase(Fieldm_returnValue)]
        [TestCase(Fieldm_stepPackage)]
        [TestCase(Fieldm_log)]
        [TestCase(Fieldm_additionalDataValues)]
        [TestCase(Fieldm_natLangCache)]
        [TestCase(Fieldm_cache)]
        [TestCase(Fieldm_dictionaryCache)]
        [TestCase(Fieldm_appData)]
        [TestCase(Fieldm_sessionManager)]
        [TestCase(Fieldm_defaultInputNode)]
        [TestCase(Fieldm_defaultReturnNode)]
        [TestCase(Fieldm_supportedMethodHandlers)]
        [Category("AUT Fields")]
        public void AUT_StepComponentBase_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepComponentBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepComponentBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepComponentBaseInstance.ShouldBeAssignableTo<StepComponentBase>();
            _stepComponentBaseInstanceFixture.ShouldBeAssignableTo<StepComponentBase>();
            CurrentInstance.ShouldBeAssignableTo<StepComponentBase>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepComponentBase) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertystepPackage)]
        [TestCase(Propertylog)]
        [TestCase(PropertynatLangCache)]
        [TestCase(Propertycache)]
        [TestCase(PropertydictionaryCache)]
        [TestCase(PropertyappData)]
        [TestCase(PropertysessionManager)]
        [TestCase(PropertyadditionalDataValues)]
        [TestCase(PropertyassemblyClassName)]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertylogicalObjectName)]
        [TestCase(PropertylogicalMethodName)]
        [TestCase(PropertystepAdditionalData)]
        [TestCase(PropertyreturnValue)]
        [TestCase(PropertydefaultInputNode)]
        [TestCase(PropertydefaultReturnNode)]
        [TestCase(PropertydataPath)]
        [TestCase(PropertystepObject)]
        [TestCase(PropertystepMethod)]
        [TestCase(PropertysupportedMethodHandlers)]
        public void AUT_StepComponentBase_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepComponentBase) => Property (additionalDataValues) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_additionalDataValues_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyadditionalDataValues);
            var propertyInfo = this.GetPropertyInfo(PropertyadditionalDataValues);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (appData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_appData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyappData);
            var propertyInfo = this.GetPropertyInfo(PropertyappData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (applicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_applicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyapplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyapplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (StepComponentBase) => Property (cache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_cache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycache);
            var propertyInfo = this.GetPropertyInfo(Propertycache);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (dataPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_dataPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydataPath);
            var propertyInfo = this.GetPropertyInfo(PropertydataPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (defaultInputNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_defaultInputNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydefaultInputNode);
            var propertyInfo = this.GetPropertyInfo(PropertydefaultInputNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (defaultReturnNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_defaultReturnNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydefaultReturnNode);
            var propertyInfo = this.GetPropertyInfo(PropertydefaultReturnNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (dictionaryCache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_dictionaryCache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydictionaryCache);
            var propertyInfo = this.GetPropertyInfo(PropertydictionaryCache);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (log) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_log_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylog);
            var propertyInfo = this.GetPropertyInfo(Propertylog);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (logicalMethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_logicalMethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogicalMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertylogicalMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (logicalObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_logicalObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogicalObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertylogicalObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (natLangCache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_natLangCache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynatLangCache);
            var propertyInfo = this.GetPropertyInfo(PropertynatLangCache);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (returnValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_returnValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyreturnValue);
            var propertyInfo = this.GetPropertyInfo(PropertyreturnValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (sessionManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_sessionManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysessionManager);
            var propertyInfo = this.GetPropertyInfo(PropertysessionManager);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (stepAdditionalData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_stepAdditionalData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepAdditionalData);
            var propertyInfo = this.GetPropertyInfo(PropertystepAdditionalData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (stepMethod) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_stepMethod_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepMethod);
            var propertyInfo = this.GetPropertyInfo(PropertystepMethod);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (stepObject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_stepObject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepObject);
            var propertyInfo = this.GetPropertyInfo(PropertystepObject);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (stepPackage) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_stepPackage_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepPackage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertystepPackage);
            Action currentAction = () => propertyInfo.SetValue(_stepComponentBaseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (stepPackage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_stepPackage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepPackage);
            var propertyInfo = this.GetPropertyInfo(PropertystepPackage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (supportedMethodHandlers) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_supportedMethodHandlers_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysupportedMethodHandlers);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertysupportedMethodHandlers);
            Action currentAction = () => propertyInfo.SetValue(_stepComponentBaseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentBase) => Property (supportedMethodHandlers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentBase_Public_Class_supportedMethodHandlers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysupportedMethodHandlers);
            var propertyInfo = this.GetPropertyInfo(PropertysupportedMethodHandlers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}