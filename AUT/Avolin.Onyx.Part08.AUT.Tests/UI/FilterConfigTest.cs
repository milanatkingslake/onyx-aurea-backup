using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.FilterConfig" />)
    ///     and namespace <see cref="Onyx.UI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FilterConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FilterConfig" />)
        /// </summary>
        public FilterConfigTest() : base(typeof(FilterConfig))
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

        #region General Initializer : Class (FilterConfig) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _filterConfigInstanceType;
        private FilterConfig _filterConfigInstance;
        private FilterConfig _filterConfigInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FilterConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _filterConfigInstanceType = typeof(FilterConfig);
            _filterConfigInstanceFixture = this.Create<FilterConfig>(false);
            _filterConfigInstance = _filterConfigInstanceFixture ?? this.Create<FilterConfig>(true);
            CurrentInstance = _filterConfigInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FilterConfig) Initializer

        #region Methods

        private const string MethodRegisterGlobalFilters = "RegisterGlobalFilters";

        #endregion

        #endregion

        #region General Initializer : Class (FilterConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FilterConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FilterConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FilterConfig)

        #region General Initializer : Class (FilterConfig) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FilterConfig" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRegisterGlobalFilters, 0)]
        public void AUT_FilterConfig_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FilterConfig) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FilterConfig" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FilterConfig_Is_Instance_Present_Test()
        {
            // Assert
            _filterConfigInstanceType.ShouldNotBeNull();
            _filterConfigInstance.ShouldNotBeNull();
            _filterConfigInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FilterConfig) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FilterConfig" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FilterConfig_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _filterConfigInstance.ShouldBeAssignableTo<FilterConfig>();
            _filterConfigInstanceFixture.ShouldBeAssignableTo<FilterConfig>();
            CurrentInstance.ShouldBeAssignableTo<FilterConfig>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FilterConfig) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FilterConfig_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FilterConfig instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var filters = this.CreateType<GlobalFilterCollection>();

            // Act
            Action executeAction = () => FilterConfig.RegisterGlobalFilters(filters);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var filters = this.CreateType<GlobalFilterCollection>();
            var methodRegisterGlobalFiltersParametersTypes = new Type[] { typeof(GlobalFilterCollection) };
            object[] parametersOfRegisterGlobalFilters = { filters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterGlobalFilters, methodRegisterGlobalFiltersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_filterConfigInstanceFixture, parametersOfRegisterGlobalFilters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterGlobalFilters.ShouldNotBeNull();
            parametersOfRegisterGlobalFilters.Length.ShouldBe(1);
            methodRegisterGlobalFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var filters = this.CreateType<GlobalFilterCollection>();
            var methodRegisterGlobalFiltersParametersTypes = new Type[] { typeof(GlobalFilterCollection) };
            object[] parametersOfRegisterGlobalFilters = { filters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterGlobalFilters, parametersOfRegisterGlobalFilters, methodRegisterGlobalFiltersParametersTypes);

            // Assert
            parametersOfRegisterGlobalFilters.ShouldNotBeNull();
            parametersOfRegisterGlobalFilters.Length.ShouldBe(1);
            methodRegisterGlobalFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterGlobalFilters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var methodRegisterGlobalFiltersParametersTypes = new Type[] { typeof(GlobalFilterCollection) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterGlobalFilters, methodRegisterGlobalFiltersParametersTypes);

            // Assert
            methodRegisterGlobalFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterGlobalFilters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FilterConfig_RegisterGlobalFilters_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterGlobalFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterGlobalFilters, 0);

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