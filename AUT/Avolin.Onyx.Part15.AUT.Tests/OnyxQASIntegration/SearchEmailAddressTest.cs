using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.SearchEmailAddress" />)
    ///     and namespace <see cref="OnyxQASIntegration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SearchEmailAddressTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SearchEmailAddress" />)
        /// </summary>
        public SearchEmailAddressTest() : base(typeof(SearchEmailAddress))
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

        #region General Initializer : Class (SearchEmailAddress) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _searchEmailAddressInstanceType;
        private SearchEmailAddress _searchEmailAddressInstance;
        private SearchEmailAddress _searchEmailAddressInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SearchEmailAddress" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _searchEmailAddressInstanceType = typeof(SearchEmailAddress);
            _searchEmailAddressInstanceFixture = this.Create<SearchEmailAddress>(false);
            _searchEmailAddressInstance = _searchEmailAddressInstanceFixture ?? this.Create<SearchEmailAddress>(true);
            CurrentInstance = _searchEmailAddressInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SearchEmailAddress) Initializer

        #region Properties

        private const string PropertyIsReusable = "IsReusable";

        #endregion

        #region Methods

        private const string MethodEmailValidation = "EmailValidation";
        private const string MethodCreateRequestBody = "CreateRequestBody";
        private const string MethodValidateEmail = "ValidateEmail";
        private const string MethodCreateResponseXml = "CreateResponseXml";
        private const string MethodSendRequestReceiveResponseBody = "SendRequestReceiveResponseBody";
        private const string MethodGetEndpoint = "GetEndpoint";
        private const string MethodGetRelativePath = "GetRelativePath";

        #endregion

        #region Fields

        private const string FieldAuthToken = "AuthToken";
        private const string FieldEmailUri = "EmailUri";
        private const string FieldDefaultTimeout = "DefaultTimeout";
        private const string Fieldemail = "email";
        private const string Fieldversion = "version";
        private const string Fieldtimeout = "timeout";
        private const string FieldAuthTokenKey = "AuthTokenKey";
        private const string FieldEmailKey = "EmailKey";
        private const string FieldTimeoutKey = "TimeoutKey";
        private const string FieldVersionKey = "VersionKey";
        private const string FieldVerboseKey = "VerboseKey";
        private const string FieldSkipCertificateValidation = "SkipCertificateValidation";

        #endregion

        #endregion

        #region General Initializer : Class (SearchEmailAddress) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchEmailAddress_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchEmailAddress) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchEmailAddress_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchEmailAddress) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchEmailAddress_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SearchEmailAddress)

        #region General Initializer : Class (SearchEmailAddress) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEmailValidation, 0)]
        [TestCase(MethodCreateRequestBody, 0)]
        [TestCase(MethodValidateEmail, 0)]
        [TestCase(MethodCreateResponseXml, 0)]
        [TestCase(MethodSendRequestReceiveResponseBody, 0)]
        [TestCase(MethodGetEndpoint, 0)]
        [TestCase(MethodGetRelativePath, 0)]
        public void AUT_SearchEmailAddress_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SearchEmailAddress) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsReusable)]
        [Category("AUT Property")]
        public void AUT_SearchEmailAddress_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SearchEmailAddress) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldAuthToken)]
        [TestCase(FieldEmailUri)]
        [TestCase(FieldDefaultTimeout)]
        [TestCase(Fieldemail)]
        [TestCase(Fieldversion)]
        [TestCase(Fieldtimeout)]
        [TestCase(FieldAuthTokenKey)]
        [TestCase(FieldEmailKey)]
        [TestCase(FieldTimeoutKey)]
        [TestCase(FieldVersionKey)]
        [TestCase(FieldVerboseKey)]
        [TestCase(FieldSkipCertificateValidation)]
        [Category("AUT Fields")]
        public void AUT_SearchEmailAddress_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SearchEmailAddress) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchEmailAddress_Is_Instance_Present_Test()
        {
            // Assert
            _searchEmailAddressInstanceType.ShouldNotBeNull();
            _searchEmailAddressInstance.ShouldNotBeNull();
            _searchEmailAddressInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SearchEmailAddress) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SearchEmailAddress" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchEmailAddress_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _searchEmailAddressInstance.ShouldBeAssignableTo<SearchEmailAddress>();
            _searchEmailAddressInstanceFixture.ShouldBeAssignableTo<SearchEmailAddress>();
            CurrentInstance.ShouldBeAssignableTo<SearchEmailAddress>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SearchEmailAddress) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchEmailAddress_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SearchEmailAddress instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SearchEmailAddress) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsReusable)]
        public void AUT_SearchEmailAddress_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SearchEmailAddress) => Property (IsReusable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchEmailAddress_Public_Class_IsReusable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsReusable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsReusable);

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

        #region Method Call : (EmailValidation) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var parameterXml = this.CreateType<string>();
            var languageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => _searchEmailAddressInstance.EmailValidation(parameterXml, languageCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var parameterXml = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _searchEmailAddressInstance.EmailValidation(parameterXml, languageCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var parameterXml = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodEmailValidationParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEmailValidation = { parameterXml, languageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEmailValidation, methodEmailValidationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchEmailAddressInstanceFixture, parametersOfEmailValidation);
            var result2 = this.GetResultOfMethod<string>(MethodEmailValidation, parametersOfEmailValidation, methodEmailValidationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEmailValidation.ShouldNotBeNull();
            parametersOfEmailValidation.Length.ShouldBe(2);
            methodEmailValidationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var parameterXml = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodEmailValidationParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEmailValidation = { parameterXml, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEmailValidation, parametersOfEmailValidation, methodEmailValidationParametersTypes);

            // Assert
            parametersOfEmailValidation.ShouldNotBeNull();
            parametersOfEmailValidation.Length.ShouldBe(2);
            methodEmailValidationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var methodEmailValidationParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEmailValidation, methodEmailValidationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEmailValidationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var methodEmailValidationParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEmailValidation, methodEmailValidationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEmailValidationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var currentMethodInfo = this.GetMethodInfo(MethodEmailValidation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EmailValidation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_EmailValidation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEmailValidation);
            var currentMethodInfo = this.GetMethodInfo(MethodEmailValidation, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateRequestBodyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[])  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var email = this.CreateType<string>();
            var timeout = this.CreateType<string>();
            var methodCreateRequestBodyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCreateRequestBody = { email, timeout };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes);
            var result2 = this.GetResultOfMethod<byte[]>(MethodCreateRequestBody, parametersOfCreateRequestBody, methodCreateRequestBodyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateRequestBody.ShouldNotBeNull();
            parametersOfCreateRequestBody.Length.ShouldBe(2);
            methodCreateRequestBodyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<byte[]>(MethodCreateRequestBody, parametersOfCreateRequestBody, methodCreateRequestBodyParametersTypes));
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var email = this.CreateType<string>();
            var timeout = this.CreateType<string>();
            var methodCreateRequestBodyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCreateRequestBody = { email, timeout };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_searchEmailAddressInstanceFixture, parametersOfCreateRequestBody);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRequestBody.ShouldNotBeNull();
            parametersOfCreateRequestBody.Length.ShouldBe(2);
            methodCreateRequestBodyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var email = this.CreateType<string>();
            var timeout = this.CreateType<string>();
            var methodCreateRequestBodyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCreateRequestBody = { email, timeout };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodCreateRequestBody, parametersOfCreateRequestBody, methodCreateRequestBodyParametersTypes);

            // Assert
            parametersOfCreateRequestBody.ShouldNotBeNull();
            parametersOfCreateRequestBody.Length.ShouldBe(2);
            methodCreateRequestBodyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var methodCreateRequestBodyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateRequestBodyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var methodCreateRequestBodyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRequestBody, methodCreateRequestBodyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRequestBodyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequestBody, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRequestBody) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateRequestBody_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequestBody);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequestBody, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_ValidateEmail_Method_Call_Internally(Type[] types)
        {
            var methodValidateEmailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateEmail, methodValidateEmailParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var email = this.CreateType<string>();
            var timeout = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodValidateEmailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfValidateEmail = { email, timeout, languageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEmail, methodValidateEmailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchEmailAddressInstanceFixture, parametersOfValidateEmail);
            var result2 = this.GetResultOfMethod<string>(MethodValidateEmail, parametersOfValidateEmail, methodValidateEmailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidateEmail.ShouldNotBeNull();
            parametersOfValidateEmail.Length.ShouldBe(3);
            methodValidateEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var email = this.CreateType<string>();
            var timeout = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodValidateEmailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfValidateEmail = { email, timeout, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodValidateEmail, parametersOfValidateEmail, methodValidateEmailParametersTypes);

            // Assert
            parametersOfValidateEmail.ShouldNotBeNull();
            parametersOfValidateEmail.Length.ShouldBe(3);
            methodValidateEmailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var methodValidateEmailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateEmail, methodValidateEmailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var methodValidateEmailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateEmail, methodValidateEmailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateEmailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEmail, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateEmail) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_ValidateEmail_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEmail, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_Internally(Type[] types)
        {
            var methodCreateResponseXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var languageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => _searchEmailAddressInstance.CreateResponseXml(qasResponseXml, languageCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var languageCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _searchEmailAddressInstance.CreateResponseXml(qasResponseXml, languageCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var languageCode = this.CreateType<string>();
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfCreateResponseXml = { qasResponseXml, languageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchEmailAddressInstanceFixture, parametersOfCreateResponseXml);
            var result2 = this.GetResultOfMethod<string>(MethodCreateResponseXml, parametersOfCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateResponseXml.ShouldNotBeNull();
            parametersOfCreateResponseXml.Length.ShouldBe(2);
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var languageCode = this.CreateType<string>();
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfCreateResponseXml = { qasResponseXml, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateResponseXml, parametersOfCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            parametersOfCreateResponseXml.ShouldNotBeNull();
            parametersOfCreateResponseXml.Length.ShouldBe(2);
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResponseXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_CreateResponseXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResponseXml, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_Internally(Type[] types)
        {
            var methodSendRequestReceiveResponseBodyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var endpointUri = this.CreateType<Uri>();
            var methodSendRequestReceiveResponseBodyParametersTypes = new Type[] { typeof(Uri) };
            object[] parametersOfSendRequestReceiveResponseBody = { endpointUri };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchEmailAddressInstanceFixture, parametersOfSendRequestReceiveResponseBody);
            var result2 = this.GetResultOfMethod<string>(MethodSendRequestReceiveResponseBody, parametersOfSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSendRequestReceiveResponseBody.ShouldNotBeNull();
            parametersOfSendRequestReceiveResponseBody.Length.ShouldBe(1);
            methodSendRequestReceiveResponseBodyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var endpointUri = this.CreateType<Uri>();
            var methodSendRequestReceiveResponseBodyParametersTypes = new Type[] { typeof(Uri) };
            object[] parametersOfSendRequestReceiveResponseBody = { endpointUri };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSendRequestReceiveResponseBody, parametersOfSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);

            // Assert
            parametersOfSendRequestReceiveResponseBody.ShouldNotBeNull();
            parametersOfSendRequestReceiveResponseBody.Length.ShouldBe(1);
            methodSendRequestReceiveResponseBodyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var methodSendRequestReceiveResponseBodyParametersTypes = new Type[] { typeof(Uri) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSendRequestReceiveResponseBodyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var methodSendRequestReceiveResponseBodyParametersTypes = new Type[] { typeof(Uri) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSendRequestReceiveResponseBodyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var currentMethodInfo = this.GetMethodInfo(MethodSendRequestReceiveResponseBody, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_SendRequestReceiveResponseBody_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var currentMethodInfo = this.GetMethodInfo(MethodSendRequestReceiveResponseBody, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_GetEndpoint_Method_Call_Internally(Type[] types)
        {
            var methodGetEndpointParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEndpoint, methodGetEndpointParametersTypes);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpoint = { baseUrl };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, methodGetEndpointParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Uri>(_searchEmailAddressInstanceFixture, out exception1, parametersOfGetEndpoint);
            var result2 = this.GetResultOfMethod<Uri>(MethodGetEndpoint, parametersOfGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(1);
            methodGetEndpointParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpoint = { baseUrl };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, methodGetEndpointParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_searchEmailAddressInstanceFixture, parametersOfGetEndpoint);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(1);
            methodGetEndpointParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpoint = { baseUrl };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Uri>(MethodGetEndpoint, parametersOfGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(1);
            methodGetEndpointParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var methodGetEndpointParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEndpointParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var methodGetEndpointParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEndpointParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetEndpoint_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchEmailAddress_GetRelativePath_Method_Call_Internally(Type[] types)
        {
            var methodGetRelativePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchEmailAddressInstanceFixture, out exception1, parametersOfGetRelativePath);
            var result2 = this.GetResultOfMethod<string>(MethodGetRelativePath, parametersOfGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_searchEmailAddressInstanceFixture, parametersOfGetRelativePath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRelativePath, parametersOfGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRelativePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchEmailAddress_GetRelativePath_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, 0);
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