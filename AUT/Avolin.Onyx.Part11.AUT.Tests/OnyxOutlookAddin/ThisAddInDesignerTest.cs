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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ThisAddIn" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ThisAddInDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ThisAddIn" />)
        /// </summary>
        public ThisAddInDesignerTest() : base(typeof(ThisAddIn))
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

        #region General Initializer : Class (ThisAddIn) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _thisAddInInstanceType;
        private ThisAddIn _thisAddInInstance;
        private ThisAddIn _thisAddInInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ThisAddIn" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _thisAddInInstanceType = typeof(ThisAddIn);
            _thisAddInInstanceFixture = this.Create<ThisAddIn>(false);
            _thisAddInInstance = _thisAddInInstanceFixture ?? this.Create<ThisAddIn>(true);
            CurrentInstance = _thisAddInInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Initializer

        #region Methods

        private const string MethodInitialize = "Initialize";
        private const string MethodFinishInitialization = "FinishInitialization";
        private const string MethodInitializeDataBindings = "InitializeDataBindings";
        private const string MethodInitializeCachedData = "InitializeCachedData";
        private const string MethodInitializeData = "InitializeData";
        private const string MethodBindToData = "BindToData";
        private const string MethodStartCaching = "StartCaching";
        private const string MethodStopCaching = "StopCaching";
        private const string MethodIsCached = "IsCached";
        private const string MethodBeginInitialization = "BeginInitialization";
        private const string MethodEndInitialization = "EndInitialization";
        private const string MethodInitializeControls = "InitializeControls";
        private const string MethodInitializeComponents = "InitializeComponents";
        private const string MethodNeedsFill = "NeedsFill";
        private const string MethodOnShutdown = "OnShutdown";

        #endregion

        #region Fields

        private const string FieldCustomTaskPanes = "CustomTaskPanes";
        private const string Fieldmissing = "missing";
        private const string FieldApplication = "Application";

        #endregion

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddInDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddInDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ThisAddIn) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ThisAddInDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ThisAddIn)

        #region General Initializer : Class (ThisAddIn) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitialize, 0)]
        [TestCase(MethodFinishInitialization, 0)]
        [TestCase(MethodInitializeDataBindings, 0)]
        [TestCase(MethodInitializeCachedData, 0)]
        [TestCase(MethodInitializeData, 0)]
        [TestCase(MethodBindToData, 0)]
        [TestCase(MethodStartCaching, 0)]
        [TestCase(MethodStopCaching, 0)]
        [TestCase(MethodIsCached, 0)]
        [TestCase(MethodBeginInitialization, 0)]
        [TestCase(MethodEndInitialization, 0)]
        [TestCase(MethodInitializeControls, 0)]
        [TestCase(MethodInitializeComponents, 0)]
        [TestCase(MethodNeedsFill, 0)]
        [TestCase(MethodOnShutdown, 0)]
        public void AUT_ThisAddInDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ThisAddIn) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCustomTaskPanes)]
        [TestCase(Fieldmissing)]
        [TestCase(FieldApplication)]
        [Category("AUT Fields")]
        public void AUT_ThisAddInDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ThisAddIn) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ThisAddIn" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ThisAddInDesigner_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _thisAddInInstance.ShouldBeAssignableTo<ThisAddIn>();
            _thisAddInInstanceFixture.ShouldBeAssignableTo<ThisAddIn>();
            CurrentInstance.ShouldBeAssignableTo<ThisAddIn>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Initialize) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_Initialize_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            Type [] methodInitializeParametersTypes = null;
            object[] parametersOfInitialize = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitialize, methodInitializeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitialize);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitialize.ShouldBeNull();
            methodInitializeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_Initialize_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            Type [] methodInitializeParametersTypes = null;
            object[] parametersOfInitialize = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitialize, parametersOfInitialize, methodInitializeParametersTypes);

            // Assert
            parametersOfInitialize.ShouldBeNull();
            methodInitializeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_Initialize_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            Type [] methodInitializeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitialize, methodInitializeParametersTypes);

            // Assert
            methodInitializeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_Initialize_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var currentMethodInfo = this.GetMethodInfo(MethodInitialize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FinishInitialization) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_FinishInitialization_Method_Call_Internally(Type[] types)
        {
            var methodFinishInitializationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFinishInitialization, methodFinishInitializationParametersTypes);
        }

        #endregion

        #region Method Call : (FinishInitialization) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_FinishInitialization_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFinishInitialization);
            Type [] methodFinishInitializationParametersTypes = null;
            object[] parametersOfFinishInitialization = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFinishInitialization, methodFinishInitializationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfFinishInitialization);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFinishInitialization.ShouldBeNull();
            methodFinishInitializationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FinishInitialization) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_FinishInitialization_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFinishInitialization);
            Type [] methodFinishInitializationParametersTypes = null;
            object[] parametersOfFinishInitialization = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFinishInitialization, parametersOfFinishInitialization, methodFinishInitializationParametersTypes);

            // Assert
            parametersOfFinishInitialization.ShouldBeNull();
            methodFinishInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FinishInitialization) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_FinishInitialization_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFinishInitialization);
            Type [] methodFinishInitializationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFinishInitialization, methodFinishInitializationParametersTypes);

            // Assert
            methodFinishInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FinishInitialization) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_FinishInitialization_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFinishInitialization);
            var currentMethodInfo = this.GetMethodInfo(MethodFinishInitialization, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeDataBindings) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_InitializeDataBindings_Method_Call_Internally(Type[] types)
        {
            var methodInitializeDataBindingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeDataBindings, methodInitializeDataBindingsParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeDataBindings) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeDataBindings_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeDataBindings);
            Type [] methodInitializeDataBindingsParametersTypes = null;
            object[] parametersOfInitializeDataBindings = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeDataBindings, methodInitializeDataBindingsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeDataBindings);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeDataBindings.ShouldBeNull();
            methodInitializeDataBindingsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeDataBindings) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeDataBindings_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeDataBindings);
            Type [] methodInitializeDataBindingsParametersTypes = null;
            object[] parametersOfInitializeDataBindings = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeDataBindings, parametersOfInitializeDataBindings, methodInitializeDataBindingsParametersTypes);

            // Assert
            parametersOfInitializeDataBindings.ShouldBeNull();
            methodInitializeDataBindingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeDataBindings) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeDataBindings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeDataBindings);
            Type [] methodInitializeDataBindingsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeDataBindings, methodInitializeDataBindingsParametersTypes);

            // Assert
            methodInitializeDataBindingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeDataBindings) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeDataBindings_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeDataBindings);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeDataBindings, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeCachedData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_InitializeCachedData_Method_Call_Internally(Type[] types)
        {
            var methodInitializeCachedDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeCachedData, methodInitializeCachedDataParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeCachedData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeCachedData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeCachedData);
            Type [] methodInitializeCachedDataParametersTypes = null;
            object[] parametersOfInitializeCachedData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeCachedData, methodInitializeCachedDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeCachedData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeCachedData.ShouldBeNull();
            methodInitializeCachedDataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeCachedData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeCachedData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeCachedData);
            Type [] methodInitializeCachedDataParametersTypes = null;
            object[] parametersOfInitializeCachedData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeCachedData, parametersOfInitializeCachedData, methodInitializeCachedDataParametersTypes);

            // Assert
            parametersOfInitializeCachedData.ShouldBeNull();
            methodInitializeCachedDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeCachedData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeCachedData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeCachedData);
            Type [] methodInitializeCachedDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeCachedData, methodInitializeCachedDataParametersTypes);

            // Assert
            methodInitializeCachedDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeCachedData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeCachedData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeCachedData);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeCachedData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_InitializeData_Method_Call_Internally(Type[] types)
        {
            var methodInitializeDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeData, methodInitializeDataParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeData);
            Type [] methodInitializeDataParametersTypes = null;
            object[] parametersOfInitializeData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeData, methodInitializeDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeData.ShouldBeNull();
            methodInitializeDataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeData);
            Type [] methodInitializeDataParametersTypes = null;
            object[] parametersOfInitializeData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeData, parametersOfInitializeData, methodInitializeDataParametersTypes);

            // Assert
            parametersOfInitializeData.ShouldBeNull();
            methodInitializeDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeData);
            Type [] methodInitializeDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeData, methodInitializeDataParametersTypes);

            // Assert
            methodInitializeDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeData);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindToData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_BindToData_Method_Call_Internally(Type[] types)
        {
            var methodBindToDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBindToData, methodBindToDataParametersTypes);
        }

        #endregion

        #region Method Call : (BindToData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BindToData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindToData);
            Type [] methodBindToDataParametersTypes = null;
            object[] parametersOfBindToData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBindToData, methodBindToDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfBindToData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBindToData.ShouldBeNull();
            methodBindToDataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BindToData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BindToData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindToData);
            Type [] methodBindToDataParametersTypes = null;
            object[] parametersOfBindToData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBindToData, parametersOfBindToData, methodBindToDataParametersTypes);

            // Assert
            parametersOfBindToData.ShouldBeNull();
            methodBindToDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindToData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BindToData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindToData);
            Type [] methodBindToDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBindToData, methodBindToDataParametersTypes);

            // Assert
            methodBindToDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BindToData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BindToData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBindToData);
            var currentMethodInfo = this.GetMethodInfo(MethodBindToData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_StartCaching_Method_Call_Internally(Type[] types)
        {
            var methodStartCachingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStartCaching, methodStartCachingParametersTypes);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StartCaching_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCaching);
            var MemberName = this.CreateType<string>();
            var methodStartCachingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStartCaching = { MemberName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStartCaching, methodStartCachingParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfStartCaching);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfStartCaching.ShouldNotBeNull();
            parametersOfStartCaching.Length.ShouldBe(1);
            methodStartCachingParametersTypes.Length.ShouldBe(1);
            methodStartCachingParametersTypes.Length.ShouldBe(parametersOfStartCaching.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StartCaching_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCaching);
            var MemberName = this.CreateType<string>();
            var methodStartCachingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStartCaching = { MemberName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodStartCaching, parametersOfStartCaching, methodStartCachingParametersTypes);

            // Assert
            parametersOfStartCaching.ShouldNotBeNull();
            parametersOfStartCaching.Length.ShouldBe(1);
            methodStartCachingParametersTypes.Length.ShouldBe(1);
            methodStartCachingParametersTypes.Length.ShouldBe(parametersOfStartCaching.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StartCaching_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCaching);
            var currentMethodInfo = this.GetMethodInfo(MethodStartCaching, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StartCaching_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCaching);
            var methodStartCachingParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStartCaching, methodStartCachingParametersTypes);

            // Assert
            methodStartCachingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StartCaching) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StartCaching_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCaching);
            var currentMethodInfo = this.GetMethodInfo(MethodStartCaching, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_StopCaching_Method_Call_Internally(Type[] types)
        {
            var methodStopCachingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStopCaching, methodStopCachingParametersTypes);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StopCaching_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCaching);
            var MemberName = this.CreateType<string>();
            var methodStopCachingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStopCaching = { MemberName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStopCaching, methodStopCachingParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfStopCaching);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfStopCaching.ShouldNotBeNull();
            parametersOfStopCaching.Length.ShouldBe(1);
            methodStopCachingParametersTypes.Length.ShouldBe(1);
            methodStopCachingParametersTypes.Length.ShouldBe(parametersOfStopCaching.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StopCaching_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCaching);
            var MemberName = this.CreateType<string>();
            var methodStopCachingParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStopCaching = { MemberName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodStopCaching, parametersOfStopCaching, methodStopCachingParametersTypes);

            // Assert
            parametersOfStopCaching.ShouldNotBeNull();
            parametersOfStopCaching.Length.ShouldBe(1);
            methodStopCachingParametersTypes.Length.ShouldBe(1);
            methodStopCachingParametersTypes.Length.ShouldBe(parametersOfStopCaching.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StopCaching_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCaching);
            var currentMethodInfo = this.GetMethodInfo(MethodStopCaching, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StopCaching_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCaching);
            var methodStopCachingParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStopCaching, methodStopCachingParametersTypes);

            // Assert
            methodStopCachingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StopCaching) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_StopCaching_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCaching);
            var currentMethodInfo = this.GetMethodInfo(MethodStopCaching, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_IsCached_Method_Call_Internally(Type[] types)
        {
            var methodIsCachedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsCached, methodIsCachedParametersTypes);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var MemberName = this.CreateType<string>();
            var methodIsCachedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCached = { MemberName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsCached, methodIsCachedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_thisAddInInstanceFixture, parametersOfIsCached);
            var result2 = this.GetResultOfMethod<bool>(MethodIsCached, parametersOfIsCached, methodIsCachedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsCached.ShouldNotBeNull();
            parametersOfIsCached.Length.ShouldBe(1);
            methodIsCachedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var MemberName = this.CreateType<string>();
            var methodIsCachedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCached = { MemberName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsCached, methodIsCachedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_thisAddInInstanceFixture, out exception1, parametersOfIsCached);
            var result2 = this.GetResultOfMethod<bool>(MethodIsCached, parametersOfIsCached, methodIsCachedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsCached.ShouldNotBeNull();
            parametersOfIsCached.Length.ShouldBe(1);
            methodIsCachedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var MemberName = this.CreateType<string>();
            var methodIsCachedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCached = { MemberName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsCached, parametersOfIsCached, methodIsCachedParametersTypes);

            // Assert
            parametersOfIsCached.ShouldNotBeNull();
            parametersOfIsCached.Length.ShouldBe(1);
            methodIsCachedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var methodIsCachedParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsCached, methodIsCachedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsCachedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var currentMethodInfo = this.GetMethodInfo(MethodIsCached, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsCached) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_IsCached_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCached);
            var currentMethodInfo = this.GetMethodInfo(MethodIsCached, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BeginInitialization) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_BeginInitialization_Method_Call_Internally(Type[] types)
        {
            var methodBeginInitializationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBeginInitialization, methodBeginInitializationParametersTypes);
        }

        #endregion

        #region Method Call : (BeginInitialization) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BeginInitialization_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeginInitialization);
            Type [] methodBeginInitializationParametersTypes = null;
            object[] parametersOfBeginInitialization = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBeginInitialization, methodBeginInitializationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfBeginInitialization);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBeginInitialization.ShouldBeNull();
            methodBeginInitializationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BeginInitialization) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BeginInitialization_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeginInitialization);
            Type [] methodBeginInitializationParametersTypes = null;
            object[] parametersOfBeginInitialization = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBeginInitialization, parametersOfBeginInitialization, methodBeginInitializationParametersTypes);

            // Assert
            parametersOfBeginInitialization.ShouldBeNull();
            methodBeginInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BeginInitialization) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BeginInitialization_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeginInitialization);
            Type [] methodBeginInitializationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBeginInitialization, methodBeginInitializationParametersTypes);

            // Assert
            methodBeginInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BeginInitialization) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_BeginInitialization_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeginInitialization);
            var currentMethodInfo = this.GetMethodInfo(MethodBeginInitialization, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndInitialization) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_EndInitialization_Method_Call_Internally(Type[] types)
        {
            var methodEndInitializationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEndInitialization, methodEndInitializationParametersTypes);
        }

        #endregion

        #region Method Call : (EndInitialization) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_EndInitialization_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndInitialization);
            Type [] methodEndInitializationParametersTypes = null;
            object[] parametersOfEndInitialization = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEndInitialization, methodEndInitializationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfEndInitialization);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEndInitialization.ShouldBeNull();
            methodEndInitializationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EndInitialization) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_EndInitialization_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndInitialization);
            Type [] methodEndInitializationParametersTypes = null;
            object[] parametersOfEndInitialization = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEndInitialization, parametersOfEndInitialization, methodEndInitializationParametersTypes);

            // Assert
            parametersOfEndInitialization.ShouldBeNull();
            methodEndInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndInitialization) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_EndInitialization_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndInitialization);
            Type [] methodEndInitializationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEndInitialization, methodEndInitializationParametersTypes);

            // Assert
            methodEndInitializationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndInitialization) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_EndInitialization_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndInitialization);
            var currentMethodInfo = this.GetMethodInfo(MethodEndInitialization, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeControls) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_InitializeControls_Method_Call_Internally(Type[] types)
        {
            var methodInitializeControlsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeControls, methodInitializeControlsParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeControls) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeControls_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeControls);
            Type [] methodInitializeControlsParametersTypes = null;
            object[] parametersOfInitializeControls = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeControls, methodInitializeControlsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeControls);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeControls.ShouldBeNull();
            methodInitializeControlsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeControls) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeControls_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeControls);
            Type [] methodInitializeControlsParametersTypes = null;
            object[] parametersOfInitializeControls = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeControls, parametersOfInitializeControls, methodInitializeControlsParametersTypes);

            // Assert
            parametersOfInitializeControls.ShouldBeNull();
            methodInitializeControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeControls) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeControls_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeControls);
            Type [] methodInitializeControlsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeControls, methodInitializeControlsParametersTypes);

            // Assert
            methodInitializeControlsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeControls) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeControls_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeControls);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeControls, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeComponents) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_InitializeComponents_Method_Call_Internally(Type[] types)
        {
            var methodInitializeComponentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeComponents, methodInitializeComponentsParametersTypes);
        }

        #endregion

        #region Method Call : (InitializeComponents) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeComponents_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeComponents);
            Type [] methodInitializeComponentsParametersTypes = null;
            object[] parametersOfInitializeComponents = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeComponents, methodInitializeComponentsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfInitializeComponents);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeComponents.ShouldBeNull();
            methodInitializeComponentsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeComponents) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeComponents_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeComponents);
            Type [] methodInitializeComponentsParametersTypes = null;
            object[] parametersOfInitializeComponents = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeComponents, parametersOfInitializeComponents, methodInitializeComponentsParametersTypes);

            // Assert
            parametersOfInitializeComponents.ShouldBeNull();
            methodInitializeComponentsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeComponents) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeComponents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeComponents);
            Type [] methodInitializeComponentsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeComponents, methodInitializeComponentsParametersTypes);

            // Assert
            methodInitializeComponentsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeComponents) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_InitializeComponents_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeComponents);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeComponents, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_NeedsFill_Method_Call_Internally(Type[] types)
        {
            var methodNeedsFillParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNeedsFill, methodNeedsFillParametersTypes);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var MemberName = this.CreateType<string>();
            var methodNeedsFillParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfNeedsFill = { MemberName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodNeedsFill, methodNeedsFillParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_thisAddInInstanceFixture, parametersOfNeedsFill);
            var result2 = this.GetResultOfMethod<bool>(MethodNeedsFill, parametersOfNeedsFill, methodNeedsFillParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNeedsFill.ShouldNotBeNull();
            parametersOfNeedsFill.Length.ShouldBe(1);
            methodNeedsFillParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var MemberName = this.CreateType<string>();
            var methodNeedsFillParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfNeedsFill = { MemberName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodNeedsFill, methodNeedsFillParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_thisAddInInstanceFixture, out exception1, parametersOfNeedsFill);
            var result2 = this.GetResultOfMethod<bool>(MethodNeedsFill, parametersOfNeedsFill, methodNeedsFillParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNeedsFill.ShouldNotBeNull();
            parametersOfNeedsFill.Length.ShouldBe(1);
            methodNeedsFillParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var MemberName = this.CreateType<string>();
            var methodNeedsFillParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfNeedsFill = { MemberName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodNeedsFill, parametersOfNeedsFill, methodNeedsFillParametersTypes);

            // Assert
            parametersOfNeedsFill.ShouldNotBeNull();
            parametersOfNeedsFill.Length.ShouldBe(1);
            methodNeedsFillParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var methodNeedsFillParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodNeedsFill, methodNeedsFillParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodNeedsFillParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var currentMethodInfo = this.GetMethodInfo(MethodNeedsFill, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (NeedsFill) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_NeedsFill_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNeedsFill);
            var currentMethodInfo = this.GetMethodInfo(MethodNeedsFill, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnShutdown) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ThisAddInDesigner_OnShutdown_Method_Call_Internally(Type[] types)
        {
            var methodOnShutdownParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnShutdown, methodOnShutdownParametersTypes);
        }

        #endregion

        #region Method Call : (OnShutdown) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_OnShutdown_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnShutdown);
            Type [] methodOnShutdownParametersTypes = null;
            object[] parametersOfOnShutdown = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnShutdown, methodOnShutdownParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_thisAddInInstanceFixture, parametersOfOnShutdown);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnShutdown.ShouldBeNull();
            methodOnShutdownParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnShutdown) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_OnShutdown_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnShutdown);
            Type [] methodOnShutdownParametersTypes = null;
            object[] parametersOfOnShutdown = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnShutdown, parametersOfOnShutdown, methodOnShutdownParametersTypes);

            // Assert
            parametersOfOnShutdown.ShouldBeNull();
            methodOnShutdownParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnShutdown) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_OnShutdown_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnShutdown);
            Type [] methodOnShutdownParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnShutdown, methodOnShutdownParametersTypes);

            // Assert
            methodOnShutdownParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnShutdown) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ThisAddInDesigner_OnShutdown_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnShutdown);
            var currentMethodInfo = this.GetMethodInfo(MethodOnShutdown, 0);

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