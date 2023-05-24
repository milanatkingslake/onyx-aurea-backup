using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Configuration;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Configuration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Configuration.OnyxSDKGatewayServiceConfigurationsSection" />)
    ///     and namespace <see cref="OnyxSDK.Public.Configuration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSDKGatewayServiceConfigurationsSectionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />)
        /// </summary>
        public OnyxSDKGatewayServiceConfigurationsSectionTest() : base(typeof(OnyxSDKGatewayServiceConfigurationsSection))
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

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSDKGatewayServiceConfigurationsSectionInstanceType;
        private OnyxSDKGatewayServiceConfigurationsSection _onyxSDKGatewayServiceConfigurationsSectionInstance;
        private OnyxSDKGatewayServiceConfigurationsSection _onyxSDKGatewayServiceConfigurationsSectionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSDKGatewayServiceConfigurationsSection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSDKGatewayServiceConfigurationsSectionInstanceType = typeof(OnyxSDKGatewayServiceConfigurationsSection);
            _onyxSDKGatewayServiceConfigurationsSectionInstanceFixture = this.Create<OnyxSDKGatewayServiceConfigurationsSection>(false);
            _onyxSDKGatewayServiceConfigurationsSectionInstance = _onyxSDKGatewayServiceConfigurationsSectionInstanceFixture ?? this.Create<OnyxSDKGatewayServiceConfigurationsSection>(true);
            CurrentInstance = _onyxSDKGatewayServiceConfigurationsSectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) Initializer

        #region Properties

        private const string PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance = "OnyxSDKGatewayServiceConfigurationsSectionInstance";
        private const string PropertyOnyxSDKGatewayServiceConfigurations = "OnyxSDKGatewayServiceConfigurations";

        #endregion

        #region Methods

        private const string MethodGetConfiguration = "GetConfiguration";
        private const string MethodGetOnyxSDKGatewayServiceConfigurations = "GetOnyxSDKGatewayServiceConfigurations";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldonyxSDKGatewayServiceConfigurationsSectionInstance = "onyxSDKGatewayServiceConfigurationsSectionInstance";
        private const string FieldSyncRoot = "SyncRoot";
        private const string FieldConfigurationLoaded = "ConfigurationLoaded";
        private const string FieldonyxSDKGatewayServiceConfigurations = "onyxSDKGatewayServiceConfigurations";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSDKGatewayServiceConfigurationsSection)

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetConfiguration, 0)]
        [TestCase(MethodGetOnyxSDKGatewayServiceConfigurations, 0)]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance)]
        [TestCase(PropertyOnyxSDKGatewayServiceConfigurations)]
        [Category("AUT Property")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSDKGatewayServiceConfigurationsSection) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldonyxSDKGatewayServiceConfigurationsSectionInstance)]
        [TestCase(FieldSyncRoot)]
        [TestCase(FieldConfigurationLoaded)]
        [TestCase(FieldonyxSDKGatewayServiceConfigurations)]
        [Category("AUT Fields")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxSDKGatewayServiceConfigurationsSection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Is_Instance_Present_Test()
        {
            // Assert
            _onyxSDKGatewayServiceConfigurationsSectionInstanceType.ShouldNotBeNull();
            _onyxSDKGatewayServiceConfigurationsSectionInstance.ShouldNotBeNull();
            _onyxSDKGatewayServiceConfigurationsSectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxSDKGatewayServiceConfigurationsSection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSDKGatewayServiceConfigurationsSection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSDKGatewayServiceConfigurationsSectionInstance.ShouldBeAssignableTo<OnyxSDKGatewayServiceConfigurationsSection>();
            _onyxSDKGatewayServiceConfigurationsSectionInstanceFixture.ShouldBeAssignableTo<OnyxSDKGatewayServiceConfigurationsSection>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSDKGatewayServiceConfigurationsSection>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSDKGatewayServiceConfigurationsSection) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance)]
        [TestCase(PropertyOnyxSDKGatewayServiceConfigurations)]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSDKGatewayServiceConfigurationsSection) => Property (OnyxSDKGatewayServiceConfigurations) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_OnyxSDKGatewayServiceConfigurations_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSDKGatewayServiceConfigurations);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSDKGatewayServiceConfigurations);
            Action currentAction = () => propertyInfo.SetValue(_onyxSDKGatewayServiceConfigurationsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKGatewayServiceConfigurationsSection) => Property (OnyxSDKGatewayServiceConfigurations) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Public_Class_OnyxSDKGatewayServiceConfigurations_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSDKGatewayServiceConfigurations);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSDKGatewayServiceConfigurations);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKGatewayServiceConfigurationsSection) => Property (OnyxSDKGatewayServiceConfigurationsSectionInstance) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_OnyxSDKGatewayServiceConfigurationsSectionInstance_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance);
            Action currentAction = () => propertyInfo.SetValue(_onyxSDKGatewayServiceConfigurationsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKGatewayServiceConfigurationsSection) => Property (OnyxSDKGatewayServiceConfigurationsSectionInstance) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_Public_Class_OnyxSDKGatewayServiceConfigurationsSectionInstance_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSDKGatewayServiceConfigurationsSectionInstance);

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

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);

            // Act
            Action executeAction = () => _onyxSDKGatewayServiceConfigurationsSectionInstance.GetConfiguration();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            var returnedValue = default(OnyxSDKGatewayServiceConfigurationsSection);

            // Act
            Action executeAction = () => returnedValue = _onyxSDKGatewayServiceConfigurationsSectionInstance.GetConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxSDKGatewayServiceConfigurationsSection>(_onyxSDKGatewayServiceConfigurationsSectionInstanceFixture, out exception1, parametersOfGetConfiguration);
            var result2 = this.GetResultOfMethod<OnyxSDKGatewayServiceConfigurationsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSDKGatewayServiceConfigurationsSectionInstanceFixture, parametersOfGetConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxSDKGatewayServiceConfigurationsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetConfiguration) (Return Type : OnyxSDKGatewayServiceConfigurationsSection) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);

            // Act
            Action executeAction = () => _onyxSDKGatewayServiceConfigurationsSectionInstance.GetOnyxSDKGatewayServiceConfigurations();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            var returnedValue = default(OnyxSDKGatewayServiceConfiguration[]);

            // Act
            Action executeAction = () => returnedValue = _onyxSDKGatewayServiceConfigurationsSectionInstance.GetOnyxSDKGatewayServiceConfigurations();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            Type [] methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxSDKGatewayServiceConfigurations = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxSDKGatewayServiceConfiguration[]>(_onyxSDKGatewayServiceConfigurationsSectionInstanceFixture, out exception1, parametersOfGetOnyxSDKGatewayServiceConfigurations);
            var result2 = this.GetResultOfMethod<OnyxSDKGatewayServiceConfiguration[]>(MethodGetOnyxSDKGatewayServiceConfigurations, parametersOfGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOnyxSDKGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            Type [] methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxSDKGatewayServiceConfigurations = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSDKGatewayServiceConfigurationsSectionInstanceFixture, parametersOfGetOnyxSDKGatewayServiceConfigurations);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOnyxSDKGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            Type [] methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = null;
            object[] parametersOfGetOnyxSDKGatewayServiceConfigurations = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxSDKGatewayServiceConfiguration[]>(MethodGetOnyxSDKGatewayServiceConfigurations, parametersOfGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes);

            // Assert
            parametersOfGetOnyxSDKGatewayServiceConfigurations.ShouldBeNull();
            methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            Type [] methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            Type [] methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxSDKGatewayServiceConfigurations, methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxSDKGatewayServiceConfigurationsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxSDKGatewayServiceConfigurations) (Return Type : OnyxSDKGatewayServiceConfiguration[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSDKGatewayServiceConfigurationsSection_GetOnyxSDKGatewayServiceConfigurations_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxSDKGatewayServiceConfigurations);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxSDKGatewayServiceConfigurations, 0);

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