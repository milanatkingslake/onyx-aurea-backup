using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Onyx.UI.Areas.HelpPage.Models;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.Models
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.Models.HelpPageApiModel" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.Models"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpPageApiModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpPageApiModel" />)
        /// </summary>
        public HelpPageApiModelTest() : base(typeof(HelpPageApiModel))
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

        #region General Initializer : Class (HelpPageApiModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpPageApiModelInstanceType;
        private HelpPageApiModel _helpPageApiModelInstance;
        private HelpPageApiModel _helpPageApiModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelpPageApiModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpPageApiModelInstanceType = typeof(HelpPageApiModel);
            _helpPageApiModelInstanceFixture = this.Create<HelpPageApiModel>(false);
            _helpPageApiModelInstance = _helpPageApiModelInstanceFixture ?? this.Create<HelpPageApiModel>(true);
            CurrentInstance = _helpPageApiModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpPageApiModel) Initializer

        #region Properties

        private const string PropertyApiDescription = "ApiDescription";
        private const string PropertyUriParameters = "UriParameters";
        private const string PropertyRequestDocumentation = "RequestDocumentation";
        private const string PropertyRequestModelDescription = "RequestModelDescription";
        private const string PropertyRequestBodyParameters = "RequestBodyParameters";
        private const string PropertyResourceDescription = "ResourceDescription";
        private const string PropertyResourceProperties = "ResourceProperties";
        private const string PropertySampleRequests = "SampleRequests";
        private const string PropertySampleResponses = "SampleResponses";
        private const string PropertyErrorMessages = "ErrorMessages";

        #endregion

        #region Methods

        private const string MethodGetParameterDescriptions = "GetParameterDescriptions";

        #endregion

        #endregion

        #region General Initializer : Class (HelpPageApiModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpPageApiModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageApiModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpPageApiModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageApiModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpPageApiModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpPageApiModel)

        #region General Initializer : Class (HelpPageApiModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetParameterDescriptions, 0)]
        public void AUT_HelpPageApiModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpPageApiModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApiDescription)]
        [TestCase(PropertyUriParameters)]
        [TestCase(PropertyRequestDocumentation)]
        [TestCase(PropertyRequestModelDescription)]
        [TestCase(PropertyRequestBodyParameters)]
        [TestCase(PropertyResourceDescription)]
        [TestCase(PropertyResourceProperties)]
        [TestCase(PropertySampleRequests)]
        [TestCase(PropertySampleResponses)]
        [TestCase(PropertyErrorMessages)]
        [Category("AUT Property")]
        public void AUT_HelpPageApiModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelpPageApiModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelpPageApiModel_Is_Instance_Present_Test()
        {
            // Assert
            _helpPageApiModelInstanceType.ShouldNotBeNull();
            _helpPageApiModelInstance.ShouldNotBeNull();
            _helpPageApiModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HelpPageApiModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelpPageApiModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelpPageApiModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helpPageApiModelInstance.ShouldBeAssignableTo<HelpPageApiModel>();
            _helpPageApiModelInstanceFixture.ShouldBeAssignableTo<HelpPageApiModel>();
            CurrentInstance.ShouldBeAssignableTo<HelpPageApiModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HelpPageApiModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpPageApiModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HelpPageApiModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (HelpPageApiModel) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpPageApiModel_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var helpPageApiModelInstance  = new HelpPageApiModel();

            // Asserts
            helpPageApiModelInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelpPageApiModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApiDescription)]
        [TestCase(PropertyUriParameters)]
        [TestCase(PropertyRequestDocumentation)]
        [TestCase(PropertyRequestModelDescription)]
        [TestCase(PropertyRequestBodyParameters)]
        [TestCase(PropertyResourceDescription)]
        [TestCase(PropertyResourceProperties)]
        [TestCase(PropertySampleRequests)]
        [TestCase(PropertySampleResponses)]
        [TestCase(PropertyErrorMessages)]
        public void AUT_HelpPageApiModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ApiDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_ApiDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApiDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyApiDescription);
            Action currentAction = () => propertyInfo.SetValue(_helpPageApiModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ApiDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_ApiDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApiDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyApiDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ErrorMessages) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_ErrorMessages_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorMessages);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorMessages);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (RequestBodyParameters) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_RequestBodyParameters_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestBodyParameters);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestBodyParameters);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (RequestDocumentation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_RequestDocumentation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestDocumentation);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestDocumentation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (RequestModelDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_RequestModelDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestModelDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequestModelDescription);
            Action currentAction = () => propertyInfo.SetValue(_helpPageApiModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (RequestModelDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_RequestModelDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestModelDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestModelDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ResourceDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_ResourceDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceDescription);
            Action currentAction = () => propertyInfo.SetValue(_helpPageApiModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ResourceDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_ResourceDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (ResourceProperties) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_ResourceProperties_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceProperties);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceProperties);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (SampleRequests) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_SampleRequests_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleRequests);
            var propertyInfo = this.GetPropertyInfo(PropertySampleRequests);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (SampleResponses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_SampleResponses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleResponses);
            var propertyInfo = this.GetPropertyInfo(PropertySampleResponses);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageApiModel) => Property (UriParameters) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageApiModel_Public_Class_UriParameters_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUriParameters);
            var propertyInfo = this.GetPropertyInfo(PropertyUriParameters);

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

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var modelDescription = this.CreateType<ModelDescription>();
            var methodGetParameterDescriptionsParametersTypes = new Type[] { typeof(ModelDescription) };
            object[] parametersOfGetParameterDescriptions = { modelDescription };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescriptions, methodGetParameterDescriptionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageApiModelInstanceFixture, parametersOfGetParameterDescriptions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetParameterDescriptions.ShouldNotBeNull();
            parametersOfGetParameterDescriptions.Length.ShouldBe(1);
            methodGetParameterDescriptionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var modelDescription = this.CreateType<ModelDescription>();
            var methodGetParameterDescriptionsParametersTypes = new Type[] { typeof(ModelDescription) };
            object[] parametersOfGetParameterDescriptions = { modelDescription };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ParameterDescription>>(MethodGetParameterDescriptions, parametersOfGetParameterDescriptions, methodGetParameterDescriptionsParametersTypes);

            // Assert
            parametersOfGetParameterDescriptions.ShouldNotBeNull();
            parametersOfGetParameterDescriptions.Length.ShouldBe(1);
            methodGetParameterDescriptionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var methodGetParameterDescriptionsParametersTypes = new Type[] { typeof(ModelDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameterDescriptions, methodGetParameterDescriptionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParameterDescriptionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var methodGetParameterDescriptionsParametersTypes = new Type[] { typeof(ModelDescription) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameterDescriptions, methodGetParameterDescriptionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParameterDescriptionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescriptions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterDescriptions) (Return Type : IList<ParameterDescription>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageApiModel_GetParameterDescriptions_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescriptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescriptions, 0);
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