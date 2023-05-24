using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Controller;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.CountryController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CountryControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CountryController" />)
        /// </summary>
        public CountryControllerTest() : base(typeof(CountryController))
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

        #region General Initializer : Class (CountryController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _countryControllerInstanceType;
        private CountryController _countryControllerInstance;
        private CountryController _countryControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CountryController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _countryControllerInstanceType = typeof(CountryController);
            _countryControllerInstanceFixture = this.Create<CountryController>(false);
            _countryControllerInstance = _countryControllerInstanceFixture ?? this.Create<CountryController>(true);
            CurrentInstance = _countryControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CountryController) Initializer

        #region Methods

        private const string MethodGetActiveCountries = "GetActiveCountries";

        #endregion

        #endregion

        #region General Initializer : Class (CountryController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CountryController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CountryController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CountryController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CountryController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CountryController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CountryController)

        #region General Initializer : Class (CountryController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CountryController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetActiveCountries, 0)]
        public void AUT_CountryController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CountryController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CountryController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CountryController_Is_Instance_Present_Test()
        {
            // Assert
            _countryControllerInstanceType.ShouldNotBeNull();
            _countryControllerInstance.ShouldNotBeNull();
            _countryControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CountryController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CountryController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CountryController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _countryControllerInstance.ShouldBeAssignableTo<CountryController>();
            _countryControllerInstanceFixture.ShouldBeAssignableTo<CountryController>();
            CurrentInstance.ShouldBeAssignableTo<CountryController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CountryController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CountryController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CountryController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);

            // Act
            Action executeAction = () => _countryControllerInstance.GetActiveCountries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _countryControllerInstance.GetActiveCountries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            Type [] methodGetActiveCountriesParametersTypes = null;
            object[] parametersOfGetActiveCountries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_countryControllerInstanceFixture, parametersOfGetActiveCountries);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveCountries, parametersOfGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveCountries.ShouldBeNull();
            methodGetActiveCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            Type [] methodGetActiveCountriesParametersTypes = null;
            object[] parametersOfGetActiveCountries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveCountries, parametersOfGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            parametersOfGetActiveCountries.ShouldBeNull();
            methodGetActiveCountriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            Type [] methodGetActiveCountriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            Type [] methodGetActiveCountriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryController_GetActiveCountries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveCountries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}