using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Shouldly;
using SortOrder = OnyxISAPI.Framework.SortOrder;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Framework
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Framework.SortOrder" />)
    ///     and namespace <see cref="OnyxISAPI.Framework"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SortOrderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SortOrder" />)
        /// </summary>
        public SortOrderTest() : base(typeof(SortOrder))
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

        #region General Initializer : Class (SortOrder) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _sortOrderInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="SortOrder" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sortOrderInstanceType = typeof(SortOrder);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SortOrder) Initializer

        #region Methods

        private const string MethodConstructSortOrder = "ConstructSortOrder";
        private const string MethodConstructSortOrderSelect = "ConstructSortOrderSelect";

        #endregion

        #endregion

        #region General Initializer : Class (SortOrder) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SortOrder" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SortOrder_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SortOrder)

        #region General Initializer : Class (SortOrder) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SortOrder" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodConstructSortOrder, 0)]
        [TestCase(MethodConstructSortOrderSelect, 0)]
        public void AUT_SortOrder_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SortOrder) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SortOrder" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SortOrder_Is_Static_Type_Present_Test()
        {
            // Assert
            _sortOrderInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ConstructSortOrder) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var sortOrder = this.CreateType<string>();

            // Act
            Action executeAction = () => SortOrder.ConstructSortOrder(sortOrder);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var sortOrder = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SortOrder.ConstructSortOrder(sortOrder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var sortOrder = this.CreateType<string>();
            var methodConstructSortOrderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConstructSortOrder = { sortOrder };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrder, methodConstructSortOrderParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructSortOrder, methodConstructSortOrderParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructSortOrder, parametersOfConstructSortOrder, methodConstructSortOrderParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructSortOrder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConstructSortOrder.ShouldNotBeNull();
            parametersOfConstructSortOrder.Length.ShouldBe(1);
            methodConstructSortOrderParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var sortOrder = this.CreateType<string>();
            var methodConstructSortOrderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConstructSortOrder = { sortOrder };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructSortOrder, parametersOfConstructSortOrder, methodConstructSortOrderParametersTypes);

            // Assert
            parametersOfConstructSortOrder.ShouldNotBeNull();
            parametersOfConstructSortOrder.Length.ShouldBe(1);
            methodConstructSortOrderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var methodConstructSortOrderParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructSortOrder, methodConstructSortOrderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConstructSortOrderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var methodConstructSortOrderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructSortOrder, methodConstructSortOrderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructSortOrderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrder, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructSortOrder) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrder_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrder);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrder, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_Internally(Type[] types)
        {
            var methodConstructSortOrderSelectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var sortOrderClause = this.CreateType<string>();
            var selectColumns = this.CreateType<List<String>>();

            // Act
            Action executeAction = () => SortOrder.ConstructSortOrderSelect(sortOrderClause, selectColumns);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var sortOrderClause = this.CreateType<string>();
            var selectColumns = this.CreateType<List<String>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SortOrder.ConstructSortOrderSelect(sortOrderClause, selectColumns);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var sortOrderClause = this.CreateType<string>();
            var selectColumns = this.CreateType<List<String>>();
            var methodConstructSortOrderSelectParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            object[] parametersOfConstructSortOrderSelect = { sortOrderClause, selectColumns };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructSortOrderSelect, parametersOfConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructSortOrderSelect);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConstructSortOrderSelect.ShouldNotBeNull();
            parametersOfConstructSortOrderSelect.Length.ShouldBe(2);
            methodConstructSortOrderSelectParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var sortOrderClause = this.CreateType<string>();
            var selectColumns = this.CreateType<List<String>>();
            var methodConstructSortOrderSelectParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            object[] parametersOfConstructSortOrderSelect = { sortOrderClause, selectColumns };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructSortOrderSelect, parametersOfConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);

            // Assert
            parametersOfConstructSortOrderSelect.ShouldNotBeNull();
            parametersOfConstructSortOrderSelect.Length.ShouldBe(2);
            methodConstructSortOrderSelectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var methodConstructSortOrderSelectParametersTypes = new Type[] { typeof(String), typeof(List<String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConstructSortOrderSelectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var methodConstructSortOrderSelectParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructSortOrderSelect, methodConstructSortOrderSelectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructSortOrderSelectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrderSelect, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructSortOrderSelect) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SortOrder_ConstructSortOrderSelect_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructSortOrderSelect);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructSortOrderSelect, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}