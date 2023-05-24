using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Resources;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.Resources
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Resources.CMLocalizedResources" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Resources"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CMLocalizedResourcesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CMLocalizedResources" />)
        /// </summary>
        public CMLocalizedResourcesTest() : base(typeof(CMLocalizedResources))
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

        #region General Initializer : Class (CMLocalizedResources) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cMLocalizedResourcesInstanceType;
        private CMLocalizedResources _cMLocalizedResourcesInstance;
        private CMLocalizedResources _cMLocalizedResourcesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CMLocalizedResources" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cMLocalizedResourcesInstanceType = typeof(CMLocalizedResources);
            _cMLocalizedResourcesInstanceFixture = this.Create<CMLocalizedResources>(false);
            _cMLocalizedResourcesInstance = _cMLocalizedResourcesInstanceFixture ?? this.Create<CMLocalizedResources>(true);
            CurrentInstance = _cMLocalizedResourcesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CMLocalizedResources) Initializer

        #region Methods

        private const string MethodGetString = "GetString";

        #endregion

        #endregion

        #region General Initializer : Class (CMLocalizedResources) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CMLocalizedResources" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMLocalizedResources_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CMLocalizedResources)

        #region General Initializer : Class (CMLocalizedResources) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CMLocalizedResources" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetString, 0)]
        public void AUT_CMLocalizedResources_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CMLocalizedResources) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CMLocalizedResources" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMLocalizedResources_Is_Instance_Present_Test()
        {
            // Assert
            _cMLocalizedResourcesInstanceType.ShouldNotBeNull();
            _cMLocalizedResourcesInstance.ShouldNotBeNull();
            _cMLocalizedResourcesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CMLocalizedResources) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CMLocalizedResources" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMLocalizedResources_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cMLocalizedResourcesInstance.ShouldBeAssignableTo<CMLocalizedResources>();
            _cMLocalizedResourcesInstanceFixture.ShouldBeAssignableTo<CMLocalizedResources>();
            CurrentInstance.ShouldBeAssignableTo<CMLocalizedResources>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CMLocalizedResources) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMLocalizedResources_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CMLocalizedResources instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var name = this.CreateType<string>();

            // Act
            Action executeAction = () => _cMLocalizedResourcesInstance.GetString(name);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var name = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _cMLocalizedResourcesInstance.GetString(name);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var name = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { name };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cMLocalizedResourcesInstanceFixture, parametersOfGetString);
            var result2 = this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var name = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { name };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLocalizedResourcesInstanceFixture, parametersOfGetString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var name = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLocalizedResources_GetString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);
            const int parametersCount = 1;

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