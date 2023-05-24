using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.TitleControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class TitleControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TitleControl" />)
        /// </summary>
        public TitleControlTest() : base(typeof(TitleControl))
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

        #region General Initializer : Class (TitleControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _titleControlInstanceType;
        private TitleControl _titleControlInstance;
        private TitleControl _titleControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TitleControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _titleControlInstanceType = typeof(TitleControl);
            _titleControlInstanceFixture = this.Create<TitleControl>(false);
            _titleControlInstance = _titleControlInstanceFixture ?? this.Create<TitleControl>(true);
            CurrentInstance = _titleControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TitleControl) Initializer

        #region Properties

        private const string PropertyIsPopulated = "IsPopulated";
        private const string PropertyIsNeedsRefresh = "IsNeedsRefresh";
        private const string PropertyTitle = "Title";
        private const string PropertyTitleMember = "TitleMember";
        private const string PropertyCustomControlId = "CustomControlId";
        private const string PropertyAssociatedOnyxObject = "AssociatedOnyxObject";

        #endregion

        #region Methods

        private const string MethodPopulateControl = "PopulateControl";
        private const string MethodsetControlBasicProperties = "setControlBasicProperties";
        private const string MethodaddDupeLink = "addDupeLink";
        private const string MethodbuildMenuItem = "buildMenuItem";
        private const string MethodbuildMenuStrip = "buildMenuStrip";
        private const string MethodbuildTitleMenu = "buildTitleMenu";
        private const string MethodbuildUnresolvedCustomerMenu = "buildUnresolvedCustomerMenu";
        private const string MethodtitleTextBox_Click_ListHeader = "titleTextBox_Click_ListHeader";
        private const string MethodtitleTextBox_Click_MemberHeader = "titleTextBox_Click_MemberHeader";
        private const string MethoddownloadContact_Click = "downloadContact_Click";
        private const string MethodaddContactMenuItem_Click = "addContactMenuItem_Click";
        private const string MethodaddInternalContactMenuItem_Click = "addInternalContactMenuItem_Click";
        private const string MethodaddApptMenuItem_Click = "addApptMenuItem_Click";
        private const string MethodaddEmailMenuItem_Click = "addEmailMenuItem_Click";
        private const string MethodaddNotesMenuItem_Click = "addNotesMenuItem_Click";
        private const string MethodaddAttachmentMenuItem_Click = "addAttachmentMenuItem_Click";
        private const string MethodreplyWithTemplateMenuItem_Click = "replyWithTemplateMenuItem_Click";
        private const string MethodcreateSalesOppMenuItem_Click = "createSalesOppMenuItem_Click";
        private const string MethodcreateServiceIncMenuItem_Click = "createServiceIncMenuItem_Click";
        private const string MethodcreateSupportTicketMenuItem_Click = "createSupportTicketMenuItem_Click";
        private const string MethodcreateOutlookContactMenuItem_Click = "createOutlookContactMenuItem_Click";
        private const string MethodexpandCollapseButton_Click = "expandCollapseButton_Click";
        private const string MethodAddControlToTree = "AddControlToTree";
        private const string MethodexpandCustomerInfo = "expandCustomerInfo";
        private const string MethodselectedCustomer = "selectedCustomer";
        private const string MethodlblDupeCount_LinkClicked = "lblDupeCount_LinkClicked";
        private const string MethodResetTableLayoutPanels = "ResetTableLayoutPanels";

        #endregion

        #region Fields

        private const string Fieldmember = "member";
        private const string FieldcontrolId = "controlId";
        private const string Fieldtitle = "title";
        private const string FieldassociatedOnyxObject = "associatedOnyxObject";
        private const string FieldinfoPanel = "infoPanel";
        private const string FieldiLevel = "iLevel";
        private const string Fieldtip = "tip";
        private const string FielddictActionMenuEventHandlers = "dictActionMenuEventHandlers";

        #endregion

        #endregion

        #region General Initializer : Class (TitleControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TitleControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControl_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TitleControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TitleControl)

        #region General Initializer : Class (TitleControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPopulateControl, 0)]
        [TestCase(MethodsetControlBasicProperties, 0)]
        [TestCase(MethodaddDupeLink, 0)]
        [TestCase(MethodbuildMenuItem, 0)]
        [TestCase(MethodbuildMenuStrip, 0)]
        [TestCase(MethodbuildTitleMenu, 0)]
        [TestCase(MethodbuildUnresolvedCustomerMenu, 0)]
        [TestCase(MethodtitleTextBox_Click_ListHeader, 0)]
        [TestCase(MethodtitleTextBox_Click_MemberHeader, 0)]
        [TestCase(MethoddownloadContact_Click, 0)]
        [TestCase(MethodaddContactMenuItem_Click, 0)]
        [TestCase(MethodaddInternalContactMenuItem_Click, 0)]
        [TestCase(MethodaddApptMenuItem_Click, 0)]
        [TestCase(MethodaddEmailMenuItem_Click, 0)]
        [TestCase(MethodaddNotesMenuItem_Click, 0)]
        [TestCase(MethodaddAttachmentMenuItem_Click, 0)]
        [TestCase(MethodreplyWithTemplateMenuItem_Click, 0)]
        [TestCase(MethodcreateSalesOppMenuItem_Click, 0)]
        [TestCase(MethodcreateServiceIncMenuItem_Click, 0)]
        [TestCase(MethodcreateSupportTicketMenuItem_Click, 0)]
        [TestCase(MethodcreateOutlookContactMenuItem_Click, 0)]
        [TestCase(MethodexpandCollapseButton_Click, 0)]
        [TestCase(MethodAddControlToTree, 0)]
        [TestCase(MethodexpandCustomerInfo, 0)]
        [TestCase(MethodselectedCustomer, 0)]
        [TestCase(MethodlblDupeCount_LinkClicked, 0)]
        [TestCase(MethodResetTableLayoutPanels, 0)]
        public void AUT_TitleControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TitleControl) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyTitleMember)]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyAssociatedOnyxObject)]
        [Category("AUT Property")]
        public void AUT_TitleControl_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TitleControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldmember)]
        [TestCase(FieldcontrolId)]
        [TestCase(Fieldtitle)]
        [TestCase(FieldassociatedOnyxObject)]
        [TestCase(FieldinfoPanel)]
        [TestCase(FieldiLevel)]
        [TestCase(Fieldtip)]
        [TestCase(FielddictActionMenuEventHandlers)]
        [Category("AUT Fields")]
        public void AUT_TitleControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TitleControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TitleControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TitleControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _titleControlInstance.ShouldBeAssignableTo<TitleControl>();
            _titleControlInstanceFixture.ShouldBeAssignableTo<TitleControl>();
            CurrentInstance.ShouldBeAssignableTo<TitleControl>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TitleControl) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TitleControl" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TitleControl_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TitleControl) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TitleControl" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TitleControl_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTitleControlParametersTypes = new Type[] { typeof(Member), typeof(List<OutlookActionMenuItem>), typeof(OnyxInfoPanel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTitleControlParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TitleControl) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TitleControl" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TitleControl_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTitleControlParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(int), typeof(OnyxInfoPanel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTitleControlParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TitleControl) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TitleControl" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TitleControl_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTitleControlParametersTypes = new Type[] { typeof(OnyxCustomer), typeof(List<OutlookActionMenuItem>), typeof(bool), typeof(bool), typeof(OnyxInfoPanel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTitleControlParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TitleControl) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TitleControl" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TitleControl_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTitleControlParametersTypes = new Type[] { typeof(OnyxOutlookListData), typeof(List<OutlookActionMenuItem>), typeof(OnyxInfoPanel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTitleControlParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TitleControl) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyTitleMember)]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyAssociatedOnyxObject)]
        public void AUT_TitleControl_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TitleControl) => Property (AssociatedOnyxObject) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_AssociatedOnyxObject_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssociatedOnyxObject);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAssociatedOnyxObject);
            Action currentAction = () => propertyInfo.SetValue(_titleControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (AssociatedOnyxObject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_AssociatedOnyxObject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssociatedOnyxObject);
            var propertyInfo = this.GetPropertyInfo(PropertyAssociatedOnyxObject);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (CustomControlId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_CustomControlId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);
            Action currentAction = () => propertyInfo.SetValue(_titleControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (CustomControlId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_CustomControlId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TitleControl) => Property (IsNeedsRefresh) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_IsNeedsRefresh_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TitleControl) => Property (IsPopulated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_IsPopulated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TitleControl) => Property (Title) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Title_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTitle);
            Action currentAction = () => propertyInfo.SetValue(_titleControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (Title) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_Title_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (TitleMember) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_TitleMember_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitleMember);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTitleMember);
            Action currentAction = () => propertyInfo.SetValue(_titleControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TitleControl) => Property (TitleMember) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TitleControl_Public_Class_TitleMember_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitleMember);
            var propertyInfo = this.GetPropertyInfo(PropertyTitleMember);

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

        #region Method Call : (PopulateControl) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_PopulateControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);

            // Act
            Action executeAction = () => _titleControlInstance.PopulateControl();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_PopulateControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfPopulateControl);

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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_PopulateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_PopulateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_PopulateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (setControlBasicProperties) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_setControlBasicProperties_Method_Call_Internally(Type[] types)
        {
            var methodsetControlBasicPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsetControlBasicProperties, methodsetControlBasicPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (setControlBasicProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_setControlBasicProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetControlBasicProperties);
            var paramTitle = this.CreateType<string>();
            var isCollapsible = this.CreateType<bool>();
            var level = this.CreateType<int>();
            var methodsetControlBasicPropertiesParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(int) };
            object[] parametersOfsetControlBasicProperties = { paramTitle, isCollapsible, level };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsetControlBasicProperties, methodsetControlBasicPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfsetControlBasicProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsetControlBasicProperties.ShouldNotBeNull();
            parametersOfsetControlBasicProperties.Length.ShouldBe(3);
            methodsetControlBasicPropertiesParametersTypes.Length.ShouldBe(3);
            methodsetControlBasicPropertiesParametersTypes.Length.ShouldBe(parametersOfsetControlBasicProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (setControlBasicProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_setControlBasicProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetControlBasicProperties);
            var paramTitle = this.CreateType<string>();
            var isCollapsible = this.CreateType<bool>();
            var level = this.CreateType<int>();
            var methodsetControlBasicPropertiesParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(int) };
            object[] parametersOfsetControlBasicProperties = { paramTitle, isCollapsible, level };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsetControlBasicProperties, parametersOfsetControlBasicProperties, methodsetControlBasicPropertiesParametersTypes);

            // Assert
            parametersOfsetControlBasicProperties.ShouldNotBeNull();
            parametersOfsetControlBasicProperties.Length.ShouldBe(3);
            methodsetControlBasicPropertiesParametersTypes.Length.ShouldBe(3);
            methodsetControlBasicPropertiesParametersTypes.Length.ShouldBe(parametersOfsetControlBasicProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setControlBasicProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_setControlBasicProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetControlBasicProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodsetControlBasicProperties, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (setControlBasicProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_setControlBasicProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetControlBasicProperties);
            var methodsetControlBasicPropertiesParametersTypes = new Type[] { typeof(String), typeof(bool), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsetControlBasicProperties, methodsetControlBasicPropertiesParametersTypes);

            // Assert
            methodsetControlBasicPropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setControlBasicProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_setControlBasicProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsetControlBasicProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodsetControlBasicProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addDupeLink) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addDupeLink_Method_Call_Internally(Type[] types)
        {
            var methodaddDupeLinkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddDupeLink, methodaddDupeLinkParametersTypes);
        }

        #endregion

        #region Method Call : (addDupeLink) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addDupeLink_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDupeLink);
            Type [] methodaddDupeLinkParametersTypes = null;
            object[] parametersOfaddDupeLink = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddDupeLink, methodaddDupeLinkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddDupeLink);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddDupeLink.ShouldBeNull();
            methodaddDupeLinkParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addDupeLink) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addDupeLink_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDupeLink);
            Type [] methodaddDupeLinkParametersTypes = null;
            object[] parametersOfaddDupeLink = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddDupeLink, parametersOfaddDupeLink, methodaddDupeLinkParametersTypes);

            // Assert
            parametersOfaddDupeLink.ShouldBeNull();
            methodaddDupeLinkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addDupeLink) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addDupeLink_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDupeLink);
            Type [] methodaddDupeLinkParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddDupeLink, methodaddDupeLinkParametersTypes);

            // Assert
            methodaddDupeLinkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addDupeLink) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addDupeLink_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddDupeLink);
            var currentMethodInfo = this.GetMethodInfo(MethodaddDupeLink, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_buildMenuItem_Method_Call_Internally(Type[] types)
        {
            var methodbuildMenuItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuildMenuItem, methodbuildMenuItemParametersTypes);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var name = this.CreateType<string>();
            var text = this.CreateType<string>();
            var methodbuildMenuItemParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfbuildMenuItem = { name, text };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuItem, methodbuildMenuItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ToolStripMenuItem>(_titleControlInstanceFixture, parametersOfbuildMenuItem);
            var result2 = this.GetResultOfMethod<ToolStripMenuItem>(MethodbuildMenuItem, parametersOfbuildMenuItem, methodbuildMenuItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfbuildMenuItem.ShouldNotBeNull();
            parametersOfbuildMenuItem.Length.ShouldBe(2);
            methodbuildMenuItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var name = this.CreateType<string>();
            var text = this.CreateType<string>();
            var methodbuildMenuItemParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfbuildMenuItem = { name, text };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ToolStripMenuItem>(MethodbuildMenuItem, parametersOfbuildMenuItem, methodbuildMenuItemParametersTypes);

            // Assert
            parametersOfbuildMenuItem.ShouldNotBeNull();
            parametersOfbuildMenuItem.Length.ShouldBe(2);
            methodbuildMenuItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var methodbuildMenuItemParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodbuildMenuItem, methodbuildMenuItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodbuildMenuItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var methodbuildMenuItemParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuildMenuItem, methodbuildMenuItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodbuildMenuItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (buildMenuItem) (Return Type : ToolStripMenuItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuItem);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_buildMenuStrip_Method_Call_Internally(Type[] types)
        {
            var methodbuildMenuStripParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuildMenuStrip, methodbuildMenuStripParametersTypes);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var name = this.CreateType<string>();
            var methodbuildMenuStripParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfbuildMenuStrip = { name };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuStrip, methodbuildMenuStripParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<MenuStrip>(_titleControlInstanceFixture, parametersOfbuildMenuStrip);
            var result2 = this.GetResultOfMethod<MenuStrip>(MethodbuildMenuStrip, parametersOfbuildMenuStrip, methodbuildMenuStripParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfbuildMenuStrip.ShouldNotBeNull();
            parametersOfbuildMenuStrip.Length.ShouldBe(1);
            methodbuildMenuStripParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var name = this.CreateType<string>();
            var methodbuildMenuStripParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfbuildMenuStrip = { name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<MenuStrip>(MethodbuildMenuStrip, parametersOfbuildMenuStrip, methodbuildMenuStripParametersTypes);

            // Assert
            parametersOfbuildMenuStrip.ShouldNotBeNull();
            parametersOfbuildMenuStrip.Length.ShouldBe(1);
            methodbuildMenuStripParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var methodbuildMenuStripParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodbuildMenuStrip, methodbuildMenuStripParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodbuildMenuStripParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var methodbuildMenuStripParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuildMenuStrip, methodbuildMenuStripParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodbuildMenuStripParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuStrip, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (buildMenuStrip) (Return Type : MenuStrip) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildMenuStrip_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildMenuStrip);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildMenuStrip, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_buildTitleMenu_Method_Call_Internally(Type[] types)
        {
            var methodbuildTitleMenuParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuildTitleMenu, methodbuildTitleMenuParametersTypes);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildTitleMenu_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildTitleMenu);
            var actionMenuItems = this.CreateType<List<OutlookActionMenuItem>>();
            var methodbuildTitleMenuParametersTypes = new Type[] { typeof(List<OutlookActionMenuItem>) };
            object[] parametersOfbuildTitleMenu = { actionMenuItems };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuildTitleMenu, methodbuildTitleMenuParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfbuildTitleMenu);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuildTitleMenu.ShouldNotBeNull();
            parametersOfbuildTitleMenu.Length.ShouldBe(1);
            methodbuildTitleMenuParametersTypes.Length.ShouldBe(1);
            methodbuildTitleMenuParametersTypes.Length.ShouldBe(parametersOfbuildTitleMenu.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildTitleMenu_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildTitleMenu);
            var actionMenuItems = this.CreateType<List<OutlookActionMenuItem>>();
            var methodbuildTitleMenuParametersTypes = new Type[] { typeof(List<OutlookActionMenuItem>) };
            object[] parametersOfbuildTitleMenu = { actionMenuItems };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuildTitleMenu, parametersOfbuildTitleMenu, methodbuildTitleMenuParametersTypes);

            // Assert
            parametersOfbuildTitleMenu.ShouldNotBeNull();
            parametersOfbuildTitleMenu.Length.ShouldBe(1);
            methodbuildTitleMenuParametersTypes.Length.ShouldBe(1);
            methodbuildTitleMenuParametersTypes.Length.ShouldBe(parametersOfbuildTitleMenu.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildTitleMenu_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildTitleMenu);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildTitleMenu, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildTitleMenu_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildTitleMenu);
            var methodbuildTitleMenuParametersTypes = new Type[] { typeof(List<OutlookActionMenuItem>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuildTitleMenu, methodbuildTitleMenuParametersTypes);

            // Assert
            methodbuildTitleMenuParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildTitleMenu) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildTitleMenu_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildTitleMenu);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildTitleMenu, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildUnresolvedCustomerMenu) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_buildUnresolvedCustomerMenu_Method_Call_Internally(Type[] types)
        {
            var methodbuildUnresolvedCustomerMenuParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuildUnresolvedCustomerMenu, methodbuildUnresolvedCustomerMenuParametersTypes);
        }

        #endregion

        #region Method Call : (buildUnresolvedCustomerMenu) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildUnresolvedCustomerMenu_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildUnresolvedCustomerMenu);
            Type [] methodbuildUnresolvedCustomerMenuParametersTypes = null;
            object[] parametersOfbuildUnresolvedCustomerMenu = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuildUnresolvedCustomerMenu, methodbuildUnresolvedCustomerMenuParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfbuildUnresolvedCustomerMenu);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuildUnresolvedCustomerMenu.ShouldBeNull();
            methodbuildUnresolvedCustomerMenuParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buildUnresolvedCustomerMenu) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildUnresolvedCustomerMenu_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildUnresolvedCustomerMenu);
            Type [] methodbuildUnresolvedCustomerMenuParametersTypes = null;
            object[] parametersOfbuildUnresolvedCustomerMenu = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuildUnresolvedCustomerMenu, parametersOfbuildUnresolvedCustomerMenu, methodbuildUnresolvedCustomerMenuParametersTypes);

            // Assert
            parametersOfbuildUnresolvedCustomerMenu.ShouldBeNull();
            methodbuildUnresolvedCustomerMenuParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildUnresolvedCustomerMenu) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildUnresolvedCustomerMenu_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildUnresolvedCustomerMenu);
            Type [] methodbuildUnresolvedCustomerMenuParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuildUnresolvedCustomerMenu, methodbuildUnresolvedCustomerMenuParametersTypes);

            // Assert
            methodbuildUnresolvedCustomerMenuParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buildUnresolvedCustomerMenu) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_buildUnresolvedCustomerMenu_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuildUnresolvedCustomerMenu);
            var currentMethodInfo = this.GetMethodInfo(MethodbuildUnresolvedCustomerMenu, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_Internally(Type[] types)
        {
            var methodtitleTextBox_Click_ListHeaderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtitleTextBox_Click_ListHeader, methodtitleTextBox_Click_ListHeaderParametersTypes);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_ListHeader);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtitleTextBox_Click_ListHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftitleTextBox_Click_ListHeader = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_ListHeader, methodtitleTextBox_Click_ListHeaderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOftitleTextBox_Click_ListHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftitleTextBox_Click_ListHeader.ShouldNotBeNull();
            parametersOftitleTextBox_Click_ListHeader.Length.ShouldBe(2);
            methodtitleTextBox_Click_ListHeaderParametersTypes.Length.ShouldBe(2);
            methodtitleTextBox_Click_ListHeaderParametersTypes.Length.ShouldBe(parametersOftitleTextBox_Click_ListHeader.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_ListHeader);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtitleTextBox_Click_ListHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftitleTextBox_Click_ListHeader = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtitleTextBox_Click_ListHeader, parametersOftitleTextBox_Click_ListHeader, methodtitleTextBox_Click_ListHeaderParametersTypes);

            // Assert
            parametersOftitleTextBox_Click_ListHeader.ShouldNotBeNull();
            parametersOftitleTextBox_Click_ListHeader.Length.ShouldBe(2);
            methodtitleTextBox_Click_ListHeaderParametersTypes.Length.ShouldBe(2);
            methodtitleTextBox_Click_ListHeaderParametersTypes.Length.ShouldBe(parametersOftitleTextBox_Click_ListHeader.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_ListHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_ListHeader, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_ListHeader);
            var methodtitleTextBox_Click_ListHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtitleTextBox_Click_ListHeader, methodtitleTextBox_Click_ListHeaderParametersTypes);

            // Assert
            methodtitleTextBox_Click_ListHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_ListHeader) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_ListHeader_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_ListHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_ListHeader, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_Internally(Type[] types)
        {
            var methodtitleTextBox_Click_MemberHeaderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtitleTextBox_Click_MemberHeader, methodtitleTextBox_Click_MemberHeaderParametersTypes);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_MemberHeader);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtitleTextBox_Click_MemberHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftitleTextBox_Click_MemberHeader = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_MemberHeader, methodtitleTextBox_Click_MemberHeaderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOftitleTextBox_Click_MemberHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftitleTextBox_Click_MemberHeader.ShouldNotBeNull();
            parametersOftitleTextBox_Click_MemberHeader.Length.ShouldBe(2);
            methodtitleTextBox_Click_MemberHeaderParametersTypes.Length.ShouldBe(2);
            methodtitleTextBox_Click_MemberHeaderParametersTypes.Length.ShouldBe(parametersOftitleTextBox_Click_MemberHeader.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_MemberHeader);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtitleTextBox_Click_MemberHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftitleTextBox_Click_MemberHeader = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtitleTextBox_Click_MemberHeader, parametersOftitleTextBox_Click_MemberHeader, methodtitleTextBox_Click_MemberHeaderParametersTypes);

            // Assert
            parametersOftitleTextBox_Click_MemberHeader.ShouldNotBeNull();
            parametersOftitleTextBox_Click_MemberHeader.Length.ShouldBe(2);
            methodtitleTextBox_Click_MemberHeaderParametersTypes.Length.ShouldBe(2);
            methodtitleTextBox_Click_MemberHeaderParametersTypes.Length.ShouldBe(parametersOftitleTextBox_Click_MemberHeader.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_MemberHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_MemberHeader, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_MemberHeader);
            var methodtitleTextBox_Click_MemberHeaderParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtitleTextBox_Click_MemberHeader, methodtitleTextBox_Click_MemberHeaderParametersTypes);

            // Assert
            methodtitleTextBox_Click_MemberHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (titleTextBox_Click_MemberHeader) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_titleTextBox_Click_MemberHeader_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtitleTextBox_Click_MemberHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodtitleTextBox_Click_MemberHeader, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_downloadContact_Click_Method_Call_Internally(Type[] types)
        {
            var methoddownloadContact_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethoddownloadContact_Click, methoddownloadContact_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_downloadContact_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddownloadContact_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methoddownloadContact_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfdownloadContact_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethoddownloadContact_Click, methoddownloadContact_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfdownloadContact_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfdownloadContact_Click.ShouldNotBeNull();
            parametersOfdownloadContact_Click.Length.ShouldBe(2);
            methoddownloadContact_ClickParametersTypes.Length.ShouldBe(2);
            methoddownloadContact_ClickParametersTypes.Length.ShouldBe(parametersOfdownloadContact_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_downloadContact_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddownloadContact_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methoddownloadContact_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfdownloadContact_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethoddownloadContact_Click, parametersOfdownloadContact_Click, methoddownloadContact_ClickParametersTypes);

            // Assert
            parametersOfdownloadContact_Click.ShouldNotBeNull();
            parametersOfdownloadContact_Click.Length.ShouldBe(2);
            methoddownloadContact_ClickParametersTypes.Length.ShouldBe(2);
            methoddownloadContact_ClickParametersTypes.Length.ShouldBe(parametersOfdownloadContact_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_downloadContact_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddownloadContact_Click);
            var currentMethodInfo = this.GetMethodInfo(MethoddownloadContact_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_downloadContact_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddownloadContact_Click);
            var methoddownloadContact_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethoddownloadContact_Click, methoddownloadContact_ClickParametersTypes);

            // Assert
            methoddownloadContact_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (downloadContact_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_downloadContact_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddownloadContact_Click);
            var currentMethodInfo = this.GetMethodInfo(MethoddownloadContact_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addContactMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddContactMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddContactMenuItem_Click, methodaddContactMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddContactMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactMenuItem_Click, methodaddContactMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddContactMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddContactMenuItem_Click.ShouldNotBeNull();
            parametersOfaddContactMenuItem_Click.Length.ShouldBe(2);
            methodaddContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddContactMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddContactMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddContactMenuItem_Click, parametersOfaddContactMenuItem_Click, methodaddContactMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddContactMenuItem_Click.ShouldNotBeNull();
            parametersOfaddContactMenuItem_Click.Length.ShouldBe(2);
            methodaddContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddContactMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addContactMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addContactMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactMenuItem_Click);
            var methodaddContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddContactMenuItem_Click, methodaddContactMenuItem_ClickParametersTypes);

            // Assert
            methodaddContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addContactMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addContactMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddInternalContactMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddInternalContactMenuItem_Click, methodaddInternalContactMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddInternalContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddInternalContactMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactMenuItem_Click, methodaddInternalContactMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddInternalContactMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddInternalContactMenuItem_Click.ShouldNotBeNull();
            parametersOfaddInternalContactMenuItem_Click.Length.ShouldBe(2);
            methodaddInternalContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddInternalContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddInternalContactMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddInternalContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddInternalContactMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddInternalContactMenuItem_Click, parametersOfaddInternalContactMenuItem_Click, methodaddInternalContactMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddInternalContactMenuItem_Click.ShouldNotBeNull();
            parametersOfaddInternalContactMenuItem_Click.Length.ShouldBe(2);
            methodaddInternalContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddInternalContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddInternalContactMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactMenuItem_Click);
            var methodaddInternalContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddInternalContactMenuItem_Click, methodaddInternalContactMenuItem_ClickParametersTypes);

            // Assert
            methodaddInternalContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addInternalContactMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addApptMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddApptMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddApptMenuItem_Click, methodaddApptMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addApptMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddApptMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddApptMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddApptMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddApptMenuItem_Click, methodaddApptMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddApptMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddApptMenuItem_Click.ShouldNotBeNull();
            parametersOfaddApptMenuItem_Click.Length.ShouldBe(2);
            methodaddApptMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddApptMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddApptMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addApptMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddApptMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddApptMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddApptMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddApptMenuItem_Click, parametersOfaddApptMenuItem_Click, methodaddApptMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddApptMenuItem_Click.ShouldNotBeNull();
            parametersOfaddApptMenuItem_Click.Length.ShouldBe(2);
            methodaddApptMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddApptMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddApptMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addApptMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddApptMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddApptMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addApptMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddApptMenuItem_Click);
            var methodaddApptMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddApptMenuItem_Click, methodaddApptMenuItem_ClickParametersTypes);

            // Assert
            methodaddApptMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addApptMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addApptMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddApptMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddApptMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddEmailMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddEmailMenuItem_Click, methodaddEmailMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddEmailMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddEmailMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddEmailMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddEmailMenuItem_Click, methodaddEmailMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddEmailMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddEmailMenuItem_Click.ShouldNotBeNull();
            parametersOfaddEmailMenuItem_Click.Length.ShouldBe(2);
            methodaddEmailMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddEmailMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddEmailMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddEmailMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddEmailMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddEmailMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddEmailMenuItem_Click, parametersOfaddEmailMenuItem_Click, methodaddEmailMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddEmailMenuItem_Click.ShouldNotBeNull();
            parametersOfaddEmailMenuItem_Click.Length.ShouldBe(2);
            methodaddEmailMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddEmailMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddEmailMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddEmailMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddEmailMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddEmailMenuItem_Click);
            var methodaddEmailMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddEmailMenuItem_Click, methodaddEmailMenuItem_ClickParametersTypes);

            // Assert
            methodaddEmailMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addEmailMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addEmailMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddEmailMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddEmailMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddNotesMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddNotesMenuItem_Click, methodaddNotesMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNotesMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddNotesMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddNotesMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddNotesMenuItem_Click, methodaddNotesMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddNotesMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddNotesMenuItem_Click.ShouldNotBeNull();
            parametersOfaddNotesMenuItem_Click.Length.ShouldBe(2);
            methodaddNotesMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddNotesMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddNotesMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNotesMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddNotesMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddNotesMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddNotesMenuItem_Click, parametersOfaddNotesMenuItem_Click, methodaddNotesMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddNotesMenuItem_Click.ShouldNotBeNull();
            parametersOfaddNotesMenuItem_Click.Length.ShouldBe(2);
            methodaddNotesMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddNotesMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddNotesMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNotesMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddNotesMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNotesMenuItem_Click);
            var methodaddNotesMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddNotesMenuItem_Click, methodaddNotesMenuItem_ClickParametersTypes);

            // Assert
            methodaddNotesMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addNotesMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addNotesMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNotesMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddNotesMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodaddAttachmentMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddAttachmentMenuItem_Click, methodaddAttachmentMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddAttachmentMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddAttachmentMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddAttachmentMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddAttachmentMenuItem_Click, methodaddAttachmentMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfaddAttachmentMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddAttachmentMenuItem_Click.ShouldNotBeNull();
            parametersOfaddAttachmentMenuItem_Click.Length.ShouldBe(2);
            methodaddAttachmentMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddAttachmentMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddAttachmentMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddAttachmentMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddAttachmentMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddAttachmentMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddAttachmentMenuItem_Click, parametersOfaddAttachmentMenuItem_Click, methodaddAttachmentMenuItem_ClickParametersTypes);

            // Assert
            parametersOfaddAttachmentMenuItem_Click.ShouldNotBeNull();
            parametersOfaddAttachmentMenuItem_Click.Length.ShouldBe(2);
            methodaddAttachmentMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodaddAttachmentMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfaddAttachmentMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddAttachmentMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddAttachmentMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddAttachmentMenuItem_Click);
            var methodaddAttachmentMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddAttachmentMenuItem_Click, methodaddAttachmentMenuItem_ClickParametersTypes);

            // Assert
            methodaddAttachmentMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addAttachmentMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_addAttachmentMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddAttachmentMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodaddAttachmentMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodreplyWithTemplateMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodreplyWithTemplateMenuItem_Click, methodreplyWithTemplateMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreplyWithTemplateMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodreplyWithTemplateMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfreplyWithTemplateMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodreplyWithTemplateMenuItem_Click, methodreplyWithTemplateMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfreplyWithTemplateMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfreplyWithTemplateMenuItem_Click.ShouldNotBeNull();
            parametersOfreplyWithTemplateMenuItem_Click.Length.ShouldBe(2);
            methodreplyWithTemplateMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodreplyWithTemplateMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfreplyWithTemplateMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreplyWithTemplateMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodreplyWithTemplateMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfreplyWithTemplateMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodreplyWithTemplateMenuItem_Click, parametersOfreplyWithTemplateMenuItem_Click, methodreplyWithTemplateMenuItem_ClickParametersTypes);

            // Assert
            parametersOfreplyWithTemplateMenuItem_Click.ShouldNotBeNull();
            parametersOfreplyWithTemplateMenuItem_Click.Length.ShouldBe(2);
            methodreplyWithTemplateMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodreplyWithTemplateMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfreplyWithTemplateMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreplyWithTemplateMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodreplyWithTemplateMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreplyWithTemplateMenuItem_Click);
            var methodreplyWithTemplateMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodreplyWithTemplateMenuItem_Click, methodreplyWithTemplateMenuItem_ClickParametersTypes);

            // Assert
            methodreplyWithTemplateMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (replyWithTemplateMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_replyWithTemplateMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreplyWithTemplateMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodreplyWithTemplateMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateSalesOppMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateSalesOppMenuItem_Click, methodcreateSalesOppMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSalesOppMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateSalesOppMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateSalesOppMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSalesOppMenuItem_Click, methodcreateSalesOppMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfcreateSalesOppMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateSalesOppMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateSalesOppMenuItem_Click.Length.ShouldBe(2);
            methodcreateSalesOppMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateSalesOppMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateSalesOppMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSalesOppMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateSalesOppMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateSalesOppMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateSalesOppMenuItem_Click, parametersOfcreateSalesOppMenuItem_Click, methodcreateSalesOppMenuItem_ClickParametersTypes);

            // Assert
            parametersOfcreateSalesOppMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateSalesOppMenuItem_Click.Length.ShouldBe(2);
            methodcreateSalesOppMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateSalesOppMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateSalesOppMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSalesOppMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSalesOppMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSalesOppMenuItem_Click);
            var methodcreateSalesOppMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateSalesOppMenuItem_Click, methodcreateSalesOppMenuItem_ClickParametersTypes);

            // Assert
            methodcreateSalesOppMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSalesOppMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSalesOppMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSalesOppMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSalesOppMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateServiceIncMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateServiceIncMenuItem_Click, methodcreateServiceIncMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateServiceIncMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateServiceIncMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateServiceIncMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateServiceIncMenuItem_Click, methodcreateServiceIncMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfcreateServiceIncMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateServiceIncMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateServiceIncMenuItem_Click.Length.ShouldBe(2);
            methodcreateServiceIncMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateServiceIncMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateServiceIncMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateServiceIncMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateServiceIncMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateServiceIncMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateServiceIncMenuItem_Click, parametersOfcreateServiceIncMenuItem_Click, methodcreateServiceIncMenuItem_ClickParametersTypes);

            // Assert
            parametersOfcreateServiceIncMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateServiceIncMenuItem_Click.Length.ShouldBe(2);
            methodcreateServiceIncMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateServiceIncMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateServiceIncMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateServiceIncMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateServiceIncMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateServiceIncMenuItem_Click);
            var methodcreateServiceIncMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateServiceIncMenuItem_Click, methodcreateServiceIncMenuItem_ClickParametersTypes);

            // Assert
            methodcreateServiceIncMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createServiceIncMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createServiceIncMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateServiceIncMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateServiceIncMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateSupportTicketMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateSupportTicketMenuItem_Click, methodcreateSupportTicketMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSupportTicketMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateSupportTicketMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateSupportTicketMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSupportTicketMenuItem_Click, methodcreateSupportTicketMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfcreateSupportTicketMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateSupportTicketMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateSupportTicketMenuItem_Click.Length.ShouldBe(2);
            methodcreateSupportTicketMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateSupportTicketMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateSupportTicketMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSupportTicketMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateSupportTicketMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateSupportTicketMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateSupportTicketMenuItem_Click, parametersOfcreateSupportTicketMenuItem_Click, methodcreateSupportTicketMenuItem_ClickParametersTypes);

            // Assert
            parametersOfcreateSupportTicketMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateSupportTicketMenuItem_Click.Length.ShouldBe(2);
            methodcreateSupportTicketMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateSupportTicketMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateSupportTicketMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSupportTicketMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSupportTicketMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSupportTicketMenuItem_Click);
            var methodcreateSupportTicketMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateSupportTicketMenuItem_Click, methodcreateSupportTicketMenuItem_ClickParametersTypes);

            // Assert
            methodcreateSupportTicketMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createSupportTicketMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createSupportTicketMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateSupportTicketMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateSupportTicketMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateOutlookContactMenuItem_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateOutlookContactMenuItem_Click, methodcreateOutlookContactMenuItem_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOutlookContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateOutlookContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateOutlookContactMenuItem_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOutlookContactMenuItem_Click, methodcreateOutlookContactMenuItem_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfcreateOutlookContactMenuItem_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateOutlookContactMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateOutlookContactMenuItem_Click.Length.ShouldBe(2);
            methodcreateOutlookContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateOutlookContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateOutlookContactMenuItem_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOutlookContactMenuItem_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateOutlookContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateOutlookContactMenuItem_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateOutlookContactMenuItem_Click, parametersOfcreateOutlookContactMenuItem_Click, methodcreateOutlookContactMenuItem_ClickParametersTypes);

            // Assert
            parametersOfcreateOutlookContactMenuItem_Click.ShouldNotBeNull();
            parametersOfcreateOutlookContactMenuItem_Click.Length.ShouldBe(2);
            methodcreateOutlookContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateOutlookContactMenuItem_ClickParametersTypes.Length.ShouldBe(parametersOfcreateOutlookContactMenuItem_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOutlookContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOutlookContactMenuItem_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOutlookContactMenuItem_Click);
            var methodcreateOutlookContactMenuItem_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateOutlookContactMenuItem_Click, methodcreateOutlookContactMenuItem_ClickParametersTypes);

            // Assert
            methodcreateOutlookContactMenuItem_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createOutlookContactMenuItem_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_createOutlookContactMenuItem_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOutlookContactMenuItem_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOutlookContactMenuItem_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_expandCollapseButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodexpandCollapseButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodexpandCollapseButton_Click, methodexpandCollapseButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCollapseButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCollapseButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodexpandCollapseButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfexpandCollapseButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodexpandCollapseButton_Click, methodexpandCollapseButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfexpandCollapseButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfexpandCollapseButton_Click.ShouldNotBeNull();
            parametersOfexpandCollapseButton_Click.Length.ShouldBe(2);
            methodexpandCollapseButton_ClickParametersTypes.Length.ShouldBe(2);
            methodexpandCollapseButton_ClickParametersTypes.Length.ShouldBe(parametersOfexpandCollapseButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCollapseButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCollapseButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodexpandCollapseButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfexpandCollapseButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodexpandCollapseButton_Click, parametersOfexpandCollapseButton_Click, methodexpandCollapseButton_ClickParametersTypes);

            // Assert
            parametersOfexpandCollapseButton_Click.ShouldNotBeNull();
            parametersOfexpandCollapseButton_Click.Length.ShouldBe(2);
            methodexpandCollapseButton_ClickParametersTypes.Length.ShouldBe(2);
            methodexpandCollapseButton_ClickParametersTypes.Length.ShouldBe(parametersOfexpandCollapseButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCollapseButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCollapseButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodexpandCollapseButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCollapseButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCollapseButton_Click);
            var methodexpandCollapseButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodexpandCollapseButton_Click, methodexpandCollapseButton_ClickParametersTypes);

            // Assert
            methodexpandCollapseButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (expandCollapseButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCollapseButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCollapseButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodexpandCollapseButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_AddControlToTree_Method_Call_Internally(Type[] types)
        {
            var methodAddControlToTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddControlToTree, methodAddControlToTreeParametersTypes);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _titleControlInstance.AddControlToTree(parentControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddControlToTree = { parentControlId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, methodAddControlToTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfAddControlToTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddControlToTree = { parentControlId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddControlToTree, parametersOfAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_AddControlToTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (expandCustomerInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_expandCustomerInfo_Method_Call_Internally(Type[] types)
        {
            var methodexpandCustomerInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodexpandCustomerInfo, methodexpandCustomerInfoParametersTypes);
        }

        #endregion

        #region Method Call : (expandCustomerInfo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCustomerInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCustomerInfo);

            // Act
            Action executeAction = () => _titleControlInstance.expandCustomerInfo();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (expandCustomerInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCustomerInfo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCustomerInfo);
            Type [] methodexpandCustomerInfoParametersTypes = null;
            object[] parametersOfexpandCustomerInfo = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodexpandCustomerInfo, methodexpandCustomerInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfexpandCustomerInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfexpandCustomerInfo.ShouldBeNull();
            methodexpandCustomerInfoParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (expandCustomerInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCustomerInfo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCustomerInfo);
            Type [] methodexpandCustomerInfoParametersTypes = null;
            object[] parametersOfexpandCustomerInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodexpandCustomerInfo, parametersOfexpandCustomerInfo, methodexpandCustomerInfoParametersTypes);

            // Assert
            parametersOfexpandCustomerInfo.ShouldBeNull();
            methodexpandCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (expandCustomerInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCustomerInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCustomerInfo);
            Type [] methodexpandCustomerInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodexpandCustomerInfo, methodexpandCustomerInfoParametersTypes);

            // Assert
            methodexpandCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (expandCustomerInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_expandCustomerInfo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexpandCustomerInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodexpandCustomerInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_selectedCustomer_Method_Call_Internally(Type[] types)
        {
            var methodselectedCustomerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodselectedCustomer, methodselectedCustomerParametersTypes);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var primaryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _titleControlInstance.selectedCustomer(primaryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var primaryId = this.CreateType<string>();
            var methodselectedCustomerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfselectedCustomer = { primaryId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodselectedCustomer, methodselectedCustomerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfselectedCustomer);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfselectedCustomer.ShouldNotBeNull();
            parametersOfselectedCustomer.Length.ShouldBe(1);
            methodselectedCustomerParametersTypes.Length.ShouldBe(1);
            methodselectedCustomerParametersTypes.Length.ShouldBe(parametersOfselectedCustomer.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var primaryId = this.CreateType<string>();
            var methodselectedCustomerParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfselectedCustomer = { primaryId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodselectedCustomer, parametersOfselectedCustomer, methodselectedCustomerParametersTypes);

            // Assert
            parametersOfselectedCustomer.ShouldNotBeNull();
            parametersOfselectedCustomer.Length.ShouldBe(1);
            methodselectedCustomerParametersTypes.Length.ShouldBe(1);
            methodselectedCustomerParametersTypes.Length.ShouldBe(parametersOfselectedCustomer.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodselectedCustomer, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var methodselectedCustomerParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodselectedCustomer, methodselectedCustomerParametersTypes);

            // Assert
            methodselectedCustomerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (selectedCustomer) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_selectedCustomer_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodselectedCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodselectedCustomer, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodlblDupeCount_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlblDupeCount_LinkClicked, methodlblDupeCount_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlblDupeCount_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodlblDupeCount_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOflblDupeCount_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodlblDupeCount_LinkClicked, methodlblDupeCount_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOflblDupeCount_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOflblDupeCount_LinkClicked.ShouldNotBeNull();
            parametersOflblDupeCount_LinkClicked.Length.ShouldBe(2);
            methodlblDupeCount_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodlblDupeCount_LinkClickedParametersTypes.Length.ShouldBe(parametersOflblDupeCount_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlblDupeCount_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodlblDupeCount_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOflblDupeCount_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodlblDupeCount_LinkClicked, parametersOflblDupeCount_LinkClicked, methodlblDupeCount_LinkClickedParametersTypes);

            // Assert
            parametersOflblDupeCount_LinkClicked.ShouldNotBeNull();
            parametersOflblDupeCount_LinkClicked.Length.ShouldBe(2);
            methodlblDupeCount_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodlblDupeCount_LinkClickedParametersTypes.Length.ShouldBe(parametersOflblDupeCount_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlblDupeCount_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodlblDupeCount_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlblDupeCount_LinkClicked);
            var methodlblDupeCount_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlblDupeCount_LinkClicked, methodlblDupeCount_LinkClickedParametersTypes);

            // Assert
            methodlblDupeCount_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (lblDupeCount_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_lblDupeCount_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlblDupeCount_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodlblDupeCount_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_Internally(Type[] types)
        {
            var methodResetTableLayoutPanelsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _titleControlInstance.ResetTableLayoutPanels(bVisible);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_titleControlInstanceFixture, parametersOfResetTableLayoutPanels);

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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_Parameters_Count_Verification_Test()
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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        [Category("AUT MethodCallTest")]
        public void AUT_TitleControl_ResetTableLayoutPanels_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #endregion

        #endregion
    }
}