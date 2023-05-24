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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.MailItemWrapper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MailItemWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MailItemWrapper" />)
        /// </summary>
        public MailItemWrapperTest() : base(typeof(MailItemWrapper))
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

        #region General Initializer : Class (MailItemWrapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _mailItemWrapperInstanceType;
        private MailItemWrapper _mailItemWrapperInstance;
        private MailItemWrapper _mailItemWrapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MailItemWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mailItemWrapperInstanceType = typeof(MailItemWrapper);
            _mailItemWrapperInstanceFixture = this.Create<MailItemWrapper>(false);
            _mailItemWrapperInstance = _mailItemWrapperInstanceFixture ?? this.Create<MailItemWrapper>(true);
            CurrentInstance = _mailItemWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MailItemWrapper) Initializer

        #region Properties

        private const string PropertyItem = "Item";

        #endregion

        #region Methods

        private const string MethodpopulateInfoPanel = "populateInfoPanel";
        private const string MethodmailItem_PropertyChange = "mailItem_PropertyChange";
        private const string MethodDisposeWrapper = "DisposeWrapper";
        private const string MethodmailItem_Close = "mailItem_Close";

        #endregion

        #region Fields

        private const string Fielditem = "item";
        private const string Fieldtimer = "timer";
        private const string FieldonyxInfoPanel = "onyxInfoPanel";

        #endregion

        #endregion

        #region General Initializer : Class (MailItemWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MailItemWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MailItemWrapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MailItemWrapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MailItemWrapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MailItemWrapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MailItemWrapper)

        #region General Initializer : Class (MailItemWrapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodpopulateInfoPanel, 0)]
        [TestCase(MethodmailItem_PropertyChange, 0)]
        public void AUT_MailItemWrapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MailItemWrapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyItem)]
        [Category("AUT Property")]
        public void AUT_MailItemWrapper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (MailItemWrapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fielditem)]
        [TestCase(Fieldtimer)]
        [TestCase(FieldonyxInfoPanel)]
        [Category("AUT Fields")]
        public void AUT_MailItemWrapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MailItemWrapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MailItemWrapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MailItemWrapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _mailItemWrapperInstance.ShouldBeAssignableTo<MailItemWrapper>();
            _mailItemWrapperInstanceFixture.ShouldBeAssignableTo<MailItemWrapper>();
            CurrentInstance.ShouldBeAssignableTo<MailItemWrapper>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MailItemWrapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyItem)]
        public void AUT_MailItemWrapper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MailItemWrapper) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MailItemWrapper_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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
        public void AUT_MailItemWrapper_populateInfoPanel_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateInfoPanel);
            Type [] methodpopulateInfoPanelParametersTypes = null;
            object[] parametersOfpopulateInfoPanel = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateInfoPanel, methodpopulateInfoPanelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_mailItemWrapperInstanceFixture, parametersOfpopulateInfoPanel);

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
        public void AUT_MailItemWrapper_populateInfoPanel_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_MailItemWrapper_populateInfoPanel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_MailItemWrapper_populateInfoPanel_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_Internally(Type[] types)
        {
            var methodmailItem_PropertyChangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodmailItem_PropertyChange, methodmailItem_PropertyChangeParametersTypes);
        }

        #endregion

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmailItem_PropertyChange);
            var propertyName = this.CreateType<string>();
            var methodmailItem_PropertyChangeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfmailItem_PropertyChange = { propertyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodmailItem_PropertyChange, methodmailItem_PropertyChangeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_mailItemWrapperInstanceFixture, parametersOfmailItem_PropertyChange);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfmailItem_PropertyChange.ShouldNotBeNull();
            parametersOfmailItem_PropertyChange.Length.ShouldBe(1);
            methodmailItem_PropertyChangeParametersTypes.Length.ShouldBe(1);
            methodmailItem_PropertyChangeParametersTypes.Length.ShouldBe(parametersOfmailItem_PropertyChange.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmailItem_PropertyChange);
            var propertyName = this.CreateType<string>();
            var methodmailItem_PropertyChangeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfmailItem_PropertyChange = { propertyName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodmailItem_PropertyChange, parametersOfmailItem_PropertyChange, methodmailItem_PropertyChangeParametersTypes);

            // Assert
            parametersOfmailItem_PropertyChange.ShouldNotBeNull();
            parametersOfmailItem_PropertyChange.Length.ShouldBe(1);
            methodmailItem_PropertyChangeParametersTypes.Length.ShouldBe(1);
            methodmailItem_PropertyChangeParametersTypes.Length.ShouldBe(parametersOfmailItem_PropertyChange.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmailItem_PropertyChange);
            var currentMethodInfo = this.GetMethodInfo(MethodmailItem_PropertyChange, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmailItem_PropertyChange);
            var methodmailItem_PropertyChangeParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodmailItem_PropertyChange, methodmailItem_PropertyChangeParametersTypes);

            // Assert
            methodmailItem_PropertyChangeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (mailItem_PropertyChange) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MailItemWrapper_mailItem_PropertyChange_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmailItem_PropertyChange);
            var currentMethodInfo = this.GetMethodInfo(MethodmailItem_PropertyChange, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisposeWrapper) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MailItemWrapper_DisposeWrapper_Method_Call_Internally(Type[] types)
        {
            var methodDisposeWrapperParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDisposeWrapper, methodDisposeWrapperParametersTypes);
        }

        #endregion

        #region Method Call : (mailItem_Close) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MailItemWrapper_mailItem_Close_Method_Call_Internally(Type[] types)
        {
            var methodmailItem_CloseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodmailItem_Close, methodmailItem_CloseParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}