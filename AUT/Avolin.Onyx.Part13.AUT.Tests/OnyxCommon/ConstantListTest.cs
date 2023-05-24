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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.ConstantList" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ConstantListTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ConstantListNonPublicTypeName" />) using
        ///     Using a public type <see cref="CountryHelper" /> to
        ///     create a non-public type.
        /// </summary>
        public ConstantListTest() : base(publicType: typeof(CountryHelper), classNameWithNamespace: ConstantListNonPublicTypeName)
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

        private Type _constantListInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ConstantListNonPublicTypeName = "OnyxCommon.ConstantList";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _constantListInstance;
        private object _constantListInstanceFixture;

        #region General Initializer : Class (ConstantList) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ConstantList" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _constantListInstanceFixture = this.CreateNonPublicType(ConstantListNonPublicTypeName);
            _constantListInstance = _constantListInstanceFixture;
            CurrentInstance = _constantListInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ConstantList) Initializer

        #region Fields

        private const string FieldEVENT_MESSAGE_MAX_LENGTH = "EVENT_MESSAGE_MAX_LENGTH";
        private const string FieldPR_SMTP_ADDRESS = "PR_SMTP_ADDRESS";
        private const string FieldEMAIL_DATATYPE = "EMAIL_DATATYPE";
        private const string FieldURL_DATATYPE = "URL_DATATYPE";
        private const string FieldPR_ATTACH_DATA_BIN = "PR_ATTACH_DATA_BIN";
        private const string FieldPR_ATTACH_CONTENT_ID_UNICODE = "PR_ATTACH_CONTENT_ID_UNICODE";
        private const string FieldPR_ATTACH_CONTENT_ID_ANSI = "PR_ATTACH_CONTENT_ID_ANSI";
        private const string FieldEMAIL_MESSAGE_ENUM = "EMAIL_MESSAGE_ENUM";
        private const string FieldPR_CLIENT_SUBMIT_TIME = "PR_CLIENT_SUBMIT_TIME";
        private const string FieldPR_MESSAGE_DELIVERY_TIME = "PR_MESSAGE_DELIVERY_TIME";
        private const string FieldMEMBERS_PER_PAGE = "MEMBERS_PER_PAGE";
        private const string FieldPAGES_LIMIT = "PAGES_LIMIT";
        private const string FieldCONTACTSYNC_DIRECTION_PREFERENCE_NAME = "CONTACTSYNC_DIRECTION_PREFERENCE_NAME";
        private const string FieldCONTACTSYNC_DIRECTION_BIDIRECTIONAL = "CONTACTSYNC_DIRECTION_BIDIRECTIONAL";
        private const string FieldCONTACTSYNC_DIRECTION_ONYXTOOUTLOOK = "CONTACTSYNC_DIRECTION_ONYXTOOUTLOOK";
        private const string FieldDEFAULT_RECORD_LIMIT = "DEFAULT_RECORD_LIMIT";
        private const string FieldEmail1EntryIdPropertyAccessor = "Email1EntryIdPropertyAccessor";
        private const string FieldEmail2EntryIdPropertyAccessor = "Email2EntryIdPropertyAccessor";
        private const string FieldEmail3EntryIdPropertyAccessor = "Email3EntryIdPropertyAccessor";
        private const string FieldONYX = "ONYX";
        private const string FieldOUTLOOK = "OUTLOOK";
        private const string FieldKEEPALIVEINTERVAL = "KEEPALIVEINTERVAL";
        private const string FieldSESSION_INVALID_ERRNUM = "SESSION_INVALID_ERRNUM";
        private const string FieldADDITEM_ACTION = "ADDITEM_ACTION";
        private const string FieldADDEMAILASWORKNOTE_ACTION = "ADDEMAILASWORKNOTE_ACTION";
        private const string FieldPR_SENT_REPRESENTING_ENTRYID = "PR_SENT_REPRESENTING_ENTRYID";
        private const string FieldOUTLOOK_CONTACTSYNC_RESID = "OUTLOOK_CONTACTSYNC_RESID";
        private const string FieldOUTLOOKONYX360 = "OUTLOOKONYX360";
        private const string Field_OUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME = "_OUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME";
        private const string Field_OUTLOOK_MODIFY_SYNC_CONTACT_DIRECTION_RESOURCE_ID = "_OUTLOOK_MODIFY_SYNC_CONTACT_DIRECTION_RESOURCE_ID";
        private const string Field_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_TEXT = "_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_TEXT";
        private const string Field_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_VALUE = "_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_VALUE";
        private const string Field_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_TEXT = "_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_TEXT";
        private const string Field_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_VALUE = "_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_VALUE";
        private const string FieldresourceStringError = "resourceStringError";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ConstantList)

        #region General Initializer : Class (ConstantList) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ConstantList" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldEVENT_MESSAGE_MAX_LENGTH)]
        [TestCase(FieldPR_SMTP_ADDRESS)]
        [TestCase(FieldEMAIL_DATATYPE)]
        [TestCase(FieldURL_DATATYPE)]
        [TestCase(FieldPR_ATTACH_DATA_BIN)]
        [TestCase(FieldPR_ATTACH_CONTENT_ID_UNICODE)]
        [TestCase(FieldPR_ATTACH_CONTENT_ID_ANSI)]
        [TestCase(FieldEMAIL_MESSAGE_ENUM)]
        [TestCase(FieldPR_CLIENT_SUBMIT_TIME)]
        [TestCase(FieldPR_MESSAGE_DELIVERY_TIME)]
        [TestCase(FieldMEMBERS_PER_PAGE)]
        [TestCase(FieldPAGES_LIMIT)]
        [TestCase(FieldCONTACTSYNC_DIRECTION_PREFERENCE_NAME)]
        [TestCase(FieldCONTACTSYNC_DIRECTION_BIDIRECTIONAL)]
        [TestCase(FieldCONTACTSYNC_DIRECTION_ONYXTOOUTLOOK)]
        [TestCase(FieldDEFAULT_RECORD_LIMIT)]
        [TestCase(FieldEmail1EntryIdPropertyAccessor)]
        [TestCase(FieldEmail2EntryIdPropertyAccessor)]
        [TestCase(FieldEmail3EntryIdPropertyAccessor)]
        [TestCase(FieldONYX)]
        [TestCase(FieldOUTLOOK)]
        [TestCase(FieldKEEPALIVEINTERVAL)]
        [TestCase(FieldSESSION_INVALID_ERRNUM)]
        [TestCase(FieldADDITEM_ACTION)]
        [TestCase(FieldADDEMAILASWORKNOTE_ACTION)]
        [TestCase(FieldPR_SENT_REPRESENTING_ENTRYID)]
        [TestCase(FieldOUTLOOK_CONTACTSYNC_RESID)]
        [TestCase(FieldOUTLOOKONYX360)]
        [TestCase(Field_OUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME)]
        [TestCase(Field_OUTLOOK_MODIFY_SYNC_CONTACT_DIRECTION_RESOURCE_ID)]
        [TestCase(Field_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_TEXT)]
        [TestCase(Field_OUTLOOK_SYNC_CONTACT_DIRECTION_BIDIRECTIONAL_VALUE)]
        [TestCase(Field_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_TEXT)]
        [TestCase(Field_OUTLOOK_SYNC_CONTACT_DIRECTION_ONYX_TO_OUTLOOK_VALUE)]
        [TestCase(FieldresourceStringError)]
        [Category("AUT Fields")]
        public void AUT_ConstantList_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ConstantList) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ConstantList" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ConstantList_Explore_Reflection_Based_NonListed_Fields_Test()
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