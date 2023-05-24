using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxResource" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxResourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxResourceNonPublicTypeName" />) using
        ///     Using a public type <see cref="CountryHelper" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxResourceTest() : base(publicType: typeof(CountryHelper), classNameWithNamespace: OnyxResourceNonPublicTypeName)
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

        private Type _onyxResourceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxResourceNonPublicTypeName = "OnyxCommon.OnyxResource";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxResourceInstance;
        private object _onyxResourceInstanceFixture;

        #region General Initializer : Class (OnyxResource) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxResource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxResourceInstanceFixture = this.CreateNonPublicType(OnyxResourceNonPublicTypeName);
            _onyxResourceInstance = _onyxResourceInstanceFixture;
            CurrentInstance = _onyxResourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxResource) Initializer

        #region Fields

        private const string Fieldres_mailItemwrapper = "res_mailItemwrapper";
        private const string Fieldres_appointmentItemWrapper = "res_appointmentItemWrapper";
        private const string Fieldres_contactItemWrapper = "res_contactItemWrapper";
        private const string Fieldres_countryHelper = "res_countryHelper";
        private const string Fieldres_addContactControl = "res_addContactControl";
        private const string Fieldres_addInternalContactControl = "res_addInternalContactControl";
        private const string Fieldres_createCustomerControl = "res_createCustomerControl";
        private const string Fieldres_createCustomerControlAttachment = "res_createCustomerControlAttachment";
        private const string Fieldres_createCustomerControlCustomerError = "res_createCustomerControlCustomerError";
        private const string Fieldres_createIncidentControl = "res_createIncidentControl";
        private const string Fieldres_createIncidentControlSaveIncident = "res_createIncidentControlSaveIncident";
        private const string Fieldres_customUtility = "res_customUtility";
        private const string Fieldres_duplicateCustomers = "res_duplicateCustomers";
        private const string Fieldres_emailTemplateControl = "res_emailTemplateControl";
        private const string Fieldres_inspectorWrapper = "res_inspectorWrapper";
        private const string Fieldres_itemSelectorControl = "res_itemSelectorControl";
        private const string Fieldres_outlookItemSelector = "res_outlookItemSelector";
        private const string Fieldres_onyxDownloadableCustomerSelector = "res_onyxDownloadableCustomerSelector";
        private const string Fieldres_onyxObjectSelector = "res_onyxObjectSelector";
        private const string Fieldres_memberCollection = "res_memberCollection";
        private const string Fieldres_onyx360RibbonXML = "res_onyx360RibbonXML";
        private const string Fieldres_onyx360RibbonXMLToggleClick = "res_onyx360RibbonXMLToggleClick";
        private const string Fieldres_onyx360RibbonXMLGetLabel = "res_onyx360RibbonXMLGetLabel";
        private const string Fieldres_onyx360RibbonXMLGlobalClick = "res_onyx360RibbonXMLGlobalClick";
        private const string Fieldres_onyx360RibbonXMLSettingsClick = "res_onyx360RibbonXMLSettingsClick";
        private const string Fieldres_onyx360RibbonXMLHelpClick = "res_onyx360RibbonXMLHelpClick";
        private const string Fieldres_onyxAppointment = "res_onyxAppointment";
        private const string Fieldres_onyxEmailConversation = "res_onyxEmailConversation";
        private const string Fieldres_onyxEmailMessage = "res_onyxEmailMessage";
        private const string Fieldres_onyxFileLocationAttachment = "res_onyxFileLocationAttachment";
        private const string Fieldres_onyxInfoPanel = "res_onyxInfoPanel";
        private const string Fieldres_onyxOutlookSyncContact = "res_onyxOutlookSyncContact";
        private const string Fieldres_onyxReferenceLookupCache = "res_onyxReferenceLookupCache";
        private const string Fieldres_onyxUserPreferences = "res_onyxUserPreferences";
        private const string Fieldres_outlookItemWrapper = "res_outlookItemWrapper";
        private const string Fieldres_thisAddIn = "res_thisAddIn";
        private const string Fieldres_sessionSettings = "res_sessionSettings";
        private const string Fieldres_onyxInfoPanel_TaskPane = "res_onyxInfoPanel_TaskPane";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxResource)

        #region General Initializer : Class (OnyxResource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxResource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldres_mailItemwrapper)]
        [TestCase(Fieldres_appointmentItemWrapper)]
        [TestCase(Fieldres_contactItemWrapper)]
        [TestCase(Fieldres_countryHelper)]
        [TestCase(Fieldres_addContactControl)]
        [TestCase(Fieldres_addInternalContactControl)]
        [TestCase(Fieldres_createCustomerControl)]
        [TestCase(Fieldres_createCustomerControlAttachment)]
        [TestCase(Fieldres_createCustomerControlCustomerError)]
        [TestCase(Fieldres_createIncidentControl)]
        [TestCase(Fieldres_createIncidentControlSaveIncident)]
        [TestCase(Fieldres_customUtility)]
        [TestCase(Fieldres_duplicateCustomers)]
        [TestCase(Fieldres_emailTemplateControl)]
        [TestCase(Fieldres_inspectorWrapper)]
        [TestCase(Fieldres_itemSelectorControl)]
        [TestCase(Fieldres_outlookItemSelector)]
        [TestCase(Fieldres_onyxDownloadableCustomerSelector)]
        [TestCase(Fieldres_onyxObjectSelector)]
        [TestCase(Fieldres_memberCollection)]
        [TestCase(Fieldres_onyx360RibbonXML)]
        [TestCase(Fieldres_onyx360RibbonXMLToggleClick)]
        [TestCase(Fieldres_onyx360RibbonXMLGetLabel)]
        [TestCase(Fieldres_onyx360RibbonXMLGlobalClick)]
        [TestCase(Fieldres_onyx360RibbonXMLSettingsClick)]
        [TestCase(Fieldres_onyx360RibbonXMLHelpClick)]
        [TestCase(Fieldres_onyxAppointment)]
        [TestCase(Fieldres_onyxEmailConversation)]
        [TestCase(Fieldres_onyxEmailMessage)]
        [TestCase(Fieldres_onyxFileLocationAttachment)]
        [TestCase(Fieldres_onyxInfoPanel)]
        [TestCase(Fieldres_onyxOutlookSyncContact)]
        [TestCase(Fieldres_onyxReferenceLookupCache)]
        [TestCase(Fieldres_onyxUserPreferences)]
        [TestCase(Fieldres_outlookItemWrapper)]
        [TestCase(Fieldres_thisAddIn)]
        [TestCase(Fieldres_sessionSettings)]
        [TestCase(Fieldres_onyxInfoPanel_TaskPane)]
        [Category("AUT Fields")]
        public void AUT_OnyxResource_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxResource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxResource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxResource_Explore_Reflection_Based_NonListed_Fields_Test()
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