using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AddinSettings" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class AddinSettingsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AddinSettings" />)
        /// </summary>
        public AddinSettingsTest() : base(typeof(AddinSettings))
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

        #region General Initializer : Class (AddinSettings) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _addinSettingsInstanceType;
        private AddinSettings _addinSettingsInstance;
        private AddinSettings _addinSettingsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AddinSettings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addinSettingsInstanceType = typeof(AddinSettings);
            _addinSettingsInstanceFixture = this.Create<AddinSettings>(false);
            _addinSettingsInstance = _addinSettingsInstanceFixture ?? this.Create<AddinSettings>(true);
            CurrentInstance = _addinSettingsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddinSettings) Initializer

        #region Methods

        private const string MethodpopulateControl = "populateControl";
        private const string MethodaddTextbox = "addTextbox";
        private const string MethodflowSettingsLayoutPanel_Paint = "flowSettingsLayoutPanel_Paint";
        private const string MethodAddinSettings_Load = "AddinSettings_Load";

        #endregion

        #endregion

        #region General Initializer : Class (AddinSettings) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_AddinSettings_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AddinSettings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_AddinSettings_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AddinSettings)

        #region General Initializer : Class (AddinSettings) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodpopulateControl, 0)]
        [TestCase(MethodaddTextbox, 0)]
        [TestCase(MethodflowSettingsLayoutPanel_Paint, 0)]
        [TestCase(MethodAddinSettings_Load, 0)]
        public void AUT_AddinSettings_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (AddinSettings) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_AddinSettings_Is_Instance_Present_Test()
        {
            // Assert
            _addinSettingsInstanceType.ShouldNotBeNull();
            _addinSettingsInstance.ShouldNotBeNull();
            _addinSettingsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AddinSettings) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_AddinSettings_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _addinSettingsInstance.ShouldBeAssignableTo<AddinSettings>();
            _addinSettingsInstanceFixture.ShouldBeAssignableTo<AddinSettings>();
            CurrentInstance.ShouldBeAssignableTo<AddinSettings>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AddinSettings) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_AddinSettings_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AddinSettings instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (populateControl) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_populateControl_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;
            object[] parametersOfpopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControl, methodpopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addinSettingsInstanceFixture, parametersOfpopulateControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateControl.ShouldBeNull();
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_populateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;
            object[] parametersOfpopulateControl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateControl, parametersOfpopulateControl, methodpopulateControlParametersTypes);

            // Assert
            parametersOfpopulateControl.ShouldBeNull();
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_populateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateControl, methodpopulateControlParametersTypes);

            // Assert
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_populateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddinSettings_addTextbox_Method_Call_Internally(Type[] types)
        {
            var methodaddTextboxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddTextbox, methodaddTextboxParametersTypes);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_addTextbox_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddTextbox);
            var label = this.CreateType<string>();
            var value = this.CreateType<object>();
            var methodaddTextboxParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfaddTextbox = { label, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddTextbox, methodaddTextboxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addinSettingsInstanceFixture, parametersOfaddTextbox);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddTextbox.ShouldNotBeNull();
            parametersOfaddTextbox.Length.ShouldBe(2);
            methodaddTextboxParametersTypes.Length.ShouldBe(2);
            methodaddTextboxParametersTypes.Length.ShouldBe(parametersOfaddTextbox.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_addTextbox_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddTextbox);
            var label = this.CreateType<string>();
            var value = this.CreateType<object>();
            var methodaddTextboxParametersTypes = new Type[] { typeof(string), typeof(object) };
            object[] parametersOfaddTextbox = { label, value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddTextbox, parametersOfaddTextbox, methodaddTextboxParametersTypes);

            // Assert
            parametersOfaddTextbox.ShouldNotBeNull();
            parametersOfaddTextbox.Length.ShouldBe(2);
            methodaddTextboxParametersTypes.Length.ShouldBe(2);
            methodaddTextboxParametersTypes.Length.ShouldBe(parametersOfaddTextbox.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_addTextbox_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddTextbox);
            var currentMethodInfo = this.GetMethodInfo(MethodaddTextbox, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_addTextbox_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddTextbox);
            var methodaddTextboxParametersTypes = new Type[] { typeof(string), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddTextbox, methodaddTextboxParametersTypes);

            // Assert
            methodaddTextboxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addTextbox) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_addTextbox_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddTextbox);
            var currentMethodInfo = this.GetMethodInfo(MethodaddTextbox, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_Internally(Type[] types)
        {
            var methodflowSettingsLayoutPanel_PaintParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodflowSettingsLayoutPanel_Paint, methodflowSettingsLayoutPanel_PaintParametersTypes);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodflowSettingsLayoutPanel_Paint);
            var sender = this.CreateType<object>();
            var e = this.CreateType<PaintEventArgs>();
            var methodflowSettingsLayoutPanel_PaintParametersTypes = new Type[] { typeof(object), typeof(PaintEventArgs) };
            object[] parametersOfflowSettingsLayoutPanel_Paint = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodflowSettingsLayoutPanel_Paint, methodflowSettingsLayoutPanel_PaintParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addinSettingsInstanceFixture, parametersOfflowSettingsLayoutPanel_Paint);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfflowSettingsLayoutPanel_Paint.ShouldNotBeNull();
            parametersOfflowSettingsLayoutPanel_Paint.Length.ShouldBe(2);
            methodflowSettingsLayoutPanel_PaintParametersTypes.Length.ShouldBe(2);
            methodflowSettingsLayoutPanel_PaintParametersTypes.Length.ShouldBe(parametersOfflowSettingsLayoutPanel_Paint.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodflowSettingsLayoutPanel_Paint);
            var sender = this.CreateType<object>();
            var e = this.CreateType<PaintEventArgs>();
            var methodflowSettingsLayoutPanel_PaintParametersTypes = new Type[] { typeof(object), typeof(PaintEventArgs) };
            object[] parametersOfflowSettingsLayoutPanel_Paint = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodflowSettingsLayoutPanel_Paint, parametersOfflowSettingsLayoutPanel_Paint, methodflowSettingsLayoutPanel_PaintParametersTypes);

            // Assert
            parametersOfflowSettingsLayoutPanel_Paint.ShouldNotBeNull();
            parametersOfflowSettingsLayoutPanel_Paint.Length.ShouldBe(2);
            methodflowSettingsLayoutPanel_PaintParametersTypes.Length.ShouldBe(2);
            methodflowSettingsLayoutPanel_PaintParametersTypes.Length.ShouldBe(parametersOfflowSettingsLayoutPanel_Paint.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodflowSettingsLayoutPanel_Paint);
            var currentMethodInfo = this.GetMethodInfo(MethodflowSettingsLayoutPanel_Paint, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodflowSettingsLayoutPanel_Paint);
            var methodflowSettingsLayoutPanel_PaintParametersTypes = new Type[] { typeof(object), typeof(PaintEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodflowSettingsLayoutPanel_Paint, methodflowSettingsLayoutPanel_PaintParametersTypes);

            // Assert
            methodflowSettingsLayoutPanel_PaintParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (flowSettingsLayoutPanel_Paint) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_flowSettingsLayoutPanel_Paint_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodflowSettingsLayoutPanel_Paint);
            var currentMethodInfo = this.GetMethodInfo(MethodflowSettingsLayoutPanel_Paint, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddinSettings_AddinSettings_Load_Method_Call_Internally(Type[] types)
        {
            var methodAddinSettings_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddinSettings_Load, methodAddinSettings_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_AddinSettings_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddinSettings_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodAddinSettings_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfAddinSettings_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddinSettings_Load, methodAddinSettings_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addinSettingsInstanceFixture, parametersOfAddinSettings_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddinSettings_Load.ShouldNotBeNull();
            parametersOfAddinSettings_Load.Length.ShouldBe(2);
            methodAddinSettings_LoadParametersTypes.Length.ShouldBe(2);
            methodAddinSettings_LoadParametersTypes.Length.ShouldBe(parametersOfAddinSettings_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_AddinSettings_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddinSettings_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodAddinSettings_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfAddinSettings_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddinSettings_Load, parametersOfAddinSettings_Load, methodAddinSettings_LoadParametersTypes);

            // Assert
            parametersOfAddinSettings_Load.ShouldNotBeNull();
            parametersOfAddinSettings_Load.Length.ShouldBe(2);
            methodAddinSettings_LoadParametersTypes.Length.ShouldBe(2);
            methodAddinSettings_LoadParametersTypes.Length.ShouldBe(parametersOfAddinSettings_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_AddinSettings_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddinSettings_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodAddinSettings_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_AddinSettings_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddinSettings_Load);
            var methodAddinSettings_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddinSettings_Load, methodAddinSettings_LoadParametersTypes);

            // Assert
            methodAddinSettings_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddinSettings_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_AddinSettings_AddinSettings_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddinSettings_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodAddinSettings_Load, 0);

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