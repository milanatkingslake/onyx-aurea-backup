using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.OnyxGatewayServiceConfigurations" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxGatewayServiceConfigurationsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayServiceConfigurations" />)
        /// </summary>
        public OnyxGatewayServiceConfigurationsTest() : base(typeof(OnyxGatewayServiceConfigurations))
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

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayServiceConfigurationsInstanceType;
        private OnyxGatewayServiceConfigurations _onyxGatewayServiceConfigurationsInstance;
        private OnyxGatewayServiceConfigurations _onyxGatewayServiceConfigurationsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayServiceConfigurations" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayServiceConfigurationsInstanceType = typeof(OnyxGatewayServiceConfigurations);
            _onyxGatewayServiceConfigurationsInstanceFixture = this.Create<OnyxGatewayServiceConfigurations>(false);
            _onyxGatewayServiceConfigurationsInstance = _onyxGatewayServiceConfigurationsInstanceFixture ?? this.Create<OnyxGatewayServiceConfigurations>(true);
            CurrentInstance = _onyxGatewayServiceConfigurationsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) Initializer

        #region Properties

        private const string PropertyCollectionType = "CollectionType";
        private const string PropertyElementName = "ElementName";

        #endregion

        #region Methods

        private const string MethodCreateNewElement = "CreateNewElement";
        private const string MethodGetElementKey = "GetElementKey";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfigurations_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfigurations_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayServiceConfigurations)

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateNewElement, 0)]
        [TestCase(MethodGetElementKey, 0)]
        public void AUT_OnyxGatewayServiceConfigurations_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxGatewayServiceConfigurations) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCollectionType)]
        [TestCase(PropertyElementName)]
        [Category("AUT Property")]
        public void AUT_OnyxGatewayServiceConfigurations_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxGatewayServiceConfigurations) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfigurations_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationsInstanceType.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationsInstance.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayServiceConfigurations) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfigurations" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfigurations_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationsInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfigurations>();
            _onyxGatewayServiceConfigurationsInstanceFixture.ShouldBeAssignableTo<OnyxGatewayServiceConfigurations>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfigurations>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxGatewayServiceConfigurations) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxGatewayServiceConfigurations_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxGatewayServiceConfigurations instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurations) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCollectionType)]
        [TestCase(PropertyElementName)]
        public void AUT_OnyxGatewayServiceConfigurations_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurations) => Property (CollectionType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurations_CollectionType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCollectionType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCollectionType);
            Action currentAction = () => propertyInfo.SetValue(_onyxGatewayServiceConfigurationsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurations) => Property (CollectionType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurations_Public_Class_CollectionType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCollectionType);
            var propertyInfo = this.GetPropertyInfo(PropertyCollectionType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfigurations) => Property (ElementName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfigurations_Public_Class_ElementName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyElementName);
            var propertyInfo = this.GetPropertyInfo(PropertyElementName);

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

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            Type [] methodCreateNewElementParametersTypes = null;
            object[] parametersOfCreateNewElement = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewElement, methodCreateNewElementParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ConfigurationElement>(_onyxGatewayServiceConfigurationsInstanceFixture, out exception1, parametersOfCreateNewElement);
            var result2 = this.GetResultOfMethod<ConfigurationElement>(MethodCreateNewElement, parametersOfCreateNewElement, methodCreateNewElementParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNewElement.ShouldBeNull();
            methodCreateNewElementParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            Type [] methodCreateNewElementParametersTypes = null;
            object[] parametersOfCreateNewElement = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewElement, methodCreateNewElementParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayServiceConfigurationsInstanceFixture, parametersOfCreateNewElement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateNewElement.ShouldBeNull();
            methodCreateNewElementParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            Type [] methodCreateNewElementParametersTypes = null;
            object[] parametersOfCreateNewElement = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ConfigurationElement>(MethodCreateNewElement, parametersOfCreateNewElement, methodCreateNewElementParametersTypes);

            // Assert
            parametersOfCreateNewElement.ShouldBeNull();
            methodCreateNewElementParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            Type [] methodCreateNewElementParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewElement, methodCreateNewElementParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNewElementParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            Type [] methodCreateNewElementParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNewElement, methodCreateNewElementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNewElementParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewElement) (Return Type : ConfigurationElement) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_CreateNewElement_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewElement);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewElement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_Internally(Type[] types)
        {
            var methodGetElementKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetElementKey, methodGetElementKeyParametersTypes);
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var element = this.CreateType<ConfigurationElement>();
            var methodGetElementKeyParametersTypes = new Type[] { typeof(ConfigurationElement) };
            object[] parametersOfGetElementKey = { element };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementKey, methodGetElementKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_onyxGatewayServiceConfigurationsInstanceFixture, parametersOfGetElementKey);
            var result2 = this.GetResultOfMethod<object>(MethodGetElementKey, parametersOfGetElementKey, methodGetElementKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetElementKey.ShouldNotBeNull();
            parametersOfGetElementKey.Length.ShouldBe(1);
            methodGetElementKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var element = this.CreateType<ConfigurationElement>();
            var methodGetElementKeyParametersTypes = new Type[] { typeof(ConfigurationElement) };
            object[] parametersOfGetElementKey = { element };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetElementKey, parametersOfGetElementKey, methodGetElementKeyParametersTypes);

            // Assert
            parametersOfGetElementKey.ShouldNotBeNull();
            parametersOfGetElementKey.Length.ShouldBe(1);
            methodGetElementKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var methodGetElementKeyParametersTypes = new Type[] { typeof(ConfigurationElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetElementKey, methodGetElementKeyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetElementKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var methodGetElementKeyParametersTypes = new Type[] { typeof(ConfigurationElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetElementKey, methodGetElementKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetElementKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetElementKey) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceConfigurations_GetElementKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementKey, 0);
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