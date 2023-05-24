using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ItemSelectorControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ItemSelectorControlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ItemSelectorControl" />)
        /// </summary>
        public ItemSelectorControlTest() : base(typeof(ItemSelectorControl))
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

        #region General Initializer : Class (ItemSelectorControl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _itemSelectorControlInstanceType;
        private ItemSelectorControl _itemSelectorControlInstance;
        private ItemSelectorControl _itemSelectorControlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ItemSelectorControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _itemSelectorControlInstanceType = typeof(ItemSelectorControl);
            _itemSelectorControlInstanceFixture = this.Create<ItemSelectorControl>(false);
            _itemSelectorControlInstance = _itemSelectorControlInstanceFixture ?? this.Create<ItemSelectorControl>(true);
            CurrentInstance = _itemSelectorControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ItemSelectorControl) Initializer

        #region Methods

        private const string MethodPopulateControl = "PopulateControl";
        private const string MethodbulkInsertIntoOnyx = "bulkInsertIntoOnyx";

        #endregion

        #region Fields

        private const string Fieldobjs = "objs";
        private const string Fieldheader = "header";

        #endregion

        #endregion

        #region General Initializer : Class (ItemSelectorControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ItemSelectorControl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ItemSelectorControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ItemSelectorControl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ItemSelectorControl)

        #region General Initializer : Class (ItemSelectorControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodPopulateControl, 0)]
        [TestCase(MethodbulkInsertIntoOnyx, 0)]
        public void AUT_ItemSelectorControl_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ItemSelectorControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldobjs)]
        [TestCase(Fieldheader)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ItemSelectorControl_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ItemSelectorControl) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ItemSelectorControl_Is_Instance_Present_Test()
        {
            // Assert
            _itemSelectorControlInstanceType.ShouldNotBeNull();
            _itemSelectorControlInstance.ShouldNotBeNull();
            _itemSelectorControlInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ItemSelectorControl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ItemSelectorControl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ItemSelectorControl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _itemSelectorControlInstance.ShouldBeAssignableTo<ItemSelectorControl>();
            _itemSelectorControlInstanceFixture.ShouldBeAssignableTo<ItemSelectorControl>();
            CurrentInstance.ShouldBeAssignableTo<ItemSelectorControl>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ItemSelectorControl) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ItemSelectorControl_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var paramObjs = this.CreateType<List<Object>>();
            var paramHeader = this.CreateType<string>();
            ItemSelectorControl instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ItemSelectorControl(paramObjs, paramHeader);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _itemSelectorControlInstance.ShouldNotBeNull();
            _itemSelectorControlInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ItemSelectorControl>();
        }

        #endregion

        #region General Constructor : Class (ItemSelectorControl) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ItemSelectorControl_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var paramObjs = this.CreateType<List<Object>>();
            var paramHeader = this.CreateType<string>();
            ItemSelectorControl instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ItemSelectorControl(paramObjs, paramHeader);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _itemSelectorControlInstance.ShouldNotBeNull();
            _itemSelectorControlInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (PopulateControl) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);

            // Act
            Action executeAction = () => _itemSelectorControlInstance.PopulateControl();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_itemSelectorControlInstanceFixture, parametersOfPopulateControl);
            var result2 = this.GetResultOfMethod<int>(MethodPopulateControl, parametersOfPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, methodPopulateControlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_itemSelectorControlInstanceFixture, out exception1, parametersOfPopulateControl);
            var result2 = this.GetResultOfMethod<int>(MethodPopulateControl, parametersOfPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;
            object[] parametersOfPopulateControl = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodPopulateControl, parametersOfPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            parametersOfPopulateControl.ShouldBeNull();
            methodPopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            Type [] methodPopulateControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateControl, methodPopulateControlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPopulateControlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateControl) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_PopulateControl_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateControl);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateControl, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_Call_Internally(Type[] types)
        {
            var methodbulkInsertIntoOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);

            // Act
            Action executeAction = () => _itemSelectorControlInstance.bulkInsertIntoOnyx();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;
            object[] parametersOfbulkInsertIntoOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_itemSelectorControlInstanceFixture, parametersOfbulkInsertIntoOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbulkInsertIntoOnyx.ShouldBeNull();
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;
            object[] parametersOfbulkInsertIntoOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbulkInsertIntoOnyx, parametersOfbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes);

            // Assert
            parametersOfbulkInsertIntoOnyx.ShouldBeNull();
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            Type [] methodbulkInsertIntoOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbulkInsertIntoOnyx, methodbulkInsertIntoOnyxParametersTypes);

            // Assert
            methodbulkInsertIntoOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (bulkInsertIntoOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ItemSelectorControl_bulkInsertIntoOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbulkInsertIntoOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodbulkInsertIntoOnyx, 0);

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