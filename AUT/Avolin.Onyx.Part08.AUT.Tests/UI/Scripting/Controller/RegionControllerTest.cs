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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.RegionController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class RegionControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RegionController" />)
        /// </summary>
        public RegionControllerTest() : base(typeof(RegionController))
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

        #region General Initializer : Class (RegionController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _regionControllerInstanceType;
        private RegionController _regionControllerInstance;
        private RegionController _regionControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RegionController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _regionControllerInstanceType = typeof(RegionController);
            _regionControllerInstanceFixture = this.Create<RegionController>(false);
            _regionControllerInstance = _regionControllerInstanceFixture ?? this.Create<RegionController>(true);
            CurrentInstance = _regionControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RegionController) Initializer

        #region Methods

        private const string MethodGetActiveRegions = "GetActiveRegions";

        #endregion

        #endregion

        #region General Initializer : Class (RegionController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RegionController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegionController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RegionController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegionController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RegionController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RegionController)

        #region General Initializer : Class (RegionController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RegionController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetActiveRegions, 0)]
        [TestCase(MethodGetActiveRegions, 1)]
        public void AUT_RegionController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (RegionController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RegionController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegionController_Is_Instance_Present_Test()
        {
            // Assert
            _regionControllerInstanceType.ShouldNotBeNull();
            _regionControllerInstance.ShouldNotBeNull();
            _regionControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RegionController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RegionController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegionController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _regionControllerInstance.ShouldBeAssignableTo<RegionController>();
            _regionControllerInstanceFixture.ShouldBeAssignableTo<RegionController>();
            CurrentInstance.ShouldBeAssignableTo<RegionController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RegionController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RegionController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RegionController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();

            // Act
            Action executeAction = () => _regionControllerInstance.GetActiveRegions(countryCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _regionControllerInstance.GetActiveRegions(countryCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetActiveRegions = { countryCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_regionControllerInstanceFixture, parametersOfGetActiveRegions);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(1);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetActiveRegions = { countryCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(1);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegionController_GetActiveRegions_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetActiveRegionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);

            // Act
            Action executeAction = () => _regionControllerInstance.GetActiveRegions();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _regionControllerInstance.GetActiveRegions();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            Type [] methodGetActiveRegionsParametersTypes = null;
            object[] parametersOfGetActiveRegions = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_regionControllerInstanceFixture, parametersOfGetActiveRegions);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveRegions.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            Type [] methodGetActiveRegionsParametersTypes = null;
            object[] parametersOfGetActiveRegions = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            parametersOfGetActiveRegions.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            Type [] methodGetActiveRegionsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            Type [] methodGetActiveRegionsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveRegionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionController_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 1);

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