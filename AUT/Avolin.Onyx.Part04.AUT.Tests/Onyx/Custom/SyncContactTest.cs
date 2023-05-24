using System;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.SyncContact" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SyncContactTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SyncContact" />)
        /// </summary>
        public SyncContactTest() : base(typeof(SyncContact))
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

        #region General Initializer : Class (SyncContact) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _syncContactInstanceType;
        private SyncContact _syncContactInstance;
        private SyncContact _syncContactInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SyncContact" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _syncContactInstanceType = typeof(SyncContact);
            _syncContactInstanceFixture = this.Create<SyncContact>(false);
            _syncContactInstance = _syncContactInstanceFixture ?? this.Create<SyncContact>(true);
            CurrentInstance = _syncContactInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SyncContact) Initializer

        #region Properties

        private const string PropertyItemExistsInOnyx = "ItemExistsInOnyx";
        private const string PropertygetIndividualNode = "getIndividualNode";
        private const string PropertyPrimaryId = "PrimaryId";

        #endregion

        #region Methods

        private const string Methodsync = "sync";
        private const string MethodgetOnyxUpdateDate = "getOnyxUpdateDate";
        private const string MethodretrieveIndividualDataForBISync = "retrieveIndividualDataForBISync";
        private const string MethodretrieveFromOnyxSyncTable = "retrieveFromOnyxSyncTable";
        private const string MethodupdateOnyxSyncTableLastSyncDate = "updateOnyxSyncTableLastSyncDate";
        private const string MethodinsertAssociationIntoOnyx = "insertAssociationIntoOnyx";
        private const string MethodlocateMatchingCustomer = "locateMatchingCustomer";

        #endregion

        #region Fields

        private const string FieldprimaryId = "primaryId";
        private const string FieldsyncDirection = "syncDirection";
        private const string FieldmasterSystem = "masterSystem";
        private const string FieldsyncByUser = "syncByUser";
        private const string FieldoutlookContactId = "outlookContactId";
        private const string FieldonyxCustomerId = "onyxCustomerId";
        private const string FieldonyxCustomerTypeEnum = "onyxCustomerTypeEnum";
        private const string Fielddata = "data";
        private const string FieldoutlookContactUpdateDate = "outlookContactUpdateDate";
        private const string FieldonyxTimestamp = "onyxTimestamp";
        private const string FieldisExists = "isExists";
        private const string FieldIndividualNode = "IndividualNode";
        private const string FieldwinningSystem = "winningSystem";
        private const string FieldonyxCustomerUpdateDate = "onyxCustomerUpdateDate";
        private const string FielderrorMessageList = "errorMessageList";
        private const string FieldoSessionVar = "oSessionVar";
        private const string FieldNOMATCHCUSTOMER_ERROR_NUM = "NOMATCHCUSTOMER_ERROR_NUM";
        private const string FieldINSERTSYNC_ERROR_NUM = "INSERTSYNC_ERROR_NUM";
        private const string FieldLOCATMATCHINGCUSTOMER_ERROR_NUM = "LOCATMATCHINGCUSTOMER_ERROR_NUM";
        private const string FieldLATESTUPDATEDATE_ERROR_NUM = "LATESTUPDATEDATE_ERROR_NUM";
        private const string FieldRETRIEVEONYXSYNC_ERROR_NUM = "RETRIEVEONYXSYNC_ERROR_NUM";
        private const string FieldUPDATELASTSYNCDATE_ERROR_NUM = "UPDATELASTSYNCDATE_ERROR_NUM";
        private const string FieldSYNCMETHODFAILED_ERROR_NUM = "SYNCMETHODFAILED_ERROR_NUM";
        private const string FieldnatLangMessageText = "natLangMessageText";
        private const string FieldoNatLang = "oNatLang";
        private const string FieldinputValues = "inputValues";

        #endregion

        #endregion

        #region General Initializer : Class (SyncContact) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SyncContact_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SyncContact) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SyncContact_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SyncContact) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SyncContact_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SyncContact)

        #region General Initializer : Class (SyncContact) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Methodsync, 0)]
        [TestCase(MethodgetOnyxUpdateDate, 0)]
        [TestCase(MethodretrieveIndividualDataForBISync, 0)]
        [TestCase(MethodretrieveFromOnyxSyncTable, 0)]
        [TestCase(MethodupdateOnyxSyncTableLastSyncDate, 0)]
        [TestCase(MethodinsertAssociationIntoOnyx, 0)]
        [TestCase(MethodlocateMatchingCustomer, 0)]
        public void AUT_SyncContact_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SyncContact) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertygetIndividualNode)]
        [TestCase(PropertyPrimaryId)]
        [Category("AUT Property")]
        public void AUT_SyncContact_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SyncContact) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SyncContact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldprimaryId)]
        [TestCase(FieldsyncDirection)]
        [TestCase(FieldmasterSystem)]
        [TestCase(FieldsyncByUser)]
        [TestCase(FieldoutlookContactId)]
        [TestCase(FieldonyxCustomerId)]
        [TestCase(FieldonyxCustomerTypeEnum)]
        [TestCase(Fielddata)]
        [TestCase(FieldoutlookContactUpdateDate)]
        [TestCase(FieldonyxTimestamp)]
        [TestCase(FieldisExists)]
        [TestCase(FieldIndividualNode)]
        [TestCase(FieldwinningSystem)]
        [TestCase(FieldonyxCustomerUpdateDate)]
        [TestCase(FielderrorMessageList)]
        [TestCase(FieldoSessionVar)]
        [TestCase(FieldNOMATCHCUSTOMER_ERROR_NUM)]
        [TestCase(FieldINSERTSYNC_ERROR_NUM)]
        [TestCase(FieldLOCATMATCHINGCUSTOMER_ERROR_NUM)]
        [TestCase(FieldLATESTUPDATEDATE_ERROR_NUM)]
        [TestCase(FieldRETRIEVEONYXSYNC_ERROR_NUM)]
        [TestCase(FieldUPDATELASTSYNCDATE_ERROR_NUM)]
        [TestCase(FieldSYNCMETHODFAILED_ERROR_NUM)]
        [TestCase(FieldnatLangMessageText)]
        [TestCase(FieldoNatLang)]
        [TestCase(FieldinputValues)]
        [Category("AUT Fields")]
        public void AUT_SyncContact_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SyncContact) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SyncContact" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SyncContact_Is_Instance_Present_Test()
        {
            // Assert
            _syncContactInstanceType.ShouldNotBeNull();
            _syncContactInstance.ShouldNotBeNull();
            _syncContactInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SyncContact) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SyncContact" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SyncContact_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _syncContactInstance.ShouldBeAssignableTo<SyncContact>();
            _syncContactInstanceFixture.ShouldBeAssignableTo<SyncContact>();
            CurrentInstance.ShouldBeAssignableTo<SyncContact>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SyncContact) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SyncContact_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SyncContact instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SyncContact) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertygetIndividualNode)]
        [TestCase(PropertyPrimaryId)]
        public void AUT_SyncContact_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SyncContact) => Property (getIndividualNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SyncContact_getIndividualNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertygetIndividualNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertygetIndividualNode);
            Action currentAction = () => propertyInfo.SetValue(_syncContactInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SyncContact) => Property (getIndividualNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SyncContact_Public_Class_getIndividualNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertygetIndividualNode);
            var propertyInfo = this.GetPropertyInfo(PropertygetIndividualNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SyncContact) => Property (ItemExistsInOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SyncContact_Public_Class_ItemExistsInOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemExistsInOnyx);
            var propertyInfo = this.GetPropertyInfo(PropertyItemExistsInOnyx);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SyncContact) => Property (PrimaryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SyncContact_PrimaryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);
            Action currentAction = () => propertyInfo.SetValue(_syncContactInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SyncContact) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SyncContact_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

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

        #region Method Call : (sync) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var poLBONode = this.CreateType<XmlNode>();
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => _syncContactInstance.sync(poLBONode, oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var poLBONode = this.CreateType<XmlNode>();
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _syncContactInstance.sync(poLBONode, oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var poLBONode = this.CreateType<XmlNode>();
            var oSession = this.CreateType<OnyxSession>();
            var methodsyncParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };
            object[] parametersOfsync = { poLBONode, oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(Methodsync, methodsyncParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_syncContactInstanceFixture, parametersOfsync);
            var result2 = this.GetResultOfMethod<XmlNode>(Methodsync, parametersOfsync, methodsyncParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfsync.ShouldNotBeNull();
            parametersOfsync.Length.ShouldBe(2);
            methodsyncParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var poLBONode = this.CreateType<XmlNode>();
            var oSession = this.CreateType<OnyxSession>();
            var methodsyncParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };
            object[] parametersOfsync = { poLBONode, oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(Methodsync, parametersOfsync, methodsyncParametersTypes);

            // Assert
            parametersOfsync.ShouldNotBeNull();
            parametersOfsync.Length.ShouldBe(2);
            methodsyncParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var methodsyncParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(Methodsync, methodsyncParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodsyncParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var methodsyncParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(Methodsync, methodsyncParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodsyncParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var currentMethodInfo = this.GetMethodInfo(Methodsync, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (sync) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_sync_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsync);
            var currentMethodInfo = this.GetMethodInfo(Methodsync, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_getOnyxUpdateDate_Method_Call_Internally(Type[] types)
        {
            var methodgetOnyxUpdateDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var oIndividualRetrieve = this.CreateType<XmlNode>();
            var methodgetOnyxUpdateDateParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfgetOnyxUpdateDate = { oIndividualRetrieve };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_syncContactInstanceFixture, parametersOfgetOnyxUpdateDate);
            var result2 = this.GetResultOfMethod<string>(MethodgetOnyxUpdateDate, parametersOfgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetOnyxUpdateDate.ShouldNotBeNull();
            parametersOfgetOnyxUpdateDate.Length.ShouldBe(1);
            methodgetOnyxUpdateDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var oIndividualRetrieve = this.CreateType<XmlNode>();
            var methodgetOnyxUpdateDateParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfgetOnyxUpdateDate = { oIndividualRetrieve };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodgetOnyxUpdateDate, parametersOfgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes);

            // Assert
            parametersOfgetOnyxUpdateDate.ShouldNotBeNull();
            parametersOfgetOnyxUpdateDate.Length.ShouldBe(1);
            methodgetOnyxUpdateDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var methodgetOnyxUpdateDateParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetOnyxUpdateDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var methodgetOnyxUpdateDateParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetOnyxUpdateDate, methodgetOnyxUpdateDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetOnyxUpdateDateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var currentMethodInfo = this.GetMethodInfo(MethodgetOnyxUpdateDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getOnyxUpdateDate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_getOnyxUpdateDate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOnyxUpdateDate);
            var currentMethodInfo = this.GetMethodInfo(MethodgetOnyxUpdateDate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_Internally(Type[] types)
        {
            var methodretrieveIndividualDataForBISyncParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var oSession = this.CreateType<OnyxSession>();
            var methodretrieveIndividualDataForBISyncParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfretrieveIndividualDataForBISync = { oSession };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_syncContactInstanceFixture, out exception1, parametersOfretrieveIndividualDataForBISync);
            var result2 = this.GetResultOfMethod<string>(MethodretrieveIndividualDataForBISync, parametersOfretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfretrieveIndividualDataForBISync.ShouldNotBeNull();
            parametersOfretrieveIndividualDataForBISync.Length.ShouldBe(1);
            methodretrieveIndividualDataForBISyncParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var oSession = this.CreateType<OnyxSession>();
            var methodretrieveIndividualDataForBISyncParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfretrieveIndividualDataForBISync = { oSession };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_syncContactInstanceFixture, parametersOfretrieveIndividualDataForBISync);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfretrieveIndividualDataForBISync.ShouldNotBeNull();
            parametersOfretrieveIndividualDataForBISync.Length.ShouldBe(1);
            methodretrieveIndividualDataForBISyncParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var oSession = this.CreateType<OnyxSession>();
            var methodretrieveIndividualDataForBISyncParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfretrieveIndividualDataForBISync = { oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodretrieveIndividualDataForBISync, parametersOfretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes);

            // Assert
            parametersOfretrieveIndividualDataForBISync.ShouldNotBeNull();
            parametersOfretrieveIndividualDataForBISync.Length.ShouldBe(1);
            methodretrieveIndividualDataForBISyncParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var methodretrieveIndividualDataForBISyncParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodretrieveIndividualDataForBISyncParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var methodretrieveIndividualDataForBISyncParametersTypes = new Type[] { typeof(OnyxSession) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveIndividualDataForBISync, methodretrieveIndividualDataForBISyncParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveIndividualDataForBISyncParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveIndividualDataForBISync, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (retrieveIndividualDataForBISync) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveIndividualDataForBISync_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveIndividualDataForBISync);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveIndividualDataForBISync, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_Internally(Type[] types)
        {
            var methodretrieveFromOnyxSyncTableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var oSession = this.CreateType<OnyxSession>();
            var custEnum = this.CreateType<string>();
            var methodretrieveFromOnyxSyncTableParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            object[] parametersOfretrieveFromOnyxSyncTable = { oSession, custEnum };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_syncContactInstanceFixture, parametersOfretrieveFromOnyxSyncTable);
            var result2 = this.GetResultOfMethod<string>(MethodretrieveFromOnyxSyncTable, parametersOfretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveFromOnyxSyncTable.ShouldNotBeNull();
            parametersOfretrieveFromOnyxSyncTable.Length.ShouldBe(2);
            methodretrieveFromOnyxSyncTableParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var oSession = this.CreateType<OnyxSession>();
            var custEnum = this.CreateType<string>();
            var methodretrieveFromOnyxSyncTableParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            object[] parametersOfretrieveFromOnyxSyncTable = { oSession, custEnum };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodretrieveFromOnyxSyncTable, parametersOfretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes);

            // Assert
            parametersOfretrieveFromOnyxSyncTable.ShouldNotBeNull();
            parametersOfretrieveFromOnyxSyncTable.Length.ShouldBe(2);
            methodretrieveFromOnyxSyncTableParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var methodretrieveFromOnyxSyncTableParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveFromOnyxSyncTableParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var methodretrieveFromOnyxSyncTableParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyxSyncTable, methodretrieveFromOnyxSyncTableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveFromOnyxSyncTableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyxSyncTable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyxSyncTable) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_retrieveFromOnyxSyncTable_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyxSyncTable);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyxSyncTable, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_Internally(Type[] types)
        {
            var methodupdateOnyxSyncTableLastSyncDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodupdateOnyxSyncTableLastSyncDate, methodupdateOnyxSyncTableLastSyncDateParametersTypes);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxSyncTableLastSyncDate);
            var oSession = this.CreateType<OnyxSession>();
            var methodupdateOnyxSyncTableLastSyncDateParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfupdateOnyxSyncTableLastSyncDate = { oSession };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOnyxSyncTableLastSyncDate, methodupdateOnyxSyncTableLastSyncDateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_syncContactInstanceFixture, parametersOfupdateOnyxSyncTableLastSyncDate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfupdateOnyxSyncTableLastSyncDate.ShouldNotBeNull();
            parametersOfupdateOnyxSyncTableLastSyncDate.Length.ShouldBe(1);
            methodupdateOnyxSyncTableLastSyncDateParametersTypes.Length.ShouldBe(1);
            methodupdateOnyxSyncTableLastSyncDateParametersTypes.Length.ShouldBe(parametersOfupdateOnyxSyncTableLastSyncDate.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxSyncTableLastSyncDate);
            var oSession = this.CreateType<OnyxSession>();
            var methodupdateOnyxSyncTableLastSyncDateParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfupdateOnyxSyncTableLastSyncDate = { oSession };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodupdateOnyxSyncTableLastSyncDate, parametersOfupdateOnyxSyncTableLastSyncDate, methodupdateOnyxSyncTableLastSyncDateParametersTypes);

            // Assert
            parametersOfupdateOnyxSyncTableLastSyncDate.ShouldNotBeNull();
            parametersOfupdateOnyxSyncTableLastSyncDate.Length.ShouldBe(1);
            methodupdateOnyxSyncTableLastSyncDateParametersTypes.Length.ShouldBe(1);
            methodupdateOnyxSyncTableLastSyncDateParametersTypes.Length.ShouldBe(parametersOfupdateOnyxSyncTableLastSyncDate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxSyncTableLastSyncDate);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOnyxSyncTableLastSyncDate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxSyncTableLastSyncDate);
            var methodupdateOnyxSyncTableLastSyncDateParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodupdateOnyxSyncTableLastSyncDate, methodupdateOnyxSyncTableLastSyncDateParametersTypes);

            // Assert
            methodupdateOnyxSyncTableLastSyncDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxSyncTableLastSyncDate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_updateOnyxSyncTableLastSyncDate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxSyncTableLastSyncDate);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOnyxSyncTableLastSyncDate, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_Internally(Type[] types)
        {
            var methodinsertAssociationIntoOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var oSession = this.CreateType<OnyxSession>();
            var custEnum = this.CreateType<string>();
            var methodinsertAssociationIntoOnyxParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            object[] parametersOfinsertAssociationIntoOnyx = { oSession, custEnum };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_syncContactInstanceFixture, parametersOfinsertAssociationIntoOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodinsertAssociationIntoOnyx, parametersOfinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfinsertAssociationIntoOnyx.ShouldNotBeNull();
            parametersOfinsertAssociationIntoOnyx.Length.ShouldBe(2);
            methodinsertAssociationIntoOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var oSession = this.CreateType<OnyxSession>();
            var custEnum = this.CreateType<string>();
            var methodinsertAssociationIntoOnyxParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            object[] parametersOfinsertAssociationIntoOnyx = { oSession, custEnum };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodinsertAssociationIntoOnyx, parametersOfinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            parametersOfinsertAssociationIntoOnyx.ShouldNotBeNull();
            parametersOfinsertAssociationIntoOnyx.Length.ShouldBe(2);
            methodinsertAssociationIntoOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var methodinsertAssociationIntoOnyxParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodinsertAssociationIntoOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var methodinsertAssociationIntoOnyxParametersTypes = new Type[] { typeof(OnyxSession), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodinsertAssociationIntoOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodinsertAssociationIntoOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_insertAssociationIntoOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodinsertAssociationIntoOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SyncContact_locateMatchingCustomer_Method_Call_Internally(Type[] types)
        {
            var methodlocateMatchingCustomerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var oSession = this.CreateType<OnyxSession>();
            var methodlocateMatchingCustomerParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOflocateMatchingCustomer = { oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_syncContactInstanceFixture, parametersOflocateMatchingCustomer);
            var result2 = this.GetResultOfMethod<String>(MethodlocateMatchingCustomer, parametersOflocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOflocateMatchingCustomer.ShouldNotBeNull();
            parametersOflocateMatchingCustomer.Length.ShouldBe(1);
            methodlocateMatchingCustomerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var oSession = this.CreateType<OnyxSession>();
            var methodlocateMatchingCustomerParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOflocateMatchingCustomer = { oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodlocateMatchingCustomer, parametersOflocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes);

            // Assert
            parametersOflocateMatchingCustomer.ShouldNotBeNull();
            parametersOflocateMatchingCustomer.Length.ShouldBe(1);
            methodlocateMatchingCustomerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var methodlocateMatchingCustomerParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodlocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodlocateMatchingCustomerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var methodlocateMatchingCustomerParametersTypes = new Type[] { typeof(OnyxSession) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlocateMatchingCustomer, methodlocateMatchingCustomerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodlocateMatchingCustomerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingCustomer, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (locateMatchingCustomer) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SyncContact_locateMatchingCustomer_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingCustomer, 0);
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