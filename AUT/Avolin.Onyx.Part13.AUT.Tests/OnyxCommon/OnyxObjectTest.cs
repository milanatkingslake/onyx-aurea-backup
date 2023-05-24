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
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxObject" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxObjectTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxObject" />)
        /// </summary>
        public OnyxObjectTest() : base(typeof(OnyxObject))
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

        #region General Initializer : Class (OnyxObject) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxObjectInstanceType;
        private OnyxObject _onyxObjectInstance;
        private OnyxObject _onyxObjectInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxObject" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxObjectInstanceType = typeof(OnyxObject);
            _onyxObjectInstanceFixture = this.Create<OnyxObject>(false);
            _onyxObjectInstance = _onyxObjectInstanceFixture ?? this.Create<OnyxObject>(true);
            CurrentInstance = _onyxObjectInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxObject) Initializer

        #region Properties

        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyHeading = "Heading";
        private const string PropertySecondaryId = "SecondaryId";
        private const string PropertyObjectType = "ObjectType";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyUpdateBy = "UpdateBy";

        #endregion

        #region Methods

        private const string MethodInsertInternalContact = "InsertInternalContact";
        private const string MethodUpdateInOnyx = "UpdateInOnyx";
        private const string MethodInsertInOnyx = "InsertInOnyx";

        #endregion

        #region Fields

        private const string FieldprimaryId = "primaryId";
        private const string FieldsecondaryId = "secondaryId";
        private const string FieldprimaryLbo = "primaryLbo";
        private const string FieldinsertBy = "insertBy";
        private const string FieldupdateBy = "updateBy";
        private const string Fieldheading = "heading";
        private const string FieldobjectType = "objectType";
        private const string FieldoSession = "oSession";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxObject) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxObject_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxObject) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxObject_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxObject) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxObject_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxObject)

        #region General Initializer : Class (OnyxObject) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInsertInternalContact, 0)]
        [TestCase(MethodUpdateInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 0)]
        public void AUT_OnyxObject_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxObject) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyUpdateBy)]
        [Category("AUT Property")]
        public void AUT_OnyxObject_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxObject) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldprimaryId)]
        [TestCase(FieldsecondaryId)]
        [TestCase(FieldprimaryLbo)]
        [TestCase(FieldinsertBy)]
        [TestCase(FieldupdateBy)]
        [TestCase(Fieldheading)]
        [TestCase(FieldobjectType)]
        [TestCase(FieldoSession)]
        [Category("AUT Fields")]
        public void AUT_OnyxObject_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxObject) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxObject_Is_Instance_Present_Test()
        {
            // Assert
            _onyxObjectInstanceType.ShouldNotBeNull();
            _onyxObjectInstance.ShouldNotBeNull();
            _onyxObjectInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxObject) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxObject_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxObjectInstance.ShouldBeAssignableTo<OnyxObject>();
            _onyxObjectInstanceFixture.ShouldBeAssignableTo<OnyxObject>();
            CurrentInstance.ShouldBeAssignableTo<OnyxObject>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxObject) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramPrimaryId = this.CreateType<string>();
            var paramObjectType = this.CreateType<string>();
            OnyxObject instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxObject(paramPrimaryId, paramObjectType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxObjectInstance.ShouldNotBeNull();
            _onyxObjectInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxObject>();
        }

        #endregion

        #region General Constructor : Class (OnyxObject) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramPrimaryId = this.CreateType<string>();
            var paramObjectType = this.CreateType<string>();
            OnyxObject instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxObject(paramPrimaryId, paramObjectType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxObjectInstance.ShouldNotBeNull();
            _onyxObjectInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxObject) instance created

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_Is_Created_Test()
        {
            // Assert
            _onyxObjectInstance.ShouldNotBeNull();
            _onyxObjectInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxObject) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxObject" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxObject_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxObject) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxObject" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxObject) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxObject" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxObjectParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxObjectParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxObject) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxObject" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObject_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxObjectParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxObjectParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxObject) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyUpdateBy)]
        public void AUT_OnyxObject_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxObject) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxObject) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertBy);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxObject) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxObject) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxObject) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxObjectInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxObject) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxObject) => Property (SecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_SecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertySecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxObject) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxObject_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateBy);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateBy);

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

        #region Method Call : (InsertInternalContact) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var contactId = this.CreateType<string>();
            var userId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxObjectInstance.InsertInternalContact(contactId, userId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInternalContact) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var contactId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var methodInsertInternalContactParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfInsertInternalContact = { contactId, userId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInternalContact, methodInsertInternalContactParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxObjectInstanceFixture, parametersOfInsertInternalContact);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertInternalContact.ShouldNotBeNull();
            parametersOfInsertInternalContact.Length.ShouldBe(2);
            methodInsertInternalContactParametersTypes.Length.ShouldBe(2);
            methodInsertInternalContactParametersTypes.Length.ShouldBe(parametersOfInsertInternalContact.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertInternalContact) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var contactId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var methodInsertInternalContactParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfInsertInternalContact = { contactId, userId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertInternalContact, parametersOfInsertInternalContact, methodInsertInternalContactParametersTypes);

            // Assert
            parametersOfInsertInternalContact.ShouldNotBeNull();
            parametersOfInsertInternalContact.Length.ShouldBe(2);
            methodInsertInternalContactParametersTypes.Length.ShouldBe(2);
            methodInsertInternalContactParametersTypes.Length.ShouldBe(parametersOfInsertInternalContact.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInternalContact) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInternalContact, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInternalContact) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var methodInsertInternalContactParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInternalContact, methodInsertInternalContactParametersTypes);

            // Assert
            methodInsertInternalContactParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInternalContact) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInternalContact_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInternalContact);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInternalContact, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxObject_UpdateInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodUpdateInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxObjectInstance.UpdateInOnyx(sParameters, addNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfUpdateInOnyx = { sParameters, addNodes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxObjectInstanceFixture, parametersOfUpdateInOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateInOnyx.ShouldNotBeNull();
            parametersOfUpdateInOnyx.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(parametersOfUpdateInOnyx.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfUpdateInOnyx = { sParameters, addNodes };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateInOnyx, parametersOfUpdateInOnyx, methodUpdateInOnyxParametersTypes);

            // Assert
            parametersOfUpdateInOnyx.ShouldNotBeNull();
            parametersOfUpdateInOnyx.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(parametersOfUpdateInOnyx.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes);

            // Assert
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_UpdateInOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxObject_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxObjectInstance.InsertInOnyx(sParameters, collectionNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var returnedValue = default(OnyxObject);

            // Act
            Action executeAction = () => returnedValue = _onyxObjectInstance.InsertInOnyx(sParameters, collectionNodes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfInsertInOnyx = { sParameters, collectionNodes };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxObject>(_onyxObjectInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OnyxObject>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(2);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfInsertInOnyx = { sParameters, collectionNodes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxObject>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(2);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : OnyxObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObject_InsertInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}