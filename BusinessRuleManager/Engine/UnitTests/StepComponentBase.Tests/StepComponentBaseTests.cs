using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.EnterpriseServices;
using System.EnterpriseServices.Fakes;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.Onyx.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Shouldly;
using StepComponentBaseClass = ConsonaCRM.Onyx.StepComponentBase;
using static ConsonaCRM.Onyx.StepComponentBase;

namespace StepComponentBase.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class StepComponentBaseTests
    {
        private const string DummyText = "Dummy";
        private const string EmptyString = "";
        private const string ReturnValue = "returnValue";
        private const string DefaultInputNode = "defaultInputNode";
        private const string DefaultReturnNode = "defaultReturnNode";
        private const string LogicalObjectName = "logicalObjectName";
        private const string LogicalMethodName = "logicalMethodName";
        private const string Cache = "cache";
        private const string DictionaryCache = "dictionaryCache";
        private const string AppData = "appData";
        private const string SessionManager = "sessionManager";
        private const string NatLangCache = "natLangCache";

        private IDisposable shimContext;
        private PrivateObject privateObject;
        private CultureInfo currentCulture;
        private DummyStepComponentBase testObject;
        private StringBuilder logMessage;
        private int handleExceptionCallCount;
        private int stepPackageCallCount;
        private int getRequiredNodeCallCount;
        private int getOrCreateNodeCallCount;
        private int setAbortCallCount;

        [SetUp]
        public void Initialize()
        {
            shimContext = ShimsContext.Create();
            currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            logMessage = new StringBuilder();
            ShimStepComponentLog.AllInstances.LogMessageStringStringStringString = (_, psSource, psDebugType, psMessage, psAdditionalInfo) =>
            {
                logMessage.Append($"{psSource}:{psDebugType}:{psMessage}:{psAdditionalInfo}~");
            };

            testObject = new DummyStepComponentBase();
            privateObject = new PrivateObject(testObject);
        }

        [TearDown]
        public void CleanUp()
        {
            shimContext?.Dispose();
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        [Test]
        public void Execute_GivenParameters_ReturnsValue()
        {
            // Arrange
            const string xml = "<xml><doc></doc></xml>";
            const string applicationName = "applicationName";
            const string logicalObjectName = LogicalObjectName;
            const string logicalMethodName = LogicalMethodName;
            const string expectedLogMessage = @"DummyStepComponentBase:Enter:a;stepObject=c;dataPath=f=Dummy/:Pre-execute logic was completed, starting execution... <xml><doc></doc></xml>~DummyStepComponentBase:Exit:a;stepObject=c;dataPath=f=Dummy/:Post-execute logic was completed, ending execution... <xml><doc></doc></xml>~";

            var xmlString = string.Empty;
            var psAdditionalData = $"a;{StepAdditionalDataValue.StepObject}=c;{StepAdditionalDataValue.DataPath}=f={DummyText}/";
            var packageContext = new ShimStepPackageContext().Instance;
            var handlerCallCount = 0;
            void handler() => handlerCallCount++;
            var logicalMethodHandler = new LogicalMethodHandler(handler);
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var xmlNode = xmlDoc.ChildNodes[0];

            SetupExecuteShims(packageContext, xmlDoc, xmlNode);

            Set(ReturnValue, DummyText);
            privateObject.Invoke("AddSupportedMethod", "c", string.Empty, logicalMethodHandler);

            // Act
            var result = testObject.Execute(
                applicationName,
                logicalObjectName,
                logicalMethodName,
                psAdditionalData,
                ref xmlString);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => xmlString.ShouldBe(xml),
                () => result.ShouldBe(DummyText),
                () => handlerCallCount.ShouldBe(1),
                () => setAbortCallCount.ShouldBe(1),
                () => stepPackageCallCount.ShouldBe(1),
                () => getRequiredNodeCallCount.ShouldBe(1),
                () => getOrCreateNodeCallCount.ShouldBe(1),
                () => handleExceptionCallCount.ShouldBe(0),
                () => logMessage.ToString().ShouldBe(expectedLogMessage),
                () => testObject.additionalDataValues.Count.ShouldBe(3),
                () => Get<XmlNode>(DefaultInputNode).ShouldBe(xmlNode),
                () => Get<XmlNode>(DefaultReturnNode).ShouldBe(xmlNode),
                () => Get<string>(LogicalObjectName).ShouldBe(logicalObjectName),
                () => Get<string>(LogicalMethodName).ShouldBe(logicalMethodName),
                () => Get<StepComponentCache>(Cache).prefix.ShouldBe($"{applicationName}.0."),
                () => Get<OnyxDictionaryCache>(DictionaryCache).applicationName.ShouldBe(applicationName),
                () => Get<OnyxAppData>(AppData).applicationName.ShouldBe(applicationName),
                () => Get<OnyxSessionManager>(SessionManager).context.ShouldBe(packageContext),
                () => Get<OnyxNatLangCache>(NatLangCache).applicationName.ShouldBe(applicationName));
        }

        [Test]
        public void Execute_GivenInvalidParameters_HandlesException()
        {
            // Arrange
            const string xml = "<xml><doc></doc></xml>";
            const string applicationName = "applicationName";
            const string expectedLogMessage = @"DummyStepComponentBase:Progress:A previous logical method step set statusType='failure', exiting...:~";

            var xmlString = string.Empty;
            var psAdditionalData = $"a;{StepAdditionalDataValue.StepObject}=c;{StepAdditionalDataValue.DataPath}=f={DummyText}/";
            var packageContext = new ShimStepPackageContext().Instance;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var xmlNode = xmlDoc.ChildNodes[0];

            SetupExecuteShims(packageContext, xmlDoc, xmlNode);
            var handleExceptionCallCount = 0;
            ShimStepComponentBase.AllInstances.HandleExceptionException = (_, e) =>
            {
                e.ShouldNotBeNull();
                handleExceptionCallCount++;
            };
            var postExecuteCallCount = 0;
            ShimStepComponentBase.AllInstances.PostExecuteStringRef = (StepComponentBaseClass instance, ref string psXMLString) =>
            {
                psXMLString.ShouldNotBeNull();
                postExecuteCallCount++;
                throw new InvalidOperationException("not allowed");
            };
            ShimStepPackage.AllInstances.statusTypeGet = _ => StepPackageStatusType.Failure;

            Set(ReturnValue, DummyText);

            // Act
            var result = testObject.Execute(
                applicationName,
                LogicalObjectName,
                LogicalMethodName,
                psAdditionalData,
                ref xmlString);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => result.ShouldBe(DummyText),
                () => postExecuteCallCount.ShouldBe(1),
                () => handleExceptionCallCount.ShouldBe(2),
                () => logMessage.ToString().ShouldBe(expectedLogMessage));
        }

        [Test]
        public void PostExecute_GivenFailureStatusType_IsSuccessful()
        {
            // Arrange
            var xmlString = string.Empty;

            var setCompleteCallCount = 0;
            ShimContextUtil.SetComplete = () => setCompleteCallCount++;
            ShimStepComponentBase.AllInstances.stepPackageGet = _ => new ShimStepPackage
            {
                statusTypeGet = () => StepPackageStatusType.Failure,
                xmlDocGet = () => new XmlDocument()
            }.Instance;

            // Act
            privateObject.Invoke("PostExecute", xmlString);

            // Assert
            setCompleteCallCount.ShouldBe(1);
        }

        [Test]
        public void GetDefaultInputReturnNodes_OnSuccess_SetsDefaultNodes()
        {
            // Arrange
            XmlNode xmlNode = new XmlDocument();

            ShimStepComponentBase.AllInstances.dataPathGet = _ => string.Empty;
            ShimStepComponentBase.AllInstances.stepMethodGet = _ => ConsonaCRM.Onyx.LogicalMethodName.RetrieveList;
            ShimStepComponentBase.AllInstances.stepPackageGet = _ => new ShimStepPackage
            {
                paramsNodeGet = () => xmlNode,
                paramsReturnNodeGet = () => xmlNode
            }.Instance;

            // Act
            privateObject.Invoke("GetDefaultInputReturnNodes");

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Get<XmlNode>(DefaultInputNode).ShouldBe(xmlNode),
                () => Get<XmlNode>(DefaultReturnNode).ShouldBe(xmlNode));
        }

        [Test]
        public void ExecuteMethodHandler_GivenInvalidParameter_ThrowsException()
        {
            // Arrange
            ShimStepComponentBase.AllInstances.supportedMethodHandlersGet = _ => new Hashtable();

            // Act
            var action = new Action(() => privateObject.Invoke("ExecuteMethodHandler", string.Empty, string.Empty));

            // Assert
            var exception = action.ShouldThrow<StepComponentException>();
            this.ShouldSatisfyAllConditions(
                () => exception.messageId.ShouldBe(700025),
                () => exception.additionalInfo.ShouldBeEmpty());
        }

        [TestCase(EmptyString, DummyText, DummyText, "A valid application name was not provided.")]
        [TestCase(DummyText, EmptyString, DummyText, "A valid logical object name was not provided.")]
        [TestCase(DummyText, DummyText, EmptyString, "A valid logical method name was not provided.")]
        public void PreExecute_InvalidParameter_ThrowsException(
            string psApplicationName,
            string psLogicalObjectName,
            string psLogicalMethodName,
            string exceptionMessage)
        {
            // Arrange, Act
            var action = new Action(() => privateObject.Invoke(
                "PreExecute",
                psApplicationName,
                psLogicalObjectName,
                psLogicalMethodName,
                DummyText,
                DummyText));

            // Assert
            var exception = action.ShouldThrow<StepComponentException>();
            this.ShouldSatisfyAllConditions(
                () => exception.additionalInfo.ShouldBeEmpty(),
                () => exception.Message.ShouldBe(exceptionMessage));
        }

        [Test]
        public void HandleException_GivenStepComponentStopException_IsSuccessful()
        {
            // Arrange
            Exception exception = new StepComponentStopException(DummyText);

            // Act
            privateObject.Invoke("HandleException", exception);

            // Assert
            Get<string>(ReturnValue).ShouldBe(DummyText);
        }

        [Test]
        public void HandleException_GivenStepComponentException_IsSuccessful()
        {
            // Arrange
            const string message = ":700025:Dummy::";

            Exception exception = new StepComponentException();

            ShimStepComponentException.AllInstances.messageIdGet = _ => 700025;
            var retrieveStringCallCount = 0;
            ShimStepComponentBase.AllInstances.natLangCacheGet = _ => new ShimOnyxNatLangCache
            {
                RetrieveStringInt32String = (messageId, arguments) =>
                {
                    this.ShouldSatisfyAllConditions(
                        () => messageId.ShouldBe(700025),
                        () => arguments.ShouldNotBeNull());

                    retrieveStringCallCount++;
                    return DummyText;
                }
            };
            var addErrorCallCount = 0;
            ShimStepComponentBase.AllInstances.stepPackageGet = _ => new ShimStepPackage
            {
                initializedGet = () => true,
                AddErrorInt64StringStringInt64StringString = (errorNumber, errorType, description, natLangId, sourceType, sourceName) =>
                {
                    this.ShouldSatisfyAllConditions(
                        () => errorNumber.ShouldBe(700025),
                        () => sourceName.ShouldContain(":"),
                        () => errorType.ShouldNotBeNull(),
                        () => description.ShouldNotBeNull(),
                        () => natLangId.ShouldNotBeNull(),
                        () => sourceType.ShouldNotBeNull());
                    addErrorCallCount++;
                }
            }.Instance;
            setAbortCallCount = 0;
            ShimContextUtil.SetAbort = () => setAbortCallCount++;

            var logMessageBuilder = new StringBuilder();
            testObject.log = new ShimStepComponentLog()
            {
                LogErrorStringInt64StringString = (source, messageid, psMessage, additionalInfo) =>
                {
                    logMessageBuilder.Append($"{source}:{messageid}:{psMessage}:{additionalInfo}:");
                }
            }.Instance;

            // Act
            privateObject.Invoke("HandleException", exception);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => addErrorCallCount.ShouldBe(1),
                () => setAbortCallCount.ShouldBe(1),
                () => retrieveStringCallCount.ShouldBe(1),
                () => logMessageBuilder.ToString().ShouldBe(message),
                () => Get<string>(ReturnValue).ShouldBe(StepReturnValue.Stop));
        }

        [Test]
        public void HandleException_GivenException_IsSuccessful()
        {
            // Arrange
            const string message = "DummyStepComponentBase:0:Dummy:Dummy:";

            var innerException = new StepComponentStopException(DummyText);
            var exception = new DummyException(DummyText, innerException);

            setAbortCallCount = 0;
            ShimContextUtil.SetAbort = () => setAbortCallCount++;
            var addErrorCallCount = 0;
            ShimStepComponentBase.AllInstances.stepPackageGet = _ => new ShimStepPackage
            {
                initializedGet = () => true,
                AddErrorInt64StringStringInt64StringString = (errorNumber, errorType, description, natLangId, sourceType, sourceName) =>
                {
                    this.ShouldSatisfyAllConditions(
                        () => errorNumber.ShouldBe(0),
                        () => sourceName.ShouldBeEmpty(),
                        () => errorType.ShouldNotBeNull(),
                        () => description.ShouldNotBeNull(),
                        () => natLangId.ShouldBe(0),
                        () => sourceType.ShouldBeEmpty());
                    addErrorCallCount++;
                }
            }.Instance;

            var logMessageBuilder = new StringBuilder();
            testObject.log = new ShimStepComponentLog()
            {
                LogErrorStringInt64StringString = (source, messageid, psMessage, additionalInfo) =>
                {
                    logMessageBuilder.Append($"{source}:{messageid}:{psMessage}:{additionalInfo}:");
                }
            }.Instance;

            // Act
            privateObject.Invoke("HandleException", exception);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => setAbortCallCount.ShouldBe(1),
                () => addErrorCallCount.ShouldBe(1),
                () => logMessageBuilder.ToString().ShouldBe(message),
                () => Get<string>(ReturnValue).ShouldBe(DummyText));
        }

        private void SetupExecuteShims(StepPackageContext packageContext, XmlDocument xmlDoc, XmlNode xmlNode)
        {
            handleExceptionCallCount = 0;
            ShimStepComponentBase.AllInstances.HandleExceptionException = (_, e) => handleExceptionCallCount++;

            stepPackageCallCount = 0;
            ShimStepPackage.ConstructorString = (_, psXmlString) =>
            {
                psXmlString.ShouldNotBeNull();
                stepPackageCallCount++;
            };
            ShimStepPackage.AllInstances.statusTypeGet = _ => StepPackageStatusType.Success;
            ShimStepPackage.AllInstances.contextGet = _ => packageContext;
            ShimStepPackage.AllInstances.paramsNodeGet = _ => xmlNode;
            ShimStepPackage.AllInstances.xmlDocGet = _ => xmlDoc;
            getRequiredNodeCallCount = 0;
            ShimXmlUtil.GetRequiredNodeXmlNodeString = (node, path) =>
            {
                this.ShouldSatisfyAllConditions(
                    () => node.ShouldNotBeNull(),
                    () => path.ShouldBe($"f={DummyText}/c"));
                getRequiredNodeCallCount++;
                return xmlNode;
            };
            getOrCreateNodeCallCount = 0;
            ShimXmlUtil.GetOrCreateNodeXmlNodeString = (node, path) =>
            {
                this.ShouldSatisfyAllConditions(
                    () => node.ShouldBeNull(),
                    () => path.ShouldBe($"f={DummyText}"));
                getOrCreateNodeCallCount++;
                return xmlNode;
            };
            setAbortCallCount = 0;
            ShimContextUtil.SetAbort = () => setAbortCallCount++;
        }

        private void Set<T>(string propertyName, T propertyValue)
        {
            privateObject.SetFieldOrProperty(propertyName, propertyValue);
        }

        private T Get<T>(string propertyName)
        {
            return (T)privateObject.GetFieldOrProperty(propertyName);
        }

        [Transaction(TransactionOption.Disabled), ComVisible(true)]
        public class DummyStepComponentBase : StepComponentBaseClass { }

        private class DummyException : Exception
        {
            private readonly string stackTrace;

            public DummyException(string message, Exception innerException) : base(message, innerException)
            {
                stackTrace = message;
            }

            public override string StackTrace => stackTrace;
        }
    }
}
