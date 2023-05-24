using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Description;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Onyx.UI.Areas.HelpPage.Models;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.HelpPageConfigurationExtensions" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpPageConfigurationExtensionsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpPageConfigurationExtensions" />)
        /// </summary>
        public HelpPageConfigurationExtensionsTest() : base(typeof(HelpPageConfigurationExtensions))
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

        #region General Initializer : Class (HelpPageConfigurationExtensions) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpPageConfigurationExtensionsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="HelpPageConfigurationExtensions" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpPageConfigurationExtensionsInstanceType = typeof(HelpPageConfigurationExtensions);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpPageConfigurationExtensions) Initializer

        #region Methods

        private const string MethodSetDocumentationProvider = "SetDocumentationProvider";
        private const string MethodSetSampleObjects = "SetSampleObjects";
        private const string MethodSetSampleRequest = "SetSampleRequest";
        private const string MethodSetSampleResponse = "SetSampleResponse";
        private const string MethodSetSampleForMediaType = "SetSampleForMediaType";
        private const string MethodSetSampleForType = "SetSampleForType";
        private const string MethodSetActualRequestType = "SetActualRequestType";
        private const string MethodSetActualResponseType = "SetActualResponseType";
        private const string MethodGetHelpPageSampleGenerator = "GetHelpPageSampleGenerator";
        private const string MethodSetHelpPageSampleGenerator = "SetHelpPageSampleGenerator";
        private const string MethodGetModelDescriptionGenerator = "GetModelDescriptionGenerator";
        private const string MethodGetHelpPageApiModel = "GetHelpPageApiModel";
        private const string MethodGenerateApiModel = "GenerateApiModel";
        private const string MethodGenerateUriParameters = "GenerateUriParameters";
        private const string MethodIsBindableWithTypeConverter = "IsBindableWithTypeConverter";
        private const string MethodAddParameterDescription = "AddParameterDescription";
        private const string MethodGenerateRequestModelDescription = "GenerateRequestModelDescription";
        private const string MethodGenerateResourceDescription = "GenerateResourceDescription";
        private const string MethodGenerateSamples = "GenerateSamples";
        private const string MethodTryGetResourceParameter = "TryGetResourceParameter";
        private const string MethodInitializeModelDescriptionGenerator = "InitializeModelDescriptionGenerator";
        private const string MethodLogInvalidSampleAsError = "LogInvalidSampleAsError";

        #endregion

        #region Fields

        private const string FieldApiModelPrefix = "ApiModelPrefix";

        #endregion

        #endregion

        #region General Initializer : Class (HelpPageConfigurationExtensions) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpPageConfigurationExtensions" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageConfigurationExtensions_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageConfigurationExtensions) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelpPageConfigurationExtensions" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageConfigurationExtensions_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpPageConfigurationExtensions)

        #region General Initializer : Class (HelpPageConfigurationExtensions) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpPageConfigurationExtensions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodSetDocumentationProvider, 0)]
        [TestCase(MethodSetSampleObjects, 0)]
        [TestCase(MethodSetSampleRequest, 0)]
        [TestCase(MethodSetSampleRequest, 1)]
        [TestCase(MethodSetSampleResponse, 0)]
        [TestCase(MethodSetSampleResponse, 1)]
        [TestCase(MethodSetSampleForMediaType, 0)]
        [TestCase(MethodSetSampleForType, 0)]
        [TestCase(MethodSetActualRequestType, 0)]
        [TestCase(MethodSetActualRequestType, 1)]
        [TestCase(MethodSetActualResponseType, 0)]
        [TestCase(MethodSetActualResponseType, 1)]
        [TestCase(MethodGetHelpPageSampleGenerator, 0)]
        [TestCase(MethodSetHelpPageSampleGenerator, 0)]
        [TestCase(MethodGetModelDescriptionGenerator, 0)]
        [TestCase(MethodGetHelpPageApiModel, 0)]
        [TestCase(MethodGenerateApiModel, 0)]
        [TestCase(MethodGenerateUriParameters, 0)]
        [TestCase(MethodIsBindableWithTypeConverter, 0)]
        [TestCase(MethodAddParameterDescription, 0)]
        [TestCase(MethodGenerateRequestModelDescription, 0)]
        [TestCase(MethodGenerateResourceDescription, 0)]
        [TestCase(MethodGenerateSamples, 0)]
        [TestCase(MethodTryGetResourceParameter, 0)]
        [TestCase(MethodInitializeModelDescriptionGenerator, 0)]
        [TestCase(MethodLogInvalidSampleAsError, 0)]
        public void AUT_HelpPageConfigurationExtensions_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpPageConfigurationExtensions) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpPageConfigurationExtensions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldApiModelPrefix)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_HelpPageConfigurationExtensions_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelpPageConfigurationExtensions) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelpPageConfigurationExtensions" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_HelpPageConfigurationExtensions_Is_Static_Type_Present_Test()
        {
            // Assert
            _helpPageConfigurationExtensionsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SetDocumentationProvider) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var config = this.CreateType<HttpConfiguration>();
            var documentationProvider = this.CreateType<IDocumentationProvider>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetDocumentationProvider(config, documentationProvider);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDocumentationProvider) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var config = this.CreateType<HttpConfiguration>();
            var documentationProvider = this.CreateType<IDocumentationProvider>();
            var methodSetDocumentationProviderParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(IDocumentationProvider) };
            object[] parametersOfSetDocumentationProvider = { config, documentationProvider };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocumentationProvider, methodSetDocumentationProviderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetDocumentationProvider);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDocumentationProvider.ShouldNotBeNull();
            parametersOfSetDocumentationProvider.Length.ShouldBe(2);
            methodSetDocumentationProviderParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetDocumentationProvider) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var config = this.CreateType<HttpConfiguration>();
            var documentationProvider = this.CreateType<IDocumentationProvider>();
            var methodSetDocumentationProviderParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(IDocumentationProvider) };
            object[] parametersOfSetDocumentationProvider = { config, documentationProvider };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDocumentationProvider, parametersOfSetDocumentationProvider, methodSetDocumentationProviderParametersTypes);

            // Assert
            parametersOfSetDocumentationProvider.ShouldNotBeNull();
            parametersOfSetDocumentationProvider.Length.ShouldBe(2);
            methodSetDocumentationProviderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocumentationProvider) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocumentationProvider, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDocumentationProvider) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var methodSetDocumentationProviderParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(IDocumentationProvider) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDocumentationProvider, methodSetDocumentationProviderParametersTypes);

            // Assert
            methodSetDocumentationProviderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDocumentationProvider) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetDocumentationProvider_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDocumentationProvider);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDocumentationProvider, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleObjects) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetSampleObjects_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetSampleObjectsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSampleObjects, methodSetSampleObjectsParametersTypes);
        }

        #endregion

        #region Method Call : (SetSampleRequest) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleRequest_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleRequest);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetSampleRequest(config, sample, mediaType, controllerName, actionName, parameterNames);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSampleRequest) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleRequest_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleRequest, 1);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (SetSampleRequest) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleRequest_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleRequest, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetSampleResponse) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetSampleResponse(config, sample, mediaType, controllerName, actionName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var methodSetSampleResponseParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(string), typeof(string) };
            object[] parametersOfSetSampleResponse = { config, sample, mediaType, controllerName, actionName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSampleResponse, parametersOfSetSampleResponse, methodSetSampleResponseParametersTypes);

            // Assert
            parametersOfSetSampleResponse.ShouldNotBeNull();
            parametersOfSetSampleResponse.Length.ShouldBe(5);
            methodSetSampleResponseParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleResponse, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var methodSetSampleResponseParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSampleResponse, methodSetSampleResponseParametersTypes);

            // Assert
            methodSetSampleResponseParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleResponse, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetSampleResponseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSampleResponse, methodSetSampleResponseParametersTypes);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetSampleResponse(config, sample, mediaType, controllerName, actionName, parameterNames);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetSampleResponseParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetSampleResponse = { config, sample, mediaType, controllerName, actionName, parameterNames };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleResponse, methodSetSampleResponseParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetSampleResponse);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSampleResponse.ShouldNotBeNull();
            parametersOfSetSampleResponse.Length.ShouldBe(6);
            methodSetSampleResponseParametersTypes.Length.ShouldBe(6);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetSampleResponseParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetSampleResponse = { config, sample, mediaType, controllerName, actionName, parameterNames };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSampleResponse, parametersOfSetSampleResponse, methodSetSampleResponseParametersTypes);

            // Assert
            parametersOfSetSampleResponse.ShouldNotBeNull();
            parametersOfSetSampleResponse.Length.ShouldBe(6);
            methodSetSampleResponseParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleResponse, 1);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var methodSetSampleResponseParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(string), typeof(string), typeof(string[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSampleResponse, methodSetSampleResponseParametersTypes);

            // Assert
            methodSetSampleResponseParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleResponse) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleResponse_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleResponse, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetSampleForMediaTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSampleForMediaType, methodSetSampleForMediaTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetSampleForMediaType(config, sample, mediaType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var methodSetSampleForMediaTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue) };
            object[] parametersOfSetSampleForMediaType = { config, sample, mediaType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForMediaType, methodSetSampleForMediaTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetSampleForMediaType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSampleForMediaType.ShouldNotBeNull();
            parametersOfSetSampleForMediaType.Length.ShouldBe(3);
            methodSetSampleForMediaTypeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var methodSetSampleForMediaTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue) };
            object[] parametersOfSetSampleForMediaType = { config, sample, mediaType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSampleForMediaType, parametersOfSetSampleForMediaType, methodSetSampleForMediaTypeParametersTypes);

            // Assert
            parametersOfSetSampleForMediaType.ShouldNotBeNull();
            parametersOfSetSampleForMediaType.Length.ShouldBe(3);
            methodSetSampleForMediaTypeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForMediaType, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var methodSetSampleForMediaTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSampleForMediaType, methodSetSampleForMediaTypeParametersTypes);

            // Assert
            methodSetSampleForMediaTypeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForMediaType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForMediaType_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForMediaType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForMediaType, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetSampleForTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSampleForType, methodSetSampleForTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetSampleForType(config, sample, mediaType, type);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var type = this.CreateType<Type>();
            var methodSetSampleForTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(Type) };
            object[] parametersOfSetSampleForType = { config, sample, mediaType, type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForType, methodSetSampleForTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetSampleForType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSampleForType.ShouldNotBeNull();
            parametersOfSetSampleForType.Length.ShouldBe(4);
            methodSetSampleForTypeParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var config = this.CreateType<HttpConfiguration>();
            var sample = this.CreateType<object>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var type = this.CreateType<Type>();
            var methodSetSampleForTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(Type) };
            object[] parametersOfSetSampleForType = { config, sample, mediaType, type };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSampleForType, parametersOfSetSampleForType, methodSetSampleForTypeParametersTypes);

            // Assert
            parametersOfSetSampleForType.ShouldNotBeNull();
            parametersOfSetSampleForType.Length.ShouldBe(4);
            methodSetSampleForTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForType, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var methodSetSampleForTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(object), typeof(MediaTypeHeaderValue), typeof(Type) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSampleForType, methodSetSampleForTypeParametersTypes);

            // Assert
            methodSetSampleForTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSampleForType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetSampleForType_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSampleForType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSampleForType, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetActualRequestTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetActualRequestType(config, type, controllerName, actionName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };
            object[] parametersOfSetActualRequestType = { config, type, controllerName, actionName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetActualRequestType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetActualRequestType.ShouldNotBeNull();
            parametersOfSetActualRequestType.Length.ShouldBe(4);
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };
            object[] parametersOfSetActualRequestType = { config, type, controllerName, actionName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetActualRequestType, parametersOfSetActualRequestType, methodSetActualRequestTypeParametersTypes);

            // Assert
            parametersOfSetActualRequestType.ShouldNotBeNull();
            parametersOfSetActualRequestType.Length.ShouldBe(4);
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes);

            // Assert
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetActualRequestTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetActualRequestType(config, type, controllerName, actionName, parameterNames);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetActualRequestType = { config, type, controllerName, actionName, parameterNames };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetActualRequestType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetActualRequestType.ShouldNotBeNull();
            parametersOfSetActualRequestType.Length.ShouldBe(5);
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetActualRequestType = { config, type, controllerName, actionName, parameterNames };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetActualRequestType, parametersOfSetActualRequestType, methodSetActualRequestTypeParametersTypes);

            // Assert
            parametersOfSetActualRequestType.ShouldNotBeNull();
            parametersOfSetActualRequestType.Length.ShouldBe(5);
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var methodSetActualRequestTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetActualRequestType, methodSetActualRequestTypeParametersTypes);

            // Assert
            methodSetActualRequestTypeParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualRequestType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualRequestType_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualRequestType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualRequestType, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetActualResponseTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetActualResponseType(config, type, controllerName, actionName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };
            object[] parametersOfSetActualResponseType = { config, type, controllerName, actionName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetActualResponseType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetActualResponseType.ShouldNotBeNull();
            parametersOfSetActualResponseType.Length.ShouldBe(4);
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };
            object[] parametersOfSetActualResponseType = { config, type, controllerName, actionName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetActualResponseType, parametersOfSetActualResponseType, methodSetActualResponseTypeParametersTypes);

            // Assert
            parametersOfSetActualResponseType.ShouldNotBeNull();
            parametersOfSetActualResponseType.Length.ShouldBe(4);
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes);

            // Assert
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetActualResponseTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetActualResponseType(config, type, controllerName, actionName, parameterNames);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetActualResponseType = { config, type, controllerName, actionName, parameterNames };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetActualResponseType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetActualResponseType.ShouldNotBeNull();
            parametersOfSetActualResponseType.Length.ShouldBe(5);
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var config = this.CreateType<HttpConfiguration>();
            var type = this.CreateType<Type>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<string[]>();
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };
            object[] parametersOfSetActualResponseType = { config, type, controllerName, actionName, parameterNames };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetActualResponseType, parametersOfSetActualResponseType, methodSetActualResponseTypeParametersTypes);

            // Assert
            parametersOfSetActualResponseType.ShouldNotBeNull();
            parametersOfSetActualResponseType.Length.ShouldBe(5);
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var methodSetActualResponseTypeParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(Type), typeof(string), typeof(string), typeof(string[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetActualResponseType, methodSetActualResponseTypeParametersTypes);

            // Assert
            methodSetActualResponseTypeParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetActualResponseType) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetActualResponseType_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetActualResponseType);
            var currentMethodInfo = this.GetMethodInfo(MethodSetActualResponseType, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetHelpPageSampleGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.GetHelpPageSampleGenerator(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var returnedValue = default(HelpPageSampleGenerator);

            // Act
            Action executeAction = () => returnedValue = HelpPageConfigurationExtensions.GetHelpPageSampleGenerator(config);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodGetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfGetHelpPageSampleGenerator = { config };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);
            var result2 = this.GetResultOfMethod<HelpPageSampleGenerator>(MethodGetHelpPageSampleGenerator, parametersOfGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetHelpPageSampleGenerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHelpPageSampleGenerator.ShouldNotBeNull();
            parametersOfGetHelpPageSampleGenerator.Length.ShouldBe(1);
            methodGetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodGetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfGetHelpPageSampleGenerator = { config };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HelpPageSampleGenerator>(MethodGetHelpPageSampleGenerator, parametersOfGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);

            // Assert
            parametersOfGetHelpPageSampleGenerator.ShouldNotBeNull();
            parametersOfGetHelpPageSampleGenerator.Length.ShouldBe(1);
            methodGetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var methodGetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var methodGetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHelpPageSampleGenerator, methodGetHelpPageSampleGeneratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageSampleGenerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHelpPageSampleGenerator) (Return Type : HelpPageSampleGenerator) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageSampleGenerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageSampleGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageSampleGenerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetHelpPageSampleGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetHelpPageSampleGenerator, methodSetHelpPageSampleGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.SetHelpPageSampleGenerator(config, sampleGenerator);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodSetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(HelpPageSampleGenerator) };
            object[] parametersOfSetHelpPageSampleGenerator = { config, sampleGenerator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetHelpPageSampleGenerator, methodSetHelpPageSampleGeneratorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetHelpPageSampleGenerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetHelpPageSampleGenerator.ShouldNotBeNull();
            parametersOfSetHelpPageSampleGenerator.Length.ShouldBe(2);
            methodSetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodSetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(HelpPageSampleGenerator) };
            object[] parametersOfSetHelpPageSampleGenerator = { config, sampleGenerator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetHelpPageSampleGenerator, parametersOfSetHelpPageSampleGenerator, methodSetHelpPageSampleGeneratorParametersTypes);

            // Assert
            parametersOfSetHelpPageSampleGenerator.ShouldNotBeNull();
            parametersOfSetHelpPageSampleGenerator.Length.ShouldBe(2);
            methodSetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodSetHelpPageSampleGenerator, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var methodSetHelpPageSampleGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(HelpPageSampleGenerator) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetHelpPageSampleGenerator, methodSetHelpPageSampleGeneratorParametersTypes);

            // Assert
            methodSetHelpPageSampleGeneratorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHelpPageSampleGenerator) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_SetHelpPageSampleGenerator_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHelpPageSampleGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodSetHelpPageSampleGenerator, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetModelDescriptionGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.GetModelDescriptionGenerator(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var returnedValue = default(ModelDescriptionGenerator);

            // Act
            Action executeAction = () => returnedValue = HelpPageConfigurationExtensions.GetModelDescriptionGenerator(config);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodGetModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfGetModelDescriptionGenerator = { config };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);
            var result2 = this.GetResultOfMethod<ModelDescriptionGenerator>(MethodGetModelDescriptionGenerator, parametersOfGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetModelDescriptionGenerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModelDescriptionGenerator.ShouldNotBeNull();
            parametersOfGetModelDescriptionGenerator.Length.ShouldBe(1);
            methodGetModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodGetModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfGetModelDescriptionGenerator = { config };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDescriptionGenerator>(MethodGetModelDescriptionGenerator, parametersOfGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);

            // Assert
            parametersOfGetModelDescriptionGenerator.ShouldNotBeNull();
            parametersOfGetModelDescriptionGenerator.Length.ShouldBe(1);
            methodGetModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var methodGetModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var methodGetModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModelDescriptionGenerator, methodGetModelDescriptionGeneratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModelDescriptionGeneratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDescriptionGenerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetModelDescriptionGenerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDescriptionGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDescriptionGenerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetHelpPageApiModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var config = this.CreateType<HttpConfiguration>();
            var apiDescriptionId = this.CreateType<string>();

            // Act
            Action executeAction = () => HelpPageConfigurationExtensions.GetHelpPageApiModel(config, apiDescriptionId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var config = this.CreateType<HttpConfiguration>();
            var apiDescriptionId = this.CreateType<string>();
            var returnedValue = default(HelpPageApiModel);

            // Act
            Action executeAction = () => returnedValue = HelpPageConfigurationExtensions.GetHelpPageApiModel(config, apiDescriptionId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var config = this.CreateType<HttpConfiguration>();
            var apiDescriptionId = this.CreateType<string>();
            var methodGetHelpPageApiModelParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(string) };
            object[] parametersOfGetHelpPageApiModel = { config, apiDescriptionId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);
            var result2 = this.GetResultOfMethod<HelpPageApiModel>(MethodGetHelpPageApiModel, parametersOfGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetHelpPageApiModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHelpPageApiModel.ShouldNotBeNull();
            parametersOfGetHelpPageApiModel.Length.ShouldBe(2);
            methodGetHelpPageApiModelParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var config = this.CreateType<HttpConfiguration>();
            var apiDescriptionId = this.CreateType<string>();
            var methodGetHelpPageApiModelParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(string) };
            object[] parametersOfGetHelpPageApiModel = { config, apiDescriptionId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HelpPageApiModel>(MethodGetHelpPageApiModel, parametersOfGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);

            // Assert
            parametersOfGetHelpPageApiModel.ShouldNotBeNull();
            parametersOfGetHelpPageApiModel.Length.ShouldBe(2);
            methodGetHelpPageApiModelParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var methodGetHelpPageApiModelParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHelpPageApiModelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var methodGetHelpPageApiModelParametersTypes = new Type[] { typeof(HttpConfiguration), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHelpPageApiModel, methodGetHelpPageApiModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHelpPageApiModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageApiModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHelpPageApiModel) (Return Type : HelpPageApiModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GetHelpPageApiModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHelpPageApiModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHelpPageApiModel, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateApiModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateApiModel, methodGenerateApiModelParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var apiDescription = this.CreateType<ApiDescription>();
            var config = this.CreateType<HttpConfiguration>();
            var methodGenerateApiModelParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration) };
            object[] parametersOfGenerateApiModel = { apiDescription, config };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateApiModel, methodGenerateApiModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateApiModel, methodGenerateApiModelParametersTypes);
            var result2 = this.GetResultOfMethod<HelpPageApiModel>(MethodGenerateApiModel, parametersOfGenerateApiModel, methodGenerateApiModelParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateApiModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateApiModel.ShouldNotBeNull();
            parametersOfGenerateApiModel.Length.ShouldBe(2);
            methodGenerateApiModelParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var apiDescription = this.CreateType<ApiDescription>();
            var config = this.CreateType<HttpConfiguration>();
            var methodGenerateApiModelParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration) };
            object[] parametersOfGenerateApiModel = { apiDescription, config };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HelpPageApiModel>(MethodGenerateApiModel, parametersOfGenerateApiModel, methodGenerateApiModelParametersTypes);

            // Assert
            parametersOfGenerateApiModel.ShouldNotBeNull();
            parametersOfGenerateApiModel.Length.ShouldBe(2);
            methodGenerateApiModelParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var methodGenerateApiModelParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateApiModel, methodGenerateApiModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateApiModelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var methodGenerateApiModelParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateApiModel, methodGenerateApiModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateApiModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateApiModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateApiModel) (Return Type : HelpPageApiModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateApiModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateApiModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateApiModel, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateUriParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateUriParameters, methodGenerateUriParametersParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateUriParameters);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var methodGenerateUriParametersParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };
            object[] parametersOfGenerateUriParameters = { apiModel, modelGenerator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateUriParameters, methodGenerateUriParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateUriParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateUriParameters.ShouldNotBeNull();
            parametersOfGenerateUriParameters.Length.ShouldBe(2);
            methodGenerateUriParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateUriParameters);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var methodGenerateUriParametersParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };
            object[] parametersOfGenerateUriParameters = { apiModel, modelGenerator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateUriParameters, parametersOfGenerateUriParameters, methodGenerateUriParametersParametersTypes);

            // Assert
            parametersOfGenerateUriParameters.ShouldNotBeNull();
            parametersOfGenerateUriParameters.Length.ShouldBe(2);
            methodGenerateUriParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateUriParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateUriParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateUriParameters);
            var methodGenerateUriParametersParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateUriParameters, methodGenerateUriParametersParametersTypes);

            // Assert
            methodGenerateUriParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateUriParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateUriParameters_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateUriParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateUriParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsBindableWithTypeConverterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var parameterType = this.CreateType<Type>();
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsBindableWithTypeConverter = { parameterType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsBindableWithTypeConverter, parametersOfIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsBindableWithTypeConverter.ShouldNotBeNull();
            parametersOfIsBindableWithTypeConverter.Length.ShouldBe(1);
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsBindableWithTypeConverter, parametersOfIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes));
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var parameterType = this.CreateType<Type>();
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsBindableWithTypeConverter = { parameterType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfIsBindableWithTypeConverter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsBindableWithTypeConverter.ShouldNotBeNull();
            parametersOfIsBindableWithTypeConverter.Length.ShouldBe(1);
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var parameterType = this.CreateType<Type>();
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsBindableWithTypeConverter = { parameterType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsBindableWithTypeConverter, parametersOfIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);

            // Assert
            parametersOfIsBindableWithTypeConverter.ShouldNotBeNull();
            parametersOfIsBindableWithTypeConverter.Length.ShouldBe(1);
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var methodIsBindableWithTypeConverterParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsBindableWithTypeConverter, methodIsBindableWithTypeConverterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsBindableWithTypeConverterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBindableWithTypeConverter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsBindableWithTypeConverter) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_IsBindableWithTypeConverter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBindableWithTypeConverter);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBindableWithTypeConverter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_Internally(Type[] types)
        {
            var methodAddParameterDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var apiParameter = this.CreateType<ApiParameterDescription>();
            var typeDescription = this.CreateType<ModelDescription>();
            var methodAddParameterDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ApiParameterDescription), typeof(ModelDescription) };
            object[] parametersOfAddParameterDescription = { apiModel, apiParameter, typeDescription };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes);
            var result2 = this.GetResultOfMethod<ParameterDescription>(MethodAddParameterDescription, parametersOfAddParameterDescription, methodAddParameterDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddParameterDescription.ShouldNotBeNull();
            parametersOfAddParameterDescription.Length.ShouldBe(3);
            methodAddParameterDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<ParameterDescription>(MethodAddParameterDescription, parametersOfAddParameterDescription, methodAddParameterDescriptionParametersTypes));
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var apiParameter = this.CreateType<ApiParameterDescription>();
            var typeDescription = this.CreateType<ModelDescription>();
            var methodAddParameterDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ApiParameterDescription), typeof(ModelDescription) };
            object[] parametersOfAddParameterDescription = { apiModel, apiParameter, typeDescription };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAddParameterDescription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddParameterDescription.ShouldNotBeNull();
            parametersOfAddParameterDescription.Length.ShouldBe(3);
            methodAddParameterDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var apiParameter = this.CreateType<ApiParameterDescription>();
            var typeDescription = this.CreateType<ModelDescription>();
            var methodAddParameterDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ApiParameterDescription), typeof(ModelDescription) };
            object[] parametersOfAddParameterDescription = { apiModel, apiParameter, typeDescription };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ParameterDescription>(MethodAddParameterDescription, parametersOfAddParameterDescription, methodAddParameterDescriptionParametersTypes);

            // Assert
            parametersOfAddParameterDescription.ShouldNotBeNull();
            parametersOfAddParameterDescription.Length.ShouldBe(3);
            methodAddParameterDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var methodAddParameterDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ApiParameterDescription), typeof(ModelDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddParameterDescriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var methodAddParameterDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ApiParameterDescription), typeof(ModelDescription) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddParameterDescription, methodAddParameterDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddParameterDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodAddParameterDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AddParameterDescription) (Return Type : ParameterDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_AddParameterDescription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddParameterDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodAddParameterDescription, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateRequestModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateRequestModelDescription, methodGenerateRequestModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRequestModelDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodGenerateRequestModelDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator), typeof(HelpPageSampleGenerator) };
            object[] parametersOfGenerateRequestModelDescription = { apiModel, modelGenerator, sampleGenerator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRequestModelDescription, methodGenerateRequestModelDescriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateRequestModelDescription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateRequestModelDescription.ShouldNotBeNull();
            parametersOfGenerateRequestModelDescription.Length.ShouldBe(3);
            methodGenerateRequestModelDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRequestModelDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodGenerateRequestModelDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator), typeof(HelpPageSampleGenerator) };
            object[] parametersOfGenerateRequestModelDescription = { apiModel, modelGenerator, sampleGenerator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateRequestModelDescription, parametersOfGenerateRequestModelDescription, methodGenerateRequestModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateRequestModelDescription.ShouldNotBeNull();
            parametersOfGenerateRequestModelDescription.Length.ShouldBe(3);
            methodGenerateRequestModelDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRequestModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRequestModelDescription, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRequestModelDescription);
            var methodGenerateRequestModelDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator), typeof(HelpPageSampleGenerator) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateRequestModelDescription, methodGenerateRequestModelDescriptionParametersTypes);

            // Assert
            methodGenerateRequestModelDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateRequestModelDescription) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateRequestModelDescription_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRequestModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRequestModelDescription, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateResourceDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateResourceDescription, methodGenerateResourceDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResourceDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var methodGenerateResourceDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };
            object[] parametersOfGenerateResourceDescription = { apiModel, modelGenerator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateResourceDescription, methodGenerateResourceDescriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateResourceDescription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateResourceDescription.ShouldNotBeNull();
            parametersOfGenerateResourceDescription.Length.ShouldBe(2);
            methodGenerateResourceDescriptionParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResourceDescription);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var modelGenerator = this.CreateType<ModelDescriptionGenerator>();
            var methodGenerateResourceDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };
            object[] parametersOfGenerateResourceDescription = { apiModel, modelGenerator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateResourceDescription, parametersOfGenerateResourceDescription, methodGenerateResourceDescriptionParametersTypes);

            // Assert
            parametersOfGenerateResourceDescription.ShouldNotBeNull();
            parametersOfGenerateResourceDescription.Length.ShouldBe(2);
            methodGenerateResourceDescriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResourceDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateResourceDescription, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResourceDescription);
            var methodGenerateResourceDescriptionParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(ModelDescriptionGenerator) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateResourceDescription, methodGenerateResourceDescriptionParametersTypes);

            // Assert
            methodGenerateResourceDescriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResourceDescription) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateResourceDescription_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResourceDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateResourceDescription, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateSamplesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateSamples, methodGenerateSamplesParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSamples);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodGenerateSamplesParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(HelpPageSampleGenerator) };
            object[] parametersOfGenerateSamples = { apiModel, sampleGenerator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSamples, methodGenerateSamplesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateSamples);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateSamples.ShouldNotBeNull();
            parametersOfGenerateSamples.Length.ShouldBe(2);
            methodGenerateSamplesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSamples);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var methodGenerateSamplesParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(HelpPageSampleGenerator) };
            object[] parametersOfGenerateSamples = { apiModel, sampleGenerator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateSamples, parametersOfGenerateSamples, methodGenerateSamplesParametersTypes);

            // Assert
            parametersOfGenerateSamples.ShouldNotBeNull();
            parametersOfGenerateSamples.Length.ShouldBe(2);
            methodGenerateSamplesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSamples);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSamples, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSamples);
            var methodGenerateSamplesParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(HelpPageSampleGenerator) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateSamples, methodGenerateSamplesParametersTypes);

            // Assert
            methodGenerateSamplesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateSamples) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_GenerateSamples_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSamples);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSamples, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Internally(Type[] types)
        {
            var methodTryGetResourceParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var apiDescription = this.CreateType<ApiDescription>();
            var config = this.CreateType<HttpConfiguration>();
            var parameterDescription = this.CreateType<ApiParameterDescription>();
            var resourceType = this.CreateType<Type>();
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };
            object[] parametersOfTryGetResourceParameter = { apiDescription, config, parameterDescription, resourceType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodTryGetResourceParameter, parametersOfTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryGetResourceParameter.ShouldNotBeNull();
            parametersOfTryGetResourceParameter.Length.ShouldBe(4);
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodTryGetResourceParameter, parametersOfTryGetResourceParameter, methodTryGetResourceParameterParametersTypes));
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var apiDescription = this.CreateType<ApiDescription>();
            var config = this.CreateType<HttpConfiguration>();
            var parameterDescription = this.CreateType<ApiParameterDescription>();
            var resourceType = this.CreateType<Type>();
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };
            object[] parametersOfTryGetResourceParameter = { apiDescription, config, parameterDescription, resourceType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfTryGetResourceParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryGetResourceParameter.ShouldNotBeNull();
            parametersOfTryGetResourceParameter.Length.ShouldBe(4);
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var apiDescription = this.CreateType<ApiDescription>();
            var config = this.CreateType<HttpConfiguration>();
            var parameterDescription = this.CreateType<ApiParameterDescription>();
            var resourceType = this.CreateType<Type>();
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };
            object[] parametersOfTryGetResourceParameter = { apiDescription, config, parameterDescription, resourceType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodTryGetResourceParameter, parametersOfTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);

            // Assert
            parametersOfTryGetResourceParameter.ShouldNotBeNull();
            parametersOfTryGetResourceParameter.Length.ShouldBe(4);
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var methodTryGetResourceParameterParametersTypes = new Type[] { typeof(ApiDescription), typeof(HttpConfiguration), typeof(ApiParameterDescription), typeof(Type) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryGetResourceParameter, methodTryGetResourceParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryGetResourceParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodTryGetResourceParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryGetResourceParameter) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_TryGetResourceParameter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryGetResourceParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodTryGetResourceParameter, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitializeModelDescriptionGeneratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodInitializeModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfInitializeModelDescriptionGenerator = { config };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);
            var result2 = this.GetResultOfMethod<ModelDescriptionGenerator>(MethodInitializeModelDescriptionGenerator, parametersOfInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitializeModelDescriptionGenerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInitializeModelDescriptionGenerator.ShouldNotBeNull();
            parametersOfInitializeModelDescriptionGenerator.Length.ShouldBe(1);
            methodInitializeModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var config = this.CreateType<HttpConfiguration>();
            var methodInitializeModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfInitializeModelDescriptionGenerator = { config };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDescriptionGenerator>(MethodInitializeModelDescriptionGenerator, parametersOfInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);

            // Assert
            parametersOfInitializeModelDescriptionGenerator.ShouldNotBeNull();
            parametersOfInitializeModelDescriptionGenerator.Length.ShouldBe(1);
            methodInitializeModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var methodInitializeModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInitializeModelDescriptionGeneratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var methodInitializeModelDescriptionGeneratorParametersTypes = new Type[] { typeof(HttpConfiguration) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeModelDescriptionGenerator, methodInitializeModelDescriptionGeneratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInitializeModelDescriptionGeneratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeModelDescriptionGenerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InitializeModelDescriptionGenerator) (Return Type : ModelDescriptionGenerator) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_InitializeModelDescriptionGenerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeModelDescriptionGenerator);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeModelDescriptionGenerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogInvalidSampleAsErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogInvalidSampleAsError, methodLogInvalidSampleAsErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInvalidSampleAsError);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var sample = this.CreateType<object>();
            var methodLogInvalidSampleAsErrorParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(object) };
            object[] parametersOfLogInvalidSampleAsError = { apiModel, sample };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogInvalidSampleAsError, methodLogInvalidSampleAsErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogInvalidSampleAsError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogInvalidSampleAsError.ShouldNotBeNull();
            parametersOfLogInvalidSampleAsError.Length.ShouldBe(2);
            methodLogInvalidSampleAsErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInvalidSampleAsError);
            var apiModel = this.CreateType<HelpPageApiModel>();
            var sample = this.CreateType<object>();
            var methodLogInvalidSampleAsErrorParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(object) };
            object[] parametersOfLogInvalidSampleAsError = { apiModel, sample };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogInvalidSampleAsError, parametersOfLogInvalidSampleAsError, methodLogInvalidSampleAsErrorParametersTypes);

            // Assert
            parametersOfLogInvalidSampleAsError.ShouldNotBeNull();
            parametersOfLogInvalidSampleAsError.Length.ShouldBe(2);
            methodLogInvalidSampleAsErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInvalidSampleAsError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInvalidSampleAsError, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInvalidSampleAsError);
            var methodLogInvalidSampleAsErrorParametersTypes = new Type[] { typeof(HelpPageApiModel), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogInvalidSampleAsError, methodLogInvalidSampleAsErrorParametersTypes);

            // Assert
            methodLogInvalidSampleAsErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInvalidSampleAsError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageConfigurationExtensions_LogInvalidSampleAsError_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInvalidSampleAsError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInvalidSampleAsError, 0);

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