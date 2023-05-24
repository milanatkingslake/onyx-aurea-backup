using System;
using System.Diagnostics.CodeAnalysis;
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
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CreateIncidentControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CreateIncidentControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CreateIncidentControl" />)
        /// </summary>
        public CreateIncidentControlTest() : base(typeof(CreateIncidentControl))
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

        #region General Initializer : Class (CreateIncidentControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _createIncidentControlInstanceType;
        private CreateIncidentControl _createIncidentControlInstance;
        private CreateIncidentControl _createIncidentControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CreateIncidentControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _createIncidentControlInstanceType = typeof(CreateIncidentControl);
            _createIncidentControlInstanceFixture = this.Create<CreateIncidentControl>(false);
            _createIncidentControlInstance = _createIncidentControlInstanceFixture ?? this.Create<CreateIncidentControl>(true);
            CurrentInstance = _createIncidentControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Initializer

        #region Properties

        private const string PropertyInternalCategoryName = "InternalCategoryName";
        private const string PropertyDisplayCategoryName = "DisplayCategoryName";

        #endregion

        #region Methods

        private const string MethodpopulateControls = "populateControls";
        private const string MethodsaveIncidentInOnyx_Click = "saveIncidentInOnyx_Click";
        private const string MethodvalidateForm = "validateForm";
        private const string MethodcancelIncidentBtn_Click = "cancelIncidentBtn_Click";
        private const string MethodCreateIncidentControl_Load = "CreateIncidentControl_Load";

        #endregion

        #region Fields

        private const string FieldincidentCategoryId = "incidentCategoryId";
        private const string Fieldowner = "owner";
        private const string Fieldtip = "tip";

        #endregion

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControl_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CreateIncidentControl)

        #region General Initializer : Class (CreateIncidentControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodpopulateControls, 0)]
        [TestCase(MethodsaveIncidentInOnyx_Click, 0)]
        [TestCase(MethodvalidateForm, 0)]
        [TestCase(MethodcancelIncidentBtn_Click, 0)]
        [TestCase(MethodCreateIncidentControl_Load, 0)]
        public void AUT_CreateIncidentControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CreateIncidentControl) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyInternalCategoryName)]
        [TestCase(PropertyDisplayCategoryName)]
        [Category("AUT Property")]
        public void AUT_CreateIncidentControl_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CreateIncidentControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldincidentCategoryId)]
        [TestCase(Fieldowner)]
        [TestCase(Fieldtip)]
        [Category("AUT Fields")]
        public void AUT_CreateIncidentControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CreateIncidentControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CreateIncidentControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _createIncidentControlInstance.ShouldBeAssignableTo<CreateIncidentControl>();
            _createIncidentControlInstanceFixture.ShouldBeAssignableTo<CreateIncidentControl>();
            CurrentInstance.ShouldBeAssignableTo<CreateIncidentControl>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CreateIncidentControl) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyInternalCategoryName)]
        [TestCase(PropertyDisplayCategoryName)]
        public void AUT_CreateIncidentControl_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CreateIncidentControl) => Property (DisplayCategoryName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CreateIncidentControl_DisplayCategoryName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayCategoryName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayCategoryName);
            Action currentAction = () => propertyInfo.SetValue(_createIncidentControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CreateIncidentControl) => Property (DisplayCategoryName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CreateIncidentControl_Public_Class_DisplayCategoryName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayCategoryName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayCategoryName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CreateIncidentControl) => Property (InternalCategoryName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CreateIncidentControl_InternalCategoryName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInternalCategoryName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInternalCategoryName);
            Action currentAction = () => propertyInfo.SetValue(_createIncidentControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CreateIncidentControl) => Property (InternalCategoryName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CreateIncidentControl_Public_Class_InternalCategoryName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInternalCategoryName);
            var propertyInfo = this.GetPropertyInfo(PropertyInternalCategoryName);

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

        #region Method Call : (populateControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_populateControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControls);
            Type [] methodpopulateControlsParametersTypes = null;
            object[] parametersOfpopulateControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControls, methodpopulateControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createIncidentControlInstanceFixture, parametersOfpopulateControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateControls.ShouldBeNull();
            methodpopulateControlsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_populateControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControls);
            Type [] methodpopulateControlsParametersTypes = null;
            object[] parametersOfpopulateControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateControls, parametersOfpopulateControls, methodpopulateControlsParametersTypes);

            // Assert
            parametersOfpopulateControls.ShouldBeNull();
            methodpopulateControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_populateControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControls);
            Type [] methodpopulateControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateControls, methodpopulateControlsParametersTypes);

            // Assert
            methodpopulateControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_populateControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControls);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_Internally(Type[] types)
        {
            var methodsaveIncidentInOnyx_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsaveIncidentInOnyx_Click, methodsaveIncidentInOnyx_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveIncidentInOnyx_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsaveIncidentInOnyx_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsaveIncidentInOnyx_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsaveIncidentInOnyx_Click, methodsaveIncidentInOnyx_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createIncidentControlInstanceFixture, parametersOfsaveIncidentInOnyx_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsaveIncidentInOnyx_Click.ShouldNotBeNull();
            parametersOfsaveIncidentInOnyx_Click.Length.ShouldBe(2);
            methodsaveIncidentInOnyx_ClickParametersTypes.Length.ShouldBe(2);
            methodsaveIncidentInOnyx_ClickParametersTypes.Length.ShouldBe(parametersOfsaveIncidentInOnyx_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveIncidentInOnyx_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodsaveIncidentInOnyx_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfsaveIncidentInOnyx_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsaveIncidentInOnyx_Click, parametersOfsaveIncidentInOnyx_Click, methodsaveIncidentInOnyx_ClickParametersTypes);

            // Assert
            parametersOfsaveIncidentInOnyx_Click.ShouldNotBeNull();
            parametersOfsaveIncidentInOnyx_Click.Length.ShouldBe(2);
            methodsaveIncidentInOnyx_ClickParametersTypes.Length.ShouldBe(2);
            methodsaveIncidentInOnyx_ClickParametersTypes.Length.ShouldBe(parametersOfsaveIncidentInOnyx_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveIncidentInOnyx_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsaveIncidentInOnyx_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveIncidentInOnyx_Click);
            var methodsaveIncidentInOnyx_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsaveIncidentInOnyx_Click, methodsaveIncidentInOnyx_ClickParametersTypes);

            // Assert
            methodsaveIncidentInOnyx_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (saveIncidentInOnyx_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_saveIncidentInOnyx_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsaveIncidentInOnyx_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodsaveIncidentInOnyx_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateIncidentControl_validateForm_Method_Call_Internally(Type[] types)
        {
            var methodvalidateFormParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodvalidateForm, methodvalidateFormParametersTypes);
        }

        #endregion

        #region Method Call : (validateForm) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_validateForm_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_createIncidentControlInstanceFixture, parametersOfvalidateForm);
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
        public void AUT_CreateIncidentControl_validateForm_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodvalidateForm);
            Type [] methodvalidateFormParametersTypes = null;
            object[] parametersOfvalidateForm = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodvalidateForm, methodvalidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_createIncidentControlInstanceFixture, out exception1, parametersOfvalidateForm);
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
        public void AUT_CreateIncidentControl_validateForm_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CreateIncidentControl_validateForm_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CreateIncidentControl_validateForm_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_Internally(Type[] types)
        {
            var methodcancelIncidentBtn_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcancelIncidentBtn_Click, methodcancelIncidentBtn_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelIncidentBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcancelIncidentBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcancelIncidentBtn_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcancelIncidentBtn_Click, methodcancelIncidentBtn_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createIncidentControlInstanceFixture, parametersOfcancelIncidentBtn_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcancelIncidentBtn_Click.ShouldNotBeNull();
            parametersOfcancelIncidentBtn_Click.Length.ShouldBe(2);
            methodcancelIncidentBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcancelIncidentBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcancelIncidentBtn_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelIncidentBtn_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodcancelIncidentBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfcancelIncidentBtn_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodcancelIncidentBtn_Click, parametersOfcancelIncidentBtn_Click, methodcancelIncidentBtn_ClickParametersTypes);

            // Assert
            parametersOfcancelIncidentBtn_Click.ShouldNotBeNull();
            parametersOfcancelIncidentBtn_Click.Length.ShouldBe(2);
            methodcancelIncidentBtn_ClickParametersTypes.Length.ShouldBe(2);
            methodcancelIncidentBtn_ClickParametersTypes.Length.ShouldBe(parametersOfcancelIncidentBtn_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelIncidentBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcancelIncidentBtn_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelIncidentBtn_Click);
            var methodcancelIncidentBtn_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcancelIncidentBtn_Click, methodcancelIncidentBtn_ClickParametersTypes);

            // Assert
            methodcancelIncidentBtn_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (cancelIncidentBtn_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_cancelIncidentBtn_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcancelIncidentBtn_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodcancelIncidentBtn_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_Internally(Type[] types)
        {
            var methodCreateIncidentControl_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateIncidentControl_Load, methodCreateIncidentControl_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncidentControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodCreateIncidentControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfCreateIncidentControl_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncidentControl_Load, methodCreateIncidentControl_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_createIncidentControlInstanceFixture, parametersOfCreateIncidentControl_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateIncidentControl_Load.ShouldNotBeNull();
            parametersOfCreateIncidentControl_Load.Length.ShouldBe(2);
            methodCreateIncidentControl_LoadParametersTypes.Length.ShouldBe(2);
            methodCreateIncidentControl_LoadParametersTypes.Length.ShouldBe(parametersOfCreateIncidentControl_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncidentControl_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodCreateIncidentControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfCreateIncidentControl_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateIncidentControl_Load, parametersOfCreateIncidentControl_Load, methodCreateIncidentControl_LoadParametersTypes);

            // Assert
            parametersOfCreateIncidentControl_Load.ShouldNotBeNull();
            parametersOfCreateIncidentControl_Load.Length.ShouldBe(2);
            methodCreateIncidentControl_LoadParametersTypes.Length.ShouldBe(2);
            methodCreateIncidentControl_LoadParametersTypes.Length.ShouldBe(parametersOfCreateIncidentControl_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncidentControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncidentControl_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncidentControl_Load);
            var methodCreateIncidentControl_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateIncidentControl_Load, methodCreateIncidentControl_LoadParametersTypes);

            // Assert
            methodCreateIncidentControl_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncidentControl_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CreateIncidentControl_CreateIncidentControl_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncidentControl_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncidentControl_Load, 0);

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