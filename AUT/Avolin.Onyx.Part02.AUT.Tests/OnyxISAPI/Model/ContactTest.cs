using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Contact" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ContactTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Contact" />)
        /// </summary>
        public ContactTest() : base(typeof(Contact))
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

        #region General Initializer : Class (Contact) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _contactInstanceType;
        private Contact _contactInstance;
        private Contact _contactInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Contact" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _contactInstanceType = typeof(Contact);
            _contactInstanceFixture = this.Create<Contact>(false);
            _contactInstance = _contactInstanceFixture ?? this.Create<Contact>(true);
            CurrentInstance = _contactInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Contact) Initializer

        #region Methods

        private const string MethodGetContactByOwner = "GetContactByOwner";
        private const string MethodGetInternalContactByOwner = "GetInternalContactByOwner";
        private const string MethodGetExternalContactByOwner = "GetExternalContactByOwner";
        private const string MethodGetContactTypeByCategoryId = "GetContactTypeByCategoryId";
        private const string MethodGetInternalContactUserList = "GetInternalContactUserList";
        private const string MethodAddInternalContact = "AddInternalContact";
        private const string MethodAddExternalContact = "AddExternalContact";
        private const string MethodMergeContactResult = "MergeContactResult";
        private const string MethodSortbyAttribute = "SortbyAttribute";

        #endregion

        #endregion

        #region General Initializer : Class (Contact) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Contact" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Contact_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Contact)

        #region General Initializer : Class (Contact) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Contact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetContactByOwner, 0)]
        [TestCase(MethodGetInternalContactByOwner, 0)]
        [TestCase(MethodGetExternalContactByOwner, 0)]
        [TestCase(MethodGetContactTypeByCategoryId, 0)]
        [TestCase(MethodGetInternalContactUserList, 0)]
        [TestCase(MethodAddInternalContact, 0)]
        [TestCase(MethodAddExternalContact, 0)]
        [TestCase(MethodMergeContactResult, 0)]
        [TestCase(MethodSortbyAttribute, 0)]
        public void AUT_Contact_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Contact) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Contact" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Contact_Is_Instance_Present_Test()
        {
            // Assert
            _contactInstanceType.ShouldNotBeNull();
            _contactInstance.ShouldNotBeNull();
            _contactInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Contact) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Contact" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Contact_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _contactInstance.ShouldBeAssignableTo<Contact>();
            _contactInstanceFixture.ShouldBeAssignableTo<Contact>();
            CurrentInstance.ShouldBeAssignableTo<Contact>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Contact) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Contact_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Contact instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Contact(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _contactInstance.ShouldNotBeNull();
            _contactInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Contact>();
        }

        #endregion

        #region General Constructor : Class (Contact) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Contact_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Contact instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Contact(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _contactInstance.ShouldNotBeNull();
            _contactInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetContactByOwner) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);

            // Act
            Action executeAction = () => _contactInstance.GetContactByOwner();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.GetContactByOwner();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            Type [] methodGetContactByOwnerParametersTypes = null;
            object[] parametersOfGetContactByOwner = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactByOwner, methodGetContactByOwnerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfGetContactByOwner);
            var result2 = this.GetResultOfMethod<string>(MethodGetContactByOwner, parametersOfGetContactByOwner, methodGetContactByOwnerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContactByOwner.ShouldBeNull();
            methodGetContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            Type [] methodGetContactByOwnerParametersTypes = null;
            object[] parametersOfGetContactByOwner = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContactByOwner, parametersOfGetContactByOwner, methodGetContactByOwnerParametersTypes);

            // Assert
            parametersOfGetContactByOwner.ShouldBeNull();
            methodGetContactByOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            Type [] methodGetContactByOwnerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContactByOwner, methodGetContactByOwnerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            Type [] methodGetContactByOwnerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContactByOwner, methodGetContactByOwnerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactByOwner) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactByOwner_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactByOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactByOwner, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_GetInternalContactByOwner_Method_Call_Internally(Type[] types)
        {
            var methodGetInternalContactByOwnerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes);
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);

            // Act
            Action executeAction = () => _contactInstance.GetInternalContactByOwner();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.GetInternalContactByOwner();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            Type [] methodGetInternalContactByOwnerParametersTypes = null;
            object[] parametersOfGetInternalContactByOwner = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfGetInternalContactByOwner);
            var result2 = this.GetResultOfMethod<string>(MethodGetInternalContactByOwner, parametersOfGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetInternalContactByOwner.ShouldBeNull();
            methodGetInternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            Type [] methodGetInternalContactByOwnerParametersTypes = null;
            object[] parametersOfGetInternalContactByOwner = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetInternalContactByOwner, parametersOfGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes);

            // Assert
            parametersOfGetInternalContactByOwner.ShouldBeNull();
            methodGetInternalContactByOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            Type [] methodGetInternalContactByOwnerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetInternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            Type [] methodGetInternalContactByOwnerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetInternalContactByOwner, methodGetInternalContactByOwnerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetInternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactByOwner) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactByOwner_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactByOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetInternalContactByOwner, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_GetExternalContactByOwner_Method_Call_Internally(Type[] types)
        {
            var methodGetExternalContactByOwnerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes);
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);

            // Act
            Action executeAction = () => _contactInstance.GetExternalContactByOwner();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.GetExternalContactByOwner();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            Type [] methodGetExternalContactByOwnerParametersTypes = null;
            object[] parametersOfGetExternalContactByOwner = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfGetExternalContactByOwner);
            var result2 = this.GetResultOfMethod<string>(MethodGetExternalContactByOwner, parametersOfGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetExternalContactByOwner.ShouldBeNull();
            methodGetExternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            Type [] methodGetExternalContactByOwnerParametersTypes = null;
            object[] parametersOfGetExternalContactByOwner = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetExternalContactByOwner, parametersOfGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes);

            // Assert
            parametersOfGetExternalContactByOwner.ShouldBeNull();
            methodGetExternalContactByOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            Type [] methodGetExternalContactByOwnerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetExternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            Type [] methodGetExternalContactByOwnerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExternalContactByOwner, methodGetExternalContactByOwnerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExternalContactByOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExternalContactByOwner) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetExternalContactByOwner_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExternalContactByOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExternalContactByOwner, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_GetContactTypeByCategoryId_Method_Call_Internally(Type[] types)
        {
            var methodGetContactTypeByCategoryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);

            // Act
            Action executeAction = () => _contactInstance.GetContactTypeByCategoryId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.GetContactTypeByCategoryId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            Type [] methodGetContactTypeByCategoryIdParametersTypes = null;
            object[] parametersOfGetContactTypeByCategoryId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfGetContactTypeByCategoryId);
            var result2 = this.GetResultOfMethod<string>(MethodGetContactTypeByCategoryId, parametersOfGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContactTypeByCategoryId.ShouldBeNull();
            methodGetContactTypeByCategoryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            Type [] methodGetContactTypeByCategoryIdParametersTypes = null;
            object[] parametersOfGetContactTypeByCategoryId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContactTypeByCategoryId, parametersOfGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes);

            // Assert
            parametersOfGetContactTypeByCategoryId.ShouldBeNull();
            methodGetContactTypeByCategoryIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            Type [] methodGetContactTypeByCategoryIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContactTypeByCategoryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            Type [] methodGetContactTypeByCategoryIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContactTypeByCategoryId, methodGetContactTypeByCategoryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContactTypeByCategoryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeByCategoryId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetContactTypeByCategoryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeByCategoryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactTypeByCategoryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_GetInternalContactUserList_Method_Call_Internally(Type[] types)
        {
            var methodGetInternalContactUserListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetInternalContactUserList, methodGetInternalContactUserListParametersTypes);
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);

            // Act
            Action executeAction = () => _contactInstance.GetInternalContactUserList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.GetInternalContactUserList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            Type [] methodGetInternalContactUserListParametersTypes = null;
            object[] parametersOfGetInternalContactUserList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetInternalContactUserList, methodGetInternalContactUserListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfGetInternalContactUserList);
            var result2 = this.GetResultOfMethod<string>(MethodGetInternalContactUserList, parametersOfGetInternalContactUserList, methodGetInternalContactUserListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetInternalContactUserList.ShouldBeNull();
            methodGetInternalContactUserListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            Type [] methodGetInternalContactUserListParametersTypes = null;
            object[] parametersOfGetInternalContactUserList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetInternalContactUserList, parametersOfGetInternalContactUserList, methodGetInternalContactUserListParametersTypes);

            // Assert
            parametersOfGetInternalContactUserList.ShouldBeNull();
            methodGetInternalContactUserListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            Type [] methodGetInternalContactUserListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetInternalContactUserList, methodGetInternalContactUserListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetInternalContactUserListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            Type [] methodGetInternalContactUserListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetInternalContactUserList, methodGetInternalContactUserListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetInternalContactUserListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetInternalContactUserList) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_GetInternalContactUserList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetInternalContactUserList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetInternalContactUserList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_AddInternalContact_Method_Call_Internally(Type[] types)
        {
            var methodAddInternalContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddInternalContact, methodAddInternalContactParametersTypes);
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);

            // Act
            Action executeAction = () => _contactInstance.AddInternalContact();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.AddInternalContact();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            Type [] methodAddInternalContactParametersTypes = null;
            object[] parametersOfAddInternalContact = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddInternalContact, methodAddInternalContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfAddInternalContact);
            var result2 = this.GetResultOfMethod<string>(MethodAddInternalContact, parametersOfAddInternalContact, methodAddInternalContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddInternalContact.ShouldBeNull();
            methodAddInternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            Type [] methodAddInternalContactParametersTypes = null;
            object[] parametersOfAddInternalContact = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAddInternalContact, parametersOfAddInternalContact, methodAddInternalContactParametersTypes);

            // Assert
            parametersOfAddInternalContact.ShouldBeNull();
            methodAddInternalContactParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            Type [] methodAddInternalContactParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddInternalContact, methodAddInternalContactParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddInternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            Type [] methodAddInternalContactParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddInternalContact, methodAddInternalContactParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddInternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddInternalContact) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddInternalContact_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalContact);
            var currentMethodInfo = this.GetMethodInfo(MethodAddInternalContact, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_AddExternalContact_Method_Call_Internally(Type[] types)
        {
            var methodAddExternalContactParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddExternalContact, methodAddExternalContactParametersTypes);
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);

            // Act
            Action executeAction = () => _contactInstance.AddExternalContact();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _contactInstance.AddExternalContact();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            Type [] methodAddExternalContactParametersTypes = null;
            object[] parametersOfAddExternalContact = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddExternalContact, methodAddExternalContactParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfAddExternalContact);
            var result2 = this.GetResultOfMethod<string>(MethodAddExternalContact, parametersOfAddExternalContact, methodAddExternalContactParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddExternalContact.ShouldBeNull();
            methodAddExternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            Type [] methodAddExternalContactParametersTypes = null;
            object[] parametersOfAddExternalContact = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAddExternalContact, parametersOfAddExternalContact, methodAddExternalContactParametersTypes);

            // Assert
            parametersOfAddExternalContact.ShouldBeNull();
            methodAddExternalContactParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            Type [] methodAddExternalContactParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddExternalContact, methodAddExternalContactParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddExternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            Type [] methodAddExternalContactParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddExternalContact, methodAddExternalContactParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddExternalContactParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddExternalContact) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_AddExternalContact_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddExternalContact);
            var currentMethodInfo = this.GetMethodInfo(MethodAddExternalContact, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_MergeContactResult_Method_Call_Internally(Type[] types)
        {
            var methodMergeContactResultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeContactResult, methodMergeContactResultParametersTypes);
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var internalXml = this.CreateType<string>();
            var externalXml = this.CreateType<string>();
            var methodMergeContactResultParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMergeContactResult = { internalXml, externalXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeContactResult, methodMergeContactResultParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, parametersOfMergeContactResult);
            var result2 = this.GetResultOfMethod<string>(MethodMergeContactResult, parametersOfMergeContactResult, methodMergeContactResultParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeContactResult.ShouldNotBeNull();
            parametersOfMergeContactResult.Length.ShouldBe(2);
            methodMergeContactResultParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var internalXml = this.CreateType<string>();
            var externalXml = this.CreateType<string>();
            var methodMergeContactResultParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMergeContactResult = { internalXml, externalXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMergeContactResult, parametersOfMergeContactResult, methodMergeContactResultParametersTypes);

            // Assert
            parametersOfMergeContactResult.ShouldNotBeNull();
            parametersOfMergeContactResult.Length.ShouldBe(2);
            methodMergeContactResultParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var methodMergeContactResultParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeContactResult, methodMergeContactResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeContactResultParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var methodMergeContactResultParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeContactResult, methodMergeContactResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeContactResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeContactResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeContactResult) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_MergeContactResult_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeContactResult);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeContactResult, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Contact_SortbyAttribute_Method_Call_Internally(Type[] types)
        {
            var methodSortbyAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSortbyAttribute, methodSortbyAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var attributeName = this.CreateType<string>();
            var methodSortbyAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfSortbyAttribute = { xmlDoc, attributeName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyAttribute, methodSortbyAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_contactInstanceFixture, out exception1, parametersOfSortbyAttribute);
            var result2 = this.GetResultOfMethod<string>(MethodSortbyAttribute, parametersOfSortbyAttribute, methodSortbyAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSortbyAttribute.ShouldNotBeNull();
            parametersOfSortbyAttribute.Length.ShouldBe(2);
            methodSortbyAttributeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var attributeName = this.CreateType<string>();
            var methodSortbyAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfSortbyAttribute = { xmlDoc, attributeName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyAttribute, methodSortbyAttributeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_contactInstanceFixture, parametersOfSortbyAttribute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSortbyAttribute.ShouldNotBeNull();
            parametersOfSortbyAttribute.Length.ShouldBe(2);
            methodSortbyAttributeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var attributeName = this.CreateType<string>();
            var methodSortbyAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfSortbyAttribute = { xmlDoc, attributeName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSortbyAttribute, parametersOfSortbyAttribute, methodSortbyAttributeParametersTypes);

            // Assert
            parametersOfSortbyAttribute.ShouldNotBeNull();
            parametersOfSortbyAttribute.Length.ShouldBe(2);
            methodSortbyAttributeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var methodSortbyAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSortbyAttribute, methodSortbyAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSortbyAttributeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var methodSortbyAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSortbyAttribute, methodSortbyAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSortbyAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SortbyAttribute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Contact_SortbyAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyAttribute, 0);
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