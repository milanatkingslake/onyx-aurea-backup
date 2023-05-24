using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Net.Fakes;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web.Services.Description;
using System.Web.Services.Description.Fakes;
using System.Xml;
using System.Xml.Fakes;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache.Fakes;
using ConsonaCRM.BusinessRuleManager.Fakes;
using ConsonaCRM.BusinessRuleManager.Grammar;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.Fakes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.Fakes;
using ConsonaCRM.BusinessRuleManager.Grammar.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Shouldly;

namespace BusinessRuleManagerProcess.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class WebServiceCallTests
    {
        private const string DummyText = "Dummy Text";
        private const string DummyUrl = "http://dummy.url";
        private const string GetMethod = "GET";
        private const string PostMethod = "POST";
        private const string RequestDoc = "requestDoc";
        private const string RequestBodyNode = "requestBodyNode";
        private const string RequestHeaderNode = "requestHeaderNode";
        private const string ServiceDescription = "serviceDescription";
        private const string WsdlUrl = "wsdlUrl";
        private const string MethodName = "methodName";
        private const string BindingName = "bindingName";
        private const string ServiceName = "serviceName";
        private const string RequestUrl = "requestUrl";
        private const string ResponseDoc = "responseDoc";
        private const string ResponseBodyNode = "responseBodyNode";

        private List<IDisposable> disposableObjects;
        private IDisposable shimContext;
        private PrivateObject privateObject;
        private CultureInfo currentCulture;
        private WebServiceCall testObject;
        private int evaluateStringCallCount;
        private bool loadServiceDescription;
        private bool getRequestUrl;
        private bool getSoapRequestPackage;
        private bool executeMethod;
        private int processXmlNodeCallCount;

        [SetUp]
        public void Initialize()
        {
            disposableObjects = new List<IDisposable>();
            shimContext = ShimsContext.Create();
            currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            testObject = new WebServiceCall();
            privateObject = new PrivateObject(testObject);
        }

        [TearDown]
        public void CleanUp()
        {
            shimContext?.Dispose();
            Thread.CurrentThread.CurrentCulture = currentCulture;
            disposableObjects.ForEach(o => o?.Dispose());
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Process_GivenInvalidEvaluateResult_ThrowsException(int allowedStringEvaluations)
        {
            // Arrange
            const string xml = "<xml><doc></doc></xml>";
            const string retrievedRequiredNode = "brm:wsdl:brm:service:brm:method:brm:inputParameters:brm:outputParameters:";

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var node = xmlDoc.ChildNodes[0];

            ShimGrammarBase.AllInstances.isActiveGet = _ => true;
            var requiredNode = new StringBuilder();
            ShimXmlUtil.GetRequiredNodeXmlNodeStringXmlNamespaceManager = (pParentNode, psXPath, pNamespaceManager) =>
            {
                this.ShouldSatisfyAllConditions(
                    () => pParentNode.ShouldNotBeNull(),
                    () => psXPath.ShouldNotBeNullOrEmpty(),
                    () => pNamespaceManager.ShouldBeNull());
                requiredNode.Append($"{psXPath}:");
                return node;
            };
            var evaluateStringCallCount = 0;
            ShimStringContainer.EvaluateStringXmlNodeInternalEngineXmlNodeXmlNamespaceManager
                = (pMetadataNode, pEngine, pDataNode, pNamespaceManager) =>
                {
                    this.ShouldSatisfyAllConditions(
                        () => pMetadataNode.ShouldNotBeNull(),
                        () => pEngine.ShouldBeNull(),
                        () => pDataNode.ShouldNotBeNull(),
                        () => pNamespaceManager.ShouldBeNull());
                    evaluateStringCallCount++;

                    if (evaluateStringCallCount == allowedStringEvaluations)
                    {
                        return string.Empty;
                    }

                    return DummyText;
                };

            testObject.metadataNode = node;

            // Act
            var action = new Action(() => testObject.Process(node));

            // Assert
            var exception = action.ShouldThrow<BusinessRuleManagerException>();
            this.ShouldSatisfyAllConditions(
                () => requiredNode.ToString().ShouldBe(retrievedRequiredNode),
                () => evaluateStringCallCount.ShouldBe(allowedStringEvaluations),
                () => exception.messageId.ShouldBe((long)SystemMessage.MessageId.EvaluatesToEmptyString));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Process_GivenParameter_IsSuccessful(bool isActive)
        {
            // Arrange
            const string xml = "<xml><doc><child><child2></child2></child></doc></xml>";

            var expectedProcessNodeCalls = isActive ? 2 : 0;
            var expectedEvaluateStringCalls = isActive ? 3 : 0;

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var node = xmlDoc.ChildNodes[0];

            SetupProcessShims(isActive, xmlDoc, node);

            testObject.metadataNode = node;
            privateObject.SetFieldOrProperty(RequestDoc, xmlDoc);
            privateObject.SetFieldOrProperty(RequestBodyNode, node);
            privateObject.SetFieldOrProperty(RequestHeaderNode, node.FirstChild);
            privateObject.SetFieldOrProperty(ServiceDescription, new ServiceDescription
            {
                TargetNamespace = DummyText
            });

            // Act
            testObject.Process(node);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => getRequestUrl.ShouldBe(isActive),
                () => executeMethod.ShouldBe(isActive),
                () => getSoapRequestPackage.ShouldBe(isActive),
                () => loadServiceDescription.ShouldBe(isActive),
                () => processXmlNodeCallCount.ShouldBe(expectedProcessNodeCalls),
                () => evaluateStringCallCount.ShouldBe(expectedEvaluateStringCalls),
                () =>
                {
                    if (isActive)
                    {
                        var firstChild = node.FirstChild;
                        var grandChild = node.FirstChild.FirstChild;
                        isActive.ShouldSatisfyAllConditions(
                            () => firstChild.Attributes.GetNamedItem("xmlns").ShouldNotBeNull(),
                            () => grandChild.Attributes.GetNamedItem("xmlns").ShouldNotBeNull());
                    }
                });
        }

        [TestCase(true)]
        [TestCase(false)]
        public void LoadServiceDescription_GivenParameter_IsSuccessful(bool isNullServiceDescription)
        {
            // Arrange
            var responseStream = new MemoryStream(Encoding.UTF8.GetBytes(DummyText));
            disposableObjects.Add(responseStream);

            var readString = false;
            var cacheWrite = false;
            var internalEngine = new InternalEngine
            {
                settingsCache = new ShimSettingsCache().Instance,
                cache = new ShimLocalCache
                {
                    ReadString = psName =>
                    {
                        psName.ShouldContain(DummyUrl);
                        readString = true;
                        if (isNullServiceDescription)
                        {
                            return null;
                        }
                        return new ServiceDescription();
                    },
                    WriteStringObject = (psName, pValue) =>
                    {
                        this.ShouldSatisfyAllConditions(
                            () => psName.ShouldContain(DummyUrl),
                            () => pValue.ShouldBeOfType<ServiceDescription>());
                        cacheWrite = true;
                    }
                }
            };

            ShimGrammarBase.AllInstances.engineGet = _ => internalEngine;
            ShimXmlDocumentCache.AllInstances.enableCachingGet = _ => true;
            var getResponseStream = false;
            ShimHttpWebRequest.AllInstances.GetResponse = instance =>
            {
                instance.Method.ShouldBe(GetMethod);
                return new ShimHttpWebResponse()
                {
                    GetResponseStream = () =>
                    {
                        getResponseStream = true;
                        return responseStream;
                    }
                };
            };
            ShimServiceDescription.ReadStream = stream =>
            {
                stream.ShouldBe(responseStream);
                return new ServiceDescription();
            };

            privateObject.SetFieldOrProperty(WsdlUrl, DummyUrl);

            // Act
            privateObject.Invoke("LoadServiceDescription");

            // Assert
            this.ShouldSatisfyAllConditions(
                () => readString.ShouldBeTrue(),
                () => getResponseStream.ShouldBe(isNullServiceDescription),
                () => cacheWrite.ShouldBe(isNullServiceDescription));
        }


        [TestCase(true)]
        [TestCase(false)]
        public void LoadServiceDescription_GivenNetworkError_ThrowsException(bool isGetResponseError)
        {
            // Arrange
            const string xml = "<xml><doc></doc></xml>";

            var messageId = isGetResponseError
                ? (long)SystemMessage.MessageId.ErrorLoadingWsdl
                : (long)SystemMessage.MessageId.ErrorParsingServiceDescription;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var node = xmlDoc.ChildNodes[0];

            ShimGrammarBase.AllInstances.engineGet = _ => new InternalEngine
            {
                settingsCache = new ShimSettingsCache().Instance
            };
            ShimXmlDocumentCache.AllInstances.enableCachingGet = _ => false;
            var getResponseStream = false;
            ShimHttpWebRequest.AllInstances.GetResponse = instance =>
            {
                instance.Method.ShouldBe(GetMethod);
                if (isGetResponseError)
                {
                    throw new InvalidOperationException("response not allwed");
                }
                return new ShimHttpWebResponse()
                {
                    GetResponseStream = () =>
                    {
                        getResponseStream = true;
                        throw new InvalidOperationException("response stream not allwed");
                    }
                };
            };

            testObject.metadataNode = node;
            privateObject.SetFieldOrProperty(WsdlUrl, DummyUrl);

            // Act
            var action = new Action(() => privateObject.Invoke("LoadServiceDescription"));

            // Assert
            var exception = action.ShouldThrow<BusinessRuleManagerException>();
            this.ShouldSatisfyAllConditions(
                () => exception.messageId.ShouldBe(messageId),
                () => getResponseStream.ShouldNotBe(isGetResponseError));
        }

        [Test]
        public void GetSoapRequestPackage_OnSuccess_UpdatesValues()
        {
            // Arrange
            const string soap = "soap";

            // Act
            privateObject.Invoke("GetSoapRequestPackage");

            // Assert
            this.ShouldSatisfyAllConditions(
                () =>
                {
                    Get<XmlDocument>(RequestDoc).ShouldNotBeNull();
                    Get<XmlDocument>(RequestDoc).OuterXml.ShouldContain(soap);
                },
                () =>
                {
                    Get<XmlNode>(RequestHeaderNode).ShouldNotBeNull();
                    Get<XmlNode>(RequestHeaderNode).Name.ShouldContain(soap);
                },
                () =>
                {
                    Get<XmlNode>(RequestBodyNode).ShouldNotBeNull();
                    Get<XmlNode>(RequestBodyNode).Name.ShouldContain(soap);
                });
        }

        [Test]
        public void GetSoapAction_OnSuccess_ReturnsResult()
        {
            // Arrange
            var binding = new Binding
            {
                Operations =
                {
                    new OperationBinding
                    {
                        Name = DummyText,
                        Extensions =
                        {
                            new SoapOperationBinding
                            {
                                SoapAction = GetMethod
                            }
                        }
                    }
                }
            };
            ShimServiceDescription.AllInstances.BindingsGet = _ => new ShimBindingCollection
            {
                ItemGetString = key =>
                {
                    key.ShouldBe(DummyText);
                    return binding;
                }
            };

            privateObject.SetFieldOrProperty(MethodName, DummyText);
            privateObject.SetFieldOrProperty(BindingName, DummyText);
            privateObject.SetFieldOrProperty(ServiceDescription, new ServiceDescription());

            // Act
            var result = privateObject.Invoke("GetSoapAction") as string;

            // Assert
            result.ShouldBe(GetMethod);
        }

        [Test]
        public void GetSoapAction_NoBindingOperation_ThrowsException()
        {
            // Arrange
            const string xml = "<xml><child></child></xml>";

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var node = xmlDoc.ChildNodes[0];
            var binding = new Binding
            {
                Operations =
                {
                    new OperationBinding
                    {
                        Name = DummyText,
                        Extensions =
                        {
                            new Soap12Binding()
                        }
                    }
                }
            };
            var getBinding = false;
            ShimServiceDescription.AllInstances.BindingsGet = _ => new ShimBindingCollection
            {
                ItemGetString = key =>
                {
                    key.ShouldBe(DummyText);
                    getBinding = true;
                    return binding;
                }
            };

            testObject.metadataNode = node;
            privateObject.SetFieldOrProperty(MethodName, DummyText);
            privateObject.SetFieldOrProperty(BindingName, DummyText);
            privateObject.SetFieldOrProperty(ServiceDescription, new ServiceDescription());

            // Act
            var action = new Action(() => privateObject.Invoke("GetSoapAction"));

            // Assert
            var exception = action.ShouldThrow<BusinessRuleManagerException>();
            this.ShouldSatisfyAllConditions(
                () => getBinding.ShouldBeTrue(),
                () => exception.messageArguments.ShouldBe("~Dummy Text"),
                () => exception.messageId.ShouldBe((long)SystemMessage.MessageId.SOAPActionNotFound));
        }

        [Test]
        public void GetRequestUrl_OnSuccess_ReturnsResult()
        {
            // Arrange
            var service = new Service
            {
                Ports =
                {
                    new Port
                    {
                        Binding = new XmlQualifiedName(DummyText),
                        Extensions =
                        {
                            new SoapAddressBinding
                            {
                                Location = DummyUrl
                            }
                        }
                    }
                }
            };
            ShimServiceDescription.AllInstances.ServicesGet = _ => new ShimServiceCollection
            {
                ItemGetString = key =>
                {
                    key.ShouldBe(DummyText);
                    return service;
                }
            };

            privateObject.SetFieldOrProperty(ServiceName, DummyText);
            privateObject.SetFieldOrProperty(ServiceDescription, new ServiceDescription());

            // Act
            privateObject.Invoke("GetRequestUrl");

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Get<string>(RequestUrl).ShouldBe(DummyUrl),
                () => Get<string>(BindingName).ShouldBe(DummyText));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void GetRequestUrl_InvalidService_ThrowsException(bool isNullService)
        {
            // Arrange
            const string xml = "<xml><doc></doc></xml>";

            var messageId = isNullService
                ? (long)SystemMessage.MessageId.ServiceNotFound
                : (long)SystemMessage.MessageId.RequestUrlNotFound;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var node = xmlDoc.ChildNodes[0];
            var service = new Service
            {
                Ports =
                {
                    new Port
                    {
                        Extensions =
                        {
                            new Soap12Binding()
                        }
                    }
                }
            };

            ShimServiceDescription.AllInstances.ServicesGet = _ => new ShimServiceCollection
            {
                ItemGetString = key =>
                {
                    key.ShouldBe(DummyText);
                    return isNullService
                        ? null
                        : service;
                }
            };

            testObject.metadataNode = node;
            privateObject.SetFieldOrProperty(ServiceName, DummyText);
            privateObject.SetFieldOrProperty(ServiceDescription, new ServiceDescription());

            // Act
            var action = new Action(() => privateObject.Invoke("GetRequestUrl"));

            // Assert
            action.ShouldThrow<BusinessRuleManagerException>()
                .messageId.ShouldBe(messageId);
        }

        [Test]
        public void ExecuteMethod_OnSuccess_UpdatesProperties()
        {
            // Arrange
            const string requestDoc = "<xml><doc></doc></xml>";
            const string xml = "<xml><doc><child><child2></child2></child></doc></xml>";
            var responseStream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            disposableObjects.Add(responseStream);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(requestDoc);

            var getResponseStream = false;
            ShimHttpWebRequest.AllInstances.GetResponse = instance =>
            {
                this.ShouldSatisfyAllConditions(
                    () => instance.Method.ShouldBe(PostMethod),
                    () => instance.ContentType.ShouldBe("text/xml"),
                    () => instance.Headers.Get("MessageType").ShouldBe("CALL"),
                    () => instance.Headers.Get("SOAPAction").ShouldBe(PostMethod));
                return new ShimHttpWebResponse()
                {
                    GetResponseStream = () =>
                    {
                        getResponseStream = true;
                        return responseStream;
                    }
                };
            };
            ShimHttpWebRequest.AllInstances.GetRequestStream = _ => responseStream;
            ShimWebServiceCall.AllInstances.GetSoapAction = _ => PostMethod;
            ShimXmlDocument.AllInstances.LoadStream = (instance, stream) =>
            {
                stream.ShouldBe(responseStream);
                instance.LoadXml(xml);
            };

            privateObject.SetFieldOrProperty(RequestUrl, DummyUrl);
            privateObject.SetFieldOrProperty(RequestDoc, xmlDoc);

            // Act
            privateObject.Invoke("ExecuteMethod");

            // Assert
            this.ShouldSatisfyAllConditions(
                () => getResponseStream.ShouldBeTrue(),
                () => Get<XmlDocument>(ResponseDoc).OuterXml.ShouldContain("child2"),
                () => Get<XmlNode>(ResponseBodyNode).ShouldNotBeNull());
        }

        [TestCase(true)]
        [TestCase(false)]
        public void ExecuteMethod_InvalidRequest_ThrowsEXception(bool isResponseStreamError)
        {
            // Arrange
            const string requestDoc = "<xml><doc></doc></xml>";

            var responseStream = new MemoryStream(Encoding.UTF8.GetBytes(requestDoc));
            disposableObjects.Add(responseStream);
            var messageArgument = isResponseStreamError
                ? "~~"
                : "~";
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(requestDoc);
            var node = xmlDoc.ChildNodes[0];

            var getResponseStream = false;
            ShimHttpWebRequest.AllInstances.GetResponse = instance =>
            {
                instance.Method.ShouldBe(PostMethod);
                return new ShimHttpWebResponse()
                {
                    GetResponseStream = () =>
                    {
                        getResponseStream = true;
                        if (isResponseStreamError)
                        {
                            throw new InvalidOperationException("not allowed");
                        }
                        return responseStream;
                    }
                };
            };
            ShimHttpWebRequest.AllInstances.GetRequestStream = _ => responseStream;
            ShimWebServiceCall.AllInstances.GetSoapAction = _ => PostMethod;
            var isLoadStream = false;
            ShimXmlDocument.AllInstances.LoadStream = (instance, stream) =>
            {
                stream.ShouldBe(responseStream);
                isLoadStream = true;
                throw new InvalidOperationException("xml load not allowed");
            };

            testObject.metadataNode = node;
            privateObject.SetFieldOrProperty(RequestUrl, DummyUrl);
            privateObject.SetFieldOrProperty(RequestDoc, xmlDoc);

            // Act
            var action = new Action(() => privateObject.Invoke("ExecuteMethod"));

            // Assert
            var exception = action.ShouldThrow<BusinessRuleManagerException>();
            this.ShouldSatisfyAllConditions(
                () => getResponseStream.ShouldBeTrue(),
                () => isLoadStream.ShouldNotBe(isResponseStreamError),
                () => exception.messageArguments.ShouldBe(messageArgument),
                () => exception.messageId.ShouldBe((long)SystemMessage.MessageId.ErrorExecutingWSMethod));
        }

        [Test]
        public void RemoteCertificateValidationCallback_GivenParameters_ReturnsResult()
        {
            // Arrange
            object sender = testObject;
            X509Certificate certificate = null;
            X509Chain chain = null;
            var policyErrors = SslPolicyErrors.None;

            // Act
            var result = (bool)privateObject.Invoke(
                "RemoteCertificateValidationCallback",
                sender,
                certificate,
                chain,
                policyErrors);

            // Assert
            result.ShouldBeTrue();
        }

        private void SetupProcessShims(bool isActive, XmlDocument xmlDoc, XmlNode node)
        {
            ShimGrammarBase.AllInstances.isActiveGet = _ => isActive;
            ShimXmlUtil.GetRequiredNodeXmlNodeStringXmlNamespaceManager = (pParentNode, psXPath, pNamespaceManager) =>
            {
                this.ShouldSatisfyAllConditions(
                    () => pParentNode.ShouldNotBeNull(),
                    () => psXPath.ShouldNotBeNullOrEmpty(),
                    () => pNamespaceManager.ShouldBeNull());
                return node;
            };
            evaluateStringCallCount = 0;
            ShimStringContainer.EvaluateStringXmlNodeInternalEngineXmlNodeXmlNamespaceManager
                = (pMetadataNode, pEngine, pDataNode, pNamespaceManager) =>
                {
                    this.ShouldSatisfyAllConditions(
                        () => pMetadataNode.ShouldNotBeNull(),
                        () => pEngine.ShouldBeNull(),
                        () => pDataNode.ShouldNotBeNull(),
                        () => pNamespaceManager.ShouldBeNull());
                    evaluateStringCallCount++;

                    return DummyText;
                };
            loadServiceDescription = false;
            ShimWebServiceCall.AllInstances.LoadServiceDescription = _ =>
            {
                loadServiceDescription = true;
            };
            getRequestUrl = false;
            ShimWebServiceCall.AllInstances.GetRequestUrl = _ =>
            {
                getRequestUrl = true;
            };
            getSoapRequestPackage = false;
            ShimWebServiceCall.AllInstances.GetSoapRequestPackage = _ =>
            {
                getSoapRequestPackage = true;
            };
            executeMethod = false;
            ShimWebServiceCall.AllInstances.ExecuteMethod = _ =>
            {
                executeMethod = true;
            };
            ShimGrammarBase.AllInstances.GetChildElementsXmlNode = (_, pParentNode) =>
            {
                pParentNode.ShouldNotBeNull();
                return xmlDoc.ChildNodes;
            };
            processXmlNodeCallCount = 0;
            ShimGrammarBase.CreateInstanceXmlNodeTypeGrammarBase = (pMetadataNode, pRequiredInterfaceType, pGrammarBase) =>
            {
                this.ShouldSatisfyAllConditions(
                    () => pMetadataNode.ShouldNotBeNull(),
                    () => pRequiredInterfaceType.ShouldBe(typeof(IGrammarProcess2)),
                    () => pGrammarBase.ShouldBe(testObject));

                return new ShimSaveXML
                {
                    ProcessXmlNodeXmlNode = (node1, node2) =>
                    {
                        node2.ShouldNotBeNull();
                        processXmlNodeCallCount++;
                    }
                }.Instance;
            };
        }

        private T Get<T>(string propertyName)
        {
            return (T)privateObject.GetFieldOrProperty(propertyName);
        }
    }
}
