using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
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
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OutlookItemWrapper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OutlookItemWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookItemWrapper" />)
        /// </summary>
        public OutlookItemWrapperTest() : base(typeof(OutlookItemWrapper))
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

        #region General Initializer : Class (OutlookItemWrapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookItemWrapperInstanceType;
        private OutlookItemWrapper _outlookItemWrapperInstance;
        private OutlookItemWrapper _outlookItemWrapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookItemWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookItemWrapperInstanceType = typeof(OutlookItemWrapper);
            _outlookItemWrapperInstanceFixture = this.Create<OutlookItemWrapper>(false);
            _outlookItemWrapperInstance = _outlookItemWrapperInstanceFixture ?? this.Create<OutlookItemWrapper>(true);
            CurrentInstance = _outlookItemWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookItemWrapper) Initializer

        #region Properties

        private const string PropertyItem = "Item";
        private const string PropertyItemType = "ItemType";
        private const string PropertySubject = "Subject";
        private const string PropertyEntryId = "EntryId";
        private const string PropertyItemAttachments = "ItemAttachments";
        private const string PropertymailItem = "mailItem";
        private const string PropertyappointmentItem = "appointmentItem";
        private const string PropertycontactItem = "contactItem";
        private const string PropertySent = "Sent";
        private const string PropertySenderName = "SenderName";
        private const string PropertySenderEmail = "SenderEmail";
        private const string PropertyRecipients = "Recipients";
        private const string PropertySavingMessage = "SavingMessage";
        private const string PropertyInsertMessage = "InsertMessage";
        private const string PropertyNewItemGUID = "NewItemGUID";
        private const string PropertySaveToOnyx = "SaveToOnyx";

        #endregion

        #region Methods

        private const string MethodConvertRecurrencePatternToOnyx = "ConvertRecurrencePatternToOnyx";
        private const string MethodCancelSaveToOnyx = "CancelSaveToOnyx";
        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodInsertItemAsWorkNote = "InsertItemAsWorkNote";
        private const string MethodAddCategory = "AddCategory";
        private const string MethodAddUserProperty = "AddUserProperty";
        private const string MethodgetEmailAddressFromAddressEntry = "getEmailAddressFromAddressEntry";
        private const string MethodPerformPostActions = "PerformPostActions";

        #endregion

        #region Fields

        private const string Fielditem = "item";
        private const string FieldnewItemGuid = "newItemGuid";
        private const string FieldinsertMessage = "insertMessage";
        private const string FieldsaveToOnyx = "saveToOnyx";
        private const string FieldallowableActions = "allowableActions";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookItemWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookItemWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookItemWrapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookItemWrapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookItemWrapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookItemWrapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookItemWrapper)

        #region General Initializer : Class (OutlookItemWrapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodConvertRecurrencePatternToOnyx, 0)]
        [TestCase(MethodCancelSaveToOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 1)]
        [TestCase(MethodInsertInOnyx, 2)]
        [TestCase(MethodInsertItemAsWorkNote, 0)]
        [TestCase(MethodAddCategory, 0)]
        [TestCase(MethodAddUserProperty, 0)]
        [TestCase(MethodgetEmailAddressFromAddressEntry, 0)]
        [TestCase(MethodPerformPostActions, 0)]
        public void AUT_OutlookItemWrapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OutlookItemWrapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyItem)]
        [TestCase(PropertyItemType)]
        [TestCase(PropertySubject)]
        [TestCase(PropertyEntryId)]
        [TestCase(PropertyItemAttachments)]
        [TestCase(PropertymailItem)]
        [TestCase(PropertyappointmentItem)]
        [TestCase(PropertycontactItem)]
        [TestCase(PropertySent)]
        [TestCase(PropertySenderName)]
        [TestCase(PropertySenderEmail)]
        [TestCase(PropertyRecipients)]
        [TestCase(PropertySavingMessage)]
        [TestCase(PropertyInsertMessage)]
        [TestCase(PropertyNewItemGUID)]
        [TestCase(PropertySaveToOnyx)]
        [Category("AUT Property")]
        public void AUT_OutlookItemWrapper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OutlookItemWrapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fielditem)]
        [TestCase(FieldnewItemGuid)]
        [TestCase(FieldinsertMessage)]
        [TestCase(FieldsaveToOnyx)]
        [TestCase(FieldallowableActions)]
        [Category("AUT Fields")]
        public void AUT_OutlookItemWrapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookItemWrapper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookItemWrapper_Is_Instance_Present_Test()
        {
            // Assert
            _outlookItemWrapperInstanceType.ShouldNotBeNull();
            _outlookItemWrapperInstance.ShouldNotBeNull();
            _outlookItemWrapperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookItemWrapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookItemWrapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookItemWrapperInstance.ShouldBeAssignableTo<OutlookItemWrapper>();
            _outlookItemWrapperInstanceFixture.ShouldBeAssignableTo<OutlookItemWrapper>();
            CurrentInstance.ShouldBeAssignableTo<OutlookItemWrapper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookItemWrapper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OutlookItemWrapper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramItem = this.CreateType<Object>();
            OutlookItemWrapper instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookItemWrapper(paramItem);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookItemWrapperInstance.ShouldNotBeNull();
            _outlookItemWrapperInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OutlookItemWrapper>();
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramItem = this.CreateType<Object>();
            OutlookItemWrapper instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookItemWrapper(paramItem);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookItemWrapperInstance.ShouldNotBeNull();
            _outlookItemWrapperInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) instance created

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Is_Created_Test()
        {
            // Assert
            _outlookItemWrapperInstance.ShouldNotBeNull();
            _outlookItemWrapperInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OutlookItemWrapper" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OutlookItemWrapper_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OutlookItemWrapper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OutlookItemWrapper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOutlookItemWrapperParametersTypes = new Type[] { typeof(Object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOutlookItemWrapperParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OutlookItemWrapper) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OutlookItemWrapper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookItemWrapper_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodOutlookItemWrapperParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOutlookItemWrapperParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OutlookItemWrapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyItem)]
        [TestCase(PropertyItemType)]
        [TestCase(PropertySubject)]
        [TestCase(PropertyEntryId)]
        [TestCase(PropertyItemAttachments)]
        [TestCase(PropertymailItem)]
        [TestCase(PropertyappointmentItem)]
        [TestCase(PropertycontactItem)]
        [TestCase(PropertySent)]
        [TestCase(PropertySenderName)]
        [TestCase(PropertySenderEmail)]
        [TestCase(PropertyRecipients)]
        [TestCase(PropertySavingMessage)]
        [TestCase(PropertyInsertMessage)]
        [TestCase(PropertyNewItemGUID)]
        [TestCase(PropertySaveToOnyx)]
        public void AUT_OutlookItemWrapper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (appointmentItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_appointmentItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyappointmentItem);
            var propertyInfo = this.GetPropertyInfo(PropertyappointmentItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (contactItem) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_contactItem_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycontactItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertycontactItem);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (contactItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_contactItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertycontactItem);
            var propertyInfo = this.GetPropertyInfo(PropertycontactItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (EntryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_EntryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEntryId);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (EntryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_EntryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntryId);
            var propertyInfo = this.GetPropertyInfo(PropertyEntryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (InsertMessage) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_InsertMessage_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertMessage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertMessage);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (InsertMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_InsertMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var propertyInfo = this.GetPropertyInfo(PropertyItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (ItemAttachments) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_ItemAttachments_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemAttachments);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItemAttachments);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (ItemAttachments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_ItemAttachments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemAttachments);
            var propertyInfo = this.GetPropertyInfo(PropertyItemAttachments);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (ItemType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_ItemType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItemType);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (ItemType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_ItemType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemType);
            var propertyInfo = this.GetPropertyInfo(PropertyItemType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (mailItem) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_mailItem_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymailItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertymailItem);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (mailItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_mailItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymailItem);
            var propertyInfo = this.GetPropertyInfo(PropertymailItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (NewItemGUID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_NewItemGUID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNewItemGUID);
            var propertyInfo = this.GetPropertyInfo(PropertyNewItemGUID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Recipients) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Recipients_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecipients);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRecipients);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Recipients) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_Recipients_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecipients);
            var propertyInfo = this.GetPropertyInfo(PropertyRecipients);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SaveToOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_SaveToOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySaveToOnyx);
            var propertyInfo = this.GetPropertyInfo(PropertySaveToOnyx);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SavingMessage) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_SavingMessage_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySavingMessage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySavingMessage);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SavingMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_SavingMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySavingMessage);
            var propertyInfo = this.GetPropertyInfo(PropertySavingMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SenderEmail) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_SenderEmail_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySenderEmail);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySenderEmail);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SenderEmail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_SenderEmail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySenderEmail);
            var propertyInfo = this.GetPropertyInfo(PropertySenderEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SenderName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_SenderName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySenderName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySenderName);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (SenderName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_SenderName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySenderName);
            var propertyInfo = this.GetPropertyInfo(PropertySenderName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Sent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_Sent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySent);
            var propertyInfo = this.GetPropertyInfo(PropertySent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Subject) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Subject_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubject);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySubject);
            Action currentAction = () => propertyInfo.SetValue(_outlookItemWrapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemWrapper) => Property (Subject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemWrapper_Public_Class_Subject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubject);
            var propertyInfo = this.GetPropertyInfo(PropertySubject);

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

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.ConvertRecurrencePatternToOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _outlookItemWrapperInstance.ConvertRecurrencePatternToOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            Type [] methodConvertRecurrencePatternToOnyxParametersTypes = null;
            object[] parametersOfConvertRecurrencePatternToOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertRecurrencePatternToOnyx, methodConvertRecurrencePatternToOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_outlookItemWrapperInstanceFixture, parametersOfConvertRecurrencePatternToOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodConvertRecurrencePatternToOnyx, parametersOfConvertRecurrencePatternToOnyx, methodConvertRecurrencePatternToOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConvertRecurrencePatternToOnyx.ShouldBeNull();
            methodConvertRecurrencePatternToOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            Type [] methodConvertRecurrencePatternToOnyxParametersTypes = null;
            object[] parametersOfConvertRecurrencePatternToOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodConvertRecurrencePatternToOnyx, parametersOfConvertRecurrencePatternToOnyx, methodConvertRecurrencePatternToOnyxParametersTypes);

            // Assert
            parametersOfConvertRecurrencePatternToOnyx.ShouldBeNull();
            methodConvertRecurrencePatternToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            Type [] methodConvertRecurrencePatternToOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertRecurrencePatternToOnyx, methodConvertRecurrencePatternToOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertRecurrencePatternToOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            Type [] methodConvertRecurrencePatternToOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertRecurrencePatternToOnyx, methodConvertRecurrencePatternToOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertRecurrencePatternToOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertRecurrencePatternToOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_ConvertRecurrencePatternToOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertRecurrencePatternToOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertRecurrencePatternToOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_Call_Internally(Type[] types)
        {
            var methodCancelSaveToOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCancelSaveToOnyx, methodCancelSaveToOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelSaveToOnyx);

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.CancelSaveToOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelSaveToOnyx);
            Type [] methodCancelSaveToOnyxParametersTypes = null;
            object[] parametersOfCancelSaveToOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCancelSaveToOnyx, methodCancelSaveToOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemWrapperInstanceFixture, parametersOfCancelSaveToOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCancelSaveToOnyx.ShouldBeNull();
            methodCancelSaveToOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelSaveToOnyx);
            Type [] methodCancelSaveToOnyxParametersTypes = null;
            object[] parametersOfCancelSaveToOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCancelSaveToOnyx, parametersOfCancelSaveToOnyx, methodCancelSaveToOnyxParametersTypes);

            // Assert
            parametersOfCancelSaveToOnyx.ShouldBeNull();
            methodCancelSaveToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelSaveToOnyx);
            Type [] methodCancelSaveToOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCancelSaveToOnyx, methodCancelSaveToOnyxParametersTypes);

            // Assert
            methodCancelSaveToOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelSaveToOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_CancelSaveToOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelSaveToOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodCancelSaveToOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.InsertInOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var returnedValue = default(OutlookItemSaveableToOnyx);

            // Act
            Action executeAction = () => returnedValue = _outlookItemWrapperInstance.InsertInOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;
            object[] parametersOfInsertInOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OutlookItemSaveableToOnyx>(_outlookItemWrapperInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldBeNull();
            methodInsertInOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;
            object[] parametersOfInsertInOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldBeNull();
            methodInsertInOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_InsertInOnyx_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.InsertInOnyx(onyxObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var returnedValue = default(OutlookItemSaveableToOnyx);

            // Act
            Action executeAction = () => returnedValue = _outlookItemWrapperInstance.InsertInOnyx(onyxObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OutlookItemSaveableToOnyx>(_outlookItemWrapperInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_InsertInOnyx_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.InsertInOnyx(onyxObjects);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var returnedValue = default(OutlookItemSaveableToOnyx);

            // Act
            Action executeAction = () => returnedValue = _outlookItemWrapperInstance.InsertInOnyx(onyxObjects);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfInsertInOnyx = { onyxObjects };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OutlookItemSaveableToOnyx>(_outlookItemWrapperInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfInsertInOnyx = { onyxObjects };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OutlookItemSaveableToOnyx>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OutlookItemSaveableToOnyx) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertInOnyx_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_Internally(Type[] types)
        {
            var methodInsertItemAsWorkNoteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertItemAsWorkNote, methodInsertItemAsWorkNoteParametersTypes);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var obj = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.InsertItemAsWorkNote(obj);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var obj = this.CreateType<OnyxObject>();
            var methodInsertItemAsWorkNoteParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertItemAsWorkNote = { obj };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertItemAsWorkNote, methodInsertItemAsWorkNoteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemWrapperInstanceFixture, parametersOfInsertItemAsWorkNote);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertItemAsWorkNote.ShouldNotBeNull();
            parametersOfInsertItemAsWorkNote.Length.ShouldBe(1);
            methodInsertItemAsWorkNoteParametersTypes.Length.ShouldBe(1);
            methodInsertItemAsWorkNoteParametersTypes.Length.ShouldBe(parametersOfInsertItemAsWorkNote.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var obj = this.CreateType<OnyxObject>();
            var methodInsertItemAsWorkNoteParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertItemAsWorkNote = { obj };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertItemAsWorkNote, parametersOfInsertItemAsWorkNote, methodInsertItemAsWorkNoteParametersTypes);

            // Assert
            parametersOfInsertItemAsWorkNote.ShouldNotBeNull();
            parametersOfInsertItemAsWorkNote.Length.ShouldBe(1);
            methodInsertItemAsWorkNoteParametersTypes.Length.ShouldBe(1);
            methodInsertItemAsWorkNoteParametersTypes.Length.ShouldBe(parametersOfInsertItemAsWorkNote.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertItemAsWorkNote, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var methodInsertItemAsWorkNoteParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertItemAsWorkNote, methodInsertItemAsWorkNoteParametersTypes);

            // Assert
            methodInsertItemAsWorkNoteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertItemAsWorkNote) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_InsertItemAsWorkNote_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertItemAsWorkNote);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertItemAsWorkNote, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_AddCategory_Method_Call_Internally(Type[] types)
        {
            var methodAddCategoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddCategory, methodAddCategoryParametersTypes);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var categoryName = this.CreateType<string>();

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.AddCategory(categoryName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var categoryName = this.CreateType<string>();
            var methodAddCategoryParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddCategory = { categoryName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddCategory, methodAddCategoryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemWrapperInstanceFixture, parametersOfAddCategory);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddCategory.ShouldNotBeNull();
            parametersOfAddCategory.Length.ShouldBe(1);
            methodAddCategoryParametersTypes.Length.ShouldBe(1);
            methodAddCategoryParametersTypes.Length.ShouldBe(parametersOfAddCategory.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var categoryName = this.CreateType<string>();
            var methodAddCategoryParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddCategory = { categoryName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddCategory, parametersOfAddCategory, methodAddCategoryParametersTypes);

            // Assert
            parametersOfAddCategory.ShouldNotBeNull();
            parametersOfAddCategory.Length.ShouldBe(1);
            methodAddCategoryParametersTypes.Length.ShouldBe(1);
            methodAddCategoryParametersTypes.Length.ShouldBe(parametersOfAddCategory.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var currentMethodInfo = this.GetMethodInfo(MethodAddCategory, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var methodAddCategoryParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddCategory, methodAddCategoryParametersTypes);

            // Assert
            methodAddCategoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddCategory) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddCategory_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddCategory);
            var currentMethodInfo = this.GetMethodInfo(MethodAddCategory, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_Internally(Type[] types)
        {
            var methodAddUserPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddUserProperty, methodAddUserPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var propertyName = this.CreateType<string>();
            var propertyValue = this.CreateType<string>();

            // Act
            Action executeAction = () => _outlookItemWrapperInstance.AddUserProperty(propertyName, propertyValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var propertyName = this.CreateType<string>();
            var propertyValue = this.CreateType<string>();
            var methodAddUserPropertyParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfAddUserProperty = { propertyName, propertyValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddUserProperty, methodAddUserPropertyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemWrapperInstanceFixture, parametersOfAddUserProperty);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddUserProperty.ShouldNotBeNull();
            parametersOfAddUserProperty.Length.ShouldBe(2);
            methodAddUserPropertyParametersTypes.Length.ShouldBe(2);
            methodAddUserPropertyParametersTypes.Length.ShouldBe(parametersOfAddUserProperty.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var propertyName = this.CreateType<string>();
            var propertyValue = this.CreateType<string>();
            var methodAddUserPropertyParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfAddUserProperty = { propertyName, propertyValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddUserProperty, parametersOfAddUserProperty, methodAddUserPropertyParametersTypes);

            // Assert
            parametersOfAddUserProperty.ShouldNotBeNull();
            parametersOfAddUserProperty.Length.ShouldBe(2);
            methodAddUserPropertyParametersTypes.Length.ShouldBe(2);
            methodAddUserPropertyParametersTypes.Length.ShouldBe(parametersOfAddUserProperty.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddUserProperty, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var methodAddUserPropertyParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddUserProperty, methodAddUserPropertyParametersTypes);

            // Assert
            methodAddUserPropertyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUserProperty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_AddUserProperty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUserProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodAddUserProperty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_Internally(Type[] types)
        {
            var methodgetEmailAddressFromAddressEntryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var methodgetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            object[] parametersOfgetEmailAddressFromAddressEntry = { addressEntry };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_outlookItemWrapperInstanceFixture, parametersOfgetEmailAddressFromAddressEntry);
            var result2 = this.GetResultOfMethod<String>(MethodgetEmailAddressFromAddressEntry, parametersOfgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetEmailAddressFromAddressEntry.ShouldNotBeNull();
            parametersOfgetEmailAddressFromAddressEntry.Length.ShouldBe(1);
            methodgetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var methodgetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            object[] parametersOfgetEmailAddressFromAddressEntry = { addressEntry };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookItemWrapperInstanceFixture, parametersOfgetEmailAddressFromAddressEntry);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfgetEmailAddressFromAddressEntry.ShouldNotBeNull();
            parametersOfgetEmailAddressFromAddressEntry.Length.ShouldBe(1);
            methodgetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var addressEntry = this.CreateType<Outlook.AddressEntry>();
            var methodgetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            object[] parametersOfgetEmailAddressFromAddressEntry = { addressEntry };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetEmailAddressFromAddressEntry, parametersOfgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            parametersOfgetEmailAddressFromAddressEntry.ShouldNotBeNull();
            parametersOfgetEmailAddressFromAddressEntry.Length.ShouldBe(1);
            methodgetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var methodgetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var methodgetEmailAddressFromAddressEntryParametersTypes = new Type[] { typeof(Outlook.AddressEntry) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetEmailAddressFromAddressEntry, methodgetEmailAddressFromAddressEntryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetEmailAddressFromAddressEntryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodgetEmailAddressFromAddressEntry, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getEmailAddressFromAddressEntry) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_getEmailAddressFromAddressEntry_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetEmailAddressFromAddressEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodgetEmailAddressFromAddressEntry, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PerformPostActions) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookItemWrapper_PerformPostActions_Method_Call_Internally(Type[] types)
        {
            var methodPerformPostActionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPerformPostActions, methodPerformPostActionsParametersTypes);
        }

        #endregion
        
        #region Method Call : (PerformPostActions) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_PerformPostActions_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformPostActions);
            Type [] methodPerformPostActionsParametersTypes = null;
            object[] parametersOfPerformPostActions = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPerformPostActions, parametersOfPerformPostActions, methodPerformPostActionsParametersTypes);

            // Assert
            parametersOfPerformPostActions.ShouldBeNull();
            methodPerformPostActionsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PerformPostActions) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_PerformPostActions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformPostActions);
            Type [] methodPerformPostActionsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPerformPostActions, methodPerformPostActionsParametersTypes);

            // Assert
            methodPerformPostActionsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PerformPostActions) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OutlookItemWrapper_PerformPostActions_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformPostActions);
            var currentMethodInfo = this.GetMethodInfo(MethodPerformPostActions, 0);

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