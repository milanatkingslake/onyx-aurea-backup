using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http.Description;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.HelpPageSampleGenerator" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpPageSampleGeneratorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpPageSampleGenerator" />)
        /// </summary>
        public HelpPageSampleGeneratorTest() : base(typeof(HelpPageSampleGenerator))
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

        #region General Initializer : Class (HelpPageSampleGenerator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpPageSampleGeneratorInstanceType;
        private HelpPageSampleGenerator _helpPageSampleGeneratorInstance;
        private HelpPageSampleGenerator _helpPageSampleGeneratorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelpPageSampleGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpPageSampleGeneratorInstanceType = typeof(HelpPageSampleGenerator);
            _helpPageSampleGeneratorInstanceFixture = this.Create<HelpPageSampleGenerator>(false);
            _helpPageSampleGeneratorInstance = _helpPageSampleGeneratorInstanceFixture ?? this.Create<HelpPageSampleGenerator>(true);
            CurrentInstance = _helpPageSampleGeneratorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleGenerator) Initializer

        #region Properties

        private const string PropertyActualHttpMessageTypes = "ActualHttpMessageTypes";
        private const string PropertyActionSamples = "ActionSamples";
        private const string PropertySampleObjects = "SampleObjects";
        private const string PropertySampleObjectFactories = "SampleObjectFactories";

        #endregion

        #region Methods

        private const string MethodGetSampleRequests = "GetSampleRequests";
        private const string MethodGetSampleResponses = "GetSampleResponses";
        private const string MethodGetSample = "GetSample";
        private const string MethodGetActionSample = "GetActionSample";
        private const string MethodGetSampleObject = "GetSampleObject";
        private const string MethodResolveHttpRequestMessageType = "ResolveHttpRequestMessageType";
        private const string MethodResolveType = "ResolveType";
        private const string MethodWriteSampleObjectUsingFormatter = "WriteSampleObjectUsingFormatter";
        private const string MethodUnwrapException = "UnwrapException";
        private const string MethodDefaultSampleObjectFactory = "DefaultSampleObjectFactory";
        private const string MethodTryFormatJson = "TryFormatJson";
        private const string MethodTryFormatXml = "TryFormatXml";
        private const string MethodIsFormatSupported = "IsFormatSupported";
        private const string MethodGetAllActionSamples = "GetAllActionSamples";
        private const string MethodWrapSampleIfString = "WrapSampleIfString";

        #endregion

        #endregion

        #region General Initializer : Class (HelpPageSampleGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleGenerator) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleGenerator_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpPageSampleGenerator)

        #region General Initializer : Class (HelpPageSampleGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodGetSampleRequests, 0)]
        [TestCase(MethodGetSampleResponses, 0)]
        [TestCase(MethodGetSample, 0)]
        [TestCase(MethodGetActionSample, 0)]
        [TestCase(MethodGetSampleObject, 0)]
        [TestCase(MethodResolveHttpRequestMessageType, 0)]
        [TestCase(MethodResolveType, 0)]
        [TestCase(MethodWriteSampleObjectUsingFormatter, 0)]
        [TestCase(MethodUnwrapException, 0)]
        [TestCase(MethodDefaultSampleObjectFactory, 0)]
        [TestCase(MethodTryFormatJson, 0)]
        [TestCase(MethodTryFormatXml, 0)]
        [TestCase(MethodIsFormatSupported, 0)]
        [TestCase(MethodGetAllActionSamples, 0)]
        [TestCase(MethodWrapSampleIfString, 0)]
        public void AUT_HelpPageSampleGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpPageSampleGenerator) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyActualHttpMessageTypes)]
        [TestCase(PropertyActionSamples)]
        [TestCase(PropertySampleObjects)]
        [TestCase(PropertySampleObjectFactories)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_HelpPageSampleGenerator_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelpPageSampleGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_HelpPageSampleGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _helpPageSampleGeneratorInstanceType.ShouldNotBeNull();
            _helpPageSampleGeneratorInstance.ShouldNotBeNull();
            _helpPageSampleGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HelpPageSampleGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelpPageSampleGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_HelpPageSampleGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helpPageSampleGeneratorInstance.ShouldBeAssignableTo<HelpPageSampleGenerator>();
            _helpPageSampleGeneratorInstanceFixture.ShouldBeAssignableTo<HelpPageSampleGenerator>();
            CurrentInstance.ShouldBeAssignableTo<HelpPageSampleGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HelpPageSampleGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HelpPageSampleGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleGenerator) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleGenerator_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var helpPageSampleGeneratorInstance  = new HelpPageSampleGenerator();

            // Asserts
            helpPageSampleGeneratorInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelpPageSampleGenerator) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyActualHttpMessageTypes)]
        [TestCase(PropertyActionSamples)]
        [TestCase(PropertySampleObjects)]
        [TestCase(PropertySampleObjectFactories)]
        public void AUT_HelpPageSampleGenerator_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelpPageSampleGenerator) => Property (ActionSamples) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleGenerator_Public_Class_ActionSamples_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionSamples);
            var propertyInfo = this.GetPropertyInfo(PropertyActionSamples);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleGenerator) => Property (ActualHttpMessageTypes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleGenerator_Public_Class_ActualHttpMessageTypes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActualHttpMessageTypes);
            var propertyInfo = this.GetPropertyInfo(PropertyActualHttpMessageTypes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleGenerator) => Property (SampleObjectFactories) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleGenerator_Public_Class_SampleObjectFactories_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleObjectFactories);
            var propertyInfo = this.GetPropertyInfo(PropertySampleObjectFactories);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleGenerator) => Property (SampleObjects) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleGenerator_Public_Class_SampleObjects_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleObjects);
            var propertyInfo = this.GetPropertyInfo(PropertySampleObjects);

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

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var api = this.CreateType<ApiDescription>();

            // Act
            Action executeAction = () => _helpPageSampleGeneratorInstance.GetSampleRequests(api);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var api = this.CreateType<ApiDescription>();
            var returnedValue = default(IDictionary<MediaTypeHeaderValue, object>);

            // Act
            Action executeAction = () => returnedValue = _helpPageSampleGeneratorInstance.GetSampleRequests(api);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var api = this.CreateType<ApiDescription>();
            var methodGetSampleRequestsParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetSampleRequests = { api };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleRequests, methodGetSampleRequestsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<MediaTypeHeaderValue, object>>(_helpPageSampleGeneratorInstanceFixture, parametersOfGetSampleRequests);
            var result2 = this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSampleRequests, parametersOfGetSampleRequests, methodGetSampleRequestsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSampleRequests.ShouldNotBeNull();
            parametersOfGetSampleRequests.Length.ShouldBe(1);
            methodGetSampleRequestsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var api = this.CreateType<ApiDescription>();
            var methodGetSampleRequestsParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetSampleRequests = { api };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSampleRequests, parametersOfGetSampleRequests, methodGetSampleRequestsParametersTypes);

            // Assert
            parametersOfGetSampleRequests.ShouldNotBeNull();
            parametersOfGetSampleRequests.Length.ShouldBe(1);
            methodGetSampleRequestsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var methodGetSampleRequestsParametersTypes = new Type[] { typeof(ApiDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSampleRequests, methodGetSampleRequestsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSampleRequestsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var methodGetSampleRequestsParametersTypes = new Type[] { typeof(ApiDescription) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSampleRequests, methodGetSampleRequestsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSampleRequestsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleRequests, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleRequests) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleRequests_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleRequests);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleRequests, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_Internally(Type[] types)
        {
            var methodGetSampleResponsesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSampleResponses, methodGetSampleResponsesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var api = this.CreateType<ApiDescription>();

            // Act
            Action executeAction = () => _helpPageSampleGeneratorInstance.GetSampleResponses(api);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var api = this.CreateType<ApiDescription>();
            var returnedValue = default(IDictionary<MediaTypeHeaderValue, object>);

            // Act
            Action executeAction = () => returnedValue = _helpPageSampleGeneratorInstance.GetSampleResponses(api);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var api = this.CreateType<ApiDescription>();
            var methodGetSampleResponsesParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetSampleResponses = { api };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleResponses, methodGetSampleResponsesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<MediaTypeHeaderValue, object>>(_helpPageSampleGeneratorInstanceFixture, parametersOfGetSampleResponses);
            var result2 = this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSampleResponses, parametersOfGetSampleResponses, methodGetSampleResponsesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSampleResponses.ShouldNotBeNull();
            parametersOfGetSampleResponses.Length.ShouldBe(1);
            methodGetSampleResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var api = this.CreateType<ApiDescription>();
            var methodGetSampleResponsesParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetSampleResponses = { api };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSampleResponses, parametersOfGetSampleResponses, methodGetSampleResponsesParametersTypes);

            // Assert
            parametersOfGetSampleResponses.ShouldNotBeNull();
            parametersOfGetSampleResponses.Length.ShouldBe(1);
            methodGetSampleResponsesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var methodGetSampleResponsesParametersTypes = new Type[] { typeof(ApiDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSampleResponses, methodGetSampleResponsesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSampleResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var methodGetSampleResponsesParametersTypes = new Type[] { typeof(ApiDescription) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSampleResponses, methodGetSampleResponsesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSampleResponsesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleResponses, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleResponses) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleResponses_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleResponses, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_GetSample_Method_Call_Internally(Type[] types)
        {
            var methodGetSampleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSample, methodGetSampleParametersTypes);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var api = this.CreateType<ApiDescription>();
            var sampleDirection = this.CreateType<SampleDirection>();

            // Act
            Action executeAction = () => _helpPageSampleGeneratorInstance.GetSample(api, sampleDirection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var api = this.CreateType<ApiDescription>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var returnedValue = default(IDictionary<MediaTypeHeaderValue, object>);

            // Act
            Action executeAction = () => returnedValue = _helpPageSampleGeneratorInstance.GetSample(api, sampleDirection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var api = this.CreateType<ApiDescription>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetSampleParametersTypes = new Type[] { typeof(ApiDescription), typeof(SampleDirection) };
            object[] parametersOfGetSample = { api, sampleDirection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSample, methodGetSampleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<MediaTypeHeaderValue, object>>(_helpPageSampleGeneratorInstanceFixture, parametersOfGetSample);
            var result2 = this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSample, parametersOfGetSample, methodGetSampleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSample.ShouldNotBeNull();
            parametersOfGetSample.Length.ShouldBe(2);
            methodGetSampleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var api = this.CreateType<ApiDescription>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetSampleParametersTypes = new Type[] { typeof(ApiDescription), typeof(SampleDirection) };
            object[] parametersOfGetSample = { api, sampleDirection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<MediaTypeHeaderValue, object>>(MethodGetSample, parametersOfGetSample, methodGetSampleParametersTypes);

            // Assert
            parametersOfGetSample.ShouldNotBeNull();
            parametersOfGetSample.Length.ShouldBe(2);
            methodGetSampleParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var methodGetSampleParametersTypes = new Type[] { typeof(ApiDescription), typeof(SampleDirection) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSample, methodGetSampleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSampleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var methodGetSampleParametersTypes = new Type[] { typeof(ApiDescription), typeof(SampleDirection) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSample, methodGetSampleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSampleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSample, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSample) (Return Type : IDictionary<MediaTypeHeaderValue, object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSample_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSample);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSample, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_Internally(Type[] types)
        {
            var methodGetActionSampleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActionSample, methodGetActionSampleParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetActionSample) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var type = this.CreateType<Type>();
            var formatter = this.CreateType<MediaTypeFormatter>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetActionSampleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(Type), typeof(MediaTypeFormatter), typeof(MediaTypeHeaderValue), typeof(SampleDirection) };
            object[] parametersOfGetActionSample = { controllerName, actionName, parameterNames, type, formatter, mediaType, sampleDirection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActionSample, methodGetActionSampleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_helpPageSampleGeneratorInstanceFixture, parametersOfGetActionSample);
            var result2 = this.GetResultOfMethod<object>(MethodGetActionSample, parametersOfGetActionSample, methodGetActionSampleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActionSample.ShouldNotBeNull();
            parametersOfGetActionSample.Length.ShouldBe(7);
            methodGetActionSampleParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var type = this.CreateType<Type>();
            var formatter = this.CreateType<MediaTypeFormatter>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetActionSampleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(Type), typeof(MediaTypeFormatter), typeof(MediaTypeHeaderValue), typeof(SampleDirection) };
            object[] parametersOfGetActionSample = { controllerName, actionName, parameterNames, type, formatter, mediaType, sampleDirection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetActionSample, parametersOfGetActionSample, methodGetActionSampleParametersTypes);

            // Assert
            parametersOfGetActionSample.ShouldNotBeNull();
            parametersOfGetActionSample.Length.ShouldBe(7);
            methodGetActionSampleParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var methodGetActionSampleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(Type), typeof(MediaTypeFormatter), typeof(MediaTypeHeaderValue), typeof(SampleDirection) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActionSample, methodGetActionSampleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActionSampleParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var methodGetActionSampleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(Type), typeof(MediaTypeFormatter), typeof(MediaTypeHeaderValue), typeof(SampleDirection) };
            const int parametersCount = 7;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActionSample, methodGetActionSampleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActionSampleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActionSample, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActionSample) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetActionSample_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActionSample);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActionSample, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_Internally(Type[] types)
        {
            var methodGetSampleObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSampleObject, methodGetSampleObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _helpPageSampleGeneratorInstance.GetSampleObject(type);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var type = this.CreateType<Type>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _helpPageSampleGeneratorInstance.GetSampleObject(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var type = this.CreateType<Type>();
            var methodGetSampleObjectParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetSampleObject = { type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleObject, methodGetSampleObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_helpPageSampleGeneratorInstanceFixture, parametersOfGetSampleObject);
            var result2 = this.GetResultOfMethod<object>(MethodGetSampleObject, parametersOfGetSampleObject, methodGetSampleObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSampleObject.ShouldNotBeNull();
            parametersOfGetSampleObject.Length.ShouldBe(1);
            methodGetSampleObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var type = this.CreateType<Type>();
            var methodGetSampleObjectParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetSampleObject = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetSampleObject, parametersOfGetSampleObject, methodGetSampleObjectParametersTypes);

            // Assert
            parametersOfGetSampleObject.ShouldNotBeNull();
            parametersOfGetSampleObject.Length.ShouldBe(1);
            methodGetSampleObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var methodGetSampleObjectParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSampleObject, methodGetSampleObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSampleObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var methodGetSampleObjectParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSampleObject, methodGetSampleObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSampleObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSampleObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetSampleObject_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSampleObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSampleObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_Internally(Type[] types)
        {
            var methodResolveHttpRequestMessageTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var api = this.CreateType<ApiDescription>();

            // Act
            Action executeAction = () => _helpPageSampleGeneratorInstance.ResolveHttpRequestMessageType(api);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var api = this.CreateType<ApiDescription>();
            var returnedValue = default(Type);

            // Act
            Action executeAction = () => returnedValue = _helpPageSampleGeneratorInstance.ResolveHttpRequestMessageType(api);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var api = this.CreateType<ApiDescription>();
            var methodResolveHttpRequestMessageTypeParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfResolveHttpRequestMessageType = { api };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Type>(_helpPageSampleGeneratorInstanceFixture, parametersOfResolveHttpRequestMessageType);
            var result2 = this.GetResultOfMethod<Type>(MethodResolveHttpRequestMessageType, parametersOfResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveHttpRequestMessageType.ShouldNotBeNull();
            parametersOfResolveHttpRequestMessageType.Length.ShouldBe(1);
            methodResolveHttpRequestMessageTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var api = this.CreateType<ApiDescription>();
            var methodResolveHttpRequestMessageTypeParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfResolveHttpRequestMessageType = { api };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodResolveHttpRequestMessageType, parametersOfResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes);

            // Assert
            parametersOfResolveHttpRequestMessageType.ShouldNotBeNull();
            parametersOfResolveHttpRequestMessageType.Length.ShouldBe(1);
            methodResolveHttpRequestMessageTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var methodResolveHttpRequestMessageTypeParametersTypes = new Type[] { typeof(ApiDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveHttpRequestMessageTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var methodResolveHttpRequestMessageTypeParametersTypes = new Type[] { typeof(ApiDescription) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveHttpRequestMessageType, methodResolveHttpRequestMessageTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveHttpRequestMessageTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveHttpRequestMessageType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveHttpRequestMessageType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveHttpRequestMessageType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveHttpRequestMessageType);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveHttpRequestMessageType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_Internally(Type[] types)
        {
            var methodResolveTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveType, methodResolveTypeParametersTypes);
        }

        #endregion
        
        #region Method Call : (ResolveType) (Return Type : Type) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var api = this.CreateType<ApiDescription>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var formatters = this.CreateType<Collection<MediaTypeFormatter>>();
            var methodResolveTypeParametersTypes = new Type[] { typeof(ApiDescription), typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection), typeof(Collection<MediaTypeFormatter>) };
            object[] parametersOfResolveType = { api, controllerName, actionName, parameterNames, sampleDirection, formatters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveType, methodResolveTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Type>(_helpPageSampleGeneratorInstanceFixture, parametersOfResolveType);
            var result2 = this.GetResultOfMethod<Type>(MethodResolveType, parametersOfResolveType, methodResolveTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveType.ShouldNotBeNull();
            parametersOfResolveType.Length.ShouldBe(6);
            methodResolveTypeParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var api = this.CreateType<ApiDescription>();
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var formatters = this.CreateType<Collection<MediaTypeFormatter>>();
            var methodResolveTypeParametersTypes = new Type[] { typeof(ApiDescription), typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection), typeof(Collection<MediaTypeFormatter>) };
            object[] parametersOfResolveType = { api, controllerName, actionName, parameterNames, sampleDirection, formatters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodResolveType, parametersOfResolveType, methodResolveTypeParametersTypes);

            // Assert
            parametersOfResolveType.ShouldNotBeNull();
            parametersOfResolveType.Length.ShouldBe(6);
            methodResolveTypeParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var methodResolveTypeParametersTypes = new Type[] { typeof(ApiDescription), typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection), typeof(Collection<MediaTypeFormatter>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveType, methodResolveTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveTypeParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var methodResolveTypeParametersTypes = new Type[] { typeof(ApiDescription), typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection), typeof(Collection<MediaTypeFormatter>) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveType, methodResolveTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_ResolveType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveType);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveType, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_Internally(Type[] types)
        {
            var methodWriteSampleObjectUsingFormatterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var formatter = this.CreateType<MediaTypeFormatter>();
            var value = this.CreateType<object>();
            var type = this.CreateType<Type>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var methodWriteSampleObjectUsingFormatterParametersTypes = new Type[] { typeof(MediaTypeFormatter), typeof(object), typeof(Type), typeof(MediaTypeHeaderValue) };
            object[] parametersOfWriteSampleObjectUsingFormatter = { formatter, value, type, mediaType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_helpPageSampleGeneratorInstanceFixture, out exception1, parametersOfWriteSampleObjectUsingFormatter);
            var result2 = this.GetResultOfMethod<object>(MethodWriteSampleObjectUsingFormatter, parametersOfWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWriteSampleObjectUsingFormatter.ShouldNotBeNull();
            parametersOfWriteSampleObjectUsingFormatter.Length.ShouldBe(4);
            methodWriteSampleObjectUsingFormatterParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var formatter = this.CreateType<MediaTypeFormatter>();
            var value = this.CreateType<object>();
            var type = this.CreateType<Type>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var methodWriteSampleObjectUsingFormatterParametersTypes = new Type[] { typeof(MediaTypeFormatter), typeof(object), typeof(Type), typeof(MediaTypeHeaderValue) };
            object[] parametersOfWriteSampleObjectUsingFormatter = { formatter, value, type, mediaType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfWriteSampleObjectUsingFormatter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWriteSampleObjectUsingFormatter.ShouldNotBeNull();
            parametersOfWriteSampleObjectUsingFormatter.Length.ShouldBe(4);
            methodWriteSampleObjectUsingFormatterParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var formatter = this.CreateType<MediaTypeFormatter>();
            var value = this.CreateType<object>();
            var type = this.CreateType<Type>();
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            var methodWriteSampleObjectUsingFormatterParametersTypes = new Type[] { typeof(MediaTypeFormatter), typeof(object), typeof(Type), typeof(MediaTypeHeaderValue) };
            object[] parametersOfWriteSampleObjectUsingFormatter = { formatter, value, type, mediaType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodWriteSampleObjectUsingFormatter, parametersOfWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes);

            // Assert
            parametersOfWriteSampleObjectUsingFormatter.ShouldNotBeNull();
            parametersOfWriteSampleObjectUsingFormatter.Length.ShouldBe(4);
            methodWriteSampleObjectUsingFormatterParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var methodWriteSampleObjectUsingFormatterParametersTypes = new Type[] { typeof(MediaTypeFormatter), typeof(object), typeof(Type), typeof(MediaTypeHeaderValue) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodWriteSampleObjectUsingFormatterParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var methodWriteSampleObjectUsingFormatterParametersTypes = new Type[] { typeof(MediaTypeFormatter), typeof(object), typeof(Type), typeof(MediaTypeHeaderValue) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteSampleObjectUsingFormatter, methodWriteSampleObjectUsingFormatterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWriteSampleObjectUsingFormatterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteSampleObjectUsingFormatter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WriteSampleObjectUsingFormatter) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WriteSampleObjectUsingFormatter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteSampleObjectUsingFormatter);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteSampleObjectUsingFormatter, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_Internally(Type[] types)
        {
            var methodUnwrapExceptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUnwrapException, methodUnwrapExceptionParametersTypes);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var parameterException = this.CreateType<Exception>();
            var methodUnwrapExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfUnwrapException = { parameterException };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUnwrapException, methodUnwrapExceptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodUnwrapException, methodUnwrapExceptionParametersTypes);
            var result2 = this.GetResultOfMethod<Exception>(MethodUnwrapException, parametersOfUnwrapException, methodUnwrapExceptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUnwrapException.ShouldNotBeNull();
            parametersOfUnwrapException.Length.ShouldBe(1);
            methodUnwrapExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Exception>(MethodUnwrapException, parametersOfUnwrapException, methodUnwrapExceptionParametersTypes));
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var parameterException = this.CreateType<Exception>();
            var methodUnwrapExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfUnwrapException = { parameterException };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUnwrapException, methodUnwrapExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfUnwrapException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUnwrapException.ShouldNotBeNull();
            parametersOfUnwrapException.Length.ShouldBe(1);
            methodUnwrapExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var parameterException = this.CreateType<Exception>();
            var methodUnwrapExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfUnwrapException = { parameterException };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Exception>(MethodUnwrapException, parametersOfUnwrapException, methodUnwrapExceptionParametersTypes);

            // Assert
            parametersOfUnwrapException.ShouldNotBeNull();
            parametersOfUnwrapException.Length.ShouldBe(1);
            methodUnwrapExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var methodUnwrapExceptionParametersTypes = new Type[] { typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUnwrapException, methodUnwrapExceptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodUnwrapExceptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var methodUnwrapExceptionParametersTypes = new Type[] { typeof(Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUnwrapException, methodUnwrapExceptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUnwrapExceptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var currentMethodInfo = this.GetMethodInfo(MethodUnwrapException, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (UnwrapException) (Return Type : Exception) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_UnwrapException_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnwrapException);
            var currentMethodInfo = this.GetMethodInfo(MethodUnwrapException, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_Internally(Type[] types)
        {
            var methodDefaultSampleObjectFactoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var type = this.CreateType<Type>();
            var methodDefaultSampleObjectFactoryParametersTypes = new Type[] { typeof(HelpPageSampleGenerator), typeof(Type) };
            object[] parametersOfDefaultSampleObjectFactory = { sampleGenerator, type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodDefaultSampleObjectFactory, parametersOfDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDefaultSampleObjectFactory.ShouldNotBeNull();
            parametersOfDefaultSampleObjectFactory.Length.ShouldBe(2);
            methodDefaultSampleObjectFactoryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<object>(MethodDefaultSampleObjectFactory, parametersOfDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes));
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var type = this.CreateType<Type>();
            var methodDefaultSampleObjectFactoryParametersTypes = new Type[] { typeof(HelpPageSampleGenerator), typeof(Type) };
            object[] parametersOfDefaultSampleObjectFactory = { sampleGenerator, type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfDefaultSampleObjectFactory);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDefaultSampleObjectFactory.ShouldNotBeNull();
            parametersOfDefaultSampleObjectFactory.Length.ShouldBe(2);
            methodDefaultSampleObjectFactoryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var sampleGenerator = this.CreateType<HelpPageSampleGenerator>();
            var type = this.CreateType<Type>();
            var methodDefaultSampleObjectFactoryParametersTypes = new Type[] { typeof(HelpPageSampleGenerator), typeof(Type) };
            object[] parametersOfDefaultSampleObjectFactory = { sampleGenerator, type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodDefaultSampleObjectFactory, parametersOfDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);

            // Assert
            parametersOfDefaultSampleObjectFactory.ShouldNotBeNull();
            parametersOfDefaultSampleObjectFactory.Length.ShouldBe(2);
            methodDefaultSampleObjectFactoryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var methodDefaultSampleObjectFactoryParametersTypes = new Type[] { typeof(HelpPageSampleGenerator), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDefaultSampleObjectFactoryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var methodDefaultSampleObjectFactoryParametersTypes = new Type[] { typeof(HelpPageSampleGenerator), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDefaultSampleObjectFactory, methodDefaultSampleObjectFactoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDefaultSampleObjectFactoryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var currentMethodInfo = this.GetMethodInfo(MethodDefaultSampleObjectFactory, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DefaultSampleObjectFactory) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_DefaultSampleObjectFactory_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDefaultSampleObjectFactory);
            var currentMethodInfo = this.GetMethodInfo(MethodDefaultSampleObjectFactory, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_Internally(Type[] types)
        {
            var methodTryFormatJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryFormatJson, methodTryFormatJsonParametersTypes);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var str = this.CreateType<string>();
            var methodTryFormatJsonParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatJson = { str };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatJson, methodTryFormatJsonParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodTryFormatJson, methodTryFormatJsonParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodTryFormatJson, parametersOfTryFormatJson, methodTryFormatJsonParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryFormatJson.ShouldNotBeNull();
            parametersOfTryFormatJson.Length.ShouldBe(1);
            methodTryFormatJsonParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodTryFormatJson, parametersOfTryFormatJson, methodTryFormatJsonParametersTypes));
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var str = this.CreateType<string>();
            var methodTryFormatJsonParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatJson = { str };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatJson, methodTryFormatJsonParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfTryFormatJson);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryFormatJson.ShouldNotBeNull();
            parametersOfTryFormatJson.Length.ShouldBe(1);
            methodTryFormatJsonParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var str = this.CreateType<string>();
            var methodTryFormatJsonParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatJson = { str };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodTryFormatJson, parametersOfTryFormatJson, methodTryFormatJsonParametersTypes);

            // Assert
            parametersOfTryFormatJson.ShouldNotBeNull();
            parametersOfTryFormatJson.Length.ShouldBe(1);
            methodTryFormatJsonParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var methodTryFormatJsonParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryFormatJson, methodTryFormatJsonParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryFormatJsonParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var methodTryFormatJsonParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryFormatJson, methodTryFormatJsonParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryFormatJsonParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatJson, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryFormatJson) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatJson_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatJson);
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatJson, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodTryFormatXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTryFormatXml, methodTryFormatXmlParametersTypes);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var str = this.CreateType<string>();
            var methodTryFormatXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatXml = { str };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatXml, methodTryFormatXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodTryFormatXml, methodTryFormatXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodTryFormatXml, parametersOfTryFormatXml, methodTryFormatXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfTryFormatXml.ShouldNotBeNull();
            parametersOfTryFormatXml.Length.ShouldBe(1);
            methodTryFormatXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodTryFormatXml, parametersOfTryFormatXml, methodTryFormatXmlParametersTypes));
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var str = this.CreateType<string>();
            var methodTryFormatXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatXml = { str };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatXml, methodTryFormatXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfTryFormatXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTryFormatXml.ShouldNotBeNull();
            parametersOfTryFormatXml.Length.ShouldBe(1);
            methodTryFormatXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var str = this.CreateType<string>();
            var methodTryFormatXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfTryFormatXml = { str };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodTryFormatXml, parametersOfTryFormatXml, methodTryFormatXmlParametersTypes);

            // Assert
            parametersOfTryFormatXml.ShouldNotBeNull();
            parametersOfTryFormatXml.Length.ShouldBe(1);
            methodTryFormatXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var methodTryFormatXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTryFormatXml, methodTryFormatXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTryFormatXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var methodTryFormatXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTryFormatXml, methodTryFormatXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTryFormatXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (TryFormatXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_TryFormatXml_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTryFormatXml);
            var currentMethodInfo = this.GetMethodInfo(MethodTryFormatXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsFormatSupportedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var sampleDirection = this.CreateType<SampleDirection>();
            var formatter = this.CreateType<MediaTypeFormatter>();
            var type = this.CreateType<Type>();
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };
            object[] parametersOfIsFormatSupported = { sampleDirection, formatter, type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsFormatSupported, parametersOfIsFormatSupported, methodIsFormatSupportedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsFormatSupported.ShouldNotBeNull();
            parametersOfIsFormatSupported.Length.ShouldBe(3);
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsFormatSupported, parametersOfIsFormatSupported, methodIsFormatSupportedParametersTypes));
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var sampleDirection = this.CreateType<SampleDirection>();
            var formatter = this.CreateType<MediaTypeFormatter>();
            var type = this.CreateType<Type>();
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };
            object[] parametersOfIsFormatSupported = { sampleDirection, formatter, type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfIsFormatSupported);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsFormatSupported.ShouldNotBeNull();
            parametersOfIsFormatSupported.Length.ShouldBe(3);
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var sampleDirection = this.CreateType<SampleDirection>();
            var formatter = this.CreateType<MediaTypeFormatter>();
            var type = this.CreateType<Type>();
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };
            object[] parametersOfIsFormatSupported = { sampleDirection, formatter, type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsFormatSupported, parametersOfIsFormatSupported, methodIsFormatSupportedParametersTypes);

            // Assert
            parametersOfIsFormatSupported.ShouldNotBeNull();
            parametersOfIsFormatSupported.Length.ShouldBe(3);
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var methodIsFormatSupportedParametersTypes = new Type[] { typeof(SampleDirection), typeof(MediaTypeFormatter), typeof(Type) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsFormatSupported, methodIsFormatSupportedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsFormatSupportedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var currentMethodInfo = this.GetMethodInfo(MethodIsFormatSupported, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsFormatSupported) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_IsFormatSupported_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsFormatSupported);
            var currentMethodInfo = this.GetMethodInfo(MethodIsFormatSupported, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_Internally(Type[] types)
        {
            var methodGetAllActionSamplesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllActionSamples, methodGetAllActionSamplesParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetAllActionSamplesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection) };
            object[] parametersOfGetAllActionSamples = { controllerName, actionName, parameterNames, sampleDirection };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllActionSamples, methodGetAllActionSamplesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IEnumerable<KeyValuePair<HelpPageSampleKey, object>>>(_helpPageSampleGeneratorInstanceFixture, out exception1, parametersOfGetAllActionSamples);
            var result2 = this.GetResultOfMethod<IEnumerable<KeyValuePair<HelpPageSampleKey, object>>>(MethodGetAllActionSamples, parametersOfGetAllActionSamples, methodGetAllActionSamplesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetAllActionSamples.ShouldNotBeNull();
            parametersOfGetAllActionSamples.Length.ShouldBe(4);
            methodGetAllActionSamplesParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetAllActionSamplesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection) };
            object[] parametersOfGetAllActionSamples = { controllerName, actionName, parameterNames, sampleDirection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllActionSamples, methodGetAllActionSamplesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfGetAllActionSamples);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAllActionSamples.ShouldNotBeNull();
            parametersOfGetAllActionSamples.Length.ShouldBe(4);
            methodGetAllActionSamplesParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var controllerName = this.CreateType<string>();
            var actionName = this.CreateType<string>();
            var parameterNames = this.CreateType<IEnumerable<string>>();
            var sampleDirection = this.CreateType<SampleDirection>();
            var methodGetAllActionSamplesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection) };
            object[] parametersOfGetAllActionSamples = { controllerName, actionName, parameterNames, sampleDirection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<KeyValuePair<HelpPageSampleKey, object>>>(MethodGetAllActionSamples, parametersOfGetAllActionSamples, methodGetAllActionSamplesParametersTypes);

            // Assert
            parametersOfGetAllActionSamples.ShouldNotBeNull();
            parametersOfGetAllActionSamples.Length.ShouldBe(4);
            methodGetAllActionSamplesParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var methodGetAllActionSamplesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllActionSamples, methodGetAllActionSamplesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetAllActionSamplesParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var methodGetAllActionSamplesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(IEnumerable<string>), typeof(SampleDirection) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllActionSamples, methodGetAllActionSamplesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllActionSamplesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllActionSamples, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetAllActionSamples) (Return Type : IEnumerable<KeyValuePair<HelpPageSampleKey, object>>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_GetAllActionSamples_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllActionSamples);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllActionSamples, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_Internally(Type[] types)
        {
            var methodWrapSampleIfStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var sample = this.CreateType<object>();
            var methodWrapSampleIfStringParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfWrapSampleIfString = { sample };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodWrapSampleIfString, parametersOfWrapSampleIfString, methodWrapSampleIfStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWrapSampleIfString.ShouldNotBeNull();
            parametersOfWrapSampleIfString.Length.ShouldBe(1);
            methodWrapSampleIfStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<object>(MethodWrapSampleIfString, parametersOfWrapSampleIfString, methodWrapSampleIfStringParametersTypes));
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var sample = this.CreateType<object>();
            var methodWrapSampleIfStringParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfWrapSampleIfString = { sample };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleGeneratorInstanceFixture, parametersOfWrapSampleIfString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWrapSampleIfString.ShouldNotBeNull();
            parametersOfWrapSampleIfString.Length.ShouldBe(1);
            methodWrapSampleIfStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var sample = this.CreateType<object>();
            var methodWrapSampleIfStringParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfWrapSampleIfString = { sample };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodWrapSampleIfString, parametersOfWrapSampleIfString, methodWrapSampleIfStringParametersTypes);

            // Assert
            parametersOfWrapSampleIfString.ShouldNotBeNull();
            parametersOfWrapSampleIfString.Length.ShouldBe(1);
            methodWrapSampleIfStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var methodWrapSampleIfStringParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodWrapSampleIfStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var methodWrapSampleIfStringParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWrapSampleIfString, methodWrapSampleIfStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWrapSampleIfStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var currentMethodInfo = this.GetMethodInfo(MethodWrapSampleIfString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (WrapSampleIfString) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleGenerator_WrapSampleIfString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrapSampleIfString);
            var currentMethodInfo = this.GetMethodInfo(MethodWrapSampleIfString, 0);
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