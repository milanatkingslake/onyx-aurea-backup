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

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Cache
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Cache.GrammarDefinitionCache" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Cache"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GrammarDefinitionCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GrammarDefinitionCache" />)
        /// </summary>
        public GrammarDefinitionCacheTest() : base(typeof(GrammarDefinitionCache))
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

        #region General Initializer : Class (GrammarDefinitionCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _grammarDefinitionCacheInstanceType;
        private GrammarDefinitionCache _grammarDefinitionCacheInstance;
        private GrammarDefinitionCache _grammarDefinitionCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GrammarDefinitionCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _grammarDefinitionCacheInstanceType = typeof(GrammarDefinitionCache);
            _grammarDefinitionCacheInstanceFixture = this.Create<GrammarDefinitionCache>(false);
            _grammarDefinitionCacheInstance = _grammarDefinitionCacheInstanceFixture ?? this.Create<GrammarDefinitionCache>(true);
            CurrentInstance = _grammarDefinitionCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GrammarDefinitionCache) Initializer

        #region Properties

        private const string PropertydefinitionTable = "definitionTable";

        #endregion

        #region Methods

        private const string MethodLoad = "Load";
        private const string MethodGetDefinition = "GetDefinition";

        #endregion

        #region Fields

        private const string Fieldm_hashTable = "m_hashTable";

        #endregion

        #endregion

        #region General Initializer : Class (GrammarDefinitionCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinitionCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarDefinitionCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinitionCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GrammarDefinitionCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GrammarDefinitionCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GrammarDefinitionCache)

        #region General Initializer : Class (GrammarDefinitionCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoad, 0)]
        [TestCase(MethodGetDefinition, 0)]
        public void AUT_GrammarDefinitionCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GrammarDefinitionCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertydefinitionTable)]
        [Category("AUT Property")]
        public void AUT_GrammarDefinitionCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GrammarDefinitionCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_hashTable)]
        [Category("AUT Fields")]
        public void AUT_GrammarDefinitionCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GrammarDefinitionCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarDefinitionCache_Is_Instance_Present_Test()
        {
            // Assert
            _grammarDefinitionCacheInstanceType.ShouldNotBeNull();
            _grammarDefinitionCacheInstance.ShouldNotBeNull();
            _grammarDefinitionCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GrammarDefinitionCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GrammarDefinitionCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GrammarDefinitionCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _grammarDefinitionCacheInstance.ShouldBeAssignableTo<GrammarDefinitionCache>();
            _grammarDefinitionCacheInstanceFixture.ShouldBeAssignableTo<GrammarDefinitionCache>();
            CurrentInstance.ShouldBeAssignableTo<GrammarDefinitionCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GrammarDefinitionCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarDefinitionCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            GrammarDefinitionCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GrammarDefinitionCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _grammarDefinitionCacheInstance.ShouldNotBeNull();
            _grammarDefinitionCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<GrammarDefinitionCache>();
        }

        #endregion

        #region General Constructor : Class (GrammarDefinitionCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GrammarDefinitionCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            GrammarDefinitionCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GrammarDefinitionCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _grammarDefinitionCacheInstance.ShouldNotBeNull();
            _grammarDefinitionCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GrammarDefinitionCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertydefinitionTable)]
        public void AUT_GrammarDefinitionCache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GrammarDefinitionCache) => Property (definitionTable) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinitionCache_definitionTable_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydefinitionTable);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertydefinitionTable);
            Action currentAction = () => propertyInfo.SetValue(_grammarDefinitionCacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GrammarDefinitionCache) => Property (definitionTable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GrammarDefinitionCache_Public_Class_definitionTable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydefinitionTable);
            var propertyInfo = this.GetPropertyInfo(PropertydefinitionTable);

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
        
        #region Method Call : (Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var psFolderPath = this.CreateType<string>();
            var psSearchPattern = this.CreateType<string>();
            var methodLoadParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLoad = { psFolderPath, psSearchPattern };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoad, parametersOfLoad, methodLoadParametersTypes);

            // Assert
            parametersOfLoad.ShouldNotBeNull();
            parametersOfLoad.Length.ShouldBe(2);
            methodLoadParametersTypes.Length.ShouldBe(2);
            methodLoadParametersTypes.Length.ShouldBe(parametersOfLoad.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var currentMethodInfo = this.GetMethodInfo(MethodLoad, 0);
            const int parametersCount = 2;

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
        public void AUT_GrammarDefinitionCache_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var methodLoadParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoad, methodLoadParametersTypes);

            // Assert
            methodLoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_Internally(Type[] types)
        {
            var methodGetDefinitionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefinition, methodGetDefinitionParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _grammarDefinitionCacheInstance.GetDefinition(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var psName = this.CreateType<string>();
            var returnedValue = default(GrammarDefinition);

            // Act
            Action executeAction = () => returnedValue = _grammarDefinitionCacheInstance.GetDefinition(psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var psName = this.CreateType<string>();
            var methodGetDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDefinition = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefinition, methodGetDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<GrammarDefinition>(_grammarDefinitionCacheInstanceFixture, parametersOfGetDefinition);
            var result2 = this.GetResultOfMethod<GrammarDefinition>(MethodGetDefinition, parametersOfGetDefinition, methodGetDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefinition.ShouldNotBeNull();
            parametersOfGetDefinition.Length.ShouldBe(1);
            methodGetDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var psName = this.CreateType<string>();
            var methodGetDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDefinition = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GrammarDefinition>(MethodGetDefinition, parametersOfGetDefinition, methodGetDefinitionParametersTypes);

            // Assert
            parametersOfGetDefinition.ShouldNotBeNull();
            parametersOfGetDefinition.Length.ShouldBe(1);
            methodGetDefinitionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var methodGetDefinitionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefinition, methodGetDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var methodGetDefinitionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefinition, methodGetDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefinition) (Return Type : GrammarDefinition) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GrammarDefinitionCache_GetDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefinition, 0);
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