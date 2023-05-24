using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.Utility" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UtilityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Utility" />)
        /// </summary>
        public UtilityTest() : base(typeof(Utility))
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

        #region General Initializer : Class (Utility) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _utilityInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Utility" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _utilityInstanceType = typeof(Utility);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Utility) Initializer

        #region Methods

        private const string MethodcheckIfStringIsGuid = "checkIfStringIsGuid";
        private const string MethodappendNodes = "appendNodes";
        private const string MethodcheckIfInteger = "checkIfInteger";
        private const string MethodCreateBasicMethodXML = "CreateBasicMethodXML";
        private const string MethodCreateGenericParamXML = "CreateGenericParamXML";
        private const string MethodLogToOnyxLog = "LogToOnyxLog";
        private const string MethodappendParamList = "appendParamList";
        private const string MethodconvertDateTimeBasedOnTZ = "convertDateTimeBasedOnTZ";
        private const string MethodSerializeObject = "SerializeObject";
        private const string MethodgetSystemParameterValue = "getSystemParameterValue";

        #endregion

        #region Fields

        private const string FielddigitsOnly = "digitsOnly";

        #endregion

        #endregion

        #region General Initializer : Class (Utility) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utility_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Utility) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utility_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Utility)

        #region General Initializer : Class (Utility) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodcheckIfStringIsGuid, 0)]
        [TestCase(MethodappendNodes, 0)]
        [TestCase(MethodcheckIfInteger, 0)]
        [TestCase(MethodCreateBasicMethodXML, 0)]
        [TestCase(MethodCreateGenericParamXML, 0)]
        [TestCase(MethodLogToOnyxLog, 0)]
        [TestCase(MethodappendParamList, 0)]
        [TestCase(MethodconvertDateTimeBasedOnTZ, 0)]
        [TestCase(MethodSerializeObject, 0)]
        [TestCase(MethodgetSystemParameterValue, 0)]
        public void AUT_Utility_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Utility) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FielddigitsOnly)]
        [Category("AUT Fields")]
        public void AUT_Utility_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Utility) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Utility" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Utility_Is_Static_Type_Present_Test()
        {
            // Assert
            _utilityInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var s = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.checkIfStringIsGuid(s);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var s = this.CreateType<string>();
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfStringIsGuid = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);
            var result2 = this.GetResultOfMethod<Boolean>(MethodcheckIfStringIsGuid, parametersOfcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfcheckIfStringIsGuid.ShouldNotBeNull();
            parametersOfcheckIfStringIsGuid.Length.ShouldBe(1);
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Boolean>(MethodcheckIfStringIsGuid, parametersOfcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes));
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var s = this.CreateType<string>();
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfStringIsGuid = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfcheckIfStringIsGuid);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcheckIfStringIsGuid.ShouldNotBeNull();
            parametersOfcheckIfStringIsGuid.Length.ShouldBe(1);
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var s = this.CreateType<string>();
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfStringIsGuid = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Boolean>(MethodcheckIfStringIsGuid, parametersOfcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);

            // Assert
            parametersOfcheckIfStringIsGuid.ShouldNotBeNull();
            parametersOfcheckIfStringIsGuid.Length.ShouldBe(1);
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var methodcheckIfStringIsGuidParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcheckIfStringIsGuid, methodcheckIfStringIsGuidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodcheckIfStringIsGuidParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfStringIsGuid, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (checkIfStringIsGuid) (Return Type : Boolean) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfStringIsGuid_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfStringIsGuid);
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfStringIsGuid, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_appendNodes_Static_Method_Call_Internally(Type[] types)
        {
            var methodappendNodesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappendNodes, methodappendNodesParametersTypes);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String,String>>();
            var overWriteValues = this.CreateType<bool>();

            // Act
            Action executeAction = () => Utility.appendNodes(inputNode, nodeList, overWriteValues);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String,String>>();
            var overWriteValues = this.CreateType<bool>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = Utility.appendNodes(inputNode, nodeList, overWriteValues);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String,String>>();
            var overWriteValues = this.CreateType<bool>();
            var methodappendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String,String>), typeof(bool) };
            object[] parametersOfappendNodes = { inputNode, nodeList, overWriteValues };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodappendNodes, methodappendNodesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodappendNodes, methodappendNodesParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodappendNodes, parametersOfappendNodes, methodappendNodesParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfappendNodes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfappendNodes.ShouldNotBeNull();
            parametersOfappendNodes.Length.ShouldBe(3);
            methodappendNodesParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String,String>>();
            var overWriteValues = this.CreateType<bool>();
            var methodappendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String,String>), typeof(bool) };
            object[] parametersOfappendNodes = { inputNode, nodeList, overWriteValues };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodappendNodes, parametersOfappendNodes, methodappendNodesParametersTypes);

            // Assert
            parametersOfappendNodes.ShouldNotBeNull();
            parametersOfappendNodes.Length.ShouldBe(3);
            methodappendNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var methodappendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String,String>), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodappendNodes, methodappendNodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodappendNodesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var methodappendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String,String>), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodappendNodes, methodappendNodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodappendNodesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var currentMethodInfo = this.GetMethodInfo(MethodappendNodes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (appendNodes) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendNodes_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendNodes);
            var currentMethodInfo = this.GetMethodInfo(MethodappendNodes, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_checkIfInteger_Static_Method_Call_Internally(Type[] types)
        {
            var methodcheckIfIntegerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var s = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.checkIfInteger(s);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var s = this.CreateType<string>();
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfInteger = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodcheckIfInteger, parametersOfcheckIfInteger, methodcheckIfIntegerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfcheckIfInteger.ShouldNotBeNull();
            parametersOfcheckIfInteger.Length.ShouldBe(1);
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodcheckIfInteger, parametersOfcheckIfInteger, methodcheckIfIntegerParametersTypes));
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var s = this.CreateType<string>();
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfInteger = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfcheckIfInteger);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcheckIfInteger.ShouldNotBeNull();
            parametersOfcheckIfInteger.Length.ShouldBe(1);
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var s = this.CreateType<string>();
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfcheckIfInteger = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodcheckIfInteger, parametersOfcheckIfInteger, methodcheckIfIntegerParametersTypes);

            // Assert
            parametersOfcheckIfInteger.ShouldNotBeNull();
            parametersOfcheckIfInteger.Length.ShouldBe(1);
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var methodcheckIfIntegerParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcheckIfInteger, methodcheckIfIntegerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodcheckIfIntegerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfInteger, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (checkIfInteger) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_checkIfInteger_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckIfInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodcheckIfInteger, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateBasicMethodXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.CreateBasicMethodXML(paramList, objectName, methodType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = Utility.CreateBasicMethodXML(paramList, objectName, methodType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateBasicMethodXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateBasicMethodXML = { paramList, objectName, methodType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodCreateBasicMethodXML, parametersOfCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateBasicMethodXML.ShouldNotBeNull();
            parametersOfCreateBasicMethodXML.Length.ShouldBe(3);
            methodCreateBasicMethodXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<XmlDocument>(MethodCreateBasicMethodXML, parametersOfCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes));
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateBasicMethodXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateBasicMethodXML = { paramList, objectName, methodType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateBasicMethodXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateBasicMethodXML.ShouldNotBeNull();
            parametersOfCreateBasicMethodXML.Length.ShouldBe(3);
            methodCreateBasicMethodXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateBasicMethodXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateBasicMethodXML = { paramList, objectName, methodType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodCreateBasicMethodXML, parametersOfCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);

            // Assert
            parametersOfCreateBasicMethodXML.ShouldNotBeNull();
            parametersOfCreateBasicMethodXML.Length.ShouldBe(3);
            methodCreateBasicMethodXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var methodCreateBasicMethodXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateBasicMethodXMLParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var methodCreateBasicMethodXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateBasicMethodXMLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBasicMethodXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateBasicMethodXML_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBasicMethodXML, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_CreateGenericParamXML_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateGenericParamXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.CreateGenericParamXML(paramList, objectName, methodType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = Utility.CreateGenericParamXML(paramList, objectName, methodType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateGenericParamXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateGenericParamXML = { paramList, objectName, methodType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodCreateGenericParamXML, parametersOfCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateGenericParamXML.ShouldNotBeNull();
            parametersOfCreateGenericParamXML.Length.ShouldBe(3);
            methodCreateGenericParamXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<XmlDocument>(MethodCreateGenericParamXML, parametersOfCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes));
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateGenericParamXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateGenericParamXML = { paramList, objectName, methodType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateGenericParamXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateGenericParamXML.ShouldNotBeNull();
            parametersOfCreateGenericParamXML.Length.ShouldBe(3);
            methodCreateGenericParamXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var methodCreateGenericParamXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            object[] parametersOfCreateGenericParamXML = { paramList, objectName, methodType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodCreateGenericParamXML, parametersOfCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);

            // Assert
            parametersOfCreateGenericParamXML.ShouldNotBeNull();
            parametersOfCreateGenericParamXML.Length.ShouldBe(3);
            methodCreateGenericParamXMLParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var methodCreateGenericParamXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateGenericParamXMLParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var methodCreateGenericParamXMLParametersTypes = new Type[] { typeof(Hashtable), typeof(String), typeof(String) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateGenericParamXMLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateGenericParamXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_CreateGenericParamXML_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateGenericParamXML, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_LogToOnyxLog_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogToOnyxLogParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogToOnyxLog, methodLogToOnyxLogParametersTypes);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var source = this.CreateType<string>();
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.LogToOnyxLog(source, message);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var source = this.CreateType<string>();
            var message = this.CreateType<string>();
            var methodLogToOnyxLogParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfLogToOnyxLog = { source, message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogToOnyxLog, methodLogToOnyxLogParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogToOnyxLog);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogToOnyxLog.ShouldNotBeNull();
            parametersOfLogToOnyxLog.Length.ShouldBe(2);
            methodLogToOnyxLogParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var source = this.CreateType<string>();
            var message = this.CreateType<string>();
            var methodLogToOnyxLogParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfLogToOnyxLog = { source, message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogToOnyxLog, parametersOfLogToOnyxLog, methodLogToOnyxLogParametersTypes);

            // Assert
            parametersOfLogToOnyxLog.ShouldNotBeNull();
            parametersOfLogToOnyxLog.Length.ShouldBe(2);
            methodLogToOnyxLogParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var currentMethodInfo = this.GetMethodInfo(MethodLogToOnyxLog, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var methodLogToOnyxLogParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogToOnyxLog, methodLogToOnyxLogParametersTypes);

            // Assert
            methodLogToOnyxLogParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogToOnyxLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_LogToOnyxLog_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogToOnyxLog);
            var currentMethodInfo = this.GetMethodInfo(MethodLogToOnyxLog, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_appendParamList_Static_Method_Call_Internally(Type[] types)
        {
            var methodappendParamListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappendParamList, methodappendParamListParametersTypes);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var paramList = this.CreateType<Hashtable>();
            var paramDoc = this.CreateType<XmlDocument>();
            var parentNode = this.CreateType<XmlNode>();
            var methodappendParamListParametersTypes = new Type[] { typeof(Hashtable), typeof(XmlDocument), typeof(XmlNode) };
            object[] parametersOfappendParamList = { paramList, paramDoc, parentNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodappendParamList, methodappendParamListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfappendParamList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfappendParamList.ShouldNotBeNull();
            parametersOfappendParamList.Length.ShouldBe(3);
            methodappendParamListParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var paramList = this.CreateType<Hashtable>();
            var paramDoc = this.CreateType<XmlDocument>();
            var parentNode = this.CreateType<XmlNode>();
            var methodappendParamListParametersTypes = new Type[] { typeof(Hashtable), typeof(XmlDocument), typeof(XmlNode) };
            object[] parametersOfappendParamList = { paramList, paramDoc, parentNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodappendParamList, parametersOfappendParamList, methodappendParamListParametersTypes);

            // Assert
            parametersOfappendParamList.ShouldNotBeNull();
            parametersOfappendParamList.Length.ShouldBe(3);
            methodappendParamListParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var methodappendParamListParametersTypes = new Type[] { typeof(Hashtable), typeof(XmlDocument), typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodappendParamList, methodappendParamListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodappendParamListParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var methodappendParamListParametersTypes = new Type[] { typeof(Hashtable), typeof(XmlDocument), typeof(XmlNode) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodappendParamList, methodappendParamListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodappendParamListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var currentMethodInfo = this.GetMethodInfo(MethodappendParamList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_appendParamList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappendParamList);
            var currentMethodInfo = this.GetMethodInfo(MethodappendParamList, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_Internally(Type[] types)
        {
            var methodconvertDateTimeBasedOnTZParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var inDateTime = this.CreateType<string>();
            var inputTZ = this.CreateType<string>();
            var outputTZ = this.CreateType<string>();
            var outDateFormat = this.CreateType<string>();

            // Act
            Action executeAction = () => Utility.convertDateTimeBasedOnTZ(inDateTime, inputTZ, outputTZ, outDateFormat);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var inDateTime = this.CreateType<string>();
            var inputTZ = this.CreateType<string>();
            var outputTZ = this.CreateType<string>();
            var outDateFormat = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Utility.convertDateTimeBasedOnTZ(inDateTime, inputTZ, outputTZ, outDateFormat);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var inDateTime = this.CreateType<string>();
            var inputTZ = this.CreateType<string>();
            var outputTZ = this.CreateType<string>();
            var outDateFormat = this.CreateType<string>();
            var methodconvertDateTimeBasedOnTZParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfconvertDateTimeBasedOnTZ = { inDateTime, inputTZ, outputTZ, outDateFormat };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodconvertDateTimeBasedOnTZ, parametersOfconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfconvertDateTimeBasedOnTZ);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertDateTimeBasedOnTZ.ShouldNotBeNull();
            parametersOfconvertDateTimeBasedOnTZ.Length.ShouldBe(4);
            methodconvertDateTimeBasedOnTZParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var inDateTime = this.CreateType<string>();
            var inputTZ = this.CreateType<string>();
            var outputTZ = this.CreateType<string>();
            var outDateFormat = this.CreateType<string>();
            var methodconvertDateTimeBasedOnTZParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfconvertDateTimeBasedOnTZ = { inDateTime, inputTZ, outputTZ, outDateFormat };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodconvertDateTimeBasedOnTZ, parametersOfconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);

            // Assert
            parametersOfconvertDateTimeBasedOnTZ.ShouldNotBeNull();
            parametersOfconvertDateTimeBasedOnTZ.Length.ShouldBe(4);
            methodconvertDateTimeBasedOnTZParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var methodconvertDateTimeBasedOnTZParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertDateTimeBasedOnTZParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var methodconvertDateTimeBasedOnTZParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(String) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertDateTimeBasedOnTZ, methodconvertDateTimeBasedOnTZParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertDateTimeBasedOnTZParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertDateTimeBasedOnTZ, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertDateTimeBasedOnTZ) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_convertDateTimeBasedOnTZ_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertDateTimeBasedOnTZ);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertDateTimeBasedOnTZ, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_SerializeObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodSerializeObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSerializeObject, methodSerializeObjectParametersTypes);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var objName = this.CreateType<Object>();

            // Act
            Action executeAction = () => Utility.SerializeObject(objName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var objName = this.CreateType<Object>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Utility.SerializeObject(objName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var objName = this.CreateType<Object>();
            var methodSerializeObjectParametersTypes = new Type[] { typeof(Object) };
            object[] parametersOfSerializeObject = { objName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSerializeObject, methodSerializeObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSerializeObject, methodSerializeObjectParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodSerializeObject, parametersOfSerializeObject, methodSerializeObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSerializeObject.ShouldNotBeNull();
            parametersOfSerializeObject.Length.ShouldBe(1);
            methodSerializeObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodSerializeObject, parametersOfSerializeObject, methodSerializeObjectParametersTypes));
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var objName = this.CreateType<Object>();
            var methodSerializeObjectParametersTypes = new Type[] { typeof(Object) };
            object[] parametersOfSerializeObject = { objName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSerializeObject, methodSerializeObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSerializeObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSerializeObject.ShouldNotBeNull();
            parametersOfSerializeObject.Length.ShouldBe(1);
            methodSerializeObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var objName = this.CreateType<Object>();
            var methodSerializeObjectParametersTypes = new Type[] { typeof(Object) };
            object[] parametersOfSerializeObject = { objName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodSerializeObject, parametersOfSerializeObject, methodSerializeObjectParametersTypes);

            // Assert
            parametersOfSerializeObject.ShouldNotBeNull();
            parametersOfSerializeObject.Length.ShouldBe(1);
            methodSerializeObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var methodSerializeObjectParametersTypes = new Type[] { typeof(Object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSerializeObject, methodSerializeObjectParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSerializeObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var methodSerializeObjectParametersTypes = new Type[] { typeof(Object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSerializeObject, methodSerializeObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSerializeObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var currentMethodInfo = this.GetMethodInfo(MethodSerializeObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SerializeObject) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SerializeObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSerializeObject);
            var currentMethodInfo = this.GetMethodInfo(MethodSerializeObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_getSystemParameterValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodgetSystemParameterValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var code = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => Utility.getSystemParameterValue(code, oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var code = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Utility.getSystemParameterValue(code, oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var code = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodgetSystemParameterValueParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfgetSystemParameterValue = { code, oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetSystemParameterValue, methodgetSystemParameterValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodgetSystemParameterValue, parametersOfgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfgetSystemParameterValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetSystemParameterValue.ShouldNotBeNull();
            parametersOfgetSystemParameterValue.Length.ShouldBe(2);
            methodgetSystemParameterValueParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var code = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodgetSystemParameterValueParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfgetSystemParameterValue = { code, oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetSystemParameterValue, parametersOfgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);

            // Assert
            parametersOfgetSystemParameterValue.ShouldNotBeNull();
            parametersOfgetSystemParameterValue.Length.ShouldBe(2);
            methodgetSystemParameterValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var methodgetSystemParameterValueParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetSystemParameterValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var methodgetSystemParameterValueParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetSystemParameterValue, methodgetSystemParameterValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetSystemParameterValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetSystemParameterValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getSystemParameterValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_getSystemParameterValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSystemParameterValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetSystemParameterValue, 0);
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