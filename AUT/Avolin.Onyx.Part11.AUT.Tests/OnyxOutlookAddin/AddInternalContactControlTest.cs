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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AddInternalContactControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class AddInternalContactControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AddInternalContactControl" />)
        /// </summary>
        public AddInternalContactControlTest() : base(typeof(AddInternalContactControl))
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

        #region General Initializer : Class (AddInternalContactControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _addInternalContactControlInstanceType;
        private AddInternalContactControl _addInternalContactControlInstance;
        private AddInternalContactControl _addInternalContactControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AddInternalContactControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addInternalContactControlInstanceType = typeof(AddInternalContactControl);
            _addInternalContactControlInstanceFixture = this.Create<AddInternalContactControl>(false);
            _addInternalContactControlInstance = _addInternalContactControlInstanceFixture ?? this.Create<AddInternalContactControl>(true);
            CurrentInstance = _addInternalContactControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddInternalContactControl) Initializer

        #region Methods

        private const string MethodaddInternalContactControl_Load = "addInternalContactControl_Load";
        private const string MethodsaveContactBtn_Click = "saveContactBtn_Click";
        private const string MethodvalidateForm = "validateForm";
        private const string MethodcancelContactBtn_Click = "cancelContactBtn_Click";

        #endregion

        #region Fields

        private const string FieldcategoryId = "categoryId";
        private const string FieldgroupId = "groupId";
        private const string FieldaddToObject = "addToObject";
        private const string Fieldtip = "tip";

        #endregion

        #endregion

        #region General Initializer : Class (AddInternalContactControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddInternalContactControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddInternalContactControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AddInternalContactControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AddInternalContactControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddInternalContactControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AddInternalContactControl)

        #region General Initializer : Class (AddInternalContactControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddInternalContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodaddInternalContactControl_Load, 0)]
        [TestCase(MethodsaveContactBtn_Click, 0)]
        [TestCase(MethodvalidateForm, 0)]
        [TestCase(MethodcancelContactBtn_Click, 0)]
        public void AUT_AddInternalContactControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AddInternalContactControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AddInternalContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcategoryId)]
        [TestCase(FieldgroupId)]
        [TestCase(FieldaddToObject)]
        [TestCase(Fieldtip)]
        [Category("AUT Fields")]
        public void AUT_AddInternalContactControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AddInternalContactControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AddInternalContactControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AddInternalContactControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _addInternalContactControlInstance.ShouldBeAssignableTo<AddInternalContactControl>();
            _addInternalContactControlInstanceFixture.ShouldBeAssignableTo<AddInternalContactControl>();
            CurrentInstance.ShouldBeAssignableTo<AddInternalContactControl>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (addInternalContactControl_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_addInternalContactControl_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddInternalContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddInternalContactControl_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactControl_Load, methodaddInternalContactControl_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addInternalContactControlInstanceFixture, parametersOfaddInternalContactControl_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddInternalContactControl_Load.ShouldNotBeNull();
            parametersOfaddInternalContactControl_Load.Length.ShouldBe(2);
            methodaddInternalContactControl_LoadParametersTypes.Length.ShouldBe(2);
            methodaddInternalContactControl_LoadParametersTypes.Length.ShouldBe(parametersOfaddInternalContactControl_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactControl_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_addInternalContactControl_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodaddInternalContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfaddInternalContactControl_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddInternalContactControl_Load, parametersOfaddInternalContactControl_Load, methodaddInternalContactControl_LoadParametersTypes);

            // Assert
            parametersOfaddInternalContactControl_Load.ShouldNotBeNull();
            parametersOfaddInternalContactControl_Load.Length.ShouldBe(2);
            methodaddInternalContactControl_LoadParametersTypes.Length.ShouldBe(2);
            methodaddInternalContactControl_LoadParametersTypes.Length.ShouldBe(parametersOfaddInternalContactControl_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactControl_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_addInternalContactControl_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactControl_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addInternalContactControl_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_addInternalContactControl_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactControl_Load);
            var methodaddInternalContactControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddInternalContactControl_Load, methodaddInternalContactControl_LoadParametersTypes);

            // Assert
            methodaddInternalContactControl_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addInternalContactControl_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_addInternalContactControl_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddInternalContactControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodaddInternalContactControl_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodsaveContactBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsaveContactBtn_Click, methodsaveContactBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveContactBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsaveContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsaveContactBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsaveContactBtn_Click, methodsaveContactBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addInternalContactControlInstanceFixture, parametersOfsaveContactBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsaveContactBtn_Click.ShouldNotBeNull();
            parametersOfsaveContactBtn_Click.Length.ShouldBe(2);
            methodsaveContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodsaveContactBtn_ClickParametersTypes.Length.ShouldBe(parametersOfsaveContactBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveContactBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsaveContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsaveContactBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsaveContactBtn_Click, parametersOfsaveContactBtn_Click, methodsaveContactBtn_ClickParametersTypes);

            // Assert
            parametersOfsaveContactBtn_Click.ShouldNotBeNull();
            parametersOfsaveContactBtn_Click.Length.ShouldBe(2);
            methodsaveContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodsaveContactBtn_ClickParametersTypes.Length.ShouldBe(parametersOfsaveContactBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveContactBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsaveContactBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveContactBtn_Click);
            var methodsaveContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsaveContactBtn_Click, methodsaveContactBtn_ClickParametersTypes);

            // Assert
            methodsaveContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveContactBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_saveContactBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveContactBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsaveContactBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddInternalContactControl_validateForm_Method_Call_Internally(Type[] types)
        {
            var methodvalidateFormParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodvalidateForm, methodvalidateFormParametersTypes);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_validateForm_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_addInternalContactControlInstanceFixture, parametersOfvalidateForm);
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
        public void AUT_AddInternalContactControl_validateForm_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_addInternalContactControlInstanceFixture, out exception1, parametersOfvalidateForm);
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
        public void AUT_AddInternalContactControl_validateForm_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_AddInternalContactControl_validateForm_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_AddInternalContactControl_validateForm_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodcancelContactBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcancelContactBtn_Click, methodcancelContactBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelContactBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcancelContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcancelContactBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcancelContactBtn_Click, methodcancelContactBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addInternalContactControlInstanceFixture, parametersOfcancelContactBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcancelContactBtn_Click.ShouldNotBeNull();
            parametersOfcancelContactBtn_Click.Length.ShouldBe(2);
            methodcancelContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcancelContactBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcancelContactBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelContactBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcancelContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcancelContactBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcancelContactBtn_Click, parametersOfcancelContactBtn_Click, methodcancelContactBtn_ClickParametersTypes);

            // Assert
            parametersOfcancelContactBtn_Click.ShouldNotBeNull();
            parametersOfcancelContactBtn_Click.Length.ShouldBe(2);
            methodcancelContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcancelContactBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcancelContactBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelContactBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcancelContactBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelContactBtn_Click);
            var methodcancelContactBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcancelContactBtn_Click, methodcancelContactBtn_ClickParametersTypes);

            // Assert
            methodcancelContactBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelContactBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddInternalContactControl_cancelContactBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelContactBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcancelContactBtn_Click, 0);

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