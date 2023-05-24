using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.InternalEngine" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class InternalEngineTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="InternalEngine" />)
        /// </summary>
        public InternalEngineTest() : base(typeof(InternalEngine))
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

        #region General Initializer : Class (InternalEngine) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _internalEngineInstanceType;
        private InternalEngine _internalEngineInstance;
        private InternalEngine _internalEngineInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="InternalEngine" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _internalEngineInstanceType = typeof(InternalEngine);
            _internalEngineInstanceFixture = this.Create<InternalEngine>(false);
            _internalEngineInstance = _internalEngineInstanceFixture ?? this.Create<InternalEngine>(true);
            CurrentInstance = _internalEngineInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (InternalEngine) Initializer

        #region Properties

        private const string PropertysettingsCache = "settingsCache";
        private const string PropertygrammarDefinitionCache = "grammarDefinitionCache";
        private const string Propertycache = "cache";
        private const string PropertyexternalComponent = "externalComponent";
        private const string PropertyrepositoryPath = "repositoryPath";
        private const string PropertyreferenceID = "referenceID";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";

        #endregion

        #region Fields

        private const string Fieldm_settingsCache = "m_settingsCache";
        private const string Fieldm_grammarDefinitionCache = "m_grammarDefinitionCache";
        private const string Fieldm_cache = "m_cache";
        private const string Fieldm_externalComponent = "m_externalComponent";
        private const string Fieldm_repositoryPath = "m_repositoryPath";
        private const string Fieldm_referenceID = "m_referenceID";

        #endregion

        #endregion

        #region General Initializer : Class (InternalEngine) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InternalEngine_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (InternalEngine) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InternalEngine_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (InternalEngine) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_InternalEngine_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (InternalEngine)

        #region General Initializer : Class (InternalEngine) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        public void AUT_InternalEngine_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (InternalEngine) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertysettingsCache)]
        [TestCase(PropertygrammarDefinitionCache)]
        [TestCase(Propertycache)]
        [TestCase(PropertyexternalComponent)]
        [TestCase(PropertyrepositoryPath)]
        [TestCase(PropertyreferenceID)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_InternalEngine_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (InternalEngine) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_settingsCache)]
        [TestCase(Fieldm_grammarDefinitionCache)]
        [TestCase(Fieldm_cache)]
        [TestCase(Fieldm_externalComponent)]
        [TestCase(Fieldm_repositoryPath)]
        [TestCase(Fieldm_referenceID)]
        [Category("AUT Fields")]
        public void AUT_InternalEngine_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (InternalEngine) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_InternalEngine_Is_Instance_Present_Test()
        {
            // Assert
            _internalEngineInstanceType.ShouldNotBeNull();
            _internalEngineInstance.ShouldNotBeNull();
            _internalEngineInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (InternalEngine) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="InternalEngine" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_InternalEngine_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _internalEngineInstance.ShouldBeAssignableTo<InternalEngine>();
            _internalEngineInstanceFixture.ShouldBeAssignableTo<InternalEngine>();
            CurrentInstance.ShouldBeAssignableTo<InternalEngine>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (InternalEngine) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_InternalEngine_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            InternalEngine instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (InternalEngine) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertysettingsCache)]
        [TestCase(PropertygrammarDefinitionCache)]
        [TestCase(Propertycache)]
        [TestCase(PropertyexternalComponent)]
        [TestCase(PropertyrepositoryPath)]
        [TestCase(PropertyreferenceID)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_InternalEngine_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (InternalEngine) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (InternalEngine) => Property (cache) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_cache_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycache);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertycache);
            Action currentAction = () => propertyInfo.SetValue(_internalEngineInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (cache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_cache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (InternalEngine) => Property (externalComponent) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_externalComponent_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyexternalComponent);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyexternalComponent);
            Action currentAction = () => propertyInfo.SetValue(_internalEngineInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (externalComponent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_externalComponent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyexternalComponent);
            var propertyInfo = this.GetPropertyInfo(PropertyexternalComponent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (grammarDefinitionCache) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_grammarDefinitionCache_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertygrammarDefinitionCache);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertygrammarDefinitionCache);
            Action currentAction = () => propertyInfo.SetValue(_internalEngineInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (grammarDefinitionCache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_grammarDefinitionCache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertygrammarDefinitionCache);
            var propertyInfo = this.GetPropertyInfo(PropertygrammarDefinitionCache);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (referenceID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_referenceID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyreferenceID);
            var propertyInfo = this.GetPropertyInfo(PropertyreferenceID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (repositoryPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_repositoryPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrepositoryPath);
            var propertyInfo = this.GetPropertyInfo(PropertyrepositoryPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (settingsCache) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_settingsCache_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysettingsCache);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertysettingsCache);
            Action currentAction = () => propertyInfo.SetValue(_internalEngineInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (InternalEngine) => Property (settingsCache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_InternalEngine_Public_Class_settingsCache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysettingsCache);
            var propertyInfo = this.GetPropertyInfo(PropertysettingsCache);

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

        #region Method Call : (Execute) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryPath = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var pDataPackage = this.CreateType<DataPackage>();
            var psCacheControlPrefix = this.CreateType<string>();
            var psReferenceID = this.CreateType<string>();
            var pExternalComponent = this.CreateType<object>();

            // Act
            Action executeAction = () => _internalEngineInstance.Execute(psRepositoryPath, psMetadataPath, pDataPackage, psCacheControlPrefix, psReferenceID, pExternalComponent);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryPath = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var pDataPackage = this.CreateType<DataPackage>();
            var psCacheControlPrefix = this.CreateType<string>();
            var psReferenceID = this.CreateType<string>();
            var pExternalComponent = this.CreateType<object>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(DataPackage), typeof(string), typeof(string), typeof(object) };
            object[] parametersOfExecute = { psRepositoryPath, psMetadataPath, pDataPackage, psCacheControlPrefix, psReferenceID, pExternalComponent };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_internalEngineInstanceFixture, parametersOfExecute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryPath = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var pDataPackage = this.CreateType<DataPackage>();
            var psCacheControlPrefix = this.CreateType<string>();
            var psReferenceID = this.CreateType<string>();
            var pExternalComponent = this.CreateType<object>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(DataPackage), typeof(string), typeof(string), typeof(object) };
            object[] parametersOfExecute = { psRepositoryPath, psMetadataPath, pDataPackage, psCacheControlPrefix, psReferenceID, pExternalComponent };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(DataPackage), typeof(string), typeof(string), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_InternalEngine_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

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