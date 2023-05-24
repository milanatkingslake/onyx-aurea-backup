using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OEASConfig;
using Shouldly;

namespace Avolin.Onyx.Part17.AUT.Tests.OEASConfig
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OEASConfig.OEASConfigTool" />)
    ///     and namespace <see cref="OEASConfig"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OEASConfigToolDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OEASConfigToolNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public OEASConfigToolDesignerTest() : base(publicType: typeof(Common), classNameWithNamespace: OEASConfigToolNonPublicTypeName)
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

        private Type _oEASConfigToolInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OEASConfigToolNonPublicTypeName = "OEASConfig.OEASConfigTool";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _oEASConfigToolInstance;
        private object _oEASConfigToolInstanceFixture;

        #region General Initializer : Class (OEASConfigTool) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OEASConfigTool" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASConfigToolInstanceFixture = this.CreateNonPublicType(OEASConfigToolNonPublicTypeName);
            _oEASConfigToolInstance = _oEASConfigToolInstanceFixture;
            CurrentInstance = _oEASConfigToolInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASConfigTool) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldlblApplicationName = "lblApplicationName";
        private const string FieldcmbApplicationName = "cmbApplicationName";
        private const string FieldTabStrip = "TabStrip";
        private const string FieldTabApplicationData = "TabApplicationData";
        private const string FieldtxtOrgId = "txtOrgId";
        private const string FieldtxtMaxRows = "txtMaxRows";
        private const string FieldtxtQueryTimeout = "txtQueryTimeout";
        private const string FieldtxtConnectionTimeout = "txtConnectionTimeout";
        private const string FieldtxtPassword = "txtPassword";
        private const string FieldtxtUserID = "txtUserID";
        private const string FieldtxtPDatabase = "txtPDatabase";
        private const string FieldtxtDatabase = "txtDatabase";
        private const string FieldtxtServer = "txtServer";
        private const string FieldlblSQLDatabase = "lblSQLDatabase";
        private const string FieldTabOGS = "TabOGS";
        private const string FieldTabEmail = "TabEmail";
        private const string FieldTabLoggingData = "TabLoggingData";
        private const string FieldlblSQLId = "lblSQLId";
        private const string FieldlblPDatabase = "lblPDatabase";
        private const string FieldlblConnectionTimeout = "lblConnectionTimeout";
        private const string FieldlblSQLPassword = "lblSQLPassword";
        private const string FieldlblOrgId = "lblOrgId";
        private const string FieldlblMaxRows = "lblMaxRows";
        private const string FieldlblQueryTimeout = "lblQueryTimeout";
        private const string FieldlblOGSPort = "lblOGSPort";
        private const string FieldtxtPort = "txtPort";
        private const string FieldlstLoggingValues = "lstLoggingValues";
        private const string FieldlblKeyList = "lblKeyList";
        private const string FieldlblValueKey = "lblValueKey";
        private const string FieldlblValue = "lblValue";
        private const string FieldtxtValue = "txtValue";
        private const string FieldtxtKey = "txtKey";
        private const string FieldcmdRemove = "cmdRemove";
        private const string FieldcmdAdd = "cmdAdd";
        private const string FieldcmdUpdate = "cmdUpdate";
        private const string FieldcmdClose = "cmdClose";
        private const string FieldcmdGlobalRestore = "cmdGlobalRestore";
        private const string FieldcmdGlobalSave = "cmdGlobalSave";
        private const string FieldpanelCmdButtons = "panelCmdButtons";
        private const string FieldpanelCmdLoggingData = "panelCmdLoggingData";
        private const string FieldpanelApplicationData = "panelApplicationData";
        private const string FieldpanelOGS = "panelOGS";
        private const string FieldpanelLoggingData = "panelLoggingData";
        private const string FieldpanelEmailSendData = "panelEmailSendData";
        private const string FieldlblSendPass = "lblSendPass";
        private const string FieldtxtSendPass = "txtSendPass";
        private const string FieldlblPort = "lblPort";
        private const string FieldtxtSMTPPort = "txtSMTPPort";
        private const string FieldchkUseSSL = "chkUseSSL";
        private const string FieldlblSendUser = "lblSendUser";
        private const string FieldcboProtocol = "cboProtocol";
        private const string FieldlblAuthProtocol = "lblAuthProtocol";
        private const string FieldtxtSendUser = "txtSendUser";
        private const string FieldlblSQLServer = "lblSQLServer";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASConfigTool)

        #region General Initializer : Class (OEASConfigTool) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_OEASConfigToolDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASConfigTool) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASConfigToolDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OEASConfigTool) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldlblApplicationName)]
        [TestCase(FieldcmbApplicationName)]
        [TestCase(FieldTabStrip)]
        [TestCase(FieldTabApplicationData)]
        [TestCase(FieldtxtOrgId)]
        [TestCase(FieldtxtMaxRows)]
        [TestCase(FieldtxtQueryTimeout)]
        [TestCase(FieldtxtConnectionTimeout)]
        [TestCase(FieldtxtPassword)]
        [TestCase(FieldtxtUserID)]
        [TestCase(FieldtxtPDatabase)]
        [TestCase(FieldtxtDatabase)]
        [TestCase(FieldtxtServer)]
        [TestCase(FieldlblSQLDatabase)]
        [TestCase(FieldTabOGS)]
        [TestCase(FieldTabEmail)]
        [TestCase(FieldTabLoggingData)]
        [TestCase(FieldlblSQLId)]
        [TestCase(FieldlblPDatabase)]
        [TestCase(FieldlblConnectionTimeout)]
        [TestCase(FieldlblSQLPassword)]
        [TestCase(FieldlblOrgId)]
        [TestCase(FieldlblMaxRows)]
        [TestCase(FieldlblQueryTimeout)]
        [TestCase(FieldlblOGSPort)]
        [TestCase(FieldtxtPort)]
        [TestCase(FieldlstLoggingValues)]
        [TestCase(FieldlblKeyList)]
        [TestCase(FieldlblValueKey)]
        [TestCase(FieldlblValue)]
        [TestCase(FieldtxtValue)]
        [TestCase(FieldtxtKey)]
        [TestCase(FieldcmdRemove)]
        [TestCase(FieldcmdAdd)]
        [TestCase(FieldcmdUpdate)]
        [TestCase(FieldcmdGlobalRestore)]
        [TestCase(FieldcmdGlobalSave)]
        [TestCase(FieldpanelCmdButtons)]
        [TestCase(FieldpanelCmdLoggingData)]
        [TestCase(FieldpanelApplicationData)]
        [TestCase(FieldpanelOGS)]
        [TestCase(FieldpanelLoggingData)]
        [TestCase(FieldpanelEmailSendData)]
        [TestCase(FieldlblSendPass)]
        [TestCase(FieldtxtSendPass)]
        [TestCase(FieldlblPort)]
        [TestCase(FieldtxtSMTPPort)]
        [TestCase(FieldchkUseSSL)]
        [TestCase(FieldlblSendUser)]
        [TestCase(FieldcboProtocol)]
        [TestCase(FieldlblAuthProtocol)]
        [TestCase(FieldtxtSendUser)]
        [TestCase(FieldlblSQLServer)]
        [Category("AUT Fields")]
        public void AUT_OEASConfigToolDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OEASConfigTool) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASConfigTool" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASConfigToolDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}