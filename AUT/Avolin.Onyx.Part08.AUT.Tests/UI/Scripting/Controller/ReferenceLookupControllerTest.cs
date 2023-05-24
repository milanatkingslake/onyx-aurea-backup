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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.ReferenceLookupController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReferenceLookupControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReferenceLookupController" />)
        /// </summary>
        public ReferenceLookupControllerTest() : base(typeof(ReferenceLookupController))
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

        #region General Initializer : Class (ReferenceLookupController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _referenceLookupControllerInstanceType;
        private ReferenceLookupController _referenceLookupControllerInstance;
        private ReferenceLookupController _referenceLookupControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReferenceLookupController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _referenceLookupControllerInstanceType = typeof(ReferenceLookupController);
            _referenceLookupControllerInstanceFixture = this.Create<ReferenceLookupController>(false);
            _referenceLookupControllerInstance = _referenceLookupControllerInstanceFixture ?? this.Create<ReferenceLookupController>(true);
            CurrentInstance = _referenceLookupControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupController) Initializer

        #region Methods

        private const string MethodRetreiveList = "RetreiveList";

        #endregion

        #endregion

        #region General Initializer : Class (ReferenceLookupController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReferenceLookupController)

        #region General Initializer : Class (ReferenceLookupController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetreiveList, 0)]
        public void AUT_ReferenceLookupController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ReferenceLookupController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupController_Is_Instance_Present_Test()
        {
            // Assert
            _referenceLookupControllerInstanceType.ShouldNotBeNull();
            _referenceLookupControllerInstance.ShouldNotBeNull();
            _referenceLookupControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReferenceLookupController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReferenceLookupController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _referenceLookupControllerInstance.ShouldBeAssignableTo<ReferenceLookupController>();
            _referenceLookupControllerInstanceFixture.ShouldBeAssignableTo<ReferenceLookupController>();
            CurrentInstance.ShouldBeAssignableTo<ReferenceLookupController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReferenceLookupController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ReferenceLookupController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReferenceLookupController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();

            // Act
            Action executeAction = () => _referenceLookupControllerInstance.RetreiveList(name, parentId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _referenceLookupControllerInstance.RetreiveList(name, parentId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfRetreiveList = { name, parentId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, methodRetreiveListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_referenceLookupControllerInstanceFixture, parametersOfRetreiveList);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodRetreiveList, parametersOfRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetreiveList.ShouldNotBeNull();
            parametersOfRetreiveList.Length.ShouldBe(2);
            methodRetreiveListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfRetreiveList = { name, parentId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodRetreiveList, parametersOfRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            parametersOfRetreiveList.ShouldNotBeNull();
            parametersOfRetreiveList.Length.ShouldBe(2);
            methodRetreiveListParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetreiveListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetreiveListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupController_RetreiveList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, 0);
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