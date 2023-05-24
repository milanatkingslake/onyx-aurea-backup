using System;
using System.Diagnostics.CodeAnalysis;
using System.Fakes;
using System.Globalization;
using System.Threading;
using System.Xml;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
using Shouldly;
using ConsonaCRM.Onyx;

namespace StepComponentBase.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class StepPackageTests
    {
        private const string MethodNameAddErrorOrWarning = "AddErrorOrWarning";
        private const int DummyErrorNumber1 = 24;
        private const int DummyErrorNumber2 = 25;
        private const string DummyErrorType1 = "DummyErrorType1";
        private const string DummyErrorType2 = "DummyErrorType2";
        private const string DummyErrorDescription1 = "DummyErrorDescription1";
        private const string DummyErrorDescription2 = "DummyErrorDescription2";
        private const int DummyNatLangId1 = 797;
        private const int DummyNatLangId2 = 798;
        private const string DummySourceType1 = "DummySourceType1";
        private const string DummySourceType2 = "DummySourceType2";
        private const string DummySourceName1 = "DummySourceName1";
        private const string DummySourceName2 = "DummySourceName2";
        private const string DummyString = "DummyString";
        private const string DefaultXmlString = "\r\n<stepPackage>\r\n<context>\r\n</context>\r\n<parameters>\r\n<DummyParameter></DummyParameter>\r\n</parameters>\r\n<returnXml>\r\n<parametersReturn>\r\n<DummyParameterReturn></DummyParameterReturn>\r\n</parametersReturn>\r\n<methodStatus>\r\n<statusType></statusType>\r\n</methodStatus>\r\n</returnXml>\r\n</stepPackage>\r\n";
        private const string ExpectedXmlDocConstructor = "<stepPackage><context></context><parameters><DummyParameter></DummyParameter></parameters><returnXml><parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType></statusType></methodStatus></returnXml></stepPackage>";
        private const string ExpectedXmlAddErrorOrWarning = "<stepPackage><context></context><parameters><DummyParameter></DummyParameter></parameters><returnXml><parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType>failure</statusType><error><errorNumber>24</errorNumber><errorType>DummyErrorType1</errorType><errorDescription>DummyErrorDescription1</errorDescription><natLangId>797</natLangId><severity>failure</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType1</sourceType><sourceName>DummySourceName1</sourceName></error><error><errorNumber>25</errorNumber><errorType>DummyErrorType2</errorType><errorDescription>DummyErrorDescription2</errorDescription><natLangId>798</natLangId><severity>warning</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType2</sourceType><sourceName>DummySourceName2</sourceName></error></methodStatus></returnXml></stepPackage>";
        private const string ExpectedXmlAddMessage = "<stepPackage><context></context><parameters><DummyParameter></DummyParameter></parameters><returnXml><parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType></statusType><message><messageID>24</messageID><messageText>DummyErrorDescription1</messageText><timestamp>2018-06-07 02:01:03</timestamp></message></methodStatus></returnXml></stepPackage>";
        private const string ExpectedXmlAddWarning = "<stepPackage><context></context><parameters><DummyParameter></DummyParameter></parameters><returnXml><parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType></statusType><error><errorNumber>24</errorNumber><errorType>DummyErrorType1</errorType><errorDescription>DummyErrorDescription1</errorDescription><natLangId>797</natLangId><severity>warning</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType1</sourceType><sourceName>DummySourceName1</sourceName></error></methodStatus></returnXml></stepPackage>";
        private const string ExpectedXmlAddError = "<stepPackage><context></context><parameters><DummyParameter></DummyParameter></parameters><returnXml><parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType>failure</statusType><error><errorNumber>24</errorNumber><errorType>DummyErrorType1</errorType><errorDescription>DummyErrorDescription1</errorDescription><natLangId>797</natLangId><severity>failure</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType1</sourceType><sourceName>DummySourceName1</sourceName></error></methodStatus></returnXml></stepPackage>";
        private const string DummyName = "DummyName";
        private const string DummyValue = "DummyValue";
        private const string ExpectedXmlSetContextProperty = "<DummyName>DummyValue</DummyName>";
        private const string ExpectedXmlMergeMethodStatus = "<statusType>failure</statusType><error><errorNumber>25</errorNumber><errorType>DummyErrorType2</errorType><errorDescription>DummyErrorDescription2</errorDescription><natLangId>798</natLangId><severity>warning</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType2</sourceType><sourceName>DummySourceName2</sourceName></error><error><errorNumber>24</errorNumber><errorType>DummyErrorType1</errorType><errorDescription>DummyErrorDescription1</errorDescription><natLangId>797</natLangId><severity>failure</severity><timestamp>2018-06-07 02:01:03</timestamp><sourceType>DummySourceType1</sourceType><sourceName>DummySourceName1</sourceName></error>";
        private const string ExpectedXmlReturnXmlNode = "<parametersReturn><DummyParameterReturn></DummyParameterReturn></parametersReturn><methodStatus><statusType></statusType></methodStatus>";
        private const string ExpectedExceptionMessageSetStatusType = "Invalid status type value was provided.";
        private const string ExpectedExceptionMessageSetDocument = "Error parsing step package XML.";
        private IDisposable shimContext;
        private PrivateObject privateObject;
        private CultureInfo currentCulture;
        private StepPackage testObject;
        private static readonly DateTime DummyDateTimeNow = new DateTime(2018, 6, 7, 2, 1, 3, DateTimeKind.Utc);
        private static readonly Guid DummyNewGuid = new Guid("f878da7e-1adc-4902-acca-3582f6fc2b7b");

        [OneTimeSetUp]
        public void OneTimeInitialize()
        {
            shimContext = ShimsContext.Create();
            currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ShimDateTime.NowGet = () => DummyDateTimeNow;
            ShimGuid.NewGuid = () => DummyNewGuid;
        }

        [SetUp]
        public void Initialize()
        {
            testObject = new StepPackage(DefaultXmlString);
            privateObject = new PrivateObject(testObject);
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {
            shimContext?.Dispose();
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        [Test]
        public void Constructor_Empty_ReturnsClass()
        {
            // Arrange, Act
            var stepPacket = new StepPackage();

            // Assert
            this.ShouldSatisfyAllConditions(
                () => stepPacket.initialized.ShouldBeFalse(),
                () => stepPacket.xmlDoc.ShouldBeNull());
        }

        [Test]
        public void Constructor_XmlDocumentParameter_SetDocument()
        {
            // Arrange
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(DefaultXmlString);

            // Act
            var stepPacket = new StepPackage(xmlDocument);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => stepPacket.initialized.ShouldBeTrue(),
                () => stepPacket.xmlDoc.InnerXml.ShouldBe(ExpectedXmlDocConstructor));
        }

        [Test]
        public void Constructor_StepPackageParameter_SetDocument()
        {
            // Arrange
            var stepPacket = new StepPackage(DefaultXmlString);

            // Act
            var result = new StepPackage(stepPacket);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => stepPacket.initialized.ShouldBeTrue(),
                () => result.xmlDoc.InnerXml.ShouldBe(ExpectedXmlDocConstructor));
        }

        [Test]
        public void AddErrorOrWarning_LowPriorityMessage_UpdateDocument()
        {
            // Arrange
            privateObject.Invoke(MethodNameAddErrorOrWarning,
                false,
                DummyErrorNumber2,
                DummyErrorType2,
                DummyErrorDescription2,
                DummyNatLangId2,
                DummySourceType2,
                DummySourceName2);

            // Act
            privateObject.Invoke(MethodNameAddErrorOrWarning,
                true,
                DummyErrorNumber1,
                DummyErrorType1,
                DummyErrorDescription1,
                DummyNatLangId1,
                DummySourceType1,
                DummySourceName1);

            // Assert
            testObject.xmlDoc.InnerXml.ShouldBe(ExpectedXmlAddErrorOrWarning);
        }

        [Test]
        public void SetDocument_InvalidXmlString_ThrowsStepComponentException()
        {
            // Arrange, Act
            Action action = () => testObject.SetDocument(string.Empty);

            // Assert
            action.ShouldThrow<StepComponentException>().Message.ShouldBe(ExpectedExceptionMessageSetDocument);
        }

        [Test]
        public void AddMessage_OnValidCall_UpdateDocument()
        {
            // Arrange, Act
            testObject.AddMessage(DummyErrorNumber1, DummyErrorDescription1);

            // Assert
            testObject.xmlDoc.InnerXml.ShouldBe(ExpectedXmlAddMessage);
        }

        [Test]
        public void AddWarning_OnValidCall_UpdateDocument()
        {
            // Arrange, Act
            testObject.AddWarning(DummyErrorNumber1, DummyErrorType1, DummyErrorDescription1, DummyNatLangId1, DummySourceType1, DummySourceName1);

            // Assert
            testObject.xmlDoc.InnerXml.ShouldBe(ExpectedXmlAddWarning);
        }

        [Test]
        public void AddError_OnValidCall_UpdateDocument()
        {
            // Arrange, Act
            testObject.AddError(DummyErrorNumber1, DummyErrorType1, DummyErrorDescription1, DummyNatLangId1, DummySourceType1, DummySourceName1);

            // Assert
            testObject.xmlDoc.InnerXml.ShouldBe(ExpectedXmlAddError);
        }

        [Test]
        public void SetStatusType_StatusSuccessWithInfo_SetStatusType()
        {
            // Arrange
            testObject.statusType = StepPackageStatusType.Success;

            // Act
            testObject.SetStatusType(StepPackageStatusType.SuccessWithInfo);

            // Assert
            testObject.statusType.ShouldBe(StepPackageStatusType.SuccessWithInfo);
        }

        [Test]
        public void SetStatusType_StatusSuccess_KeepStatus()
        {
            // Arrange
            testObject.statusType = StepPackageStatusType.Failure;

            // Act
            testObject.SetStatusType(StepPackageStatusType.Success);

            // Assert
            testObject.statusType.ShouldBe(StepPackageStatusType.Failure);
        }

        [Test]
        public void SetStatusType_InvalidStatus_ThrowsStepComponentException()
        {
            // Arrange, Act
            Action action = () => testObject.SetStatusType(DummyString);

            // Assert
            action.ShouldThrow<StepComponentException>().Message.ShouldBe(ExpectedExceptionMessageSetStatusType);
        }

        [Test]
        public void GetContextProperty_OnValidCall_ReturnsString()
        {
            // Arrange
            testObject.SetContextProperty(DummyName, DummyValue);

            // Act
            var result = testObject.GetContextProperty(DummyName);

            // Assert
            result.ShouldBe(DummyValue);
        }

        [Test]
        public void SetContextProperty_OnValidCall_SetContextNode()
        {
            // Arrange, Act
            testObject.SetContextProperty(DummyName, DummyValue);

            // Assert
            testObject.contextNode.InnerXml.ShouldBe(ExpectedXmlSetContextProperty);
        }

        [Test]
        public void Reset_OnValidCall_ClearSomeChildNodes()
        {
            // Arrange
            testObject.AddError(DummyErrorNumber1, DummyErrorType1, DummyErrorDescription1, DummyNatLangId1, DummySourceType1, DummySourceName1);

            // Act
            testObject.Reset();

            // Assert
            this.ShouldSatisfyAllConditions(
                () => testObject.paramsNode.ChildNodes.Count.ShouldBe(0),
                () => testObject.paramsReturnNode.ChildNodes.Count.ShouldBe(0),
                () => testObject.methodStatusNode.ChildNodes.Count.ShouldBe(1),
                () => testObject.statusType.ShouldBe(StepPackageStatusType.Success),
                () => testObject.context.otmID.ShouldBe(DummyNewGuid.ToString().ToUpper()));
        }

        [Test]
        public void MergeMethodStatus_OnValidCall_UpdateMethodStatusNode()
        {
            // Arrange
            var stepPacket = new StepPackage(DefaultXmlString);
            stepPacket.AddError(DummyErrorNumber1, DummyErrorType1, DummyErrorDescription1, DummyNatLangId1, DummySourceType1, DummySourceName1);

            testObject.AddWarning(DummyErrorNumber2, DummyErrorType2, DummyErrorDescription2, DummyNatLangId2, DummySourceType2, DummySourceName2);

            // Act
            testObject.MergeMethodStatus(stepPacket);

            // Assert
            testObject.methodStatusNode.InnerXml.ShouldBe(ExpectedXmlMergeMethodStatus);
        }

        [Test]
        public void ReturnXmlNode_GetValue_ReturnsXmlNode()
        {
            // Arrange, Act
            var returnXmlNode = testObject.returnXmlNode;

            // Assert
            returnXmlNode.ShouldNotBeNull();
            returnXmlNode.InnerXml.ShouldBe(ExpectedXmlReturnXmlNode);
        }
    }
}