using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CustomerInfo" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CustomerInfoTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerInfo" />)
        /// </summary>
        public CustomerInfoTest() : base(typeof(CustomerInfo))
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

        #region General Initializer : Class (CustomerInfo) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerInfoInstanceType;
        private CustomerInfo _customerInfoInstance;
        private CustomerInfo _customerInfoInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerInfo" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerInfoInstanceType = typeof(CustomerInfo);
            _customerInfoInstanceFixture = this.Create<CustomerInfo>(false);
            _customerInfoInstance = _customerInfoInstanceFixture ?? this.Create<CustomerInfo>(true);
            CurrentInstance = _customerInfoInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomerInfo) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyIsPopulated = "IsPopulated";
        private const string PropertyIsNeedsRefresh = "IsNeedsRefresh";
        private const string PropertyCustomControlId = "CustomControlId";

        #endregion

        #region Methods

        private const string MethodAddControlToTree = "AddControlToTree";
        private const string MethodResetTableLayoutPanels = "ResetTableLayoutPanels";
        private const string MethodBindNewCustomer = "BindNewCustomer";
        private const string MethodPopulateControl = "PopulateControl";
        private const string MethodpopulateCustomerInfo = "populateCustomerInfo";
        private const string MethodcreateTextBox = "createTextBox";
        private const string MethodaddChildListControls = "addChildListControls";

        #endregion

        #region Fields

        private const string Fieldcustomer = "customer";
        private const string Fieldpopulated = "populated";
        private const string FieldneedsRefresh = "needsRefresh";
        private const string FieldcontrolId = "controlId";
        private const string FieldoldControlId = "oldControlId";
        private const string FieldisDisplayDetail = "isDisplayDetail";
        private const string FieldinfoPanel = "infoPanel";

        #endregion

        #endregion

        #region General Initializer : Class (CustomerInfo) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerInfo_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerInfo) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerInfo_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerInfo) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerInfo_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomerInfo)

        #region General Initializer : Class (CustomerInfo) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddControlToTree, 0)]
        [TestCase(MethodResetTableLayoutPanels, 0)]
        [TestCase(MethodBindNewCustomer, 0)]
        [TestCase(MethodPopulateControl, 0)]
        [TestCase(MethodpopulateCustomerInfo, 0)]
        [TestCase(MethodcreateTextBox, 0)]
        [TestCase(MethodaddChildListControls, 0)]
        public void AUT_CustomerInfo_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomerInfo) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyCustomControlId)]
        [Category("AUT Property")]
        public void AUT_CustomerInfo_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CustomerInfo) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcustomer)]
        [TestCase(Fieldpopulated)]
        [TestCase(FieldneedsRefresh)]
        [TestCase(FieldcontrolId)]
        [TestCase(FieldoldControlId)]
        [TestCase(FieldisDisplayDetail)]
        [TestCase(FieldinfoPanel)]
        [Category("AUT Fields")]
        public void AUT_CustomerInfo_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CustomerInfo) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerInfo_Is_Instance_Present_Test()
        {
            // Assert
            _customerInfoInstanceType.ShouldNotBeNull();
            _customerInfoInstance.ShouldNotBeNull();
            _customerInfoInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomerInfo) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomerInfo" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerInfo_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customerInfoInstance.ShouldBeAssignableTo<CustomerInfo>();
            _customerInfoInstanceFixture.ShouldBeAssignableTo<CustomerInfo>();
            CurrentInstance.ShouldBeAssignableTo<CustomerInfo>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CustomerInfo) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CustomerInfo_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramCustomer = this.CreateType<OnyxIndividual>();
            var detail = this.CreateType<bool>();
            var paramInfoPanel = this.CreateType<OnyxInfoPanel>();
            CustomerInfo instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CustomerInfo(paramCustomer, detail, paramInfoPanel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _customerInfoInstance.ShouldNotBeNull();
            _customerInfoInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<CustomerInfo>();
        }

        #endregion

        #region General Constructor : Class (CustomerInfo) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CustomerInfo_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramCustomer = this.CreateType<OnyxIndividual>();
            var detail = this.CreateType<bool>();
            var paramInfoPanel = this.CreateType<OnyxInfoPanel>();
            CustomerInfo instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CustomerInfo(paramCustomer, detail, paramInfoPanel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _customerInfoInstance.ShouldNotBeNull();
            _customerInfoInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CustomerInfo) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyCustomControlId)]
        public void AUT_CustomerInfo_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CustomerInfo) => Property (CustomControlId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_CustomControlId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);
            Action currentAction = () => propertyInfo.SetValue(_customerInfoInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CustomerInfo) => Property (CustomControlId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_Public_Class_CustomControlId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerInfo) => Property (Id) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_Id_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyId);
            Action currentAction = () => propertyInfo.SetValue(_customerInfoInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CustomerInfo) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerInfo) => Property (IsNeedsRefresh) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_Public_Class_IsNeedsRefresh_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsNeedsRefresh);
            var propertyInfo = this.GetPropertyInfo(PropertyIsNeedsRefresh);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerInfo) => Property (IsPopulated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerInfo_Public_Class_IsPopulated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsPopulated);
            var propertyInfo = this.GetPropertyInfo(PropertyIsPopulated);

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

        #region Method Call : (AddControlToTree) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _customerInfoInstance.AddControlToTree(parentControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddControlToTree = { parentControlId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, methodAddControlToTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfAddControlToTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddControlToTree = { parentControlId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddControlToTree, parametersOfAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            parametersOfAddControlToTree.ShouldNotBeNull();
            parametersOfAddControlToTree.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            methodAddControlToTreeParametersTypes.Length.ShouldBe(parametersOfAddControlToTree.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddControlToTree, methodAddControlToTreeParametersTypes);

            // Assert
            methodAddControlToTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_AddControlToTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_Internally(Type[] types)
        {
            var methodResetTableLayoutPanelsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _customerInfoInstance.ResetTableLayoutPanels(bVisible);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfResetTableLayoutPanels);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetTableLayoutPanels.ShouldNotBeNull();
            parametersOfResetTableLayoutPanels.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(parametersOfResetTableLayoutPanels.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResetTableLayoutPanels, parametersOfResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);

            // Assert
            parametersOfResetTableLayoutPanels.ShouldNotBeNull();
            parametersOfResetTableLayoutPanels.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(parametersOfResetTableLayoutPanels.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);

            // Assert
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_ResetTableLayoutPanels_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_BindNewCustomer_Method_Call_Internally(Type[] types)
        {
            var methodBindNewCustomerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBindNewCustomer, methodBindNewCustomerParametersTypes);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var newCust = this.CreateType<OnyxIndividual>();

            // Act
            Action executeAction = () => _customerInfoInstance.BindNewCustomer(newCust);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var newCust = this.CreateType<OnyxIndividual>();
            var methodBindNewCustomerParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfBindNewCustomer = { newCust };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBindNewCustomer, methodBindNewCustomerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfBindNewCustomer);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBindNewCustomer.ShouldNotBeNull();
            parametersOfBindNewCustomer.Length.ShouldBe(1);
            methodBindNewCustomerParametersTypes.Length.ShouldBe(1);
            methodBindNewCustomerParametersTypes.Length.ShouldBe(parametersOfBindNewCustomer.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var newCust = this.CreateType<OnyxIndividual>();
            var methodBindNewCustomerParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfBindNewCustomer = { newCust };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBindNewCustomer, parametersOfBindNewCustomer, methodBindNewCustomerParametersTypes);

            // Assert
            parametersOfBindNewCustomer.ShouldNotBeNull();
            parametersOfBindNewCustomer.Length.ShouldBe(1);
            methodBindNewCustomerParametersTypes.Length.ShouldBe(1);
            methodBindNewCustomerParametersTypes.Length.ShouldBe(parametersOfBindNewCustomer.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodBindNewCustomer, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var methodBindNewCustomerParametersTypes = new Type[] { typeof(OnyxIndividual) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBindNewCustomer, methodBindNewCustomerParametersTypes);

            // Assert
            methodBindNewCustomerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindNewCustomer) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_BindNewCustomer_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindNewCustomer);
            var currentMethodInfo = this.GetMethodInfo(MethodBindNewCustomer, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_PopulateControl_Method_Call_Internally(Type[] types)
        {
            var methodPopulateControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_PopulateControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);

            // Act
            Action executeAction = () => _customerInfoInstance.PopulateControl();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_PopulateControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfPopulateControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_PopulateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateControl, parametersOfPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_PopulateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_PopulateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateCustomerInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_populateCustomerInfo_Method_Call_Internally(Type[] types)
        {
            var methodpopulateCustomerInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateCustomerInfo, methodpopulateCustomerInfoParametersTypes);
        }

        #endregion

        #region Method Call : (populateCustomerInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_populateCustomerInfo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateCustomerInfo);
            Type [] methodpopulateCustomerInfoParametersTypes = null;
            object[] parametersOfpopulateCustomerInfo = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateCustomerInfo, methodpopulateCustomerInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfpopulateCustomerInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateCustomerInfo.ShouldBeNull();
            methodpopulateCustomerInfoParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateCustomerInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_populateCustomerInfo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateCustomerInfo);
            Type [] methodpopulateCustomerInfoParametersTypes = null;
            object[] parametersOfpopulateCustomerInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateCustomerInfo, parametersOfpopulateCustomerInfo, methodpopulateCustomerInfoParametersTypes);

            // Assert
            parametersOfpopulateCustomerInfo.ShouldBeNull();
            methodpopulateCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateCustomerInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_populateCustomerInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateCustomerInfo);
            Type [] methodpopulateCustomerInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateCustomerInfo, methodpopulateCustomerInfoParametersTypes);

            // Assert
            methodpopulateCustomerInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateCustomerInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_populateCustomerInfo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateCustomerInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateCustomerInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_createTextBox_Method_Call_Internally(Type[] types)
        {
            var methodcreateTextBoxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateTextBox, methodcreateTextBoxParametersTypes);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var label = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodcreateTextBoxParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfcreateTextBox = { label, value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateTextBox, methodcreateTextBoxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<TextBox>(_customerInfoInstanceFixture, parametersOfcreateTextBox);
            var result2 = this.GetResultOfMethod<TextBox>(MethodcreateTextBox, parametersOfcreateTextBox, methodcreateTextBoxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfcreateTextBox.ShouldNotBeNull();
            parametersOfcreateTextBox.Length.ShouldBe(2);
            methodcreateTextBoxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var label = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodcreateTextBoxParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfcreateTextBox = { label, value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TextBox>(MethodcreateTextBox, parametersOfcreateTextBox, methodcreateTextBoxParametersTypes);

            // Assert
            parametersOfcreateTextBox.ShouldNotBeNull();
            parametersOfcreateTextBox.Length.ShouldBe(2);
            methodcreateTextBoxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var methodcreateTextBoxParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcreateTextBox, methodcreateTextBoxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodcreateTextBoxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var methodcreateTextBoxParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateTextBox, methodcreateTextBoxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodcreateTextBoxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateTextBox, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (createTextBox) (Return Type : TextBox) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_createTextBox_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateTextBox);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateTextBox, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addChildListControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerInfo_addChildListControls_Method_Call_Internally(Type[] types)
        {
            var methodaddChildListControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddChildListControls, methodaddChildListControlsParametersTypes);
        }

        #endregion

        #region Method Call : (addChildListControls) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_addChildListControls_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddChildListControls);
            Type [] methodaddChildListControlsParametersTypes = null;
            object[] parametersOfaddChildListControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddChildListControls, methodaddChildListControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInfoInstanceFixture, parametersOfaddChildListControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddChildListControls.ShouldBeNull();
            methodaddChildListControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addChildListControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_addChildListControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddChildListControls);
            Type [] methodaddChildListControlsParametersTypes = null;
            object[] parametersOfaddChildListControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddChildListControls, parametersOfaddChildListControls, methodaddChildListControlsParametersTypes);

            // Assert
            parametersOfaddChildListControls.ShouldBeNull();
            methodaddChildListControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addChildListControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_addChildListControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddChildListControls);
            Type [] methodaddChildListControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodaddChildListControls, methodaddChildListControlsParametersTypes);

            // Assert
            methodaddChildListControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addChildListControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerInfo_addChildListControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddChildListControls);
            var currentMethodInfo = this.GetMethodInfo(MethodaddChildListControls, 0);

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