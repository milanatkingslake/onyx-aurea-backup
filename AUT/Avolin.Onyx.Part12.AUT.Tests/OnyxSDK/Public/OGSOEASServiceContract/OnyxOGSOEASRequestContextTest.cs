using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Web;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OGSOEASServiceContract;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OGSOEASServiceContract
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASServiceContract.OnyxOGSOEASRequestContext" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASServiceContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOGSOEASRequestContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOGSOEASRequestContext" />)
        /// </summary>
        public OnyxOGSOEASRequestContextTest() : base(typeof(OnyxOGSOEASRequestContext))
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

        #region General Initializer : Class (OnyxOGSOEASRequestContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOGSOEASRequestContextInstanceType;
        private OnyxOGSOEASRequestContext _onyxOGSOEASRequestContextInstance;
        private OnyxOGSOEASRequestContext _onyxOGSOEASRequestContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOGSOEASRequestContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOGSOEASRequestContextInstanceType = typeof(OnyxOGSOEASRequestContext);
            _onyxOGSOEASRequestContextInstanceFixture = this.Create<OnyxOGSOEASRequestContext>(false);
            _onyxOGSOEASRequestContextInstance = _onyxOGSOEASRequestContextInstanceFixture ?? this.Create<OnyxOGSOEASRequestContext>(true);
            CurrentInstance = _onyxOGSOEASRequestContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASRequestContext) Initializer

        #region Properties

        private const string PropertyRequestContentType = "RequestContentType";
        private const string PropertyResponseContentType = "ResponseContentType";

        #endregion

        #region Methods

        private const string MethodGetContentType = "GetContentType";
        private const string MethodGetRequestContentType = "GetRequestContentType";
        private const string MethodGetResponseContentType = "GetResponseContentType";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOGSOEASRequestContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASRequestContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASRequestContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASRequestContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASRequestContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASRequestContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOGSOEASRequestContext)

        #region General Initializer : Class (OnyxOGSOEASRequestContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetContentType, 0)]
        [TestCase(MethodGetRequestContentType, 0)]
        [TestCase(MethodGetResponseContentType, 0)]
        public void AUT_OnyxOGSOEASRequestContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOGSOEASRequestContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRequestContentType)]
        [TestCase(PropertyResponseContentType)]
        [Category("AUT Property")]
        public void AUT_OnyxOGSOEASRequestContext_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOGSOEASRequestContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASRequestContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOGSOEASRequestContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOGSOEASRequestContextInstance.ShouldBeAssignableTo<OnyxOGSOEASRequestContext>();
            _onyxOGSOEASRequestContextInstanceFixture.ShouldBeAssignableTo<OnyxOGSOEASRequestContext>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOGSOEASRequestContext>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOGSOEASRequestContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRequestContentType)]
        [TestCase(PropertyResponseContentType)]
        public void AUT_OnyxOGSOEASRequestContext_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOGSOEASRequestContext) => Property (RequestContentType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOGSOEASRequestContext_Public_Class_RequestContentType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestContentType);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestContentType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOGSOEASRequestContext) => Property (ResponseContentType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOGSOEASRequestContext_Public_Class_ResponseContentType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseContentType);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseContentType);

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

        #region Method Call : (GetContentType) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var contentType = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASRequestContextInstance.GetContentType(contentType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var contentType = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASRequestContextInstance.GetContentType(contentType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var contentType = this.CreateType<string>();
            var methodGetContentTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContentType = { contentType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentType, methodGetContentTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASRequestContextInstanceFixture, parametersOfGetContentType);
            var result2 = this.GetResultOfMethod<string>(MethodGetContentType, parametersOfGetContentType, methodGetContentTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContentType.ShouldNotBeNull();
            parametersOfGetContentType.Length.ShouldBe(1);
            methodGetContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var contentType = this.CreateType<string>();
            var methodGetContentTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContentType = { contentType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContentType, parametersOfGetContentType, methodGetContentTypeParametersTypes);

            // Assert
            parametersOfGetContentType.ShouldNotBeNull();
            parametersOfGetContentType.Length.ShouldBe(1);
            methodGetContentTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var methodGetContentTypeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContentType, methodGetContentTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var methodGetContentTypeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContentType, methodGetContentTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContentTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContentType) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetContentType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_Internally(Type[] types)
        {
            var methodGetRequestContentTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequestContentType, methodGetRequestContentTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();

            // Act
            Action executeAction = () => _onyxOGSOEASRequestContextInstance.GetRequestContentType(webOperationContext);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASRequestContextInstance.GetRequestContentType(webOperationContext);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var methodGetRequestContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            object[] parametersOfGetRequestContentType = { webOperationContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestContentType, methodGetRequestContentTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASRequestContextInstanceFixture, parametersOfGetRequestContentType);
            var result2 = this.GetResultOfMethod<string>(MethodGetRequestContentType, parametersOfGetRequestContentType, methodGetRequestContentTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequestContentType.ShouldNotBeNull();
            parametersOfGetRequestContentType.Length.ShouldBe(1);
            methodGetRequestContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var methodGetRequestContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            object[] parametersOfGetRequestContentType = { webOperationContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRequestContentType, parametersOfGetRequestContentType, methodGetRequestContentTypeParametersTypes);

            // Assert
            parametersOfGetRequestContentType.ShouldNotBeNull();
            parametersOfGetRequestContentType.Length.ShouldBe(1);
            methodGetRequestContentTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var methodGetRequestContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequestContentType, methodGetRequestContentTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequestContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var methodGetRequestContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestContentType, methodGetRequestContentTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequestContentTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestContentType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestContentType) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetRequestContentType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestContentType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseContentTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseContentType, methodGetResponseContentTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();

            // Act
            Action executeAction = () => _onyxOGSOEASRequestContextInstance.GetResponseContentType(webOperationContext);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASRequestContextInstance.GetResponseContentType(webOperationContext);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var methodGetResponseContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            object[] parametersOfGetResponseContentType = { webOperationContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseContentType, methodGetResponseContentTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASRequestContextInstanceFixture, parametersOfGetResponseContentType);
            var result2 = this.GetResultOfMethod<string>(MethodGetResponseContentType, parametersOfGetResponseContentType, methodGetResponseContentTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseContentType.ShouldNotBeNull();
            parametersOfGetResponseContentType.Length.ShouldBe(1);
            methodGetResponseContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var webOperationContext = this.CreateType<WebOperationContext>();
            var methodGetResponseContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            object[] parametersOfGetResponseContentType = { webOperationContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResponseContentType, parametersOfGetResponseContentType, methodGetResponseContentTypeParametersTypes);

            // Assert
            parametersOfGetResponseContentType.ShouldNotBeNull();
            parametersOfGetResponseContentType.Length.ShouldBe(1);
            methodGetResponseContentTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var methodGetResponseContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseContentType, methodGetResponseContentTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseContentTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var methodGetResponseContentTypeParametersTypes = new Type[] { typeof(WebOperationContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseContentType, methodGetResponseContentTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseContentTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseContentType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseContentType) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASRequestContext_GetResponseContentType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseContentType, 0);
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