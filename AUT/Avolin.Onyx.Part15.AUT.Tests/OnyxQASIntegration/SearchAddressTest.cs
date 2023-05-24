using System;
using System.Collections.Generic;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.SearchAddress" />)
    ///     and namespace <see cref="OnyxQASIntegration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SearchAddressTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SearchAddress" />)
        /// </summary>
        public SearchAddressTest() : base(typeof(SearchAddress))
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

        #region General Initializer : Class (SearchAddress) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _searchAddressInstanceType;
        private SearchAddress _searchAddressInstance;
        private SearchAddress _searchAddressInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SearchAddress" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _searchAddressInstanceType = typeof(SearchAddress);
            _searchAddressInstanceFixture = this.Create<SearchAddress>(false);
            _searchAddressInstance = _searchAddressInstanceFixture ?? this.Create<SearchAddress>(true);
            CurrentInstance = _searchAddressInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SearchAddress) Initializer

        #region Methods

        private const string MethodAddressValidation = "AddressValidation";
        private const string MethodValidate = "Validate";
        private const string MethodSendRequestReceiveResponseBody = "SendRequestReceiveResponseBody";
        private const string MethodGetEndpoint = "GetEndpoint";
        private const string MethodCreateResponseXml = "CreateResponseXml";
        private const string MethodGetRelativePath = "GetRelativePath";

        #endregion

        #region Fields

        private const string FieldBaseUrl = "BaseUrl";
        private const string Fieldcountry = "country";
        private const string FieldaddressId = "addressId";
        private const string Fieldselected = "selected";
        private const string FieldActionKey = "ActionKey";
        private const string FieldQueryKey = "QueryKey";
        private const string FieldCountryKey = "CountryKey";
        private const string FieldIdKey = "IdKey";
        private const string FieldAuthTokenKey = "AuthTokenKey";
        private const string FieldSearchAddressEndpoint = "SearchAddressEndpoint";
        private const string FieldVerifyAddressEndpoint = "VerifyAddressEndpoint";
        private const string FieldAddressLayoutEndpoint = "AddressLayoutEndpoint";
        private const string FieldSkipCertificateValidation = "SkipCertificateValidation";
        private const string FieldInternalServerErrorMessage = "InternalServerErrorMessage";

        #endregion

        #endregion

        #region General Initializer : Class (SearchAddress) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchAddress_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchAddress) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchAddress_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SearchAddress)

        #region General Initializer : Class (SearchAddress) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddressValidation, 0)]
        [TestCase(MethodValidate, 0)]
        [TestCase(MethodSendRequestReceiveResponseBody, 0)]
        [TestCase(MethodGetEndpoint, 0)]
        [TestCase(MethodCreateResponseXml, 0)]
        [TestCase(MethodGetRelativePath, 0)]
        public void AUT_SearchAddress_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SearchAddress) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldBaseUrl)]
        [TestCase(Fieldcountry)]
        [TestCase(FieldaddressId)]
        [TestCase(Fieldselected)]
        [TestCase(FieldActionKey)]
        [TestCase(FieldQueryKey)]
        [TestCase(FieldCountryKey)]
        [TestCase(FieldIdKey)]
        [TestCase(FieldAuthTokenKey)]
        [TestCase(FieldSearchAddressEndpoint)]
        [TestCase(FieldVerifyAddressEndpoint)]
        [TestCase(FieldAddressLayoutEndpoint)]
        [TestCase(FieldSkipCertificateValidation)]
        [TestCase(FieldInternalServerErrorMessage)]
        [Category("AUT Fields")]
        public void AUT_SearchAddress_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SearchAddress) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchAddress_Is_Instance_Present_Test()
        {
            // Assert
            _searchAddressInstanceType.ShouldNotBeNull();
            _searchAddressInstance.ShouldNotBeNull();
            _searchAddressInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SearchAddress) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SearchAddress" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchAddress_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _searchAddressInstance.ShouldBeAssignableTo<SearchAddress>();
            _searchAddressInstanceFixture.ShouldBeAssignableTo<SearchAddress>();
            CurrentInstance.ShouldBeAssignableTo<SearchAddress>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SearchAddress) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchAddress_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SearchAddress instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AddressValidation) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var parameterXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _searchAddressInstance.AddressValidation(parameterXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var parameterXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _searchAddressInstance.AddressValidation(parameterXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var parameterXml = this.CreateType<string>();
            var methodAddressValidationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfAddressValidation = { parameterXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddressValidation, methodAddressValidationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchAddressInstanceFixture, parametersOfAddressValidation);
            var result2 = this.GetResultOfMethod<string>(MethodAddressValidation, parametersOfAddressValidation, methodAddressValidationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddressValidation.ShouldNotBeNull();
            parametersOfAddressValidation.Length.ShouldBe(1);
            methodAddressValidationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var parameterXml = this.CreateType<string>();
            var methodAddressValidationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfAddressValidation = { parameterXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAddressValidation, parametersOfAddressValidation, methodAddressValidationParametersTypes);

            // Assert
            parametersOfAddressValidation.ShouldNotBeNull();
            parametersOfAddressValidation.Length.ShouldBe(1);
            methodAddressValidationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var methodAddressValidationParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddressValidation, methodAddressValidationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddressValidationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var methodAddressValidationParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddressValidation, methodAddressValidationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddressValidationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var currentMethodInfo = this.GetMethodInfo(MethodAddressValidation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddressValidation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_AddressValidation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddressValidation);
            var currentMethodInfo = this.GetMethodInfo(MethodAddressValidation, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchAddress_Validate_Method_Call_Internally(Type[] types)
        {
            var methodValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var action = this.CreateType<string>();
            var query = this.CreateType<string>();
            var country = this.CreateType<string>();
            var addressId = this.CreateType<string>();

            // Act
            Action executeAction = () => _searchAddressInstance.Validate(action, query, country, addressId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var action = this.CreateType<string>();
            var query = this.CreateType<string>();
            var country = this.CreateType<string>();
            var addressId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _searchAddressInstance.Validate(action, query, country, addressId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var action = this.CreateType<string>();
            var query = this.CreateType<string>();
            var country = this.CreateType<string>();
            var addressId = this.CreateType<string>();
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfValidate = { action, query, country, addressId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchAddressInstanceFixture, parametersOfValidate);
            var result2 = this.GetResultOfMethod<string>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(4);
            methodValidateParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var action = this.CreateType<string>();
            var query = this.CreateType<string>();
            var country = this.CreateType<string>();
            var addressId = this.CreateType<string>();
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfValidate = { action, query, country, addressId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(4);
            methodValidateParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_Validate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_Internally(Type[] types)
        {
            var methodSendRequestReceiveResponseBodyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes);
        }

        #endregion

        #region Method Call : (SendRequestReceiveResponseBody) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSendRequestReceiveResponseBody);
            var endpointUri = this.CreateType<Uri>();
            var methodSendRequestReceiveResponseBodyParametersTypes = new Type[] { typeof(Uri) };
            object[] parametersOfSendRequestReceiveResponseBody = { endpointUri };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSendRequestReceiveResponseBody, methodSendRequestReceiveResponseBodyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchAddressInstanceFixture, parametersOfSendRequestReceiveResponseBody);
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
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SearchAddress_SendRequestReceiveResponseBody_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_SearchAddress_GetEndpoint_Method_Call_Internally(Type[] types)
        {
            var methodGetEndpointParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEndpoint, methodGetEndpointParametersTypes);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetEndpoint_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var path = this.CreateType<string>();
            var queryParameters = this.CreateType<Dictionary<string, string>>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>) };
            object[] parametersOfGetEndpoint = { baseUrl, path, queryParameters };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, methodGetEndpointParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Uri>(_searchAddressInstanceFixture, out exception1, parametersOfGetEndpoint);
            var result2 = this.GetResultOfMethod<Uri>(MethodGetEndpoint, parametersOfGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(3);
            methodGetEndpointParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetEndpoint_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var path = this.CreateType<string>();
            var queryParameters = this.CreateType<Dictionary<string, string>>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>) };
            object[] parametersOfGetEndpoint = { baseUrl, path, queryParameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, methodGetEndpointParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_searchAddressInstanceFixture, parametersOfGetEndpoint);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(3);
            methodGetEndpointParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetEndpoint_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var baseUrl = this.CreateType<string>();
            var path = this.CreateType<string>();
            var queryParameters = this.CreateType<Dictionary<string, string>>();
            var methodGetEndpointParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>) };
            object[] parametersOfGetEndpoint = { baseUrl, path, queryParameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Uri>(MethodGetEndpoint, parametersOfGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            parametersOfGetEndpoint.ShouldNotBeNull();
            parametersOfGetEndpoint.Length.ShouldBe(3);
            methodGetEndpointParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var methodGetEndpointParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEndpoint, methodGetEndpointParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEndpointParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetEndpoint) (Return Type : Uri) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var methodGetEndpointParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>) };
            const int parametersCount = 3;

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
        public void AUT_SearchAddress_GetEndpoint_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_SearchAddress_GetEndpoint_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpoint);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpoint, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchAddress_CreateResponseXml_Method_Call_Internally(Type[] types)
        {
            var methodCreateResponseXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var query = this.CreateType<string>();

            // Act
            Action executeAction = () => _searchAddressInstance.CreateResponseXml(qasResponseXml, query);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var query = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _searchAddressInstance.CreateResponseXml(qasResponseXml, query);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var query = this.CreateType<string>();
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfCreateResponseXml = { qasResponseXml, query };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchAddressInstanceFixture, parametersOfCreateResponseXml);
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
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var qasResponseXml = this.CreateType<XmlDocument>();
            var query = this.CreateType<string>();
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfCreateResponseXml = { qasResponseXml, query };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateResponseXml, parametersOfCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            parametersOfCreateResponseXml.ShouldNotBeNull();
            parametersOfCreateResponseXml.Length.ShouldBe(2);
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var methodCreateResponseXmlParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateResponseXml, methodCreateResponseXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateResponseXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (CreateResponseXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResponseXml);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResponseXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateResponseXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_CreateResponseXml_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetRelativePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SearchAddress_GetRelativePath_Method_Call_Internally(Type[] types)
        {
            var methodGetRelativePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SearchAddress_GetRelativePath_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_searchAddressInstanceFixture, out exception1, parametersOfGetRelativePath);
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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_searchAddressInstanceFixture, parametersOfGetRelativePath);

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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_SearchAddress_GetRelativePath_Method_Call_Parameters_Count_Verification_Test()
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