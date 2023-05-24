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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Configuration.OnyxLanguageCultureMappingsSection" />)
    ///     and namespace <see cref="OnyxSDK.Public.Configuration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxLanguageCultureMappingsSectionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxLanguageCultureMappingsSection" />)
        /// </summary>
        public OnyxLanguageCultureMappingsSectionTest() : base(typeof(OnyxLanguageCultureMappingsSection))
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

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxLanguageCultureMappingsSectionInstanceType;
        private OnyxLanguageCultureMappingsSection _onyxLanguageCultureMappingsSectionInstance;
        private OnyxLanguageCultureMappingsSection _onyxLanguageCultureMappingsSectionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxLanguageCultureMappingsSection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxLanguageCultureMappingsSectionInstanceType = typeof(OnyxLanguageCultureMappingsSection);
            _onyxLanguageCultureMappingsSectionInstanceFixture = this.Create<OnyxLanguageCultureMappingsSection>(false);
            _onyxLanguageCultureMappingsSectionInstance = _onyxLanguageCultureMappingsSectionInstanceFixture ?? this.Create<OnyxLanguageCultureMappingsSection>(true);
            CurrentInstance = _onyxLanguageCultureMappingsSectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) Initializer

        #region Properties

        private const string PropertyOnyxLanguageCultureMappingsSectionInstance = "OnyxLanguageCultureMappingsSectionInstance";
        private const string PropertyOnyxLanguageCultureMappings = "OnyxLanguageCultureMappings";

        #endregion

        #region Methods

        private const string MethodGetConfiguration = "GetConfiguration";
        private const string MethodGetOnyxLanguageCultureMappings = "GetOnyxLanguageCultureMappings";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldonyxLanguageCultureMappingsSectionInstance = "onyxLanguageCultureMappingsSectionInstance";
        private const string FieldSyncRoot = "SyncRoot";
        private const string FieldConfigurationLoaded = "ConfigurationLoaded";
        private const string FieldonyxLanguageCultureMappings = "onyxLanguageCultureMappings";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLanguageCultureMappingsSection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLanguageCultureMappingsSection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLanguageCultureMappingsSection_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxLanguageCultureMappingsSection)

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetConfiguration, 0)]
        [TestCase(MethodGetOnyxLanguageCultureMappings, 0)]
        public void AUT_OnyxLanguageCultureMappingsSection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxLanguageCultureMappingsSectionInstance)]
        [TestCase(PropertyOnyxLanguageCultureMappings)]
        [Category("AUT Property")]
        public void AUT_OnyxLanguageCultureMappingsSection_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxLanguageCultureMappingsSection) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldonyxLanguageCultureMappingsSectionInstance)]
        [TestCase(FieldSyncRoot)]
        [TestCase(FieldConfigurationLoaded)]
        [TestCase(FieldonyxLanguageCultureMappings)]
        [Category("AUT Fields")]
        public void AUT_OnyxLanguageCultureMappingsSection_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxLanguageCultureMappingsSection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxLanguageCultureMappingsSection_Is_Instance_Present_Test()
        {
            // Assert
            _onyxLanguageCultureMappingsSectionInstanceType.ShouldNotBeNull();
            _onyxLanguageCultureMappingsSectionInstance.ShouldNotBeNull();
            _onyxLanguageCultureMappingsSectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxLanguageCultureMappingsSection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMappingsSection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxLanguageCultureMappingsSection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxLanguageCultureMappingsSectionInstance.ShouldBeAssignableTo<OnyxLanguageCultureMappingsSection>();
            _onyxLanguageCultureMappingsSectionInstanceFixture.ShouldBeAssignableTo<OnyxLanguageCultureMappingsSection>();
            CurrentInstance.ShouldBeAssignableTo<OnyxLanguageCultureMappingsSection>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxLanguageCultureMappingsSection) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxLanguageCultureMappingsSectionInstance)]
        [TestCase(PropertyOnyxLanguageCultureMappings)]
        public void AUT_OnyxLanguageCultureMappingsSection_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxLanguageCultureMappingsSection) => Property (OnyxLanguageCultureMappings) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMappingsSection_OnyxLanguageCultureMappings_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxLanguageCultureMappings);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxLanguageCultureMappings);
            Action currentAction = () => propertyInfo.SetValue(_onyxLanguageCultureMappingsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxLanguageCultureMappingsSection) => Property (OnyxLanguageCultureMappings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMappingsSection_Public_Class_OnyxLanguageCultureMappings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxLanguageCultureMappings);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxLanguageCultureMappings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxLanguageCultureMappingsSection) => Property (OnyxLanguageCultureMappingsSectionInstance) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMappingsSection_OnyxLanguageCultureMappingsSectionInstance_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxLanguageCultureMappingsSectionInstance);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxLanguageCultureMappingsSectionInstance);
            Action currentAction = () => propertyInfo.SetValue(_onyxLanguageCultureMappingsSectionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxLanguageCultureMappingsSection) => Property (OnyxLanguageCultureMappingsSectionInstance) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMappingsSection_Public_Class_OnyxLanguageCultureMappingsSectionInstance_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxLanguageCultureMappingsSectionInstance);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxLanguageCultureMappingsSectionInstance);

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

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);

            // Act
            Action executeAction = () => _onyxLanguageCultureMappingsSectionInstance.GetConfiguration();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            var returnedValue = default(OnyxLanguageCultureMappingsSection);

            // Act
            Action executeAction = () => returnedValue = _onyxLanguageCultureMappingsSectionInstance.GetConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxLanguageCultureMappingsSection>(_onyxLanguageCultureMappingsSectionInstanceFixture, out exception1, parametersOfGetConfiguration);
            var result2 = this.GetResultOfMethod<OnyxLanguageCultureMappingsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguration, methodGetConfigurationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxLanguageCultureMappingsSectionInstanceFixture, parametersOfGetConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguration);
            Type [] methodGetConfigurationParametersTypes = null;
            object[] parametersOfGetConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxLanguageCultureMappingsSection>(MethodGetConfiguration, parametersOfGetConfiguration, methodGetConfigurationParametersTypes);

            // Assert
            parametersOfGetConfiguration.ShouldBeNull();
            methodGetConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetConfiguration) (Return Type : OnyxLanguageCultureMappingsSection) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxLanguageCultureMappingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);

            // Act
            Action executeAction = () => _onyxLanguageCultureMappingsSectionInstance.GetOnyxLanguageCultureMappings();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            var returnedValue = default(OnyxLanguageCultureMapping[]);

            // Act
            Action executeAction = () => returnedValue = _onyxLanguageCultureMappingsSectionInstance.GetOnyxLanguageCultureMappings();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            Type [] methodGetOnyxLanguageCultureMappingsParametersTypes = null;
            object[] parametersOfGetOnyxLanguageCultureMappings = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxLanguageCultureMapping[]>(_onyxLanguageCultureMappingsSectionInstanceFixture, out exception1, parametersOfGetOnyxLanguageCultureMappings);
            var result2 = this.GetResultOfMethod<OnyxLanguageCultureMapping[]>(MethodGetOnyxLanguageCultureMappings, parametersOfGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOnyxLanguageCultureMappings.ShouldBeNull();
            methodGetOnyxLanguageCultureMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            Type [] methodGetOnyxLanguageCultureMappingsParametersTypes = null;
            object[] parametersOfGetOnyxLanguageCultureMappings = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxLanguageCultureMappingsSectionInstanceFixture, parametersOfGetOnyxLanguageCultureMappings);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOnyxLanguageCultureMappings.ShouldBeNull();
            methodGetOnyxLanguageCultureMappingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            Type [] methodGetOnyxLanguageCultureMappingsParametersTypes = null;
            object[] parametersOfGetOnyxLanguageCultureMappings = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxLanguageCultureMapping[]>(MethodGetOnyxLanguageCultureMappings, parametersOfGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes);

            // Assert
            parametersOfGetOnyxLanguageCultureMappings.ShouldBeNull();
            methodGetOnyxLanguageCultureMappingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            Type [] methodGetOnyxLanguageCultureMappingsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxLanguageCultureMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            Type [] methodGetOnyxLanguageCultureMappingsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxLanguageCultureMappings, methodGetOnyxLanguageCultureMappingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxLanguageCultureMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxLanguageCultureMappings) (Return Type : OnyxLanguageCultureMapping[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLanguageCultureMappingsSection_GetOnyxLanguageCultureMappings_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxLanguageCultureMappings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxLanguageCultureMappings, 0);

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