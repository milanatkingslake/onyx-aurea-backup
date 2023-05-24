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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AppointmentItemWrapper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AppointmentItemWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AppointmentItemWrapper" />)
        /// </summary>
        public AppointmentItemWrapperTest() : base(typeof(AppointmentItemWrapper))
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

        #region General Initializer : Class (AppointmentItemWrapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _appointmentItemWrapperInstanceType;
        private AppointmentItemWrapper _appointmentItemWrapperInstance;
        private AppointmentItemWrapper _appointmentItemWrapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AppointmentItemWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _appointmentItemWrapperInstanceType = typeof(AppointmentItemWrapper);
            _appointmentItemWrapperInstanceFixture = this.Create<AppointmentItemWrapper>(false);
            _appointmentItemWrapperInstance = _appointmentItemWrapperInstanceFixture ?? this.Create<AppointmentItemWrapper>(true);
            CurrentInstance = _appointmentItemWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AppointmentItemWrapper) Initializer

        #region Properties

        private const string PropertyItem = "Item";

        #endregion

        #region Methods

        private const string MethodpopulateInfoPanel = "populateInfoPanel";
        private const string MethodappointmentItemSend = "appointmentItemSend";
        private const string MethodappointmentItemPropertyChange = "appointmentItemPropertyChange";
        private const string MethoddisposeWrapper = "disposeWrapper";
        private const string MethodappointmentItemClose = "appointmentItemClose";

        #endregion

        #region Fields

        private const string Fielditem = "item";
        private const string Fieldtimer = "timer";
        private const string FieldonyxInformationPanel = "onyxInformationPanel";
        private const string FieldnewApptSent = "newApptSent";

        #endregion

        #endregion

        #region General Initializer : Class (AppointmentItemWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AppointmentItemWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AppointmentItemWrapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AppointmentItemWrapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AppointmentItemWrapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AppointmentItemWrapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AppointmentItemWrapper)

        #region General Initializer : Class (AppointmentItemWrapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodpopulateInfoPanel, 0)]
        [TestCase(MethodappointmentItemSend, 0)]
        [TestCase(MethodappointmentItemPropertyChange, 0)]
        [TestCase(MethodpopulateInfoPanel, 1)]
        public void AUT_AppointmentItemWrapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AppointmentItemWrapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyItem)]
        [Category("AUT Property")]
        public void AUT_AppointmentItemWrapper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (AppointmentItemWrapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fielditem)]
        [TestCase(Fieldtimer)]
        [TestCase(FieldonyxInformationPanel)]
        [TestCase(FieldnewApptSent)]
        [Category("AUT Fields")]
        public void AUT_AppointmentItemWrapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AppointmentItemWrapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AppointmentItemWrapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AppointmentItemWrapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _appointmentItemWrapperInstance.ShouldBeAssignableTo<AppointmentItemWrapper>();
            _appointmentItemWrapperInstanceFixture.ShouldBeAssignableTo<AppointmentItemWrapper>();
            CurrentInstance.ShouldBeAssignableTo<AppointmentItemWrapper>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AppointmentItemWrapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyItem)]
        public void AUT_AppointmentItemWrapper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AppointmentItemWrapper) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AppointmentItemWrapper_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var propertyInfo = this.GetPropertyInfo(PropertyItem);

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

        #region Method Call : (populateInfoPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            Type [] methodpopulateInfoPanelParametersTypes = null;
            object[] parametersOfpopulateInfoPanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appointmentItemWrapperInstanceFixture, parametersOfpopulateInfoPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateInfoPanel.ShouldBeNull();
            methodpopulateInfoPanelParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            Type [] methodpopulateInfoPanelParametersTypes = null;
            object[] parametersOfpopulateInfoPanel = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateInfoPanel, parametersOfpopulateInfoPanel, methodpopulateInfoPanelParametersTypes);

            // Assert
            parametersOfpopulateInfoPanel.ShouldBeNull();
            methodpopulateInfoPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            Type [] methodpopulateInfoPanelParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes);

            // Assert
            methodpopulateInfoPanelParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_Internally(Type[] types)
        {
            var methodappointmentItemSendParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappointmentItemSend, methodappointmentItemSendParametersTypes);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemSend);
            var Cancel = this.CreateType<bool>();
            var methodappointmentItemSendParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfappointmentItemSend = { Cancel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemSend, methodappointmentItemSendParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appointmentItemWrapperInstanceFixture, parametersOfappointmentItemSend);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfappointmentItemSend.ShouldNotBeNull();
            parametersOfappointmentItemSend.Length.ShouldBe(1);
            methodappointmentItemSendParametersTypes.Length.ShouldBe(1);
            methodappointmentItemSendParametersTypes.Length.ShouldBe(parametersOfappointmentItemSend.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemSend);
            var Cancel = this.CreateType<bool>();
            var methodappointmentItemSendParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfappointmentItemSend = { Cancel };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodappointmentItemSend, parametersOfappointmentItemSend, methodappointmentItemSendParametersTypes);

            // Assert
            parametersOfappointmentItemSend.ShouldNotBeNull();
            parametersOfappointmentItemSend.Length.ShouldBe(1);
            methodappointmentItemSendParametersTypes.Length.ShouldBe(1);
            methodappointmentItemSendParametersTypes.Length.ShouldBe(parametersOfappointmentItemSend.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemSend);
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemSend, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemSend);
            var methodappointmentItemSendParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodappointmentItemSend, methodappointmentItemSendParametersTypes);

            // Assert
            methodappointmentItemSendParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemSend) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemSend_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemSend);
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemSend, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_Internally(Type[] types)
        {
            var methodappointmentItemPropertyChangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappointmentItemPropertyChange, methodappointmentItemPropertyChangeParametersTypes);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemPropertyChange);
            var propertyName = this.CreateType<string>();
            var methodappointmentItemPropertyChangeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfappointmentItemPropertyChange = { propertyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemPropertyChange, methodappointmentItemPropertyChangeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appointmentItemWrapperInstanceFixture, parametersOfappointmentItemPropertyChange);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfappointmentItemPropertyChange.ShouldNotBeNull();
            parametersOfappointmentItemPropertyChange.Length.ShouldBe(1);
            methodappointmentItemPropertyChangeParametersTypes.Length.ShouldBe(1);
            methodappointmentItemPropertyChangeParametersTypes.Length.ShouldBe(parametersOfappointmentItemPropertyChange.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemPropertyChange);
            var propertyName = this.CreateType<string>();
            var methodappointmentItemPropertyChangeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfappointmentItemPropertyChange = { propertyName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodappointmentItemPropertyChange, parametersOfappointmentItemPropertyChange, methodappointmentItemPropertyChangeParametersTypes);

            // Assert
            parametersOfappointmentItemPropertyChange.ShouldNotBeNull();
            parametersOfappointmentItemPropertyChange.Length.ShouldBe(1);
            methodappointmentItemPropertyChangeParametersTypes.Length.ShouldBe(1);
            methodappointmentItemPropertyChangeParametersTypes.Length.ShouldBe(parametersOfappointmentItemPropertyChange.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemPropertyChange);
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemPropertyChange, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemPropertyChange);
            var methodappointmentItemPropertyChangeParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodappointmentItemPropertyChange, methodappointmentItemPropertyChangeParametersTypes);

            // Assert
            methodappointmentItemPropertyChangeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (appointmentItemPropertyChange) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_appointmentItemPropertyChange_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodappointmentItemPropertyChange);
            var currentMethodInfo = this.GetMethodInfo(MethodappointmentItemPropertyChange, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodpopulateInfoPanelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var outlookItem = this.CreateType<Object>();
            var methodpopulateInfoPanelParametersTypes = new Type[] { typeof(Object) };
            object[] parametersOfpopulateInfoPanel = { outlookItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appointmentItemWrapperInstanceFixture, parametersOfpopulateInfoPanel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateInfoPanel.ShouldNotBeNull();
            parametersOfpopulateInfoPanel.Length.ShouldBe(1);
            methodpopulateInfoPanelParametersTypes.Length.ShouldBe(1);
            methodpopulateInfoPanelParametersTypes.Length.ShouldBe(parametersOfpopulateInfoPanel.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var outlookItem = this.CreateType<Object>();
            var methodpopulateInfoPanelParametersTypes = new Type[] { typeof(Object) };
            object[] parametersOfpopulateInfoPanel = { outlookItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateInfoPanel, parametersOfpopulateInfoPanel, methodpopulateInfoPanelParametersTypes);

            // Assert
            parametersOfpopulateInfoPanel.ShouldNotBeNull();
            parametersOfpopulateInfoPanel.Length.ShouldBe(1);
            methodpopulateInfoPanelParametersTypes.Length.ShouldBe(1);
            methodpopulateInfoPanelParametersTypes.Length.ShouldBe(parametersOfpopulateInfoPanel.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var methodpopulateInfoPanelParametersTypes = new Type[] { typeof(Object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes);

            // Assert
            methodpopulateInfoPanelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateInfoPanel) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppointmentItemWrapper_populateInfoPanel_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (disposeWrapper) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppointmentItemWrapper_disposeWrapper_Method_Call_Internally(Type[] types)
        {
            var methoddisposeWrapperParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethoddisposeWrapper, methoddisposeWrapperParametersTypes);
        }

        #endregion

        #region Method Call : (appointmentItemClose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppointmentItemWrapper_appointmentItemClose_Method_Call_Internally(Type[] types)
        {
            var methodappointmentItemCloseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodappointmentItemClose, methodappointmentItemCloseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}