using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.WebServiceCall" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WebServiceCallTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WebServiceCall" />)
        /// </summary>
        public WebServiceCallTest() : base(typeof(WebServiceCall))
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

        #region General Initializer : Class (WebServiceCall) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _webServiceCallInstanceType;
        private WebServiceCall _webServiceCallInstance;
        private WebServiceCall _webServiceCallInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="WebServiceCall" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _webServiceCallInstanceType = typeof(WebServiceCall);
            _webServiceCallInstanceFixture = this.Create<WebServiceCall>(false);
            _webServiceCallInstance = _webServiceCallInstanceFixture ?? this.Create<WebServiceCall>(true);
            CurrentInstance = _webServiceCallInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WebServiceCall) Initializer

        #region Properties

        private const string PropertywsdlUrl = "wsdlUrl";
        private const string PropertyrequestUrl = "requestUrl";
        private const string PropertyserviceName = "serviceName";
        private const string PropertybindingName = "bindingName";
        private const string PropertymethodName = "methodName";
        private const string PropertyserviceDescription = "serviceDescription";
        private const string PropertyrequestDoc = "requestDoc";
        private const string PropertyresponseDoc = "responseDoc";
        private const string PropertyrequestHeaderNode = "requestHeaderNode";
        private const string PropertyrequestBodyNode = "requestBodyNode";
        private const string PropertyresponseBodyNode = "responseBodyNode";

        #endregion

        #region Methods

        private const string MethodProcess = "Process";
        private const string MethodLoadServiceDescription = "LoadServiceDescription";
        private const string MethodGetSoapRequestPackage = "GetSoapRequestPackage";
        private const string MethodGetSoapAction = "GetSoapAction";
        private const string MethodGetRequestUrl = "GetRequestUrl";
        private const string MethodExecuteMethod = "ExecuteMethod";
        private const string MethodRemoteCertificateValidationCallback = "RemoteCertificateValidationCallback";

        #endregion

        #region Fields

        private const string Fieldm_wsdlUrl = "m_wsdlUrl";
        private const string Fieldm_requestUrl = "m_requestUrl";
        private const string Fieldm_serviceName = "m_serviceName";
        private const string Fieldm_bindingName = "m_bindingName";
        private const string Fieldm_methodName = "m_methodName";
        private const string Fieldm_svcDescription = "m_svcDescription";
        private const string Fieldm_requestDoc = "m_requestDoc";
        private const string Fieldm_responseDoc = "m_responseDoc";
        private const string Fieldm_requestHeaderNode = "m_requestHeaderNode";
        private const string Fieldm_requestBodyNode = "m_requestBodyNode";
        private const string Fieldm_responseBodyNode = "m_responseBodyNode";

        #endregion

        #endregion

        #region General Initializer : Class (WebServiceCall) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WebServiceCall_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WebServiceCall) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WebServiceCall_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WebServiceCall) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WebServiceCall_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WebServiceCall)

        #region General Initializer : Class (WebServiceCall) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcess, 0)]
        [TestCase(MethodLoadServiceDescription, 0)]
        [TestCase(MethodGetSoapRequestPackage, 0)]
        [TestCase(MethodGetSoapAction, 0)]
        [TestCase(MethodGetRequestUrl, 0)]
        [TestCase(MethodExecuteMethod, 0)]
        [TestCase(MethodRemoteCertificateValidationCallback, 0)]
        public void AUT_WebServiceCall_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (WebServiceCall) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertywsdlUrl)]
        [TestCase(PropertyrequestUrl)]
        [TestCase(PropertyserviceName)]
        [TestCase(PropertybindingName)]
        [TestCase(PropertymethodName)]
        [TestCase(PropertyserviceDescription)]
        [TestCase(PropertyrequestDoc)]
        [TestCase(PropertyresponseDoc)]
        [TestCase(PropertyrequestHeaderNode)]
        [TestCase(PropertyrequestBodyNode)]
        [TestCase(PropertyresponseBodyNode)]
        [Category("AUT Property")]
        public void AUT_WebServiceCall_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (WebServiceCall) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_wsdlUrl)]
        [TestCase(Fieldm_requestUrl)]
        [TestCase(Fieldm_serviceName)]
        [TestCase(Fieldm_bindingName)]
        [TestCase(Fieldm_methodName)]
        [TestCase(Fieldm_svcDescription)]
        [TestCase(Fieldm_requestDoc)]
        [TestCase(Fieldm_responseDoc)]
        [TestCase(Fieldm_requestHeaderNode)]
        [TestCase(Fieldm_requestBodyNode)]
        [TestCase(Fieldm_responseBodyNode)]
        [Category("AUT Fields")]
        public void AUT_WebServiceCall_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (WebServiceCall) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WebServiceCall_Is_Instance_Present_Test()
        {
            // Assert
            _webServiceCallInstanceType.ShouldNotBeNull();
            _webServiceCallInstance.ShouldNotBeNull();
            _webServiceCallInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (WebServiceCall) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="WebServiceCall" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WebServiceCall_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _webServiceCallInstance.ShouldBeAssignableTo<WebServiceCall>();
            _webServiceCallInstanceFixture.ShouldBeAssignableTo<WebServiceCall>();
            CurrentInstance.ShouldBeAssignableTo<WebServiceCall>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (WebServiceCall) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_WebServiceCall_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            WebServiceCall instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (WebServiceCall) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertywsdlUrl)]
        [TestCase(PropertyrequestUrl)]
        [TestCase(PropertyserviceName)]
        [TestCase(PropertybindingName)]
        [TestCase(PropertymethodName)]
        [TestCase(PropertyserviceDescription)]
        [TestCase(PropertyrequestDoc)]
        [TestCase(PropertyresponseDoc)]
        [TestCase(PropertyrequestHeaderNode)]
        [TestCase(PropertyrequestBodyNode)]
        [TestCase(PropertyresponseBodyNode)]
        public void AUT_WebServiceCall_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (WebServiceCall) => Property (bindingName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_bindingName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertybindingName);
            var propertyInfo = this.GetPropertyInfo(PropertybindingName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (methodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_methodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymethodName);
            var propertyInfo = this.GetPropertyInfo(PropertymethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestBodyNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_requestBodyNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestBodyNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyrequestBodyNode);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestBodyNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_requestBodyNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestBodyNode);
            var propertyInfo = this.GetPropertyInfo(PropertyrequestBodyNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestDoc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_requestDoc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestDoc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyrequestDoc);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestDoc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_requestDoc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestDoc);
            var propertyInfo = this.GetPropertyInfo(PropertyrequestDoc);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestHeaderNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_requestHeaderNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestHeaderNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyrequestHeaderNode);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestHeaderNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_requestHeaderNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestHeaderNode);
            var propertyInfo = this.GetPropertyInfo(PropertyrequestHeaderNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (requestUrl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_requestUrl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyrequestUrl);
            var propertyInfo = this.GetPropertyInfo(PropertyrequestUrl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (responseBodyNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_responseBodyNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresponseBodyNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyresponseBodyNode);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (responseBodyNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_responseBodyNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresponseBodyNode);
            var propertyInfo = this.GetPropertyInfo(PropertyresponseBodyNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (responseDoc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_responseDoc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresponseDoc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyresponseDoc);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (responseDoc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_responseDoc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresponseDoc);
            var propertyInfo = this.GetPropertyInfo(PropertyresponseDoc);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (serviceDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_serviceDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyserviceDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyserviceDescription);
            Action currentAction = () => propertyInfo.SetValue(_webServiceCallInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (serviceDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_serviceDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyserviceDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyserviceDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (serviceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_serviceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyserviceName);
            var propertyInfo = this.GetPropertyInfo(PropertyserviceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WebServiceCall) => Property (wsdlUrl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_WebServiceCall_Public_Class_wsdlUrl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertywsdlUrl);
            var propertyInfo = this.GetPropertyInfo(PropertywsdlUrl);

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

        #region Method Call : (Process) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _webServiceCallInstance.Process(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfProcess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcess, parametersOfProcess, methodProcessParametersTypes);

            // Assert
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);

            // Assert
            methodProcessParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_Process_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadServiceDescription) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_LoadServiceDescription_Method_Call_Internally(Type[] types)
        {
            var methodLoadServiceDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadServiceDescription, methodLoadServiceDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (LoadServiceDescription) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_LoadServiceDescription_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadServiceDescription);
            Type [] methodLoadServiceDescriptionParametersTypes = null;
            object[] parametersOfLoadServiceDescription = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadServiceDescription, methodLoadServiceDescriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfLoadServiceDescription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadServiceDescription.ShouldBeNull();
            methodLoadServiceDescriptionParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LoadServiceDescription) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_LoadServiceDescription_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadServiceDescription);
            Type [] methodLoadServiceDescriptionParametersTypes = null;
            object[] parametersOfLoadServiceDescription = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadServiceDescription, parametersOfLoadServiceDescription, methodLoadServiceDescriptionParametersTypes);

            // Assert
            parametersOfLoadServiceDescription.ShouldBeNull();
            methodLoadServiceDescriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadServiceDescription) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_LoadServiceDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadServiceDescription);
            Type [] methodLoadServiceDescriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadServiceDescription, methodLoadServiceDescriptionParametersTypes);

            // Assert
            methodLoadServiceDescriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadServiceDescription) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_LoadServiceDescription_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadServiceDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadServiceDescription, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapRequestPackage) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_GetSoapRequestPackage_Method_Call_Internally(Type[] types)
        {
            var methodGetSoapRequestPackageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSoapRequestPackage, methodGetSoapRequestPackageParametersTypes);
        }

        #endregion

        #region Method Call : (GetSoapRequestPackage) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapRequestPackage_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapRequestPackage);
            Type [] methodGetSoapRequestPackageParametersTypes = null;
            object[] parametersOfGetSoapRequestPackage = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSoapRequestPackage, methodGetSoapRequestPackageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfGetSoapRequestPackage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSoapRequestPackage.ShouldBeNull();
            methodGetSoapRequestPackageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapRequestPackage) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapRequestPackage_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapRequestPackage);
            Type [] methodGetSoapRequestPackageParametersTypes = null;
            object[] parametersOfGetSoapRequestPackage = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetSoapRequestPackage, parametersOfGetSoapRequestPackage, methodGetSoapRequestPackageParametersTypes);

            // Assert
            parametersOfGetSoapRequestPackage.ShouldBeNull();
            methodGetSoapRequestPackageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapRequestPackage) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapRequestPackage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapRequestPackage);
            Type [] methodGetSoapRequestPackageParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSoapRequestPackage, methodGetSoapRequestPackageParametersTypes);

            // Assert
            methodGetSoapRequestPackageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapRequestPackage) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapRequestPackage_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapRequestPackage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSoapRequestPackage, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_GetSoapAction_Method_Call_Internally(Type[] types)
        {
            var methodGetSoapActionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSoapAction, methodGetSoapActionParametersTypes);
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapAction_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapAction);
            Type [] methodGetSoapActionParametersTypes = null;
            object[] parametersOfGetSoapAction = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSoapAction, methodGetSoapActionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_webServiceCallInstanceFixture, parametersOfGetSoapAction);
            var result2 = this.GetResultOfMethod<string>(MethodGetSoapAction, parametersOfGetSoapAction, methodGetSoapActionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSoapAction.ShouldBeNull();
            methodGetSoapActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapAction_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapAction);
            Type [] methodGetSoapActionParametersTypes = null;
            object[] parametersOfGetSoapAction = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSoapAction, parametersOfGetSoapAction, methodGetSoapActionParametersTypes);

            // Assert
            parametersOfGetSoapAction.ShouldBeNull();
            methodGetSoapActionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapAction_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapAction);
            Type [] methodGetSoapActionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSoapAction, methodGetSoapActionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSoapActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapAction_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapAction);
            Type [] methodGetSoapActionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSoapAction, methodGetSoapActionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSoapActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSoapAction) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetSoapAction_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSoapAction);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSoapAction, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestUrl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_GetRequestUrl_Method_Call_Internally(Type[] types)
        {
            var methodGetRequestUrlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequestUrl, methodGetRequestUrlParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequestUrl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetRequestUrl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestUrl);
            Type [] methodGetRequestUrlParametersTypes = null;
            object[] parametersOfGetRequestUrl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestUrl, methodGetRequestUrlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfGetRequestUrl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRequestUrl.ShouldBeNull();
            methodGetRequestUrlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestUrl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetRequestUrl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestUrl);
            Type [] methodGetRequestUrlParametersTypes = null;
            object[] parametersOfGetRequestUrl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetRequestUrl, parametersOfGetRequestUrl, methodGetRequestUrlParametersTypes);

            // Assert
            parametersOfGetRequestUrl.ShouldBeNull();
            methodGetRequestUrlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestUrl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetRequestUrl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestUrl);
            Type [] methodGetRequestUrlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestUrl, methodGetRequestUrlParametersTypes);

            // Assert
            methodGetRequestUrlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestUrl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_GetRequestUrl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestUrl);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestUrl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMethod) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_ExecuteMethod_Method_Call_Internally(Type[] types)
        {
            var methodExecuteMethodParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteMethod, methodExecuteMethodParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteMethod) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_ExecuteMethod_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMethod);
            Type [] methodExecuteMethodParametersTypes = null;
            object[] parametersOfExecuteMethod = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteMethod, methodExecuteMethodParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfExecuteMethod);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecuteMethod.ShouldBeNull();
            methodExecuteMethodParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMethod) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_ExecuteMethod_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMethod);
            Type [] methodExecuteMethodParametersTypes = null;
            object[] parametersOfExecuteMethod = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecuteMethod, parametersOfExecuteMethod, methodExecuteMethodParametersTypes);

            // Assert
            parametersOfExecuteMethod.ShouldBeNull();
            methodExecuteMethodParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMethod) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_ExecuteMethod_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMethod);
            Type [] methodExecuteMethodParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteMethod, methodExecuteMethodParametersTypes);

            // Assert
            methodExecuteMethodParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteMethod) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_ExecuteMethod_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteMethod);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteMethod, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Internally(Type[] types)
        {
            var methodRemoteCertificateValidationCallbackParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var sender = this.CreateType<Object>();
            var certificate = this.CreateType<X509Certificate>();
            var chain = this.CreateType<X509Chain>();
            var sslPolicyErrors = this.CreateType<SslPolicyErrors>();
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };
            object[] parametersOfRemoteCertificateValidationCallback = { sender, certificate, chain, sslPolicyErrors };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_webServiceCallInstanceFixture, parametersOfRemoteCertificateValidationCallback);
            var result2 = this.GetResultOfMethod<bool>(MethodRemoteCertificateValidationCallback, parametersOfRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.Length.ShouldBe(4);
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var sender = this.CreateType<Object>();
            var certificate = this.CreateType<X509Certificate>();
            var chain = this.CreateType<X509Chain>();
            var sslPolicyErrors = this.CreateType<SslPolicyErrors>();
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };
            object[] parametersOfRemoteCertificateValidationCallback = { sender, certificate, chain, sslPolicyErrors };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_webServiceCallInstanceFixture, out exception1, parametersOfRemoteCertificateValidationCallback);
            var result2 = this.GetResultOfMethod<bool>(MethodRemoteCertificateValidationCallback, parametersOfRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.Length.ShouldBe(4);
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var sender = this.CreateType<Object>();
            var certificate = this.CreateType<X509Certificate>();
            var chain = this.CreateType<X509Chain>();
            var sslPolicyErrors = this.CreateType<SslPolicyErrors>();
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };
            object[] parametersOfRemoteCertificateValidationCallback = { sender, certificate, chain, sslPolicyErrors };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_webServiceCallInstanceFixture, parametersOfRemoteCertificateValidationCallback);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoteCertificateValidationCallback.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.Length.ShouldBe(4);
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var sender = this.CreateType<Object>();
            var certificate = this.CreateType<X509Certificate>();
            var chain = this.CreateType<X509Chain>();
            var sslPolicyErrors = this.CreateType<SslPolicyErrors>();
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };
            object[] parametersOfRemoteCertificateValidationCallback = { sender, certificate, chain, sslPolicyErrors };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodRemoteCertificateValidationCallback, parametersOfRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            parametersOfRemoteCertificateValidationCallback.ShouldNotBeNull();
            parametersOfRemoteCertificateValidationCallback.Length.ShouldBe(4);
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var methodRemoteCertificateValidationCallbackParametersTypes = new Type[] { typeof(Object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoteCertificateValidationCallback, methodRemoteCertificateValidationCallbackParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoteCertificateValidationCallbackParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoteCertificateValidationCallback, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (RemoteCertificateValidationCallback) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebServiceCall_RemoteCertificateValidationCallback_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoteCertificateValidationCallback);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoteCertificateValidationCallback, 0);
            const int parametersCount = 4;

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