using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Microsoft.Office.Tools;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ThisAddIn" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ThisAddInTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ThisAddIn" />)
        /// </summary>
        public ThisAddInTest() : base(typeof(ThisAddIn))
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

        #region General Initializer : Class (ThisAddIn) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _thisAddInInstanceType;
        private ThisAddIn _thisAddInInstance;
        private ThisAddIn _thisAddInInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ThisAddIn" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _thisAddInInstanceType = typeof(ThisAddIn);
            _thisAddInInstanceFixture = this.Create<ThisAddIn>(false);
            _thisAddInInstance = _thisAddInInstanceFixture ?? this.Create<ThisAddIn>(true);
            CurrentInstance = _thisAddInInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Initializer

        #region Properties

        private const string PropertyexplorerTaskPane = "explorerTaskPane";
        private const string PropertyInspectorWrappers = "InspectorWrappers";
        private const string PropertyContactFolders = "ContactFolders";
        private const string PropertyCurrentExplorer = "CurrentExplorer";
        private const string PropertyContactSyncAccess = "ContactSyncAccess";

        #endregion

        #region Methods

        private const string MethodsetActiveInfoPanel = "setActiveInfoPanel";
        private const string MethodresetActiveInfoPanel = "resetActiveInfoPanel";
        private const string MethodinvalidateRibbon = "invalidateRibbon";
        private const string Methodcontact_BeforeDelete = "contact_BeforeDelete";
        private const string MethodthisAddIn_Startup = "thisAddIn_Startup";
        private const string MethodcontactFolderAdded = "contactFolderAdded";
        private const string MethodcontactItemAdded = "contactItemAdded";
        private const string MethodcontactItemChanged = "contactItemChanged";
        private const string MethodSystemEvents_TimeChanged = "SystemEvents_TimeChanged";
        private const string MethodUpdateUserPrefDupes = "UpdateUserPrefDupes";
        private const string MethodRefreshAllOpenPanels = "RefreshAllOpenPanels";
        private const string Methodexplorers_NewExplorer = "explorers_NewExplorer";
        private const string MethodInitializeAddin = "InitializeAddin";
        private const string MethodinitAttachments = "initAttachments";
        private const string MethodloadCountries = "loadCountries";
        private const string MethodloadListConfig = "loadListConfig";
        private const string MethodinitContactSync = "initContactSync";
        private const string MethodGetFolder = "GetFolder";
        private const string MethodGetFolders = "GetFolders";
        private const string MethodthisAddIn_Shutdown = "thisAddIn_Shutdown";
        private const string MethodResetIgnoreExplorerEvent = "ResetIgnoreExplorerEvent";
        private const string MethodResetPreviousItemId = "ResetPreviousItemId";
        private const string MethodGetActiveTaskPane = "GetActiveTaskPane";
        private const string MethodGetActiveInfoPanel = "GetActiveInfoPanel";
        private const string MethodAddToPostSendActionList = "AddToPostSendActionList";
        private const string MethodGetPostActionOnyxObjectList = "GetPostActionOnyxObjectList";
        private const string MethodRemoveAllPostActionsForItem = "RemoveAllPostActionsForItem";
        private const string MethodRemoveFromPostSendActionList = "RemoveFromPostSendActionList";
        private const string MethodactiveInlineClose = "activeInlineClose";
        private const string MethodactiveInlineOpen = "activeInlineOpen";
        private const string MethodoutFolderItemAdded = "outFolderItemAdded";
        private const string MethodinFolderItemAdded = "inFolderItemAdded";
        private const string MethodpostActionWorker = "postActionWorker";
        private const string MethodstartSubWorker = "startSubWorker";
        private const string MethodInspectors_NewInspector = "Inspectors_NewInspector";
        private const string MethodcurrentExplorer_Event = "currentExplorer_Event";
        private const string MethodaddCustomTaskPane = "addCustomTaskPane";
        private const string MethodMyCustomTaskPane_VisibleChanged = "MyCustomTaskPane_VisibleChanged";
        private const string MethodShowFolderInfo = "ShowFolderInfo";
        private const string MethodCreateRibbonExtensibilityObject = "CreateRibbonExtensibilityObject";
        private const string MethodInternalStartup = "InternalStartup";

        #endregion

        #region Fields

        private const string FieldinspectorWrappersValue = "inspectorWrappersValue";
        private const string Fieldexplorers = "explorers";
        private const string Fieldinspectors = "inspectors";
        private const string FieldonyxInfoPanel = "onyxInfoPanel";
        private const string FieldmyCustomTaskPane = "myCustomTaskPane";
        private const string FieldcurrentExplorer = "currentExplorer";
        private const string FieldprevItemId = "prevItemId";
        private const string FieldinboxFolder = "inboxFolder";
        private const string FieldcontactsFolder = "contactsFolder";
        private const string FieldcontactFolders = "contactFolders";
        private const string FieldcontactFolderFolders = "contactFolderFolders";
        private const string FieldcontactFolderItems = "contactFolderItems";
        private const string FieldinBoxItems = "inBoxItems";
        private const string FieldsentFolder = "sentFolder";
        private const string FieldsentItems = "sentItems";
        private const string FieldactivePanel = "activePanel";
        private const string FieldfollowUnsentEmailList = "followUnsentEmailList";
        private const string FieldmapiFolders = "mapiFolders";
        private const string FieldfoldersItems = "foldersItems";
        private const string FieldignoreExplorerEvent = "ignoreExplorerEvent";
        private const string FieldinlineMailWrapper = "inlineMailWrapper";
        private const string FieldoverRideLoad = "overRideLoad";
        private const string Fieldribbon = "ribbon";
        private const string FieldbInspectorPanelVisible = "bInspectorPanelVisible";
        private const string FieldcontactSyncAccess = "contactSyncAccess";
        private const string FieldNewContactIds = "NewContactIds";
        private const string FieldDuplicateIndividuals = "DuplicateIndividuals";
        private const string Fieldfolders = "folders";
        private const string FielddictListConfigs = "dictListConfigs";
        private const string FielddictMenuActions = "dictMenuActions";
        private const string FieldisFirstItemLoad = "isFirstItemLoad";
        private const string FieldpostSendLockObject = "postSendLockObject";
        private const string FieldsubscriptionLockObject = "subscriptionLockObject";
        private const string FieldpostSendActionList = "postSendActionList";

        #endregion

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddIn_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddIn_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddIn_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ThisAddIn)

        #region General Initializer : Class (ThisAddIn) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodsetActiveInfoPanel, 0)]
        [TestCase(MethodresetActiveInfoPanel, 0)]
        [TestCase(MethodinvalidateRibbon, 0)]
        [TestCase(Methodcontact_BeforeDelete, 0)]
        [TestCase(MethodthisAddIn_Startup, 0)]
        [TestCase(MethodcontactFolderAdded, 0)]
        [TestCase(MethodcontactItemAdded, 0)]
        [TestCase(MethodcontactItemChanged, 0)]
        [TestCase(MethodSystemEvents_TimeChanged, 0)]
        [TestCase(MethodUpdateUserPrefDupes, 0)]
        [TestCase(MethodRefreshAllOpenPanels, 0)]
        [TestCase(Methodexplorers_NewExplorer, 0)]
        [TestCase(MethodInitializeAddin, 0)]
        [TestCase(MethodinitAttachments, 0)]
        [TestCase(MethodloadCountries, 0)]
        [TestCase(MethodloadListConfig, 0)]
        [TestCase(MethodinitContactSync, 0)]
        [TestCase(MethodGetFolder, 0)]
        [TestCase(MethodGetFolders, 0)]
        [TestCase(MethodthisAddIn_Shutdown, 0)]
        [TestCase(MethodResetIgnoreExplorerEvent, 0)]
        [TestCase(MethodResetPreviousItemId, 0)]
        [TestCase(MethodGetActiveTaskPane, 0)]
        [TestCase(MethodGetActiveInfoPanel, 0)]
        [TestCase(MethodAddToPostSendActionList, 0)]
        [TestCase(MethodGetPostActionOnyxObjectList, 0)]
        [TestCase(MethodRemoveAllPostActionsForItem, 0)]
        [TestCase(MethodRemoveFromPostSendActionList, 0)]
        [TestCase(MethodactiveInlineOpen, 0)]
        [TestCase(MethodoutFolderItemAdded, 0)]
        [TestCase(MethodinFolderItemAdded, 0)]
        [TestCase(MethodpostActionWorker, 0)]
        [TestCase(MethodstartSubWorker, 0)]
        [TestCase(MethodInspectors_NewInspector, 0)]
        [TestCase(MethodcurrentExplorer_Event, 0)]
        [TestCase(MethodaddCustomTaskPane, 0)]
        [TestCase(MethodMyCustomTaskPane_VisibleChanged, 0)]
        [TestCase(MethodShowFolderInfo, 0)]
        [TestCase(MethodCreateRibbonExtensibilityObject, 0)]
        [TestCase(MethodInternalStartup, 0)]
        public void AUT_ThisAddIn_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ThisAddIn) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyexplorerTaskPane)]
        [TestCase(PropertyInspectorWrappers)]
        [TestCase(PropertyContactFolders)]
        [TestCase(PropertyCurrentExplorer)]
        [TestCase(PropertyContactSyncAccess)]
        [Category("AUT Property")]
        public void AUT_ThisAddIn_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ThisAddIn) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldinspectorWrappersValue)]
        [TestCase(Fieldexplorers)]
        [TestCase(Fieldinspectors)]
        [TestCase(FieldonyxInfoPanel)]
        [TestCase(FieldmyCustomTaskPane)]
        [TestCase(FieldcurrentExplorer)]
        [TestCase(FieldprevItemId)]
        [TestCase(FieldinboxFolder)]
        [TestCase(FieldcontactsFolder)]
        [TestCase(FieldcontactFolders)]
        [TestCase(FieldcontactFolderFolders)]
        [TestCase(FieldcontactFolderItems)]
        [TestCase(FieldinBoxItems)]
        [TestCase(FieldsentFolder)]
        [TestCase(FieldsentItems)]
        [TestCase(FieldactivePanel)]
        [TestCase(FieldfollowUnsentEmailList)]
        [TestCase(FieldmapiFolders)]
        [TestCase(FieldfoldersItems)]
        [TestCase(FieldignoreExplorerEvent)]
        [TestCase(FieldinlineMailWrapper)]
        [TestCase(FieldoverRideLoad)]
        [TestCase(Fieldribbon)]
        [TestCase(FieldbInspectorPanelVisible)]
        [TestCase(FieldcontactSyncAccess)]
        [TestCase(FieldNewContactIds)]
        [TestCase(FieldDuplicateIndividuals)]
        [TestCase(Fieldfolders)]
        [TestCase(FielddictListConfigs)]
        [TestCase(FielddictMenuActions)]
        [TestCase(FieldisFirstItemLoad)]
        [TestCase(FieldpostSendLockObject)]
        [TestCase(FieldsubscriptionLockObject)]
        [TestCase(FieldpostSendActionList)]
        [Category("AUT Fields")]
        public void AUT_ThisAddIn_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ThisAddIn) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThisAddIn_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _thisAddInInstance.ShouldBeAssignableTo<ThisAddIn>();
            _thisAddInInstanceFixture.ShouldBeAssignableTo<ThisAddIn>();
            CurrentInstance.ShouldBeAssignableTo<ThisAddIn>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ThisAddIn) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyexplorerTaskPane)]
        [TestCase(PropertyInspectorWrappers)]
        [TestCase(PropertyContactFolders)]
        [TestCase(PropertyCurrentExplorer)]
        [TestCase(PropertyContactSyncAccess)]
        public void AUT_ThisAddIn_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ThisAddIn) => Property (ContactFolders) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_Public_Class_ContactFolders_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactFolders);
            var propertyInfo = this.GetPropertyInfo(PropertyContactFolders);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (ContactSyncAccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_Public_Class_ContactSyncAccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactSyncAccess);
            var propertyInfo = this.GetPropertyInfo(PropertyContactSyncAccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (CurrentExplorer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_CurrentExplorer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentExplorer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentExplorer);
            Action currentAction = () => propertyInfo.SetValue(_thisAddInInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (CurrentExplorer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_Public_Class_CurrentExplorer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentExplorer);
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentExplorer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (explorerTaskPane) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_explorerTaskPane_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyexplorerTaskPane);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyexplorerTaskPane);
            Action currentAction = () => propertyInfo.SetValue(_thisAddInInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (explorerTaskPane) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_Public_Class_explorerTaskPane_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyexplorerTaskPane);
            var propertyInfo = this.GetPropertyInfo(PropertyexplorerTaskPane);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ThisAddIn) => Property (InspectorWrappers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ThisAddIn_Public_Class_InspectorWrappers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInspectorWrappers);
            var propertyInfo = this.GetPropertyInfo(PropertyInspectorWrappers);

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

        #region Method Call : (setActiveInfoPanel) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var panel = this.CreateType<OnyxInfoPanel>();

            // Act
            Action executeAction = () => _thisAddInInstance.setActiveInfoPanel(panel);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (setActiveInfoPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var panel = this.CreateType<OnyxInfoPanel>();
            var methodsetActiveInfoPanelParametersTypes = new Type[] { typeof(OnyxInfoPanel) };
            object[] parametersOfsetActiveInfoPanel = { panel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsetActiveInfoPanel, methodsetActiveInfoPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfsetActiveInfoPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsetActiveInfoPanel.ShouldNotBeNull();
            parametersOfsetActiveInfoPanel.Length.ShouldBe(1);
            methodsetActiveInfoPanelParametersTypes.Length.ShouldBe(1);
            methodsetActiveInfoPanelParametersTypes.Length.ShouldBe(parametersOfsetActiveInfoPanel.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (setActiveInfoPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var panel = this.CreateType<OnyxInfoPanel>();
            var methodsetActiveInfoPanelParametersTypes = new Type[] { typeof(OnyxInfoPanel) };
            object[] parametersOfsetActiveInfoPanel = { panel };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsetActiveInfoPanel, parametersOfsetActiveInfoPanel, methodsetActiveInfoPanelParametersTypes);

            // Assert
            parametersOfsetActiveInfoPanel.ShouldNotBeNull();
            parametersOfsetActiveInfoPanel.Length.ShouldBe(1);
            methodsetActiveInfoPanelParametersTypes.Length.ShouldBe(1);
            methodsetActiveInfoPanelParametersTypes.Length.ShouldBe(parametersOfsetActiveInfoPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setActiveInfoPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodsetActiveInfoPanel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (setActiveInfoPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var methodsetActiveInfoPanelParametersTypes = new Type[] { typeof(OnyxInfoPanel) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsetActiveInfoPanel, methodsetActiveInfoPanelParametersTypes);

            // Assert
            methodsetActiveInfoPanelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setActiveInfoPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_setActiveInfoPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetActiveInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodsetActiveInfoPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_resetActiveInfoPanel_Method_Call_Internally(Type[] types)
        {
            var methodresetActiveInfoPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodresetActiveInfoPanel, methodresetActiveInfoPanelParametersTypes);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_resetActiveInfoPanel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetActiveInfoPanel);

            // Act
            Action executeAction = () => _thisAddInInstance.resetActiveInfoPanel();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_resetActiveInfoPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetActiveInfoPanel);
            Type [] methodresetActiveInfoPanelParametersTypes = null;
            object[] parametersOfresetActiveInfoPanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodresetActiveInfoPanel, methodresetActiveInfoPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfresetActiveInfoPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfresetActiveInfoPanel.ShouldBeNull();
            methodresetActiveInfoPanelParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_resetActiveInfoPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetActiveInfoPanel);
            Type [] methodresetActiveInfoPanelParametersTypes = null;
            object[] parametersOfresetActiveInfoPanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodresetActiveInfoPanel, parametersOfresetActiveInfoPanel, methodresetActiveInfoPanelParametersTypes);

            // Assert
            parametersOfresetActiveInfoPanel.ShouldBeNull();
            methodresetActiveInfoPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_resetActiveInfoPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetActiveInfoPanel);
            Type [] methodresetActiveInfoPanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodresetActiveInfoPanel, methodresetActiveInfoPanelParametersTypes);

            // Assert
            methodresetActiveInfoPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (resetActiveInfoPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_resetActiveInfoPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodresetActiveInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodresetActiveInfoPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_invalidateRibbon_Method_Call_Internally(Type[] types)
        {
            var methodinvalidateRibbonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinvalidateRibbon, methodinvalidateRibbonParametersTypes);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_invalidateRibbon_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinvalidateRibbon);

            // Act
            Action executeAction = () => _thisAddInInstance.invalidateRibbon();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_invalidateRibbon_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinvalidateRibbon);
            Type [] methodinvalidateRibbonParametersTypes = null;
            object[] parametersOfinvalidateRibbon = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinvalidateRibbon, methodinvalidateRibbonParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfinvalidateRibbon);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinvalidateRibbon.ShouldBeNull();
            methodinvalidateRibbonParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_invalidateRibbon_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinvalidateRibbon);
            Type [] methodinvalidateRibbonParametersTypes = null;
            object[] parametersOfinvalidateRibbon = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinvalidateRibbon, parametersOfinvalidateRibbon, methodinvalidateRibbonParametersTypes);

            // Assert
            parametersOfinvalidateRibbon.ShouldBeNull();
            methodinvalidateRibbonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_invalidateRibbon_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinvalidateRibbon);
            Type [] methodinvalidateRibbonParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinvalidateRibbon, methodinvalidateRibbonParametersTypes);

            // Assert
            methodinvalidateRibbonParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (invalidateRibbon) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_invalidateRibbon_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinvalidateRibbon);
            var currentMethodInfo = this.GetMethodInfo(MethodinvalidateRibbon, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_Internally(Type[] types)
        {
            var methodcontact_BeforeDeleteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(Methodcontact_BeforeDelete, methodcontact_BeforeDeleteParametersTypes);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodcontact_BeforeDelete);
            var Item = this.CreateType<object>();
            var Cancel = this.CreateType<bool>();
            var methodcontact_BeforeDeleteParametersTypes = new Type[] { typeof(object), typeof(bool) };
            object[] parametersOfcontact_BeforeDelete = { Item, Cancel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(Methodcontact_BeforeDelete, methodcontact_BeforeDeleteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfcontact_BeforeDelete);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontact_BeforeDelete.ShouldNotBeNull();
            parametersOfcontact_BeforeDelete.Length.ShouldBe(2);
            methodcontact_BeforeDeleteParametersTypes.Length.ShouldBe(2);
            methodcontact_BeforeDeleteParametersTypes.Length.ShouldBe(parametersOfcontact_BeforeDelete.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodcontact_BeforeDelete);
            var Item = this.CreateType<object>();
            var Cancel = this.CreateType<bool>();
            var methodcontact_BeforeDeleteParametersTypes = new Type[] { typeof(object), typeof(bool) };
            object[] parametersOfcontact_BeforeDelete = { Item, Cancel };

            // Act
            Action currentAction = () => this.InvokeWithTypes(Methodcontact_BeforeDelete, parametersOfcontact_BeforeDelete, methodcontact_BeforeDeleteParametersTypes);

            // Assert
            parametersOfcontact_BeforeDelete.ShouldNotBeNull();
            parametersOfcontact_BeforeDelete.Length.ShouldBe(2);
            methodcontact_BeforeDeleteParametersTypes.Length.ShouldBe(2);
            methodcontact_BeforeDeleteParametersTypes.Length.ShouldBe(parametersOfcontact_BeforeDelete.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodcontact_BeforeDelete);
            var currentMethodInfo = this.GetMethodInfo(Methodcontact_BeforeDelete, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodcontact_BeforeDelete);
            var methodcontact_BeforeDeleteParametersTypes = new Type[] { typeof(object), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(Methodcontact_BeforeDelete, methodcontact_BeforeDeleteParametersTypes);

            // Assert
            methodcontact_BeforeDeleteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contact_BeforeDelete) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contact_BeforeDelete_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodcontact_BeforeDelete);
            var currentMethodInfo = this.GetMethodInfo(Methodcontact_BeforeDelete, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_Internally(Type[] types)
        {
            var methodthisAddIn_StartupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodthisAddIn_Startup, methodthisAddIn_StartupParametersTypes);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Startup);
            var sender = this.CreateType<object>();
            var e = this.CreateType<System.EventArgs>();
            var methodthisAddIn_StartupParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };
            object[] parametersOfthisAddIn_Startup = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Startup, methodthisAddIn_StartupParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfthisAddIn_Startup);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfthisAddIn_Startup.ShouldNotBeNull();
            parametersOfthisAddIn_Startup.Length.ShouldBe(2);
            methodthisAddIn_StartupParametersTypes.Length.ShouldBe(2);
            methodthisAddIn_StartupParametersTypes.Length.ShouldBe(parametersOfthisAddIn_Startup.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Startup);
            var sender = this.CreateType<object>();
            var e = this.CreateType<System.EventArgs>();
            var methodthisAddIn_StartupParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };
            object[] parametersOfthisAddIn_Startup = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodthisAddIn_Startup, parametersOfthisAddIn_Startup, methodthisAddIn_StartupParametersTypes);

            // Assert
            parametersOfthisAddIn_Startup.ShouldNotBeNull();
            parametersOfthisAddIn_Startup.Length.ShouldBe(2);
            methodthisAddIn_StartupParametersTypes.Length.ShouldBe(2);
            methodthisAddIn_StartupParametersTypes.Length.ShouldBe(parametersOfthisAddIn_Startup.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Startup);
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Startup, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Startup);
            var methodthisAddIn_StartupParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodthisAddIn_Startup, methodthisAddIn_StartupParametersTypes);

            // Assert
            methodthisAddIn_StartupParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Startup) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Startup_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Startup);
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Startup, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_contactFolderAdded_Method_Call_Internally(Type[] types)
        {
            var methodcontactFolderAddedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactFolderAdded, methodcontactFolderAddedParametersTypes);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactFolderAdded_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactFolderAdded);
            var folderAdded = this.CreateType<Outlook.MAPIFolder>();
            var methodcontactFolderAddedParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };
            object[] parametersOfcontactFolderAdded = { folderAdded };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactFolderAdded, methodcontactFolderAddedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfcontactFolderAdded);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactFolderAdded.ShouldNotBeNull();
            parametersOfcontactFolderAdded.Length.ShouldBe(1);
            methodcontactFolderAddedParametersTypes.Length.ShouldBe(1);
            methodcontactFolderAddedParametersTypes.Length.ShouldBe(parametersOfcontactFolderAdded.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactFolderAdded_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactFolderAdded);
            var folderAdded = this.CreateType<Outlook.MAPIFolder>();
            var methodcontactFolderAddedParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };
            object[] parametersOfcontactFolderAdded = { folderAdded };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactFolderAdded, parametersOfcontactFolderAdded, methodcontactFolderAddedParametersTypes);

            // Assert
            parametersOfcontactFolderAdded.ShouldNotBeNull();
            parametersOfcontactFolderAdded.Length.ShouldBe(1);
            methodcontactFolderAddedParametersTypes.Length.ShouldBe(1);
            methodcontactFolderAddedParametersTypes.Length.ShouldBe(parametersOfcontactFolderAdded.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactFolderAdded_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactFolderAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactFolderAdded, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactFolderAdded_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactFolderAdded);
            var methodcontactFolderAddedParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactFolderAdded, methodcontactFolderAddedParametersTypes);

            // Assert
            methodcontactFolderAddedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactFolderAdded) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactFolderAdded_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactFolderAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactFolderAdded, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_contactItemAdded_Method_Call_Internally(Type[] types)
        {
            var methodcontactItemAddedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactItemAdded, methodcontactItemAddedParametersTypes);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemAdded_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemAdded);
            var Item = this.CreateType<object>();
            var methodcontactItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfcontactItemAdded = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemAdded, methodcontactItemAddedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfcontactItemAdded);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactItemAdded.ShouldNotBeNull();
            parametersOfcontactItemAdded.Length.ShouldBe(1);
            methodcontactItemAddedParametersTypes.Length.ShouldBe(1);
            methodcontactItemAddedParametersTypes.Length.ShouldBe(parametersOfcontactItemAdded.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemAdded_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemAdded);
            var Item = this.CreateType<object>();
            var methodcontactItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfcontactItemAdded = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactItemAdded, parametersOfcontactItemAdded, methodcontactItemAddedParametersTypes);

            // Assert
            parametersOfcontactItemAdded.ShouldNotBeNull();
            parametersOfcontactItemAdded.Length.ShouldBe(1);
            methodcontactItemAddedParametersTypes.Length.ShouldBe(1);
            methodcontactItemAddedParametersTypes.Length.ShouldBe(parametersOfcontactItemAdded.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemAdded_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemAdded, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemAdded_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemAdded);
            var methodcontactItemAddedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactItemAdded, methodcontactItemAddedParametersTypes);

            // Assert
            methodcontactItemAddedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemAdded) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemAdded_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemAdded, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_contactItemChanged_Method_Call_Internally(Type[] types)
        {
            var methodcontactItemChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactItemChanged, methodcontactItemChangedParametersTypes);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemChanged);
            var Item = this.CreateType<object>();
            var methodcontactItemChangedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfcontactItemChanged = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemChanged, methodcontactItemChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfcontactItemChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactItemChanged.ShouldNotBeNull();
            parametersOfcontactItemChanged.Length.ShouldBe(1);
            methodcontactItemChangedParametersTypes.Length.ShouldBe(1);
            methodcontactItemChangedParametersTypes.Length.ShouldBe(parametersOfcontactItemChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemChanged);
            var Item = this.CreateType<object>();
            var methodcontactItemChangedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfcontactItemChanged = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactItemChanged, parametersOfcontactItemChanged, methodcontactItemChangedParametersTypes);

            // Assert
            parametersOfcontactItemChanged.ShouldNotBeNull();
            parametersOfcontactItemChanged.Length.ShouldBe(1);
            methodcontactItemChangedParametersTypes.Length.ShouldBe(1);
            methodcontactItemChangedParametersTypes.Length.ShouldBe(parametersOfcontactItemChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemChanged, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemChanged);
            var methodcontactItemChangedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactItemChanged, methodcontactItemChangedParametersTypes);

            // Assert
            methodcontactItemChangedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactItemChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_contactItemChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactItemChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactItemChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_Internally(Type[] types)
        {
            var methodSystemEvents_TimeChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSystemEvents_TimeChanged, methodSystemEvents_TimeChangedParametersTypes);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSystemEvents_TimeChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodSystemEvents_TimeChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfSystemEvents_TimeChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSystemEvents_TimeChanged, methodSystemEvents_TimeChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfSystemEvents_TimeChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSystemEvents_TimeChanged.ShouldNotBeNull();
            parametersOfSystemEvents_TimeChanged.Length.ShouldBe(2);
            methodSystemEvents_TimeChangedParametersTypes.Length.ShouldBe(2);
            methodSystemEvents_TimeChangedParametersTypes.Length.ShouldBe(parametersOfSystemEvents_TimeChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSystemEvents_TimeChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodSystemEvents_TimeChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfSystemEvents_TimeChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSystemEvents_TimeChanged, parametersOfSystemEvents_TimeChanged, methodSystemEvents_TimeChangedParametersTypes);

            // Assert
            parametersOfSystemEvents_TimeChanged.ShouldNotBeNull();
            parametersOfSystemEvents_TimeChanged.Length.ShouldBe(2);
            methodSystemEvents_TimeChangedParametersTypes.Length.ShouldBe(2);
            methodSystemEvents_TimeChangedParametersTypes.Length.ShouldBe(parametersOfSystemEvents_TimeChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSystemEvents_TimeChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodSystemEvents_TimeChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSystemEvents_TimeChanged);
            var methodSystemEvents_TimeChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSystemEvents_TimeChanged, methodSystemEvents_TimeChangedParametersTypes);

            // Assert
            methodSystemEvents_TimeChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SystemEvents_TimeChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_SystemEvents_TimeChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSystemEvents_TimeChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodSystemEvents_TimeChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_Internally(Type[] types)
        {
            var methodUpdateUserPrefDupesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateUserPrefDupes, methodUpdateUserPrefDupesParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var email = this.CreateType<string>();
            var individualId = this.CreateType<string>();

            // Act
            Action executeAction = () => _thisAddInInstance.UpdateUserPrefDupes(email, individualId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var email = this.CreateType<string>();
            var individualId = this.CreateType<string>();
            var methodUpdateUserPrefDupesParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfUpdateUserPrefDupes = { email, individualId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateUserPrefDupes, methodUpdateUserPrefDupesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfUpdateUserPrefDupes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateUserPrefDupes.ShouldNotBeNull();
            parametersOfUpdateUserPrefDupes.Length.ShouldBe(2);
            methodUpdateUserPrefDupesParametersTypes.Length.ShouldBe(2);
            methodUpdateUserPrefDupesParametersTypes.Length.ShouldBe(parametersOfUpdateUserPrefDupes.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var email = this.CreateType<string>();
            var individualId = this.CreateType<string>();
            var methodUpdateUserPrefDupesParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfUpdateUserPrefDupes = { email, individualId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateUserPrefDupes, parametersOfUpdateUserPrefDupes, methodUpdateUserPrefDupesParametersTypes);

            // Assert
            parametersOfUpdateUserPrefDupes.ShouldNotBeNull();
            parametersOfUpdateUserPrefDupes.Length.ShouldBe(2);
            methodUpdateUserPrefDupesParametersTypes.Length.ShouldBe(2);
            methodUpdateUserPrefDupesParametersTypes.Length.ShouldBe(parametersOfUpdateUserPrefDupes.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateUserPrefDupes, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var methodUpdateUserPrefDupesParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateUserPrefDupes, methodUpdateUserPrefDupesParametersTypes);

            // Assert
            methodUpdateUserPrefDupesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateUserPrefDupes) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_UpdateUserPrefDupes_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateUserPrefDupes);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateUserPrefDupes, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_RefreshAllOpenPanels_Method_Call_Internally(Type[] types)
        {
            var methodRefreshAllOpenPanelsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRefreshAllOpenPanels, methodRefreshAllOpenPanelsParametersTypes);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RefreshAllOpenPanels_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRefreshAllOpenPanels);

            // Act
            Action executeAction = () => _thisAddInInstance.RefreshAllOpenPanels();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RefreshAllOpenPanels_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRefreshAllOpenPanels);
            Type [] methodRefreshAllOpenPanelsParametersTypes = null;
            object[] parametersOfRefreshAllOpenPanels = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRefreshAllOpenPanels, methodRefreshAllOpenPanelsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfRefreshAllOpenPanels);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRefreshAllOpenPanels.ShouldBeNull();
            methodRefreshAllOpenPanelsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RefreshAllOpenPanels_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRefreshAllOpenPanels);
            Type [] methodRefreshAllOpenPanelsParametersTypes = null;
            object[] parametersOfRefreshAllOpenPanels = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRefreshAllOpenPanels, parametersOfRefreshAllOpenPanels, methodRefreshAllOpenPanelsParametersTypes);

            // Assert
            parametersOfRefreshAllOpenPanels.ShouldBeNull();
            methodRefreshAllOpenPanelsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RefreshAllOpenPanels_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRefreshAllOpenPanels);
            Type [] methodRefreshAllOpenPanelsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRefreshAllOpenPanels, methodRefreshAllOpenPanelsParametersTypes);

            // Assert
            methodRefreshAllOpenPanelsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RefreshAllOpenPanels) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RefreshAllOpenPanels_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRefreshAllOpenPanels);
            var currentMethodInfo = this.GetMethodInfo(MethodRefreshAllOpenPanels, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_Internally(Type[] types)
        {
            var methodexplorers_NewExplorerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(Methodexplorers_NewExplorer, methodexplorers_NewExplorerParametersTypes);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodexplorers_NewExplorer);
            var Explorer = this.CreateType<Outlook.Explorer>();
            var methodexplorers_NewExplorerParametersTypes = new Type[] { typeof(Outlook.Explorer) };
            object[] parametersOfexplorers_NewExplorer = { Explorer };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(Methodexplorers_NewExplorer, methodexplorers_NewExplorerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfexplorers_NewExplorer);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfexplorers_NewExplorer.ShouldNotBeNull();
            parametersOfexplorers_NewExplorer.Length.ShouldBe(1);
            methodexplorers_NewExplorerParametersTypes.Length.ShouldBe(1);
            methodexplorers_NewExplorerParametersTypes.Length.ShouldBe(parametersOfexplorers_NewExplorer.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodexplorers_NewExplorer);
            var Explorer = this.CreateType<Outlook.Explorer>();
            var methodexplorers_NewExplorerParametersTypes = new Type[] { typeof(Outlook.Explorer) };
            object[] parametersOfexplorers_NewExplorer = { Explorer };

            // Act
            Action currentAction = () => this.InvokeWithTypes(Methodexplorers_NewExplorer, parametersOfexplorers_NewExplorer, methodexplorers_NewExplorerParametersTypes);

            // Assert
            parametersOfexplorers_NewExplorer.ShouldNotBeNull();
            parametersOfexplorers_NewExplorer.Length.ShouldBe(1);
            methodexplorers_NewExplorerParametersTypes.Length.ShouldBe(1);
            methodexplorers_NewExplorerParametersTypes.Length.ShouldBe(parametersOfexplorers_NewExplorer.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodexplorers_NewExplorer);
            var currentMethodInfo = this.GetMethodInfo(Methodexplorers_NewExplorer, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodexplorers_NewExplorer);
            var methodexplorers_NewExplorerParametersTypes = new Type[] { typeof(Outlook.Explorer) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(Methodexplorers_NewExplorer, methodexplorers_NewExplorerParametersTypes);

            // Assert
            methodexplorers_NewExplorerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (explorers_NewExplorer) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_explorers_NewExplorer_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodexplorers_NewExplorer);
            var currentMethodInfo = this.GetMethodInfo(Methodexplorers_NewExplorer, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_InitializeAddin_Method_Call_Internally(Type[] types)
        {
            var methodInitializeAddinParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeAddin, methodInitializeAddinParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InitializeAddin_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeAddin);

            // Act
            Action executeAction = () => _thisAddInInstance.InitializeAddin();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InitializeAddin_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeAddin);
            Type [] methodInitializeAddinParametersTypes = null;
            object[] parametersOfInitializeAddin = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeAddin, methodInitializeAddinParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeAddin);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeAddin.ShouldBeNull();
            methodInitializeAddinParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InitializeAddin_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeAddin);
            Type [] methodInitializeAddinParametersTypes = null;
            object[] parametersOfInitializeAddin = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeAddin, parametersOfInitializeAddin, methodInitializeAddinParametersTypes);

            // Assert
            parametersOfInitializeAddin.ShouldBeNull();
            methodInitializeAddinParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InitializeAddin_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeAddin);
            Type [] methodInitializeAddinParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeAddin, methodInitializeAddinParametersTypes);

            // Assert
            methodInitializeAddinParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeAddin) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InitializeAddin_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeAddin);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeAddin, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAttachments) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_initAttachments_Method_Call_Internally(Type[] types)
        {
            var methodinitAttachmentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinitAttachments, methodinitAttachmentsParametersTypes);
        }

        #endregion

        #region Method Call : (initAttachments) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initAttachments_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAttachments);
            Type [] methodinitAttachmentsParametersTypes = null;
            object[] parametersOfinitAttachments = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitAttachments, methodinitAttachmentsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfinitAttachments);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinitAttachments.ShouldBeNull();
            methodinitAttachmentsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (initAttachments) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initAttachments_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAttachments);
            Type [] methodinitAttachmentsParametersTypes = null;
            object[] parametersOfinitAttachments = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinitAttachments, parametersOfinitAttachments, methodinitAttachmentsParametersTypes);

            // Assert
            parametersOfinitAttachments.ShouldBeNull();
            methodinitAttachmentsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAttachments) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initAttachments_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAttachments);
            Type [] methodinitAttachmentsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinitAttachments, methodinitAttachmentsParametersTypes);

            // Assert
            methodinitAttachmentsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAttachments) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initAttachments_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAttachments);
            var currentMethodInfo = this.GetMethodInfo(MethodinitAttachments, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_loadCountries_Method_Call_Internally(Type[] types)
        {
            var methodloadCountriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodloadCountries, methodloadCountriesParametersTypes);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadCountries_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;
            object[] parametersOfloadCountries = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodloadCountries, methodloadCountriesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfloadCountries);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfloadCountries.ShouldBeNull();
            methodloadCountriesParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadCountries_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;
            object[] parametersOfloadCountries = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodloadCountries, parametersOfloadCountries, methodloadCountriesParametersTypes);

            // Assert
            parametersOfloadCountries.ShouldBeNull();
            methodloadCountriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadCountries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodloadCountries, methodloadCountriesParametersTypes);

            // Assert
            methodloadCountriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadCountries_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodloadCountries, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadListConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_loadListConfig_Method_Call_Internally(Type[] types)
        {
            var methodloadListConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodloadListConfig, methodloadListConfigParametersTypes);
        }

        #endregion

        #region Method Call : (loadListConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadListConfig_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadListConfig);
            Type [] methodloadListConfigParametersTypes = null;
            object[] parametersOfloadListConfig = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodloadListConfig, methodloadListConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfloadListConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfloadListConfig.ShouldBeNull();
            methodloadListConfigParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (loadListConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadListConfig_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadListConfig);
            Type [] methodloadListConfigParametersTypes = null;
            object[] parametersOfloadListConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodloadListConfig, parametersOfloadListConfig, methodloadListConfigParametersTypes);

            // Assert
            parametersOfloadListConfig.ShouldBeNull();
            methodloadListConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadListConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadListConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadListConfig);
            Type [] methodloadListConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodloadListConfig, methodloadListConfigParametersTypes);

            // Assert
            methodloadListConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadListConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_loadListConfig_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadListConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodloadListConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initContactSync) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_initContactSync_Method_Call_Internally(Type[] types)
        {
            var methodinitContactSyncParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinitContactSync, methodinitContactSyncParametersTypes);
        }

        #endregion

        #region Method Call : (initContactSync) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initContactSync_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitContactSync);
            Type [] methodinitContactSyncParametersTypes = null;
            object[] parametersOfinitContactSync = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitContactSync, methodinitContactSyncParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfinitContactSync);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinitContactSync.ShouldBeNull();
            methodinitContactSyncParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (initContactSync) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initContactSync_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitContactSync);
            Type [] methodinitContactSyncParametersTypes = null;
            object[] parametersOfinitContactSync = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinitContactSync, parametersOfinitContactSync, methodinitContactSyncParametersTypes);

            // Assert
            parametersOfinitContactSync.ShouldBeNull();
            methodinitContactSyncParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initContactSync) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initContactSync_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitContactSync);
            Type [] methodinitContactSyncParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinitContactSync, methodinitContactSyncParametersTypes);

            // Assert
            methodinitContactSyncParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initContactSync) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_initContactSync_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitContactSync);
            var currentMethodInfo = this.GetMethodInfo(MethodinitContactSync, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_GetFolder_Method_Call_Internally(Type[] types)
        {
            var methodGetFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFolder, methodGetFolderParametersTypes);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var folderPath = this.CreateType<string>();
            var methodGetFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFolder = { folderPath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolder, methodGetFolderParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Outlook.Folder>(_thisAddInInstanceFixture, parametersOfGetFolder);
            var result2 = this.GetResultOfMethod<Outlook.Folder>(MethodGetFolder, parametersOfGetFolder, methodGetFolderParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetFolder.ShouldNotBeNull();
            parametersOfGetFolder.Length.ShouldBe(1);
            methodGetFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var folderPath = this.CreateType<string>();
            var methodGetFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFolder = { folderPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.Folder>(MethodGetFolder, parametersOfGetFolder, methodGetFolderParametersTypes);

            // Assert
            parametersOfGetFolder.ShouldNotBeNull();
            parametersOfGetFolder.Length.ShouldBe(1);
            methodGetFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var methodGetFolderParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFolder, methodGetFolderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var methodGetFolderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFolder, methodGetFolderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFolderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolder, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFolder) (Return Type : Outlook.Folder) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolder, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_GetFolders_Method_Call_Internally(Type[] types)
        {
            var methodGetFoldersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFolders, methodGetFoldersParametersTypes);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var folder = this.CreateType<Outlook.MAPIFolder>();

            // Act
            Action executeAction = () => _thisAddInInstance.GetFolders(folder);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var folder = this.CreateType<Outlook.MAPIFolder>();
            var methodGetFoldersParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };
            object[] parametersOfGetFolders = { folder };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolders, methodGetFoldersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfGetFolders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFolders.ShouldNotBeNull();
            parametersOfGetFolders.Length.ShouldBe(1);
            methodGetFoldersParametersTypes.Length.ShouldBe(1);
            methodGetFoldersParametersTypes.Length.ShouldBe(parametersOfGetFolders.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var folder = this.CreateType<Outlook.MAPIFolder>();
            var methodGetFoldersParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };
            object[] parametersOfGetFolders = { folder };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetFolders, parametersOfGetFolders, methodGetFoldersParametersTypes);

            // Assert
            parametersOfGetFolders.ShouldNotBeNull();
            parametersOfGetFolders.Length.ShouldBe(1);
            methodGetFoldersParametersTypes.Length.ShouldBe(1);
            methodGetFoldersParametersTypes.Length.ShouldBe(parametersOfGetFolders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolders, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var methodGetFoldersParametersTypes = new Type[] { typeof(Outlook.MAPIFolder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFolders, methodGetFoldersParametersTypes);

            // Assert
            methodGetFoldersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFolders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetFolders_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFolders);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFolders, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_Internally(Type[] types)
        {
            var methodthisAddIn_ShutdownParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodthisAddIn_Shutdown, methodthisAddIn_ShutdownParametersTypes);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Shutdown);
            var sender = this.CreateType<object>();
            var e = this.CreateType<System.EventArgs>();
            var methodthisAddIn_ShutdownParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };
            object[] parametersOfthisAddIn_Shutdown = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Shutdown, methodthisAddIn_ShutdownParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfthisAddIn_Shutdown);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfthisAddIn_Shutdown.ShouldNotBeNull();
            parametersOfthisAddIn_Shutdown.Length.ShouldBe(2);
            methodthisAddIn_ShutdownParametersTypes.Length.ShouldBe(2);
            methodthisAddIn_ShutdownParametersTypes.Length.ShouldBe(parametersOfthisAddIn_Shutdown.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Shutdown);
            var sender = this.CreateType<object>();
            var e = this.CreateType<System.EventArgs>();
            var methodthisAddIn_ShutdownParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };
            object[] parametersOfthisAddIn_Shutdown = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodthisAddIn_Shutdown, parametersOfthisAddIn_Shutdown, methodthisAddIn_ShutdownParametersTypes);

            // Assert
            parametersOfthisAddIn_Shutdown.ShouldNotBeNull();
            parametersOfthisAddIn_Shutdown.Length.ShouldBe(2);
            methodthisAddIn_ShutdownParametersTypes.Length.ShouldBe(2);
            methodthisAddIn_ShutdownParametersTypes.Length.ShouldBe(parametersOfthisAddIn_Shutdown.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Shutdown);
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Shutdown, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Shutdown);
            var methodthisAddIn_ShutdownParametersTypes = new Type[] { typeof(object), typeof(System.EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodthisAddIn_Shutdown, methodthisAddIn_ShutdownParametersTypes);

            // Assert
            methodthisAddIn_ShutdownParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (thisAddIn_Shutdown) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_thisAddIn_Shutdown_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodthisAddIn_Shutdown);
            var currentMethodInfo = this.GetMethodInfo(MethodthisAddIn_Shutdown, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_Call_Internally(Type[] types)
        {
            var methodResetIgnoreExplorerEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetIgnoreExplorerEvent, methodResetIgnoreExplorerEventParametersTypes);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetIgnoreExplorerEvent);

            // Act
            Action executeAction = () => _thisAddInInstance.ResetIgnoreExplorerEvent();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetIgnoreExplorerEvent);
            Type [] methodResetIgnoreExplorerEventParametersTypes = null;
            object[] parametersOfResetIgnoreExplorerEvent = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetIgnoreExplorerEvent, methodResetIgnoreExplorerEventParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfResetIgnoreExplorerEvent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetIgnoreExplorerEvent.ShouldBeNull();
            methodResetIgnoreExplorerEventParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetIgnoreExplorerEvent);
            Type [] methodResetIgnoreExplorerEventParametersTypes = null;
            object[] parametersOfResetIgnoreExplorerEvent = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetIgnoreExplorerEvent, parametersOfResetIgnoreExplorerEvent, methodResetIgnoreExplorerEventParametersTypes);

            // Assert
            parametersOfResetIgnoreExplorerEvent.ShouldBeNull();
            methodResetIgnoreExplorerEventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetIgnoreExplorerEvent);
            Type [] methodResetIgnoreExplorerEventParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetIgnoreExplorerEvent, methodResetIgnoreExplorerEventParametersTypes);

            // Assert
            methodResetIgnoreExplorerEventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetIgnoreExplorerEvent) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetIgnoreExplorerEvent_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetIgnoreExplorerEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodResetIgnoreExplorerEvent, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_ResetPreviousItemId_Method_Call_Internally(Type[] types)
        {
            var methodResetPreviousItemIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetPreviousItemId, methodResetPreviousItemIdParametersTypes);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetPreviousItemId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPreviousItemId);

            // Act
            Action executeAction = () => _thisAddInInstance.ResetPreviousItemId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetPreviousItemId_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPreviousItemId);
            Type [] methodResetPreviousItemIdParametersTypes = null;
            object[] parametersOfResetPreviousItemId = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetPreviousItemId, methodResetPreviousItemIdParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfResetPreviousItemId);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetPreviousItemId.ShouldBeNull();
            methodResetPreviousItemIdParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetPreviousItemId_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPreviousItemId);
            Type [] methodResetPreviousItemIdParametersTypes = null;
            object[] parametersOfResetPreviousItemId = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetPreviousItemId, parametersOfResetPreviousItemId, methodResetPreviousItemIdParametersTypes);

            // Assert
            parametersOfResetPreviousItemId.ShouldBeNull();
            methodResetPreviousItemIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetPreviousItemId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPreviousItemId);
            Type [] methodResetPreviousItemIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetPreviousItemId, methodResetPreviousItemIdParametersTypes);

            // Assert
            methodResetPreviousItemIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetPreviousItemId) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ResetPreviousItemId_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetPreviousItemId);
            var currentMethodInfo = this.GetMethodInfo(MethodResetPreviousItemId, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_Internally(Type[] types)
        {
            var methodGetActiveTaskPaneParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);

            // Act
            Action executeAction = () => _thisAddInInstance.GetActiveTaskPane();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            var returnedValue = default(CustomTaskPane);

            // Act
            Action executeAction = () => returnedValue = _thisAddInInstance.GetActiveTaskPane();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            Type [] methodGetActiveTaskPaneParametersTypes = null;
            object[] parametersOfGetActiveTaskPane = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CustomTaskPane>(_thisAddInInstanceFixture, parametersOfGetActiveTaskPane);
            var result2 = this.GetResultOfMethod<CustomTaskPane>(MethodGetActiveTaskPane, parametersOfGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveTaskPane.ShouldBeNull();
            methodGetActiveTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            Type [] methodGetActiveTaskPaneParametersTypes = null;
            object[] parametersOfGetActiveTaskPane = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<CustomTaskPane>(MethodGetActiveTaskPane, parametersOfGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes);

            // Assert
            parametersOfGetActiveTaskPane.ShouldBeNull();
            methodGetActiveTaskPaneParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            Type [] methodGetActiveTaskPaneParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            Type [] methodGetActiveTaskPaneParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveTaskPane, methodGetActiveTaskPaneParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveTaskPane) (Return Type : CustomTaskPane) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveTaskPane_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveTaskPane);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveTaskPane, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_Internally(Type[] types)
        {
            var methodGetActiveInfoPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);

            // Act
            Action executeAction = () => _thisAddInInstance.GetActiveInfoPanel();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            var returnedValue = default(OnyxInfoPanel);

            // Act
            Action executeAction = () => returnedValue = _thisAddInInstance.GetActiveInfoPanel();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            Type [] methodGetActiveInfoPanelParametersTypes = null;
            object[] parametersOfGetActiveInfoPanel = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxInfoPanel>(_thisAddInInstanceFixture, parametersOfGetActiveInfoPanel);
            var result2 = this.GetResultOfMethod<OnyxInfoPanel>(MethodGetActiveInfoPanel, parametersOfGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveInfoPanel.ShouldBeNull();
            methodGetActiveInfoPanelParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            Type [] methodGetActiveInfoPanelParametersTypes = null;
            object[] parametersOfGetActiveInfoPanel = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxInfoPanel>(MethodGetActiveInfoPanel, parametersOfGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes);

            // Assert
            parametersOfGetActiveInfoPanel.ShouldBeNull();
            methodGetActiveInfoPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            Type [] methodGetActiveInfoPanelParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveInfoPanelParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            Type [] methodGetActiveInfoPanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveInfoPanel, methodGetActiveInfoPanelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveInfoPanelParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveInfoPanel) (Return Type : OnyxInfoPanel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetActiveInfoPanel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveInfoPanel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_Internally(Type[] types)
        {
            var methodAddToPostSendActionListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddToPostSendActionList, methodAddToPostSendActionListParametersTypes);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _thisAddInInstance.AddToPostSendActionList(newEmailId, action, associatedObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();
            var methodAddToPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };
            object[] parametersOfAddToPostSendActionList = { newEmailId, action, associatedObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddToPostSendActionList, methodAddToPostSendActionListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfAddToPostSendActionList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddToPostSendActionList.ShouldNotBeNull();
            parametersOfAddToPostSendActionList.Length.ShouldBe(3);
            methodAddToPostSendActionListParametersTypes.Length.ShouldBe(3);
            methodAddToPostSendActionListParametersTypes.Length.ShouldBe(parametersOfAddToPostSendActionList.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();
            var methodAddToPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };
            object[] parametersOfAddToPostSendActionList = { newEmailId, action, associatedObject };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddToPostSendActionList, parametersOfAddToPostSendActionList, methodAddToPostSendActionListParametersTypes);

            // Assert
            parametersOfAddToPostSendActionList.ShouldNotBeNull();
            parametersOfAddToPostSendActionList.Length.ShouldBe(3);
            methodAddToPostSendActionListParametersTypes.Length.ShouldBe(3);
            methodAddToPostSendActionListParametersTypes.Length.ShouldBe(parametersOfAddToPostSendActionList.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var currentMethodInfo = this.GetMethodInfo(MethodAddToPostSendActionList, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var methodAddToPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddToPostSendActionList, methodAddToPostSendActionListParametersTypes);

            // Assert
            methodAddToPostSendActionListParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddToPostSendActionList) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_AddToPostSendActionList_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddToPostSendActionList);
            var currentMethodInfo = this.GetMethodInfo(MethodAddToPostSendActionList, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_Internally(Type[] types)
        {
            var methodGetPostActionOnyxObjectListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();

            // Act
            Action executeAction = () => _thisAddInInstance.GetPostActionOnyxObjectList(newEmailId, action);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var returnedValue = default(List<OnyxObject>);

            // Act
            Action executeAction = () => returnedValue = _thisAddInInstance.GetPostActionOnyxObjectList(newEmailId, action);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var methodGetPostActionOnyxObjectListParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfGetPostActionOnyxObjectList = { newEmailId, action };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<OnyxObject>>(_thisAddInInstanceFixture, parametersOfGetPostActionOnyxObjectList);
            var result2 = this.GetResultOfMethod<List<OnyxObject>>(MethodGetPostActionOnyxObjectList, parametersOfGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPostActionOnyxObjectList.ShouldNotBeNull();
            parametersOfGetPostActionOnyxObjectList.Length.ShouldBe(2);
            methodGetPostActionOnyxObjectListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var newEmailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var methodGetPostActionOnyxObjectListParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfGetPostActionOnyxObjectList = { newEmailId, action };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<OnyxObject>>(MethodGetPostActionOnyxObjectList, parametersOfGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes);

            // Assert
            parametersOfGetPostActionOnyxObjectList.ShouldNotBeNull();
            parametersOfGetPostActionOnyxObjectList.Length.ShouldBe(2);
            methodGetPostActionOnyxObjectListParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var methodGetPostActionOnyxObjectListParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPostActionOnyxObjectListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var methodGetPostActionOnyxObjectListParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPostActionOnyxObjectList, methodGetPostActionOnyxObjectListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPostActionOnyxObjectListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPostActionOnyxObjectList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPostActionOnyxObjectList) (Return Type : List<OnyxObject>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_GetPostActionOnyxObjectList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPostActionOnyxObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPostActionOnyxObjectList, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_Internally(Type[] types)
        {
            var methodRemoveAllPostActionsForItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveAllPostActionsForItem, methodRemoveAllPostActionsForItemParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var itemId = this.CreateType<string>();

            // Act
            Action executeAction = () => _thisAddInInstance.RemoveAllPostActionsForItem(itemId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var itemId = this.CreateType<string>();
            var methodRemoveAllPostActionsForItemParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRemoveAllPostActionsForItem = { itemId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllPostActionsForItem, methodRemoveAllPostActionsForItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfRemoveAllPostActionsForItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveAllPostActionsForItem.ShouldNotBeNull();
            parametersOfRemoveAllPostActionsForItem.Length.ShouldBe(1);
            methodRemoveAllPostActionsForItemParametersTypes.Length.ShouldBe(1);
            methodRemoveAllPostActionsForItemParametersTypes.Length.ShouldBe(parametersOfRemoveAllPostActionsForItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var itemId = this.CreateType<string>();
            var methodRemoveAllPostActionsForItemParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRemoveAllPostActionsForItem = { itemId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveAllPostActionsForItem, parametersOfRemoveAllPostActionsForItem, methodRemoveAllPostActionsForItemParametersTypes);

            // Assert
            parametersOfRemoveAllPostActionsForItem.ShouldNotBeNull();
            parametersOfRemoveAllPostActionsForItem.Length.ShouldBe(1);
            methodRemoveAllPostActionsForItemParametersTypes.Length.ShouldBe(1);
            methodRemoveAllPostActionsForItemParametersTypes.Length.ShouldBe(parametersOfRemoveAllPostActionsForItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllPostActionsForItem, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var methodRemoveAllPostActionsForItemParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveAllPostActionsForItem, methodRemoveAllPostActionsForItemParametersTypes);

            // Assert
            methodRemoveAllPostActionsForItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllPostActionsForItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveAllPostActionsForItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllPostActionsForItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllPostActionsForItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_Internally(Type[] types)
        {
            var methodRemoveFromPostSendActionListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveFromPostSendActionList, methodRemoveFromPostSendActionListParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var emailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _thisAddInInstance.RemoveFromPostSendActionList(emailId, action, associatedObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var emailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();
            var methodRemoveFromPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };
            object[] parametersOfRemoveFromPostSendActionList = { emailId, action, associatedObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveFromPostSendActionList, methodRemoveFromPostSendActionListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfRemoveFromPostSendActionList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveFromPostSendActionList.ShouldNotBeNull();
            parametersOfRemoveFromPostSendActionList.Length.ShouldBe(3);
            methodRemoveFromPostSendActionListParametersTypes.Length.ShouldBe(3);
            methodRemoveFromPostSendActionListParametersTypes.Length.ShouldBe(parametersOfRemoveFromPostSendActionList.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var emailId = this.CreateType<string>();
            var action = this.CreateType<string>();
            var associatedObject = this.CreateType<OnyxObject>();
            var methodRemoveFromPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };
            object[] parametersOfRemoveFromPostSendActionList = { emailId, action, associatedObject };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveFromPostSendActionList, parametersOfRemoveFromPostSendActionList, methodRemoveFromPostSendActionListParametersTypes);

            // Assert
            parametersOfRemoveFromPostSendActionList.ShouldNotBeNull();
            parametersOfRemoveFromPostSendActionList.Length.ShouldBe(3);
            methodRemoveFromPostSendActionListParametersTypes.Length.ShouldBe(3);
            methodRemoveFromPostSendActionListParametersTypes.Length.ShouldBe(parametersOfRemoveFromPostSendActionList.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveFromPostSendActionList, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var methodRemoveFromPostSendActionListParametersTypes = new Type[] { typeof(String), typeof(String), typeof(OnyxObject) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveFromPostSendActionList, methodRemoveFromPostSendActionListParametersTypes);

            // Assert
            methodRemoveFromPostSendActionListParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveFromPostSendActionList) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_RemoveFromPostSendActionList_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveFromPostSendActionList);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveFromPostSendActionList, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (activeInlineClose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_activeInlineClose_Method_Call_Internally(Type[] types)
        {
            var methodactiveInlineCloseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodactiveInlineClose, methodactiveInlineCloseParametersTypes);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_activeInlineOpen_Method_Call_Internally(Type[] types)
        {
            var methodactiveInlineOpenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodactiveInlineOpen, methodactiveInlineOpenParametersTypes);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_activeInlineOpen_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodactiveInlineOpen);
            var currItem = this.CreateType<object>();
            var methodactiveInlineOpenParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfactiveInlineOpen = { currItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodactiveInlineOpen, methodactiveInlineOpenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfactiveInlineOpen);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfactiveInlineOpen.ShouldNotBeNull();
            parametersOfactiveInlineOpen.Length.ShouldBe(1);
            methodactiveInlineOpenParametersTypes.Length.ShouldBe(1);
            methodactiveInlineOpenParametersTypes.Length.ShouldBe(parametersOfactiveInlineOpen.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_activeInlineOpen_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodactiveInlineOpen);
            var currItem = this.CreateType<object>();
            var methodactiveInlineOpenParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfactiveInlineOpen = { currItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodactiveInlineOpen, parametersOfactiveInlineOpen, methodactiveInlineOpenParametersTypes);

            // Assert
            parametersOfactiveInlineOpen.ShouldNotBeNull();
            parametersOfactiveInlineOpen.Length.ShouldBe(1);
            methodactiveInlineOpenParametersTypes.Length.ShouldBe(1);
            methodactiveInlineOpenParametersTypes.Length.ShouldBe(parametersOfactiveInlineOpen.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_activeInlineOpen_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodactiveInlineOpen);
            var currentMethodInfo = this.GetMethodInfo(MethodactiveInlineOpen, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_activeInlineOpen_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodactiveInlineOpen);
            var methodactiveInlineOpenParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodactiveInlineOpen, methodactiveInlineOpenParametersTypes);

            // Assert
            methodactiveInlineOpenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (activeInlineOpen) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_activeInlineOpen_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodactiveInlineOpen);
            var currentMethodInfo = this.GetMethodInfo(MethodactiveInlineOpen, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_outFolderItemAdded_Method_Call_Internally(Type[] types)
        {
            var methodoutFolderItemAddedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodoutFolderItemAdded, methodoutFolderItemAddedParametersTypes);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_outFolderItemAdded_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoutFolderItemAdded);
            var Item = this.CreateType<object>();
            var methodoutFolderItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfoutFolderItemAdded = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodoutFolderItemAdded, methodoutFolderItemAddedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfoutFolderItemAdded);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfoutFolderItemAdded.ShouldNotBeNull();
            parametersOfoutFolderItemAdded.Length.ShouldBe(1);
            methodoutFolderItemAddedParametersTypes.Length.ShouldBe(1);
            methodoutFolderItemAddedParametersTypes.Length.ShouldBe(parametersOfoutFolderItemAdded.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_outFolderItemAdded_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoutFolderItemAdded);
            var Item = this.CreateType<object>();
            var methodoutFolderItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfoutFolderItemAdded = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodoutFolderItemAdded, parametersOfoutFolderItemAdded, methodoutFolderItemAddedParametersTypes);

            // Assert
            parametersOfoutFolderItemAdded.ShouldNotBeNull();
            parametersOfoutFolderItemAdded.Length.ShouldBe(1);
            methodoutFolderItemAddedParametersTypes.Length.ShouldBe(1);
            methodoutFolderItemAddedParametersTypes.Length.ShouldBe(parametersOfoutFolderItemAdded.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_outFolderItemAdded_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoutFolderItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodoutFolderItemAdded, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_outFolderItemAdded_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoutFolderItemAdded);
            var methodoutFolderItemAddedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodoutFolderItemAdded, methodoutFolderItemAddedParametersTypes);

            // Assert
            methodoutFolderItemAddedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (outFolderItemAdded) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_outFolderItemAdded_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodoutFolderItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodoutFolderItemAdded, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_inFolderItemAdded_Method_Call_Internally(Type[] types)
        {
            var methodinFolderItemAddedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinFolderItemAdded, methodinFolderItemAddedParametersTypes);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_inFolderItemAdded_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinFolderItemAdded);
            var Item = this.CreateType<object>();
            var methodinFolderItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfinFolderItemAdded = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinFolderItemAdded, methodinFolderItemAddedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfinFolderItemAdded);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinFolderItemAdded.ShouldNotBeNull();
            parametersOfinFolderItemAdded.Length.ShouldBe(1);
            methodinFolderItemAddedParametersTypes.Length.ShouldBe(1);
            methodinFolderItemAddedParametersTypes.Length.ShouldBe(parametersOfinFolderItemAdded.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_inFolderItemAdded_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinFolderItemAdded);
            var Item = this.CreateType<object>();
            var methodinFolderItemAddedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfinFolderItemAdded = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinFolderItemAdded, parametersOfinFolderItemAdded, methodinFolderItemAddedParametersTypes);

            // Assert
            parametersOfinFolderItemAdded.ShouldNotBeNull();
            parametersOfinFolderItemAdded.Length.ShouldBe(1);
            methodinFolderItemAddedParametersTypes.Length.ShouldBe(1);
            methodinFolderItemAddedParametersTypes.Length.ShouldBe(parametersOfinFolderItemAdded.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_inFolderItemAdded_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinFolderItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodinFolderItemAdded, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_inFolderItemAdded_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinFolderItemAdded);
            var methodinFolderItemAddedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinFolderItemAdded, methodinFolderItemAddedParametersTypes);

            // Assert
            methodinFolderItemAddedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (inFolderItemAdded) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_inFolderItemAdded_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinFolderItemAdded);
            var currentMethodInfo = this.GetMethodInfo(MethodinFolderItemAdded, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_postActionWorker_Method_Call_Internally(Type[] types)
        {
            var methodpostActionWorkerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpostActionWorker, methodpostActionWorkerParametersTypes);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_postActionWorker_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpostActionWorker);
            var mailItem = this.CreateType<Outlook.MailItem>();
            var methodpostActionWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };
            object[] parametersOfpostActionWorker = { mailItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpostActionWorker, methodpostActionWorkerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfpostActionWorker);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpostActionWorker.ShouldNotBeNull();
            parametersOfpostActionWorker.Length.ShouldBe(1);
            methodpostActionWorkerParametersTypes.Length.ShouldBe(1);
            methodpostActionWorkerParametersTypes.Length.ShouldBe(parametersOfpostActionWorker.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_postActionWorker_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpostActionWorker);
            var mailItem = this.CreateType<Outlook.MailItem>();
            var methodpostActionWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };
            object[] parametersOfpostActionWorker = { mailItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpostActionWorker, parametersOfpostActionWorker, methodpostActionWorkerParametersTypes);

            // Assert
            parametersOfpostActionWorker.ShouldNotBeNull();
            parametersOfpostActionWorker.Length.ShouldBe(1);
            methodpostActionWorkerParametersTypes.Length.ShouldBe(1);
            methodpostActionWorkerParametersTypes.Length.ShouldBe(parametersOfpostActionWorker.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_postActionWorker_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpostActionWorker);
            var currentMethodInfo = this.GetMethodInfo(MethodpostActionWorker, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_postActionWorker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpostActionWorker);
            var methodpostActionWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpostActionWorker, methodpostActionWorkerParametersTypes);

            // Assert
            methodpostActionWorkerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (postActionWorker) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_postActionWorker_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpostActionWorker);
            var currentMethodInfo = this.GetMethodInfo(MethodpostActionWorker, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_startSubWorker_Method_Call_Internally(Type[] types)
        {
            var methodstartSubWorkerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodstartSubWorker, methodstartSubWorkerParametersTypes);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_startSubWorker_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartSubWorker);
            var mailItem = this.CreateType<Outlook.MailItem>();
            var methodstartSubWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };
            object[] parametersOfstartSubWorker = { mailItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodstartSubWorker, methodstartSubWorkerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfstartSubWorker);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfstartSubWorker.ShouldNotBeNull();
            parametersOfstartSubWorker.Length.ShouldBe(1);
            methodstartSubWorkerParametersTypes.Length.ShouldBe(1);
            methodstartSubWorkerParametersTypes.Length.ShouldBe(parametersOfstartSubWorker.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_startSubWorker_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartSubWorker);
            var mailItem = this.CreateType<Outlook.MailItem>();
            var methodstartSubWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };
            object[] parametersOfstartSubWorker = { mailItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodstartSubWorker, parametersOfstartSubWorker, methodstartSubWorkerParametersTypes);

            // Assert
            parametersOfstartSubWorker.ShouldNotBeNull();
            parametersOfstartSubWorker.Length.ShouldBe(1);
            methodstartSubWorkerParametersTypes.Length.ShouldBe(1);
            methodstartSubWorkerParametersTypes.Length.ShouldBe(parametersOfstartSubWorker.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_startSubWorker_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartSubWorker);
            var currentMethodInfo = this.GetMethodInfo(MethodstartSubWorker, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_startSubWorker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartSubWorker);
            var methodstartSubWorkerParametersTypes = new Type[] { typeof(Outlook.MailItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodstartSubWorker, methodstartSubWorkerParametersTypes);

            // Assert
            methodstartSubWorkerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startSubWorker) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_startSubWorker_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartSubWorker);
            var currentMethodInfo = this.GetMethodInfo(MethodstartSubWorker, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_Internally(Type[] types)
        {
            var methodInspectors_NewInspectorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInspectors_NewInspector, methodInspectors_NewInspectorParametersTypes);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectors_NewInspector);
            var Inspector = this.CreateType<Outlook.Inspector>();
            var methodInspectors_NewInspectorParametersTypes = new Type[] { typeof(Outlook.Inspector) };
            object[] parametersOfInspectors_NewInspector = { Inspector };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInspectors_NewInspector, methodInspectors_NewInspectorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInspectors_NewInspector);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInspectors_NewInspector.ShouldNotBeNull();
            parametersOfInspectors_NewInspector.Length.ShouldBe(1);
            methodInspectors_NewInspectorParametersTypes.Length.ShouldBe(1);
            methodInspectors_NewInspectorParametersTypes.Length.ShouldBe(parametersOfInspectors_NewInspector.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectors_NewInspector);
            var Inspector = this.CreateType<Outlook.Inspector>();
            var methodInspectors_NewInspectorParametersTypes = new Type[] { typeof(Outlook.Inspector) };
            object[] parametersOfInspectors_NewInspector = { Inspector };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInspectors_NewInspector, parametersOfInspectors_NewInspector, methodInspectors_NewInspectorParametersTypes);

            // Assert
            parametersOfInspectors_NewInspector.ShouldNotBeNull();
            parametersOfInspectors_NewInspector.Length.ShouldBe(1);
            methodInspectors_NewInspectorParametersTypes.Length.ShouldBe(1);
            methodInspectors_NewInspectorParametersTypes.Length.ShouldBe(parametersOfInspectors_NewInspector.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectors_NewInspector);
            var currentMethodInfo = this.GetMethodInfo(MethodInspectors_NewInspector, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectors_NewInspector);
            var methodInspectors_NewInspectorParametersTypes = new Type[] { typeof(Outlook.Inspector) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInspectors_NewInspector, methodInspectors_NewInspectorParametersTypes);

            // Assert
            methodInspectors_NewInspectorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Inspectors_NewInspector) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_Inspectors_NewInspector_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectors_NewInspector);
            var currentMethodInfo = this.GetMethodInfo(MethodInspectors_NewInspector, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (currentExplorer_Event) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_currentExplorer_Event_Method_Call_Internally(Type[] types)
        {
            var methodcurrentExplorer_EventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcurrentExplorer_Event, methodcurrentExplorer_EventParametersTypes);
        }

        #endregion

        #region Method Call : (currentExplorer_Event) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_currentExplorer_Event_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcurrentExplorer_Event);
            Type [] methodcurrentExplorer_EventParametersTypes = null;
            object[] parametersOfcurrentExplorer_Event = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcurrentExplorer_Event, methodcurrentExplorer_EventParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfcurrentExplorer_Event);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcurrentExplorer_Event.ShouldBeNull();
            methodcurrentExplorer_EventParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (currentExplorer_Event) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_currentExplorer_Event_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcurrentExplorer_Event);
            Type [] methodcurrentExplorer_EventParametersTypes = null;
            object[] parametersOfcurrentExplorer_Event = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcurrentExplorer_Event, parametersOfcurrentExplorer_Event, methodcurrentExplorer_EventParametersTypes);

            // Assert
            parametersOfcurrentExplorer_Event.ShouldBeNull();
            methodcurrentExplorer_EventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (currentExplorer_Event) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_currentExplorer_Event_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcurrentExplorer_Event);
            Type [] methodcurrentExplorer_EventParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcurrentExplorer_Event, methodcurrentExplorer_EventParametersTypes);

            // Assert
            methodcurrentExplorer_EventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (currentExplorer_Event) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_currentExplorer_Event_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcurrentExplorer_Event);
            var currentMethodInfo = this.GetMethodInfo(MethodcurrentExplorer_Event, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_addCustomTaskPane_Method_Call_Internally(Type[] types)
        {
            var methodaddCustomTaskPaneParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes);
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_addCustomTaskPane_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddCustomTaskPane);
            Type [] methodaddCustomTaskPaneParametersTypes = null;
            object[] parametersOfaddCustomTaskPane = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CustomTaskPane>(_thisAddInInstanceFixture, parametersOfaddCustomTaskPane);
            var result2 = this.GetResultOfMethod<CustomTaskPane>(MethodaddCustomTaskPane, parametersOfaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfaddCustomTaskPane.ShouldBeNull();
            methodaddCustomTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_addCustomTaskPane_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddCustomTaskPane);
            Type [] methodaddCustomTaskPaneParametersTypes = null;
            object[] parametersOfaddCustomTaskPane = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<CustomTaskPane>(MethodaddCustomTaskPane, parametersOfaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes);

            // Assert
            parametersOfaddCustomTaskPane.ShouldBeNull();
            methodaddCustomTaskPaneParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_addCustomTaskPane_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddCustomTaskPane);
            Type [] methodaddCustomTaskPaneParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodaddCustomTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_addCustomTaskPane_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddCustomTaskPane);
            Type [] methodaddCustomTaskPaneParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddCustomTaskPane, methodaddCustomTaskPaneParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodaddCustomTaskPaneParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (addCustomTaskPane) (Return Type : CustomTaskPane) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_addCustomTaskPane_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddCustomTaskPane);
            var currentMethodInfo = this.GetMethodInfo(MethodaddCustomTaskPane, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_Internally(Type[] types)
        {
            var methodMyCustomTaskPane_VisibleChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMyCustomTaskPane_VisibleChanged, methodMyCustomTaskPane_VisibleChangedParametersTypes);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();

            // Act
            Action executeAction = () => _thisAddInInstance.MyCustomTaskPane_VisibleChanged(sender, e);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodMyCustomTaskPane_VisibleChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfMyCustomTaskPane_VisibleChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMyCustomTaskPane_VisibleChanged, methodMyCustomTaskPane_VisibleChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfMyCustomTaskPane_VisibleChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMyCustomTaskPane_VisibleChanged.ShouldNotBeNull();
            parametersOfMyCustomTaskPane_VisibleChanged.Length.ShouldBe(2);
            methodMyCustomTaskPane_VisibleChangedParametersTypes.Length.ShouldBe(2);
            methodMyCustomTaskPane_VisibleChangedParametersTypes.Length.ShouldBe(parametersOfMyCustomTaskPane_VisibleChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodMyCustomTaskPane_VisibleChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfMyCustomTaskPane_VisibleChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMyCustomTaskPane_VisibleChanged, parametersOfMyCustomTaskPane_VisibleChanged, methodMyCustomTaskPane_VisibleChangedParametersTypes);

            // Assert
            parametersOfMyCustomTaskPane_VisibleChanged.ShouldNotBeNull();
            parametersOfMyCustomTaskPane_VisibleChanged.Length.ShouldBe(2);
            methodMyCustomTaskPane_VisibleChangedParametersTypes.Length.ShouldBe(2);
            methodMyCustomTaskPane_VisibleChangedParametersTypes.Length.ShouldBe(parametersOfMyCustomTaskPane_VisibleChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodMyCustomTaskPane_VisibleChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var methodMyCustomTaskPane_VisibleChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMyCustomTaskPane_VisibleChanged, methodMyCustomTaskPane_VisibleChangedParametersTypes);

            // Assert
            methodMyCustomTaskPane_VisibleChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MyCustomTaskPane_VisibleChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_MyCustomTaskPane_VisibleChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMyCustomTaskPane_VisibleChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodMyCustomTaskPane_VisibleChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_ShowFolderInfo_Method_Call_Internally(Type[] types)
        {
            var methodShowFolderInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodShowFolderInfo, methodShowFolderInfoParametersTypes);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ShowFolderInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShowFolderInfo);

            // Act
            Action executeAction = () => _thisAddInInstance.ShowFolderInfo();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ShowFolderInfo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShowFolderInfo);
            Type [] methodShowFolderInfoParametersTypes = null;
            object[] parametersOfShowFolderInfo = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodShowFolderInfo, methodShowFolderInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfShowFolderInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfShowFolderInfo.ShouldBeNull();
            methodShowFolderInfoParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ShowFolderInfo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShowFolderInfo);
            Type [] methodShowFolderInfoParametersTypes = null;
            object[] parametersOfShowFolderInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodShowFolderInfo, parametersOfShowFolderInfo, methodShowFolderInfoParametersTypes);

            // Assert
            parametersOfShowFolderInfo.ShouldBeNull();
            methodShowFolderInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ShowFolderInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShowFolderInfo);
            Type [] methodShowFolderInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodShowFolderInfo, methodShowFolderInfoParametersTypes);

            // Assert
            methodShowFolderInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShowFolderInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_ShowFolderInfo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShowFolderInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodShowFolderInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRibbonExtensibilityObject) (Return Type : Microsoft.Office.Core.IRibbonExtensibility) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_CreateRibbonExtensibilityObject_Method_Call_Internally(Type[] types)
        {
            var methodCreateRibbonExtensibilityObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRibbonExtensibilityObject, methodCreateRibbonExtensibilityObjectParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRibbonExtensibilityObject) (Return Type : Microsoft.Office.Core.IRibbonExtensibility) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_CreateRibbonExtensibilityObject_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRibbonExtensibilityObject);
            Type [] methodCreateRibbonExtensibilityObjectParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRibbonExtensibilityObject, methodCreateRibbonExtensibilityObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateRibbonExtensibilityObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRibbonExtensibilityObject) (Return Type : Microsoft.Office.Core.IRibbonExtensibility) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_CreateRibbonExtensibilityObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRibbonExtensibilityObject);
            Type [] methodCreateRibbonExtensibilityObjectParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRibbonExtensibilityObject, methodCreateRibbonExtensibilityObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRibbonExtensibilityObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRibbonExtensibilityObject) (Return Type : Microsoft.Office.Core.IRibbonExtensibility) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_CreateRibbonExtensibilityObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRibbonExtensibilityObject);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRibbonExtensibilityObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InternalStartup) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddIn_InternalStartup_Method_Call_Internally(Type[] types)
        {
            var methodInternalStartupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInternalStartup, methodInternalStartupParametersTypes);
        }

        #endregion

        #region Method Call : (InternalStartup) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InternalStartup_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalStartup);
            Type [] methodInternalStartupParametersTypes = null;
            object[] parametersOfInternalStartup = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInternalStartup, methodInternalStartupParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInternalStartup);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInternalStartup.ShouldBeNull();
            methodInternalStartupParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InternalStartup) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InternalStartup_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalStartup);
            Type [] methodInternalStartupParametersTypes = null;
            object[] parametersOfInternalStartup = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInternalStartup, parametersOfInternalStartup, methodInternalStartupParametersTypes);

            // Assert
            parametersOfInternalStartup.ShouldBeNull();
            methodInternalStartupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InternalStartup) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InternalStartup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalStartup);
            Type [] methodInternalStartupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInternalStartup, methodInternalStartupParametersTypes);

            // Assert
            methodInternalStartupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InternalStartup) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddIn_InternalStartup_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalStartup);
            var currentMethodInfo = this.GetMethodInfo(MethodInternalStartup, 0);

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