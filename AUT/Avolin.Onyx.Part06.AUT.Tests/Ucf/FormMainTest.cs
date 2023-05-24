using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.FormMain" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class FormMainTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FormMain" />)
        /// </summary>
        public FormMainTest() : base(typeof(FormMain))
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

        #region General Initializer : Class (FormMain) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _formMainInstanceType;
        private FormMain _formMainInstance;
        private FormMain _formMainInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FormMain" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _formMainInstanceType = typeof(FormMain);
            _formMainInstanceFixture = this.Create<FormMain>(false);
            _formMainInstance = _formMainInstanceFixture ?? this.Create<FormMain>(true);
            CurrentInstance = _formMainInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FormMain) Initializer

        #region Methods

        private const string MethodFormMain_Load = "FormMain_Load";
        private const string MethodbuttonMerge_Click = "buttonMerge_Click";
        private const string MethodtextBoxContextString_TextChanged = "textBoxContextString_TextChanged";
        private const string MethodbuttonAddActions_Click = "buttonAddActions_Click";
        private const string MethodbuttonSave_Click = "buttonSave_Click";
        private const string MethodbuttonDiscard_Click = "buttonDiscard_Click";
        private const string MethodbuttonCompilePage_Click = "buttonCompilePage_Click";
        private const string MethodbuttonCompileSite_Click = "buttonCompileSite_Click";

        #endregion

        #region Fields

        private const string Field_deltaMerge = "_deltaMerge";

        #endregion

        #endregion

        #region General Initializer : Class (FormMain) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FormMain" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_FormMain_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FormMain) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FormMain" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_FormMain_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FormMain)

        #region General Initializer : Class (FormMain) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FormMain" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodFormMain_Load, 0)]
        [TestCase(MethodbuttonMerge_Click, 0)]
        [TestCase(MethodtextBoxContextString_TextChanged, 0)]
        [TestCase(MethodbuttonAddActions_Click, 0)]
        [TestCase(MethodbuttonSave_Click, 0)]
        [TestCase(MethodbuttonDiscard_Click, 0)]
        [TestCase(MethodbuttonCompilePage_Click, 0)]
        [TestCase(MethodbuttonCompileSite_Click, 0)]
        public void AUT_FormMain_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FormMain) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="FormMain" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Field_deltaMerge)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_FormMain_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FormMain) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FormMain" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_FormMain_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _formMainInstance.ShouldBeAssignableTo<FormMain>();
            _formMainInstanceFixture.ShouldBeAssignableTo<FormMain>();
            CurrentInstance.ShouldBeAssignableTo<FormMain>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (FormMain_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_FormMain_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormMain_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodFormMain_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfFormMain_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormMain_Load, methodFormMain_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfFormMain_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormMain_Load.ShouldNotBeNull();
            parametersOfFormMain_Load.Length.ShouldBe(2);
            methodFormMain_LoadParametersTypes.Length.ShouldBe(2);
            methodFormMain_LoadParametersTypes.Length.ShouldBe(parametersOfFormMain_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FormMain_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_FormMain_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormMain_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodFormMain_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfFormMain_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFormMain_Load, parametersOfFormMain_Load, methodFormMain_LoadParametersTypes);

            // Assert
            parametersOfFormMain_Load.ShouldNotBeNull();
            parametersOfFormMain_Load.Length.ShouldBe(2);
            methodFormMain_LoadParametersTypes.Length.ShouldBe(2);
            methodFormMain_LoadParametersTypes.Length.ShouldBe(parametersOfFormMain_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormMain_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_FormMain_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormMain_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodFormMain_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormMain_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_FormMain_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormMain_Load);
            var methodFormMain_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormMain_Load, methodFormMain_LoadParametersTypes);

            // Assert
            methodFormMain_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormMain_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_FormMain_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormMain_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodFormMain_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonMerge_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonMerge_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonMerge_Click, methodbuttonMerge_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonMerge_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonMerge_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonMerge_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonMerge_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonMerge_Click, methodbuttonMerge_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonMerge_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonMerge_Click.ShouldNotBeNull();
            parametersOfbuttonMerge_Click.Length.ShouldBe(2);
            methodbuttonMerge_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonMerge_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonMerge_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonMerge_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonMerge_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonMerge_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonMerge_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonMerge_Click, parametersOfbuttonMerge_Click, methodbuttonMerge_ClickParametersTypes);

            // Assert
            parametersOfbuttonMerge_Click.ShouldNotBeNull();
            parametersOfbuttonMerge_Click.Length.ShouldBe(2);
            methodbuttonMerge_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonMerge_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonMerge_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonMerge_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonMerge_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonMerge_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonMerge_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonMerge_Click);
            var methodbuttonMerge_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonMerge_Click, methodbuttonMerge_ClickParametersTypes);

            // Assert
            methodbuttonMerge_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonMerge_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonMerge_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonMerge_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonMerge_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_Internally(Type[] types)
        {
            var methodtextBoxContextString_TextChangedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtextBoxContextString_TextChanged, methodtextBoxContextString_TextChangedParametersTypes);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtextBoxContextString_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtextBoxContextString_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftextBoxContextString_TextChanged = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtextBoxContextString_TextChanged, methodtextBoxContextString_TextChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOftextBoxContextString_TextChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftextBoxContextString_TextChanged.ShouldNotBeNull();
            parametersOftextBoxContextString_TextChanged.Length.ShouldBe(2);
            methodtextBoxContextString_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtextBoxContextString_TextChangedParametersTypes.Length.ShouldBe(parametersOftextBoxContextString_TextChanged.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtextBoxContextString_TextChanged);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtextBoxContextString_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftextBoxContextString_TextChanged = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtextBoxContextString_TextChanged, parametersOftextBoxContextString_TextChanged, methodtextBoxContextString_TextChangedParametersTypes);

            // Assert
            parametersOftextBoxContextString_TextChanged.ShouldNotBeNull();
            parametersOftextBoxContextString_TextChanged.Length.ShouldBe(2);
            methodtextBoxContextString_TextChangedParametersTypes.Length.ShouldBe(2);
            methodtextBoxContextString_TextChangedParametersTypes.Length.ShouldBe(parametersOftextBoxContextString_TextChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtextBoxContextString_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtextBoxContextString_TextChanged, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtextBoxContextString_TextChanged);
            var methodtextBoxContextString_TextChangedParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtextBoxContextString_TextChanged, methodtextBoxContextString_TextChangedParametersTypes);

            // Assert
            methodtextBoxContextString_TextChangedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (textBoxContextString_TextChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_textBoxContextString_TextChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtextBoxContextString_TextChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodtextBoxContextString_TextChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonAddActions_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonAddActions_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonAddActions_Click, methodbuttonAddActions_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonAddActions_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonAddActions_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonAddActions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonAddActions_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonAddActions_Click, methodbuttonAddActions_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonAddActions_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonAddActions_Click.ShouldNotBeNull();
            parametersOfbuttonAddActions_Click.Length.ShouldBe(2);
            methodbuttonAddActions_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonAddActions_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonAddActions_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonAddActions_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonAddActions_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonAddActions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonAddActions_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonAddActions_Click, parametersOfbuttonAddActions_Click, methodbuttonAddActions_ClickParametersTypes);

            // Assert
            parametersOfbuttonAddActions_Click.ShouldNotBeNull();
            parametersOfbuttonAddActions_Click.Length.ShouldBe(2);
            methodbuttonAddActions_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonAddActions_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonAddActions_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonAddActions_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonAddActions_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonAddActions_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonAddActions_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonAddActions_Click);
            var methodbuttonAddActions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonAddActions_Click, methodbuttonAddActions_ClickParametersTypes);

            // Assert
            methodbuttonAddActions_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonAddActions_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonAddActions_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonAddActions_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonAddActions_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonSave_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonSave_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonSave_Click, methodbuttonSave_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonSave_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonSave_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonSave_Click, methodbuttonSave_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonSave_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonSave_Click.ShouldNotBeNull();
            parametersOfbuttonSave_Click.Length.ShouldBe(2);
            methodbuttonSave_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonSave_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonSave_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonSave_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonSave_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonSave_Click, parametersOfbuttonSave_Click, methodbuttonSave_ClickParametersTypes);

            // Assert
            parametersOfbuttonSave_Click.ShouldNotBeNull();
            parametersOfbuttonSave_Click.Length.ShouldBe(2);
            methodbuttonSave_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonSave_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonSave_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonSave_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonSave_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonSave_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonSave_Click);
            var methodbuttonSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonSave_Click, methodbuttonSave_ClickParametersTypes);

            // Assert
            methodbuttonSave_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonSave_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonSave_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonSave_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonDiscard_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonDiscard_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonDiscard_Click, methodbuttonDiscard_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonDiscard_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonDiscard_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonDiscard_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonDiscard_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonDiscard_Click, methodbuttonDiscard_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonDiscard_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonDiscard_Click.ShouldNotBeNull();
            parametersOfbuttonDiscard_Click.Length.ShouldBe(2);
            methodbuttonDiscard_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonDiscard_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonDiscard_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonDiscard_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonDiscard_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonDiscard_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonDiscard_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonDiscard_Click, parametersOfbuttonDiscard_Click, methodbuttonDiscard_ClickParametersTypes);

            // Assert
            parametersOfbuttonDiscard_Click.ShouldNotBeNull();
            parametersOfbuttonDiscard_Click.Length.ShouldBe(2);
            methodbuttonDiscard_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonDiscard_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonDiscard_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonDiscard_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonDiscard_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonDiscard_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonDiscard_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonDiscard_Click);
            var methodbuttonDiscard_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonDiscard_Click, methodbuttonDiscard_ClickParametersTypes);

            // Assert
            methodbuttonDiscard_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonDiscard_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonDiscard_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonDiscard_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonDiscard_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonCompilePage_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonCompilePage_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonCompilePage_Click, methodbuttonCompilePage_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompilePage_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompilePage_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonCompilePage_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonCompilePage_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompilePage_Click, methodbuttonCompilePage_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonCompilePage_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonCompilePage_Click.ShouldNotBeNull();
            parametersOfbuttonCompilePage_Click.Length.ShouldBe(2);
            methodbuttonCompilePage_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonCompilePage_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonCompilePage_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompilePage_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompilePage_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonCompilePage_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonCompilePage_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonCompilePage_Click, parametersOfbuttonCompilePage_Click, methodbuttonCompilePage_ClickParametersTypes);

            // Assert
            parametersOfbuttonCompilePage_Click.ShouldNotBeNull();
            parametersOfbuttonCompilePage_Click.Length.ShouldBe(2);
            methodbuttonCompilePage_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonCompilePage_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonCompilePage_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompilePage_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompilePage_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompilePage_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompilePage_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompilePage_Click);
            var methodbuttonCompilePage_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonCompilePage_Click, methodbuttonCompilePage_ClickParametersTypes);

            // Assert
            methodbuttonCompilePage_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompilePage_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompilePage_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompilePage_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompilePage_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormMain_buttonCompileSite_Click_Method_Call_Internally(Type[] types)
        {
            var methodbuttonCompileSite_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbuttonCompileSite_Click, methodbuttonCompileSite_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompileSite_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompileSite_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonCompileSite_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonCompileSite_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompileSite_Click, methodbuttonCompileSite_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formMainInstanceFixture, parametersOfbuttonCompileSite_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbuttonCompileSite_Click.ShouldNotBeNull();
            parametersOfbuttonCompileSite_Click.Length.ShouldBe(2);
            methodbuttonCompileSite_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonCompileSite_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonCompileSite_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompileSite_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompileSite_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbuttonCompileSite_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbuttonCompileSite_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbuttonCompileSite_Click, parametersOfbuttonCompileSite_Click, methodbuttonCompileSite_ClickParametersTypes);

            // Assert
            parametersOfbuttonCompileSite_Click.ShouldNotBeNull();
            parametersOfbuttonCompileSite_Click.Length.ShouldBe(2);
            methodbuttonCompileSite_ClickParametersTypes.Length.ShouldBe(2);
            methodbuttonCompileSite_ClickParametersTypes.Length.ShouldBe(parametersOfbuttonCompileSite_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompileSite_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompileSite_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompileSite_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompileSite_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompileSite_Click);
            var methodbuttonCompileSite_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbuttonCompileSite_Click, methodbuttonCompileSite_ClickParametersTypes);

            // Assert
            methodbuttonCompileSite_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (buttonCompileSite_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_FormMain_buttonCompileSite_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbuttonCompileSite_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbuttonCompileSite_Click, 0);

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