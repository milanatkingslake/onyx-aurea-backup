using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Cache;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Cache
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Cache.XmlDocumentCache" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Cache"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlDocumentCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlDocumentCache" />)
        /// </summary>
        public XmlDocumentCacheTest() : base(typeof(XmlDocumentCache))
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

        #region General Initializer : Class (XmlDocumentCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlDocumentCacheInstanceType;
        private XmlDocumentCache _xmlDocumentCacheInstance;
        private XmlDocumentCache _xmlDocumentCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlDocumentCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlDocumentCacheInstanceType = typeof(XmlDocumentCache);
            _xmlDocumentCacheInstanceFixture = this.Create<XmlDocumentCache>(false);
            _xmlDocumentCacheInstance = _xmlDocumentCacheInstanceFixture ?? this.Create<XmlDocumentCache>(true);
            CurrentInstance = _xmlDocumentCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlDocumentCache) Initializer

        #region Properties

        private const string PropertyxmlDoc = "xmlDoc";
        private const string PropertycachePrefix = "cachePrefix";
        private const string PropertycachePrefixNamespaceMgr = "cachePrefixNamespaceMgr";
        private const string Propertycache = "cache";
        private const string PropertyenableCaching = "enableCaching";
        private const string PropertynamespaceManager = "namespaceManager";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodLoad = "Load";
        private const string MethodRemove = "Remove";

        #endregion

        #region Fields

        private const string Fieldm_xmlDoc = "m_xmlDoc";
        private const string Fieldm_cachePrefix = "m_cachePrefix";
        private const string Fieldm_cachePrefixNamespaceMgr = "m_cachePrefixNamespaceMgr";
        private const string Fieldm_cache = "m_cache";
        private const string Fieldm_enableCaching = "m_enableCaching";
        private const string Fieldm_namespaceManager = "m_namespaceManager";

        #endregion

        #endregion

        #region General Initializer : Class (XmlDocumentCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlDocumentCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlDocumentCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlDocumentCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlDocumentCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlDocumentCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlDocumentCache)

        #region General Initializer : Class (XmlDocumentCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoad, 0)]
        [TestCase(MethodRemove, 0)]
        public void AUT_XmlDocumentCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (XmlDocumentCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycachePrefix)]
        [TestCase(PropertycachePrefixNamespaceMgr)]
        [TestCase(Propertycache)]
        [TestCase(PropertyenableCaching)]
        [TestCase(PropertynamespaceManager)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_XmlDocumentCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (XmlDocumentCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_xmlDoc)]
        [TestCase(Fieldm_cachePrefix)]
        [TestCase(Fieldm_cachePrefixNamespaceMgr)]
        [TestCase(Fieldm_cache)]
        [TestCase(Fieldm_enableCaching)]
        [TestCase(Fieldm_namespaceManager)]
        [Category("AUT Fields")]
        public void AUT_XmlDocumentCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlDocumentCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlDocumentCache_Is_Instance_Present_Test()
        {
            // Assert
            _xmlDocumentCacheInstanceType.ShouldNotBeNull();
            _xmlDocumentCacheInstance.ShouldNotBeNull();
            _xmlDocumentCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (XmlDocumentCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlDocumentCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlDocumentCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlDocumentCacheInstance.ShouldBeAssignableTo<XmlDocumentCache>();
            _xmlDocumentCacheInstanceFixture.ShouldBeAssignableTo<XmlDocumentCache>();
            CurrentInstance.ShouldBeAssignableTo<XmlDocumentCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlDocumentCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlDocumentCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            XmlDocumentCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new XmlDocumentCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _xmlDocumentCacheInstance.ShouldNotBeNull();
            _xmlDocumentCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<XmlDocumentCache>();
        }

        #endregion

        #region General Constructor : Class (XmlDocumentCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlDocumentCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            XmlDocumentCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new XmlDocumentCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _xmlDocumentCacheInstance.ShouldNotBeNull();
            _xmlDocumentCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (XmlDocumentCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyxmlDoc)]
        [TestCase(PropertycachePrefix)]
        [TestCase(PropertycachePrefixNamespaceMgr)]
        [TestCase(Propertycache)]
        [TestCase(PropertyenableCaching)]
        [TestCase(PropertynamespaceManager)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_XmlDocumentCache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (cache) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_cache_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycache);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertycache);
            Action currentAction = () => propertyInfo.SetValue(_xmlDocumentCacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (cache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_cache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (cachePrefix) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_cachePrefix_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycachePrefix);
            var propertyInfo = this.GetPropertyInfo(PropertycachePrefix);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (cachePrefixNamespaceMgr) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_cachePrefixNamespaceMgr_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycachePrefixNamespaceMgr);
            var propertyInfo = this.GetPropertyInfo(PropertycachePrefixNamespaceMgr);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (enableCaching) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_enableCaching_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyenableCaching);
            var propertyInfo = this.GetPropertyInfo(PropertyenableCaching);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (namespaceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_namespaceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynamespaceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertynamespaceManager);
            Action currentAction = () => propertyInfo.SetValue(_xmlDocumentCacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (namespaceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_namespaceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (xmlDoc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_xmlDoc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyxmlDoc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyxmlDoc);
            Action currentAction = () => propertyInfo.SetValue(_xmlDocumentCacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (XmlDocumentCache) => Property (xmlDoc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlDocumentCache_Public_Class_xmlDoc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (Load) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var filePath = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlDocumentCacheInstance.Load(filePath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var filePath = this.CreateType<string>();
            var methodLoadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoad = { filePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoad, methodLoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlDocumentCacheInstanceFixture, parametersOfLoad);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoad.ShouldNotBeNull();
            parametersOfLoad.Length.ShouldBe(1);
            methodLoadParametersTypes.Length.ShouldBe(1);
            methodLoadParametersTypes.Length.ShouldBe(parametersOfLoad.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var filePath = this.CreateType<string>();
            var methodLoadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoad = { filePath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoad, parametersOfLoad, methodLoadParametersTypes);

            // Assert
            parametersOfLoad.ShouldNotBeNull();
            parametersOfLoad.Length.ShouldBe(1);
            methodLoadParametersTypes.Length.ShouldBe(1);
            methodLoadParametersTypes.Length.ShouldBe(parametersOfLoad.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var currentMethodInfo = this.GetMethodInfo(MethodLoad, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var methodLoadParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoad, methodLoadParametersTypes);

            // Assert
            methodLoadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var currentMethodInfo = this.GetMethodInfo(MethodLoad, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentCache_Remove_Method_Call_Internally(Type[] types)
        {
            var methodRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var filePath = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlDocumentCacheInstance.Remove(filePath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var filePath = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { filePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlDocumentCacheInstanceFixture, parametersOfRemove);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var filePath = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { filePath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodRemoveParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);

            // Assert
            methodRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentCache_Remove_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);

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