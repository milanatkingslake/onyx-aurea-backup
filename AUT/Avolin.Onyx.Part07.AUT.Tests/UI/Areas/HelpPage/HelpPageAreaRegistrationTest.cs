using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.HelpPageAreaRegistration" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpPageAreaRegistrationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpPageAreaRegistration" />)
        /// </summary>
        public HelpPageAreaRegistrationTest() : base(typeof(HelpPageAreaRegistration))
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

        #region General Initializer : Class (HelpPageAreaRegistration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpPageAreaRegistrationInstanceType;
        private HelpPageAreaRegistration _helpPageAreaRegistrationInstance;
        private HelpPageAreaRegistration _helpPageAreaRegistrationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelpPageAreaRegistration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpPageAreaRegistrationInstanceType = typeof(HelpPageAreaRegistration);
            _helpPageAreaRegistrationInstanceFixture = this.Create<HelpPageAreaRegistration>(false);
            _helpPageAreaRegistrationInstance = _helpPageAreaRegistrationInstanceFixture ?? this.Create<HelpPageAreaRegistration>(true);
            CurrentInstance = _helpPageAreaRegistrationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpPageAreaRegistration) Initializer

        #region Properties

        private const string PropertyAreaName = "AreaName";

        #endregion

        #region Methods

        private const string MethodRegisterArea = "RegisterArea";

        #endregion

        #endregion

        #region General Initializer : Class (HelpPageAreaRegistration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpPageAreaRegistration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageAreaRegistration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpPageAreaRegistration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpPageAreaRegistration)

        #region General Initializer : Class (HelpPageAreaRegistration) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRegisterArea, 0)]
        public void AUT_HelpPageAreaRegistration_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpPageAreaRegistration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyAreaName)]
        [Category("AUT Property")]
        public void AUT_HelpPageAreaRegistration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (HelpPageAreaRegistration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelpPageAreaRegistration_Is_Instance_Present_Test()
        {
            // Assert
            _helpPageAreaRegistrationInstanceType.ShouldNotBeNull();
            _helpPageAreaRegistrationInstance.ShouldNotBeNull();
            _helpPageAreaRegistrationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HelpPageAreaRegistration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelpPageAreaRegistration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelpPageAreaRegistration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helpPageAreaRegistrationInstance.ShouldBeAssignableTo<HelpPageAreaRegistration>();
            _helpPageAreaRegistrationInstanceFixture.ShouldBeAssignableTo<HelpPageAreaRegistration>();
            CurrentInstance.ShouldBeAssignableTo<HelpPageAreaRegistration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HelpPageAreaRegistration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpPageAreaRegistration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HelpPageAreaRegistration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelpPageAreaRegistration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyAreaName)]
        public void AUT_HelpPageAreaRegistration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelpPageAreaRegistration) => Property (AreaName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpPageAreaRegistration_Public_Class_AreaName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAreaName);
            var propertyInfo = this.GetPropertyInfo(PropertyAreaName);

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

        #region Method Call : (RegisterArea) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var context = this.CreateType<AreaRegistrationContext>();

            // Act
            Action executeAction = () => _helpPageAreaRegistrationInstance.RegisterArea(context);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterArea) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var context = this.CreateType<AreaRegistrationContext>();
            var methodRegisterAreaParametersTypes = new Type[] { typeof(AreaRegistrationContext) };
            object[] parametersOfRegisterArea = { context };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterArea, methodRegisterAreaParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageAreaRegistrationInstanceFixture, parametersOfRegisterArea);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterArea.ShouldNotBeNull();
            parametersOfRegisterArea.Length.ShouldBe(1);
            methodRegisterAreaParametersTypes.Length.ShouldBe(1);
            methodRegisterAreaParametersTypes.Length.ShouldBe(parametersOfRegisterArea.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterArea) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var context = this.CreateType<AreaRegistrationContext>();
            var methodRegisterAreaParametersTypes = new Type[] { typeof(AreaRegistrationContext) };
            object[] parametersOfRegisterArea = { context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterArea, parametersOfRegisterArea, methodRegisterAreaParametersTypes);

            // Assert
            parametersOfRegisterArea.ShouldNotBeNull();
            parametersOfRegisterArea.Length.ShouldBe(1);
            methodRegisterAreaParametersTypes.Length.ShouldBe(1);
            methodRegisterAreaParametersTypes.Length.ShouldBe(parametersOfRegisterArea.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterArea) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterArea, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterArea) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var methodRegisterAreaParametersTypes = new Type[] { typeof(AreaRegistrationContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterArea, methodRegisterAreaParametersTypes);

            // Assert
            methodRegisterAreaParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterArea) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpPageAreaRegistration_RegisterArea_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterArea);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterArea, 0);

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