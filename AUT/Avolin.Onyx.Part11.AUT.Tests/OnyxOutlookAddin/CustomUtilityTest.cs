using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CustomUtility" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomUtilityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomUtility" />)
        /// </summary>
        public CustomUtilityTest() : base(typeof(CustomUtility))
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

        #region General Initializer : Class (CustomUtility) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customUtilityInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CustomUtility" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customUtilityInstanceType = typeof(CustomUtility);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomUtility) Initializer

        #region Methods

        private const string MethodAppendNodes = "AppendNodes";
        private const string MethodGetOEPLauncherURL = "GetOEPLauncherURL";
        private const string MethodGetCurrentOutlookObject = "GetCurrentOutlookObject";
        private const string MethodGetCurrentMailItem = "GetCurrentMailItem";
        private const string MethodGetCurrentAppointmentItem = "GetCurrentAppointmentItem";
        private const string MethodGetCurrentContactItem = "GetCurrentContactItem";
        private const string MethodGetDescriptionFromParameterId = "GetDescriptionFromParameterId";
        private const string MethodGetLatestContactUsingFilter = "GetLatestContactUsingFilter";
        private const string MethodFindContactInOutlook = "FindContactInOutlook";
        private const string MethodCreateBasicMethodXML = "CreateBasicMethodXML";
        private const string MethodCreateGenericParamXML = "CreateGenericParamXML";
        private const string MethodappendParamList = "appendParamList";
        private const string MethodPopulateDropdownFromRetrieveList = "PopulateDropdownFromRetrieveList";
        private const string MethodGetOnyxEmailContactType = "GetOnyxEmailContactType";
        private const string MethodXmlEscape = "XmlEscape";
        private const string MethodSearchInString = "SearchInString";
        private const string MethodGetEmailAddressFromAddressEntry = "GetEmailAddressFromAddressEntry";

        #endregion

        #region Fields

        private const string FieldfileWriteLock = "fileWriteLock";
        private const string FieldPR_SMTP_ADDRESS = "PR_SMTP_ADDRESS";
        private const string FieldPR_ATTR_HIDDEN = "PR_ATTR_HIDDEN";
        private const string FieldSTR_TRUE = "STR_TRUE";

        #endregion

        #endregion

        #region General Initializer : Class (CustomUtility) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomUtility" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomUtility_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomUtility) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomUtility" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomUtility_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomUtility)

        #region General Initializer : Class (CustomUtility) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomUtility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAppendNodes, 0)]
        [TestCase(MethodGetOEPLauncherURL, 0)]
        [TestCase(MethodGetCurrentOutlookObject, 0)]
        [TestCase(MethodGetCurrentMailItem, 0)]
        [TestCase(MethodGetCurrentAppointmentItem, 0)]
        [TestCase(MethodGetCurrentContactItem, 0)]
        [TestCase(MethodGetDescriptionFromParameterId, 0)]
        [TestCase(MethodGetLatestContactUsingFilter, 0)]
        [TestCase(MethodFindContactInOutlook, 0)]
        [TestCase(MethodCreateBasicMethodXML, 0)]
        [TestCase(MethodCreateGenericParamXML, 0)]
        [TestCase(MethodappendParamList, 0)]
        [TestCase(MethodPopulateDropdownFromRetrieveList, 0)]
        [TestCase(MethodGetOnyxEmailContactType, 0)]
        [TestCase(MethodXmlEscape, 0)]
        [TestCase(MethodSearchInString, 0)]
        [TestCase(MethodGetEmailAddressFromAddressEntry, 0)]
        public void AUT_CustomUtility_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomUtility) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomUtility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldfileWriteLock)]
        [TestCase(FieldPR_SMTP_ADDRESS)]
        [TestCase(FieldPR_ATTR_HIDDEN)]
        [TestCase(FieldSTR_TRUE)]
        [Category("AUT Fields")]
        public void AUT_CustomUtility_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CustomUtility) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomUtility" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomUtility_Is_Static_Type_Present_Test()
        {
            // Assert
            _customUtilityInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String, String>>();
            var overWriteValues = this.CreateType<bool>();

            // Act
            Action executeAction = () => CustomUtility.AppendNodes(inputNode, nodeList, overWriteValues);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String, String>>();
            var overWriteValues = this.CreateType<bool>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.AppendNodes(inputNode, nodeList, overWriteValues);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String, String>>();
            var overWriteValues = this.CreateType<bool>();
            var methodAppendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(bool) };
            object[] parametersOfAppendNodes = { inputNode, nodeList, overWriteValues };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNodes, methodAppendNodesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodAppendNodes, methodAppendNodesParametersTypes);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodAppendNodes, parametersOfAppendNodes, methodAppendNodesParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAppendNodes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAppendNodes.ShouldNotBeNull();
            parametersOfAppendNodes.Length.ShouldBe(3);
            methodAppendNodesParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var inputNode = this.CreateType<XmlNode>();
            var nodeList = this.CreateType<Dictionary<String, String>>();
            var overWriteValues = this.CreateType<bool>();
            var methodAppendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(bool) };
            object[] parametersOfAppendNodes = { inputNode, nodeList, overWriteValues };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodAppendNodes, parametersOfAppendNodes, methodAppendNodesParametersTypes);

            // Assert
            parametersOfAppendNodes.ShouldNotBeNull();
            parametersOfAppendNodes.Length.ShouldBe(3);
            methodAppendNodesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var methodAppendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAppendNodes, methodAppendNodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAppendNodesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var methodAppendNodesParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendNodes, methodAppendNodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAppendNodesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNodes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AppendNodes) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_AppendNodes_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNodes);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNodes, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOEPLauncherURLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var launcherObjectType = this.CreateType<string>();
            var objectId = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.GetOEPLauncherURL(launcherObjectType, objectId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var launcherObjectType = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetOEPLauncherURL(launcherObjectType, objectId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var launcherObjectType = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var methodGetOEPLauncherURLParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfGetOEPLauncherURL = { launcherObjectType, objectId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodGetOEPLauncherURL, parametersOfGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOEPLauncherURL.ShouldNotBeNull();
            parametersOfGetOEPLauncherURL.Length.ShouldBe(2);
            methodGetOEPLauncherURLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodGetOEPLauncherURL, parametersOfGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes));
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var launcherObjectType = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var methodGetOEPLauncherURLParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfGetOEPLauncherURL = { launcherObjectType, objectId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOEPLauncherURL);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOEPLauncherURL.ShouldNotBeNull();
            parametersOfGetOEPLauncherURL.Length.ShouldBe(2);
            methodGetOEPLauncherURLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var launcherObjectType = this.CreateType<string>();
            var objectId = this.CreateType<string>();
            var methodGetOEPLauncherURLParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfGetOEPLauncherURL = { launcherObjectType, objectId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetOEPLauncherURL, parametersOfGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);

            // Assert
            parametersOfGetOEPLauncherURL.ShouldNotBeNull();
            parametersOfGetOEPLauncherURL.Length.ShouldBe(2);
            methodGetOEPLauncherURLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var methodGetOEPLauncherURLParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOEPLauncherURLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var methodGetOEPLauncherURLParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOEPLauncherURL, methodGetOEPLauncherURLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOEPLauncherURLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEPLauncherURL, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOEPLauncherURL) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOEPLauncherURL_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEPLauncherURL);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEPLauncherURL, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentOutlookObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);

            // Act
            Action executeAction = () => CustomUtility.GetCurrentOutlookObject();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            var returnedValue = default(Object);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetCurrentOutlookObject();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            Type [] methodGetCurrentOutlookObjectParametersTypes = null;
            object[] parametersOfGetCurrentOutlookObject = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);
            var result2 = this.GetResultOfMethod<Object>(MethodGetCurrentOutlookObject, parametersOfGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCurrentOutlookObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentOutlookObject.ShouldBeNull();
            methodGetCurrentOutlookObjectParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            Type [] methodGetCurrentOutlookObjectParametersTypes = null;
            object[] parametersOfGetCurrentOutlookObject = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Object>(MethodGetCurrentOutlookObject, parametersOfGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);

            // Assert
            parametersOfGetCurrentOutlookObject.ShouldBeNull();
            methodGetCurrentOutlookObjectParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            Type [] methodGetCurrentOutlookObjectParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentOutlookObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            Type [] methodGetCurrentOutlookObjectParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentOutlookObject, methodGetCurrentOutlookObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentOutlookObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentOutlookObject) (Return Type : Object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentOutlookObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentOutlookObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentOutlookObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentMailItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);

            // Act
            Action executeAction = () => CustomUtility.GetCurrentMailItem();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            var returnedValue = default(Outlook.MailItem);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetCurrentMailItem();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            Type [] methodGetCurrentMailItemParametersTypes = null;
            object[] parametersOfGetCurrentMailItem = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentMailItem, methodGetCurrentMailItemParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);
            var result2 = this.GetResultOfMethod<Outlook.MailItem>(MethodGetCurrentMailItem, parametersOfGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCurrentMailItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentMailItem.ShouldBeNull();
            methodGetCurrentMailItemParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            Type [] methodGetCurrentMailItemParametersTypes = null;
            object[] parametersOfGetCurrentMailItem = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.MailItem>(MethodGetCurrentMailItem, parametersOfGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);

            // Assert
            parametersOfGetCurrentMailItem.ShouldBeNull();
            methodGetCurrentMailItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            Type [] methodGetCurrentMailItemParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentMailItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            Type [] methodGetCurrentMailItemParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentMailItem, methodGetCurrentMailItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentMailItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentMailItem) (Return Type : Outlook.MailItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentMailItem_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentMailItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentMailItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentAppointmentItem) (Return Type : Outlook.AppointmentItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetCurrentAppointmentItem_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentAppointmentItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentAppointmentItem, methodGetCurrentAppointmentItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentAppointmentItem) (Return Type : Outlook.AppointmentItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentAppointmentItem_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAppointmentItem);

            // Act
            Action executeAction = () => CustomUtility.GetCurrentAppointmentItem();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentAppointmentItem) (Return Type : Outlook.AppointmentItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentAppointmentItem_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAppointmentItem);
            Type [] methodGetCurrentAppointmentItemParametersTypes = null;
            object[] parametersOfGetCurrentAppointmentItem = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.AppointmentItem>(MethodGetCurrentAppointmentItem, parametersOfGetCurrentAppointmentItem, methodGetCurrentAppointmentItemParametersTypes);

            // Assert
            parametersOfGetCurrentAppointmentItem.ShouldBeNull();
            methodGetCurrentAppointmentItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentAppointmentItem) (Return Type : Outlook.AppointmentItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentAppointmentItem_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAppointmentItem);
            Type [] methodGetCurrentAppointmentItemParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentAppointmentItem, methodGetCurrentAppointmentItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentAppointmentItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentAppointmentItem) (Return Type : Outlook.AppointmentItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentAppointmentItem_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAppointmentItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentAppointmentItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentContactItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);

            // Act
            Action executeAction = () => CustomUtility.GetCurrentContactItem();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            var returnedValue = default(Outlook.ContactItem);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetCurrentContactItem();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            Type [] methodGetCurrentContactItemParametersTypes = null;
            object[] parametersOfGetCurrentContactItem = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentContactItem, methodGetCurrentContactItemParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);
            var result2 = this.GetResultOfMethod<Outlook.ContactItem>(MethodGetCurrentContactItem, parametersOfGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCurrentContactItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentContactItem.ShouldBeNull();
            methodGetCurrentContactItemParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            Type [] methodGetCurrentContactItemParametersTypes = null;
            object[] parametersOfGetCurrentContactItem = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.ContactItem>(MethodGetCurrentContactItem, parametersOfGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);

            // Assert
            parametersOfGetCurrentContactItem.ShouldBeNull();
            methodGetCurrentContactItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            Type [] methodGetCurrentContactItemParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentContactItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            Type [] methodGetCurrentContactItemParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentContactItem, methodGetCurrentContactItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentContactItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentContactItem) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetCurrentContactItem_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentContactItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentContactItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDescriptionFromParameterIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => CustomUtility.GetDescriptionFromParameterId(id, oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetDescriptionFromParameterId(id, oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfGetDescriptionFromParameterId = { id, oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodGetDescriptionFromParameterId, parametersOfGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDescriptionFromParameterId);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDescriptionFromParameterId.ShouldNotBeNull();
            parametersOfGetDescriptionFromParameterId.Length.ShouldBe(2);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfGetDescriptionFromParameterId = { id, oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetDescriptionFromParameterId, parametersOfGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            parametersOfGetDescriptionFromParameterId.ShouldNotBeNull();
            parametersOfGetDescriptionFromParameterId.Length.ShouldBe(2);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetDescriptionFromParameterId_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetLatestContactUsingFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var FilterString = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.GetLatestContactUsingFilter(FilterString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var FilterString = this.CreateType<string>();
            var returnedValue = default(Outlook.ContactItem);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetLatestContactUsingFilter(FilterString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var FilterString = this.CreateType<string>();
            var methodGetLatestContactUsingFilterParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetLatestContactUsingFilter = { FilterString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);
            var result2 = this.GetResultOfMethod<Outlook.ContactItem>(MethodGetLatestContactUsingFilter, parametersOfGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetLatestContactUsingFilter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLatestContactUsingFilter.ShouldNotBeNull();
            parametersOfGetLatestContactUsingFilter.Length.ShouldBe(1);
            methodGetLatestContactUsingFilterParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var FilterString = this.CreateType<string>();
            var methodGetLatestContactUsingFilterParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetLatestContactUsingFilter = { FilterString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.ContactItem>(MethodGetLatestContactUsingFilter, parametersOfGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);

            // Assert
            parametersOfGetLatestContactUsingFilter.ShouldNotBeNull();
            parametersOfGetLatestContactUsingFilter.Length.ShouldBe(1);
            methodGetLatestContactUsingFilterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var methodGetLatestContactUsingFilterParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLatestContactUsingFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var methodGetLatestContactUsingFilterParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLatestContactUsingFilter, methodGetLatestContactUsingFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLatestContactUsingFilterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLatestContactUsingFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLatestContactUsingFilter) (Return Type : Outlook.ContactItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetLatestContactUsingFilter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLatestContactUsingFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLatestContactUsingFilter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_Internally(Type[] types)
        {
            var methodFindContactInOutlookParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFindContactInOutlook, methodFindContactInOutlookParametersTypes);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var email = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.FindContactInOutlook(email);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var email = this.CreateType<string>();
            var returnedValue = default(Outlook.ContactItem);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.FindContactInOutlook(email);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var email = this.CreateType<string>();
            var methodFindContactInOutlookParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfFindContactInOutlook = { email };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFindContactInOutlook, methodFindContactInOutlookParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodFindContactInOutlook, methodFindContactInOutlookParametersTypes);
            var result2 = this.GetResultOfMethod<Outlook.ContactItem>(MethodFindContactInOutlook, parametersOfFindContactInOutlook, methodFindContactInOutlookParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfFindContactInOutlook);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFindContactInOutlook.ShouldNotBeNull();
            parametersOfFindContactInOutlook.Length.ShouldBe(1);
            methodFindContactInOutlookParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var email = this.CreateType<string>();
            var methodFindContactInOutlookParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfFindContactInOutlook = { email };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.ContactItem>(MethodFindContactInOutlook, parametersOfFindContactInOutlook, methodFindContactInOutlookParametersTypes);

            // Assert
            parametersOfFindContactInOutlook.ShouldNotBeNull();
            parametersOfFindContactInOutlook.Length.ShouldBe(1);
            methodFindContactInOutlookParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var methodFindContactInOutlookParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindContactInOutlook, methodFindContactInOutlookParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindContactInOutlookParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var methodFindContactInOutlookParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindContactInOutlook, methodFindContactInOutlookParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindContactInOutlookParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var currentMethodInfo = this.GetMethodInfo(MethodFindContactInOutlook, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindContactInOutlook) (Return Type : Outlook.ContactItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_FindContactInOutlook_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindContactInOutlook);
            var currentMethodInfo = this.GetMethodInfo(MethodFindContactInOutlook, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateBasicMethodXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateBasicMethodXML, methodCreateBasicMethodXMLParametersTypes);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.CreateBasicMethodXML(paramList, objectName, methodType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBasicMethodXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.CreateBasicMethodXML(paramList, objectName, methodType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateBasicMethodXML) (Return Type : XmlDocument)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_With_No_Exception_Thrown_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CustomUtility_CreateBasicMethodXML_Static_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateGenericParamXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateGenericParamXML, methodCreateGenericParamXMLParametersTypes);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.CreateGenericParamXML(paramList, objectName, methodType);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateGenericParamXML);
            var paramList = this.CreateType<Hashtable>();
            var objectName = this.CreateType<string>();
            var methodType = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.CreateGenericParamXML(paramList, objectName, methodType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateGenericParamXML) (Return Type : XmlDocument)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_With_No_Exception_Thrown_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CustomUtility_CreateGenericParamXML_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (appendParamList) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_appendParamList_Static_Method_Call_Internally(Type[] types)
        {
            var methodappendParamListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappendParamList, methodappendParamListParametersTypes);
        }

        #endregion

        #region Method Call : (appendParamList) (Return Type : XmlNode) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_With_No_Exception_Thrown_Test()
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
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_CustomUtility_appendParamList_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_Internally(Type[] types)
        {
            var methodPopulateDropdownFromRetrieveListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateDropdownFromRetrieveList, methodPopulateDropdownFromRetrieveListParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var lbo = this.CreateType<string>();
            var inXml = this.CreateType<string>();
            var dropdownControl = this.CreateType<ComboBox>();
            var selectedValue = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.PopulateDropdownFromRetrieveList(lbo, inXml, dropdownControl, selectedValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var lbo = this.CreateType<string>();
            var inXml = this.CreateType<string>();
            var dropdownControl = this.CreateType<ComboBox>();
            var selectedValue = this.CreateType<string>();
            var methodPopulateDropdownFromRetrieveListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(ComboBox), typeof(String) };
            object[] parametersOfPopulateDropdownFromRetrieveList = { lbo, inXml, dropdownControl, selectedValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateDropdownFromRetrieveList, methodPopulateDropdownFromRetrieveListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfPopulateDropdownFromRetrieveList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateDropdownFromRetrieveList.ShouldNotBeNull();
            parametersOfPopulateDropdownFromRetrieveList.Length.ShouldBe(4);
            methodPopulateDropdownFromRetrieveListParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var lbo = this.CreateType<string>();
            var inXml = this.CreateType<string>();
            var dropdownControl = this.CreateType<ComboBox>();
            var selectedValue = this.CreateType<string>();
            var methodPopulateDropdownFromRetrieveListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(ComboBox), typeof(String) };
            object[] parametersOfPopulateDropdownFromRetrieveList = { lbo, inXml, dropdownControl, selectedValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateDropdownFromRetrieveList, parametersOfPopulateDropdownFromRetrieveList, methodPopulateDropdownFromRetrieveListParametersTypes);

            // Assert
            parametersOfPopulateDropdownFromRetrieveList.ShouldNotBeNull();
            parametersOfPopulateDropdownFromRetrieveList.Length.ShouldBe(4);
            methodPopulateDropdownFromRetrieveListParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateDropdownFromRetrieveList, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var methodPopulateDropdownFromRetrieveListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(ComboBox), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateDropdownFromRetrieveList, methodPopulateDropdownFromRetrieveListParametersTypes);

            // Assert
            methodPopulateDropdownFromRetrieveListParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateDropdownFromRetrieveList) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_PopulateDropdownFromRetrieveList_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateDropdownFromRetrieveList);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateDropdownFromRetrieveList, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxEmailContactTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxEmailContactType, methodGetOnyxEmailContactTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var rec = this.CreateType<Outlook.Recipient>();

            // Act
            Action executeAction = () => CustomUtility.GetOnyxEmailContactType(rec);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var rec = this.CreateType<Outlook.Recipient>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetOnyxEmailContactType(rec);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var rec = this.CreateType<Outlook.Recipient>();
            var methodGetOnyxEmailContactTypeParametersTypes = new Type[] { typeof(Outlook.Recipient) };
            object[] parametersOfGetOnyxEmailContactType = { rec };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetOnyxEmailContactType, parametersOfGetOnyxEmailContactType, methodGetOnyxEmailContactTypeParametersTypes);

            // Assert
            parametersOfGetOnyxEmailContactType.ShouldNotBeNull();
            parametersOfGetOnyxEmailContactType.Length.ShouldBe(1);
            methodGetOnyxEmailContactTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var methodGetOnyxEmailContactTypeParametersTypes = new Type[] { typeof(Outlook.Recipient) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxEmailContactType, methodGetOnyxEmailContactTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxEmailContactTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var methodGetOnyxEmailContactTypeParametersTypes = new Type[] { typeof(Outlook.Recipient) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxEmailContactType, methodGetOnyxEmailContactTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxEmailContactTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxEmailContactType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxEmailContactType) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetOnyxEmailContactType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxEmailContactType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxEmailContactType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_XmlEscape_Static_Method_Call_Internally(Type[] types)
        {
            var methodXmlEscapeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.XmlEscape(s);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.XmlEscape(s);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, methodXmlEscapeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes));
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, methodXmlEscapeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfXmlEscape);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodXmlEscapeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_XmlEscape_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_SearchInString_Static_Method_Call_Internally(Type[] types)
        {
            var methodSearchInStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSearchInString, methodSearchInStringParametersTypes);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var startPos = this.CreateType<int>();
            var startMatchString = this.CreateType<string>();
            var endMatchString = this.CreateType<string>();
            var response = this.CreateType<string>();

            // Act
            Action executeAction = () => CustomUtility.SearchInString(startPos, startMatchString, endMatchString, response);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var startPos = this.CreateType<int>();
            var startMatchString = this.CreateType<string>();
            var endMatchString = this.CreateType<string>();
            var response = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.SearchInString(startPos, startMatchString, endMatchString, response);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var startPos = this.CreateType<int>();
            var startMatchString = this.CreateType<string>();
            var endMatchString = this.CreateType<string>();
            var response = this.CreateType<string>();
            var methodSearchInStringParametersTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfSearchInString = { startPos, startMatchString, endMatchString, response };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSearchInString, methodSearchInStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSearchInString, methodSearchInStringParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodSearchInString, parametersOfSearchInString, methodSearchInStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSearchInString.ShouldNotBeNull();
            parametersOfSearchInString.Length.ShouldBe(4);
            methodSearchInStringParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodSearchInString, parametersOfSearchInString, methodSearchInStringParametersTypes));
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var startPos = this.CreateType<int>();
            var startMatchString = this.CreateType<string>();
            var endMatchString = this.CreateType<string>();
            var response = this.CreateType<string>();
            var methodSearchInStringParametersTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfSearchInString = { startPos, startMatchString, endMatchString, response };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSearchInString, methodSearchInStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSearchInString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSearchInString.ShouldNotBeNull();
            parametersOfSearchInString.Length.ShouldBe(4);
            methodSearchInStringParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var startPos = this.CreateType<int>();
            var startMatchString = this.CreateType<string>();
            var endMatchString = this.CreateType<string>();
            var response = this.CreateType<string>();
            var methodSearchInStringParametersTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfSearchInString = { startPos, startMatchString, endMatchString, response };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodSearchInString, parametersOfSearchInString, methodSearchInStringParametersTypes);

            // Assert
            parametersOfSearchInString.ShouldNotBeNull();
            parametersOfSearchInString.Length.ShouldBe(4);
            methodSearchInStringParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var methodSearchInStringParametersTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSearchInString, methodSearchInStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSearchInStringParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var methodSearchInStringParametersTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSearchInString, methodSearchInStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSearchInStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var currentMethodInfo = this.GetMethodInfo(MethodSearchInString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SearchInString) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_SearchInString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchInString);
            var currentMethodInfo = this.GetMethodInfo(MethodSearchInString, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailAddressFromAddressEntryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressFromAddressEntry, methodGetEmailAddressFromAddressEntryParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();

            // Act
            Action executeAction = () => CustomUtility.GetEmailAddressFromAddressEntry(addressEntry);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = CustomUtility.GetEmailAddressFromAddressEntry(addressEntry);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var methodGetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            object[] parametersOfGetEmailAddressFromAddressEntry = { addressEntry };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressFromAddressEntry, methodGetEmailAddressFromAddressEntryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEmailAddressFromAddressEntry);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEmailAddressFromAddressEntry.ShouldNotBeNull();
            parametersOfGetEmailAddressFromAddressEntry.Length.ShouldBe(1);
            methodGetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var methodGetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            object[] parametersOfGetEmailAddressFromAddressEntry = { addressEntry };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetEmailAddressFromAddressEntry, parametersOfGetEmailAddressFromAddressEntry, methodGetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            parametersOfGetEmailAddressFromAddressEntry.ShouldNotBeNull();
            parametersOfGetEmailAddressFromAddressEntry.Length.ShouldBe(1);
            methodGetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var methodGetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressFromAddressEntry, methodGetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var methodGetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressFromAddressEntry, methodGetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressFromAddressEntry, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailAddressFromAddressEntry) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomUtility_GetEmailAddressFromAddressEntry_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressFromAddressEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressFromAddressEntry, 0);
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