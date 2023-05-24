using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using PasswordEncryptLibrary;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.PasswordEncryptLibrary
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="PasswordEncryptLibrary.XmlHandlers" />)
    ///     and namespace <see cref="PasswordEncryptLibrary"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlHandlersTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlHandlers" />)
        /// </summary>
        public XmlHandlersTest() : base(typeof(XmlHandlers))
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

        #region General Initializer : Class (XmlHandlers) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlHandlersInstanceType;
        private XmlHandlers _xmlHandlersInstance;
        private XmlHandlers _xmlHandlersInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlHandlers" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlHandlersInstanceType = typeof(XmlHandlers);
            _xmlHandlersInstanceFixture = this.Create<XmlHandlers>(false);
            _xmlHandlersInstance = _xmlHandlersInstanceFixture ?? this.Create<XmlHandlers>(true);
            CurrentInstance = _xmlHandlersInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlHandlers) Initializer

        #region Properties

        private const string PropertyExceptionCodes = "ExceptionCodes";
        private const string PropertyIsSuccess = "IsSuccess";

        #endregion

        #region Methods

        private const string MethodGetDocument = "GetDocument";
        private const string MethodGetXmlAtrributeText = "GetXmlAtrributeText";
        private const string MethodUpdateXmlDocument = "UpdateXmlDocument";

        #endregion

        #region Fields

        private const string FieldxmlDom = "xmlDom";
        private const string FieldfilePath = "filePath";

        #endregion

        #endregion

        #region General Initializer : Class (XmlHandlers) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHandlers_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlHandlers) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHandlers_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlHandlers) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHandlers_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlHandlers)

        #region General Initializer : Class (XmlHandlers) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDocument, 0)]
        [TestCase(MethodGetXmlAtrributeText, 0)]
        [TestCase(MethodUpdateXmlDocument, 0)]
        public void AUT_XmlHandlers_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (XmlHandlers) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyExceptionCodes)]
        [TestCase(PropertyIsSuccess)]
        [Category("AUT Property")]
        public void AUT_XmlHandlers_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (XmlHandlers) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldxmlDom)]
        [TestCase(FieldfilePath)]
        [Category("AUT Fields")]
        public void AUT_XmlHandlers_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlHandlers) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlHandlers_Is_Instance_Present_Test()
        {
            // Assert
            _xmlHandlersInstanceType.ShouldNotBeNull();
            _xmlHandlersInstance.ShouldNotBeNull();
            _xmlHandlersInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (XmlHandlers) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlHandlers" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlHandlers_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlHandlersInstance.ShouldBeAssignableTo<XmlHandlers>();
            _xmlHandlersInstanceFixture.ShouldBeAssignableTo<XmlHandlers>();
            CurrentInstance.ShouldBeAssignableTo<XmlHandlers>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlHandlers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlHandlers_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var fileName = this.CreateType<string>();
            XmlHandlers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new XmlHandlers(fileName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _xmlHandlersInstance.ShouldNotBeNull();
            _xmlHandlersInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<XmlHandlers>();
        }

        #endregion

        #region General Constructor : Class (XmlHandlers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlHandlers_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var fileName = this.CreateType<string>();
            XmlHandlers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new XmlHandlers(fileName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _xmlHandlersInstance.ShouldNotBeNull();
            _xmlHandlersInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (XmlHandlers) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyExceptionCodes)]
        [TestCase(PropertyIsSuccess)]
        public void AUT_XmlHandlers_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (XmlHandlers) => Property (ExceptionCodes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlHandlers_Public_Class_ExceptionCodes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptionCodes);
            var propertyInfo = this.GetPropertyInfo(PropertyExceptionCodes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (XmlHandlers) => Property (IsSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlHandlers_Public_Class_IsSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSuccess);

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

        #region Method Call : (GetDocument) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);

            // Act
            Action executeAction = () => _xmlHandlersInstance.GetDocument();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = _xmlHandlersInstance.GetDocument();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            Type [] methodGetDocumentParametersTypes = null;
            object[] parametersOfGetDocument = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocument, methodGetDocumentParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_xmlHandlersInstanceFixture, parametersOfGetDocument);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodGetDocument, parametersOfGetDocument, methodGetDocumentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocument.ShouldBeNull();
            methodGetDocumentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            Type [] methodGetDocumentParametersTypes = null;
            object[] parametersOfGetDocument = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocument, methodGetDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlHandlersInstanceFixture, parametersOfGetDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDocument.ShouldBeNull();
            methodGetDocumentParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            Type [] methodGetDocumentParametersTypes = null;
            object[] parametersOfGetDocument = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodGetDocument, parametersOfGetDocument, methodGetDocumentParametersTypes);

            // Assert
            parametersOfGetDocument.ShouldBeNull();
            methodGetDocumentParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            Type [] methodGetDocumentParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocument, methodGetDocumentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            Type [] methodGetDocumentParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocument, methodGetDocumentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocument) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetDocument_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocument, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlAtrributeTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var xPath = this.CreateType<string>();
            var xmlDom = this.CreateType<XmlDocument>();
            var attributeToRead = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlHandlersInstance.GetXmlAtrributeText(xPath, xmlDom, attributeToRead);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var xPath = this.CreateType<string>();
            var xmlDom = this.CreateType<XmlDocument>();
            var attributeToRead = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlHandlersInstance.GetXmlAtrributeText(xPath, xmlDom, attributeToRead);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var xPath = this.CreateType<string>();
            var xmlDom = this.CreateType<XmlDocument>();
            var attributeToRead = this.CreateType<string>();
            var methodGetXmlAtrributeTextParametersTypes = new Type[] { typeof(string), typeof(XmlDocument), typeof(string) };
            object[] parametersOfGetXmlAtrributeText = { xPath, xmlDom, attributeToRead };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlHandlersInstanceFixture, out exception1, parametersOfGetXmlAtrributeText);
            var result2 = this.GetResultOfMethod<string>(MethodGetXmlAtrributeText, parametersOfGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetXmlAtrributeText.ShouldNotBeNull();
            parametersOfGetXmlAtrributeText.Length.ShouldBe(3);
            methodGetXmlAtrributeTextParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var xPath = this.CreateType<string>();
            var xmlDom = this.CreateType<XmlDocument>();
            var attributeToRead = this.CreateType<string>();
            var methodGetXmlAtrributeTextParametersTypes = new Type[] { typeof(string), typeof(XmlDocument), typeof(string) };
            object[] parametersOfGetXmlAtrributeText = { xPath, xmlDom, attributeToRead };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlHandlersInstanceFixture, parametersOfGetXmlAtrributeText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetXmlAtrributeText.ShouldNotBeNull();
            parametersOfGetXmlAtrributeText.Length.ShouldBe(3);
            methodGetXmlAtrributeTextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var xPath = this.CreateType<string>();
            var xmlDom = this.CreateType<XmlDocument>();
            var attributeToRead = this.CreateType<string>();
            var methodGetXmlAtrributeTextParametersTypes = new Type[] { typeof(string), typeof(XmlDocument), typeof(string) };
            object[] parametersOfGetXmlAtrributeText = { xPath, xmlDom, attributeToRead };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXmlAtrributeText, parametersOfGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes);

            // Assert
            parametersOfGetXmlAtrributeText.ShouldNotBeNull();
            parametersOfGetXmlAtrributeText.Length.ShouldBe(3);
            methodGetXmlAtrributeTextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var methodGetXmlAtrributeTextParametersTypes = new Type[] { typeof(string), typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetXmlAtrributeTextParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var methodGetXmlAtrributeTextParametersTypes = new Type[] { typeof(string), typeof(XmlDocument), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXmlAtrributeText, methodGetXmlAtrributeTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlAtrributeTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlAtrributeText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetXmlAtrributeText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_GetXmlAtrributeText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlAtrributeText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlAtrributeText, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_Internally(Type[] types)
        {
            var methodUpdateXmlDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var xmlDom = this.CreateType<XmlDocument>();
            var xPath = this.CreateType<string>();
            var inputData = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlHandlersInstance.UpdateXmlDocument(xmlDom, xPath, inputData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var xmlDom = this.CreateType<XmlDocument>();
            var xPath = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = _xmlHandlersInstance.UpdateXmlDocument(xmlDom, xPath, inputData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var xmlDom = this.CreateType<XmlDocument>();
            var xPath = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var methodUpdateXmlDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string) };
            object[] parametersOfUpdateXmlDocument = { xmlDom, xPath, inputData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_xmlHandlersInstanceFixture, parametersOfUpdateXmlDocument);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodUpdateXmlDocument, parametersOfUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateXmlDocument.ShouldNotBeNull();
            parametersOfUpdateXmlDocument.Length.ShouldBe(3);
            methodUpdateXmlDocumentParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var xmlDom = this.CreateType<XmlDocument>();
            var xPath = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var methodUpdateXmlDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string) };
            object[] parametersOfUpdateXmlDocument = { xmlDom, xPath, inputData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlHandlersInstanceFixture, parametersOfUpdateXmlDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateXmlDocument.ShouldNotBeNull();
            parametersOfUpdateXmlDocument.Length.ShouldBe(3);
            methodUpdateXmlDocumentParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var xmlDom = this.CreateType<XmlDocument>();
            var xPath = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var methodUpdateXmlDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string) };
            object[] parametersOfUpdateXmlDocument = { xmlDom, xPath, inputData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodUpdateXmlDocument, parametersOfUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes);

            // Assert
            parametersOfUpdateXmlDocument.ShouldNotBeNull();
            parametersOfUpdateXmlDocument.Length.ShouldBe(3);
            methodUpdateXmlDocumentParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var methodUpdateXmlDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateXmlDocumentParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var methodUpdateXmlDocumentParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateXmlDocument, methodUpdateXmlDocumentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateXmlDocumentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateXmlDocument, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateXmlDocument) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHandlers_UpdateXmlDocument_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateXmlDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateXmlDocument, 0);
            const int parametersCount = 3;

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