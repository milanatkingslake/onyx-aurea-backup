using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CreateCustomerControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CreateCustomerControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CreateCustomerControl" />)
        /// </summary>
        public CreateCustomerControlTest() : base(typeof(CreateCustomerControl))
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

        #region General Initializer : Class (CreateCustomerControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _createCustomerControlInstanceType;
        private CreateCustomerControl _createCustomerControlInstance;
        private CreateCustomerControl _createCustomerControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CreateCustomerControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _createCustomerControlInstanceType = typeof(CreateCustomerControl);
            _createCustomerControlInstanceFixture = this.Create<CreateCustomerControl>(false);
            _createCustomerControlInstance = _createCustomerControlInstanceFixture ?? this.Create<CreateCustomerControl>(true);
            CurrentInstance = _createCustomerControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CreateCustomerControl) Initializer

        #region Methods

        private const string MethodfindContactInOutlook = "findContactInOutlook";
        private const string MethodvalidateForm = "validateForm";
        private const string MethodgetCompanyListForCombo = "getCompanyListForCombo";
        private const string MethodcreateCustomerButton_Click = "createCustomerButton_Click";
        private const string MethodcreateCustomerCancelButton_Click = "createCustomerCancelButton_Click";
        private const string MethodexistsinOutlookLbl_LinkClicked = "existsinOutlookLbl_LinkClicked";
        private const string MethodcreateCustomerControl_Load = "createCustomerControl_Load";

        #endregion

        #region Fields

        private const string Fieldmember = "member";
        private const string Field_outlookContact = "_outlookContact";

        #endregion

        #endregion

        #region General Initializer : Class (CreateCustomerControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateCustomerControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CreateCustomerControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateCustomerControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CreateCustomerControl)

        #region General Initializer : Class (CreateCustomerControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodfindContactInOutlook, 0)]
        [TestCase(MethodvalidateForm, 0)]
        [TestCase(MethodgetCompanyListForCombo, 0)]
        [TestCase(MethodcreateCustomerButton_Click, 0)]
        [TestCase(MethodcreateCustomerCancelButton_Click, 0)]
        [TestCase(MethodexistsinOutlookLbl_LinkClicked, 0)]
        [TestCase(MethodcreateCustomerControl_Load, 0)]
        public void AUT_CreateCustomerControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CreateCustomerControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldmember)]
        [TestCase(Field_outlookContact)]
        [Category("AUT Fields")]
        public void AUT_CreateCustomerControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CreateCustomerControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CreateCustomerControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _createCustomerControlInstance.ShouldBeAssignableTo<CreateCustomerControl>();
            _createCustomerControlInstanceFixture.ShouldBeAssignableTo<CreateCustomerControl>();
            CurrentInstance.ShouldBeAssignableTo<CreateCustomerControl>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (findContactInOutlook) (Return Type : Outlook.ContactItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_findContactInOutlook_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactInOutlook);
            var methodfindContactInOutlookParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodfindContactInOutlook, methodfindContactInOutlookParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodfindContactInOutlookParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (findContactInOutlook) (Return Type : Outlook.ContactItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_findContactInOutlook_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactInOutlook);
            var methodfindContactInOutlookParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodfindContactInOutlook, methodfindContactInOutlookParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodfindContactInOutlookParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (findContactInOutlook) (Return Type : Outlook.ContactItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_findContactInOutlook_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactInOutlook);
            var currentMethodInfo = this.GetMethodInfo(MethodfindContactInOutlook, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (findContactInOutlook) (Return Type : Outlook.ContactItem) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_findContactInOutlook_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodfindContactInOutlook);
            var currentMethodInfo = this.GetMethodInfo(MethodfindContactInOutlook, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_validateForm_Method_Call_Internally(Type[] types)
        {
            var methodvalidateFormParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodvalidateForm, methodvalidateFormParametersTypes);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_validateForm_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_createCustomerControlInstanceFixture, parametersOfvalidateForm);
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
        public void AUT_CreateCustomerControl_validateForm_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_createCustomerControlInstanceFixture, out exception1, parametersOfvalidateForm);
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
        public void AUT_CreateCustomerControl_validateForm_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CreateCustomerControl_validateForm_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CreateCustomerControl_validateForm_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (getCompanyListForCombo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_Internally(Type[] types)
        {
            var methodgetCompanyListForComboParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetCompanyListForCombo, methodgetCompanyListForComboParametersTypes);
        }

        #endregion

        #region Method Call : (getCompanyListForCombo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCompanyListForCombo);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodgetCompanyListForComboParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfgetCompanyListForCombo = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodgetCompanyListForCombo, methodgetCompanyListForComboParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createCustomerControlInstanceFixture, parametersOfgetCompanyListForCombo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfgetCompanyListForCombo.ShouldNotBeNull();
            parametersOfgetCompanyListForCombo.Length.ShouldBe(2);
            methodgetCompanyListForComboParametersTypes.Length.ShouldBe(2);
            methodgetCompanyListForComboParametersTypes.Length.ShouldBe(parametersOfgetCompanyListForCombo.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (getCompanyListForCombo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCompanyListForCombo);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodgetCompanyListForComboParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfgetCompanyListForCombo = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodgetCompanyListForCombo, parametersOfgetCompanyListForCombo, methodgetCompanyListForComboParametersTypes);

            // Assert
            parametersOfgetCompanyListForCombo.ShouldNotBeNull();
            parametersOfgetCompanyListForCombo.Length.ShouldBe(2);
            methodgetCompanyListForComboParametersTypes.Length.ShouldBe(2);
            methodgetCompanyListForComboParametersTypes.Length.ShouldBe(parametersOfgetCompanyListForCombo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getCompanyListForCombo) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCompanyListForCombo);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCompanyListForCombo, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getCompanyListForCombo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCompanyListForCombo);
            var methodgetCompanyListForComboParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetCompanyListForCombo, methodgetCompanyListForComboParametersTypes);

            // Assert
            methodgetCompanyListForComboParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getCompanyListForCombo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_getCompanyListForCombo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCompanyListForCombo);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCompanyListForCombo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateCustomerButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateCustomerButton_Click, methodcreateCustomerButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerButton_Click, methodcreateCustomerButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createCustomerControlInstanceFixture, parametersOfcreateCustomerButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateCustomerButton_Click.ShouldNotBeNull();
            parametersOfcreateCustomerButton_Click.Length.ShouldBe(2);
            methodcreateCustomerButton_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerButton_ClickParametersTypes.Length.ShouldBe(parametersOfcreateCustomerButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateCustomerButton_Click, parametersOfcreateCustomerButton_Click, methodcreateCustomerButton_ClickParametersTypes);

            // Assert
            parametersOfcreateCustomerButton_Click.ShouldNotBeNull();
            parametersOfcreateCustomerButton_Click.Length.ShouldBe(2);
            methodcreateCustomerButton_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerButton_ClickParametersTypes.Length.ShouldBe(parametersOfcreateCustomerButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerButton_Click);
            var methodcreateCustomerButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateCustomerButton_Click, methodcreateCustomerButton_ClickParametersTypes);

            // Assert
            methodcreateCustomerButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodcreateCustomerCancelButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateCustomerCancelButton_Click, methodcreateCustomerCancelButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerCancelButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerCancelButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerCancelButton_Click, methodcreateCustomerCancelButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createCustomerControlInstanceFixture, parametersOfcreateCustomerCancelButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateCustomerCancelButton_Click.ShouldNotBeNull();
            parametersOfcreateCustomerCancelButton_Click.Length.ShouldBe(2);
            methodcreateCustomerCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerCancelButton_ClickParametersTypes.Length.ShouldBe(parametersOfcreateCustomerCancelButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerCancelButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerCancelButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateCustomerCancelButton_Click, parametersOfcreateCustomerCancelButton_Click, methodcreateCustomerCancelButton_ClickParametersTypes);

            // Assert
            parametersOfcreateCustomerCancelButton_Click.ShouldNotBeNull();
            parametersOfcreateCustomerCancelButton_Click.Length.ShouldBe(2);
            methodcreateCustomerCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerCancelButton_ClickParametersTypes.Length.ShouldBe(parametersOfcreateCustomerCancelButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerCancelButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerCancelButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerCancelButton_Click);
            var methodcreateCustomerCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateCustomerCancelButton_Click, methodcreateCustomerCancelButton_ClickParametersTypes);

            // Assert
            methodcreateCustomerCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerCancelButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerCancelButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerCancelButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerCancelButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodexistsinOutlookLbl_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodexistsinOutlookLbl_LinkClicked, methodexistsinOutlookLbl_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexistsinOutlookLbl_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodexistsinOutlookLbl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfexistsinOutlookLbl_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodexistsinOutlookLbl_LinkClicked, methodexistsinOutlookLbl_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createCustomerControlInstanceFixture, parametersOfexistsinOutlookLbl_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfexistsinOutlookLbl_LinkClicked.ShouldNotBeNull();
            parametersOfexistsinOutlookLbl_LinkClicked.Length.ShouldBe(2);
            methodexistsinOutlookLbl_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodexistsinOutlookLbl_LinkClickedParametersTypes.Length.ShouldBe(parametersOfexistsinOutlookLbl_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexistsinOutlookLbl_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodexistsinOutlookLbl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfexistsinOutlookLbl_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodexistsinOutlookLbl_LinkClicked, parametersOfexistsinOutlookLbl_LinkClicked, methodexistsinOutlookLbl_LinkClickedParametersTypes);

            // Assert
            parametersOfexistsinOutlookLbl_LinkClicked.ShouldNotBeNull();
            parametersOfexistsinOutlookLbl_LinkClicked.Length.ShouldBe(2);
            methodexistsinOutlookLbl_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodexistsinOutlookLbl_LinkClickedParametersTypes.Length.ShouldBe(parametersOfexistsinOutlookLbl_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexistsinOutlookLbl_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodexistsinOutlookLbl_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexistsinOutlookLbl_LinkClicked);
            var methodexistsinOutlookLbl_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodexistsinOutlookLbl_LinkClicked, methodexistsinOutlookLbl_LinkClickedParametersTypes);

            // Assert
            methodexistsinOutlookLbl_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (existsinOutlookLbl_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_existsinOutlookLbl_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexistsinOutlookLbl_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodexistsinOutlookLbl_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_Internally(Type[] types)
        {
            var methodcreateCustomerControl_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateCustomerControl_Load, methodcreateCustomerControl_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerControl_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerControl_Load, methodcreateCustomerControl_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createCustomerControlInstanceFixture, parametersOfcreateCustomerControl_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateCustomerControl_Load.ShouldNotBeNull();
            parametersOfcreateCustomerControl_Load.Length.ShouldBe(2);
            methodcreateCustomerControl_LoadParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerControl_LoadParametersTypes.Length.ShouldBe(parametersOfcreateCustomerControl_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcreateCustomerControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcreateCustomerControl_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcreateCustomerControl_Load, parametersOfcreateCustomerControl_Load, methodcreateCustomerControl_LoadParametersTypes);

            // Assert
            parametersOfcreateCustomerControl_Load.ShouldNotBeNull();
            parametersOfcreateCustomerControl_Load.Length.ShouldBe(2);
            methodcreateCustomerControl_LoadParametersTypes.Length.ShouldBe(2);
            methodcreateCustomerControl_LoadParametersTypes.Length.ShouldBe(parametersOfcreateCustomerControl_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerControl_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerControl_Load);
            var methodcreateCustomerControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateCustomerControl_Load, methodcreateCustomerControl_LoadParametersTypes);

            // Assert
            methodcreateCustomerControl_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createCustomerControl_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateCustomerControl_createCustomerControl_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateCustomerControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateCustomerControl_Load, 0);

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