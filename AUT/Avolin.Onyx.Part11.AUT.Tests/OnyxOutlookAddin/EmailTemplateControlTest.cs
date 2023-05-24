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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.EmailTemplateControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class EmailTemplateControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EmailTemplateControl" />)
        /// </summary>
        public EmailTemplateControlTest() : base(typeof(EmailTemplateControl))
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

        #region General Initializer : Class (EmailTemplateControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _emailTemplateControlInstanceType;
        private EmailTemplateControl _emailTemplateControlInstance;
        private EmailTemplateControl _emailTemplateControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EmailTemplateControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _emailTemplateControlInstanceType = typeof(EmailTemplateControl);
            _emailTemplateControlInstanceFixture = this.Create<EmailTemplateControl>(false);
            _emailTemplateControlInstance = _emailTemplateControlInstanceFixture ?? this.Create<EmailTemplateControl>(true);
            CurrentInstance = _emailTemplateControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EmailTemplateControl) Initializer

        #region Methods

        private const string MethodemailTemplateTree_AfterSelect = "emailTemplateTree_AfterSelect";
        private const string MethodemailTemplateCancelButton_Click = "emailTemplateCancelButton_Click";
        private const string MethodemailTemplateControl_Load = "emailTemplateControl_Load";

        #endregion

        #region Fields

        private const string FieldonyxObject = "onyxObject";
        private const string Fieldmember = "member";
        private const string Fieldtip = "tip";

        #endregion

        #endregion

        #region General Initializer : Class (EmailTemplateControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EmailTemplateControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EmailTemplateControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EmailTemplateControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EmailTemplateControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EmailTemplateControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EmailTemplateControl)

        #region General Initializer : Class (EmailTemplateControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="EmailTemplateControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodemailTemplateTree_AfterSelect, 0)]
        [TestCase(MethodemailTemplateCancelButton_Click, 0)]
        [TestCase(MethodemailTemplateControl_Load, 0)]
        public void AUT_EmailTemplateControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (EmailTemplateControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="EmailTemplateControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldonyxObject)]
        [TestCase(Fieldmember)]
        [TestCase(Fieldtip)]
        [Category("AUT Fields")]
        public void AUT_EmailTemplateControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EmailTemplateControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EmailTemplateControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EmailTemplateControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _emailTemplateControlInstance.ShouldBeAssignableTo<EmailTemplateControl>();
            _emailTemplateControlInstanceFixture.ShouldBeAssignableTo<EmailTemplateControl>();
            CurrentInstance.ShouldBeAssignableTo<EmailTemplateControl>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (emailTemplateTree_AfterSelect) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateTree_AfterSelect_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateTree_AfterSelect);
            var sender = this.CreateType<object>();
            var e = this.CreateType<TreeViewEventArgs>();
            var methodemailTemplateTree_AfterSelectParametersTypes = new Type[] { typeof(object), typeof(TreeViewEventArgs) };
            object[] parametersOfemailTemplateTree_AfterSelect = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateTree_AfterSelect, methodemailTemplateTree_AfterSelectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_emailTemplateControlInstanceFixture, parametersOfemailTemplateTree_AfterSelect);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailTemplateTree_AfterSelect.ShouldNotBeNull();
            parametersOfemailTemplateTree_AfterSelect.Length.ShouldBe(2);
            methodemailTemplateTree_AfterSelectParametersTypes.Length.ShouldBe(2);
            methodemailTemplateTree_AfterSelectParametersTypes.Length.ShouldBe(parametersOfemailTemplateTree_AfterSelect.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateTree_AfterSelect) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateTree_AfterSelect_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateTree_AfterSelect);
            var sender = this.CreateType<object>();
            var e = this.CreateType<TreeViewEventArgs>();
            var methodemailTemplateTree_AfterSelectParametersTypes = new Type[] { typeof(object), typeof(TreeViewEventArgs) };
            object[] parametersOfemailTemplateTree_AfterSelect = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailTemplateTree_AfterSelect, parametersOfemailTemplateTree_AfterSelect, methodemailTemplateTree_AfterSelectParametersTypes);

            // Assert
            parametersOfemailTemplateTree_AfterSelect.ShouldNotBeNull();
            parametersOfemailTemplateTree_AfterSelect.Length.ShouldBe(2);
            methodemailTemplateTree_AfterSelectParametersTypes.Length.ShouldBe(2);
            methodemailTemplateTree_AfterSelectParametersTypes.Length.ShouldBe(parametersOfemailTemplateTree_AfterSelect.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateTree_AfterSelect) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateTree_AfterSelect_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateTree_AfterSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateTree_AfterSelect, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailTemplateTree_AfterSelect) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateTree_AfterSelect_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateTree_AfterSelect);
            var methodemailTemplateTree_AfterSelectParametersTypes = new Type[] { typeof(object), typeof(TreeViewEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailTemplateTree_AfterSelect, methodemailTemplateTree_AfterSelectParametersTypes);

            // Assert
            methodemailTemplateTree_AfterSelectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateTree_AfterSelect) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateTree_AfterSelect_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateTree_AfterSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateTree_AfterSelect, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_Internally(Type[] types)
        {
            var methodemailTemplateCancelButton_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodemailTemplateCancelButton_Click, methodemailTemplateCancelButton_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateCancelButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodemailTemplateCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfemailTemplateCancelButton_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateCancelButton_Click, methodemailTemplateCancelButton_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_emailTemplateControlInstanceFixture, parametersOfemailTemplateCancelButton_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailTemplateCancelButton_Click.ShouldNotBeNull();
            parametersOfemailTemplateCancelButton_Click.Length.ShouldBe(2);
            methodemailTemplateCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            methodemailTemplateCancelButton_ClickParametersTypes.Length.ShouldBe(parametersOfemailTemplateCancelButton_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateCancelButton_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodemailTemplateCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfemailTemplateCancelButton_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailTemplateCancelButton_Click, parametersOfemailTemplateCancelButton_Click, methodemailTemplateCancelButton_ClickParametersTypes);

            // Assert
            parametersOfemailTemplateCancelButton_Click.ShouldNotBeNull();
            parametersOfemailTemplateCancelButton_Click.Length.ShouldBe(2);
            methodemailTemplateCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            methodemailTemplateCancelButton_ClickParametersTypes.Length.ShouldBe(parametersOfemailTemplateCancelButton_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateCancelButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateCancelButton_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateCancelButton_Click);
            var methodemailTemplateCancelButton_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailTemplateCancelButton_Click, methodemailTemplateCancelButton_ClickParametersTypes);

            // Assert
            methodemailTemplateCancelButton_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateCancelButton_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateCancelButton_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateCancelButton_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateCancelButton_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_Internally(Type[] types)
        {
            var methodemailTemplateControl_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodemailTemplateControl_Load, methodemailTemplateControl_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodemailTemplateControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfemailTemplateControl_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateControl_Load, methodemailTemplateControl_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_emailTemplateControlInstanceFixture, parametersOfemailTemplateControl_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfemailTemplateControl_Load.ShouldNotBeNull();
            parametersOfemailTemplateControl_Load.Length.ShouldBe(2);
            methodemailTemplateControl_LoadParametersTypes.Length.ShouldBe(2);
            methodemailTemplateControl_LoadParametersTypes.Length.ShouldBe(parametersOfemailTemplateControl_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodemailTemplateControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfemailTemplateControl_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodemailTemplateControl_Load, parametersOfemailTemplateControl_Load, methodemailTemplateControl_LoadParametersTypes);

            // Assert
            parametersOfemailTemplateControl_Load.ShouldNotBeNull();
            parametersOfemailTemplateControl_Load.Length.ShouldBe(2);
            methodemailTemplateControl_LoadParametersTypes.Length.ShouldBe(2);
            methodemailTemplateControl_LoadParametersTypes.Length.ShouldBe(parametersOfemailTemplateControl_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateControl_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateControl_Load);
            var methodemailTemplateControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodemailTemplateControl_Load, methodemailTemplateControl_LoadParametersTypes);

            // Assert
            methodemailTemplateControl_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (emailTemplateControl_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_EmailTemplateControl_emailTemplateControl_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodemailTemplateControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodemailTemplateControl_Load, 0);

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