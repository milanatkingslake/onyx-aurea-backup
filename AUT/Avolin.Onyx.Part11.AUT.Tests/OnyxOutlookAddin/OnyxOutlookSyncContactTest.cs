using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxOutlookSyncContact" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookSyncContactTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookSyncContact" />)
        /// </summary>
        public OnyxOutlookSyncContactTest() : base(typeof(OnyxOutlookSyncContact))
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

        #region General Initializer : Class (OnyxOutlookSyncContact) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookSyncContactInstanceType;
        private OnyxOutlookSyncContact _onyxOutlookSyncContactInstance;
        private OnyxOutlookSyncContact _onyxOutlookSyncContactInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookSyncContact" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookSyncContactInstanceType = typeof(OnyxOutlookSyncContact);
            _onyxOutlookSyncContactInstanceFixture = this.Create<OnyxOutlookSyncContact>(false);
            _onyxOutlookSyncContactInstance = _onyxOutlookSyncContactInstanceFixture ?? this.Create<OnyxOutlookSyncContact>(true);
            CurrentInstance = _onyxOutlookSyncContactInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookSyncContact) Initializer

        #region Properties

        private const string PropertyIsOnyxCustomerDirty = "IsOnyxCustomerDirty";
        private const string PropertyIsOutlookContactDirty = "IsOutlookContactDirty";
        private const string PropertyItemExistsInOnyx = "ItemExistsInOnyx";
        private const string PropertySavedAttachments = "SavedAttachments";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySyncedOnyxCustomer = "SyncedOnyxCustomer";
        private const string PropertySyncedOutlookContact = "SyncedOutlookContact";

        #endregion

        #region Methods

        private const string MethodgetOutlookPropertyValue = "getOutlookPropertyValue";
        private const string MethodmapToOutlookValue = "mapToOutlookValue";
        private const string MethodupdateOutlookContactFromReturnValues = "updateOutlookContactFromReturnValues";
        private const string MethodSyncContact = "SyncContact";
        private const string MethodlocateMatchingOutlookContact = "locateMatchingOutlookContact";
        private const string MethodfindContactFromEntryId = "findContactFromEntryId";
        private const string MethodupdateOnyxLastSyncDate = "updateOnyxLastSyncDate";
        private const string MethodinsertAssociationIntoOnyx = "insertAssociationIntoOnyx";
        private const string MethodRetrieveOutlookContactPropsToSync = "RetrieveOutlookContactPropsToSync";
        private const string MethodretrieveFromOnyx = "retrieveFromOnyx";

        #endregion

        #region Fields

        private const string FieldcontactPrimaryId = "contactPrimaryId";
        private const string FieldsyncByUser = "syncByUser";
        private const string FieldsyncedOutlookContact = "syncedOutlookContact";
        private const string FieldsyncedCustomer = "syncedCustomer";
        private const string FieldoutlookSyncTimestamp = "outlookSyncTimestamp";
        private const string FieldonyxSyncTimestamp = "onyxSyncTimestamp";
        private const string FieldisExists = "isExists";
        private const string FieldsavedAttachments = "savedAttachments";
        private const string FieldoutlookContactSyncProperties = "outlookContactSyncProperties";
        private const string FieldcontactPropertiesRetrievedEvent = "contactPropertiesRetrievedEvent";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookSyncContact) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookSyncContact_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookSyncContact) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookSyncContact_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookSyncContact) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookSyncContact_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookSyncContact)

        #region General Initializer : Class (OnyxOutlookSyncContact) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodgetOutlookPropertyValue, 0)]
        [TestCase(MethodmapToOutlookValue, 0)]
        [TestCase(MethodupdateOutlookContactFromReturnValues, 0)]
        [TestCase(MethodSyncContact, 0)]
        [TestCase(MethodlocateMatchingOutlookContact, 0)]
        [TestCase(MethodfindContactFromEntryId, 0)]
        [TestCase(MethodupdateOnyxLastSyncDate, 0)]
        [TestCase(MethodinsertAssociationIntoOnyx, 0)]
        [TestCase(MethodRetrieveOutlookContactPropsToSync, 0)]
        [TestCase(MethodretrieveFromOnyx, 0)]
        public void AUT_OnyxOutlookSyncContact_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOutlookSyncContact) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsOnyxCustomerDirty)]
        [TestCase(PropertyIsOutlookContactDirty)]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySyncedOnyxCustomer)]
        [TestCase(PropertySyncedOutlookContact)]
        [Category("AUT Property")]
        public void AUT_OnyxOutlookSyncContact_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOutlookSyncContact) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcontactPrimaryId)]
        [TestCase(FieldsyncByUser)]
        [TestCase(FieldsyncedOutlookContact)]
        [TestCase(FieldsyncedCustomer)]
        [TestCase(FieldoutlookSyncTimestamp)]
        [TestCase(FieldonyxSyncTimestamp)]
        [TestCase(FieldisExists)]
        [TestCase(FieldsavedAttachments)]
        [TestCase(FieldoutlookContactSyncProperties)]
        [TestCase(FieldcontactPropertiesRetrievedEvent)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookSyncContact_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookSyncContact) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookSyncContact" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookSyncContact_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookSyncContactInstance.ShouldBeAssignableTo<OnyxOutlookSyncContact>();
            _onyxOutlookSyncContactInstanceFixture.ShouldBeAssignableTo<OnyxOutlookSyncContact>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookSyncContact>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsOnyxCustomerDirty)]
        [TestCase(PropertyIsOutlookContactDirty)]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySyncedOnyxCustomer)]
        [TestCase(PropertySyncedOutlookContact)]
        public void AUT_OnyxOutlookSyncContact_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (IsOnyxCustomerDirty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_IsOnyxCustomerDirty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsOnyxCustomerDirty);
            var propertyInfo = this.GetPropertyInfo(PropertyIsOnyxCustomerDirty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (IsOutlookContactDirty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_IsOutlookContactDirty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsOutlookContactDirty);
            var propertyInfo = this.GetPropertyInfo(PropertyIsOutlookContactDirty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (ItemExistsInOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_ItemExistsInOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (PrimaryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_PrimaryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookSyncContactInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (SavedAttachments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_SavedAttachments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySavedAttachments);
            var propertyInfo = this.GetPropertyInfo(PropertySavedAttachments);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (SyncedOnyxCustomer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_SyncedOnyxCustomer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySyncedOnyxCustomer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySyncedOnyxCustomer);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookSyncContactInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (SyncedOnyxCustomer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_SyncedOnyxCustomer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySyncedOnyxCustomer);
            var propertyInfo = this.GetPropertyInfo(PropertySyncedOnyxCustomer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookSyncContact) => Property (SyncedOutlookContact) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookSyncContact_Public_Class_SyncedOutlookContact_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySyncedOutlookContact);
            var propertyInfo = this.GetPropertyInfo(PropertySyncedOutlookContact);

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

        #region Method Call : (getOutlookPropertyValue) (Return Type : dynamic) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_getOutlookPropertyValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOutlookPropertyValue);
            var propertyName = this.CreateType<string>();
            var methodgetOutlookPropertyValueParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetOutlookPropertyValue = { propertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<dynamic>(MethodgetOutlookPropertyValue, parametersOfgetOutlookPropertyValue, methodgetOutlookPropertyValueParametersTypes);

            // Assert
            parametersOfgetOutlookPropertyValue.ShouldNotBeNull();
            parametersOfgetOutlookPropertyValue.Length.ShouldBe(1);
            methodgetOutlookPropertyValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getOutlookPropertyValue) (Return Type : dynamic) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_getOutlookPropertyValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOutlookPropertyValue);
            var methodgetOutlookPropertyValueParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetOutlookPropertyValue, methodgetOutlookPropertyValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetOutlookPropertyValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getOutlookPropertyValue) (Return Type : dynamic) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_getOutlookPropertyValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOutlookPropertyValue);
            var methodgetOutlookPropertyValueParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetOutlookPropertyValue, methodgetOutlookPropertyValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetOutlookPropertyValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getOutlookPropertyValue) (Return Type : dynamic) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_getOutlookPropertyValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOutlookPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetOutlookPropertyValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getOutlookPropertyValue) (Return Type : dynamic) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_getOutlookPropertyValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetOutlookPropertyValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetOutlookPropertyValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_Internally(Type[] types)
        {
            var methodmapToOutlookValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodmapToOutlookValue, methodmapToOutlookValueParametersTypes);
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmapToOutlookValue);
            var propName = this.CreateType<string>();
            var propVal = this.CreateType<string>();
            var methodmapToOutlookValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfmapToOutlookValue = { propName, propVal };

            // Act
            Action currentAction = () => this.GetResultOfMethod<dynamic>(MethodmapToOutlookValue, parametersOfmapToOutlookValue, methodmapToOutlookValueParametersTypes);

            // Assert
            parametersOfmapToOutlookValue.ShouldNotBeNull();
            parametersOfmapToOutlookValue.Length.ShouldBe(2);
            methodmapToOutlookValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmapToOutlookValue);
            var methodmapToOutlookValueParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodmapToOutlookValue, methodmapToOutlookValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodmapToOutlookValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmapToOutlookValue);
            var methodmapToOutlookValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodmapToOutlookValue, methodmapToOutlookValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodmapToOutlookValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmapToOutlookValue);
            var currentMethodInfo = this.GetMethodInfo(MethodmapToOutlookValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (mapToOutlookValue) (Return Type : dynamic) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_mapToOutlookValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmapToOutlookValue);
            var currentMethodInfo = this.GetMethodInfo(MethodmapToOutlookValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_Internally(Type[] types)
        {
            var methodupdateOutlookContactFromReturnValuesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodupdateOutlookContactFromReturnValues, methodupdateOutlookContactFromReturnValuesParametersTypes);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOutlookContactFromReturnValues);
            var returnValues = this.CreateType<Dictionary<String, String>>();
            var methodupdateOutlookContactFromReturnValuesParametersTypes = new Type[] { typeof(Dictionary<String, String>) };
            object[] parametersOfupdateOutlookContactFromReturnValues = { returnValues };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOutlookContactFromReturnValues, methodupdateOutlookContactFromReturnValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOutlookSyncContactInstanceFixture, parametersOfupdateOutlookContactFromReturnValues);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfupdateOutlookContactFromReturnValues.ShouldNotBeNull();
            parametersOfupdateOutlookContactFromReturnValues.Length.ShouldBe(1);
            methodupdateOutlookContactFromReturnValuesParametersTypes.Length.ShouldBe(1);
            methodupdateOutlookContactFromReturnValuesParametersTypes.Length.ShouldBe(parametersOfupdateOutlookContactFromReturnValues.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOutlookContactFromReturnValues);
            var returnValues = this.CreateType<Dictionary<String, String>>();
            var methodupdateOutlookContactFromReturnValuesParametersTypes = new Type[] { typeof(Dictionary<String, String>) };
            object[] parametersOfupdateOutlookContactFromReturnValues = { returnValues };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodupdateOutlookContactFromReturnValues, parametersOfupdateOutlookContactFromReturnValues, methodupdateOutlookContactFromReturnValuesParametersTypes);

            // Assert
            parametersOfupdateOutlookContactFromReturnValues.ShouldNotBeNull();
            parametersOfupdateOutlookContactFromReturnValues.Length.ShouldBe(1);
            methodupdateOutlookContactFromReturnValuesParametersTypes.Length.ShouldBe(1);
            methodupdateOutlookContactFromReturnValuesParametersTypes.Length.ShouldBe(parametersOfupdateOutlookContactFromReturnValues.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOutlookContactFromReturnValues);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOutlookContactFromReturnValues, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOutlookContactFromReturnValues);
            var methodupdateOutlookContactFromReturnValuesParametersTypes = new Type[] { typeof(Dictionary<String, String>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodupdateOutlookContactFromReturnValues, methodupdateOutlookContactFromReturnValuesParametersTypes);

            // Assert
            methodupdateOutlookContactFromReturnValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOutlookContactFromReturnValues) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOutlookContactFromReturnValues_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOutlookContactFromReturnValues);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOutlookContactFromReturnValues, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_Internally(Type[] types)
        {
            var methodSyncContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSyncContact, methodSyncContactParametersTypes);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);

            // Act
            Action executeAction = () => _onyxOutlookSyncContactInstance.SyncContact();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var returnedValue = default(List<String>);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookSyncContactInstance.SyncContact();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            Type [] methodSyncContactParametersTypes = null;
            object[] parametersOfSyncContact = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, methodSyncContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<String>>(_onyxOutlookSyncContactInstanceFixture, parametersOfSyncContact);
            var result2 = this.GetResultOfMethod<List<String>>(MethodSyncContact, parametersOfSyncContact, methodSyncContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSyncContact.ShouldBeNull();
            methodSyncContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            Type [] methodSyncContactParametersTypes = null;
            object[] parametersOfSyncContact = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<String>>(MethodSyncContact, parametersOfSyncContact, methodSyncContactParametersTypes);

            // Assert
            parametersOfSyncContact.ShouldBeNull();
            methodSyncContactParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            Type [] methodSyncContactParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSyncContact, methodSyncContactParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSyncContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            Type [] methodSyncContactParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSyncContact, methodSyncContactParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSyncContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SyncContact) (Return Type : List<String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_SyncContact_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSyncContact);
            var currentMethodInfo = this.GetMethodInfo(MethodSyncContact, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_Internally(Type[] types)
        {
            var methodlocateMatchingOutlookContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes);
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var returnValues = this.CreateType<Dictionary<String, String>>();
            var methodlocateMatchingOutlookContactParametersTypes = new Type[] { typeof(Dictionary<String, String>) };
            object[] parametersOflocateMatchingOutlookContact = { returnValues };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Outlook.ContactItem>(_onyxOutlookSyncContactInstanceFixture, parametersOflocateMatchingOutlookContact);
            var result2 = this.GetResultOfMethod<Outlook.ContactItem>(MethodlocateMatchingOutlookContact, parametersOflocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOflocateMatchingOutlookContact.ShouldNotBeNull();
            parametersOflocateMatchingOutlookContact.Length.ShouldBe(1);
            methodlocateMatchingOutlookContactParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var returnValues = this.CreateType<Dictionary<String, String>>();
            var methodlocateMatchingOutlookContactParametersTypes = new Type[] { typeof(Dictionary<String, String>) };
            object[] parametersOflocateMatchingOutlookContact = { returnValues };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.ContactItem>(MethodlocateMatchingOutlookContact, parametersOflocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes);

            // Assert
            parametersOflocateMatchingOutlookContact.ShouldNotBeNull();
            parametersOflocateMatchingOutlookContact.Length.ShouldBe(1);
            methodlocateMatchingOutlookContactParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var methodlocateMatchingOutlookContactParametersTypes = new Type[] { typeof(Dictionary<String, String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodlocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodlocateMatchingOutlookContactParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var methodlocateMatchingOutlookContactParametersTypes = new Type[] { typeof(Dictionary<String, String>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlocateMatchingOutlookContact, methodlocateMatchingOutlookContactParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodlocateMatchingOutlookContactParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingOutlookContact, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (locateMatchingOutlookContact) (Return Type : Outlook.ContactItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_locateMatchingOutlookContact_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlocateMatchingOutlookContact);
            var currentMethodInfo = this.GetMethodInfo(MethodlocateMatchingOutlookContact, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_Internally(Type[] types)
        {
            var methodfindContactFromEntryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodfindContactFromEntryId, methodfindContactFromEntryIdParametersTypes);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var contactEntryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOutlookSyncContactInstance.findContactFromEntryId(contactEntryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var contactEntryId = this.CreateType<string>();
            var returnedValue = default(Outlook.ContactItem);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookSyncContactInstance.findContactFromEntryId(contactEntryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var contactEntryId = this.CreateType<string>();
            var methodfindContactFromEntryIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOffindContactFromEntryId = { contactEntryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodfindContactFromEntryId, methodfindContactFromEntryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Outlook.ContactItem>(_onyxOutlookSyncContactInstanceFixture, parametersOffindContactFromEntryId);
            var result2 = this.GetResultOfMethod<Outlook.ContactItem>(MethodfindContactFromEntryId, parametersOffindContactFromEntryId, methodfindContactFromEntryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOffindContactFromEntryId.ShouldNotBeNull();
            parametersOffindContactFromEntryId.Length.ShouldBe(1);
            methodfindContactFromEntryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var contactEntryId = this.CreateType<string>();
            var methodfindContactFromEntryIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOffindContactFromEntryId = { contactEntryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.ContactItem>(MethodfindContactFromEntryId, parametersOffindContactFromEntryId, methodfindContactFromEntryIdParametersTypes);

            // Assert
            parametersOffindContactFromEntryId.ShouldNotBeNull();
            parametersOffindContactFromEntryId.Length.ShouldBe(1);
            methodfindContactFromEntryIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var methodfindContactFromEntryIdParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodfindContactFromEntryId, methodfindContactFromEntryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodfindContactFromEntryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var methodfindContactFromEntryIdParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodfindContactFromEntryId, methodfindContactFromEntryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodfindContactFromEntryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var currentMethodInfo = this.GetMethodInfo(MethodfindContactFromEntryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (findContactFromEntryId) (Return Type : Outlook.ContactItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_findContactFromEntryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactFromEntryId);
            var currentMethodInfo = this.GetMethodInfo(MethodfindContactFromEntryId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateOnyxLastSyncDate) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_updateOnyxLastSyncDate_Method_Call_Internally(Type[] types)
        {
            var methodupdateOnyxLastSyncDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodupdateOnyxLastSyncDate, methodupdateOnyxLastSyncDateParametersTypes);
        }

        #endregion

        #region Method Call : (updateOnyxLastSyncDate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOnyxLastSyncDate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxLastSyncDate);
            Type [] methodupdateOnyxLastSyncDateParametersTypes = null;
            object[] parametersOfupdateOnyxLastSyncDate = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOnyxLastSyncDate, methodupdateOnyxLastSyncDateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOutlookSyncContactInstanceFixture, parametersOfupdateOnyxLastSyncDate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfupdateOnyxLastSyncDate.ShouldBeNull();
            methodupdateOnyxLastSyncDateParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxLastSyncDate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOnyxLastSyncDate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxLastSyncDate);
            Type [] methodupdateOnyxLastSyncDateParametersTypes = null;
            object[] parametersOfupdateOnyxLastSyncDate = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodupdateOnyxLastSyncDate, parametersOfupdateOnyxLastSyncDate, methodupdateOnyxLastSyncDateParametersTypes);

            // Assert
            parametersOfupdateOnyxLastSyncDate.ShouldBeNull();
            methodupdateOnyxLastSyncDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxLastSyncDate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOnyxLastSyncDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxLastSyncDate);
            Type [] methodupdateOnyxLastSyncDateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodupdateOnyxLastSyncDate, methodupdateOnyxLastSyncDateParametersTypes);

            // Assert
            methodupdateOnyxLastSyncDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateOnyxLastSyncDate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_updateOnyxLastSyncDate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateOnyxLastSyncDate);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateOnyxLastSyncDate, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_Internally(Type[] types)
        {
            var methodinsertAssociationIntoOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            Type [] methodinsertAssociationIntoOnyxParametersTypes = null;
            object[] parametersOfinsertAssociationIntoOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxOutlookSyncContactInstanceFixture, parametersOfinsertAssociationIntoOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodinsertAssociationIntoOnyx, parametersOfinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfinsertAssociationIntoOnyx.ShouldBeNull();
            methodinsertAssociationIntoOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            Type [] methodinsertAssociationIntoOnyxParametersTypes = null;
            object[] parametersOfinsertAssociationIntoOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodinsertAssociationIntoOnyx, parametersOfinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            parametersOfinsertAssociationIntoOnyx.ShouldBeNull();
            methodinsertAssociationIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            Type [] methodinsertAssociationIntoOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodinsertAssociationIntoOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinsertAssociationIntoOnyx);
            Type [] methodinsertAssociationIntoOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinsertAssociationIntoOnyx, methodinsertAssociationIntoOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodinsertAssociationIntoOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (insertAssociationIntoOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_insertAssociationIntoOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveOutlookContactPropsToSyncParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveOutlookContactPropsToSync, methodRetrieveOutlookContactPropsToSyncParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveOutlookContactPropsToSync);

            // Act
            Action executeAction = () => OnyxOutlookSyncContact.RetrieveOutlookContactPropsToSync();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveOutlookContactPropsToSync);
            Type [] methodRetrieveOutlookContactPropsToSyncParametersTypes = null;
            object[] parametersOfRetrieveOutlookContactPropsToSync = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveOutlookContactPropsToSync, methodRetrieveOutlookContactPropsToSyncParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOutlookSyncContactInstanceFixture, parametersOfRetrieveOutlookContactPropsToSync);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRetrieveOutlookContactPropsToSync.ShouldBeNull();
            methodRetrieveOutlookContactPropsToSyncParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveOutlookContactPropsToSync);
            Type [] methodRetrieveOutlookContactPropsToSyncParametersTypes = null;
            object[] parametersOfRetrieveOutlookContactPropsToSync = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRetrieveOutlookContactPropsToSync, parametersOfRetrieveOutlookContactPropsToSync, methodRetrieveOutlookContactPropsToSyncParametersTypes);

            // Assert
            parametersOfRetrieveOutlookContactPropsToSync.ShouldBeNull();
            methodRetrieveOutlookContactPropsToSyncParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveOutlookContactPropsToSync);
            Type [] methodRetrieveOutlookContactPropsToSyncParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveOutlookContactPropsToSync, methodRetrieveOutlookContactPropsToSyncParametersTypes);

            // Assert
            methodRetrieveOutlookContactPropsToSyncParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveOutlookContactPropsToSync) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_RetrieveOutlookContactPropsToSync_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveOutlookContactPropsToSync);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveOutlookContactPropsToSync, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOutlookSyncContact_retrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodretrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_retrieveFromOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOutlookSyncContactInstanceFixture, parametersOfretrieveFromOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_retrieveFromOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookSyncContact_retrieveFromOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, 0);

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