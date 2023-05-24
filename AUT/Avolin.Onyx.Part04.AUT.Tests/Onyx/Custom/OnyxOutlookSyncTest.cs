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
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxOutlookSync" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookSyncTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookSync" />)
        /// </summary>
        public OnyxOutlookSyncTest() : base(typeof(OnyxOutlookSync))
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

        #region General Initializer : Class (OnyxOutlookSync) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookSyncInstanceType;
        private OnyxOutlookSync _onyxOutlookSyncInstance;
        private OnyxOutlookSync _onyxOutlookSyncInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookSync" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookSyncInstanceType = typeof(OnyxOutlookSync);
            _onyxOutlookSyncInstanceFixture = this.Create<OnyxOutlookSync>(false);
            _onyxOutlookSyncInstance = _onyxOutlookSyncInstanceFixture ?? this.Create<OnyxOutlookSync>(true);
            CurrentInstance = _onyxOutlookSyncInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookSync) Initializer

        #region Methods

        private const string MethodOutlookSyncMain = "OutlookSyncMain";
        private const string MethodSetBaseComponentInfo = "SetBaseComponentInfo";
        private const string MethodExecute = "Execute";
        private const string MethodtoXelement = "toXelement";
        private const string MethodtoXmlNode = "toXmlNode";
        private const string MethodCheckReturnValue = "CheckReturnValue";
        private const string MethodSyncContact = "SyncContact";
        private const string MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch = "LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch";
        private const string MethodLBM_CetOutlookAddin_Retrieve_ListsConfig = "LBM_CetOutlookAddin_Retrieve_ListsConfig";

        #endregion

        #region Fields

        private const string FieldNAT_LANG_BASE_ID = "NAT_LANG_BASE_ID";
        private const string FieldLBO_OUTLOOKSYNC = "LBO_OUTLOOKSYNC";
        private const string FieldLBM_SYNC = "LBM_SYNC";
        private const string FieldLBM_RETRIEVE_COLLECTION_OUTLOOK_PROPS_TO_SYNC = "LBM_RETRIEVE_COLLECTION_OUTLOOK_PROPS_TO_SYNC";
        private const string FieldLBM_RETRIEVE_ADDIN_LISTS_CONFIGXML = "LBM_RETRIEVE_ADDIN_LISTS_CONFIGXML";
        private const string FieldonyxSession = "onyxSession";
        private const string FieldneedPostProcessing = "needPostProcessing";
        private const string FieldOUTLOOKCONTACTSYNC_ERROR_NUM = "OUTLOOKCONTACTSYNC_ERROR_NUM";
        private const string Fieldm_sComponentAndClassName = "m_sComponentAndClassName";
        private const string Fieldm_oParametersNode = "m_oParametersNode";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookSync) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSync" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookSync_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookSync) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSync" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookSync_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookSync)

        #region General Initializer : Class (OnyxOutlookSync) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSync" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOutlookSyncMain, 0)]
        [TestCase(MethodSetBaseComponentInfo, 0)]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodtoXelement, 0)]
        [TestCase(MethodtoXmlNode, 0)]
        [TestCase(MethodCheckReturnValue, 0)]
        [TestCase(MethodSyncContact, 0)]
        [TestCase(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, 0)]
        [TestCase(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, 0)]
        public void AUT_OnyxOutlookSync_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOutlookSync) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSync" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAT_LANG_BASE_ID)]
        [TestCase(FieldLBO_OUTLOOKSYNC)]
        [TestCase(FieldLBM_SYNC)]
        [TestCase(FieldLBM_RETRIEVE_COLLECTION_OUTLOOK_PROPS_TO_SYNC)]
        [TestCase(FieldLBM_RETRIEVE_ADDIN_LISTS_CONFIGXML)]
        [TestCase(FieldonyxSession)]
        [TestCase(FieldneedPostProcessing)]
        [TestCase(FieldOUTLOOKCONTACTSYNC_ERROR_NUM)]
        [TestCase(Fieldm_sComponentAndClassName)]
        [TestCase(Fieldm_oParametersNode)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookSync_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookSync) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSync" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookSync_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookSyncInstance.ShouldBeAssignableTo<OnyxOutlookSync>();
            _onyxOutlookSyncInstanceFixture.ShouldBeAssignableTo<OnyxOutlookSync>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookSync>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (OutlookSyncMain) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_OutlookSyncMain_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookSyncMain);
            Type [] methodOutlookSyncMainParametersTypes = null;
            object[] parametersOfOutlookSyncMain = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOutlookSyncMain, parametersOfOutlookSyncMain, methodOutlookSyncMainParametersTypes);

            // Assert
            parametersOfOutlookSyncMain.ShouldBeNull();
            methodOutlookSyncMainParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OutlookSyncMain) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_OutlookSyncMain_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookSyncMain);
            Type [] methodOutlookSyncMainParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOutlookSyncMain, methodOutlookSyncMainParametersTypes);

            // Assert
            methodOutlookSyncMainParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OutlookSyncMain) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_OutlookSyncMain_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookSyncMain);
            var currentMethodInfo = this.GetMethodInfo(MethodOutlookSyncMain, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetBaseComponentInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_SetBaseComponentInfo_Method_Call_Internally(Type[] types)
        {
            var methodSetBaseComponentInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetBaseComponentInfo, methodSetBaseComponentInfoParametersTypes);
        }

        #endregion

        #region Method Call : (SetBaseComponentInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SetBaseComponentInfo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetBaseComponentInfo);
            Type [] methodSetBaseComponentInfoParametersTypes = null;
            object[] parametersOfSetBaseComponentInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetBaseComponentInfo, parametersOfSetBaseComponentInfo, methodSetBaseComponentInfoParametersTypes);

            // Assert
            parametersOfSetBaseComponentInfo.ShouldBeNull();
            methodSetBaseComponentInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetBaseComponentInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SetBaseComponentInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetBaseComponentInfo);
            Type [] methodSetBaseComponentInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetBaseComponentInfo, methodSetBaseComponentInfoParametersTypes);

            // Assert
            methodSetBaseComponentInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetBaseComponentInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SetBaseComponentInfo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetBaseComponentInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodSetBaseComponentInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_Execute_Method_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psApplicationName = this.CreateType<string>();
            var psObjectName = this.CreateType<string>();
            var psMethodName = this.CreateType<string>();
            var psStepAdditionalData = this.CreateType<string>();
            var psStepPackageXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOutlookSyncInstance.Execute(psApplicationName, psObjectName, psMethodName, psStepAdditionalData, ref psStepPackageXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psApplicationName = this.CreateType<string>();
            var psObjectName = this.CreateType<string>();
            var psMethodName = this.CreateType<string>();
            var psStepAdditionalData = this.CreateType<string>();
            var psStepPackageXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookSyncInstance.Execute(psApplicationName, psObjectName, psMethodName, psStepAdditionalData, ref psStepPackageXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psApplicationName = this.CreateType<string>();
            var psObjectName = this.CreateType<string>();
            var psMethodName = this.CreateType<string>();
            var psStepAdditionalData = this.CreateType<string>();
            var psStepPackageXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { psApplicationName, psObjectName, psMethodName, psStepAdditionalData, psStepPackageXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOutlookSyncInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(5);
            methodExecuteParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psApplicationName = this.CreateType<string>();
            var psObjectName = this.CreateType<string>();
            var psMethodName = this.CreateType<string>();
            var psStepAdditionalData = this.CreateType<string>();
            var psStepPackageXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { psApplicationName, psObjectName, psMethodName, psStepAdditionalData, psStepPackageXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(5);
            methodExecuteParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_toXelement_Method_Call_Internally(Type[] types)
        {
            var methodtoXelementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtoXelement, methodtoXelementParametersTypes);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var node = this.CreateType<XmlNode>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookSyncInstance.toXelement(node);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var node = this.CreateType<XmlNode>();
            var methodtoXelementParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOftoXelement = { node };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodtoXelement, methodtoXelementParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_onyxOutlookSyncInstanceFixture, parametersOftoXelement);
            var result2 = this.GetResultOfMethod<XElement>(MethodtoXelement, parametersOftoXelement, methodtoXelementParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOftoXelement.ShouldNotBeNull();
            parametersOftoXelement.Length.ShouldBe(1);
            methodtoXelementParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var node = this.CreateType<XmlNode>();
            var methodtoXelementParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOftoXelement = { node };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodtoXelement, parametersOftoXelement, methodtoXelementParametersTypes);

            // Assert
            parametersOftoXelement.ShouldNotBeNull();
            parametersOftoXelement.Length.ShouldBe(1);
            methodtoXelementParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var methodtoXelementParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodtoXelement, methodtoXelementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodtoXelementParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var methodtoXelementParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtoXelement, methodtoXelementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodtoXelementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var currentMethodInfo = this.GetMethodInfo(MethodtoXelement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (toXelement) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXelement_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXelement);
            var currentMethodInfo = this.GetMethodInfo(MethodtoXelement, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (toXmlNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_toXmlNode_Method_Call_Internally(Type[] types)
        {
            var methodtoXmlNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtoXmlNode, methodtoXmlNodeParametersTypes);
        }

        #endregion

        #region Method Call : (toXmlNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXmlNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXmlNode);
            var element = this.CreateType<XElement>();
            var methodtoXmlNodeParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOftoXmlNode = { element };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodtoXmlNode, parametersOftoXmlNode, methodtoXmlNodeParametersTypes);

            // Assert
            parametersOftoXmlNode.ShouldNotBeNull();
            parametersOftoXmlNode.Length.ShouldBe(1);
            methodtoXmlNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (toXmlNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXmlNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXmlNode);
            var methodtoXmlNodeParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtoXmlNode, methodtoXmlNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodtoXmlNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (toXmlNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_toXmlNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtoXmlNode);
            var currentMethodInfo = this.GetMethodInfo(MethodtoXmlNode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_Internally(Type[] types)
        {
            var methodCheckReturnValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckReturnValue, methodCheckReturnValueParametersTypes);
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);

            // Act
            Action executeAction = () => _onyxOutlookSyncInstance.CheckReturnValue();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookSyncInstance.CheckReturnValue();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            Type [] methodCheckReturnValueParametersTypes = null;
            object[] parametersOfCheckReturnValue = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckReturnValue, methodCheckReturnValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOutlookSyncInstanceFixture, parametersOfCheckReturnValue);
            var result2 = this.GetResultOfMethod<string>(MethodCheckReturnValue, parametersOfCheckReturnValue, methodCheckReturnValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckReturnValue.ShouldBeNull();
            methodCheckReturnValueParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            Type [] methodCheckReturnValueParametersTypes = null;
            object[] parametersOfCheckReturnValue = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCheckReturnValue, parametersOfCheckReturnValue, methodCheckReturnValueParametersTypes);

            // Assert
            parametersOfCheckReturnValue.ShouldBeNull();
            methodCheckReturnValueParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            Type [] methodCheckReturnValueParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckReturnValue, methodCheckReturnValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckReturnValueParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            Type [] methodCheckReturnValueParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckReturnValue, methodCheckReturnValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckReturnValueParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckReturnValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_CheckReturnValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckReturnValue);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckReturnValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_SyncContact_Method_Call_Internally(Type[] types)
        {
            var methodSyncContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSyncContact, methodSyncContactParametersTypes);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodSyncContactParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfSyncContact = { poParamNode, poLBONode, poReturnNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, methodSyncContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, parametersOfSyncContact);
            var result2 = this.GetResultOfMethod<bool>(MethodSyncContact, parametersOfSyncContact, methodSyncContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSyncContact.ShouldNotBeNull();
            parametersOfSyncContact.Length.ShouldBe(3);
            methodSyncContactParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodSyncContactParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfSyncContact = { poParamNode, poLBONode, poReturnNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, methodSyncContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, out exception1, parametersOfSyncContact);
            var result2 = this.GetResultOfMethod<bool>(MethodSyncContact, parametersOfSyncContact, methodSyncContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSyncContact.ShouldNotBeNull();
            parametersOfSyncContact.Length.ShouldBe(3);
            methodSyncContactParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodSyncContactParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfSyncContact = { poParamNode, poLBONode, poReturnNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSyncContact, parametersOfSyncContact, methodSyncContactParametersTypes);

            // Assert
            parametersOfSyncContact.ShouldNotBeNull();
            parametersOfSyncContact.Length.ShouldBe(3);
            methodSyncContactParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var methodSyncContactParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSyncContact, methodSyncContactParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSyncContactParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_SyncContact_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_Internally(Type[] types)
        {
            var methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch = { poParamNode, poLBONode, poReturnNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var result2 = this.GetResultOfMethod<bool>(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.ShouldNotBeNull();
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.Length.ShouldBe(3);
            methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch = { poParamNode, poLBONode, poReturnNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, out exception1, parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var result2 = this.GetResultOfMethod<bool>(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.ShouldNotBeNull();
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.Length.ShouldBe(3);
            methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch = { poParamNode, poLBONode, poReturnNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes);

            // Assert
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.ShouldNotBeNull();
            parametersOfLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch.Length.ShouldBe(3);
            methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch);
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookSyncContact_RetrieveCollectionOutlookPropsToSynch, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_Internally(Type[] types)
        {
            var methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig = { poParamNode, poLBONode, poReturnNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var result2 = this.GetResultOfMethod<bool>(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.ShouldNotBeNull();
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.Length.ShouldBe(3);
            methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig = { poParamNode, poLBONode, poReturnNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOutlookSyncInstanceFixture, out exception1, parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var result2 = this.GetResultOfMethod<bool>(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.ShouldNotBeNull();
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.Length.ShouldBe(3);
            methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var poParamNode = this.CreateType<XmlNode>();
            var poLBONode = this.CreateType<XmlNode>();
            var poReturnNode = this.CreateType<XmlNode>();
            var methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig = { poParamNode, poLBONode, poReturnNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes);

            // Assert
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.ShouldNotBeNull();
            parametersOfLBM_CetOutlookAddin_Retrieve_ListsConfig.Length.ShouldBe(3);
            methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode), typeof(XmlNode) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLBM_CetOutlookAddin_Retrieve_ListsConfigParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBM_CetOutlookAddin_Retrieve_ListsConfig) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSync_LBM_CetOutlookAddin_Retrieve_ListsConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodLBM_CetOutlookAddin_Retrieve_ListsConfig, 0);
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