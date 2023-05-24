using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.UserPreferences" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserPreferencesDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="UserPreferencesNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public UserPreferencesDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: UserPreferencesNonPublicTypeName)
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

        private Type _userPreferencesInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string UserPreferencesNonPublicTypeName = "OnyxOutlookAddin.UserPreferences";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _userPreferencesInstance;
        private object _userPreferencesInstanceFixture;

        #region General Initializer : Class (UserPreferences) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="UserPreferences" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userPreferencesInstanceFixture = this.CreateNonPublicType(UserPreferencesNonPublicTypeName);
            _userPreferencesInstance = _userPreferencesInstanceFixture;
            CurrentInstance = _userPreferencesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserPreferences) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldtoolStripContainer1 = "toolStripContainer1";
        private const string FieldtoolStrip1 = "toolStrip1";
        private const string FieldlblUserOptions = "lblUserOptions";
        private const string FieldbtnUserOptionCancel = "btnUserOptionCancel";
        private const string FieldbtnUserOptionSave = "btnUserOptionSave";
        private const string FieldtxtOutFolderList = "txtOutFolderList";
        private const string Fieldlabel3 = "label3";
        private const string FieldtxtInFolderList = "txtInFolderList";
        private const string Fieldlabel2 = "label2";
        private const string FieldgbAttachmentBehavior = "gbAttachmentBehavior";
        private const string FieldchkIncAttachOnEmailSave = "chkIncAttachOnEmailSave";
        private const string FieldcmbUserProfile = "cmbUserProfile";
        private const string Fieldlabel1 = "label1";
        private const string FieldtxtPrefPassword = "txtPrefPassword";
        private const string FieldtxtPrefUserId = "txtPrefUserId";
        private const string FieldlblPassword = "lblPassword";
        private const string FieldlblUserId = "lblUserId";
        private const string FieldchkIncAttachOnIncidentSave = "chkIncAttachOnIncidentSave";
        private const string FieldcmbOutlookSyncContactDirection = "cmbOutlookSyncContactDirection";
        private const string FieldlblSyncDirection = "lblSyncDirection";
        private const string FieldreportIssueLink = "reportIssueLink";
        private const string FieldopenLogLabel = "openLogLabel";
        private const string FieldchkDisplayResolvedEmployee = "chkDisplayResolvedEmployee";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (UserPreferences)

        #region General Initializer : Class (UserPreferences) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_UserPreferencesDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (UserPreferences) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserPreferencesDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (UserPreferences) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldtoolStripContainer1)]
        [TestCase(FieldtoolStrip1)]
        [TestCase(FieldlblUserOptions)]
        [TestCase(FieldbtnUserOptionCancel)]
        [TestCase(FieldbtnUserOptionSave)]
        [TestCase(FieldtxtOutFolderList)]
        [TestCase(Fieldlabel3)]
        [TestCase(FieldtxtInFolderList)]
        [TestCase(Fieldlabel2)]
        [TestCase(FieldgbAttachmentBehavior)]
        [TestCase(FieldchkIncAttachOnEmailSave)]
        [TestCase(FieldcmbUserProfile)]
        [TestCase(Fieldlabel1)]
        [TestCase(FieldtxtPrefPassword)]
        [TestCase(FieldtxtPrefUserId)]
        [TestCase(FieldlblPassword)]
        [TestCase(FieldlblUserId)]
        [TestCase(FieldchkIncAttachOnIncidentSave)]
        [TestCase(FieldcmbOutlookSyncContactDirection)]
        [TestCase(FieldlblSyncDirection)]
        [TestCase(FieldreportIssueLink)]
        [TestCase(FieldopenLogLabel)]
        [TestCase(FieldchkDisplayResolvedEmployee)]
        [Category("AUT Fields")]
        public void AUT_UserPreferencesDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (UserPreferences) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserPreferencesDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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