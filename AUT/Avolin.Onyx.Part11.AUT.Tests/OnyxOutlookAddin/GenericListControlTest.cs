using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.GenericListControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GenericListControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GenericListControl" />)
        /// </summary>
        public GenericListControlTest() : base(typeof(GenericListControl))
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

        #region General Initializer : Class (GenericListControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _genericListControlInstanceType;
        private GenericListControl _genericListControlInstance;
        private GenericListControl _genericListControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GenericListControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _genericListControlInstanceType = typeof(GenericListControl);
            _genericListControlInstanceFixture = this.Create<GenericListControl>(false);
            _genericListControlInstance = _genericListControlInstanceFixture ?? this.Create<GenericListControl>(true);
            CurrentInstance = _genericListControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GenericListControl) Initializer

        #region Properties

        private const string PropertyCustomControlId = "CustomControlId";
        private const string PropertyIsPopulated = "IsPopulated";
        private const string PropertyIsNeedsRefresh = "IsNeedsRefresh";
        private const string PropertyIsExpanded = "IsExpanded";

        #endregion

        #region Methods

        private const string MethodAddControlToTree = "AddControlToTree";
        private const string MethodPopulateControl = "PopulateControl";
        private const string MethodResetTableLayoutPanels = "ResetTableLayoutPanels";

        #endregion

        #region Fields

        private const string FieldlistOwnerObject = "listOwnerObject";
        private const string FieldcontrolId = "controlId";
        private const string FieldlistPanel = "listPanel";
        private const string Fieldpopulated = "populated";
        private const string FieldneedsRefresh = "needsRefresh";
        private const string FieldlistConfig = "listConfig";
        private const string FieldinfoPanel = "infoPanel";
        private const string FieldisExpanded = "isExpanded";

        #endregion

        #endregion

        #region General Initializer : Class (GenericListControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GenericListControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControl_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GenericListControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GenericListControl)

        #region General Initializer : Class (GenericListControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddControlToTree, 0)]
        [TestCase(MethodPopulateControl, 0)]
        [TestCase(MethodResetTableLayoutPanels, 0)]
        public void AUT_GenericListControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GenericListControl) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyIsExpanded)]
        [Category("AUT Property")]
        public void AUT_GenericListControl_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GenericListControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlistOwnerObject)]
        [TestCase(FieldcontrolId)]
        [TestCase(FieldlistPanel)]
        [TestCase(Fieldpopulated)]
        [TestCase(FieldneedsRefresh)]
        [TestCase(FieldlistConfig)]
        [TestCase(FieldinfoPanel)]
        [TestCase(FieldisExpanded)]
        [Category("AUT Fields")]
        public void AUT_GenericListControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GenericListControl) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GenericListControl_Is_Instance_Present_Test()
        {
            // Assert
            _genericListControlInstanceType.ShouldNotBeNull();
            _genericListControlInstance.ShouldNotBeNull();
            _genericListControlInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GenericListControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GenericListControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _genericListControlInstance.ShouldBeAssignableTo<GenericListControl>();
            _genericListControlInstanceFixture.ShouldBeAssignableTo<GenericListControl>();
            CurrentInstance.ShouldBeAssignableTo<GenericListControl>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GenericListControl) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GenericListControl_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramListConfig = this.CreateType<OnyxOutlookListConfig>();
            var ownerObject = this.CreateType<OnyxObject>();
            var paramInfoPanel = this.CreateType<OnyxInfoPanel>();
            GenericListControl instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GenericListControl(paramListConfig, ownerObject, paramInfoPanel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _genericListControlInstance.ShouldNotBeNull();
            _genericListControlInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<GenericListControl>();
        }

        #endregion

        #region General Constructor : Class (GenericListControl) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GenericListControl_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramListConfig = this.CreateType<OnyxOutlookListConfig>();
            var ownerObject = this.CreateType<OnyxObject>();
            var paramInfoPanel = this.CreateType<OnyxInfoPanel>();
            GenericListControl instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new GenericListControl(paramListConfig, ownerObject, paramInfoPanel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _genericListControlInstance.ShouldNotBeNull();
            _genericListControlInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GenericListControl) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCustomControlId)]
        [TestCase(PropertyIsPopulated)]
        [TestCase(PropertyIsNeedsRefresh)]
        [TestCase(PropertyIsExpanded)]
        public void AUT_GenericListControl_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GenericListControl) => Property (CustomControlId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericListControl_CustomControlId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomControlId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomControlId);
            Action currentAction = () => propertyInfo.SetValue(_genericListControlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GenericListControl) => Property (CustomControlId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericListControl_Public_Class_CustomControlId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GenericListControl) => Property (IsExpanded) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericListControl_Public_Class_IsExpanded_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsExpanded);
            var propertyInfo = this.GetPropertyInfo(PropertyIsExpanded);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GenericListControl) => Property (IsNeedsRefresh) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericListControl_Public_Class_IsNeedsRefresh_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GenericListControl) => Property (IsPopulated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GenericListControl_Public_Class_IsPopulated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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
        public void AUT_GenericListControl_AddControlToTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();

            // Act
            Action executeAction = () => _genericListControlInstance.AddControlToTree(parentControlId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddControlToTree) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddControlToTree);
            var parentControlId = this.CreateType<string>();
            var methodAddControlToTreeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfAddControlToTree = { parentControlId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddControlToTree, methodAddControlToTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_genericListControlInstanceFixture, parametersOfAddControlToTree);

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
        public void AUT_GenericListControl_AddControlToTree_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_GenericListControl_AddControlToTree_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_GenericListControl_AddControlToTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_GenericListControl_AddControlToTree_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (PopulateControl) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericListControl_PopulateControl_Method_Call_Internally(Type[] types)
        {
            var methodPopulateControlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_PopulateControl_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);

            // Act
            Action executeAction = () => _genericListControlInstance.PopulateControl();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_PopulateControl_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_genericListControlInstanceFixture, parametersOfPopulateControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_PopulateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_GenericListControl_PopulateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_GenericListControl_PopulateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_Internally(Type[] types)
        {
            var methodResetTableLayoutPanelsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();

            // Act
            Action executeAction = () => _genericListControlInstance.ResetTableLayoutPanels(bVisible);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResetTableLayoutPanels);
            var bVisible = this.CreateType<bool>();
            var methodResetTableLayoutPanelsParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfResetTableLayoutPanels = { bVisible };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResetTableLayoutPanels, methodResetTableLayoutPanelsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_genericListControlInstanceFixture, parametersOfResetTableLayoutPanels);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResetTableLayoutPanels.ShouldNotBeNull();
            parametersOfResetTableLayoutPanels.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(1);
            methodResetTableLayoutPanelsParametersTypes.Length.ShouldBe(parametersOfResetTableLayoutPanels.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResetTableLayoutPanels) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_GenericListControl_ResetTableLayoutPanels_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #endregion

        #endregion
    }
}