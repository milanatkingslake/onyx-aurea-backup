using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.XmlUtil" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlUtilTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlUtil" />)
        /// </summary>
        public XmlUtilTest() : base(typeof(XmlUtil))
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

        #region General Initializer : Class (XmlUtil) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlUtilInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="XmlUtil" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlUtilInstanceType = typeof(XmlUtil);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlUtil) Initializer

        #region Methods

        private const string MethodGetRequiredNode = "GetRequiredNode";
        private const string MethodGetRequiredNodeValue = "GetRequiredNodeValue";
        private const string MethodGetNodeValue = "GetNodeValue";
        private const string MethodGetOrCreateNode = "GetOrCreateNode";
        private const string MethodAddChildNode = "AddChildNode";
        private const string MethodSetChildNodeValue = "SetChildNodeValue";
        private const string MethodDateTimeToTimestamp = "DateTimeToTimestamp";
        private const string MethodFormatGuid = "FormatGuid";
        private const string MethodAppendXmlFromString = "AppendXmlFromString";

        #endregion

        #endregion

        #region General Initializer : Class (XmlUtil) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlUtil" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlUtil_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlUtil)

        #region General Initializer : Class (XmlUtil) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlUtil" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetRequiredNode, 0)]
        [TestCase(MethodGetRequiredNode, 1)]
        [TestCase(MethodGetRequiredNodeValue, 0)]
        [TestCase(MethodGetRequiredNodeValue, 1)]
        [TestCase(MethodGetNodeValue, 0)]
        [TestCase(MethodGetNodeValue, 1)]
        [TestCase(MethodGetOrCreateNode, 0)]
        [TestCase(MethodGetOrCreateNode, 1)]
        [TestCase(MethodAddChildNode, 0)]
        [TestCase(MethodAddChildNode, 1)]
        [TestCase(MethodSetChildNodeValue, 0)]
        [TestCase(MethodSetChildNodeValue, 1)]
        [TestCase(MethodDateTimeToTimestamp, 0)]
        [TestCase(MethodFormatGuid, 0)]
        [TestCase(MethodAppendXmlFromString, 0)]
        public void AUT_XmlUtil_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (XmlUtil) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlUtil" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlUtil_Is_Static_Type_Present_Test()
        {
            // Assert
            _xmlUtilInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.GetRequiredNode(pParentNode, psXPath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetRequiredNode(pParentNode, psXPath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetRequiredNode = { pParentNode, psXPath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodGetRequiredNode, parametersOfGetRequiredNode, methodGetRequiredNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequiredNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequiredNode.ShouldNotBeNull();
            parametersOfGetRequiredNode.Length.ShouldBe(2);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetRequiredNode = { pParentNode, psXPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodGetRequiredNode, parametersOfGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            parametersOfGetRequiredNode.ShouldNotBeNull();
            parametersOfGetRequiredNode.Length.ShouldBe(2);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetRequiredNode_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetRequiredNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => XmlUtil.GetRequiredNode(pParentNode, psXPath, pNamespaceManager);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetRequiredNode(pParentNode, psXPath, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetRequiredNode = { pParentNode, psXPath, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodGetRequiredNode, parametersOfGetRequiredNode, methodGetRequiredNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequiredNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequiredNode.ShouldNotBeNull();
            parametersOfGetRequiredNode.Length.ShouldBe(3);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetRequiredNode = { pParentNode, psXPath, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodGetRequiredNode, parametersOfGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            parametersOfGetRequiredNode.ShouldNotBeNull();
            parametersOfGetRequiredNode.Length.ShouldBe(3);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var methodGetRequiredNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequiredNode, methodGetRequiredNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequiredNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNode_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNode, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRequiredNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.GetRequiredNodeValue(pParentNode, psXPath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetRequiredNodeValue(pParentNode, psXPath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetRequiredNodeValue = { pParentNode, psXPath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetRequiredNodeValue, parametersOfGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequiredNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequiredNodeValue.ShouldNotBeNull();
            parametersOfGetRequiredNodeValue.Length.ShouldBe(2);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetRequiredNodeValue = { pParentNode, psXPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRequiredNodeValue, parametersOfGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            parametersOfGetRequiredNodeValue.ShouldNotBeNull();
            parametersOfGetRequiredNodeValue.Length.ShouldBe(2);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetRequiredNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => XmlUtil.GetRequiredNodeValue(pParentNode, psXPath, pNamespaceManager);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetRequiredNodeValue(pParentNode, psXPath, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetRequiredNodeValue = { pParentNode, psXPath, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetRequiredNodeValue, parametersOfGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequiredNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequiredNodeValue.ShouldNotBeNull();
            parametersOfGetRequiredNodeValue.Length.ShouldBe(3);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetRequiredNodeValue = { pParentNode, psXPath, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRequiredNodeValue, parametersOfGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            parametersOfGetRequiredNodeValue.ShouldNotBeNull();
            parametersOfGetRequiredNodeValue.Length.ShouldBe(3);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var methodGetRequiredNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequiredNodeValue, methodGetRequiredNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequiredNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetRequiredNodeValue_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredNodeValue, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.GetNodeValue(pParentNode, psXPath, pbHandleNull, psDefaultValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetNodeValue(pParentNode, psXPath, pbHandleNull, psDefaultValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(bool), typeof(string) };
            object[] parametersOfGetNodeValue = { pParentNode, psXPath, pbHandleNull, psDefaultValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, methodGetNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(4);
            methodGetNodeValueParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(bool), typeof(string) };
            object[] parametersOfGetNodeValue = { pParentNode, psXPath, pbHandleNull, psDefaultValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(4);
            methodGetNodeValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(bool), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNodeValueParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(bool), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetNodeValue_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.GetNodeValue(pParentNode, psXPath, pNamespaceManager, pbHandleNull, psDefaultValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetNodeValue(pParentNode, psXPath, pNamespaceManager, pbHandleNull, psDefaultValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(bool), typeof(string) };
            object[] parametersOfGetNodeValue = { pParentNode, psXPath, pNamespaceManager, pbHandleNull, psDefaultValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, methodGetNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(5);
            methodGetNodeValueParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var pbHandleNull = this.CreateType<bool>();
            var psDefaultValue = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(bool), typeof(string) };
            object[] parametersOfGetNodeValue = { pParentNode, psXPath, pNamespaceManager, pbHandleNull, psDefaultValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(5);
            methodGetNodeValueParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(bool), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNodeValueParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(bool), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetNodeValue_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOrCreateNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.GetOrCreateNode(pParentNode, psXPath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetOrCreateNode(pParentNode, psXPath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetOrCreateNode = { pParentNode, psXPath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodGetOrCreateNode, parametersOfGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOrCreateNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOrCreateNode.ShouldNotBeNull();
            parametersOfGetOrCreateNode.Length.ShouldBe(2);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfGetOrCreateNode = { pParentNode, psXPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodGetOrCreateNode, parametersOfGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            parametersOfGetOrCreateNode.ShouldNotBeNull();
            parametersOfGetOrCreateNode.Length.ShouldBe(2);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_GetOrCreateNode_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetOrCreateNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => XmlUtil.GetOrCreateNode(pParentNode, psXPath, pNamespaceManager);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.GetOrCreateNode(pParentNode, psXPath, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetOrCreateNode = { pParentNode, psXPath, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodGetOrCreateNode, parametersOfGetOrCreateNode, methodGetOrCreateNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOrCreateNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOrCreateNode.ShouldNotBeNull();
            parametersOfGetOrCreateNode.Length.ShouldBe(3);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psXPath = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfGetOrCreateNode = { pParentNode, psXPath, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodGetOrCreateNode, parametersOfGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            parametersOfGetOrCreateNode.ShouldNotBeNull();
            parametersOfGetOrCreateNode.Length.ShouldBe(3);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var methodGetOrCreateNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOrCreateNode, methodGetOrCreateNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOrCreateNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_GetOrCreateNode_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateNode, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_AddChildNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodAddChildNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.AddChildNode(pParentNode, psNodeName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.AddChildNode(pParentNode, psNodeName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfAddChildNode = { pParentNode, psNodeName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, methodAddChildNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodAddChildNode, parametersOfAddChildNode, methodAddChildNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAddChildNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddChildNode.ShouldNotBeNull();
            parametersOfAddChildNode.Length.ShouldBe(2);
            methodAddChildNodeParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfAddChildNode = { pParentNode, psNodeName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodAddChildNode, parametersOfAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            parametersOfAddChildNode.ShouldNotBeNull();
            parametersOfAddChildNode.Length.ShouldBe(2);
            methodAddChildNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddChildNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddChildNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_AddChildNode_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodAddChildNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => XmlUtil.AddChildNode(pParentNode, psNodeName, pNamespaceManager);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.AddChildNode(pParentNode, psNodeName, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfAddChildNode = { pParentNode, psNodeName, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, methodAddChildNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodAddChildNode, parametersOfAddChildNode, methodAddChildNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAddChildNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddChildNode.ShouldNotBeNull();
            parametersOfAddChildNode.Length.ShouldBe(3);
            methodAddChildNodeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            object[] parametersOfAddChildNode = { pParentNode, psNodeName, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodAddChildNode, parametersOfAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            parametersOfAddChildNode.ShouldNotBeNull();
            parametersOfAddChildNode.Length.ShouldBe(3);
            methodAddChildNodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddChildNodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var methodAddChildNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddChildNode, methodAddChildNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddChildNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddChildNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AddChildNode_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddChildNode);
            var currentMethodInfo = this.GetMethodInfo(MethodAddChildNode, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetChildNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();

            // Act
            Action executeAction = () => XmlUtil.SetChildNodeValue(pParentNode, psNodeName, psValue, pbHandleNull);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.SetChildNodeValue(pParentNode, psNodeName, psValue, pbHandleNull);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfSetChildNodeValue = { pParentNode, psNodeName, psValue, pbHandleNull };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodSetChildNodeValue, parametersOfSetChildNodeValue, methodSetChildNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetChildNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSetChildNodeValue.ShouldNotBeNull();
            parametersOfSetChildNodeValue.Length.ShouldBe(4);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfSetChildNodeValue = { pParentNode, psNodeName, psValue, pbHandleNull };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodSetChildNodeValue, parametersOfSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            parametersOfSetChildNodeValue.ShouldNotBeNull();
            parametersOfSetChildNodeValue.Length.ShouldBe(4);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_SetChildNodeValue_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSetChildNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();

            // Act
            Action executeAction = () => XmlUtil.SetChildNodeValue(pParentNode, psNodeName, pNamespaceManager, psValue, pbHandleNull);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.SetChildNodeValue(pParentNode, psNodeName, pNamespaceManager, psValue, pbHandleNull);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(bool) };
            object[] parametersOfSetChildNodeValue = { pParentNode, psNodeName, pNamespaceManager, psValue, pbHandleNull };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodSetChildNodeValue, parametersOfSetChildNodeValue, methodSetChildNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetChildNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSetChildNodeValue.ShouldNotBeNull();
            parametersOfSetChildNodeValue.Length.ShouldBe(5);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var pParentNode = this.CreateType<XmlNode>();
            var psNodeName = this.CreateType<string>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var psValue = this.CreateType<string>();
            var pbHandleNull = this.CreateType<bool>();
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(bool) };
            object[] parametersOfSetChildNodeValue = { pParentNode, psNodeName, pNamespaceManager, psValue, pbHandleNull };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodSetChildNodeValue, parametersOfSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            parametersOfSetChildNodeValue.ShouldNotBeNull();
            parametersOfSetChildNodeValue.Length.ShouldBe(5);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var methodSetChildNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetChildNodeValue, methodSetChildNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetChildNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetChildNodeValue) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_SetChildNodeValue_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetChildNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetChildNodeValue, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_Internally(Type[] types)
        {
            var methodDateTimeToTimestampParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var pDateTime = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => XmlUtil.DateTimeToTimestamp(pDateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var pDateTime = this.CreateType<DateTime>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.DateTimeToTimestamp(pDateTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var pDateTime = this.CreateType<DateTime>();
            var methodDateTimeToTimestampParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfDateTimeToTimestamp = { pDateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDateTimeToTimestamp, parametersOfDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDateTimeToTimestamp.ShouldNotBeNull();
            parametersOfDateTimeToTimestamp.Length.ShouldBe(1);
            methodDateTimeToTimestampParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodDateTimeToTimestamp, parametersOfDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes));
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var pDateTime = this.CreateType<DateTime>();
            var methodDateTimeToTimestampParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfDateTimeToTimestamp = { pDateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDateTimeToTimestamp);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDateTimeToTimestamp.ShouldNotBeNull();
            parametersOfDateTimeToTimestamp.Length.ShouldBe(1);
            methodDateTimeToTimestampParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var pDateTime = this.CreateType<DateTime>();
            var methodDateTimeToTimestampParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfDateTimeToTimestamp = { pDateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDateTimeToTimestamp, parametersOfDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);

            // Assert
            parametersOfDateTimeToTimestamp.ShouldNotBeNull();
            parametersOfDateTimeToTimestamp.Length.ShouldBe(1);
            methodDateTimeToTimestampParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var methodDateTimeToTimestampParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDateTimeToTimestampParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var methodDateTimeToTimestampParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDateTimeToTimestamp, methodDateTimeToTimestampParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDateTimeToTimestampParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var currentMethodInfo = this.GetMethodInfo(MethodDateTimeToTimestamp, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DateTimeToTimestamp) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_DateTimeToTimestamp_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDateTimeToTimestamp);
            var currentMethodInfo = this.GetMethodInfo(MethodDateTimeToTimestamp, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_FormatGuid_Static_Method_Call_Internally(Type[] types)
        {
            var methodFormatGuidParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatGuid, methodFormatGuidParametersTypes);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var pGuid = this.CreateType<Guid>();

            // Act
            Action executeAction = () => XmlUtil.FormatGuid(pGuid);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var pGuid = this.CreateType<Guid>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.FormatGuid(pGuid);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var pGuid = this.CreateType<Guid>();
            var methodFormatGuidParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfFormatGuid = { pGuid };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatGuid, methodFormatGuidParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodFormatGuid, methodFormatGuidParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodFormatGuid, parametersOfFormatGuid, methodFormatGuidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFormatGuid.ShouldNotBeNull();
            parametersOfFormatGuid.Length.ShouldBe(1);
            methodFormatGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodFormatGuid, parametersOfFormatGuid, methodFormatGuidParametersTypes));
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var pGuid = this.CreateType<Guid>();
            var methodFormatGuidParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfFormatGuid = { pGuid };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatGuid, methodFormatGuidParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfFormatGuid);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatGuid.ShouldNotBeNull();
            parametersOfFormatGuid.Length.ShouldBe(1);
            methodFormatGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var pGuid = this.CreateType<Guid>();
            var methodFormatGuidParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfFormatGuid = { pGuid };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodFormatGuid, parametersOfFormatGuid, methodFormatGuidParametersTypes);

            // Assert
            parametersOfFormatGuid.ShouldNotBeNull();
            parametersOfFormatGuid.Length.ShouldBe(1);
            methodFormatGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var methodFormatGuidParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFormatGuid, methodFormatGuidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodFormatGuidParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var methodFormatGuidParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatGuid, methodFormatGuidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFormatGuidParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatGuid, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatGuid) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_FormatGuid_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatGuid);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatGuid, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_Internally(Type[] types)
        {
            var methodAppendXmlFromStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAppendXmlFromString, methodAppendXmlFromStringParametersTypes);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var pParentNode = this.CreateType<XmlNode>();
            var psXml = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlUtil.AppendXmlFromString(pParentNode, psXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var pParentNode = this.CreateType<XmlNode>();
            var psXml = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = XmlUtil.AppendXmlFromString(pParentNode, psXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var pParentNode = this.CreateType<XmlNode>();
            var psXml = this.CreateType<string>();
            var methodAppendXmlFromStringParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfAppendXmlFromString = { pParentNode, psXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendXmlFromString, methodAppendXmlFromStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAppendXmlFromString, methodAppendXmlFromStringParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodAppendXmlFromString, parametersOfAppendXmlFromString, methodAppendXmlFromStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAppendXmlFromString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAppendXmlFromString.ShouldNotBeNull();
            parametersOfAppendXmlFromString.Length.ShouldBe(2);
            methodAppendXmlFromStringParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var pParentNode = this.CreateType<XmlNode>();
            var psXml = this.CreateType<string>();
            var methodAppendXmlFromStringParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            object[] parametersOfAppendXmlFromString = { pParentNode, psXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodAppendXmlFromString, parametersOfAppendXmlFromString, methodAppendXmlFromStringParametersTypes);

            // Assert
            parametersOfAppendXmlFromString.ShouldNotBeNull();
            parametersOfAppendXmlFromString.Length.ShouldBe(2);
            methodAppendXmlFromStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var methodAppendXmlFromStringParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAppendXmlFromString, methodAppendXmlFromStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAppendXmlFromStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var methodAppendXmlFromStringParametersTypes = new Type[] { typeof(XmlNode), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendXmlFromString, methodAppendXmlFromStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAppendXmlFromStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendXmlFromString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AppendXmlFromString) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlUtil_AppendXmlFromString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendXmlFromString);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendXmlFromString, 0);
            const int parametersCount = 2;

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