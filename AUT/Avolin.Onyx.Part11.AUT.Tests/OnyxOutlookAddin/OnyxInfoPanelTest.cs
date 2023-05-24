using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxInfoPanel" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxInfoPanelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxInfoPanel" />)
        /// </summary>
        public OnyxInfoPanelTest() : base(typeof(OnyxInfoPanel))
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

        #region General Initializer : Class (OnyxInfoPanel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxInfoPanelInstanceType;
        private OnyxInfoPanel _onyxInfoPanelInstance;
        private OnyxInfoPanel _onyxInfoPanelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxInfoPanel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxInfoPanelInstanceType = typeof(OnyxInfoPanel);
            _onyxInfoPanelInstanceFixture = this.Create<OnyxInfoPanel>(false);
            _onyxInfoPanelInstance = _onyxInfoPanelInstanceFixture ?? this.Create<OnyxInfoPanel>(true);
            CurrentInstance = _onyxInfoPanelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Initializer

        #region Properties

        private const string PropertyCurrentOutlookItemWrapper = "CurrentOutlookItemWrapper";
        private const string PropertySyncedContact = "SyncedContact";
        private const string PropertyTaskPaneVisible = "TaskPaneVisible";
        private const string PropertyDisabled = "Disabled";
        private const string PropertyCustomControlId = "CustomControlId";
        private const string PropertyIsPopulated = "IsPopulated";
        private const string PropertyIsNeedsRefresh = "IsNeedsRefresh";
        private const string PropertyMembers = "Members";

        #endregion

        #region Methods

        private const string MethodResetPanelDisabledFlag = "ResetPanelDisabledFlag";
        private const string MethoddisablePanel = "disablePanel";
        private const string MethodenablePanel = "enablePanel";
        private const string MethodTogglePanelButtons = "TogglePanelButtons";
        private const string MethodTogglePanelControls = "TogglePanelControls";
        private const string MethodlaunchSettings_LinkClicked = "launchSettings_LinkClicked";
        private const string MethodreEstablishSession_LinkClicked = "reEstablishSession_LinkClicked";
        private const string MethodrePopulateControl_LinkClicked = "rePopulateControl_LinkClicked";
        private const string MethodsyncContact = "syncContact";
        private const string MethodsyncContact_LinkClicked = "syncContact_LinkClicked";
        private const string MethodaddInfoLabelToPanel = "addInfoLabelToPanel";
        private const string MethodresetPagination = "resetPagination";
        private const string MethodpopulateMultiPageContextMenu = "populateMultiPageContextMenu";
        private const string MethodpopulatePaginationControl = "populatePaginationControl";
        private const string MethodhighlLightPageButton = "highlLightPageButton";
        private const string MethodrePopulateButtons = "rePopulateButtons";
        private const string MethodpaginationButton_Click = "paginationButton_Click";
        private const string MethodmultiPageContexMenu_ItemClicked = "multiPageContexMenu_ItemClicked";
        private const string MethodAddItemSelectorToPanel = "AddItemSelectorToPanel";
        private const string MethodResetInfoPanelScrollBars = "ResetInfoPanelScrollBars";
        private const string MethodClearInfoPanelControls = "ClearInfoPanelControls";
        private const string MethodaddUserControlToPanel = "addUserControlToPanel";
        private const string MethodClearCustomerInfo = "ClearCustomerInfo";
        private const string MethodClearNotify = "ClearNotify";
        private const string MethodNotify = "Notify";
        private const string MethodAppendNotify = "AppendNotify";
        private const string MethodReLoadPanelNoRefresh = "ReLoadPanelNoRefresh";
        private const string MethodAddControlToTree = "AddControlToTree";
        private const string MethodCheckForAutoSaveItem = "CheckForAutoSaveItem";
        private const string MethodSetButtonToCancelSave = "SetButtonToCancelSave";
        private const string MethodSetButtonToSave = "SetButtonToSave";
        private const string MethodSetSaveButtonToolTip = "SetSaveButtonToolTip";
        private const string MethodsaveCurrentUnSavedItemToOnyx = "saveCurrentUnSavedItemToOnyx";
        private const string MethodcancelCurrentItemSaveToOnyx = "cancelCurrentItemSaveToOnyx";
        private const string MethodGetChildControls = "GetChildControls";
        private const string MethodgetCustomControlById = "getCustomControlById";
        private const string MethodgetParentControl = "getParentControl";
        private const string MethodRemoveControlInTree = "RemoveControlInTree";
        private const string MethodResetControlTree = "ResetControlTree";
        private const string MethodsearchButton_Click = "searchButton_Click";
        private const string MethodsearchInOnyx_KeyUp = "searchInOnyx_KeyUp";
        private const string MethodsearchForCustomersInOnyx = "searchForCustomersInOnyx";
        private const string MethodemailConversationWorker_DoWork = "emailConversationWorker_DoWork";
        private const string MethodemailConversationWorker_Completed = "emailConversationWorker_Completed";
        private const string MethodSetSubscribeToolTip = "SetSubscribeToolTip";
        private const string MethodPopulateControl = "PopulateControl";
        private const string MethodPopulateCustomerPanelFromMembers = "PopulateCustomerPanelFromMembers";
        private const string MethodaddDivider = "addDivider";
        private const string MethodPopulateControlFromOutlookContact = "PopulateControlFromOutlookContact";
        private const string MethodPopulateCustomerInfoPanelFromIndividuals = "PopulateCustomerInfoPanelFromIndividuals";
        private const string MethodMultiSelect = "MultiSelect";
        private const string MethodrefreshPanelWithMembers = "refreshPanelWithMembers";
        private const string MethodtrackInOnyxBtn_Click = "trackInOnyxBtn_Click";
        private const string MethodresetBtn_Click = "resetBtn_Click";
        private const string MethodbulkInsertBtn_Click = "bulkInsertBtn_Click";
        private const string MethodPopulateItemSelectorControl = "PopulateItemSelectorControl";
        private const string MethodpickContactsBtn_Click = "pickContactsBtn_Click";
        private const string MethodResetTableLayoutPanels = "ResetTableLayoutPanels";
        private const string MethodonyxInfoPanel_Load = "onyxInfoPanel_Load";

        #endregion

        #region Fields

        private const string FieldpageNum = "pageNum";
        private const string FieldcontrolsTree = "controlsTree";
        private const string Fieldsub = "sub";
        private const string Fieldmembers = "members";
        private const string FieldshowOnlyResolved = "showOnlyResolved";
        private const string FieldcontrolId = "controlId";
        private const string FieldoutlookItemWrapper = "outlookItemWrapper";
        private const string FieldsyncedContact = "syncedContact";
        private const string FieldisBeingTracked = "isBeingTracked";
        private const string Fieldlinklable = "linklable";
        private const string FieldisDisabled = "isDisabled";
        private const string FieldpreviewContactsFlag = "previewContactsFlag";
        private const string FieldsyncInProgress = "syncInProgress";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxInfoPanel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxInfoPanel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxInfoPanel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxInfoPanel)

        #region General Initializer : Class (OnyxInfoPanel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodResetPanelDisabledFlag, 0)]
        [TestCase(MethoddisablePanel, 0)]
        [TestCase(MethodenablePanel, 0)]
        [TestCase(MethodTogglePanelButtons, 0)]
        [TestCase(MethodTogglePanelControls, 0)]
        [TestCase(MethodlaunchSettings_LinkClicked, 0)]
        [TestCase(MethodreEstablishSession_LinkClicked, 0)]
        [TestCase(MethodrePopulateControl_LinkClicked, 0)]
        [TestCase(MethodsyncContact, 0)]
        [TestCase(MethodsyncContact_LinkClicked, 0)]
        [TestCase(MethodaddInfoLabelToPanel, 0)]
        [TestCase(MethodresetPagination, 0)]
        [TestCase(MethodpopulateMultiPageContextMenu, 0)]
        [TestCase(MethodpopulatePaginationControl, 0)]
        [TestCase(MethodhighlLightPageButton, 0)]
        [TestCase(MethodrePopulateButtons, 0)]
        [TestCase(MethodpaginationButton_Click, 0)]
        [TestCase(MethodmultiPageContexMenu_ItemClicked, 0)]
        [TestCase(MethodAddItemSelectorToPanel, 0)]
        [TestCase(MethodResetInfoPanelScrollBars, 0)]
        [TestCase(MethodClearInfoPanelControls, 0)]
        [TestCase(MethodaddUserControlToPanel, 0)]
        [TestCase(MethodClearCustomerInfo, 0)]
        [TestCase(MethodClearNotify, 0)]
        [TestCase(MethodNotify, 0)]
        [TestCase(MethodAppendNotify, 0)]
        [TestCase(MethodReLoadPanelNoRefresh, 0)]
        [TestCase(MethodAddControlToTree, 0)]
        [TestCase(MethodCheckForAutoSaveItem, 0)]
        [TestCase(MethodSetButtonToCancelSave, 0)]
        [TestCase(MethodSetButtonToSave, 0)]
        [TestCase(MethodSetSaveButtonToolTip, 0)]
        [TestCase(MethodsaveCurrentUnSavedItemToOnyx, 0)]
        [TestCase(MethodcancelCurrentItemSaveToOnyx, 0)]
        [TestCase(MethodGetChildControls, 0)]
        [TestCase(MethodgetCustomControlById, 0)]
        [TestCase(MethodgetParentControl, 0)]
        [TestCase(MethodRemoveControlInTree, 0)]
        [TestCase(MethodResetControlTree, 0)]
        [TestCase(MethodsearchButton_Click, 0)]
        [TestCase(MethodsearchInOnyx_KeyUp, 0)]
        [TestCase(MethodsearchForCustomersInOnyx, 0)]
        [TestCase(MethodemailConversationWorker_DoWork, 0)]
        [TestCase(MethodemailConversationWorker_Completed, 0)]
        [TestCase(MethodSetSubscribeToolTip, 0)]
        [TestCase(MethodPopulateControl, 0)]
        [TestCase(MethodPopulateCustomerPanelFromMembers, 0)]
        [TestCase(MethodaddDivider, 0)]
        [TestCase(MethodPopulateControlFromOutlookContact, 0)]
        [TestCase(MethodPopulateCustomerInfoPanelFromIndividuals, 0)]
        [TestCase(MethodMultiSelect, 0)]
        [TestCase(MethodrefreshPanelWithMembers, 0)]
        [TestCase(MethodtrackInOnyxBtn_Click, 0)]
        [TestCase(MethodresetBtn_Click, 0)]
        [TestCase(MethodbulkInsertBtn_Click, 0)]
        [TestCase(MethodPopulateItemSelectorControl, 0)]
        [TestCase(MethodpickContactsBtn_Click, 0)]
        [TestCase(MethodResetTableLayoutPanels, 0)]
        [TestCase(MethodonyxInfoPanel_Load, 0)]
        public void AUT_OnyxInfoPanel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxInfoPanel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyCurrentOutlookItemWrapper)]
        [TestCase(PropertySyncedContact)]
        [TestCase(PropertyTaskPaneVisible)]
        [TestCase(PropertyDisabled)]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyMembers)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_OnyxInfoPanel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxInfoPanel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldpageNum)]
        [TestCase(FieldcontrolsTree)]
        [TestCase(Fieldsub)]
        [TestCase(Fieldmembers)]
        [TestCase(FieldshowOnlyResolved)]
        [TestCase(FieldcontrolId)]
        [TestCase(FieldoutlookItemWrapper)]
        [TestCase(FieldsyncedContact)]
        [TestCase(FieldisBeingTracked)]
        [TestCase(Fieldlinklable)]
        [TestCase(FieldisDisabled)]
        [TestCase(FieldpreviewContactsFlag)]
        [TestCase(FieldsyncInProgress)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OnyxInfoPanel_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxInfoPanel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OnyxInfoPanel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxInfoPanelInstance.ShouldBeAssignableTo<OnyxInfoPanel>();
            _onyxInfoPanelInstanceFixture.ShouldBeAssignableTo<OnyxInfoPanel>();
            CurrentInstance.ShouldBeAssignableTo<OnyxInfoPanel>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxInfoPanel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyCurrentOutlookItemWrapper)]
        [TestCase(PropertySyncedContact)]
        [TestCase(PropertyTaskPaneVisible)]
        [TestCase(PropertyDisabled)]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyMembers)]
        public void AUT_OnyxInfoPanel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (CurrentOutlookItemWrapper) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_CurrentOutlookItemWrapper_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentOutlookItemWrapper);
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentOutlookItemWrapper);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (CustomControlId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_CustomControlId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);
            Action currentAction = () => propertyInfo.SetValue(_onyxInfoPanelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (CustomControlId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_CustomControlId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (Disabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_Disabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisabled);
            var propertyInfo = this.GetPropertyInfo(PropertyDisabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (IsNeedsRefresh) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_IsNeedsRefresh_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsNeedsRefresh);
            var propertyInfo = this.GetPropertyInfo(PropertyIsNeedsRefresh);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (IsPopulated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_IsPopulated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsPopulated);
            var propertyInfo = this.GetPropertyInfo(PropertyIsPopulated);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (Members) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Members_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMembers);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMembers);
            Action currentAction = () => propertyInfo.SetValue(_onyxInfoPanelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (Members) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_Members_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMembers);
            var propertyInfo = this.GetPropertyInfo(PropertyMembers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (SyncedContact) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_SyncedContact_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySyncedContact);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySyncedContact);
            Action currentAction = () => propertyInfo.SetValue(_onyxInfoPanelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (SyncedContact) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_SyncedContact_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySyncedContact);
            var propertyInfo = this.GetPropertyInfo(PropertySyncedContact);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxInfoPanel) => Property (TaskPaneVisible) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxInfoPanel_Public_Class_TaskPaneVisible_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTaskPaneVisible);
            var propertyInfo = this.GetPropertyInfo(PropertyTaskPaneVisible);

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

        #region Method Call : (ResetPanelDisabledFlag) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetPanelDisabledFlag_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPanelDisabledFlag);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ResetPanelDisabledFlag();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetPanelDisabledFlag) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetPanelDisabledFlag_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPanelDisabledFlag);
            Type [] methodResetPanelDisabledFlagParametersTypes = null;
            object[] parametersOfResetPanelDisabledFlag = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetPanelDisabledFlag, methodResetPanelDisabledFlagParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfResetPanelDisabledFlag);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetPanelDisabledFlag.ShouldBeNull();
            methodResetPanelDisabledFlagParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetPanelDisabledFlag) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetPanelDisabledFlag_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPanelDisabledFlag);
            Type [] methodResetPanelDisabledFlagParametersTypes = null;
            object[] parametersOfResetPanelDisabledFlag = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetPanelDisabledFlag, parametersOfResetPanelDisabledFlag, methodResetPanelDisabledFlagParametersTypes);

            // Assert
            parametersOfResetPanelDisabledFlag.ShouldBeNull();
            methodResetPanelDisabledFlagParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetPanelDisabledFlag) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetPanelDisabledFlag_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPanelDisabledFlag);
            Type [] methodResetPanelDisabledFlagParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetPanelDisabledFlag, methodResetPanelDisabledFlagParametersTypes);

            // Assert
            methodResetPanelDisabledFlagParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetPanelDisabledFlag) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetPanelDisabledFlag_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPanelDisabledFlag);
            var currentMethodInfo = this.GetMethodInfo(MethodResetPanelDisabledFlag, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (disablePanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_disablePanel_Method_Call_Internally(Type[] types)
        {
            var methoddisablePanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethoddisablePanel, methoddisablePanelParametersTypes);
        }

        #endregion

        #region Method Call : (disablePanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_disablePanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddisablePanel);
            Type [] methoddisablePanelParametersTypes = null;
            object[] parametersOfdisablePanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethoddisablePanel, methoddisablePanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfdisablePanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfdisablePanel.ShouldBeNull();
            methoddisablePanelParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (disablePanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_disablePanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddisablePanel);
            Type [] methoddisablePanelParametersTypes = null;
            object[] parametersOfdisablePanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethoddisablePanel, parametersOfdisablePanel, methoddisablePanelParametersTypes);

            // Assert
            parametersOfdisablePanel.ShouldBeNull();
            methoddisablePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (disablePanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_disablePanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddisablePanel);
            Type [] methoddisablePanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethoddisablePanel, methoddisablePanelParametersTypes);

            // Assert
            methoddisablePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (disablePanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_disablePanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddisablePanel);
            var currentMethodInfo = this.GetMethodInfo(MethoddisablePanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (enablePanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_enablePanel_Method_Call_Internally(Type[] types)
        {
            var methodenablePanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodenablePanel, methodenablePanelParametersTypes);
        }

        #endregion

        #region Method Call : (enablePanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_enablePanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodenablePanel);
            Type [] methodenablePanelParametersTypes = null;
            object[] parametersOfenablePanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodenablePanel, methodenablePanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfenablePanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfenablePanel.ShouldBeNull();
            methodenablePanelParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (enablePanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_enablePanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodenablePanel);
            Type [] methodenablePanelParametersTypes = null;
            object[] parametersOfenablePanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodenablePanel, parametersOfenablePanel, methodenablePanelParametersTypes);

            // Assert
            parametersOfenablePanel.ShouldBeNull();
            methodenablePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (enablePanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_enablePanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodenablePanel);
            Type [] methodenablePanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodenablePanel, methodenablePanelParametersTypes);

            // Assert
            methodenablePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (enablePanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_enablePanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodenablePanel);
            var currentMethodInfo = this.GetMethodInfo(MethodenablePanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_Internally(Type[] types)
        {
            var methodTogglePanelButtonsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTogglePanelButtons, methodTogglePanelButtonsParametersTypes);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var isVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.TogglePanelButtons(isVisible);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var isVisible = this.CreateType<bool>();
            var methodTogglePanelButtonsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfTogglePanelButtons = { isVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelButtons, methodTogglePanelButtonsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfTogglePanelButtons);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTogglePanelButtons.ShouldNotBeNull();
            parametersOfTogglePanelButtons.Length.ShouldBe(1);
            methodTogglePanelButtonsParametersTypes.Length.ShouldBe(1);
            methodTogglePanelButtonsParametersTypes.Length.ShouldBe(parametersOfTogglePanelButtons.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var isVisible = this.CreateType<bool>();
            var methodTogglePanelButtonsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfTogglePanelButtons = { isVisible };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodTogglePanelButtons, parametersOfTogglePanelButtons, methodTogglePanelButtonsParametersTypes);

            // Assert
            parametersOfTogglePanelButtons.ShouldNotBeNull();
            parametersOfTogglePanelButtons.Length.ShouldBe(1);
            methodTogglePanelButtonsParametersTypes.Length.ShouldBe(1);
            methodTogglePanelButtonsParametersTypes.Length.ShouldBe(parametersOfTogglePanelButtons.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelButtons, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var methodTogglePanelButtonsParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTogglePanelButtons, methodTogglePanelButtonsParametersTypes);

            // Assert
            methodTogglePanelButtonsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelButtons) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelButtons_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelButtons);
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelButtons, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_Internally(Type[] types)
        {
            var methodTogglePanelControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodTogglePanelControls, methodTogglePanelControlsParametersTypes);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var isVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.TogglePanelControls(isVisible);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var isVisible = this.CreateType<bool>();
            var methodTogglePanelControlsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfTogglePanelControls = { isVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelControls, methodTogglePanelControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfTogglePanelControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfTogglePanelControls.ShouldNotBeNull();
            parametersOfTogglePanelControls.Length.ShouldBe(1);
            methodTogglePanelControlsParametersTypes.Length.ShouldBe(1);
            methodTogglePanelControlsParametersTypes.Length.ShouldBe(parametersOfTogglePanelControls.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var isVisible = this.CreateType<bool>();
            var methodTogglePanelControlsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfTogglePanelControls = { isVisible };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodTogglePanelControls, parametersOfTogglePanelControls, methodTogglePanelControlsParametersTypes);

            // Assert
            parametersOfTogglePanelControls.ShouldNotBeNull();
            parametersOfTogglePanelControls.Length.ShouldBe(1);
            methodTogglePanelControlsParametersTypes.Length.ShouldBe(1);
            methodTogglePanelControlsParametersTypes.Length.ShouldBe(parametersOfTogglePanelControls.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelControls, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var methodTogglePanelControlsParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTogglePanelControls, methodTogglePanelControlsParametersTypes);

            // Assert
            methodTogglePanelControlsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TogglePanelControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_TogglePanelControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTogglePanelControls);
            var currentMethodInfo = this.GetMethodInfo(MethodTogglePanelControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodlaunchSettings_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlaunchSettings_LinkClicked, methodlaunchSettings_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlaunchSettings_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodlaunchSettings_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOflaunchSettings_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodlaunchSettings_LinkClicked, methodlaunchSettings_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOflaunchSettings_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOflaunchSettings_LinkClicked.ShouldNotBeNull();
            parametersOflaunchSettings_LinkClicked.Length.ShouldBe(2);
            methodlaunchSettings_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodlaunchSettings_LinkClickedParametersTypes.Length.ShouldBe(parametersOflaunchSettings_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlaunchSettings_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodlaunchSettings_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOflaunchSettings_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodlaunchSettings_LinkClicked, parametersOflaunchSettings_LinkClicked, methodlaunchSettings_LinkClickedParametersTypes);

            // Assert
            parametersOflaunchSettings_LinkClicked.ShouldNotBeNull();
            parametersOflaunchSettings_LinkClicked.Length.ShouldBe(2);
            methodlaunchSettings_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodlaunchSettings_LinkClickedParametersTypes.Length.ShouldBe(parametersOflaunchSettings_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlaunchSettings_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodlaunchSettings_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlaunchSettings_LinkClicked);
            var methodlaunchSettings_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlaunchSettings_LinkClicked, methodlaunchSettings_LinkClickedParametersTypes);

            // Assert
            methodlaunchSettings_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (launchSettings_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_launchSettings_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlaunchSettings_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodlaunchSettings_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodreEstablishSession_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodreEstablishSession_LinkClicked, methodreEstablishSession_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreEstablishSession_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodreEstablishSession_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfreEstablishSession_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodreEstablishSession_LinkClicked, methodreEstablishSession_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfreEstablishSession_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfreEstablishSession_LinkClicked.ShouldNotBeNull();
            parametersOfreEstablishSession_LinkClicked.Length.ShouldBe(2);
            methodreEstablishSession_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodreEstablishSession_LinkClickedParametersTypes.Length.ShouldBe(parametersOfreEstablishSession_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreEstablishSession_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodreEstablishSession_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfreEstablishSession_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodreEstablishSession_LinkClicked, parametersOfreEstablishSession_LinkClicked, methodreEstablishSession_LinkClickedParametersTypes);

            // Assert
            parametersOfreEstablishSession_LinkClicked.ShouldNotBeNull();
            parametersOfreEstablishSession_LinkClicked.Length.ShouldBe(2);
            methodreEstablishSession_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodreEstablishSession_LinkClickedParametersTypes.Length.ShouldBe(parametersOfreEstablishSession_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreEstablishSession_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodreEstablishSession_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreEstablishSession_LinkClicked);
            var methodreEstablishSession_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodreEstablishSession_LinkClicked, methodreEstablishSession_LinkClickedParametersTypes);

            // Assert
            methodreEstablishSession_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (reEstablishSession_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_reEstablishSession_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreEstablishSession_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodreEstablishSession_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodrePopulateControl_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodrePopulateControl_LinkClicked, methodrePopulateControl_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateControl_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodrePopulateControl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfrePopulateControl_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateControl_LinkClicked, methodrePopulateControl_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfrePopulateControl_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfrePopulateControl_LinkClicked.ShouldNotBeNull();
            parametersOfrePopulateControl_LinkClicked.Length.ShouldBe(2);
            methodrePopulateControl_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodrePopulateControl_LinkClickedParametersTypes.Length.ShouldBe(parametersOfrePopulateControl_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateControl_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodrePopulateControl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfrePopulateControl_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodrePopulateControl_LinkClicked, parametersOfrePopulateControl_LinkClicked, methodrePopulateControl_LinkClickedParametersTypes);

            // Assert
            parametersOfrePopulateControl_LinkClicked.ShouldNotBeNull();
            parametersOfrePopulateControl_LinkClicked.Length.ShouldBe(2);
            methodrePopulateControl_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodrePopulateControl_LinkClickedParametersTypes.Length.ShouldBe(parametersOfrePopulateControl_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateControl_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateControl_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateControl_LinkClicked);
            var methodrePopulateControl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodrePopulateControl_LinkClicked, methodrePopulateControl_LinkClickedParametersTypes);

            // Assert
            methodrePopulateControl_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateControl_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateControl_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateControl_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateControl_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_syncContact_Method_Call_Internally(Type[] types)
        {
            var methodsyncContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsyncContact, methodsyncContactParametersTypes);
        }

        #endregion

        #region Method Call : (syncContact) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact);
            Type [] methodsyncContactParametersTypes = null;
            object[] parametersOfsyncContact = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsyncContact, methodsyncContactParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsyncContact);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsyncContact.ShouldBeNull();
            methodsyncContactParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (syncContact) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact);
            Type [] methodsyncContactParametersTypes = null;
            object[] parametersOfsyncContact = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsyncContact, parametersOfsyncContact, methodsyncContactParametersTypes);

            // Assert
            parametersOfsyncContact.ShouldBeNull();
            methodsyncContactParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact);
            Type [] methodsyncContactParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsyncContact, methodsyncContactParametersTypes);

            // Assert
            methodsyncContactParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact);
            var currentMethodInfo = this.GetMethodInfo(MethodsyncContact, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodsyncContact_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsyncContact_LinkClicked, methodsyncContact_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodsyncContact_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfsyncContact_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsyncContact_LinkClicked, methodsyncContact_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsyncContact_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsyncContact_LinkClicked.ShouldNotBeNull();
            parametersOfsyncContact_LinkClicked.Length.ShouldBe(2);
            methodsyncContact_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodsyncContact_LinkClickedParametersTypes.Length.ShouldBe(parametersOfsyncContact_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodsyncContact_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfsyncContact_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsyncContact_LinkClicked, parametersOfsyncContact_LinkClicked, methodsyncContact_LinkClickedParametersTypes);

            // Assert
            parametersOfsyncContact_LinkClicked.ShouldNotBeNull();
            parametersOfsyncContact_LinkClicked.Length.ShouldBe(2);
            methodsyncContact_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodsyncContact_LinkClickedParametersTypes.Length.ShouldBe(parametersOfsyncContact_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodsyncContact_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact_LinkClicked);
            var methodsyncContact_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsyncContact_LinkClicked, methodsyncContact_LinkClickedParametersTypes);

            // Assert
            methodsyncContact_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (syncContact_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_syncContact_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsyncContact_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodsyncContact_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_Internally(Type[] types)
        {
            var methodaddInfoLabelToPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddInfoLabelToPanel, methodaddInfoLabelToPanelParametersTypes);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInfoLabelToPanel);
            var lbltext = this.CreateType<string>();
            var isHyperLink = this.CreateType<bool>();
            var onClickMethod = this.CreateType<LinkLabelLinkClickedEventHandler>();
            var methodaddInfoLabelToPanelParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(LinkLabelLinkClickedEventHandler) };
            object[] parametersOfaddInfoLabelToPanel = { lbltext, isHyperLink, onClickMethod };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddInfoLabelToPanel, methodaddInfoLabelToPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfaddInfoLabelToPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddInfoLabelToPanel.ShouldNotBeNull();
            parametersOfaddInfoLabelToPanel.Length.ShouldBe(3);
            methodaddInfoLabelToPanelParametersTypes.Length.ShouldBe(3);
            methodaddInfoLabelToPanelParametersTypes.Length.ShouldBe(parametersOfaddInfoLabelToPanel.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInfoLabelToPanel);
            var lbltext = this.CreateType<string>();
            var isHyperLink = this.CreateType<bool>();
            var onClickMethod = this.CreateType<LinkLabelLinkClickedEventHandler>();
            var methodaddInfoLabelToPanelParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(LinkLabelLinkClickedEventHandler) };
            object[] parametersOfaddInfoLabelToPanel = { lbltext, isHyperLink, onClickMethod };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddInfoLabelToPanel, parametersOfaddInfoLabelToPanel, methodaddInfoLabelToPanelParametersTypes);

            // Assert
            parametersOfaddInfoLabelToPanel.ShouldNotBeNull();
            parametersOfaddInfoLabelToPanel.Length.ShouldBe(3);
            methodaddInfoLabelToPanelParametersTypes.Length.ShouldBe(3);
            methodaddInfoLabelToPanelParametersTypes.Length.ShouldBe(parametersOfaddInfoLabelToPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInfoLabelToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInfoLabelToPanel, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInfoLabelToPanel);
            var methodaddInfoLabelToPanelParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(LinkLabelLinkClickedEventHandler) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddInfoLabelToPanel, methodaddInfoLabelToPanelParametersTypes);

            // Assert
            methodaddInfoLabelToPanelParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInfoLabelToPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addInfoLabelToPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInfoLabelToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInfoLabelToPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_resetPagination_Method_Call_Internally(Type[] types)
        {
            var methodresetPaginationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodresetPagination, methodresetPaginationParametersTypes);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetPagination_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetPagination);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.resetPagination();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetPagination_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetPagination);
            Type [] methodresetPaginationParametersTypes = null;
            object[] parametersOfresetPagination = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodresetPagination, methodresetPaginationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfresetPagination);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfresetPagination.ShouldBeNull();
            methodresetPaginationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetPagination_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetPagination);
            Type [] methodresetPaginationParametersTypes = null;
            object[] parametersOfresetPagination = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodresetPagination, parametersOfresetPagination, methodresetPaginationParametersTypes);

            // Assert
            parametersOfresetPagination.ShouldBeNull();
            methodresetPaginationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetPagination_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetPagination);
            Type [] methodresetPaginationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodresetPagination, methodresetPaginationParametersTypes);

            // Assert
            methodresetPaginationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetPagination) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetPagination_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetPagination);
            var currentMethodInfo = this.GetMethodInfo(MethodresetPagination, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_Internally(Type[] types)
        {
            var methodpopulateMultiPageContextMenuParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateMultiPageContextMenu, methodpopulateMultiPageContextMenuParametersTypes);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateMultiPageContextMenu);
            var menuStrip = this.CreateType<ContextMenuStrip>();
            var pageLimit = this.CreateType<int>();
            var totalPages = this.CreateType<int>();
            var methodpopulateMultiPageContextMenuParametersTypes = new Type[] { typeof(ContextMenuStrip), typeof(int), typeof(int) };
            object[] parametersOfpopulateMultiPageContextMenu = { menuStrip, pageLimit, totalPages };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateMultiPageContextMenu, methodpopulateMultiPageContextMenuParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfpopulateMultiPageContextMenu);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateMultiPageContextMenu.ShouldNotBeNull();
            parametersOfpopulateMultiPageContextMenu.Length.ShouldBe(3);
            methodpopulateMultiPageContextMenuParametersTypes.Length.ShouldBe(3);
            methodpopulateMultiPageContextMenuParametersTypes.Length.ShouldBe(parametersOfpopulateMultiPageContextMenu.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateMultiPageContextMenu);
            var menuStrip = this.CreateType<ContextMenuStrip>();
            var pageLimit = this.CreateType<int>();
            var totalPages = this.CreateType<int>();
            var methodpopulateMultiPageContextMenuParametersTypes = new Type[] { typeof(ContextMenuStrip), typeof(int), typeof(int) };
            object[] parametersOfpopulateMultiPageContextMenu = { menuStrip, pageLimit, totalPages };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateMultiPageContextMenu, parametersOfpopulateMultiPageContextMenu, methodpopulateMultiPageContextMenuParametersTypes);

            // Assert
            parametersOfpopulateMultiPageContextMenu.ShouldNotBeNull();
            parametersOfpopulateMultiPageContextMenu.Length.ShouldBe(3);
            methodpopulateMultiPageContextMenuParametersTypes.Length.ShouldBe(3);
            methodpopulateMultiPageContextMenuParametersTypes.Length.ShouldBe(parametersOfpopulateMultiPageContextMenu.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateMultiPageContextMenu);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateMultiPageContextMenu, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateMultiPageContextMenu);
            var methodpopulateMultiPageContextMenuParametersTypes = new Type[] { typeof(ContextMenuStrip), typeof(int), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateMultiPageContextMenu, methodpopulateMultiPageContextMenuParametersTypes);

            // Assert
            methodpopulateMultiPageContextMenuParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateMultiPageContextMenu) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populateMultiPageContextMenu_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateMultiPageContextMenu);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateMultiPageContextMenu, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populatePaginationControl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_populatePaginationControl_Method_Call_Internally(Type[] types)
        {
            var methodpopulatePaginationControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulatePaginationControl, methodpopulatePaginationControlParametersTypes);
        }

        #endregion

        #region Method Call : (populatePaginationControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populatePaginationControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulatePaginationControl);
            Type [] methodpopulatePaginationControlParametersTypes = null;
            object[] parametersOfpopulatePaginationControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulatePaginationControl, methodpopulatePaginationControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfpopulatePaginationControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulatePaginationControl.ShouldBeNull();
            methodpopulatePaginationControlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populatePaginationControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populatePaginationControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulatePaginationControl);
            Type [] methodpopulatePaginationControlParametersTypes = null;
            object[] parametersOfpopulatePaginationControl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulatePaginationControl, parametersOfpopulatePaginationControl, methodpopulatePaginationControlParametersTypes);

            // Assert
            parametersOfpopulatePaginationControl.ShouldBeNull();
            methodpopulatePaginationControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populatePaginationControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populatePaginationControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulatePaginationControl);
            Type [] methodpopulatePaginationControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulatePaginationControl, methodpopulatePaginationControlParametersTypes);

            // Assert
            methodpopulatePaginationControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populatePaginationControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_populatePaginationControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulatePaginationControl);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulatePaginationControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_Internally(Type[] types)
        {
            var methodhighlLightPageButtonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodhighlLightPageButton, methodhighlLightPageButtonParametersTypes);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhighlLightPageButton);
            var buttonNum = this.CreateType<int>();
            var methodhighlLightPageButtonParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfhighlLightPageButton = { buttonNum };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodhighlLightPageButton, methodhighlLightPageButtonParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfhighlLightPageButton);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfhighlLightPageButton.ShouldNotBeNull();
            parametersOfhighlLightPageButton.Length.ShouldBe(1);
            methodhighlLightPageButtonParametersTypes.Length.ShouldBe(1);
            methodhighlLightPageButtonParametersTypes.Length.ShouldBe(parametersOfhighlLightPageButton.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhighlLightPageButton);
            var buttonNum = this.CreateType<int>();
            var methodhighlLightPageButtonParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfhighlLightPageButton = { buttonNum };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodhighlLightPageButton, parametersOfhighlLightPageButton, methodhighlLightPageButtonParametersTypes);

            // Assert
            parametersOfhighlLightPageButton.ShouldNotBeNull();
            parametersOfhighlLightPageButton.Length.ShouldBe(1);
            methodhighlLightPageButtonParametersTypes.Length.ShouldBe(1);
            methodhighlLightPageButtonParametersTypes.Length.ShouldBe(parametersOfhighlLightPageButton.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhighlLightPageButton);
            var currentMethodInfo = this.GetMethodInfo(MethodhighlLightPageButton, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhighlLightPageButton);
            var methodhighlLightPageButtonParametersTypes = new Type[] { typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodhighlLightPageButton, methodhighlLightPageButtonParametersTypes);

            // Assert
            methodhighlLightPageButtonParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (highlLightPageButton) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_highlLightPageButton_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhighlLightPageButton);
            var currentMethodInfo = this.GetMethodInfo(MethodhighlLightPageButton, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_Internally(Type[] types)
        {
            var methodrePopulateButtonsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodrePopulateButtons, methodrePopulateButtonsParametersTypes);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateButtons);
            var pageNumClicked = this.CreateType<int>();
            var methodrePopulateButtonsParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfrePopulateButtons = { pageNumClicked };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateButtons, methodrePopulateButtonsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfrePopulateButtons);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfrePopulateButtons.ShouldNotBeNull();
            parametersOfrePopulateButtons.Length.ShouldBe(1);
            methodrePopulateButtonsParametersTypes.Length.ShouldBe(1);
            methodrePopulateButtonsParametersTypes.Length.ShouldBe(parametersOfrePopulateButtons.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateButtons);
            var pageNumClicked = this.CreateType<int>();
            var methodrePopulateButtonsParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfrePopulateButtons = { pageNumClicked };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodrePopulateButtons, parametersOfrePopulateButtons, methodrePopulateButtonsParametersTypes);

            // Assert
            parametersOfrePopulateButtons.ShouldNotBeNull();
            parametersOfrePopulateButtons.Length.ShouldBe(1);
            methodrePopulateButtonsParametersTypes.Length.ShouldBe(1);
            methodrePopulateButtonsParametersTypes.Length.ShouldBe(parametersOfrePopulateButtons.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateButtons);
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateButtons, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateButtons);
            var methodrePopulateButtonsParametersTypes = new Type[] { typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodrePopulateButtons, methodrePopulateButtonsParametersTypes);

            // Assert
            methodrePopulateButtonsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (rePopulateButtons) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_rePopulateButtons_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrePopulateButtons);
            var currentMethodInfo = this.GetMethodInfo(MethodrePopulateButtons, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodpaginationButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpaginationButton_Click, methodpaginationButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpaginationButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodpaginationButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfpaginationButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpaginationButton_Click, methodpaginationButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfpaginationButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpaginationButton_Click.ShouldNotBeNull();
            parametersOfpaginationButton_Click.Length.ShouldBe(2);
            methodpaginationButton_ClickParametersTypes.Length.ShouldBe(2);
            methodpaginationButton_ClickParametersTypes.Length.ShouldBe(parametersOfpaginationButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpaginationButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodpaginationButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfpaginationButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpaginationButton_Click, parametersOfpaginationButton_Click, methodpaginationButton_ClickParametersTypes);

            // Assert
            parametersOfpaginationButton_Click.ShouldNotBeNull();
            parametersOfpaginationButton_Click.Length.ShouldBe(2);
            methodpaginationButton_ClickParametersTypes.Length.ShouldBe(2);
            methodpaginationButton_ClickParametersTypes.Length.ShouldBe(parametersOfpaginationButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpaginationButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodpaginationButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpaginationButton_Click);
            var methodpaginationButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpaginationButton_Click, methodpaginationButton_ClickParametersTypes);

            // Assert
            methodpaginationButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (paginationButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_paginationButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpaginationButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodpaginationButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_Internally(Type[] types)
        {
            var methodmultiPageContexMenu_ItemClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodmultiPageContexMenu_ItemClicked, methodmultiPageContexMenu_ItemClickedParametersTypes);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmultiPageContexMenu_ItemClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<ToolStripItemClickedEventArgs>();
            var methodmultiPageContexMenu_ItemClickedParametersTypes = new Type[] { typeof(object), typeof(ToolStripItemClickedEventArgs) };
            object[] parametersOfmultiPageContexMenu_ItemClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodmultiPageContexMenu_ItemClicked, methodmultiPageContexMenu_ItemClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfmultiPageContexMenu_ItemClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfmultiPageContexMenu_ItemClicked.ShouldNotBeNull();
            parametersOfmultiPageContexMenu_ItemClicked.Length.ShouldBe(2);
            methodmultiPageContexMenu_ItemClickedParametersTypes.Length.ShouldBe(2);
            methodmultiPageContexMenu_ItemClickedParametersTypes.Length.ShouldBe(parametersOfmultiPageContexMenu_ItemClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmultiPageContexMenu_ItemClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<ToolStripItemClickedEventArgs>();
            var methodmultiPageContexMenu_ItemClickedParametersTypes = new Type[] { typeof(object), typeof(ToolStripItemClickedEventArgs) };
            object[] parametersOfmultiPageContexMenu_ItemClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodmultiPageContexMenu_ItemClicked, parametersOfmultiPageContexMenu_ItemClicked, methodmultiPageContexMenu_ItemClickedParametersTypes);

            // Assert
            parametersOfmultiPageContexMenu_ItemClicked.ShouldNotBeNull();
            parametersOfmultiPageContexMenu_ItemClicked.Length.ShouldBe(2);
            methodmultiPageContexMenu_ItemClickedParametersTypes.Length.ShouldBe(2);
            methodmultiPageContexMenu_ItemClickedParametersTypes.Length.ShouldBe(parametersOfmultiPageContexMenu_ItemClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmultiPageContexMenu_ItemClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodmultiPageContexMenu_ItemClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmultiPageContexMenu_ItemClicked);
            var methodmultiPageContexMenu_ItemClickedParametersTypes = new Type[] { typeof(object), typeof(ToolStripItemClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodmultiPageContexMenu_ItemClicked, methodmultiPageContexMenu_ItemClickedParametersTypes);

            // Assert
            methodmultiPageContexMenu_ItemClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (multiPageContexMenu_ItemClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_multiPageContexMenu_ItemClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmultiPageContexMenu_ItemClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodmultiPageContexMenu_ItemClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_Internally(Type[] types)
        {
            var methodAddItemSelectorToPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddItemSelectorToPanel, methodAddItemSelectorToPanelParametersTypes);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var itemSelector = this.CreateType<ItemSelectorControl>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.AddItemSelectorToPanel(itemSelector);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var itemSelector = this.CreateType<ItemSelectorControl>();
            var methodAddItemSelectorToPanelParametersTypes = new Type[] { typeof(ItemSelectorControl) };
            object[] parametersOfAddItemSelectorToPanel = { itemSelector };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddItemSelectorToPanel, methodAddItemSelectorToPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfAddItemSelectorToPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddItemSelectorToPanel.ShouldNotBeNull();
            parametersOfAddItemSelectorToPanel.Length.ShouldBe(1);
            methodAddItemSelectorToPanelParametersTypes.Length.ShouldBe(1);
            methodAddItemSelectorToPanelParametersTypes.Length.ShouldBe(parametersOfAddItemSelectorToPanel.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var itemSelector = this.CreateType<ItemSelectorControl>();
            var methodAddItemSelectorToPanelParametersTypes = new Type[] { typeof(ItemSelectorControl) };
            object[] parametersOfAddItemSelectorToPanel = { itemSelector };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddItemSelectorToPanel, parametersOfAddItemSelectorToPanel, methodAddItemSelectorToPanelParametersTypes);

            // Assert
            parametersOfAddItemSelectorToPanel.ShouldNotBeNull();
            parametersOfAddItemSelectorToPanel.Length.ShouldBe(1);
            methodAddItemSelectorToPanelParametersTypes.Length.ShouldBe(1);
            methodAddItemSelectorToPanelParametersTypes.Length.ShouldBe(parametersOfAddItemSelectorToPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodAddItemSelectorToPanel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var methodAddItemSelectorToPanelParametersTypes = new Type[] { typeof(ItemSelectorControl) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddItemSelectorToPanel, methodAddItemSelectorToPanelParametersTypes);

            // Assert
            methodAddItemSelectorToPanelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddItemSelectorToPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddItemSelectorToPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddItemSelectorToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodAddItemSelectorToPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_Call_Internally(Type[] types)
        {
            var methodResetInfoPanelScrollBarsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetInfoPanelScrollBars, methodResetInfoPanelScrollBarsParametersTypes);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetInfoPanelScrollBars);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ResetInfoPanelScrollBars();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetInfoPanelScrollBars);
            Type [] methodResetInfoPanelScrollBarsParametersTypes = null;
            object[] parametersOfResetInfoPanelScrollBars = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetInfoPanelScrollBars, methodResetInfoPanelScrollBarsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfResetInfoPanelScrollBars);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetInfoPanelScrollBars.ShouldBeNull();
            methodResetInfoPanelScrollBarsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetInfoPanelScrollBars);
            Type [] methodResetInfoPanelScrollBarsParametersTypes = null;
            object[] parametersOfResetInfoPanelScrollBars = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetInfoPanelScrollBars, parametersOfResetInfoPanelScrollBars, methodResetInfoPanelScrollBarsParametersTypes);

            // Assert
            parametersOfResetInfoPanelScrollBars.ShouldBeNull();
            methodResetInfoPanelScrollBarsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetInfoPanelScrollBars);
            Type [] methodResetInfoPanelScrollBarsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetInfoPanelScrollBars, methodResetInfoPanelScrollBarsParametersTypes);

            // Assert
            methodResetInfoPanelScrollBarsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetInfoPanelScrollBars) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetInfoPanelScrollBars_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetInfoPanelScrollBars);
            var currentMethodInfo = this.GetMethodInfo(MethodResetInfoPanelScrollBars, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_Call_Internally(Type[] types)
        {
            var methodClearInfoPanelControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearInfoPanelControls, methodClearInfoPanelControlsParametersTypes);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearInfoPanelControls);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ClearInfoPanelControls();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearInfoPanelControls);
            Type [] methodClearInfoPanelControlsParametersTypes = null;
            object[] parametersOfClearInfoPanelControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearInfoPanelControls, methodClearInfoPanelControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfClearInfoPanelControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearInfoPanelControls.ShouldBeNull();
            methodClearInfoPanelControlsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearInfoPanelControls);
            Type [] methodClearInfoPanelControlsParametersTypes = null;
            object[] parametersOfClearInfoPanelControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearInfoPanelControls, parametersOfClearInfoPanelControls, methodClearInfoPanelControlsParametersTypes);

            // Assert
            parametersOfClearInfoPanelControls.ShouldBeNull();
            methodClearInfoPanelControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearInfoPanelControls);
            Type [] methodClearInfoPanelControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearInfoPanelControls, methodClearInfoPanelControlsParametersTypes);

            // Assert
            methodClearInfoPanelControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearInfoPanelControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearInfoPanelControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearInfoPanelControls);
            var currentMethodInfo = this.GetMethodInfo(MethodClearInfoPanelControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_Internally(Type[] types)
        {
            var methodaddUserControlToPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddUserControlToPanel, methodaddUserControlToPanelParametersTypes);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var ctl = this.CreateType<UserControl>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.addUserControlToPanel(ctl);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var ctl = this.CreateType<UserControl>();
            var methodaddUserControlToPanelParametersTypes = new Type[] { typeof(UserControl) };
            object[] parametersOfaddUserControlToPanel = { ctl };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddUserControlToPanel, methodaddUserControlToPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfaddUserControlToPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddUserControlToPanel.ShouldNotBeNull();
            parametersOfaddUserControlToPanel.Length.ShouldBe(1);
            methodaddUserControlToPanelParametersTypes.Length.ShouldBe(1);
            methodaddUserControlToPanelParametersTypes.Length.ShouldBe(parametersOfaddUserControlToPanel.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var ctl = this.CreateType<UserControl>();
            var methodaddUserControlToPanelParametersTypes = new Type[] { typeof(UserControl) };
            object[] parametersOfaddUserControlToPanel = { ctl };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddUserControlToPanel, parametersOfaddUserControlToPanel, methodaddUserControlToPanelParametersTypes);

            // Assert
            parametersOfaddUserControlToPanel.ShouldNotBeNull();
            parametersOfaddUserControlToPanel.Length.ShouldBe(1);
            methodaddUserControlToPanelParametersTypes.Length.ShouldBe(1);
            methodaddUserControlToPanelParametersTypes.Length.ShouldBe(parametersOfaddUserControlToPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodaddUserControlToPanel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var methodaddUserControlToPanelParametersTypes = new Type[] { typeof(UserControl) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddUserControlToPanel, methodaddUserControlToPanelParametersTypes);

            // Assert
            methodaddUserControlToPanelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addUserControlToPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addUserControlToPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddUserControlToPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodaddUserControlToPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_Call_Internally(Type[] types)
        {
            var methodClearCustomerInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearCustomerInfo, methodClearCustomerInfoParametersTypes);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCustomerInfo);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ClearCustomerInfo();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCustomerInfo);
            Type [] methodClearCustomerInfoParametersTypes = null;
            object[] parametersOfClearCustomerInfo = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearCustomerInfo, methodClearCustomerInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfClearCustomerInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearCustomerInfo.ShouldBeNull();
            methodClearCustomerInfoParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCustomerInfo);
            Type [] methodClearCustomerInfoParametersTypes = null;
            object[] parametersOfClearCustomerInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearCustomerInfo, parametersOfClearCustomerInfo, methodClearCustomerInfoParametersTypes);

            // Assert
            parametersOfClearCustomerInfo.ShouldBeNull();
            methodClearCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCustomerInfo);
            Type [] methodClearCustomerInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearCustomerInfo, methodClearCustomerInfoParametersTypes);

            // Assert
            methodClearCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCustomerInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearCustomerInfo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCustomerInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodClearCustomerInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ClearNotify_Method_Call_Internally(Type[] types)
        {
            var methodClearNotifyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearNotify, methodClearNotifyParametersTypes);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearNotify_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearNotify);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ClearNotify();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearNotify_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearNotify);
            Type [] methodClearNotifyParametersTypes = null;
            object[] parametersOfClearNotify = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearNotify, methodClearNotifyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfClearNotify);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearNotify.ShouldBeNull();
            methodClearNotifyParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearNotify_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearNotify);
            Type [] methodClearNotifyParametersTypes = null;
            object[] parametersOfClearNotify = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearNotify, parametersOfClearNotify, methodClearNotifyParametersTypes);

            // Assert
            parametersOfClearNotify.ShouldBeNull();
            methodClearNotifyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearNotify_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearNotify);
            Type [] methodClearNotifyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearNotify, methodClearNotifyParametersTypes);

            // Assert
            methodClearNotifyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearNotify) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ClearNotify_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearNotify);
            var currentMethodInfo = this.GetMethodInfo(MethodClearNotify, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_Notify_Method_Call_Internally(Type[] types)
        {
            var methodNotifyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNotify, methodNotifyParametersTypes);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var text = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.Notify(text);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var text = this.CreateType<string>();
            var methodNotifyParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfNotify = { text };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodNotify, methodNotifyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfNotify);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfNotify.ShouldNotBeNull();
            parametersOfNotify.Length.ShouldBe(1);
            methodNotifyParametersTypes.Length.ShouldBe(1);
            methodNotifyParametersTypes.Length.ShouldBe(parametersOfNotify.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var text = this.CreateType<string>();
            var methodNotifyParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfNotify = { text };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodNotify, parametersOfNotify, methodNotifyParametersTypes);

            // Assert
            parametersOfNotify.ShouldNotBeNull();
            parametersOfNotify.Length.ShouldBe(1);
            methodNotifyParametersTypes.Length.ShouldBe(1);
            methodNotifyParametersTypes.Length.ShouldBe(parametersOfNotify.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var currentMethodInfo = this.GetMethodInfo(MethodNotify, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var methodNotifyParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodNotify, methodNotifyParametersTypes);

            // Assert
            methodNotifyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Notify) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_Notify_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNotify);
            var currentMethodInfo = this.GetMethodInfo(MethodNotify, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_AppendNotify_Method_Call_Internally(Type[] types)
        {
            var methodAppendNotifyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAppendNotify, methodAppendNotifyParametersTypes);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var text = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.AppendNotify(text);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var text = this.CreateType<string>();
            var methodAppendNotifyParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAppendNotify = { text };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNotify, methodAppendNotifyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfAppendNotify);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAppendNotify.ShouldNotBeNull();
            parametersOfAppendNotify.Length.ShouldBe(1);
            methodAppendNotifyParametersTypes.Length.ShouldBe(1);
            methodAppendNotifyParametersTypes.Length.ShouldBe(parametersOfAppendNotify.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var text = this.CreateType<string>();
            var methodAppendNotifyParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAppendNotify = { text };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAppendNotify, parametersOfAppendNotify, methodAppendNotifyParametersTypes);

            // Assert
            parametersOfAppendNotify.ShouldNotBeNull();
            parametersOfAppendNotify.Length.ShouldBe(1);
            methodAppendNotifyParametersTypes.Length.ShouldBe(1);
            methodAppendNotifyParametersTypes.Length.ShouldBe(parametersOfAppendNotify.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNotify, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var methodAppendNotifyParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendNotify, methodAppendNotifyParametersTypes);

            // Assert
            methodAppendNotifyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendNotify) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AppendNotify_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendNotify);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendNotify, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_Internally(Type[] types)
        {
            var methodReLoadPanelNoRefreshParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReLoadPanelNoRefresh, methodReLoadPanelNoRefreshParametersTypes);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var clearNotify = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ReLoadPanelNoRefresh(clearNotify);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var clearNotify = this.CreateType<bool>();
            var methodReLoadPanelNoRefreshParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfReLoadPanelNoRefresh = { clearNotify };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodReLoadPanelNoRefresh, methodReLoadPanelNoRefreshParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfReLoadPanelNoRefresh);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReLoadPanelNoRefresh.ShouldNotBeNull();
            parametersOfReLoadPanelNoRefresh.Length.ShouldBe(1);
            methodReLoadPanelNoRefreshParametersTypes.Length.ShouldBe(1);
            methodReLoadPanelNoRefreshParametersTypes.Length.ShouldBe(parametersOfReLoadPanelNoRefresh.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var clearNotify = this.CreateType<bool>();
            var methodReLoadPanelNoRefreshParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfReLoadPanelNoRefresh = { clearNotify };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodReLoadPanelNoRefresh, parametersOfReLoadPanelNoRefresh, methodReLoadPanelNoRefreshParametersTypes);

            // Assert
            parametersOfReLoadPanelNoRefresh.ShouldNotBeNull();
            parametersOfReLoadPanelNoRefresh.Length.ShouldBe(1);
            methodReLoadPanelNoRefreshParametersTypes.Length.ShouldBe(1);
            methodReLoadPanelNoRefreshParametersTypes.Length.ShouldBe(parametersOfReLoadPanelNoRefresh.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var currentMethodInfo = this.GetMethodInfo(MethodReLoadPanelNoRefresh, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var methodReLoadPanelNoRefreshParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReLoadPanelNoRefresh, methodReLoadPanelNoRefreshParametersTypes);

            // Assert
            methodReLoadPanelNoRefreshParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReLoadPanelNoRefresh) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ReLoadPanelNoRefresh_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReLoadPanelNoRefresh);
            var currentMethodInfo = this.GetMethodInfo(MethodReLoadPanelNoRefresh, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_Internally(Type[] types)
        {
            var methodAddControlToTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddControlToTree, methodAddControlToTreeParametersTypes);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var child = this.CreateType<ICustomControl>();
            var parentControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.AddControlToTree(child, parentControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var child = this.CreateType<ICustomControl>();
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(ICustomControl), typeof(String) };
            object[] parametersOfAddControlToTree = { child, parentControlId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, methodAddControlToTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfAddControlToTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(2);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(2);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var child = this.CreateType<ICustomControl>();
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(ICustomControl), typeof(String) };
            object[] parametersOfAddControlToTree = { child, parentControlId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddControlToTree, parametersOfAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(2);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(2);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(ICustomControl), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            methodAddControlToTreeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_AddControlToTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_Call_Internally(Type[] types)
        {
            var methodCheckForAutoSaveItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckForAutoSaveItem, methodCheckForAutoSaveItemParametersTypes);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForAutoSaveItem);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.CheckForAutoSaveItem();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForAutoSaveItem);
            Type [] methodCheckForAutoSaveItemParametersTypes = null;
            object[] parametersOfCheckForAutoSaveItem = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForAutoSaveItem, methodCheckForAutoSaveItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfCheckForAutoSaveItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckForAutoSaveItem.ShouldBeNull();
            methodCheckForAutoSaveItemParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForAutoSaveItem);
            Type [] methodCheckForAutoSaveItemParametersTypes = null;
            object[] parametersOfCheckForAutoSaveItem = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCheckForAutoSaveItem, parametersOfCheckForAutoSaveItem, methodCheckForAutoSaveItemParametersTypes);

            // Assert
            parametersOfCheckForAutoSaveItem.ShouldBeNull();
            methodCheckForAutoSaveItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForAutoSaveItem);
            Type [] methodCheckForAutoSaveItemParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckForAutoSaveItem, methodCheckForAutoSaveItemParametersTypes);

            // Assert
            methodCheckForAutoSaveItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckForAutoSaveItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_CheckForAutoSaveItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForAutoSaveItem);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForAutoSaveItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_Call_Internally(Type[] types)
        {
            var methodSetButtonToCancelSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetButtonToCancelSave, methodSetButtonToCancelSaveParametersTypes);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToCancelSave);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.SetButtonToCancelSave();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToCancelSave);
            Type [] methodSetButtonToCancelSaveParametersTypes = null;
            object[] parametersOfSetButtonToCancelSave = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetButtonToCancelSave, methodSetButtonToCancelSaveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfSetButtonToCancelSave);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetButtonToCancelSave.ShouldBeNull();
            methodSetButtonToCancelSaveParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToCancelSave);
            Type [] methodSetButtonToCancelSaveParametersTypes = null;
            object[] parametersOfSetButtonToCancelSave = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetButtonToCancelSave, parametersOfSetButtonToCancelSave, methodSetButtonToCancelSaveParametersTypes);

            // Assert
            parametersOfSetButtonToCancelSave.ShouldBeNull();
            methodSetButtonToCancelSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToCancelSave);
            Type [] methodSetButtonToCancelSaveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetButtonToCancelSave, methodSetButtonToCancelSaveParametersTypes);

            // Assert
            methodSetButtonToCancelSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToCancelSave) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToCancelSave_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToCancelSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSetButtonToCancelSave, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_SetButtonToSave_Method_Call_Internally(Type[] types)
        {
            var methodSetButtonToSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetButtonToSave, methodSetButtonToSaveParametersTypes);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToSave_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToSave);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.SetButtonToSave();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToSave_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToSave);
            Type [] methodSetButtonToSaveParametersTypes = null;
            object[] parametersOfSetButtonToSave = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetButtonToSave, methodSetButtonToSaveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfSetButtonToSave);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetButtonToSave.ShouldBeNull();
            methodSetButtonToSaveParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToSave_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToSave);
            Type [] methodSetButtonToSaveParametersTypes = null;
            object[] parametersOfSetButtonToSave = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetButtonToSave, parametersOfSetButtonToSave, methodSetButtonToSaveParametersTypes);

            // Assert
            parametersOfSetButtonToSave.ShouldBeNull();
            methodSetButtonToSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToSave_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToSave);
            Type [] methodSetButtonToSaveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetButtonToSave, methodSetButtonToSaveParametersTypes);

            // Assert
            methodSetButtonToSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetButtonToSave) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetButtonToSave_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetButtonToSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSetButtonToSave, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_Internally(Type[] types)
        {
            var methodSetSaveButtonToolTipParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSaveButtonToolTip, methodSetSaveButtonToolTipParametersTypes);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var tooltip = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.SetSaveButtonToolTip(tooltip);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var tooltip = this.CreateType<string>();
            var methodSetSaveButtonToolTipParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfSetSaveButtonToolTip = { tooltip };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSaveButtonToolTip, methodSetSaveButtonToolTipParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfSetSaveButtonToolTip);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSaveButtonToolTip.ShouldNotBeNull();
            parametersOfSetSaveButtonToolTip.Length.ShouldBe(1);
            methodSetSaveButtonToolTipParametersTypes.Length.ShouldBe(1);
            methodSetSaveButtonToolTipParametersTypes.Length.ShouldBe(parametersOfSetSaveButtonToolTip.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var tooltip = this.CreateType<string>();
            var methodSetSaveButtonToolTipParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfSetSaveButtonToolTip = { tooltip };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSaveButtonToolTip, parametersOfSetSaveButtonToolTip, methodSetSaveButtonToolTipParametersTypes);

            // Assert
            parametersOfSetSaveButtonToolTip.ShouldNotBeNull();
            parametersOfSetSaveButtonToolTip.Length.ShouldBe(1);
            methodSetSaveButtonToolTipParametersTypes.Length.ShouldBe(1);
            methodSetSaveButtonToolTipParametersTypes.Length.ShouldBe(parametersOfSetSaveButtonToolTip.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSaveButtonToolTip, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var methodSetSaveButtonToolTipParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSaveButtonToolTip, methodSetSaveButtonToolTipParametersTypes);

            // Assert
            methodSetSaveButtonToolTipParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSaveButtonToolTip) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSaveButtonToolTip_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSaveButtonToolTip);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSaveButtonToolTip, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveCurrentUnSavedItemToOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_saveCurrentUnSavedItemToOnyx_Method_Call_Internally(Type[] types)
        {
            var methodsaveCurrentUnSavedItemToOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsaveCurrentUnSavedItemToOnyx, methodsaveCurrentUnSavedItemToOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (saveCurrentUnSavedItemToOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_saveCurrentUnSavedItemToOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveCurrentUnSavedItemToOnyx);
            Type [] methodsaveCurrentUnSavedItemToOnyxParametersTypes = null;
            object[] parametersOfsaveCurrentUnSavedItemToOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsaveCurrentUnSavedItemToOnyx, methodsaveCurrentUnSavedItemToOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsaveCurrentUnSavedItemToOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsaveCurrentUnSavedItemToOnyx.ShouldBeNull();
            methodsaveCurrentUnSavedItemToOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (saveCurrentUnSavedItemToOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_saveCurrentUnSavedItemToOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveCurrentUnSavedItemToOnyx);
            Type [] methodsaveCurrentUnSavedItemToOnyxParametersTypes = null;
            object[] parametersOfsaveCurrentUnSavedItemToOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsaveCurrentUnSavedItemToOnyx, parametersOfsaveCurrentUnSavedItemToOnyx, methodsaveCurrentUnSavedItemToOnyxParametersTypes);

            // Assert
            parametersOfsaveCurrentUnSavedItemToOnyx.ShouldBeNull();
            methodsaveCurrentUnSavedItemToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveCurrentUnSavedItemToOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_saveCurrentUnSavedItemToOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveCurrentUnSavedItemToOnyx);
            Type [] methodsaveCurrentUnSavedItemToOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsaveCurrentUnSavedItemToOnyx, methodsaveCurrentUnSavedItemToOnyxParametersTypes);

            // Assert
            methodsaveCurrentUnSavedItemToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveCurrentUnSavedItemToOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_saveCurrentUnSavedItemToOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveCurrentUnSavedItemToOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodsaveCurrentUnSavedItemToOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelCurrentItemSaveToOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_cancelCurrentItemSaveToOnyx_Method_Call_Internally(Type[] types)
        {
            var methodcancelCurrentItemSaveToOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcancelCurrentItemSaveToOnyx, methodcancelCurrentItemSaveToOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (cancelCurrentItemSaveToOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_cancelCurrentItemSaveToOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelCurrentItemSaveToOnyx);
            Type [] methodcancelCurrentItemSaveToOnyxParametersTypes = null;
            object[] parametersOfcancelCurrentItemSaveToOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcancelCurrentItemSaveToOnyx, methodcancelCurrentItemSaveToOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfcancelCurrentItemSaveToOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcancelCurrentItemSaveToOnyx.ShouldBeNull();
            methodcancelCurrentItemSaveToOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cancelCurrentItemSaveToOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_cancelCurrentItemSaveToOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelCurrentItemSaveToOnyx);
            Type [] methodcancelCurrentItemSaveToOnyxParametersTypes = null;
            object[] parametersOfcancelCurrentItemSaveToOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcancelCurrentItemSaveToOnyx, parametersOfcancelCurrentItemSaveToOnyx, methodcancelCurrentItemSaveToOnyxParametersTypes);

            // Assert
            parametersOfcancelCurrentItemSaveToOnyx.ShouldBeNull();
            methodcancelCurrentItemSaveToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelCurrentItemSaveToOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_cancelCurrentItemSaveToOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelCurrentItemSaveToOnyx);
            Type [] methodcancelCurrentItemSaveToOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcancelCurrentItemSaveToOnyx, methodcancelCurrentItemSaveToOnyxParametersTypes);

            // Assert
            methodcancelCurrentItemSaveToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelCurrentItemSaveToOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_cancelCurrentItemSaveToOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelCurrentItemSaveToOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodcancelCurrentItemSaveToOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_GetChildControls_Method_Call_Internally(Type[] types)
        {
            var methodGetChildControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetChildControls, methodGetChildControlsParametersTypes);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var parentControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.GetChildControls(parentControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var parentControlId = this.CreateType<string>();
            var returnedValue = default(List<ICustomControl>);

            // Act
            Action executeAction = () => returnedValue = _onyxInfoPanelInstance.GetChildControls(parentControlId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var parentControlId = this.CreateType<string>();
            var methodGetChildControlsParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetChildControls = { parentControlId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildControls, methodGetChildControlsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ICustomControl>>(_onyxInfoPanelInstanceFixture, parametersOfGetChildControls);
            var result2 = this.GetResultOfMethod<List<ICustomControl>>(MethodGetChildControls, parametersOfGetChildControls, methodGetChildControlsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetChildControls.ShouldNotBeNull();
            parametersOfGetChildControls.Length.ShouldBe(1);
            methodGetChildControlsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var parentControlId = this.CreateType<string>();
            var methodGetChildControlsParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetChildControls = { parentControlId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ICustomControl>>(MethodGetChildControls, parametersOfGetChildControls, methodGetChildControlsParametersTypes);

            // Assert
            parametersOfGetChildControls.ShouldNotBeNull();
            parametersOfGetChildControls.Length.ShouldBe(1);
            methodGetChildControlsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var methodGetChildControlsParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetChildControls, methodGetChildControlsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetChildControlsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var methodGetChildControlsParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetChildControls, methodGetChildControlsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetChildControlsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildControls, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetChildControls) (Return Type : List<ICustomControl>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_GetChildControls_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetChildControls);
            var currentMethodInfo = this.GetMethodInfo(MethodGetChildControls, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_Internally(Type[] types)
        {
            var methodgetCustomControlByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetCustomControlById, methodgetCustomControlByIdParametersTypes);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var paramControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.getCustomControlById(paramControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var paramControlId = this.CreateType<string>();
            var returnedValue = default(ICustomControl);

            // Act
            Action executeAction = () => returnedValue = _onyxInfoPanelInstance.getCustomControlById(paramControlId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var paramControlId = this.CreateType<string>();
            var methodgetCustomControlByIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetCustomControlById = { paramControlId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetCustomControlById, methodgetCustomControlByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ICustomControl>(_onyxInfoPanelInstanceFixture, parametersOfgetCustomControlById);
            var result2 = this.GetResultOfMethod<ICustomControl>(MethodgetCustomControlById, parametersOfgetCustomControlById, methodgetCustomControlByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetCustomControlById.ShouldNotBeNull();
            parametersOfgetCustomControlById.Length.ShouldBe(1);
            methodgetCustomControlByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var paramControlId = this.CreateType<string>();
            var methodgetCustomControlByIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetCustomControlById = { paramControlId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ICustomControl>(MethodgetCustomControlById, parametersOfgetCustomControlById, methodgetCustomControlByIdParametersTypes);

            // Assert
            parametersOfgetCustomControlById.ShouldNotBeNull();
            parametersOfgetCustomControlById.Length.ShouldBe(1);
            methodgetCustomControlByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var methodgetCustomControlByIdParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetCustomControlById, methodgetCustomControlByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetCustomControlByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var methodgetCustomControlByIdParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetCustomControlById, methodgetCustomControlByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetCustomControlByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCustomControlById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getCustomControlById) (Return Type : ICustomControl) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getCustomControlById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCustomControlById);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCustomControlById, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_getParentControl_Method_Call_Internally(Type[] types)
        {
            var methodgetParentControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetParentControl, methodgetParentControlParametersTypes);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var chilControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.getParentControl(chilControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var chilControlId = this.CreateType<string>();
            var returnedValue = default(ICustomControl);

            // Act
            Action executeAction = () => returnedValue = _onyxInfoPanelInstance.getParentControl(chilControlId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var chilControlId = this.CreateType<string>();
            var methodgetParentControlParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetParentControl = { chilControlId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetParentControl, methodgetParentControlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ICustomControl>(_onyxInfoPanelInstanceFixture, parametersOfgetParentControl);
            var result2 = this.GetResultOfMethod<ICustomControl>(MethodgetParentControl, parametersOfgetParentControl, methodgetParentControlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetParentControl.ShouldNotBeNull();
            parametersOfgetParentControl.Length.ShouldBe(1);
            methodgetParentControlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var chilControlId = this.CreateType<string>();
            var methodgetParentControlParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetParentControl = { chilControlId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ICustomControl>(MethodgetParentControl, parametersOfgetParentControl, methodgetParentControlParametersTypes);

            // Assert
            parametersOfgetParentControl.ShouldNotBeNull();
            parametersOfgetParentControl.Length.ShouldBe(1);
            methodgetParentControlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var methodgetParentControlParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetParentControl, methodgetParentControlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetParentControlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var methodgetParentControlParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetParentControl, methodgetParentControlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetParentControlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var currentMethodInfo = this.GetMethodInfo(MethodgetParentControl, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getParentControl) (Return Type : ICustomControl) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_getParentControl_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetParentControl);
            var currentMethodInfo = this.GetMethodInfo(MethodgetParentControl, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_Internally(Type[] types)
        {
            var methodRemoveControlInTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveControlInTree, methodRemoveControlInTreeParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var paramControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.RemoveControlInTree(paramControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var paramControlId = this.CreateType<string>();
            var methodRemoveControlInTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRemoveControlInTree = { paramControlId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveControlInTree, methodRemoveControlInTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfRemoveControlInTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveControlInTree.ShouldNotBeNull();
            parametersOfRemoveControlInTree.Length.ShouldBe(1);
            methodRemoveControlInTreeParametersTypes.Length.ShouldBe(1);
            methodRemoveControlInTreeParametersTypes.Length.ShouldBe(parametersOfRemoveControlInTree.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var paramControlId = this.CreateType<string>();
            var methodRemoveControlInTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRemoveControlInTree = { paramControlId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveControlInTree, parametersOfRemoveControlInTree, methodRemoveControlInTreeParametersTypes);

            // Assert
            parametersOfRemoveControlInTree.ShouldNotBeNull();
            parametersOfRemoveControlInTree.Length.ShouldBe(1);
            methodRemoveControlInTreeParametersTypes.Length.ShouldBe(1);
            methodRemoveControlInTreeParametersTypes.Length.ShouldBe(parametersOfRemoveControlInTree.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveControlInTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var methodRemoveControlInTreeParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveControlInTree, methodRemoveControlInTreeParametersTypes);

            // Assert
            methodRemoveControlInTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveControlInTree) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_RemoveControlInTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveControlInTree);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveControlInTree, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ResetControlTree_Method_Call_Internally(Type[] types)
        {
            var methodResetControlTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetControlTree, methodResetControlTreeParametersTypes);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetControlTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetControlTree);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ResetControlTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetControlTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetControlTree);
            Type [] methodResetControlTreeParametersTypes = null;
            object[] parametersOfResetControlTree = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetControlTree, methodResetControlTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfResetControlTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetControlTree.ShouldBeNull();
            methodResetControlTreeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetControlTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetControlTree);
            Type [] methodResetControlTreeParametersTypes = null;
            object[] parametersOfResetControlTree = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetControlTree, parametersOfResetControlTree, methodResetControlTreeParametersTypes);

            // Assert
            parametersOfResetControlTree.ShouldBeNull();
            methodResetControlTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetControlTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetControlTree);
            Type [] methodResetControlTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetControlTree, methodResetControlTreeParametersTypes);

            // Assert
            methodResetControlTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetControlTree) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetControlTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetControlTree);
            var currentMethodInfo = this.GetMethodInfo(MethodResetControlTree, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodsearchButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsearchButton_Click, methodsearchButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsearchButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsearchButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsearchButton_Click, methodsearchButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsearchButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsearchButton_Click.ShouldNotBeNull();
            parametersOfsearchButton_Click.Length.ShouldBe(2);
            methodsearchButton_ClickParametersTypes.Length.ShouldBe(2);
            methodsearchButton_ClickParametersTypes.Length.ShouldBe(parametersOfsearchButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsearchButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsearchButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsearchButton_Click, parametersOfsearchButton_Click, methodsearchButton_ClickParametersTypes);

            // Assert
            parametersOfsearchButton_Click.ShouldNotBeNull();
            parametersOfsearchButton_Click.Length.ShouldBe(2);
            methodsearchButton_ClickParametersTypes.Length.ShouldBe(2);
            methodsearchButton_ClickParametersTypes.Length.ShouldBe(parametersOfsearchButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchButton_Click);
            var methodsearchButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsearchButton_Click, methodsearchButton_ClickParametersTypes);

            // Assert
            methodsearchButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_Internally(Type[] types)
        {
            var methodsearchInOnyx_KeyUpParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsearchInOnyx_KeyUp, methodsearchInOnyx_KeyUpParametersTypes);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchInOnyx_KeyUp);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyEventArgs>();
            var methodsearchInOnyx_KeyUpParametersTypes = new Type[] { typeof(object), typeof(KeyEventArgs) };
            object[] parametersOfsearchInOnyx_KeyUp = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsearchInOnyx_KeyUp, methodsearchInOnyx_KeyUpParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsearchInOnyx_KeyUp);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsearchInOnyx_KeyUp.ShouldNotBeNull();
            parametersOfsearchInOnyx_KeyUp.Length.ShouldBe(2);
            methodsearchInOnyx_KeyUpParametersTypes.Length.ShouldBe(2);
            methodsearchInOnyx_KeyUpParametersTypes.Length.ShouldBe(parametersOfsearchInOnyx_KeyUp.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchInOnyx_KeyUp);
            var sender = this.CreateType<object>();
            var e = this.CreateType<KeyEventArgs>();
            var methodsearchInOnyx_KeyUpParametersTypes = new Type[] { typeof(object), typeof(KeyEventArgs) };
            object[] parametersOfsearchInOnyx_KeyUp = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsearchInOnyx_KeyUp, parametersOfsearchInOnyx_KeyUp, methodsearchInOnyx_KeyUpParametersTypes);

            // Assert
            parametersOfsearchInOnyx_KeyUp.ShouldNotBeNull();
            parametersOfsearchInOnyx_KeyUp.Length.ShouldBe(2);
            methodsearchInOnyx_KeyUpParametersTypes.Length.ShouldBe(2);
            methodsearchInOnyx_KeyUpParametersTypes.Length.ShouldBe(parametersOfsearchInOnyx_KeyUp.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchInOnyx_KeyUp);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchInOnyx_KeyUp, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchInOnyx_KeyUp);
            var methodsearchInOnyx_KeyUpParametersTypes = new Type[] { typeof(object), typeof(KeyEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsearchInOnyx_KeyUp, methodsearchInOnyx_KeyUpParametersTypes);

            // Assert
            methodsearchInOnyx_KeyUpParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchInOnyx_KeyUp) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchInOnyx_KeyUp_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchInOnyx_KeyUp);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchInOnyx_KeyUp, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodsearchForCustomersInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsearchForCustomersInOnyx, methodsearchForCustomersInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchForCustomersInOnyx);
            var searchString = this.CreateType<string>();
            var methodsearchForCustomersInOnyxParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfsearchForCustomersInOnyx = { searchString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsearchForCustomersInOnyx, methodsearchForCustomersInOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfsearchForCustomersInOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsearchForCustomersInOnyx.ShouldNotBeNull();
            parametersOfsearchForCustomersInOnyx.Length.ShouldBe(1);
            methodsearchForCustomersInOnyxParametersTypes.Length.ShouldBe(1);
            methodsearchForCustomersInOnyxParametersTypes.Length.ShouldBe(parametersOfsearchForCustomersInOnyx.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchForCustomersInOnyx);
            var searchString = this.CreateType<string>();
            var methodsearchForCustomersInOnyxParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfsearchForCustomersInOnyx = { searchString };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsearchForCustomersInOnyx, parametersOfsearchForCustomersInOnyx, methodsearchForCustomersInOnyxParametersTypes);

            // Assert
            parametersOfsearchForCustomersInOnyx.ShouldNotBeNull();
            parametersOfsearchForCustomersInOnyx.Length.ShouldBe(1);
            methodsearchForCustomersInOnyxParametersTypes.Length.ShouldBe(1);
            methodsearchForCustomersInOnyxParametersTypes.Length.ShouldBe(parametersOfsearchForCustomersInOnyx.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchForCustomersInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchForCustomersInOnyx, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchForCustomersInOnyx);
            var methodsearchForCustomersInOnyxParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsearchForCustomersInOnyx, methodsearchForCustomersInOnyxParametersTypes);

            // Assert
            methodsearchForCustomersInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (searchForCustomersInOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_searchForCustomersInOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsearchForCustomersInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodsearchForCustomersInOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_Internally(Type[] types)
        {
            var methodemailConversationWorker_DoWorkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodemailConversationWorker_DoWork, methodemailConversationWorker_DoWorkParametersTypes);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_DoWork);
            var sender = this.CreateType<object>();
            var e = this.CreateType<DoWorkEventArgs>();
            var methodemailConversationWorker_DoWorkParametersTypes = new Type[] { typeof(object), typeof(DoWorkEventArgs) };
            object[] parametersOfemailConversationWorker_DoWork = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_DoWork, methodemailConversationWorker_DoWorkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfemailConversationWorker_DoWork);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailConversationWorker_DoWork.ShouldNotBeNull();
            parametersOfemailConversationWorker_DoWork.Length.ShouldBe(2);
            methodemailConversationWorker_DoWorkParametersTypes.Length.ShouldBe(2);
            methodemailConversationWorker_DoWorkParametersTypes.Length.ShouldBe(parametersOfemailConversationWorker_DoWork.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_DoWork);
            var sender = this.CreateType<object>();
            var e = this.CreateType<DoWorkEventArgs>();
            var methodemailConversationWorker_DoWorkParametersTypes = new Type[] { typeof(object), typeof(DoWorkEventArgs) };
            object[] parametersOfemailConversationWorker_DoWork = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailConversationWorker_DoWork, parametersOfemailConversationWorker_DoWork, methodemailConversationWorker_DoWorkParametersTypes);

            // Assert
            parametersOfemailConversationWorker_DoWork.ShouldNotBeNull();
            parametersOfemailConversationWorker_DoWork.Length.ShouldBe(2);
            methodemailConversationWorker_DoWorkParametersTypes.Length.ShouldBe(2);
            methodemailConversationWorker_DoWorkParametersTypes.Length.ShouldBe(parametersOfemailConversationWorker_DoWork.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_DoWork);
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_DoWork, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_DoWork);
            var methodemailConversationWorker_DoWorkParametersTypes = new Type[] { typeof(object), typeof(DoWorkEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailConversationWorker_DoWork, methodemailConversationWorker_DoWorkParametersTypes);

            // Assert
            methodemailConversationWorker_DoWorkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_DoWork) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_DoWork_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_DoWork);
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_DoWork, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_Internally(Type[] types)
        {
            var methodemailConversationWorker_CompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodemailConversationWorker_Completed, methodemailConversationWorker_CompletedParametersTypes);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_Completed);
            var sender = this.CreateType<object>();
            var e = this.CreateType<RunWorkerCompletedEventArgs>();
            var methodemailConversationWorker_CompletedParametersTypes = new Type[] { typeof(object), typeof(RunWorkerCompletedEventArgs) };
            object[] parametersOfemailConversationWorker_Completed = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_Completed, methodemailConversationWorker_CompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfemailConversationWorker_Completed);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailConversationWorker_Completed.ShouldNotBeNull();
            parametersOfemailConversationWorker_Completed.Length.ShouldBe(2);
            methodemailConversationWorker_CompletedParametersTypes.Length.ShouldBe(2);
            methodemailConversationWorker_CompletedParametersTypes.Length.ShouldBe(parametersOfemailConversationWorker_Completed.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_Completed);
            var sender = this.CreateType<object>();
            var e = this.CreateType<RunWorkerCompletedEventArgs>();
            var methodemailConversationWorker_CompletedParametersTypes = new Type[] { typeof(object), typeof(RunWorkerCompletedEventArgs) };
            object[] parametersOfemailConversationWorker_Completed = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailConversationWorker_Completed, parametersOfemailConversationWorker_Completed, methodemailConversationWorker_CompletedParametersTypes);

            // Assert
            parametersOfemailConversationWorker_Completed.ShouldNotBeNull();
            parametersOfemailConversationWorker_Completed.Length.ShouldBe(2);
            methodemailConversationWorker_CompletedParametersTypes.Length.ShouldBe(2);
            methodemailConversationWorker_CompletedParametersTypes.Length.ShouldBe(parametersOfemailConversationWorker_Completed.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_Completed);
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_Completed, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_Completed);
            var methodemailConversationWorker_CompletedParametersTypes = new Type[] { typeof(object), typeof(RunWorkerCompletedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailConversationWorker_Completed, methodemailConversationWorker_CompletedParametersTypes);

            // Assert
            methodemailConversationWorker_CompletedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailConversationWorker_Completed) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_emailConversationWorker_Completed_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailConversationWorker_Completed);
            var currentMethodInfo = this.GetMethodInfo(MethodemailConversationWorker_Completed, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_Internally(Type[] types)
        {
            var methodSetSubscribeToolTipParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSubscribeToolTip, methodSetSubscribeToolTipParametersTypes);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var text = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.SetSubscribeToolTip(text);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var text = this.CreateType<string>();
            var methodSetSubscribeToolTipParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetSubscribeToolTip = { text };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscribeToolTip, methodSetSubscribeToolTipParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfSetSubscribeToolTip);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSubscribeToolTip.ShouldNotBeNull();
            parametersOfSetSubscribeToolTip.Length.ShouldBe(1);
            methodSetSubscribeToolTipParametersTypes.Length.ShouldBe(1);
            methodSetSubscribeToolTipParametersTypes.Length.ShouldBe(parametersOfSetSubscribeToolTip.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var text = this.CreateType<string>();
            var methodSetSubscribeToolTipParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetSubscribeToolTip = { text };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSubscribeToolTip, parametersOfSetSubscribeToolTip, methodSetSubscribeToolTipParametersTypes);

            // Assert
            parametersOfSetSubscribeToolTip.ShouldNotBeNull();
            parametersOfSetSubscribeToolTip.Length.ShouldBe(1);
            methodSetSubscribeToolTipParametersTypes.Length.ShouldBe(1);
            methodSetSubscribeToolTipParametersTypes.Length.ShouldBe(parametersOfSetSubscribeToolTip.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscribeToolTip, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var methodSetSubscribeToolTipParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSubscribeToolTip, methodSetSubscribeToolTipParametersTypes);

            // Assert
            methodSetSubscribeToolTipParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscribeToolTip) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_SetSubscribeToolTip_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscribeToolTip);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscribeToolTip, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_PopulateControl_Method_Call_Internally(Type[] types)
        {
            var methodPopulateControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.PopulateControl();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfPopulateControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateControl, parametersOfPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_Internally(Type[] types)
        {
            var methodPopulateCustomerPanelFromMembersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateCustomerPanelFromMembers, methodPopulateCustomerPanelFromMembersParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var paramMembers = this.CreateType<MemberCollection>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.PopulateCustomerPanelFromMembers(paramMembers);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var paramMembers = this.CreateType<MemberCollection>();
            var methodPopulateCustomerPanelFromMembersParametersTypes = new Type[] { typeof(MemberCollection) };
            object[] parametersOfPopulateCustomerPanelFromMembers = { paramMembers };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerPanelFromMembers, methodPopulateCustomerPanelFromMembersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfPopulateCustomerPanelFromMembers);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateCustomerPanelFromMembers.ShouldNotBeNull();
            parametersOfPopulateCustomerPanelFromMembers.Length.ShouldBe(1);
            methodPopulateCustomerPanelFromMembersParametersTypes.Length.ShouldBe(1);
            methodPopulateCustomerPanelFromMembersParametersTypes.Length.ShouldBe(parametersOfPopulateCustomerPanelFromMembers.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var paramMembers = this.CreateType<MemberCollection>();
            var methodPopulateCustomerPanelFromMembersParametersTypes = new Type[] { typeof(MemberCollection) };
            object[] parametersOfPopulateCustomerPanelFromMembers = { paramMembers };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateCustomerPanelFromMembers, parametersOfPopulateCustomerPanelFromMembers, methodPopulateCustomerPanelFromMembersParametersTypes);

            // Assert
            parametersOfPopulateCustomerPanelFromMembers.ShouldNotBeNull();
            parametersOfPopulateCustomerPanelFromMembers.Length.ShouldBe(1);
            methodPopulateCustomerPanelFromMembersParametersTypes.Length.ShouldBe(1);
            methodPopulateCustomerPanelFromMembersParametersTypes.Length.ShouldBe(parametersOfPopulateCustomerPanelFromMembers.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerPanelFromMembers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var methodPopulateCustomerPanelFromMembersParametersTypes = new Type[] { typeof(MemberCollection) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateCustomerPanelFromMembers, methodPopulateCustomerPanelFromMembersParametersTypes);

            // Assert
            methodPopulateCustomerPanelFromMembersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerPanelFromMembers) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerPanelFromMembers_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerPanelFromMembers);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerPanelFromMembers, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_addDivider_Method_Call_Internally(Type[] types)
        {
            var methodaddDividerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddDivider, methodaddDividerParametersTypes);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var text = this.CreateType<string>();
            var methodaddDividerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfaddDivider = { text };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodaddDivider, methodaddDividerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Label>(_onyxInfoPanelInstanceFixture, parametersOfaddDivider);
            var result2 = this.GetResultOfMethod<Label>(MethodaddDivider, parametersOfaddDivider, methodaddDividerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfaddDivider.ShouldNotBeNull();
            parametersOfaddDivider.Length.ShouldBe(1);
            methodaddDividerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var text = this.CreateType<string>();
            var methodaddDividerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfaddDivider = { text };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Label>(MethodaddDivider, parametersOfaddDivider, methodaddDividerParametersTypes);

            // Assert
            parametersOfaddDivider.ShouldNotBeNull();
            parametersOfaddDivider.Length.ShouldBe(1);
            methodaddDividerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var methodaddDividerParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodaddDivider, methodaddDividerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodaddDividerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var methodaddDividerParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddDivider, methodaddDividerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodaddDividerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var currentMethodInfo = this.GetMethodInfo(MethodaddDivider, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (addDivider) (Return Type : Label) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_addDivider_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDivider);
            var currentMethodInfo = this.GetMethodInfo(MethodaddDivider, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateControlFromOutlookContact) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_PopulateControlFromOutlookContact_Method_Call_Internally(Type[] types)
        {
            var methodPopulateControlFromOutlookContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateControlFromOutlookContact, methodPopulateControlFromOutlookContactParametersTypes);
        }

        #endregion
        
        #region Method Call : (PopulateControlFromOutlookContact) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControlFromOutlookContact_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControlFromOutlookContact);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControlFromOutlookContact, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (PopulateControlFromOutlookContact) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateControlFromOutlookContact_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControlFromOutlookContact);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControlFromOutlookContact, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_Internally(Type[] types)
        {
            var methodPopulateCustomerInfoPanelFromIndividualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateCustomerInfoPanelFromIndividuals, methodPopulateCustomerInfoPanelFromIndividualsParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var results = this.CreateType<List<OnyxObject>>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.PopulateCustomerInfoPanelFromIndividuals(results);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var results = this.CreateType<List<OnyxObject>>();
            var methodPopulateCustomerInfoPanelFromIndividualsParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfPopulateCustomerInfoPanelFromIndividuals = { results };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerInfoPanelFromIndividuals, methodPopulateCustomerInfoPanelFromIndividualsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfPopulateCustomerInfoPanelFromIndividuals);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateCustomerInfoPanelFromIndividuals.ShouldNotBeNull();
            parametersOfPopulateCustomerInfoPanelFromIndividuals.Length.ShouldBe(1);
            methodPopulateCustomerInfoPanelFromIndividualsParametersTypes.Length.ShouldBe(1);
            methodPopulateCustomerInfoPanelFromIndividualsParametersTypes.Length.ShouldBe(parametersOfPopulateCustomerInfoPanelFromIndividuals.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var results = this.CreateType<List<OnyxObject>>();
            var methodPopulateCustomerInfoPanelFromIndividualsParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfPopulateCustomerInfoPanelFromIndividuals = { results };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateCustomerInfoPanelFromIndividuals, parametersOfPopulateCustomerInfoPanelFromIndividuals, methodPopulateCustomerInfoPanelFromIndividualsParametersTypes);

            // Assert
            parametersOfPopulateCustomerInfoPanelFromIndividuals.ShouldNotBeNull();
            parametersOfPopulateCustomerInfoPanelFromIndividuals.Length.ShouldBe(1);
            methodPopulateCustomerInfoPanelFromIndividualsParametersTypes.Length.ShouldBe(1);
            methodPopulateCustomerInfoPanelFromIndividualsParametersTypes.Length.ShouldBe(parametersOfPopulateCustomerInfoPanelFromIndividuals.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerInfoPanelFromIndividuals, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var methodPopulateCustomerInfoPanelFromIndividualsParametersTypes = new Type[] { typeof(List<OnyxObject>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateCustomerInfoPanelFromIndividuals, methodPopulateCustomerInfoPanelFromIndividualsParametersTypes);

            // Assert
            methodPopulateCustomerInfoPanelFromIndividualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateCustomerInfoPanelFromIndividuals) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateCustomerInfoPanelFromIndividuals_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateCustomerInfoPanelFromIndividuals);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateCustomerInfoPanelFromIndividuals, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_MultiSelect_Method_Call_Internally(Type[] types)
        {
            var methodMultiSelectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMultiSelect, methodMultiSelectParametersTypes);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var selObjs = this.CreateType<List<Object>>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.MultiSelect(selObjs);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var selObjs = this.CreateType<List<Object>>();
            var methodMultiSelectParametersTypes = new Type[] { typeof(List<Object>) };
            object[] parametersOfMultiSelect = { selObjs };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMultiSelect, methodMultiSelectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfMultiSelect);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMultiSelect.ShouldNotBeNull();
            parametersOfMultiSelect.Length.ShouldBe(1);
            methodMultiSelectParametersTypes.Length.ShouldBe(1);
            methodMultiSelectParametersTypes.Length.ShouldBe(parametersOfMultiSelect.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var selObjs = this.CreateType<List<Object>>();
            var methodMultiSelectParametersTypes = new Type[] { typeof(List<Object>) };
            object[] parametersOfMultiSelect = { selObjs };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMultiSelect, parametersOfMultiSelect, methodMultiSelectParametersTypes);

            // Assert
            parametersOfMultiSelect.ShouldNotBeNull();
            parametersOfMultiSelect.Length.ShouldBe(1);
            methodMultiSelectParametersTypes.Length.ShouldBe(1);
            methodMultiSelectParametersTypes.Length.ShouldBe(parametersOfMultiSelect.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodMultiSelect, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var methodMultiSelectParametersTypes = new Type[] { typeof(List<Object>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMultiSelect, methodMultiSelectParametersTypes);

            // Assert
            methodMultiSelectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MultiSelect) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_MultiSelect_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMultiSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodMultiSelect, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_Internally(Type[] types)
        {
            var methodrefreshPanelWithMembersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodrefreshPanelWithMembers, methodrefreshPanelWithMembersParametersTypes);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrefreshPanelWithMembers);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodrefreshPanelWithMembersParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfrefreshPanelWithMembers = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodrefreshPanelWithMembers, methodrefreshPanelWithMembersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfrefreshPanelWithMembers);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfrefreshPanelWithMembers.ShouldNotBeNull();
            parametersOfrefreshPanelWithMembers.Length.ShouldBe(2);
            methodrefreshPanelWithMembersParametersTypes.Length.ShouldBe(2);
            methodrefreshPanelWithMembersParametersTypes.Length.ShouldBe(parametersOfrefreshPanelWithMembers.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrefreshPanelWithMembers);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodrefreshPanelWithMembersParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfrefreshPanelWithMembers = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodrefreshPanelWithMembers, parametersOfrefreshPanelWithMembers, methodrefreshPanelWithMembersParametersTypes);

            // Assert
            parametersOfrefreshPanelWithMembers.ShouldNotBeNull();
            parametersOfrefreshPanelWithMembers.Length.ShouldBe(2);
            methodrefreshPanelWithMembersParametersTypes.Length.ShouldBe(2);
            methodrefreshPanelWithMembersParametersTypes.Length.ShouldBe(parametersOfrefreshPanelWithMembers.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrefreshPanelWithMembers);
            var currentMethodInfo = this.GetMethodInfo(MethodrefreshPanelWithMembers, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrefreshPanelWithMembers);
            var methodrefreshPanelWithMembersParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodrefreshPanelWithMembers, methodrefreshPanelWithMembersParametersTypes);

            // Assert
            methodrefreshPanelWithMembersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (refreshPanelWithMembers) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_refreshPanelWithMembers_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodrefreshPanelWithMembers);
            var currentMethodInfo = this.GetMethodInfo(MethodrefreshPanelWithMembers, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodtrackInOnyxBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtrackInOnyxBtn_Click, methodtrackInOnyxBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtrackInOnyxBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtrackInOnyxBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftrackInOnyxBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtrackInOnyxBtn_Click, methodtrackInOnyxBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOftrackInOnyxBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftrackInOnyxBtn_Click.ShouldNotBeNull();
            parametersOftrackInOnyxBtn_Click.Length.ShouldBe(2);
            methodtrackInOnyxBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodtrackInOnyxBtn_ClickParametersTypes.Length.ShouldBe(parametersOftrackInOnyxBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtrackInOnyxBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtrackInOnyxBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftrackInOnyxBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtrackInOnyxBtn_Click, parametersOftrackInOnyxBtn_Click, methodtrackInOnyxBtn_ClickParametersTypes);

            // Assert
            parametersOftrackInOnyxBtn_Click.ShouldNotBeNull();
            parametersOftrackInOnyxBtn_Click.Length.ShouldBe(2);
            methodtrackInOnyxBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodtrackInOnyxBtn_ClickParametersTypes.Length.ShouldBe(parametersOftrackInOnyxBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtrackInOnyxBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtrackInOnyxBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtrackInOnyxBtn_Click);
            var methodtrackInOnyxBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtrackInOnyxBtn_Click, methodtrackInOnyxBtn_ClickParametersTypes);

            // Assert
            methodtrackInOnyxBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (trackInOnyxBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_trackInOnyxBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtrackInOnyxBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtrackInOnyxBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodresetBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodresetBtn_Click, methodresetBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodresetBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfresetBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodresetBtn_Click, methodresetBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfresetBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfresetBtn_Click.ShouldNotBeNull();
            parametersOfresetBtn_Click.Length.ShouldBe(2);
            methodresetBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodresetBtn_ClickParametersTypes.Length.ShouldBe(parametersOfresetBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodresetBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfresetBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodresetBtn_Click, parametersOfresetBtn_Click, methodresetBtn_ClickParametersTypes);

            // Assert
            parametersOfresetBtn_Click.ShouldNotBeNull();
            parametersOfresetBtn_Click.Length.ShouldBe(2);
            methodresetBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodresetBtn_ClickParametersTypes.Length.ShouldBe(parametersOfresetBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodresetBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetBtn_Click);
            var methodresetBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodresetBtn_Click, methodresetBtn_ClickParametersTypes);

            // Assert
            methodresetBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_resetBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodresetBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodbulkInsertBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbulkInsertBtn_Click, methodbulkInsertBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbulkInsertBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbulkInsertBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertBtn_Click, methodbulkInsertBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfbulkInsertBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbulkInsertBtn_Click.ShouldNotBeNull();
            parametersOfbulkInsertBtn_Click.Length.ShouldBe(2);
            methodbulkInsertBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodbulkInsertBtn_ClickParametersTypes.Length.ShouldBe(parametersOfbulkInsertBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbulkInsertBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbulkInsertBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbulkInsertBtn_Click, parametersOfbulkInsertBtn_Click, methodbulkInsertBtn_ClickParametersTypes);

            // Assert
            parametersOfbulkInsertBtn_Click.ShouldNotBeNull();
            parametersOfbulkInsertBtn_Click.Length.ShouldBe(2);
            methodbulkInsertBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodbulkInsertBtn_ClickParametersTypes.Length.ShouldBe(parametersOfbulkInsertBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertBtn_Click);
            var methodbulkInsertBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbulkInsertBtn_Click, methodbulkInsertBtn_ClickParametersTypes);

            // Assert
            methodbulkInsertBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_bulkInsertBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_Internally(Type[] types)
        {
            var methodPopulateItemSelectorControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateItemSelectorControl, methodPopulateItemSelectorControlParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var clearNotify = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.PopulateItemSelectorControl(clearNotify);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var clearNotify = this.CreateType<bool>();
            var methodPopulateItemSelectorControlParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfPopulateItemSelectorControl = { clearNotify };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateItemSelectorControl, methodPopulateItemSelectorControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfPopulateItemSelectorControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateItemSelectorControl.ShouldNotBeNull();
            parametersOfPopulateItemSelectorControl.Length.ShouldBe(1);
            methodPopulateItemSelectorControlParametersTypes.Length.ShouldBe(1);
            methodPopulateItemSelectorControlParametersTypes.Length.ShouldBe(parametersOfPopulateItemSelectorControl.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var clearNotify = this.CreateType<bool>();
            var methodPopulateItemSelectorControlParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfPopulateItemSelectorControl = { clearNotify };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateItemSelectorControl, parametersOfPopulateItemSelectorControl, methodPopulateItemSelectorControlParametersTypes);

            // Assert
            parametersOfPopulateItemSelectorControl.ShouldNotBeNull();
            parametersOfPopulateItemSelectorControl.Length.ShouldBe(1);
            methodPopulateItemSelectorControlParametersTypes.Length.ShouldBe(1);
            methodPopulateItemSelectorControlParametersTypes.Length.ShouldBe(parametersOfPopulateItemSelectorControl.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateItemSelectorControl, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var methodPopulateItemSelectorControlParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateItemSelectorControl, methodPopulateItemSelectorControlParametersTypes);

            // Assert
            methodPopulateItemSelectorControlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateItemSelectorControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_PopulateItemSelectorControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateItemSelectorControl);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateItemSelectorControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodpickContactsBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpickContactsBtn_Click, methodpickContactsBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpickContactsBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodpickContactsBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfpickContactsBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpickContactsBtn_Click, methodpickContactsBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfpickContactsBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpickContactsBtn_Click.ShouldNotBeNull();
            parametersOfpickContactsBtn_Click.Length.ShouldBe(2);
            methodpickContactsBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodpickContactsBtn_ClickParametersTypes.Length.ShouldBe(parametersOfpickContactsBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpickContactsBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodpickContactsBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfpickContactsBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpickContactsBtn_Click, parametersOfpickContactsBtn_Click, methodpickContactsBtn_ClickParametersTypes);

            // Assert
            parametersOfpickContactsBtn_Click.ShouldNotBeNull();
            parametersOfpickContactsBtn_Click.Length.ShouldBe(2);
            methodpickContactsBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodpickContactsBtn_ClickParametersTypes.Length.ShouldBe(parametersOfpickContactsBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpickContactsBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodpickContactsBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpickContactsBtn_Click);
            var methodpickContactsBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpickContactsBtn_Click, methodpickContactsBtn_ClickParametersTypes);

            // Assert
            methodpickContactsBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (pickContactsBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_pickContactsBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpickContactsBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodpickContactsBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_Internally(Type[] types)
        {
            var methodResetTableLayoutPanelsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxInfoPanelInstance.ResetTableLayoutPanels(bVisible);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfResetTableLayoutPanels);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetTableLayoutPanels.ShouldNotBeNull();
            parametersOfResetTableLayoutPanels.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(parametersOfResetTableLayoutPanels.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetTableLayoutPanels, parametersOfResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);

            // Assert
            parametersOfResetTableLayoutPanels.ShouldNotBeNull();
            parametersOfResetTableLayoutPanels.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(parametersOfResetTableLayoutPanels.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);

            // Assert
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_ResetTableLayoutPanels_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_Internally(Type[] types)
        {
            var methodonyxInfoPanel_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodonyxInfoPanel_Load, methodonyxInfoPanel_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodonyxInfoPanel_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodonyxInfoPanel_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfonyxInfoPanel_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodonyxInfoPanel_Load, methodonyxInfoPanel_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxInfoPanelInstanceFixture, parametersOfonyxInfoPanel_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfonyxInfoPanel_Load.ShouldNotBeNull();
            parametersOfonyxInfoPanel_Load.Length.ShouldBe(2);
            methodonyxInfoPanel_LoadParametersTypes.Length.ShouldBe(2);
            methodonyxInfoPanel_LoadParametersTypes.Length.ShouldBe(parametersOfonyxInfoPanel_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodonyxInfoPanel_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodonyxInfoPanel_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfonyxInfoPanel_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodonyxInfoPanel_Load, parametersOfonyxInfoPanel_Load, methodonyxInfoPanel_LoadParametersTypes);

            // Assert
            parametersOfonyxInfoPanel_Load.ShouldNotBeNull();
            parametersOfonyxInfoPanel_Load.Length.ShouldBe(2);
            methodonyxInfoPanel_LoadParametersTypes.Length.ShouldBe(2);
            methodonyxInfoPanel_LoadParametersTypes.Length.ShouldBe(parametersOfonyxInfoPanel_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodonyxInfoPanel_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodonyxInfoPanel_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodonyxInfoPanel_Load);
            var methodonyxInfoPanel_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodonyxInfoPanel_Load, methodonyxInfoPanel_LoadParametersTypes);

            // Assert
            methodonyxInfoPanel_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (onyxInfoPanel_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxInfoPanel_onyxInfoPanel_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodonyxInfoPanel_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodonyxInfoPanel_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}