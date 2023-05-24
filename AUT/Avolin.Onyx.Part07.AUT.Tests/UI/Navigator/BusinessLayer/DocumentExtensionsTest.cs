using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.BusinessLayer;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.DocumentExtensions" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DocumentExtensionsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DocumentExtensions" />)
        /// </summary>
        public DocumentExtensionsTest() : base(typeof(DocumentExtensions))
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

        #region General Initializer : Class (DocumentExtensions) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _documentExtensionsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="DocumentExtensions" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _documentExtensionsInstanceType = typeof(DocumentExtensions);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DocumentExtensions) Initializer

        #region Methods

        private const string MethodToXmlDocument = "ToXmlDocument";
        private const string MethodToXDocument = "ToXDocument";

        #endregion

        #endregion

        #region General Initializer : Class (DocumentExtensions) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DocumentExtensions" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DocumentExtensions_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DocumentExtensions)

        #region General Initializer : Class (DocumentExtensions) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DocumentExtensions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodToXmlDocument, 0)]
        [TestCase(MethodToXDocument, 0)]
        public void AUT_DocumentExtensions_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (DocumentExtensions) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DocumentExtensions" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DocumentExtensions_Is_Static_Type_Present_Test()
        {
            // Assert
            _documentExtensionsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var xDocument = this.CreateType<XDocument>();

            // Act
            Action executeAction = () => DocumentExtensions.ToXmlDocument(xDocument);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var xDocument = this.CreateType<XDocument>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = DocumentExtensions.ToXmlDocument(xDocument);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var xDocument = this.CreateType<XDocument>();
            var methodToXmlDocumentParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfToXmlDocument = { xDocument };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlDocument, methodToXmlDocumentParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToXmlDocument, methodToXmlDocumentParametersTypes);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodToXmlDocument, parametersOfToXmlDocument, methodToXmlDocumentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToXmlDocument.ShouldNotBeNull();
            parametersOfToXmlDocument.Length.ShouldBe(1);
            methodToXmlDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<XmlDocument>(MethodToXmlDocument, parametersOfToXmlDocument, methodToXmlDocumentParametersTypes));
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var xDocument = this.CreateType<XDocument>();
            var methodToXmlDocumentParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfToXmlDocument = { xDocument };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlDocument, methodToXmlDocumentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToXmlDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToXmlDocument.ShouldNotBeNull();
            parametersOfToXmlDocument.Length.ShouldBe(1);
            methodToXmlDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var xDocument = this.CreateType<XDocument>();
            var methodToXmlDocumentParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfToXmlDocument = { xDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodToXmlDocument, parametersOfToXmlDocument, methodToXmlDocumentParametersTypes);

            // Assert
            parametersOfToXmlDocument.ShouldNotBeNull();
            parametersOfToXmlDocument.Length.ShouldBe(1);
            methodToXmlDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var methodToXmlDocumentParametersTypes = new Type[] { typeof(XDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToXmlDocument, methodToXmlDocumentParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToXmlDocumentParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var methodToXmlDocumentParametersTypes = new Type[] { typeof(XDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToXmlDocument, methodToXmlDocumentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToXmlDocumentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlDocument, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToXmlDocument) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXmlDocument_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlDocument, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_Internally(Type[] types)
        {
            var methodToXDocumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToXDocument, methodToXDocumentParametersTypes);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var xmlDocument = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => DocumentExtensions.ToXDocument(xmlDocument);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var xmlDocument = this.CreateType<XmlDocument>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = DocumentExtensions.ToXDocument(xmlDocument);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodToXDocumentParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfToXDocument = { xmlDocument };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToXDocument, methodToXDocumentParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToXDocument, methodToXDocumentParametersTypes);
            var result2 = this.GetResultOfMethod<XDocument>(MethodToXDocument, parametersOfToXDocument, methodToXDocumentParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToXDocument);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfToXDocument.ShouldNotBeNull();
            parametersOfToXDocument.Length.ShouldBe(1);
            methodToXDocumentParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var xmlDocument = this.CreateType<XmlDocument>();
            var methodToXDocumentParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfToXDocument = { xmlDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodToXDocument, parametersOfToXDocument, methodToXDocumentParametersTypes);

            // Assert
            parametersOfToXDocument.ShouldNotBeNull();
            parametersOfToXDocument.Length.ShouldBe(1);
            methodToXDocumentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var methodToXDocumentParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToXDocument, methodToXDocumentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodToXDocumentParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var methodToXDocumentParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToXDocument, methodToXDocumentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToXDocumentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodToXDocument, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToXDocument) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DocumentExtensions_ToXDocument_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXDocument);
            var currentMethodInfo = this.GetMethodInfo(MethodToXDocument, 0);
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