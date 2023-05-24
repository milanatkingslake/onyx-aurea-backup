using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy.Helper;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.Helper.OnyxGatewayServiceConfigurationsSection" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxGatewayServiceConfigurationsSectionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayServiceConfigurationsSection" />)
        /// </summary>
        public OnyxGatewayServiceConfigurationsSectionTest() : base(typeof(OnyxGatewayServiceConfigurationsSection))
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

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayServiceConfigurationsSectionInstanceType;
        private OnyxGatewayServiceConfigurationsSection _onyxGatewayServiceConfigurationsSectionInstance;
        private OnyxGatewayServiceConfigurationsSection _onyxGatewayServiceConfigurationsSectionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayServiceConfigurationsSection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayServiceConfigurationsSectionInstanceType = typeof(OnyxGatewayServiceConfigurationsSection);
            _onyxGatewayServiceConfigurationsSectionInstanceFixture = this.Create<OnyxGatewayServiceConfigurationsSection>(false);
            _onyxGatewayServiceConfigurationsSectionInstance = _onyxGatewayServiceConfigurationsSectionInstanceFixture ?? this.Create<OnyxGatewayServiceConfigurationsSection>(true);
            CurrentInstance = _onyxGatewayServiceConfigurationsSectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) Initializer

        #region Properties

        private const string PropertyOnyxGatewayServiceConfigurationsSectionInstance = "OnyxGatewayServiceConfigurationsSectionInstance";
        private const string PropertyOnyxGatewayServiceConfigurations = "OnyxGatewayServiceConfigurations";

        #endregion

        #region Methods

        private const string MethodGetConfiguration = "GetConfiguration";
        private const string MethodGetOnyxGatewayServiceConfigurations = "GetOnyxGatewayServiceConfigurations";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldonyxGatewayServiceConfigurationsSectionInstance = "onyxGatewayServiceConfigurationsSectionInstance";
        private const string FieldSyncRoot = "SyncRoot";
        private const string FieldConfigurationLoaded = "ConfigurationLoaded";
        private const string FieldonyxGatewayServiceConfigurations = "onyxGatewayServiceConfigurations";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayServiceConfigurationsSection)

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetConfiguration, 0)]
        [TestCase(MethodGetOnyxGatewayServiceConfigurations, 0)]
        public void AUT_OnyxGatewayServiceConfigurationsSection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxGatewayServiceConfigurationsSectionInstance)]
        [TestCase(PropertyOnyxGatewayServiceConfigurations)]
        [Category("AUT Property")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxGatewayServiceConfigurationsSection) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldonyxGatewayServiceConfigurationsSectionInstance)]
        [TestCase(FieldSyncRoot)]
        [TestCase(FieldConfigurationLoaded)]
        [TestCase(FieldonyxGatewayServiceConfigurations)]
        [Category("AUT Fields")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxGatewayServiceConfigurationsSection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationsSectionInstanceType.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationsSectionInstance.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationsSectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayServiceConfigurationsSection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurationsSection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationsSectionInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfigurationsSection>();
            _onyxGatewayServiceConfigurationsSectionInstanceFixture.ShouldBeAssignableTo<OnyxGatewayServiceConfigurationsSection>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfigurationsSection>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurationsSection) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxGatewayServiceConfigurationsSectionInstance)]
        [TestCase(PropertyOnyxGatewayServiceConfigurations)]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurationsSection) => Property (OnyxGatewayServiceConfigurations) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_OnyxGatewayServiceConfigurations_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxGatewayServiceConfigurations);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxGatewayServiceConfigurations);
            Action currentAction = () => propertyInfo.SetValue(_onyxGatewayServiceConfigurationsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurationsSection) => Property (OnyxGatewayServiceConfigurations) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Public_Class_OnyxGatewayServiceConfigurations_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxGatewayServiceConfigurations);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxGatewayServiceConfigurations);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurationsSection) => Property (OnyxGatewayServiceConfigurationsSectionInstance) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_OnyxGatewayServiceConfigurationsSectionInstance_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxGatewayServiceConfigurationsSectionInstance);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxGatewayServiceConfigurationsSectionInstance);
            Action currentAction = () => propertyInfo.SetValue(_onyxGatewayServiceConfigurationsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurationsSection) => Property (OnyxGatewayServiceConfigurationsSectionInstance) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_Public_Class_OnyxGatewayServiceConfigurationsSectionInstance_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxGatewayServiceConfigurationsSectionInstance);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxGatewayServiceConfigurationsSectionInstance);

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

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);

            // Act
            Action executeAction = () => _onyxGatewayServiceConfigurationsSectionInstance.GetConfiguration();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            var returnedValue = default(OnyxGatewayServiceConfigurationsSection);

            // Act
            Action executeAction = () => returnedValue = _onyxGatewayServiceConfigurationsSectionInstance.GetConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxGatewayServiceConfigurationsSection>(_onyxGatewayServiceConfigurationsSectionInstanceFixture, out exception1, parametersOfGetConfiguration);
            var result2 = this.GetResultOfMethod<OnyxGatewayServiceConfigurationsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayServiceConfigurationsSectionInstanceFixture, parametersOfGetConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxGatewayServiceConfigurationsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxGatewayServiceConfigurationsSection) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxGatewayServiceConfigurationsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);

            // Act
            Action executeAction = () => _onyxGatewayServiceConfigurationsSectionInstance.GetOnyxGatewayServiceConfigurations();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            var returnedValue = default(OnyxGatewayServiceConfiguration[]);

            // Act
            Action executeAction = () => returnedValue = _onyxGatewayServiceConfigurationsSectionInstance.GetOnyxGatewayServiceConfigurations();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            Type [] methodGetOnyxGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfigurations = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxGatewayServiceConfiguration[]>(_onyxGatewayServiceConfigurationsSectionInstanceFixture, out exception1, parametersOfGetOnyxGatewayServiceConfigurations);
            var result2 = this.GetResultOfMethod<OnyxGatewayServiceConfiguration[]>(MethodGetOnyxGatewayServiceConfigurations, parametersOfGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOnyxGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            Type [] methodGetOnyxGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfigurations = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayServiceConfigurationsSectionInstanceFixture, parametersOfGetOnyxGatewayServiceConfigurations);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOnyxGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            Type [] methodGetOnyxGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfigurations = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxGatewayServiceConfiguration[]>(MethodGetOnyxGatewayServiceConfigurations, parametersOfGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes);

            // Assert
            parametersOfGetOnyxGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            Type [] methodGetOnyxGatewayServiceConfigurationsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            Type [] methodGetOnyxGatewayServiceConfigurationsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfigurations, methodGetOnyxGatewayServiceConfigurationsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfigurations) (Return Type : OnyxGatewayServiceConfiguration[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurationsSection_GetOnyxGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfigurations);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfigurations, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}