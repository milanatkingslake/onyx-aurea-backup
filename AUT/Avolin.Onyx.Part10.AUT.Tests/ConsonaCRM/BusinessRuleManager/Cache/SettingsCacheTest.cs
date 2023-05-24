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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Cache.SettingsCache" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Cache"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SettingsCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SettingsCache" />)
        /// </summary>
        public SettingsCacheTest() : base(typeof(SettingsCache))
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

        #region General Initializer : Class (SettingsCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _settingsCacheInstanceType;
        private SettingsCache _settingsCacheInstance;
        private SettingsCache _settingsCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SettingsCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _settingsCacheInstanceType = typeof(SettingsCache);
            _settingsCacheInstanceFixture = this.Create<SettingsCache>(false);
            _settingsCacheInstance = _settingsCacheInstanceFixture ?? this.Create<SettingsCache>(true);
            CurrentInstance = _settingsCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SettingsCache) Initializer

        #region Methods

        private const string MethodLoad = "Load";
        private const string MethodGetSetting = "GetSetting";

        #endregion

        #endregion

        #region General Initializer : Class (SettingsCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SettingsCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SettingsCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SettingsCache)

        #region General Initializer : Class (SettingsCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SettingsCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoad, 0)]
        [TestCase(MethodGetSetting, 0)]
        public void AUT_SettingsCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SettingsCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SettingsCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SettingsCache_Is_Instance_Present_Test()
        {
            // Assert
            _settingsCacheInstanceType.ShouldNotBeNull();
            _settingsCacheInstance.ShouldNotBeNull();
            _settingsCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SettingsCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SettingsCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SettingsCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _settingsCacheInstance.ShouldBeAssignableTo<SettingsCache>();
            _settingsCacheInstanceFixture.ShouldBeAssignableTo<SettingsCache>();
            CurrentInstance.ShouldBeAssignableTo<SettingsCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SettingsCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SettingsCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            SettingsCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SettingsCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _settingsCacheInstance.ShouldNotBeNull();
            _settingsCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SettingsCache>();
        }

        #endregion

        #region General Constructor : Class (SettingsCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SettingsCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pbEnableCaching = this.CreateType<bool>();
            var psCachePrefix = this.CreateType<string>();
            var psNamespaceManagerSuffix = this.CreateType<string>();
            var pCache = this.CreateType<LocalCache>();
            SettingsCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SettingsCache(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _settingsCacheInstance.ShouldNotBeNull();
            _settingsCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Load) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_Load_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var filePath = this.CreateType<string>();

            // Act
            Action executeAction = () => _settingsCacheInstance.Load(filePath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoad);
            var filePath = this.CreateType<string>();
            var methodLoadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoad = { filePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoad, methodLoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_settingsCacheInstanceFixture, parametersOfLoad);

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
        public void AUT_SettingsCache_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SettingsCache_Load_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_SettingsCache_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SettingsCache_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (GetSetting) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SettingsCache_GetSetting_Method_Call_Internally(Type[] types)
        {
            var methodGetSettingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSetting, methodGetSettingParametersTypes);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _settingsCacheInstance.GetSetting(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _settingsCacheInstance.GetSetting(psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psName = this.CreateType<string>();
            var methodGetSettingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSetting = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, methodGetSettingParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_settingsCacheInstanceFixture, parametersOfGetSetting);
            var result2 = this.GetResultOfMethod<string>(MethodGetSetting, parametersOfGetSetting, methodGetSettingParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSetting.ShouldNotBeNull();
            parametersOfGetSetting.Length.ShouldBe(1);
            methodGetSettingParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psName = this.CreateType<string>();
            var methodGetSettingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSetting = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSetting, parametersOfGetSetting, methodGetSettingParametersTypes);

            // Assert
            parametersOfGetSetting.ShouldNotBeNull();
            parametersOfGetSetting.Length.ShouldBe(1);
            methodGetSettingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var methodGetSettingParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSetting, methodGetSettingParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSettingParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var methodGetSettingParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSetting, methodGetSettingParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSettingParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SettingsCache_GetSetting_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, 0);
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