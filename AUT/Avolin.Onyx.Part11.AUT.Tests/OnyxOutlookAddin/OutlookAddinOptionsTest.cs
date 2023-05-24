using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OutlookAddinOptions" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OutlookAddinOptionsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookAddinOptions" />)
        /// </summary>
        public OutlookAddinOptionsTest() : base(typeof(OutlookAddinOptions))
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

        #region General Initializer : Class (OutlookAddinOptions) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookAddinOptionsInstanceType;
        private OutlookAddinOptions _outlookAddinOptionsInstance;
        private OutlookAddinOptions _outlookAddinOptionsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookAddinOptions" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookAddinOptionsInstanceType = typeof(OutlookAddinOptions);
            _outlookAddinOptionsInstanceFixture = this.Create<OutlookAddinOptions>(false);
            _outlookAddinOptionsInstance = _outlookAddinOptionsInstanceFixture ?? this.Create<OutlookAddinOptions>(true);
            CurrentInstance = _outlookAddinOptionsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookAddinOptions) Initializer

        #region Methods

        private const string MethodinitUserPreferencePanel = "initUserPreferencePanel";
        private const string MethodinitAppSettingsPanel = "initAppSettingsPanel";
        private const string MethodtsbUserPreferences_Click = "tsbUserPreferences_Click";
        private const string MethodtsbAddinOptions_Click = "tsbAddinOptions_Click";
        private const string MethodshowPanel = "showPanel";
        private const string MethodOutlookAddinOptions_Load = "OutlookAddinOptions_Load";

        #endregion

        #region Fields

        private const string Fieldpref = "pref";
        private const string Fieldsettings = "settings";
        private const string FieldResult = "Result";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookAddinOptions) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OutlookAddinOptions_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookAddinOptions) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OutlookAddinOptions_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookAddinOptions)

        #region General Initializer : Class (OutlookAddinOptions) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodinitUserPreferencePanel, 0)]
        [TestCase(MethodinitAppSettingsPanel, 0)]
        [TestCase(MethodtsbUserPreferences_Click, 0)]
        [TestCase(MethodtsbAddinOptions_Click, 0)]
        [TestCase(MethodshowPanel, 0)]
        [TestCase(MethodOutlookAddinOptions_Load, 0)]
        public void AUT_OutlookAddinOptions_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OutlookAddinOptions) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldpref)]
        [TestCase(Fieldsettings)]
        [TestCase(FieldResult)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OutlookAddinOptions_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookAddinOptions) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OutlookAddinOptions_Is_Instance_Present_Test()
        {
            // Assert
            _outlookAddinOptionsInstanceType.ShouldNotBeNull();
            _outlookAddinOptionsInstance.ShouldNotBeNull();
            _outlookAddinOptionsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookAddinOptions) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookAddinOptions" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OutlookAddinOptions_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookAddinOptionsInstance.ShouldBeAssignableTo<OutlookAddinOptions>();
            _outlookAddinOptionsInstanceFixture.ShouldBeAssignableTo<OutlookAddinOptions>();
            CurrentInstance.ShouldBeAssignableTo<OutlookAddinOptions>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookAddinOptions) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_OutlookAddinOptions_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OutlookAddinOptions instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (initUserPreferencePanel) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initUserPreferencePanel_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitUserPreferencePanel);
            Type [] methodinitUserPreferencePanelParametersTypes = null;
            object[] parametersOfinitUserPreferencePanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitUserPreferencePanel, methodinitUserPreferencePanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOfinitUserPreferencePanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinitUserPreferencePanel.ShouldBeNull();
            methodinitUserPreferencePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initUserPreferencePanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initUserPreferencePanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitUserPreferencePanel);
            Type [] methodinitUserPreferencePanelParametersTypes = null;
            object[] parametersOfinitUserPreferencePanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinitUserPreferencePanel, parametersOfinitUserPreferencePanel, methodinitUserPreferencePanelParametersTypes);

            // Assert
            parametersOfinitUserPreferencePanel.ShouldBeNull();
            methodinitUserPreferencePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initUserPreferencePanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initUserPreferencePanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitUserPreferencePanel);
            Type [] methodinitUserPreferencePanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinitUserPreferencePanel, methodinitUserPreferencePanelParametersTypes);

            // Assert
            methodinitUserPreferencePanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initUserPreferencePanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initUserPreferencePanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitUserPreferencePanel);
            var currentMethodInfo = this.GetMethodInfo(MethodinitUserPreferencePanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAppSettingsPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookAddinOptions_initAppSettingsPanel_Method_Call_Internally(Type[] types)
        {
            var methodinitAppSettingsPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodinitAppSettingsPanel, methodinitAppSettingsPanelParametersTypes);
        }

        #endregion

        #region Method Call : (initAppSettingsPanel) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initAppSettingsPanel_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAppSettingsPanel);
            Type [] methodinitAppSettingsPanelParametersTypes = null;
            object[] parametersOfinitAppSettingsPanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitAppSettingsPanel, methodinitAppSettingsPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOfinitAppSettingsPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinitAppSettingsPanel.ShouldBeNull();
            methodinitAppSettingsPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAppSettingsPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initAppSettingsPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAppSettingsPanel);
            Type [] methodinitAppSettingsPanelParametersTypes = null;
            object[] parametersOfinitAppSettingsPanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinitAppSettingsPanel, parametersOfinitAppSettingsPanel, methodinitAppSettingsPanelParametersTypes);

            // Assert
            parametersOfinitAppSettingsPanel.ShouldBeNull();
            methodinitAppSettingsPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAppSettingsPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initAppSettingsPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAppSettingsPanel);
            Type [] methodinitAppSettingsPanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinitAppSettingsPanel, methodinitAppSettingsPanelParametersTypes);

            // Assert
            methodinitAppSettingsPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initAppSettingsPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_initAppSettingsPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitAppSettingsPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodinitAppSettingsPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_Internally(Type[] types)
        {
            var methodtsbUserPreferences_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtsbUserPreferences_Click, methodtsbUserPreferences_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbUserPreferences_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtsbUserPreferences_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftsbUserPreferences_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtsbUserPreferences_Click, methodtsbUserPreferences_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOftsbUserPreferences_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftsbUserPreferences_Click.ShouldNotBeNull();
            parametersOftsbUserPreferences_Click.Length.ShouldBe(2);
            methodtsbUserPreferences_ClickParametersTypes.Length.ShouldBe(2);
            methodtsbUserPreferences_ClickParametersTypes.Length.ShouldBe(parametersOftsbUserPreferences_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbUserPreferences_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtsbUserPreferences_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftsbUserPreferences_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtsbUserPreferences_Click, parametersOftsbUserPreferences_Click, methodtsbUserPreferences_ClickParametersTypes);

            // Assert
            parametersOftsbUserPreferences_Click.ShouldNotBeNull();
            parametersOftsbUserPreferences_Click.Length.ShouldBe(2);
            methodtsbUserPreferences_ClickParametersTypes.Length.ShouldBe(2);
            methodtsbUserPreferences_ClickParametersTypes.Length.ShouldBe(parametersOftsbUserPreferences_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbUserPreferences_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtsbUserPreferences_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbUserPreferences_Click);
            var methodtsbUserPreferences_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtsbUserPreferences_Click, methodtsbUserPreferences_ClickParametersTypes);

            // Assert
            methodtsbUserPreferences_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbUserPreferences_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbUserPreferences_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbUserPreferences_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtsbUserPreferences_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_Internally(Type[] types)
        {
            var methodtsbAddinOptions_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtsbAddinOptions_Click, methodtsbAddinOptions_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbAddinOptions_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtsbAddinOptions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftsbAddinOptions_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodtsbAddinOptions_Click, methodtsbAddinOptions_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOftsbAddinOptions_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOftsbAddinOptions_Click.ShouldNotBeNull();
            parametersOftsbAddinOptions_Click.Length.ShouldBe(2);
            methodtsbAddinOptions_ClickParametersTypes.Length.ShouldBe(2);
            methodtsbAddinOptions_ClickParametersTypes.Length.ShouldBe(parametersOftsbAddinOptions_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbAddinOptions_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodtsbAddinOptions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOftsbAddinOptions_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodtsbAddinOptions_Click, parametersOftsbAddinOptions_Click, methodtsbAddinOptions_ClickParametersTypes);

            // Assert
            parametersOftsbAddinOptions_Click.ShouldNotBeNull();
            parametersOftsbAddinOptions_Click.Length.ShouldBe(2);
            methodtsbAddinOptions_ClickParametersTypes.Length.ShouldBe(2);
            methodtsbAddinOptions_ClickParametersTypes.Length.ShouldBe(parametersOftsbAddinOptions_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbAddinOptions_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtsbAddinOptions_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbAddinOptions_Click);
            var methodtsbAddinOptions_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtsbAddinOptions_Click, methodtsbAddinOptions_ClickParametersTypes);

            // Assert
            methodtsbAddinOptions_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (tsbAddinOptions_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_tsbAddinOptions_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtsbAddinOptions_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodtsbAddinOptions_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookAddinOptions_showPanel_Method_Call_Internally(Type[] types)
        {
            var methodshowPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodshowPanel, methodshowPanelParametersTypes);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_showPanel_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodshowPanel);
            var panelName = this.CreateType<string>();
            var methodshowPanelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfshowPanel = { panelName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodshowPanel, methodshowPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOfshowPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfshowPanel.ShouldNotBeNull();
            parametersOfshowPanel.Length.ShouldBe(1);
            methodshowPanelParametersTypes.Length.ShouldBe(1);
            methodshowPanelParametersTypes.Length.ShouldBe(parametersOfshowPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_showPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodshowPanel);
            var panelName = this.CreateType<string>();
            var methodshowPanelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfshowPanel = { panelName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodshowPanel, parametersOfshowPanel, methodshowPanelParametersTypes);

            // Assert
            parametersOfshowPanel.ShouldNotBeNull();
            parametersOfshowPanel.Length.ShouldBe(1);
            methodshowPanelParametersTypes.Length.ShouldBe(1);
            methodshowPanelParametersTypes.Length.ShouldBe(parametersOfshowPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_showPanel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodshowPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodshowPanel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_showPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodshowPanel);
            var methodshowPanelParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodshowPanel, methodshowPanelParametersTypes);

            // Assert
            methodshowPanelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (showPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_showPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodshowPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodshowPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_Internally(Type[] types)
        {
            var methodOutlookAddinOptions_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOutlookAddinOptions_Load, methodOutlookAddinOptions_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookAddinOptions_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOutlookAddinOptions_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOutlookAddinOptions_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOutlookAddinOptions_Load, methodOutlookAddinOptions_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_outlookAddinOptionsInstanceFixture, parametersOfOutlookAddinOptions_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOutlookAddinOptions_Load.ShouldNotBeNull();
            parametersOfOutlookAddinOptions_Load.Length.ShouldBe(2);
            methodOutlookAddinOptions_LoadParametersTypes.Length.ShouldBe(2);
            methodOutlookAddinOptions_LoadParametersTypes.Length.ShouldBe(parametersOfOutlookAddinOptions_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookAddinOptions_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodOutlookAddinOptions_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfOutlookAddinOptions_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOutlookAddinOptions_Load, parametersOfOutlookAddinOptions_Load, methodOutlookAddinOptions_LoadParametersTypes);

            // Assert
            parametersOfOutlookAddinOptions_Load.ShouldNotBeNull();
            parametersOfOutlookAddinOptions_Load.Length.ShouldBe(2);
            methodOutlookAddinOptions_LoadParametersTypes.Length.ShouldBe(2);
            methodOutlookAddinOptions_LoadParametersTypes.Length.ShouldBe(parametersOfOutlookAddinOptions_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookAddinOptions_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodOutlookAddinOptions_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookAddinOptions_Load);
            var methodOutlookAddinOptions_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOutlookAddinOptions_Load, methodOutlookAddinOptions_LoadParametersTypes);

            // Assert
            methodOutlookAddinOptions_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OutlookAddinOptions_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OutlookAddinOptions_OutlookAddinOptions_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOutlookAddinOptions_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodOutlookAddinOptions_Load, 0);

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