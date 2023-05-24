using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxAppointment" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxAppointmentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxAppointment" />)
        /// </summary>
        public OnyxAppointmentTest() : base(typeof(OnyxAppointment))
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

        #region General Initializer : Class (OnyxAppointment) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxAppointmentInstanceType;
        private OnyxAppointment _onyxAppointmentInstance;
        private OnyxAppointment _onyxAppointmentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxAppointment" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxAppointmentInstanceType = typeof(OnyxAppointment);
            _onyxAppointmentInstanceFixture = this.Create<OnyxAppointment>(false);
            _onyxAppointmentInstance = _onyxAppointmentInstanceFixture ?? this.Create<OnyxAppointment>(true);
            CurrentInstance = _onyxAppointmentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxAppointment) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyHeading = "Heading";
        private const string PropertyItemExistsInOnyx = "ItemExistsInOnyx";
        private const string PropertySavedAttachments = "SavedAttachments";
        private const string PropertyPrimaryLBO = "PrimaryLBO";

        #endregion

        #region Methods

        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodAddAppointmentAssociations = "AddAppointmentAssociations";

        #endregion

        #region Fields

        private const string FieldaddToAllRecipients = "addToAllRecipients";
        private const string FieldoutlookAppt = "outlookAppt";
        private const string FieldisExists = "isExists";
        private const string FieldsavedAttachments = "savedAttachments";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxAppointment) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppointment_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAppointment) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppointment_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAppointment) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppointment_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxAppointment)

        #region General Initializer : Class (OnyxAppointment) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 1)]
        [TestCase(MethodInsertInOnyx, 2)]
        [TestCase(MethodAddAppointmentAssociations, 0)]
        public void AUT_OnyxAppointment_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxAppointment) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyPrimaryLBO)]
        [Category("AUT Property")]
        public void AUT_OnyxAppointment_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxAppointment) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldaddToAllRecipients)]
        [TestCase(FieldoutlookAppt)]
        [TestCase(FieldisExists)]
        [TestCase(FieldsavedAttachments)]
        [Category("AUT Fields")]
        public void AUT_OnyxAppointment_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxAppointment) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAppointment_Is_Instance_Present_Test()
        {
            // Assert
            _onyxAppointmentInstanceType.ShouldNotBeNull();
            _onyxAppointmentInstance.ShouldNotBeNull();
            _onyxAppointmentInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxAppointment) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxAppointment" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAppointment_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxAppointmentInstance.ShouldBeAssignableTo<OnyxAppointment>();
            _onyxAppointmentInstanceFixture.ShouldBeAssignableTo<OnyxAppointment>();
            CurrentInstance.ShouldBeAssignableTo<OnyxAppointment>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxAppointment) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxAppointment_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramOutlookAppt = this.CreateType<Outlook.AppointmentItem>();
            OnyxAppointment instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxAppointment(paramOutlookAppt);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxAppointmentInstance.ShouldNotBeNull();
            _onyxAppointmentInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxAppointment>();
        }

        #endregion

        #region General Constructor : Class (OnyxAppointment) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxAppointment_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramOutlookAppt = this.CreateType<Outlook.AppointmentItem>();
            OnyxAppointment instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxAppointment(paramOutlookAppt);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxAppointmentInstance.ShouldNotBeNull();
            _onyxAppointmentInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxAppointment) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyPrimaryLBO)]
        public void AUT_OnyxAppointment_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxAppointment) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeading);
            var propertyInfo = this.GetPropertyInfo(PropertyHeading);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppointment) => Property (ItemExistsInOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_Public_Class_ItemExistsInOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxAppointment) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxAppointmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppointment) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppointment) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxAppointmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppointment) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppointment) => Property (SavedAttachments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppointment_Public_Class_SavedAttachments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);

            // Act
            Action executeAction = () => _onyxAppointmentInstance.InsertInOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxAppointmentInstance.InsertInOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;
            object[] parametersOfInsertInOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxAppointmentInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldBeNull();
            methodInsertInOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;
            object[] parametersOfInsertInOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldBeNull();
            methodInsertInOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAppointment_InsertInOnyx_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxAppointmentInstance.InsertInOnyx(onyxObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxAppointmentInstance.InsertInOnyx(onyxObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxAppointmentInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

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

        #region Method Call : (InsertInOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAppointment_InsertInOnyx_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();

            // Act
            Action executeAction = () => _onyxAppointmentInstance.InsertInOnyx(onyxObjects);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxAppointmentInstance.InsertInOnyx(onyxObjects);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfInsertInOnyx = { onyxObjects };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxAppointmentInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

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

        #region Method Call : (InsertInOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfInsertInOnyx = { onyxObjects };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_InsertInOnyx_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
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

        #region Method Call : (AddAppointmentAssociations) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAppointment_AddAppointmentAssociations_Method_Call_Internally(Type[] types)
        {
            var methodAddAppointmentAssociationsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddAppointmentAssociations, methodAddAppointmentAssociationsParametersTypes);
        }

        #endregion
        
        #region Method Call : (AddAppointmentAssociations) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_AddAppointmentAssociations_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAppointmentAssociations);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodAddAppointmentAssociationsParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfAddAppointmentAssociations = { onyxObjects };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddAppointmentAssociations, parametersOfAddAppointmentAssociations, methodAddAppointmentAssociationsParametersTypes);

            // Assert
            parametersOfAddAppointmentAssociations.ShouldNotBeNull();
            parametersOfAddAppointmentAssociations.Length.ShouldBe(1);
            methodAddAppointmentAssociationsParametersTypes.Length.ShouldBe(1);
            methodAddAppointmentAssociationsParametersTypes.Length.ShouldBe(parametersOfAddAppointmentAssociations.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddAppointmentAssociations) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_AddAppointmentAssociations_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAppointmentAssociations);
            var currentMethodInfo = this.GetMethodInfo(MethodAddAppointmentAssociations, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddAppointmentAssociations) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_AddAppointmentAssociations_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAppointmentAssociations);
            var methodAddAppointmentAssociationsParametersTypes = new Type[] { typeof(List<OnyxObject>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddAppointmentAssociations, methodAddAppointmentAssociationsParametersTypes);

            // Assert
            methodAddAppointmentAssociationsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddAppointmentAssociations) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppointment_AddAppointmentAssociations_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAppointmentAssociations);
            var currentMethodInfo = this.GetMethodInfo(MethodAddAppointmentAssociations, 0);

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