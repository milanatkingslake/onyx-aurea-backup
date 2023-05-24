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
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxEmailMessage" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxEmailMessageTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxEmailMessage" />)
        /// </summary>
        public OnyxEmailMessageTest() : base(typeof(OnyxEmailMessage))
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

        #region General Initializer : Class (OnyxEmailMessage) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxEmailMessageInstanceType;
        private OnyxEmailMessage _onyxEmailMessageInstance;
        private OnyxEmailMessage _onyxEmailMessageInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxEmailMessage" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxEmailMessageInstanceType = typeof(OnyxEmailMessage);
            _onyxEmailMessageInstanceFixture = this.Create<OnyxEmailMessage>(false);
            _onyxEmailMessageInstance = _onyxEmailMessageInstanceFixture ?? this.Create<OnyxEmailMessage>(true);
            CurrentInstance = _onyxEmailMessageInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxEmailMessage) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyHeading = "Heading";
        private const string PropertyItemExistsInOnyx = "ItemExistsInOnyx";
        private const string PropertySavedAttachments = "SavedAttachments";
        private const string PropertyPrimaryLBO = "PrimaryLBO";

        #endregion

        #region Methods

        private const string MethodRetrieveThreadIdFromOnyx = "RetrieveThreadIdFromOnyx";
        private const string MethodSearchForThreadId = "SearchForThreadId";
        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodAddEmailAssociations = "AddEmailAssociations";

        #endregion

        #region Fields

        private const string FieldaddToAllRecipients = "addToAllRecipients";
        private const string FieldoutlookMail = "outlookMail";
        private const string FieldthreadId = "threadId";
        private const string FieldisExists = "isExists";
        private const string FieldsavedAttachments = "savedAttachments";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxEmailMessage) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailMessage_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEmailMessage) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailMessage_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEmailMessage) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailMessage_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxEmailMessage)

        #region General Initializer : Class (OnyxEmailMessage) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 1)]
        [TestCase(MethodInsertInOnyx, 2)]
        [TestCase(MethodAddEmailAssociations, 0)]
        public void AUT_OnyxEmailMessage_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxEmailMessage) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify properties for coverage gain.
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
        public void AUT_OnyxEmailMessage_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxEmailMessage) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldaddToAllRecipients)]
        [TestCase(FieldoutlookMail)]
        [TestCase(FieldisExists)]
        [TestCase(FieldsavedAttachments)]
        [Category("AUT Fields")]
        public void AUT_OnyxEmailMessage_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxEmailMessage) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxEmailMessage" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEmailMessage_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxEmailMessageInstance.ShouldBeAssignableTo<OnyxEmailMessage>();
            _onyxEmailMessageInstanceFixture.ShouldBeAssignableTo<OnyxEmailMessage>();
            CurrentInstance.ShouldBeAssignableTo<OnyxEmailMessage>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxEmailMessage) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyItemExistsInOnyx)]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyPrimaryLBO)]
        public void AUT_OnyxEmailMessage_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (ItemExistsInOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_Public_Class_ItemExistsInOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxEmailMessageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxEmailMessageInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxEmailMessage) => Property (SavedAttachments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailMessage_Public_Class_SavedAttachments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);

            // Act
            Action executeAction = () => _onyxEmailMessageInstance.InsertInOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxEmailMessageInstance.InsertInOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            Type [] methodInsertInOnyxParametersTypes = null;
            object[] parametersOfInsertInOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxEmailMessageInstanceFixture, parametersOfInsertInOnyx);
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        private void AUT_OnyxEmailMessage_InsertInOnyx_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxEmailMessageInstance.InsertInOnyx(onyxObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxEmailMessageInstance.InsertInOnyx(onyxObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxEmailMessageInstanceFixture, parametersOfInsertInOnyx);
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
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
        private void AUT_OnyxEmailMessage_InsertInOnyx_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();

            // Act
            Action executeAction = () => _onyxEmailMessageInstance.InsertInOnyx(onyxObjects);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxEmailMessageInstance.InsertInOnyx(onyxObjects);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfInsertInOnyx = { onyxObjects };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxEmailMessageInstanceFixture, parametersOfInsertInOnyx);
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_OnyxEmailMessage_InsertInOnyx_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
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

        #region Method Call : (AddEmailAssociations) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_Internally(Type[] types)
        {
            var methodAddEmailAssociationsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddEmailAssociations, methodAddEmailAssociationsParametersTypes);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var onyxObjects = this.CreateType<List<OnyxObject>>();

            // Act
            Action executeAction = () => _onyxEmailMessageInstance.AddEmailAssociations(onyxObjects);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodAddEmailAssociationsParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfAddEmailAssociations = { onyxObjects };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddEmailAssociations, methodAddEmailAssociationsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEmailMessageInstanceFixture, parametersOfAddEmailAssociations);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddEmailAssociations.ShouldNotBeNull();
            parametersOfAddEmailAssociations.Length.ShouldBe(1);
            methodAddEmailAssociationsParametersTypes.Length.ShouldBe(1);
            methodAddEmailAssociationsParametersTypes.Length.ShouldBe(parametersOfAddEmailAssociations.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var onyxObjects = this.CreateType<List<OnyxObject>>();
            var methodAddEmailAssociationsParametersTypes = new Type[] { typeof(List<OnyxObject>) };
            object[] parametersOfAddEmailAssociations = { onyxObjects };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddEmailAssociations, parametersOfAddEmailAssociations, methodAddEmailAssociationsParametersTypes);

            // Assert
            parametersOfAddEmailAssociations.ShouldNotBeNull();
            parametersOfAddEmailAssociations.Length.ShouldBe(1);
            methodAddEmailAssociationsParametersTypes.Length.ShouldBe(1);
            methodAddEmailAssociationsParametersTypes.Length.ShouldBe(parametersOfAddEmailAssociations.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var currentMethodInfo = this.GetMethodInfo(MethodAddEmailAssociations, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var methodAddEmailAssociationsParametersTypes = new Type[] { typeof(List<OnyxObject>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddEmailAssociations, methodAddEmailAssociationsParametersTypes);

            // Assert
            methodAddEmailAssociationsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddEmailAssociations) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailMessage_AddEmailAssociations_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddEmailAssociations);
            var currentMethodInfo = this.GetMethodInfo(MethodAddEmailAssociations, 0);

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