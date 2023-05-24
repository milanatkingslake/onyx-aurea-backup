using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OEASConfig;
using Shouldly;

namespace Avolin.Onyx.Part17.AUT.Tests.OEASConfig
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OEASConfig.OEASConfigTool" />)
    ///     and namespace <see cref="OEASConfig"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OEASConfigToolTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASConfigTool" />)
        /// </summary>
        public OEASConfigToolTest() : base(typeof(OEASConfigTool))
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

        #region General Initializer : Class (OEASConfigTool) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASConfigToolInstanceType;
        private OEASConfigTool _oEASConfigToolInstance;
        private OEASConfigTool _oEASConfigToolInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEASConfigTool" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASConfigToolInstanceType = typeof(OEASConfigTool);
            _oEASConfigToolInstanceFixture = this.Create<OEASConfigTool>(false);
            _oEASConfigToolInstance = _oEASConfigToolInstanceFixture ?? this.Create<OEASConfigTool>(true);
            CurrentInstance = _oEASConfigToolInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASConfigTool) Initializer

        #region Methods

        private const string MethodEncryptStringW = "EncryptStringW";
        private const string MethodcmdGlobalRestore_Click = "cmdGlobalRestore_Click";
        private const string MethodcmdGlobalSave_Click = "cmdGlobalSave_Click";
        private const string MethodcmdClose_Click = "cmdClose_Click";
        private const string MethodcmdAdd_Click = "cmdAdd_Click";
        private const string MethodcmdRemove_Click = "cmdRemove_Click";
        private const string MethodcmdUpdate_Click = "cmdUpdate_Click";
        private const string MethodcboProtocol_SelectedIndexChanged = "cboProtocol_SelectedIndexChanged";
        private const string MethodcmbApplicationName_SelectedIndexChanged = "cmbApplicationName_SelectedIndexChanged";
        private const string MethodlstLoggingValues_SelectedIndexChanged = "lstLoggingValues_SelectedIndexChanged";
        private const string MethodOEASConfigTool_Load = "OEASConfigTool_Load";
        private const string MethodLoadApplicationData = "LoadApplicationData";
        private const string MethodInitializeApplicationControls = "InitializeApplicationControls";
        private const string MethodInitializeLoggingControls = "InitializeLoggingControls";
        private const string MethodWriteEnabled = "WriteEnabled";
        private const string MethodGetApplicationData = "GetApplicationData";
        private const string MethodGetOGSData = "GetOGSData";
        private const string MethodGetLoggingData = "GetLoggingData";
        private const string MethodGetEmailData = "GetEmailData";
        private const string MethodSaveOGS = "SaveOGS";
        private const string MethodSetStringProperty = "SetStringProperty";
        private const string MethodEncrypt = "Encrypt";
        private const string MethodSetAppDirty = "SetAppDirty";
        private const string MethodSetLogDirty = "SetLogDirty";
        private const string MethodSetEmailDirty = "SetEmailDirty";
        private const string MethodSetOGSDirty = "SetOGSDirty";
        private const string MethodClearAppDirty = "ClearAppDirty";
        private const string MethodClearLogDirty = "ClearLogDirty";
        private const string MethodClearEmailDirty = "ClearEmailDirty";
        private const string MethodClearOGSDirty = "ClearOGSDirty";
        private const string MethodSetCmdButton = "SetCmdButton";
        private const string MethodSetEmailCmdButton = "SetEmailCmdButton";
        private const string MethodGetOEASRegistryPath = "GetOEASRegistryPath";
        private const string MethodtxtServer_TextChanged = "txtServer_TextChanged";
        private const string MethodtxtDatabase_TextChanged = "txtDatabase_TextChanged";
        private const string MethodtxtPDatabase_TextChanged = "txtPDatabase_TextChanged";
        private const string MethodtxtUserID_TextChanged = "txtUserID_TextChanged";
        private const string MethodtxtPassword_TextChanged = "txtPassword_TextChanged";
        private const string MethodtxtConnectionTimeout_TextChanged = "txtConnectionTimeout_TextChanged";
        private const string MethodtxtQueryTimeout_TextChanged = "txtQueryTimeout_TextChanged";
        private const string MethodtxtMaxRows_TextChanged = "txtMaxRows_TextChanged";
        private const string MethodtxtOrgId_TextChanged = "txtOrgId_TextChanged";
        private const string MethodtxtPort_TextChanged = "txtPort_TextChanged";
        private const string MethodtxtKey_TextChanged = "txtKey_TextChanged";
        private const string MethodtxtValue_TextChanged = "txtValue_TextChanged";
        private const string MethodtxtSendUser_TextChanged = "txtSendUser_TextChanged";
        private const string MethodtxtSendPass_TextChanged = "txtSendPass_TextChanged";
        private const string MethodtxtSMTPPort_TextChanged = "txtSMTPPort_TextChanged";
        private const string MethodtxtServer_Enter = "txtServer_Enter";
        private const string MethodtxtDatabase_Enter = "txtDatabase_Enter";
        private const string MethodtxtPDatabase_Enter = "txtPDatabase_Enter";
        private const string MethodtxtUserID_Enter = "txtUserID_Enter";
        private const string MethodtxtPassword_Enter = "txtPassword_Enter";
        private const string MethodtxtConnectionTimeout_Enter = "txtConnectionTimeout_Enter";
        private const string MethodtxtQueryTimeout_Enter = "txtQueryTimeout_Enter";
        private const string MethodtxtMaxRows_Enter = "txtMaxRows_Enter";
        private const string MethodtxtOrgId_Enter = "txtOrgId_Enter";
        private const string MethodtxtPort_Enter = "txtPort_Enter";
        private const string MethodtxtKey_Enter = "txtKey_Enter";
        private const string MethodtxtValue_Enter = "txtValue_Enter";
        private const string MethodtxtConnectionTimeout_KeyPress = "txtConnectionTimeout_KeyPress";
        private const string MethodtxtDatabase_KeyPress = "txtDatabase_KeyPress";
        private const string MethodtxtPDatabase_KeyPress = "txtPDatabase_KeyPress";
        private const string MethodtxtMaxRows_KeyPress = "txtMaxRows_KeyPress";
        private const string MethodtxtQueryTimeout_KeyPress = "txtQueryTimeout_KeyPress";
        private const string MethodtxtServer_KeyPress = "txtServer_KeyPress";
        private const string MethodtxtUserID_KeyPress = "txtUserID_KeyPress";
        private const string MethodtxtValue_KeyPress = "txtValue_KeyPress";
        private const string MethodtxtPort_KeyPress = "txtPort_KeyPress";
        private const string MethodtxtSMTPPort_KeyPress = "txtSMTPPort_KeyPress";
        private const string MethodchkUseSSL_CheckedChanged = "chkUseSSL_CheckedChanged";
        private const string MethodTabStrip_SelectedIndexChanged = "TabStrip_SelectedIndexChanged";
        private const string MethodOEASConfigTool_FormClosing = "OEASConfigTool_FormClosing";
        private const string MethodIsOGSInstalled = "IsOGSInstalled";

        #endregion

        #region Fields

        private const string FieldoAppData = "oAppData";
        private const string FieldOEP_REG_KEY = "OEP_REG_KEY";
        private const string FieldONYX_KEY = "ONYX_KEY";
        private const string FieldONYXLOG_KEY = "ONYXLOG_KEY";
        private const string FieldQE_KEY = "QE_KEY";
        private const string FieldPASSWORD_REGKEY = "PASSWORD_REGKEY";
        private const string FieldCONNECTION_TIMEOUT_STRING = "CONNECTION_TIMEOUT_STRING";
        private const string FieldQUERY_TIMEOUT_STRING = "QUERY_TIMEOUT_STRING";
        private const string FieldMAX_ROWS_STRING = "MAX_ROWS_STRING";
        private const string FieldDATABASE_TYPE_STRING = "DATABASE_TYPE_STRING";
        private const string FieldORG_ID_STRING = "ORG_ID_STRING";
        private const string FieldNAME_POS = "NAME_POS";
        private const string FieldVALUE_POS = "VALUE_POS";
        private const string FieldSERVER = "SERVER";
        private const string FieldDATABASE = "DATABASE";
        private const string FieldUSERID = "USERID";
        private const string FieldPASSWORD = "PASSWORD";
        private const string FieldCONNECTIONTIMEOUT = "CONNECTIONTIMEOUT";
        private const string FieldQUERYTIMEOUT = "QUERYTIMEOUT";
        private const string FieldMAXROWS = "MAXROWS";
        private const string FieldDATABASETYPE = "DATABASETYPE";
        private const string FieldORGID = "ORGID";
        private const string FieldPDATABASE = "PDATABASE";
        private const string FieldOGSPort = "OGSPort";
        private const string FieldDB_MSSQL = "DB_MSSQL";
        private const string FieldDB_ORACLE = "DB_ORACLE";
        private const string FieldEVENTLOGSOURCE_RESERVED_VALUE_NAME = "EVENTLOGSOURCE_RESERVED_VALUE_NAME";
        private const string FieldFILESOURCE_RESERVED_VALUE_NAME = "FILESOURCE_RESERVED_VALUE_NAME";
        private const string FieldFILEOUTPUT_RESERVED_VALUE_NAME = "FILEOUTPUT_RESERVED_VALUE_NAME";
        private const string FieldGLOBAL_SETTINGS_RESERVED_VALUE_NAME = "GLOBAL_SETTINGS_RESERVED_VALUE_NAME";
        private const string FieldPROVIDER_TAG = "PROVIDER_TAG";
        private const string FieldDATA_SOURCE_TAG = "DATA_SOURCE_TAG";
        private const string FieldSQL_USER_ID_TAG = "SQL_USER_ID_TAG";
        private const string FieldORACLE_USER_ID_TAG = "ORACLE_USER_ID_TAG";
        private const string FieldDATABASE_TAG = "DATABASE_TAG";
        private const string FieldSC_ONYX_PASSWORD_KEY = "SC_ONYX_PASSWORD_KEY";
        private const string FieldMAGIC_ENCRYPT_STRING = "MAGIC_ENCRYPT_STRING";
        private const string FieldMAGIC_DECRYPT_STRING = "MAGIC_DECRYPT_STRING";
        private const string FieldEMAIL_KEY = "EMAIL_KEY";
        private const string FieldSMTP_AUTH_PROTOCOL = "SMTP_AUTH_PROTOCOL";
        private const string FieldSMTP_SEND_USER = "SMTP_SEND_USER";
        private const string FieldSMTP_SEND_PASS = "SMTP_SEND_PASS";
        private const string FieldSMTP_PORT = "SMTP_PORT";
        private const string FieldSMTP_USE_SSL = "SMTP_USE_SSL";
        private const string FieldSMTP_DEFAULT_PORT = "SMTP_DEFAULT_PORT";
        private const string FieldPROTOCOL = "PROTOCOL";
        private const string FieldSENDUSER = "SENDUSER";
        private const string FieldSENDPASSWORD = "SENDPASSWORD";
        private const string FieldSMTPPORT = "SMTPPORT";
        private const string FieldUSESSL = "USESSL";
        private const string FieldgsApplicationName = "gsApplicationName";
        private const string FieldgsOLEDBProvider = "gsOLEDBProvider";
        private const string FieldgsRemainderText = "gsRemainderText";
        private const string FieldgoRegister = "goRegister";
        private const string FieldgbAppDirty = "gbAppDirty";
        private const string FieldgbLogDirty = "gbLogDirty";
        private const string FieldgbOGSDirty = "gbOGSDirty";
        private const string FieldgsLoggingValues = "gsLoggingValues";
        private const string FieldgsApplicationValues = "gsApplicationValues";
        private const string FieldbReadOnly = "bReadOnly";
        private const string FieldOGSConfigXml = "OGSConfigXml";
        private const string FieldgbPasswordDirty = "gbPasswordDirty";
        private const string FieldgbEmailPasswordDirty = "gbEmailPasswordDirty";
        private const string FieldgbEmailDirty = "gbEmailDirty";
        private const string FieldgsEmailValues = "gsEmailValues";
        private const string Fieldrm = "rm";
        private const string FieldboolReturnValue = "boolReturnValue";
        private const string FieldappCmdButtonsEnabled = "appCmdButtonsEnabled";
        private const string FieldOGSCmdButtonEnabled = "OGSCmdButtonEnabled";
        private const string FieldemailCmdButtonEnabled = "emailCmdButtonEnabled";

        #endregion

        #endregion

        #region General Initializer : Class (OEASConfigTool) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASConfigTool_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASConfigTool) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASConfigTool_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASConfigTool)

        #region General Initializer : Class (OEASConfigTool) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEncryptStringW, 0)]
        [TestCase(MethodcmdGlobalRestore_Click, 0)]
        [TestCase(MethodcmdGlobalSave_Click, 0)]
        [TestCase(MethodcmdAdd_Click, 0)]
        [TestCase(MethodcmdRemove_Click, 0)]
        [TestCase(MethodcmdUpdate_Click, 0)]
        [TestCase(MethodcboProtocol_SelectedIndexChanged, 0)]
        [TestCase(MethodcmbApplicationName_SelectedIndexChanged, 0)]
        [TestCase(MethodlstLoggingValues_SelectedIndexChanged, 0)]
        [TestCase(MethodOEASConfigTool_Load, 0)]
        [TestCase(MethodLoadApplicationData, 0)]
        [TestCase(MethodInitializeApplicationControls, 0)]
        [TestCase(MethodInitializeLoggingControls, 0)]
        [TestCase(MethodWriteEnabled, 0)]
        [TestCase(MethodGetApplicationData, 0)]
        [TestCase(MethodGetOGSData, 0)]
        [TestCase(MethodGetLoggingData, 0)]
        [TestCase(MethodGetEmailData, 0)]
        [TestCase(MethodSaveOGS, 0)]
        [TestCase(MethodSetStringProperty, 0)]
        [TestCase(MethodEncrypt, 0)]
        [TestCase(MethodSetAppDirty, 0)]
        [TestCase(MethodSetLogDirty, 0)]
        [TestCase(MethodSetEmailDirty, 0)]
        [TestCase(MethodSetOGSDirty, 0)]
        [TestCase(MethodClearAppDirty, 0)]
        [TestCase(MethodClearLogDirty, 0)]
        [TestCase(MethodClearEmailDirty, 0)]
        [TestCase(MethodClearOGSDirty, 0)]
        [TestCase(MethodSetCmdButton, 0)]
        [TestCase(MethodSetEmailCmdButton, 0)]
        [TestCase(MethodGetOEASRegistryPath, 0)]
        [TestCase(MethodtxtServer_TextChanged, 0)]
        [TestCase(MethodtxtDatabase_TextChanged, 0)]
        [TestCase(MethodtxtPDatabase_TextChanged, 0)]
        [TestCase(MethodtxtUserID_TextChanged, 0)]
        [TestCase(MethodtxtPassword_TextChanged, 0)]
        [TestCase(MethodtxtConnectionTimeout_TextChanged, 0)]
        [TestCase(MethodtxtQueryTimeout_TextChanged, 0)]
        [TestCase(MethodtxtMaxRows_TextChanged, 0)]
        [TestCase(MethodtxtOrgId_TextChanged, 0)]
        [TestCase(MethodtxtPort_TextChanged, 0)]
        [TestCase(MethodtxtKey_TextChanged, 0)]
        [TestCase(MethodtxtValue_TextChanged, 0)]
        [TestCase(MethodtxtSendUser_TextChanged, 0)]
        [TestCase(MethodtxtSendPass_TextChanged, 0)]
        [TestCase(MethodtxtSMTPPort_TextChanged, 0)]
        [TestCase(MethodtxtServer_Enter, 0)]
        [TestCase(MethodtxtDatabase_Enter, 0)]
        [TestCase(MethodtxtPDatabase_Enter, 0)]
        [TestCase(MethodtxtUserID_Enter, 0)]
        [TestCase(MethodtxtPassword_Enter, 0)]
        [TestCase(MethodtxtConnectionTimeout_Enter, 0)]
        [TestCase(MethodtxtQueryTimeout_Enter, 0)]
        [TestCase(MethodtxtMaxRows_Enter, 0)]
        [TestCase(MethodtxtOrgId_Enter, 0)]
        [TestCase(MethodtxtPort_Enter, 0)]
        [TestCase(MethodtxtKey_Enter, 0)]
        [TestCase(MethodtxtValue_Enter, 0)]
        [TestCase(MethodtxtConnectionTimeout_KeyPress, 0)]
        [TestCase(MethodtxtDatabase_KeyPress, 0)]
        [TestCase(MethodtxtPDatabase_KeyPress, 0)]
        [TestCase(MethodtxtMaxRows_KeyPress, 0)]
        [TestCase(MethodtxtQueryTimeout_KeyPress, 0)]
        [TestCase(MethodtxtServer_KeyPress, 0)]
        [TestCase(MethodtxtUserID_KeyPress, 0)]
        [TestCase(MethodtxtValue_KeyPress, 0)]
        [TestCase(MethodtxtPort_KeyPress, 0)]
        [TestCase(MethodtxtSMTPPort_KeyPress, 0)]
        [TestCase(MethodchkUseSSL_CheckedChanged, 0)]
        [TestCase(MethodTabStrip_SelectedIndexChanged, 0)]
        [TestCase(MethodIsOGSInstalled, 0)]
        public void AUT_OEASConfigTool_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASConfigTool) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldoAppData)]
        [TestCase(FieldOEP_REG_KEY)]
        [TestCase(FieldONYX_KEY)]
        [TestCase(FieldONYXLOG_KEY)]
        [TestCase(FieldQE_KEY)]
        [TestCase(FieldPASSWORD_REGKEY)]
        [TestCase(FieldCONNECTION_TIMEOUT_STRING)]
        [TestCase(FieldQUERY_TIMEOUT_STRING)]
        [TestCase(FieldMAX_ROWS_STRING)]
        [TestCase(FieldDATABASE_TYPE_STRING)]
        [TestCase(FieldORG_ID_STRING)]
        [TestCase(FieldNAME_POS)]
        [TestCase(FieldVALUE_POS)]
        [TestCase(FieldSERVER)]
        [TestCase(FieldDATABASE)]
        [TestCase(FieldUSERID)]
        [TestCase(FieldPASSWORD)]
        [TestCase(FieldCONNECTIONTIMEOUT)]
        [TestCase(FieldQUERYTIMEOUT)]
        [TestCase(FieldMAXROWS)]
        [TestCase(FieldDATABASETYPE)]
        [TestCase(FieldORGID)]
        [TestCase(FieldPDATABASE)]
        [TestCase(FieldOGSPort)]
        [TestCase(FieldDB_MSSQL)]
        [TestCase(FieldDB_ORACLE)]
        [TestCase(FieldEVENTLOGSOURCE_RESERVED_VALUE_NAME)]
        [TestCase(FieldFILESOURCE_RESERVED_VALUE_NAME)]
        [TestCase(FieldFILEOUTPUT_RESERVED_VALUE_NAME)]
        [TestCase(FieldGLOBAL_SETTINGS_RESERVED_VALUE_NAME)]
        [TestCase(FieldPROVIDER_TAG)]
        [TestCase(FieldDATA_SOURCE_TAG)]
        [TestCase(FieldSQL_USER_ID_TAG)]
        [TestCase(FieldORACLE_USER_ID_TAG)]
        [TestCase(FieldDATABASE_TAG)]
        [TestCase(FieldSC_ONYX_PASSWORD_KEY)]
        [TestCase(FieldMAGIC_ENCRYPT_STRING)]
        [TestCase(FieldMAGIC_DECRYPT_STRING)]
        [TestCase(FieldEMAIL_KEY)]
        [TestCase(FieldSMTP_AUTH_PROTOCOL)]
        [TestCase(FieldSMTP_SEND_USER)]
        [TestCase(FieldSMTP_SEND_PASS)]
        [TestCase(FieldSMTP_PORT)]
        [TestCase(FieldSMTP_USE_SSL)]
        [TestCase(FieldSMTP_DEFAULT_PORT)]
        [TestCase(FieldPROTOCOL)]
        [TestCase(FieldSENDUSER)]
        [TestCase(FieldSENDPASSWORD)]
        [TestCase(FieldSMTPPORT)]
        [TestCase(FieldUSESSL)]
        [TestCase(FieldgsApplicationName)]
        [TestCase(FieldgsOLEDBProvider)]
        [TestCase(FieldgsRemainderText)]
        [TestCase(FieldgoRegister)]
        [TestCase(FieldgbAppDirty)]
        [TestCase(FieldgbLogDirty)]
        [TestCase(FieldgbOGSDirty)]
        [TestCase(FieldgsLoggingValues)]
        [TestCase(FieldgsApplicationValues)]
        [TestCase(FieldbReadOnly)]
        [TestCase(FieldOGSConfigXml)]
        [TestCase(FieldgbPasswordDirty)]
        [TestCase(FieldgbEmailPasswordDirty)]
        [TestCase(FieldgbEmailDirty)]
        [TestCase(FieldgsEmailValues)]
        [TestCase(Fieldrm)]
        [TestCase(FieldboolReturnValue)]
        [TestCase(FieldappCmdButtonsEnabled)]
        [TestCase(FieldOGSCmdButtonEnabled)]
        [TestCase(FieldemailCmdButtonEnabled)]
        [Category("AUT Fields")]
        public void AUT_OEASConfigTool_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OEASConfigTool) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASConfigTool_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEASConfigToolInstance.ShouldBeAssignableTo<OEASConfigTool>();
            _oEASConfigToolInstanceFixture.ShouldBeAssignableTo<OEASConfigTool>();
            CurrentInstance.ShouldBeAssignableTo<OEASConfigTool>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EncryptStringW) (Return Type : long) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_EncryptStringW_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptStringW);
            var MagicNumber = this.CreateType<string>();
            var Password = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var encryptedPassword = this.CreateType<StringBuilder>();

            // Act
            Action executeAction = () => OEASConfigTool.EncryptStringW(MagicNumber, Password, Key, encryptedPassword);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EncryptStringW) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_EncryptStringW_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptStringW);
            var MagicNumber = this.CreateType<string>();
            var Password = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var encryptedPassword = this.CreateType<StringBuilder>();
            var methodEncryptStringWParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(StringBuilder) };
            object[] parametersOfEncryptStringW = { MagicNumber, Password, Key, encryptedPassword };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodEncryptStringW, parametersOfEncryptStringW, methodEncryptStringWParametersTypes);

            // Assert
            parametersOfEncryptStringW.ShouldNotBeNull();
            parametersOfEncryptStringW.Length.ShouldBe(4);
            methodEncryptStringWParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptStringW) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_EncryptStringW_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptStringW);
            var methodEncryptStringWParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(StringBuilder) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncryptStringW, methodEncryptStringWParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncryptStringWParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncryptStringW) (Return Type : long) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_EncryptStringW_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptStringW);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptStringW, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EncryptStringW) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_EncryptStringW_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptStringW);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptStringW, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdGlobalRestore_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdGlobalRestore_Click, methodcmdGlobalRestore_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalRestore_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdGlobalRestore_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdGlobalRestore_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalRestore_Click, methodcmdGlobalRestore_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmdGlobalRestore_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmdGlobalRestore_Click.ShouldNotBeNull();
            parametersOfcmdGlobalRestore_Click.Length.ShouldBe(2);
            methodcmdGlobalRestore_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdGlobalRestore_ClickParametersTypes.Length.ShouldBe(parametersOfcmdGlobalRestore_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalRestore_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdGlobalRestore_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdGlobalRestore_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmdGlobalRestore_Click, parametersOfcmdGlobalRestore_Click, methodcmdGlobalRestore_ClickParametersTypes);

            // Assert
            parametersOfcmdGlobalRestore_Click.ShouldNotBeNull();
            parametersOfcmdGlobalRestore_Click.Length.ShouldBe(2);
            methodcmdGlobalRestore_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdGlobalRestore_ClickParametersTypes.Length.ShouldBe(parametersOfcmdGlobalRestore_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalRestore_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalRestore_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalRestore_Click);
            var methodcmdGlobalRestore_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmdGlobalRestore_Click, methodcmdGlobalRestore_ClickParametersTypes);

            // Assert
            methodcmdGlobalRestore_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalRestore_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalRestore_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalRestore_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalRestore_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdGlobalSave_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdGlobalSave_Click, methodcmdGlobalSave_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdGlobalSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdGlobalSave_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalSave_Click, methodcmdGlobalSave_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmdGlobalSave_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmdGlobalSave_Click.ShouldNotBeNull();
            parametersOfcmdGlobalSave_Click.Length.ShouldBe(2);
            methodcmdGlobalSave_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdGlobalSave_ClickParametersTypes.Length.ShouldBe(parametersOfcmdGlobalSave_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdGlobalSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdGlobalSave_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmdGlobalSave_Click, parametersOfcmdGlobalSave_Click, methodcmdGlobalSave_ClickParametersTypes);

            // Assert
            parametersOfcmdGlobalSave_Click.ShouldNotBeNull();
            parametersOfcmdGlobalSave_Click.Length.ShouldBe(2);
            methodcmdGlobalSave_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdGlobalSave_ClickParametersTypes.Length.ShouldBe(parametersOfcmdGlobalSave_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalSave_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalSave_Click);
            var methodcmdGlobalSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmdGlobalSave_Click, methodcmdGlobalSave_ClickParametersTypes);

            // Assert
            methodcmdGlobalSave_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdGlobalSave_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdGlobalSave_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdGlobalSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdGlobalSave_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdClose_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdClose_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdClose_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdClose_Click, methodcmdClose_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdAdd_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdAdd_Click, methodcmdAdd_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdAdd_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdAdd_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdAdd_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmdAdd_Click, methodcmdAdd_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmdAdd_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmdAdd_Click.ShouldNotBeNull();
            parametersOfcmdAdd_Click.Length.ShouldBe(2);
            methodcmdAdd_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdAdd_ClickParametersTypes.Length.ShouldBe(parametersOfcmdAdd_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdAdd_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdAdd_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdAdd_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmdAdd_Click, parametersOfcmdAdd_Click, methodcmdAdd_ClickParametersTypes);

            // Assert
            parametersOfcmdAdd_Click.ShouldNotBeNull();
            parametersOfcmdAdd_Click.Length.ShouldBe(2);
            methodcmdAdd_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdAdd_ClickParametersTypes.Length.ShouldBe(parametersOfcmdAdd_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdAdd_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdAdd_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdAdd_Click);
            var methodcmdAdd_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmdAdd_Click, methodcmdAdd_ClickParametersTypes);

            // Assert
            methodcmdAdd_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdAdd_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdAdd_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdAdd_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdAdd_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdRemove_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdRemove_Click, methodcmdRemove_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdRemove_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdRemove_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdRemove_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmdRemove_Click, methodcmdRemove_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmdRemove_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmdRemove_Click.ShouldNotBeNull();
            parametersOfcmdRemove_Click.Length.ShouldBe(2);
            methodcmdRemove_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdRemove_ClickParametersTypes.Length.ShouldBe(parametersOfcmdRemove_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdRemove_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdRemove_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdRemove_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmdRemove_Click, parametersOfcmdRemove_Click, methodcmdRemove_ClickParametersTypes);

            // Assert
            parametersOfcmdRemove_Click.ShouldNotBeNull();
            parametersOfcmdRemove_Click.Length.ShouldBe(2);
            methodcmdRemove_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdRemove_ClickParametersTypes.Length.ShouldBe(parametersOfcmdRemove_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdRemove_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdRemove_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdRemove_Click);
            var methodcmdRemove_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmdRemove_Click, methodcmdRemove_ClickParametersTypes);

            // Assert
            methodcmdRemove_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdRemove_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdRemove_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdRemove_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdRemove_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_Internally(Type[] types)
        {
            var methodcmdUpdate_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmdUpdate_Click, methodcmdUpdate_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdUpdate_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdUpdate_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdUpdate_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmdUpdate_Click, methodcmdUpdate_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmdUpdate_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmdUpdate_Click.ShouldNotBeNull();
            parametersOfcmdUpdate_Click.Length.ShouldBe(2);
            methodcmdUpdate_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdUpdate_ClickParametersTypes.Length.ShouldBe(parametersOfcmdUpdate_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdUpdate_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmdUpdate_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmdUpdate_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmdUpdate_Click, parametersOfcmdUpdate_Click, methodcmdUpdate_ClickParametersTypes);

            // Assert
            parametersOfcmdUpdate_Click.ShouldNotBeNull();
            parametersOfcmdUpdate_Click.Length.ShouldBe(2);
            methodcmdUpdate_ClickParametersTypes.Length.ShouldBe(2);
            methodcmdUpdate_ClickParametersTypes.Length.ShouldBe(parametersOfcmdUpdate_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdUpdate_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdUpdate_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdUpdate_Click);
            var methodcmdUpdate_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmdUpdate_Click, methodcmdUpdate_ClickParametersTypes);

            // Assert
            methodcmdUpdate_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmdUpdate_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmdUpdate_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmdUpdate_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcmdUpdate_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodcboProtocol_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcboProtocol_SelectedIndexChanged, methodcboProtocol_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcboProtocol_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcboProtocol_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcboProtocol_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcboProtocol_SelectedIndexChanged, methodcboProtocol_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcboProtocol_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcboProtocol_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcboProtocol_SelectedIndexChanged.Length.ShouldBe(2);
            methodcboProtocol_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcboProtocol_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcboProtocol_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcboProtocol_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcboProtocol_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcboProtocol_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcboProtocol_SelectedIndexChanged, parametersOfcboProtocol_SelectedIndexChanged, methodcboProtocol_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOfcboProtocol_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcboProtocol_SelectedIndexChanged.Length.ShouldBe(2);
            methodcboProtocol_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcboProtocol_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcboProtocol_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcboProtocol_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcboProtocol_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcboProtocol_SelectedIndexChanged);
            var methodcboProtocol_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcboProtocol_SelectedIndexChanged, methodcboProtocol_SelectedIndexChangedParametersTypes);

            // Assert
            methodcboProtocol_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cboProtocol_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cboProtocol_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcboProtocol_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcboProtocol_SelectedIndexChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodcmbApplicationName_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcmbApplicationName_SelectedIndexChanged, methodcmbApplicationName_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmbApplicationName_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmbApplicationName_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmbApplicationName_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcmbApplicationName_SelectedIndexChanged, methodcmbApplicationName_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfcmbApplicationName_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcmbApplicationName_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcmbApplicationName_SelectedIndexChanged.Length.ShouldBe(2);
            methodcmbApplicationName_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcmbApplicationName_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcmbApplicationName_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmbApplicationName_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcmbApplicationName_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcmbApplicationName_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcmbApplicationName_SelectedIndexChanged, parametersOfcmbApplicationName_SelectedIndexChanged, methodcmbApplicationName_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOfcmbApplicationName_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcmbApplicationName_SelectedIndexChanged.Length.ShouldBe(2);
            methodcmbApplicationName_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcmbApplicationName_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcmbApplicationName_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmbApplicationName_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcmbApplicationName_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmbApplicationName_SelectedIndexChanged);
            var methodcmbApplicationName_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcmbApplicationName_SelectedIndexChanged, methodcmbApplicationName_SelectedIndexChangedParametersTypes);

            // Assert
            methodcmbApplicationName_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cmbApplicationName_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_cmbApplicationName_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcmbApplicationName_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcmbApplicationName_SelectedIndexChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodlstLoggingValues_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlstLoggingValues_SelectedIndexChanged, methodlstLoggingValues_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlstLoggingValues_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodlstLoggingValues_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOflstLoggingValues_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodlstLoggingValues_SelectedIndexChanged, methodlstLoggingValues_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOflstLoggingValues_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOflstLoggingValues_SelectedIndexChanged.ShouldNotBeNull();
            parametersOflstLoggingValues_SelectedIndexChanged.Length.ShouldBe(2);
            methodlstLoggingValues_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodlstLoggingValues_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOflstLoggingValues_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlstLoggingValues_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodlstLoggingValues_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOflstLoggingValues_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodlstLoggingValues_SelectedIndexChanged, parametersOflstLoggingValues_SelectedIndexChanged, methodlstLoggingValues_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOflstLoggingValues_SelectedIndexChanged.ShouldNotBeNull();
            parametersOflstLoggingValues_SelectedIndexChanged.Length.ShouldBe(2);
            methodlstLoggingValues_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodlstLoggingValues_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOflstLoggingValues_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlstLoggingValues_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodlstLoggingValues_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlstLoggingValues_SelectedIndexChanged);
            var methodlstLoggingValues_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlstLoggingValues_SelectedIndexChanged, methodlstLoggingValues_SelectedIndexChangedParametersTypes);

            // Assert
            methodlstLoggingValues_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lstLoggingValues_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_lstLoggingValues_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlstLoggingValues_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodlstLoggingValues_SelectedIndexChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_Internally(Type[] types)
        {
            var methodOEASConfigTool_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOEASConfigTool_Load, methodOEASConfigTool_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOEASConfigTool_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOEASConfigTool_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOEASConfigTool_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOEASConfigTool_Load, methodOEASConfigTool_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfOEASConfigTool_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOEASConfigTool_Load.ShouldNotBeNull();
            parametersOfOEASConfigTool_Load.Length.ShouldBe(2);
            methodOEASConfigTool_LoadParametersTypes.Length.ShouldBe(2);
            methodOEASConfigTool_LoadParametersTypes.Length.ShouldBe(parametersOfOEASConfigTool_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOEASConfigTool_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOEASConfigTool_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOEASConfigTool_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOEASConfigTool_Load, parametersOfOEASConfigTool_Load, methodOEASConfigTool_LoadParametersTypes);

            // Assert
            parametersOfOEASConfigTool_Load.ShouldNotBeNull();
            parametersOfOEASConfigTool_Load.Length.ShouldBe(2);
            methodOEASConfigTool_LoadParametersTypes.Length.ShouldBe(2);
            methodOEASConfigTool_LoadParametersTypes.Length.ShouldBe(parametersOfOEASConfigTool_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOEASConfigTool_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodOEASConfigTool_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOEASConfigTool_Load);
            var methodOEASConfigTool_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOEASConfigTool_Load, methodOEASConfigTool_LoadParametersTypes);

            // Assert
            methodOEASConfigTool_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OEASConfigTool_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_OEASConfigTool_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOEASConfigTool_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodOEASConfigTool_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadApplicationData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_LoadApplicationData_Method_Call_Internally(Type[] types)
        {
            var methodLoadApplicationDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadApplicationData, methodLoadApplicationDataParametersTypes);
        }

        #endregion

        #region Method Call : (LoadApplicationData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_LoadApplicationData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadApplicationData);
            Type [] methodLoadApplicationDataParametersTypes = null;
            object[] parametersOfLoadApplicationData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadApplicationData, methodLoadApplicationDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfLoadApplicationData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadApplicationData.ShouldBeNull();
            methodLoadApplicationDataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LoadApplicationData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_LoadApplicationData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadApplicationData);
            Type [] methodLoadApplicationDataParametersTypes = null;
            object[] parametersOfLoadApplicationData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadApplicationData, parametersOfLoadApplicationData, methodLoadApplicationDataParametersTypes);

            // Assert
            parametersOfLoadApplicationData.ShouldBeNull();
            methodLoadApplicationDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadApplicationData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_LoadApplicationData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadApplicationData);
            Type [] methodLoadApplicationDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadApplicationData, methodLoadApplicationDataParametersTypes);

            // Assert
            methodLoadApplicationDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadApplicationData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_LoadApplicationData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadApplicationData);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadApplicationData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeApplicationControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_InitializeApplicationControls_Method_Call_Internally(Type[] types)
        {
            var methodInitializeApplicationControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeApplicationControls, methodInitializeApplicationControlsParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeApplicationControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeApplicationControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeApplicationControls);
            Type [] methodInitializeApplicationControlsParametersTypes = null;
            object[] parametersOfInitializeApplicationControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeApplicationControls, methodInitializeApplicationControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfInitializeApplicationControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeApplicationControls.ShouldBeNull();
            methodInitializeApplicationControlsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeApplicationControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeApplicationControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeApplicationControls);
            Type [] methodInitializeApplicationControlsParametersTypes = null;
            object[] parametersOfInitializeApplicationControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeApplicationControls, parametersOfInitializeApplicationControls, methodInitializeApplicationControlsParametersTypes);

            // Assert
            parametersOfInitializeApplicationControls.ShouldBeNull();
            methodInitializeApplicationControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeApplicationControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeApplicationControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeApplicationControls);
            Type [] methodInitializeApplicationControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeApplicationControls, methodInitializeApplicationControlsParametersTypes);

            // Assert
            methodInitializeApplicationControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeApplicationControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeApplicationControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeApplicationControls);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeApplicationControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLoggingControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_InitializeLoggingControls_Method_Call_Internally(Type[] types)
        {
            var methodInitializeLoggingControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeLoggingControls, methodInitializeLoggingControlsParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeLoggingControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeLoggingControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLoggingControls);
            Type [] methodInitializeLoggingControlsParametersTypes = null;
            object[] parametersOfInitializeLoggingControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeLoggingControls, methodInitializeLoggingControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfInitializeLoggingControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeLoggingControls.ShouldBeNull();
            methodInitializeLoggingControlsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLoggingControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeLoggingControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLoggingControls);
            Type [] methodInitializeLoggingControlsParametersTypes = null;
            object[] parametersOfInitializeLoggingControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeLoggingControls, parametersOfInitializeLoggingControls, methodInitializeLoggingControlsParametersTypes);

            // Assert
            parametersOfInitializeLoggingControls.ShouldBeNull();
            methodInitializeLoggingControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLoggingControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeLoggingControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLoggingControls);
            Type [] methodInitializeLoggingControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeLoggingControls, methodInitializeLoggingControlsParametersTypes);

            // Assert
            methodInitializeLoggingControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLoggingControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_InitializeLoggingControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLoggingControls);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeLoggingControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_WriteEnabled_Method_Call_Internally(Type[] types)
        {
            var methodWriteEnabledParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteEnabled, methodWriteEnabledParametersTypes);
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_WriteEnabled_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEnabled);
            Type [] methodWriteEnabledParametersTypes = null;
            object[] parametersOfWriteEnabled = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEnabled, methodWriteEnabledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, parametersOfWriteEnabled);
            var result2 = this.GetResultOfMethod<bool>(MethodWriteEnabled, parametersOfWriteEnabled, methodWriteEnabledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWriteEnabled.ShouldBeNull();
            methodWriteEnabledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_WriteEnabled_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEnabled);
            Type [] methodWriteEnabledParametersTypes = null;
            object[] parametersOfWriteEnabled = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEnabled, methodWriteEnabledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, out exception1, parametersOfWriteEnabled);
            var result2 = this.GetResultOfMethod<bool>(MethodWriteEnabled, parametersOfWriteEnabled, methodWriteEnabledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWriteEnabled.ShouldBeNull();
            methodWriteEnabledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_WriteEnabled_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEnabled);
            Type [] methodWriteEnabledParametersTypes = null;
            object[] parametersOfWriteEnabled = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodWriteEnabled, parametersOfWriteEnabled, methodWriteEnabledParametersTypes);

            // Assert
            parametersOfWriteEnabled.ShouldBeNull();
            methodWriteEnabledParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_WriteEnabled_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEnabled);
            Type [] methodWriteEnabledParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteEnabled, methodWriteEnabledParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWriteEnabledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WriteEnabled) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_WriteEnabled_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEnabled);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEnabled, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_GetApplicationData_Method_Call_Internally(Type[] types)
        {
            var methodGetApplicationDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetApplicationData, methodGetApplicationDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetApplicationData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationData);
            Type [] methodGetApplicationDataParametersTypes = null;
            object[] parametersOfGetApplicationData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationData, methodGetApplicationDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, parametersOfGetApplicationData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetApplicationData, parametersOfGetApplicationData, methodGetApplicationDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetApplicationData.ShouldBeNull();
            methodGetApplicationDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetApplicationData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationData);
            Type [] methodGetApplicationDataParametersTypes = null;
            object[] parametersOfGetApplicationData = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationData, methodGetApplicationDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, out exception1, parametersOfGetApplicationData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetApplicationData, parametersOfGetApplicationData, methodGetApplicationDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetApplicationData.ShouldBeNull();
            methodGetApplicationDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetApplicationData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationData);
            Type [] methodGetApplicationDataParametersTypes = null;
            object[] parametersOfGetApplicationData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetApplicationData, parametersOfGetApplicationData, methodGetApplicationDataParametersTypes);

            // Assert
            parametersOfGetApplicationData.ShouldBeNull();
            methodGetApplicationDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetApplicationData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationData);
            Type [] methodGetApplicationDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetApplicationData, methodGetApplicationDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetApplicationDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationData) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetApplicationData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOGSData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_GetOGSData_Method_Call_Internally(Type[] types)
        {
            var methodGetOGSDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOGSData, methodGetOGSDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetOGSData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOGSData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOGSData);
            Type [] methodGetOGSDataParametersTypes = null;
            object[] parametersOfGetOGSData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOGSData, methodGetOGSDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfGetOGSData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOGSData.ShouldBeNull();
            methodGetOGSDataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOGSData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOGSData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOGSData);
            Type [] methodGetOGSDataParametersTypes = null;
            object[] parametersOfGetOGSData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetOGSData, parametersOfGetOGSData, methodGetOGSDataParametersTypes);

            // Assert
            parametersOfGetOGSData.ShouldBeNull();
            methodGetOGSDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOGSData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOGSData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOGSData);
            Type [] methodGetOGSDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOGSData, methodGetOGSDataParametersTypes);

            // Assert
            methodGetOGSDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOGSData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOGSData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOGSData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOGSData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_GetLoggingData_Method_Call_Internally(Type[] types)
        {
            var methodGetLoggingDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLoggingData, methodGetLoggingDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetLoggingData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoggingData);
            Type [] methodGetLoggingDataParametersTypes = null;
            object[] parametersOfGetLoggingData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoggingData, methodGetLoggingDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, parametersOfGetLoggingData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetLoggingData, parametersOfGetLoggingData, methodGetLoggingDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetLoggingData.ShouldBeNull();
            methodGetLoggingDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetLoggingData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoggingData);
            Type [] methodGetLoggingDataParametersTypes = null;
            object[] parametersOfGetLoggingData = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoggingData, methodGetLoggingDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, out exception1, parametersOfGetLoggingData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetLoggingData, parametersOfGetLoggingData, methodGetLoggingDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetLoggingData.ShouldBeNull();
            methodGetLoggingDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetLoggingData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoggingData);
            Type [] methodGetLoggingDataParametersTypes = null;
            object[] parametersOfGetLoggingData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetLoggingData, parametersOfGetLoggingData, methodGetLoggingDataParametersTypes);

            // Assert
            parametersOfGetLoggingData.ShouldBeNull();
            methodGetLoggingDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetLoggingData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoggingData);
            Type [] methodGetLoggingDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLoggingData, methodGetLoggingDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLoggingDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLoggingData) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetLoggingData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoggingData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoggingData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_GetEmailData_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailData, methodGetEmailDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetEmailData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailData);
            Type [] methodGetEmailDataParametersTypes = null;
            object[] parametersOfGetEmailData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailData, methodGetEmailDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, parametersOfGetEmailData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetEmailData, parametersOfGetEmailData, methodGetEmailDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailData.ShouldBeNull();
            methodGetEmailDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetEmailData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailData);
            Type [] methodGetEmailDataParametersTypes = null;
            object[] parametersOfGetEmailData = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailData, methodGetEmailDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, out exception1, parametersOfGetEmailData);
            var result2 = this.GetResultOfMethod<bool>(MethodGetEmailData, parametersOfGetEmailData, methodGetEmailDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailData.ShouldBeNull();
            methodGetEmailDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetEmailData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailData);
            Type [] methodGetEmailDataParametersTypes = null;
            object[] parametersOfGetEmailData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetEmailData, parametersOfGetEmailData, methodGetEmailDataParametersTypes);

            // Assert
            parametersOfGetEmailData.ShouldBeNull();
            methodGetEmailDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetEmailData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailData);
            Type [] methodGetEmailDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailData, methodGetEmailDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailData) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetEmailData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveOGS) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SaveOGS_Method_Call_Internally(Type[] types)
        {
            var methodSaveOGSParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveOGS, methodSaveOGSParametersTypes);
        }

        #endregion

        #region Method Call : (SaveOGS) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SaveOGS_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveOGS);
            Type [] methodSaveOGSParametersTypes = null;
            object[] parametersOfSaveOGS = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveOGS, methodSaveOGSParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSaveOGS);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSaveOGS.ShouldBeNull();
            methodSaveOGSParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SaveOGS) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SaveOGS_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveOGS);
            Type [] methodSaveOGSParametersTypes = null;
            object[] parametersOfSaveOGS = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSaveOGS, parametersOfSaveOGS, methodSaveOGSParametersTypes);

            // Assert
            parametersOfSaveOGS.ShouldBeNull();
            methodSaveOGSParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveOGS) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SaveOGS_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveOGS);
            Type [] methodSaveOGSParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveOGS, methodSaveOGSParametersTypes);

            // Assert
            methodSaveOGSParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveOGS) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SaveOGS_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveOGS);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveOGS, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetStringProperty_Method_Call_Internally(Type[] types)
        {
            var methodSetStringPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetStringProperty, methodSetStringPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var sApplication = this.CreateType<string>();
            var sGroup = this.CreateType<string>();
            var sPropName = this.CreateType<string>();
            var sPropertyValue = this.CreateType<string>();
            var bEncrypt = this.CreateType<bool>();
            var EncryptionKey = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASConfigToolInstance.SetStringProperty(sApplication, sGroup, sPropName, sPropertyValue, bEncrypt, EncryptionKey);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var sApplication = this.CreateType<string>();
            var sGroup = this.CreateType<string>();
            var sPropName = this.CreateType<string>();
            var sPropertyValue = this.CreateType<string>();
            var bEncrypt = this.CreateType<bool>();
            var EncryptionKey = this.CreateType<string>();
            var methodSetStringPropertyParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(string) };
            object[] parametersOfSetStringProperty = { sApplication, sGroup, sPropName, sPropertyValue, bEncrypt, EncryptionKey };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetStringProperty, methodSetStringPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetStringProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetStringProperty.ShouldNotBeNull();
            parametersOfSetStringProperty.Length.ShouldBe(6);
            methodSetStringPropertyParametersTypes.Length.ShouldBe(6);
            methodSetStringPropertyParametersTypes.Length.ShouldBe(parametersOfSetStringProperty.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var sApplication = this.CreateType<string>();
            var sGroup = this.CreateType<string>();
            var sPropName = this.CreateType<string>();
            var sPropertyValue = this.CreateType<string>();
            var bEncrypt = this.CreateType<bool>();
            var EncryptionKey = this.CreateType<string>();
            var methodSetStringPropertyParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(string) };
            object[] parametersOfSetStringProperty = { sApplication, sGroup, sPropName, sPropertyValue, bEncrypt, EncryptionKey };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetStringProperty, parametersOfSetStringProperty, methodSetStringPropertyParametersTypes);

            // Assert
            parametersOfSetStringProperty.ShouldNotBeNull();
            parametersOfSetStringProperty.Length.ShouldBe(6);
            methodSetStringPropertyParametersTypes.Length.ShouldBe(6);
            methodSetStringPropertyParametersTypes.Length.ShouldBe(parametersOfSetStringProperty.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetStringProperty, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var methodSetStringPropertyParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetStringProperty, methodSetStringPropertyParametersTypes);

            // Assert
            methodSetStringPropertyParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetStringProperty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetStringProperty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetStringProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetStringProperty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_Encrypt_Method_Call_Internally(Type[] types)
        {
            var methodEncryptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var Value = this.CreateType<string>();
            var doEncryption = this.CreateType<bool>();

            // Act
            Action executeAction = () => _oEASConfigToolInstance.Encrypt(Value, doEncryption);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var Value = this.CreateType<string>();
            var doEncryption = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASConfigToolInstance.Encrypt(Value, doEncryption);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var Value = this.CreateType<string>();
            var doEncryption = this.CreateType<bool>();
            var methodEncryptParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfEncrypt = { Value, doEncryption };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, methodEncryptParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASConfigToolInstanceFixture, parametersOfEncrypt);
            var result2 = this.GetResultOfMethod<string>(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEncrypt.ShouldNotBeNull();
            parametersOfEncrypt.Length.ShouldBe(2);
            methodEncryptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var Value = this.CreateType<string>();
            var doEncryption = this.CreateType<bool>();
            var methodEncryptParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfEncrypt = { Value, doEncryption };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes);

            // Assert
            parametersOfEncrypt.ShouldNotBeNull();
            parametersOfEncrypt.Length.ShouldBe(2);
            methodEncryptParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var methodEncryptParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEncryptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var methodEncryptParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncryptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_Encrypt_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetAppDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetAppDirty_Method_Call_Internally(Type[] types)
        {
            var methodSetAppDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetAppDirty, methodSetAppDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (SetAppDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetAppDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAppDirty);
            Type [] methodSetAppDirtyParametersTypes = null;
            object[] parametersOfSetAppDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetAppDirty, methodSetAppDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetAppDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetAppDirty.ShouldBeNull();
            methodSetAppDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetAppDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetAppDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAppDirty);
            Type [] methodSetAppDirtyParametersTypes = null;
            object[] parametersOfSetAppDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetAppDirty, parametersOfSetAppDirty, methodSetAppDirtyParametersTypes);

            // Assert
            parametersOfSetAppDirty.ShouldBeNull();
            methodSetAppDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAppDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetAppDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAppDirty);
            Type [] methodSetAppDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetAppDirty, methodSetAppDirtyParametersTypes);

            // Assert
            methodSetAppDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAppDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetAppDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAppDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetAppDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLogDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetLogDirty_Method_Call_Internally(Type[] types)
        {
            var methodSetLogDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetLogDirty, methodSetLogDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (SetLogDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetLogDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLogDirty);
            Type [] methodSetLogDirtyParametersTypes = null;
            object[] parametersOfSetLogDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetLogDirty, methodSetLogDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetLogDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetLogDirty.ShouldBeNull();
            methodSetLogDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetLogDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetLogDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLogDirty);
            Type [] methodSetLogDirtyParametersTypes = null;
            object[] parametersOfSetLogDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetLogDirty, parametersOfSetLogDirty, methodSetLogDirtyParametersTypes);

            // Assert
            parametersOfSetLogDirty.ShouldBeNull();
            methodSetLogDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLogDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetLogDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLogDirty);
            Type [] methodSetLogDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetLogDirty, methodSetLogDirtyParametersTypes);

            // Assert
            methodSetLogDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLogDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetLogDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLogDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLogDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetEmailDirty_Method_Call_Internally(Type[] types)
        {
            var methodSetEmailDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetEmailDirty, methodSetEmailDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (SetEmailDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailDirty);
            Type [] methodSetEmailDirtyParametersTypes = null;
            object[] parametersOfSetEmailDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetEmailDirty, methodSetEmailDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetEmailDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetEmailDirty.ShouldBeNull();
            methodSetEmailDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailDirty);
            Type [] methodSetEmailDirtyParametersTypes = null;
            object[] parametersOfSetEmailDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetEmailDirty, parametersOfSetEmailDirty, methodSetEmailDirtyParametersTypes);

            // Assert
            parametersOfSetEmailDirty.ShouldBeNull();
            methodSetEmailDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailDirty);
            Type [] methodSetEmailDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetEmailDirty, methodSetEmailDirtyParametersTypes);

            // Assert
            methodSetEmailDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetEmailDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetOGSDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetOGSDirty_Method_Call_Internally(Type[] types)
        {
            var methodSetOGSDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetOGSDirty, methodSetOGSDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (SetOGSDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetOGSDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOGSDirty);
            Type [] methodSetOGSDirtyParametersTypes = null;
            object[] parametersOfSetOGSDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetOGSDirty, methodSetOGSDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetOGSDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetOGSDirty.ShouldBeNull();
            methodSetOGSDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetOGSDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetOGSDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOGSDirty);
            Type [] methodSetOGSDirtyParametersTypes = null;
            object[] parametersOfSetOGSDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetOGSDirty, parametersOfSetOGSDirty, methodSetOGSDirtyParametersTypes);

            // Assert
            parametersOfSetOGSDirty.ShouldBeNull();
            methodSetOGSDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetOGSDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetOGSDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOGSDirty);
            Type [] methodSetOGSDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetOGSDirty, methodSetOGSDirtyParametersTypes);

            // Assert
            methodSetOGSDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetOGSDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetOGSDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOGSDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodSetOGSDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearAppDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_ClearAppDirty_Method_Call_Internally(Type[] types)
        {
            var methodClearAppDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearAppDirty, methodClearAppDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (ClearAppDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearAppDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearAppDirty);
            Type [] methodClearAppDirtyParametersTypes = null;
            object[] parametersOfClearAppDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearAppDirty, methodClearAppDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfClearAppDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearAppDirty.ShouldBeNull();
            methodClearAppDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearAppDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearAppDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearAppDirty);
            Type [] methodClearAppDirtyParametersTypes = null;
            object[] parametersOfClearAppDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearAppDirty, parametersOfClearAppDirty, methodClearAppDirtyParametersTypes);

            // Assert
            parametersOfClearAppDirty.ShouldBeNull();
            methodClearAppDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearAppDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearAppDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearAppDirty);
            Type [] methodClearAppDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearAppDirty, methodClearAppDirtyParametersTypes);

            // Assert
            methodClearAppDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearAppDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearAppDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearAppDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodClearAppDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearLogDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_ClearLogDirty_Method_Call_Internally(Type[] types)
        {
            var methodClearLogDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearLogDirty, methodClearLogDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (ClearLogDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearLogDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearLogDirty);
            Type [] methodClearLogDirtyParametersTypes = null;
            object[] parametersOfClearLogDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearLogDirty, methodClearLogDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfClearLogDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearLogDirty.ShouldBeNull();
            methodClearLogDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearLogDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearLogDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearLogDirty);
            Type [] methodClearLogDirtyParametersTypes = null;
            object[] parametersOfClearLogDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearLogDirty, parametersOfClearLogDirty, methodClearLogDirtyParametersTypes);

            // Assert
            parametersOfClearLogDirty.ShouldBeNull();
            methodClearLogDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearLogDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearLogDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearLogDirty);
            Type [] methodClearLogDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearLogDirty, methodClearLogDirtyParametersTypes);

            // Assert
            methodClearLogDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearLogDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearLogDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearLogDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodClearLogDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearEmailDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_ClearEmailDirty_Method_Call_Internally(Type[] types)
        {
            var methodClearEmailDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearEmailDirty, methodClearEmailDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (ClearEmailDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearEmailDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearEmailDirty);
            Type [] methodClearEmailDirtyParametersTypes = null;
            object[] parametersOfClearEmailDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearEmailDirty, methodClearEmailDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfClearEmailDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearEmailDirty.ShouldBeNull();
            methodClearEmailDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearEmailDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearEmailDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearEmailDirty);
            Type [] methodClearEmailDirtyParametersTypes = null;
            object[] parametersOfClearEmailDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearEmailDirty, parametersOfClearEmailDirty, methodClearEmailDirtyParametersTypes);

            // Assert
            parametersOfClearEmailDirty.ShouldBeNull();
            methodClearEmailDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearEmailDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearEmailDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearEmailDirty);
            Type [] methodClearEmailDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearEmailDirty, methodClearEmailDirtyParametersTypes);

            // Assert
            methodClearEmailDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearEmailDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearEmailDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearEmailDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodClearEmailDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearOGSDirty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_ClearOGSDirty_Method_Call_Internally(Type[] types)
        {
            var methodClearOGSDirtyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearOGSDirty, methodClearOGSDirtyParametersTypes);
        }

        #endregion

        #region Method Call : (ClearOGSDirty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearOGSDirty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearOGSDirty);
            Type [] methodClearOGSDirtyParametersTypes = null;
            object[] parametersOfClearOGSDirty = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearOGSDirty, methodClearOGSDirtyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfClearOGSDirty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearOGSDirty.ShouldBeNull();
            methodClearOGSDirtyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearOGSDirty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearOGSDirty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearOGSDirty);
            Type [] methodClearOGSDirtyParametersTypes = null;
            object[] parametersOfClearOGSDirty = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearOGSDirty, parametersOfClearOGSDirty, methodClearOGSDirtyParametersTypes);

            // Assert
            parametersOfClearOGSDirty.ShouldBeNull();
            methodClearOGSDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearOGSDirty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearOGSDirty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearOGSDirty);
            Type [] methodClearOGSDirtyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearOGSDirty, methodClearOGSDirtyParametersTypes);

            // Assert
            methodClearOGSDirtyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearOGSDirty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_ClearOGSDirty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearOGSDirty);
            var currentMethodInfo = this.GetMethodInfo(MethodClearOGSDirty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCmdButton) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetCmdButton_Method_Call_Internally(Type[] types)
        {
            var methodSetCmdButtonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetCmdButton, methodSetCmdButtonParametersTypes);
        }

        #endregion

        #region Method Call : (SetCmdButton) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetCmdButton_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCmdButton);
            Type [] methodSetCmdButtonParametersTypes = null;
            object[] parametersOfSetCmdButton = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetCmdButton, methodSetCmdButtonParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetCmdButton);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetCmdButton.ShouldBeNull();
            methodSetCmdButtonParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetCmdButton) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetCmdButton_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCmdButton);
            Type [] methodSetCmdButtonParametersTypes = null;
            object[] parametersOfSetCmdButton = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetCmdButton, parametersOfSetCmdButton, methodSetCmdButtonParametersTypes);

            // Assert
            parametersOfSetCmdButton.ShouldBeNull();
            methodSetCmdButtonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCmdButton) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetCmdButton_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCmdButton);
            Type [] methodSetCmdButtonParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetCmdButton, methodSetCmdButtonParametersTypes);

            // Assert
            methodSetCmdButtonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCmdButton) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetCmdButton_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCmdButton);
            var currentMethodInfo = this.GetMethodInfo(MethodSetCmdButton, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailCmdButton) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_SetEmailCmdButton_Method_Call_Internally(Type[] types)
        {
            var methodSetEmailCmdButtonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetEmailCmdButton, methodSetEmailCmdButtonParametersTypes);
        }

        #endregion

        #region Method Call : (SetEmailCmdButton) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailCmdButton_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailCmdButton);
            Type [] methodSetEmailCmdButtonParametersTypes = null;
            object[] parametersOfSetEmailCmdButton = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetEmailCmdButton, methodSetEmailCmdButtonParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfSetEmailCmdButton);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetEmailCmdButton.ShouldBeNull();
            methodSetEmailCmdButtonParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailCmdButton) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailCmdButton_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailCmdButton);
            Type [] methodSetEmailCmdButtonParametersTypes = null;
            object[] parametersOfSetEmailCmdButton = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetEmailCmdButton, parametersOfSetEmailCmdButton, methodSetEmailCmdButtonParametersTypes);

            // Assert
            parametersOfSetEmailCmdButton.ShouldBeNull();
            methodSetEmailCmdButtonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailCmdButton) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailCmdButton_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailCmdButton);
            Type [] methodSetEmailCmdButtonParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetEmailCmdButton, methodSetEmailCmdButtonParametersTypes);

            // Assert
            methodSetEmailCmdButtonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetEmailCmdButton) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_SetEmailCmdButton_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetEmailCmdButton);
            var currentMethodInfo = this.GetMethodInfo(MethodSetEmailCmdButton, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_Internally(Type[] types)
        {
            var methodGetOEASRegistryPathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes);
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEASRegistryPath);
            Type [] methodGetOEASRegistryPathParametersTypes = null;
            object[] parametersOfGetOEASRegistryPath = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASConfigToolInstanceFixture, parametersOfGetOEASRegistryPath);
            var result2 = this.GetResultOfMethod<string>(MethodGetOEASRegistryPath, parametersOfGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOEASRegistryPath.ShouldBeNull();
            methodGetOEASRegistryPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEASRegistryPath);
            Type [] methodGetOEASRegistryPathParametersTypes = null;
            object[] parametersOfGetOEASRegistryPath = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetOEASRegistryPath, parametersOfGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes);

            // Assert
            parametersOfGetOEASRegistryPath.ShouldBeNull();
            methodGetOEASRegistryPathParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEASRegistryPath);
            Type [] methodGetOEASRegistryPathParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOEASRegistryPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEASRegistryPath);
            Type [] methodGetOEASRegistryPathParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOEASRegistryPath, methodGetOEASRegistryPathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOEASRegistryPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOEASRegistryPath) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_GetOEASRegistryPath_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOEASRegistryPath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOEASRegistryPath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtServer_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtServer_TextChanged, methodtxtServer_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtServer_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtServer_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_TextChanged, methodtxtServer_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtServer_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtServer_TextChanged.ShouldNotBeNull();
            parametersOftxtServer_TextChanged.Length.ShouldBe(2);
            methodtxtServer_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtServer_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtServer_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtServer_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtServer_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtServer_TextChanged, parametersOftxtServer_TextChanged, methodtxtServer_TextChangedParametersTypes);

            // Assert
            parametersOftxtServer_TextChanged.ShouldNotBeNull();
            parametersOftxtServer_TextChanged.Length.ShouldBe(2);
            methodtxtServer_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtServer_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtServer_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_TextChanged);
            var methodtxtServer_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtServer_TextChanged, methodtxtServer_TextChangedParametersTypes);

            // Assert
            methodtxtServer_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtDatabase_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_TextChanged, methodtxtDatabase_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtDatabase_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_TextChanged, methodtxtDatabase_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtDatabase_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtDatabase_TextChanged.ShouldNotBeNull();
            parametersOftxtDatabase_TextChanged.Length.ShouldBe(2);
            methodtxtDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtDatabase_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtDatabase_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtDatabase_TextChanged, parametersOftxtDatabase_TextChanged, methodtxtDatabase_TextChangedParametersTypes);

            // Assert
            parametersOftxtDatabase_TextChanged.ShouldNotBeNull();
            parametersOftxtDatabase_TextChanged.Length.ShouldBe(2);
            methodtxtDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtDatabase_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_TextChanged);
            var methodtxtDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_TextChanged, methodtxtDatabase_TextChangedParametersTypes);

            // Assert
            methodtxtDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtPDatabase_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_TextChanged, methodtxtPDatabase_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPDatabase_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_TextChanged, methodtxtPDatabase_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPDatabase_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPDatabase_TextChanged.ShouldNotBeNull();
            parametersOftxtPDatabase_TextChanged.Length.ShouldBe(2);
            methodtxtPDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPDatabase_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPDatabase_TextChanged, parametersOftxtPDatabase_TextChanged, methodtxtPDatabase_TextChangedParametersTypes);

            // Assert
            parametersOftxtPDatabase_TextChanged.ShouldNotBeNull();
            parametersOftxtPDatabase_TextChanged.Length.ShouldBe(2);
            methodtxtPDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_TextChanged);
            var methodtxtPDatabase_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_TextChanged, methodtxtPDatabase_TextChangedParametersTypes);

            // Assert
            methodtxtPDatabase_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtUserID_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtUserID_TextChanged, methodtxtUserID_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtUserID_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtUserID_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_TextChanged, methodtxtUserID_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtUserID_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtUserID_TextChanged.ShouldNotBeNull();
            parametersOftxtUserID_TextChanged.Length.ShouldBe(2);
            methodtxtUserID_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtUserID_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtUserID_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtUserID_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtUserID_TextChanged, parametersOftxtUserID_TextChanged, methodtxtUserID_TextChangedParametersTypes);

            // Assert
            parametersOftxtUserID_TextChanged.ShouldNotBeNull();
            parametersOftxtUserID_TextChanged.Length.ShouldBe(2);
            methodtxtUserID_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtUserID_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_TextChanged);
            var methodtxtUserID_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtUserID_TextChanged, methodtxtUserID_TextChangedParametersTypes);

            // Assert
            methodtxtUserID_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtPassword_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPassword_TextChanged, methodtxtPassword_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPassword_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPassword_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_TextChanged, methodtxtPassword_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPassword_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPassword_TextChanged.ShouldNotBeNull();
            parametersOftxtPassword_TextChanged.Length.ShouldBe(2);
            methodtxtPassword_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPassword_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPassword_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPassword_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPassword_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPassword_TextChanged, parametersOftxtPassword_TextChanged, methodtxtPassword_TextChangedParametersTypes);

            // Assert
            parametersOftxtPassword_TextChanged.ShouldNotBeNull();
            parametersOftxtPassword_TextChanged.Length.ShouldBe(2);
            methodtxtPassword_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPassword_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPassword_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_TextChanged);
            var methodtxtPassword_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPassword_TextChanged, methodtxtPassword_TextChangedParametersTypes);

            // Assert
            methodtxtPassword_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtConnectionTimeout_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_TextChanged, methodtxtConnectionTimeout_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtConnectionTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtConnectionTimeout_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_TextChanged, methodtxtConnectionTimeout_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtConnectionTimeout_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtConnectionTimeout_TextChanged.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_TextChanged.Length.ShouldBe(2);
            methodtxtConnectionTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtConnectionTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtConnectionTimeout_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtConnectionTimeout_TextChanged, parametersOftxtConnectionTimeout_TextChanged, methodtxtConnectionTimeout_TextChangedParametersTypes);

            // Assert
            parametersOftxtConnectionTimeout_TextChanged.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_TextChanged.Length.ShouldBe(2);
            methodtxtConnectionTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_TextChanged);
            var methodtxtConnectionTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_TextChanged, methodtxtConnectionTimeout_TextChangedParametersTypes);

            // Assert
            methodtxtConnectionTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtQueryTimeout_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_TextChanged, methodtxtQueryTimeout_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtQueryTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtQueryTimeout_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_TextChanged, methodtxtQueryTimeout_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtQueryTimeout_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtQueryTimeout_TextChanged.ShouldNotBeNull();
            parametersOftxtQueryTimeout_TextChanged.Length.ShouldBe(2);
            methodtxtQueryTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtQueryTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtQueryTimeout_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtQueryTimeout_TextChanged, parametersOftxtQueryTimeout_TextChanged, methodtxtQueryTimeout_TextChangedParametersTypes);

            // Assert
            parametersOftxtQueryTimeout_TextChanged.ShouldNotBeNull();
            parametersOftxtQueryTimeout_TextChanged.Length.ShouldBe(2);
            methodtxtQueryTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_TextChanged);
            var methodtxtQueryTimeout_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_TextChanged, methodtxtQueryTimeout_TextChangedParametersTypes);

            // Assert
            methodtxtQueryTimeout_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtMaxRows_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_TextChanged, methodtxtMaxRows_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtMaxRows_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtMaxRows_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_TextChanged, methodtxtMaxRows_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtMaxRows_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtMaxRows_TextChanged.ShouldNotBeNull();
            parametersOftxtMaxRows_TextChanged.Length.ShouldBe(2);
            methodtxtMaxRows_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtMaxRows_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtMaxRows_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtMaxRows_TextChanged, parametersOftxtMaxRows_TextChanged, methodtxtMaxRows_TextChangedParametersTypes);

            // Assert
            parametersOftxtMaxRows_TextChanged.ShouldNotBeNull();
            parametersOftxtMaxRows_TextChanged.Length.ShouldBe(2);
            methodtxtMaxRows_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_TextChanged);
            var methodtxtMaxRows_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_TextChanged, methodtxtMaxRows_TextChangedParametersTypes);

            // Assert
            methodtxtMaxRows_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtOrgId_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtOrgId_TextChanged, methodtxtOrgId_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtOrgId_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtOrgId_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_TextChanged, methodtxtOrgId_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtOrgId_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtOrgId_TextChanged.ShouldNotBeNull();
            parametersOftxtOrgId_TextChanged.Length.ShouldBe(2);
            methodtxtOrgId_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtOrgId_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtOrgId_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtOrgId_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtOrgId_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtOrgId_TextChanged, parametersOftxtOrgId_TextChanged, methodtxtOrgId_TextChangedParametersTypes);

            // Assert
            parametersOftxtOrgId_TextChanged.ShouldNotBeNull();
            parametersOftxtOrgId_TextChanged.Length.ShouldBe(2);
            methodtxtOrgId_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtOrgId_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtOrgId_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_TextChanged);
            var methodtxtOrgId_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtOrgId_TextChanged, methodtxtOrgId_TextChangedParametersTypes);

            // Assert
            methodtxtOrgId_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtPort_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPort_TextChanged, methodtxtPort_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPort_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_TextChanged, methodtxtPort_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPort_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPort_TextChanged.ShouldNotBeNull();
            parametersOftxtPort_TextChanged.Length.ShouldBe(2);
            methodtxtPort_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPort_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPort_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPort_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPort_TextChanged, parametersOftxtPort_TextChanged, methodtxtPort_TextChangedParametersTypes);

            // Assert
            parametersOftxtPort_TextChanged.ShouldNotBeNull();
            parametersOftxtPort_TextChanged.Length.ShouldBe(2);
            methodtxtPort_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtPort_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtPort_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_TextChanged);
            var methodtxtPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPort_TextChanged, methodtxtPort_TextChangedParametersTypes);

            // Assert
            methodtxtPort_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtKey_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtKey_TextChanged, methodtxtKey_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtKey_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtKey_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_TextChanged, methodtxtKey_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtKey_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtKey_TextChanged.ShouldNotBeNull();
            parametersOftxtKey_TextChanged.Length.ShouldBe(2);
            methodtxtKey_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtKey_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtKey_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtKey_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtKey_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtKey_TextChanged, parametersOftxtKey_TextChanged, methodtxtKey_TextChangedParametersTypes);

            // Assert
            parametersOftxtKey_TextChanged.ShouldNotBeNull();
            parametersOftxtKey_TextChanged.Length.ShouldBe(2);
            methodtxtKey_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtKey_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtKey_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_TextChanged);
            var methodtxtKey_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtKey_TextChanged, methodtxtKey_TextChangedParametersTypes);

            // Assert
            methodtxtKey_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtValue_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtValue_TextChanged, methodtxtValue_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtValue_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtValue_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_TextChanged, methodtxtValue_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtValue_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtValue_TextChanged.ShouldNotBeNull();
            parametersOftxtValue_TextChanged.Length.ShouldBe(2);
            methodtxtValue_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtValue_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtValue_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtValue_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtValue_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtValue_TextChanged, parametersOftxtValue_TextChanged, methodtxtValue_TextChangedParametersTypes);

            // Assert
            parametersOftxtValue_TextChanged.ShouldNotBeNull();
            parametersOftxtValue_TextChanged.Length.ShouldBe(2);
            methodtxtValue_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtValue_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtValue_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_TextChanged);
            var methodtxtValue_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtValue_TextChanged, methodtxtValue_TextChangedParametersTypes);

            // Assert
            methodtxtValue_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtSendUser_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtSendUser_TextChanged, methodtxtSendUser_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendUser_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSendUser_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSendUser_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendUser_TextChanged, methodtxtSendUser_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtSendUser_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtSendUser_TextChanged.ShouldNotBeNull();
            parametersOftxtSendUser_TextChanged.Length.ShouldBe(2);
            methodtxtSendUser_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSendUser_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSendUser_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendUser_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSendUser_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSendUser_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtSendUser_TextChanged, parametersOftxtSendUser_TextChanged, methodtxtSendUser_TextChangedParametersTypes);

            // Assert
            parametersOftxtSendUser_TextChanged.ShouldNotBeNull();
            parametersOftxtSendUser_TextChanged.Length.ShouldBe(2);
            methodtxtSendUser_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSendUser_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSendUser_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendUser_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendUser_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendUser_TextChanged);
            var methodtxtSendUser_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtSendUser_TextChanged, methodtxtSendUser_TextChangedParametersTypes);

            // Assert
            methodtxtSendUser_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendUser_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendUser_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendUser_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendUser_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtSendPass_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtSendPass_TextChanged, methodtxtSendPass_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendPass_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSendPass_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSendPass_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendPass_TextChanged, methodtxtSendPass_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtSendPass_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtSendPass_TextChanged.ShouldNotBeNull();
            parametersOftxtSendPass_TextChanged.Length.ShouldBe(2);
            methodtxtSendPass_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSendPass_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSendPass_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendPass_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSendPass_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSendPass_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtSendPass_TextChanged, parametersOftxtSendPass_TextChanged, methodtxtSendPass_TextChangedParametersTypes);

            // Assert
            parametersOftxtSendPass_TextChanged.ShouldNotBeNull();
            parametersOftxtSendPass_TextChanged.Length.ShouldBe(2);
            methodtxtSendPass_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSendPass_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSendPass_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendPass_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendPass_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendPass_TextChanged);
            var methodtxtSendPass_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtSendPass_TextChanged, methodtxtSendPass_TextChangedParametersTypes);

            // Assert
            methodtxtSendPass_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSendPass_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSendPass_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSendPass_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSendPass_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtxtSMTPPort_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtSMTPPort_TextChanged, methodtxtSMTPPort_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSMTPPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSMTPPort_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_TextChanged, methodtxtSMTPPort_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtSMTPPort_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtSMTPPort_TextChanged.ShouldNotBeNull();
            parametersOftxtSMTPPort_TextChanged.Length.ShouldBe(2);
            methodtxtSMTPPort_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSMTPPort_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSMTPPort_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtSMTPPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtSMTPPort_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtSMTPPort_TextChanged, parametersOftxtSMTPPort_TextChanged, methodtxtSMTPPort_TextChangedParametersTypes);

            // Assert
            parametersOftxtSMTPPort_TextChanged.ShouldNotBeNull();
            parametersOftxtSMTPPort_TextChanged.Length.ShouldBe(2);
            methodtxtSMTPPort_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtxtSMTPPort_TextChangedParametersTypes.Length.ShouldBe(parametersOftxtSMTPPort_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_TextChanged);
            var methodtxtSMTPPort_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtSMTPPort_TextChanged, methodtxtSMTPPort_TextChangedParametersTypes);

            // Assert
            methodtxtSMTPPort_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtServer_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtServer_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtServer_Enter, methodtxtServer_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtServer_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtServer_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_Enter, methodtxtServer_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtServer_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtServer_Enter.ShouldNotBeNull();
            parametersOftxtServer_Enter.Length.ShouldBe(2);
            methodtxtServer_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtServer_EnterParametersTypes.Length.ShouldBe(parametersOftxtServer_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtServer_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtServer_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtServer_Enter, parametersOftxtServer_Enter, methodtxtServer_EnterParametersTypes);

            // Assert
            parametersOftxtServer_Enter.ShouldNotBeNull();
            parametersOftxtServer_Enter.Length.ShouldBe(2);
            methodtxtServer_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtServer_EnterParametersTypes.Length.ShouldBe(parametersOftxtServer_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_Enter);
            var methodtxtServer_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtServer_Enter, methodtxtServer_EnterParametersTypes);

            // Assert
            methodtxtServer_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtDatabase_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_Enter, methodtxtDatabase_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtDatabase_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_Enter, methodtxtDatabase_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtDatabase_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtDatabase_Enter.ShouldNotBeNull();
            parametersOftxtDatabase_Enter.Length.ShouldBe(2);
            methodtxtDatabase_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_EnterParametersTypes.Length.ShouldBe(parametersOftxtDatabase_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtDatabase_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtDatabase_Enter, parametersOftxtDatabase_Enter, methodtxtDatabase_EnterParametersTypes);

            // Assert
            parametersOftxtDatabase_Enter.ShouldNotBeNull();
            parametersOftxtDatabase_Enter.Length.ShouldBe(2);
            methodtxtDatabase_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_EnterParametersTypes.Length.ShouldBe(parametersOftxtDatabase_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_Enter);
            var methodtxtDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_Enter, methodtxtDatabase_EnterParametersTypes);

            // Assert
            methodtxtDatabase_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtPDatabase_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_Enter, methodtxtPDatabase_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPDatabase_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_Enter, methodtxtPDatabase_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPDatabase_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPDatabase_Enter.ShouldNotBeNull();
            parametersOftxtPDatabase_Enter.Length.ShouldBe(2);
            methodtxtPDatabase_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_EnterParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPDatabase_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPDatabase_Enter, parametersOftxtPDatabase_Enter, methodtxtPDatabase_EnterParametersTypes);

            // Assert
            parametersOftxtPDatabase_Enter.ShouldNotBeNull();
            parametersOftxtPDatabase_Enter.Length.ShouldBe(2);
            methodtxtPDatabase_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_EnterParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_Enter);
            var methodtxtPDatabase_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_Enter, methodtxtPDatabase_EnterParametersTypes);

            // Assert
            methodtxtPDatabase_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtUserID_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtUserID_Enter, methodtxtUserID_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtUserID_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtUserID_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_Enter, methodtxtUserID_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtUserID_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtUserID_Enter.ShouldNotBeNull();
            parametersOftxtUserID_Enter.Length.ShouldBe(2);
            methodtxtUserID_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_EnterParametersTypes.Length.ShouldBe(parametersOftxtUserID_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtUserID_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtUserID_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtUserID_Enter, parametersOftxtUserID_Enter, methodtxtUserID_EnterParametersTypes);

            // Assert
            parametersOftxtUserID_Enter.ShouldNotBeNull();
            parametersOftxtUserID_Enter.Length.ShouldBe(2);
            methodtxtUserID_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_EnterParametersTypes.Length.ShouldBe(parametersOftxtUserID_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_Enter);
            var methodtxtUserID_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtUserID_Enter, methodtxtUserID_EnterParametersTypes);

            // Assert
            methodtxtUserID_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtPassword_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPassword_Enter, methodtxtPassword_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPassword_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPassword_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_Enter, methodtxtPassword_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPassword_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPassword_Enter.ShouldNotBeNull();
            parametersOftxtPassword_Enter.Length.ShouldBe(2);
            methodtxtPassword_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPassword_EnterParametersTypes.Length.ShouldBe(parametersOftxtPassword_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPassword_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPassword_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPassword_Enter, parametersOftxtPassword_Enter, methodtxtPassword_EnterParametersTypes);

            // Assert
            parametersOftxtPassword_Enter.ShouldNotBeNull();
            parametersOftxtPassword_Enter.Length.ShouldBe(2);
            methodtxtPassword_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPassword_EnterParametersTypes.Length.ShouldBe(parametersOftxtPassword_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_Enter);
            var methodtxtPassword_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPassword_Enter, methodtxtPassword_EnterParametersTypes);

            // Assert
            methodtxtPassword_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPassword_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPassword_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPassword_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPassword_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtConnectionTimeout_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_Enter, methodtxtConnectionTimeout_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtConnectionTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtConnectionTimeout_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_Enter, methodtxtConnectionTimeout_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtConnectionTimeout_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtConnectionTimeout_Enter.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_Enter.Length.ShouldBe(2);
            methodtxtConnectionTimeout_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_EnterParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtConnectionTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtConnectionTimeout_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtConnectionTimeout_Enter, parametersOftxtConnectionTimeout_Enter, methodtxtConnectionTimeout_EnterParametersTypes);

            // Assert
            parametersOftxtConnectionTimeout_Enter.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_Enter.Length.ShouldBe(2);
            methodtxtConnectionTimeout_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_EnterParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_Enter);
            var methodtxtConnectionTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_Enter, methodtxtConnectionTimeout_EnterParametersTypes);

            // Assert
            methodtxtConnectionTimeout_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtQueryTimeout_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_Enter, methodtxtQueryTimeout_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtQueryTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtQueryTimeout_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_Enter, methodtxtQueryTimeout_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtQueryTimeout_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtQueryTimeout_Enter.ShouldNotBeNull();
            parametersOftxtQueryTimeout_Enter.Length.ShouldBe(2);
            methodtxtQueryTimeout_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_EnterParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtQueryTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtQueryTimeout_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtQueryTimeout_Enter, parametersOftxtQueryTimeout_Enter, methodtxtQueryTimeout_EnterParametersTypes);

            // Assert
            parametersOftxtQueryTimeout_Enter.ShouldNotBeNull();
            parametersOftxtQueryTimeout_Enter.Length.ShouldBe(2);
            methodtxtQueryTimeout_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_EnterParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_Enter);
            var methodtxtQueryTimeout_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_Enter, methodtxtQueryTimeout_EnterParametersTypes);

            // Assert
            methodtxtQueryTimeout_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtMaxRows_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_Enter, methodtxtMaxRows_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtMaxRows_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtMaxRows_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_Enter, methodtxtMaxRows_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtMaxRows_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtMaxRows_Enter.ShouldNotBeNull();
            parametersOftxtMaxRows_Enter.Length.ShouldBe(2);
            methodtxtMaxRows_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_EnterParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtMaxRows_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtMaxRows_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtMaxRows_Enter, parametersOftxtMaxRows_Enter, methodtxtMaxRows_EnterParametersTypes);

            // Assert
            parametersOftxtMaxRows_Enter.ShouldNotBeNull();
            parametersOftxtMaxRows_Enter.Length.ShouldBe(2);
            methodtxtMaxRows_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_EnterParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_Enter);
            var methodtxtMaxRows_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_Enter, methodtxtMaxRows_EnterParametersTypes);

            // Assert
            methodtxtMaxRows_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtOrgId_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtOrgId_Enter, methodtxtOrgId_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtOrgId_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtOrgId_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_Enter, methodtxtOrgId_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtOrgId_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtOrgId_Enter.ShouldNotBeNull();
            parametersOftxtOrgId_Enter.Length.ShouldBe(2);
            methodtxtOrgId_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtOrgId_EnterParametersTypes.Length.ShouldBe(parametersOftxtOrgId_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtOrgId_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtOrgId_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtOrgId_Enter, parametersOftxtOrgId_Enter, methodtxtOrgId_EnterParametersTypes);

            // Assert
            parametersOftxtOrgId_Enter.ShouldNotBeNull();
            parametersOftxtOrgId_Enter.Length.ShouldBe(2);
            methodtxtOrgId_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtOrgId_EnterParametersTypes.Length.ShouldBe(parametersOftxtOrgId_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_Enter);
            var methodtxtOrgId_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtOrgId_Enter, methodtxtOrgId_EnterParametersTypes);

            // Assert
            methodtxtOrgId_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtOrgId_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtOrgId_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtOrgId_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtOrgId_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPort_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtPort_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPort_Enter, methodtxtPort_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPort_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPort_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_Enter, methodtxtPort_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPort_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPort_Enter.ShouldNotBeNull();
            parametersOftxtPort_Enter.Length.ShouldBe(2);
            methodtxtPort_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPort_EnterParametersTypes.Length.ShouldBe(parametersOftxtPort_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtPort_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtPort_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPort_Enter, parametersOftxtPort_Enter, methodtxtPort_EnterParametersTypes);

            // Assert
            parametersOftxtPort_Enter.ShouldNotBeNull();
            parametersOftxtPort_Enter.Length.ShouldBe(2);
            methodtxtPort_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtPort_EnterParametersTypes.Length.ShouldBe(parametersOftxtPort_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_Enter);
            var methodtxtPort_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPort_Enter, methodtxtPort_EnterParametersTypes);

            // Assert
            methodtxtPort_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtKey_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtKey_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtKey_Enter, methodtxtKey_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtKey_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtKey_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_Enter, methodtxtKey_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtKey_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtKey_Enter.ShouldNotBeNull();
            parametersOftxtKey_Enter.Length.ShouldBe(2);
            methodtxtKey_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtKey_EnterParametersTypes.Length.ShouldBe(parametersOftxtKey_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtKey_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtKey_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtKey_Enter, parametersOftxtKey_Enter, methodtxtKey_EnterParametersTypes);

            // Assert
            parametersOftxtKey_Enter.ShouldNotBeNull();
            parametersOftxtKey_Enter.Length.ShouldBe(2);
            methodtxtKey_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtKey_EnterParametersTypes.Length.ShouldBe(parametersOftxtKey_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_Enter);
            var methodtxtKey_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtKey_Enter, methodtxtKey_EnterParametersTypes);

            // Assert
            methodtxtKey_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtKey_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtKey_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtKey_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtKey_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtValue_Enter_Method_Call_Internally(Type[] types)
        {
            var methodtxtValue_EnterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtValue_Enter, methodtxtValue_EnterParametersTypes);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_Enter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtValue_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtValue_Enter = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_Enter, methodtxtValue_EnterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtValue_Enter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtValue_Enter.ShouldNotBeNull();
            parametersOftxtValue_Enter.Length.ShouldBe(2);
            methodtxtValue_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtValue_EnterParametersTypes.Length.ShouldBe(parametersOftxtValue_Enter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_Enter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_Enter);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtxtValue_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftxtValue_Enter = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtValue_Enter, parametersOftxtValue_Enter, methodtxtValue_EnterParametersTypes);

            // Assert
            parametersOftxtValue_Enter.ShouldNotBeNull();
            parametersOftxtValue_Enter.Length.ShouldBe(2);
            methodtxtValue_EnterParametersTypes.Length.ShouldBe(2);
            methodtxtValue_EnterParametersTypes.Length.ShouldBe(parametersOftxtValue_Enter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_Enter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_Enter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_Enter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_Enter);
            var methodtxtValue_EnterParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtValue_Enter, methodtxtValue_EnterParametersTypes);

            // Assert
            methodtxtValue_EnterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_Enter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_Enter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_Enter);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_Enter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtConnectionTimeout_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_KeyPress, methodtxtConnectionTimeout_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtConnectionTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtConnectionTimeout_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_KeyPress, methodtxtConnectionTimeout_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtConnectionTimeout_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtConnectionTimeout_KeyPress.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_KeyPress.Length.ShouldBe(2);
            methodtxtConnectionTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtConnectionTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtConnectionTimeout_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtConnectionTimeout_KeyPress, parametersOftxtConnectionTimeout_KeyPress, methodtxtConnectionTimeout_KeyPressParametersTypes);

            // Assert
            parametersOftxtConnectionTimeout_KeyPress.ShouldNotBeNull();
            parametersOftxtConnectionTimeout_KeyPress.Length.ShouldBe(2);
            methodtxtConnectionTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtConnectionTimeout_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtConnectionTimeout_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_KeyPress);
            var methodtxtConnectionTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtConnectionTimeout_KeyPress, methodtxtConnectionTimeout_KeyPressParametersTypes);

            // Assert
            methodtxtConnectionTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtConnectionTimeout_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtConnectionTimeout_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtConnectionTimeout_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtConnectionTimeout_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtDatabase_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_KeyPress, methodtxtDatabase_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtDatabase_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_KeyPress, methodtxtDatabase_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtDatabase_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtDatabase_KeyPress.ShouldNotBeNull();
            parametersOftxtDatabase_KeyPress.Length.ShouldBe(2);
            methodtxtDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtDatabase_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtDatabase_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtDatabase_KeyPress, parametersOftxtDatabase_KeyPress, methodtxtDatabase_KeyPressParametersTypes);

            // Assert
            parametersOftxtDatabase_KeyPress.ShouldNotBeNull();
            parametersOftxtDatabase_KeyPress.Length.ShouldBe(2);
            methodtxtDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtDatabase_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtDatabase_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_KeyPress);
            var methodtxtDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtDatabase_KeyPress, methodtxtDatabase_KeyPressParametersTypes);

            // Assert
            methodtxtDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtDatabase_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtDatabase_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtDatabase_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtDatabase_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtPDatabase_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_KeyPress, methodtxtPDatabase_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtPDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtPDatabase_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_KeyPress, methodtxtPDatabase_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPDatabase_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPDatabase_KeyPress.ShouldNotBeNull();
            parametersOftxtPDatabase_KeyPress.Length.ShouldBe(2);
            methodtxtPDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtPDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtPDatabase_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPDatabase_KeyPress, parametersOftxtPDatabase_KeyPress, methodtxtPDatabase_KeyPressParametersTypes);

            // Assert
            parametersOftxtPDatabase_KeyPress.ShouldNotBeNull();
            parametersOftxtPDatabase_KeyPress.Length.ShouldBe(2);
            methodtxtPDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtPDatabase_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtPDatabase_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_KeyPress);
            var methodtxtPDatabase_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPDatabase_KeyPress, methodtxtPDatabase_KeyPressParametersTypes);

            // Assert
            methodtxtPDatabase_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPDatabase_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPDatabase_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPDatabase_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPDatabase_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtMaxRows_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_KeyPress, methodtxtMaxRows_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtMaxRows_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtMaxRows_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_KeyPress, methodtxtMaxRows_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtMaxRows_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtMaxRows_KeyPress.ShouldNotBeNull();
            parametersOftxtMaxRows_KeyPress.Length.ShouldBe(2);
            methodtxtMaxRows_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtMaxRows_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtMaxRows_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtMaxRows_KeyPress, parametersOftxtMaxRows_KeyPress, methodtxtMaxRows_KeyPressParametersTypes);

            // Assert
            parametersOftxtMaxRows_KeyPress.ShouldNotBeNull();
            parametersOftxtMaxRows_KeyPress.Length.ShouldBe(2);
            methodtxtMaxRows_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtMaxRows_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtMaxRows_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_KeyPress);
            var methodtxtMaxRows_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtMaxRows_KeyPress, methodtxtMaxRows_KeyPressParametersTypes);

            // Assert
            methodtxtMaxRows_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtMaxRows_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtMaxRows_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtMaxRows_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtMaxRows_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtQueryTimeout_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_KeyPress, methodtxtQueryTimeout_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtQueryTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtQueryTimeout_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_KeyPress, methodtxtQueryTimeout_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtQueryTimeout_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtQueryTimeout_KeyPress.ShouldNotBeNull();
            parametersOftxtQueryTimeout_KeyPress.Length.ShouldBe(2);
            methodtxtQueryTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtQueryTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtQueryTimeout_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtQueryTimeout_KeyPress, parametersOftxtQueryTimeout_KeyPress, methodtxtQueryTimeout_KeyPressParametersTypes);

            // Assert
            parametersOftxtQueryTimeout_KeyPress.ShouldNotBeNull();
            parametersOftxtQueryTimeout_KeyPress.Length.ShouldBe(2);
            methodtxtQueryTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtQueryTimeout_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtQueryTimeout_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_KeyPress);
            var methodtxtQueryTimeout_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtQueryTimeout_KeyPress, methodtxtQueryTimeout_KeyPressParametersTypes);

            // Assert
            methodtxtQueryTimeout_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtQueryTimeout_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtQueryTimeout_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtQueryTimeout_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtQueryTimeout_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtServer_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtServer_KeyPress, methodtxtServer_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtServer_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtServer_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_KeyPress, methodtxtServer_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtServer_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtServer_KeyPress.ShouldNotBeNull();
            parametersOftxtServer_KeyPress.Length.ShouldBe(2);
            methodtxtServer_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtServer_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtServer_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtServer_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtServer_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtServer_KeyPress, parametersOftxtServer_KeyPress, methodtxtServer_KeyPressParametersTypes);

            // Assert
            parametersOftxtServer_KeyPress.ShouldNotBeNull();
            parametersOftxtServer_KeyPress.Length.ShouldBe(2);
            methodtxtServer_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtServer_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtServer_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_KeyPress);
            var methodtxtServer_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtServer_KeyPress, methodtxtServer_KeyPressParametersTypes);

            // Assert
            methodtxtServer_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtServer_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtServer_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtServer_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtServer_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtUserID_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtUserID_KeyPress, methodtxtUserID_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtUserID_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtUserID_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_KeyPress, methodtxtUserID_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtUserID_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtUserID_KeyPress.ShouldNotBeNull();
            parametersOftxtUserID_KeyPress.Length.ShouldBe(2);
            methodtxtUserID_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtUserID_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtUserID_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtUserID_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtUserID_KeyPress, parametersOftxtUserID_KeyPress, methodtxtUserID_KeyPressParametersTypes);

            // Assert
            parametersOftxtUserID_KeyPress.ShouldNotBeNull();
            parametersOftxtUserID_KeyPress.Length.ShouldBe(2);
            methodtxtUserID_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtUserID_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtUserID_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_KeyPress);
            var methodtxtUserID_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtUserID_KeyPress, methodtxtUserID_KeyPressParametersTypes);

            // Assert
            methodtxtUserID_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtUserID_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtUserID_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtUserID_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtUserID_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtValue_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtValue_KeyPress, methodtxtValue_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtValue_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtValue_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_KeyPress, methodtxtValue_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtValue_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtValue_KeyPress.ShouldNotBeNull();
            parametersOftxtValue_KeyPress.Length.ShouldBe(2);
            methodtxtValue_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtValue_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtValue_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtValue_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtValue_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtValue_KeyPress, parametersOftxtValue_KeyPress, methodtxtValue_KeyPressParametersTypes);

            // Assert
            parametersOftxtValue_KeyPress.ShouldNotBeNull();
            parametersOftxtValue_KeyPress.Length.ShouldBe(2);
            methodtxtValue_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtValue_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtValue_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_KeyPress);
            var methodtxtValue_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtValue_KeyPress, methodtxtValue_KeyPressParametersTypes);

            // Assert
            methodtxtValue_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtValue_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtValue_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtValue_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtValue_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtPort_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtPort_KeyPress, methodtxtPort_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtPort_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_KeyPress, methodtxtPort_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtPort_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtPort_KeyPress.ShouldNotBeNull();
            parametersOftxtPort_KeyPress.Length.ShouldBe(2);
            methodtxtPort_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtPort_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtPort_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtPort_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtPort_KeyPress, parametersOftxtPort_KeyPress, methodtxtPort_KeyPressParametersTypes);

            // Assert
            parametersOftxtPort_KeyPress.ShouldNotBeNull();
            parametersOftxtPort_KeyPress.Length.ShouldBe(2);
            methodtxtPort_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtPort_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtPort_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_KeyPress);
            var methodtxtPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtPort_KeyPress, methodtxtPort_KeyPressParametersTypes);

            // Assert
            methodtxtPort_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtPort_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtPort_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtPort_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtPort_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_Internally(Type[] types)
        {
            var methodtxtSMTPPort_KeyPressParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtxtSMTPPort_KeyPress, methodtxtSMTPPort_KeyPressParametersTypes);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtSMTPPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtSMTPPort_KeyPress = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_KeyPress, methodtxtSMTPPort_KeyPressParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOftxtSMTPPort_KeyPress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftxtSMTPPort_KeyPress.ShouldNotBeNull();
            parametersOftxtSMTPPort_KeyPress.Length.ShouldBe(2);
            methodtxtSMTPPort_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtSMTPPort_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtSMTPPort_KeyPress.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_KeyPress);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyPressEventArgs>();
            var methodtxtSMTPPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };
            object[] parametersOftxtSMTPPort_KeyPress = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtxtSMTPPort_KeyPress, parametersOftxtSMTPPort_KeyPress, methodtxtSMTPPort_KeyPressParametersTypes);

            // Assert
            parametersOftxtSMTPPort_KeyPress.ShouldNotBeNull();
            parametersOftxtSMTPPort_KeyPress.Length.ShouldBe(2);
            methodtxtSMTPPort_KeyPressParametersTypes.Length.ShouldBe(2);
            methodtxtSMTPPort_KeyPressParametersTypes.Length.ShouldBe(parametersOftxtSMTPPort_KeyPress.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_KeyPress, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_KeyPress);
            var methodtxtSMTPPort_KeyPressParametersTypes = new Type[] { typeof(object), typeof(KeyPressEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtxtSMTPPort_KeyPress, methodtxtSMTPPort_KeyPressParametersTypes);

            // Assert
            methodtxtSMTPPort_KeyPressParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (txtSMTPPort_KeyPress) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_txtSMTPPort_KeyPress_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtxtSMTPPort_KeyPress);
            var currentMethodInfo = this.GetMethodInfo(MethodtxtSMTPPort_KeyPress, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_Internally(Type[] types)
        {
            var methodchkUseSSL_CheckedChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodchkUseSSL_CheckedChanged, methodchkUseSSL_CheckedChangedParametersTypes);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodchkUseSSL_CheckedChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodchkUseSSL_CheckedChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfchkUseSSL_CheckedChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodchkUseSSL_CheckedChanged, methodchkUseSSL_CheckedChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfchkUseSSL_CheckedChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfchkUseSSL_CheckedChanged.ShouldNotBeNull();
            parametersOfchkUseSSL_CheckedChanged.Length.ShouldBe(2);
            methodchkUseSSL_CheckedChangedParametersTypes.Length.ShouldBe(2);
            methodchkUseSSL_CheckedChangedParametersTypes.Length.ShouldBe(parametersOfchkUseSSL_CheckedChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodchkUseSSL_CheckedChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodchkUseSSL_CheckedChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfchkUseSSL_CheckedChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodchkUseSSL_CheckedChanged, parametersOfchkUseSSL_CheckedChanged, methodchkUseSSL_CheckedChangedParametersTypes);

            // Assert
            parametersOfchkUseSSL_CheckedChanged.ShouldNotBeNull();
            parametersOfchkUseSSL_CheckedChanged.Length.ShouldBe(2);
            methodchkUseSSL_CheckedChangedParametersTypes.Length.ShouldBe(2);
            methodchkUseSSL_CheckedChangedParametersTypes.Length.ShouldBe(parametersOfchkUseSSL_CheckedChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodchkUseSSL_CheckedChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodchkUseSSL_CheckedChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodchkUseSSL_CheckedChanged);
            var methodchkUseSSL_CheckedChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodchkUseSSL_CheckedChanged, methodchkUseSSL_CheckedChangedParametersTypes);

            // Assert
            methodchkUseSSL_CheckedChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (chkUseSSL_CheckedChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_chkUseSSL_CheckedChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodchkUseSSL_CheckedChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodchkUseSSL_CheckedChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodTabStrip_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTabStrip_SelectedIndexChanged, methodTabStrip_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTabStrip_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodTabStrip_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfTabStrip_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTabStrip_SelectedIndexChanged, methodTabStrip_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASConfigToolInstanceFixture, parametersOfTabStrip_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTabStrip_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfTabStrip_SelectedIndexChanged.Length.ShouldBe(2);
            methodTabStrip_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodTabStrip_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfTabStrip_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTabStrip_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodTabStrip_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfTabStrip_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodTabStrip_SelectedIndexChanged, parametersOfTabStrip_SelectedIndexChanged, methodTabStrip_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOfTabStrip_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfTabStrip_SelectedIndexChanged.Length.ShouldBe(2);
            methodTabStrip_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodTabStrip_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfTabStrip_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTabStrip_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodTabStrip_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTabStrip_SelectedIndexChanged);
            var methodTabStrip_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTabStrip_SelectedIndexChanged, methodTabStrip_SelectedIndexChangedParametersTypes);

            // Assert
            methodTabStrip_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TabStrip_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_TabStrip_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTabStrip_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodTabStrip_SelectedIndexChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OEASConfigTool_FormClosing) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_OEASConfigTool_FormClosing_Method_Call_Internally(Type[] types)
        {
            var methodOEASConfigTool_FormClosingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOEASConfigTool_FormClosing, methodOEASConfigTool_FormClosingParametersTypes);
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_Internally(Type[] types)
        {
            var methodIsOGSInstalledParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsOGSInstalled, methodIsOGSInstalledParametersTypes);
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOGSInstalled);
            Type [] methodIsOGSInstalledParametersTypes = null;
            object[] parametersOfIsOGSInstalled = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsOGSInstalled, methodIsOGSInstalledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, parametersOfIsOGSInstalled);
            var result2 = this.GetResultOfMethod<bool>(MethodIsOGSInstalled, parametersOfIsOGSInstalled, methodIsOGSInstalledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsOGSInstalled.ShouldBeNull();
            methodIsOGSInstalledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOGSInstalled);
            Type [] methodIsOGSInstalledParametersTypes = null;
            object[] parametersOfIsOGSInstalled = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsOGSInstalled, methodIsOGSInstalledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASConfigToolInstanceFixture, out exception1, parametersOfIsOGSInstalled);
            var result2 = this.GetResultOfMethod<bool>(MethodIsOGSInstalled, parametersOfIsOGSInstalled, methodIsOGSInstalledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsOGSInstalled.ShouldBeNull();
            methodIsOGSInstalledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOGSInstalled);
            Type [] methodIsOGSInstalledParametersTypes = null;
            object[] parametersOfIsOGSInstalled = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsOGSInstalled, parametersOfIsOGSInstalled, methodIsOGSInstalledParametersTypes);

            // Assert
            parametersOfIsOGSInstalled.ShouldBeNull();
            methodIsOGSInstalledParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOGSInstalled);
            Type [] methodIsOGSInstalledParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsOGSInstalled, methodIsOGSInstalledParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsOGSInstalledParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsOGSInstalled) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASConfigTool_IsOGSInstalled_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsOGSInstalled);
            var currentMethodInfo = this.GetMethodInfo(MethodIsOGSInstalled, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}