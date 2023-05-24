using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AddContactControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class AddContactControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AddContactControl" />)
        /// </summary>
        public AddContactControlTest() : base(typeof(AddContactControl))
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

        #region General Initializer : Class (AddContactControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _addContactControlInstanceType;
        private AddContactControl _addContactControlInstance;
        private AddContactControl _addContactControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AddContactControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addContactControlInstanceType = typeof(AddContactControl);
            _addContactControlInstanceFixture = this.Create<AddContactControl>(false);
            _addContactControlInstance = _addContactControlInstanceFixture ?? this.Create<AddContactControl>(true);
            CurrentInstance = _addContactControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddContactControl) Initializer

        #region Methods

        private const string MethodaddContactControl_Load = "addContactControl_Load";
        private const string MethodcontactSaveBtn_Click = "contactSaveBtn_Click";
        private const string MethodvalidateForm = "validateForm";
        private const string MethodcontactCancelBtn_Click = "contactCancelBtn_Click";
        private const string MethodcheckSelection = "checkSelection";
        private const string MethodcontactNameCombo_SelectedIndexChanged = "contactNameCombo_SelectedIndexChanged";
        private const string MethodcontactTypeCombo_SelectedIndexChanged = "contactTypeCombo_SelectedIndexChanged";

        #endregion

        #region Fields

        private const string FieldcategoryId = "categoryId";
        private const string FieldgroupId = "groupId";
        private const string FieldaddToObject = "addToObject";
        private const string FieldexistingContacts = "existingContacts";
        private const string Fieldtip = "tip";

        #endregion

        #endregion

        #region General Initializer : Class (AddContactControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddContactControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AddContactControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddContactControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AddContactControl)

        #region General Initializer : Class (AddContactControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodaddContactControl_Load, 0)]
        [TestCase(MethodcontactSaveBtn_Click, 0)]
        [TestCase(MethodvalidateForm, 0)]
        [TestCase(MethodcontactCancelBtn_Click, 0)]
        [TestCase(MethodcheckSelection, 0)]
        [TestCase(MethodcontactNameCombo_SelectedIndexChanged, 0)]
        [TestCase(MethodcontactTypeCombo_SelectedIndexChanged, 0)]
        public void AUT_AddContactControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AddContactControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcategoryId)]
        [TestCase(FieldgroupId)]
        [TestCase(FieldaddToObject)]
        [TestCase(FieldexistingContacts)]
        [TestCase(Fieldtip)]
        [Category("AUT Fields")]
        public void AUT_AddContactControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AddContactControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AddContactControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _addContactControlInstance.ShouldBeAssignableTo<AddContactControl>();
            _addContactControlInstanceFixture.ShouldBeAssignableTo<AddContactControl>();
            CurrentInstance.ShouldBeAssignableTo<AddContactControl>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (addContactControl_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_addContactControl_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddContactControl_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactControl_Load, methodaddContactControl_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfaddContactControl_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddContactControl_Load.ShouldNotBeNull();
            parametersOfaddContactControl_Load.Length.ShouldBe(2);
            methodaddContactControl_LoadParametersTypes.Length.ShouldBe(2);
            methodaddContactControl_LoadParametersTypes.Length.ShouldBe(parametersOfaddContactControl_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addContactControl_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_addContactControl_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddContactControl_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddContactControl_Load, parametersOfaddContactControl_Load, methodaddContactControl_LoadParametersTypes);

            // Assert
            parametersOfaddContactControl_Load.ShouldNotBeNull();
            parametersOfaddContactControl_Load.Length.ShouldBe(2);
            methodaddContactControl_LoadParametersTypes.Length.ShouldBe(2);
            methodaddContactControl_LoadParametersTypes.Length.ShouldBe(parametersOfaddContactControl_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addContactControl_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_addContactControl_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactControl_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addContactControl_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_addContactControl_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactControl_Load);
            var methodaddContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddContactControl_Load, methodaddContactControl_LoadParametersTypes);

            // Assert
            methodaddContactControl_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addContactControl_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_addContactControl_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddContactControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodaddContactControl_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodcontactSaveBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactSaveBtn_Click, methodcontactSaveBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactSaveBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactSaveBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactSaveBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactSaveBtn_Click, methodcontactSaveBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfcontactSaveBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactSaveBtn_Click.ShouldNotBeNull();
            parametersOfcontactSaveBtn_Click.Length.ShouldBe(2);
            methodcontactSaveBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcontactSaveBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcontactSaveBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactSaveBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactSaveBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactSaveBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactSaveBtn_Click, parametersOfcontactSaveBtn_Click, methodcontactSaveBtn_ClickParametersTypes);

            // Assert
            parametersOfcontactSaveBtn_Click.ShouldNotBeNull();
            parametersOfcontactSaveBtn_Click.Length.ShouldBe(2);
            methodcontactSaveBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcontactSaveBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcontactSaveBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactSaveBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactSaveBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactSaveBtn_Click);
            var methodcontactSaveBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactSaveBtn_Click, methodcontactSaveBtn_ClickParametersTypes);

            // Assert
            methodcontactSaveBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactSaveBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactSaveBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactSaveBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactSaveBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_validateForm_Method_Call_Internally(Type[] types)
        {
            var methodvalidateFormParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodvalidateForm, methodvalidateFormParametersTypes);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_validateForm_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_addContactControlInstanceFixture, parametersOfvalidateForm);
            var result2 = this.GetResultOfMethod<bool>(MethodvalidateForm, parametersOfvalidateForm, methodvalidateFormParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfvalidateForm.ShouldBeNull();
            methodvalidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_validateForm_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_addContactControlInstanceFixture, out exception1, parametersOfvalidateForm);
            var result2 = this.GetResultOfMethod<bool>(MethodvalidateForm, parametersOfvalidateForm, methodvalidateFormParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfvalidateForm.ShouldBeNull();
            methodvalidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_validateForm_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodvalidateForm, parametersOfvalidateForm, methodvalidateFormParametersTypes);

            // Assert
            parametersOfvalidateForm.ShouldBeNull();
            methodvalidateFormParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_validateForm_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodvalidateForm, methodvalidateFormParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodvalidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_validateForm_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodcontactCancelBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactCancelBtn_Click, methodcontactCancelBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactCancelBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactCancelBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactCancelBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactCancelBtn_Click, methodcontactCancelBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfcontactCancelBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactCancelBtn_Click.ShouldNotBeNull();
            parametersOfcontactCancelBtn_Click.Length.ShouldBe(2);
            methodcontactCancelBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcontactCancelBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcontactCancelBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactCancelBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactCancelBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactCancelBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactCancelBtn_Click, parametersOfcontactCancelBtn_Click, methodcontactCancelBtn_ClickParametersTypes);

            // Assert
            parametersOfcontactCancelBtn_Click.ShouldNotBeNull();
            parametersOfcontactCancelBtn_Click.Length.ShouldBe(2);
            methodcontactCancelBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcontactCancelBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcontactCancelBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactCancelBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactCancelBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactCancelBtn_Click);
            var methodcontactCancelBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactCancelBtn_Click, methodcontactCancelBtn_ClickParametersTypes);

            // Assert
            methodcontactCancelBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactCancelBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactCancelBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactCancelBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactCancelBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkSelection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_checkSelection_Method_Call_Internally(Type[] types)
        {
            var methodcheckSelectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcheckSelection, methodcheckSelectionParametersTypes);
        }

        #endregion

        #region Method Call : (checkSelection) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_checkSelection_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckSelection);
            Type [] methodcheckSelectionParametersTypes = null;
            object[] parametersOfcheckSelection = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcheckSelection, methodcheckSelectionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfcheckSelection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcheckSelection.ShouldBeNull();
            methodcheckSelectionParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (checkSelection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_checkSelection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckSelection);
            Type [] methodcheckSelectionParametersTypes = null;
            object[] parametersOfcheckSelection = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcheckSelection, parametersOfcheckSelection, methodcheckSelectionParametersTypes);

            // Assert
            parametersOfcheckSelection.ShouldBeNull();
            methodcheckSelectionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkSelection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_checkSelection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckSelection);
            Type [] methodcheckSelectionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcheckSelection, methodcheckSelectionParametersTypes);

            // Assert
            methodcheckSelectionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (checkSelection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_checkSelection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcheckSelection);
            var currentMethodInfo = this.GetMethodInfo(MethodcheckSelection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodcontactNameCombo_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactNameCombo_SelectedIndexChanged, methodcontactNameCombo_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactNameCombo_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactNameCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactNameCombo_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactNameCombo_SelectedIndexChanged, methodcontactNameCombo_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfcontactNameCombo_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactNameCombo_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcontactNameCombo_SelectedIndexChanged.Length.ShouldBe(2);
            methodcontactNameCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcontactNameCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcontactNameCombo_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactNameCombo_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactNameCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactNameCombo_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactNameCombo_SelectedIndexChanged, parametersOfcontactNameCombo_SelectedIndexChanged, methodcontactNameCombo_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOfcontactNameCombo_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcontactNameCombo_SelectedIndexChanged.Length.ShouldBe(2);
            methodcontactNameCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcontactNameCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcontactNameCombo_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactNameCombo_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactNameCombo_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactNameCombo_SelectedIndexChanged);
            var methodcontactNameCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactNameCombo_SelectedIndexChanged, methodcontactNameCombo_SelectedIndexChangedParametersTypes);

            // Assert
            methodcontactNameCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactNameCombo_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactNameCombo_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactNameCombo_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactNameCombo_SelectedIndexChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_Internally(Type[] types)
        {
            var methodcontactTypeCombo_SelectedIndexChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcontactTypeCombo_SelectedIndexChanged, methodcontactTypeCombo_SelectedIndexChangedParametersTypes);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactTypeCombo_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactTypeCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactTypeCombo_SelectedIndexChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcontactTypeCombo_SelectedIndexChanged, methodcontactTypeCombo_SelectedIndexChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addContactControlInstanceFixture, parametersOfcontactTypeCombo_SelectedIndexChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcontactTypeCombo_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcontactTypeCombo_SelectedIndexChanged.Length.ShouldBe(2);
            methodcontactTypeCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcontactTypeCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcontactTypeCombo_SelectedIndexChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactTypeCombo_SelectedIndexChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcontactTypeCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcontactTypeCombo_SelectedIndexChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcontactTypeCombo_SelectedIndexChanged, parametersOfcontactTypeCombo_SelectedIndexChanged, methodcontactTypeCombo_SelectedIndexChangedParametersTypes);

            // Assert
            parametersOfcontactTypeCombo_SelectedIndexChanged.ShouldNotBeNull();
            parametersOfcontactTypeCombo_SelectedIndexChanged.Length.ShouldBe(2);
            methodcontactTypeCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            methodcontactTypeCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(parametersOfcontactTypeCombo_SelectedIndexChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactTypeCombo_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactTypeCombo_SelectedIndexChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactTypeCombo_SelectedIndexChanged);
            var methodcontactTypeCombo_SelectedIndexChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcontactTypeCombo_SelectedIndexChanged, methodcontactTypeCombo_SelectedIndexChangedParametersTypes);

            // Assert
            methodcontactTypeCombo_SelectedIndexChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (contactTypeCombo_SelectedIndexChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddContactControl_contactTypeCombo_SelectedIndexChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcontactTypeCombo_SelectedIndexChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodcontactTypeCombo_SelectedIndexChanged, 0);

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