using System;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI.Persistence
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.OedbEntities" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OedbEntitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OedbEntities" />)
        /// </summary>
        public OedbEntitiesTest() : base(typeof(OedbEntities))
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

        #region General Initializer : Class (OedbEntities) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oedbEntitiesInstanceType;
        private OedbEntities _oedbEntitiesInstance;
        private OedbEntities _oedbEntitiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OedbEntities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oedbEntitiesInstanceType = typeof(OedbEntities);
            _oedbEntitiesInstanceFixture = this.Create<OedbEntities>(false);
            _oedbEntitiesInstance = _oedbEntitiesInstanceFixture ?? this.Create<OedbEntities>(true);
            CurrentInstance = _oedbEntitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OedbEntities) Initializer

        #region Methods

        private const string MethodOnModelCreating = "OnModelCreating";

        #endregion

        #endregion

        #region General Initializer : Class (OedbEntities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OedbEntities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OedbEntities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OedbEntities)

        #region General Initializer : Class (OedbEntities) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OedbEntities" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOnModelCreating, 0)]
        public void AUT_OedbEntities_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OedbEntities) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OedbEntities" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OedbEntities_Is_Instance_Present_Test()
        {
            // Assert
            _oedbEntitiesInstanceType.ShouldNotBeNull();
            _oedbEntitiesInstance.ShouldNotBeNull();
            _oedbEntitiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OedbEntities) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OedbEntities" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OedbEntities_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oedbEntitiesInstance.ShouldBeAssignableTo<OedbEntities>();
            _oedbEntitiesInstanceFixture.ShouldBeAssignableTo<OedbEntities>();
            CurrentInstance.ShouldBeAssignableTo<OedbEntities>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OedbEntities) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OedbEntities_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OedbEntities instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (OnModelCreating) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OedbEntities_OnModelCreating_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var modelBuilder = this.CreateType<DbModelBuilder>();
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };
            object[] parametersOfOnModelCreating = { modelBuilder };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, methodOnModelCreatingParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oedbEntitiesInstanceFixture, parametersOfOnModelCreating);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnModelCreating.ShouldNotBeNull();
            parametersOfOnModelCreating.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(parametersOfOnModelCreating.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OedbEntities_OnModelCreating_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var modelBuilder = this.CreateType<DbModelBuilder>();
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };
            object[] parametersOfOnModelCreating = { modelBuilder };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnModelCreating, parametersOfOnModelCreating, methodOnModelCreatingParametersTypes);

            // Assert
            parametersOfOnModelCreating.ShouldNotBeNull();
            parametersOfOnModelCreating.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(parametersOfOnModelCreating.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OedbEntities_OnModelCreating_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OedbEntities_OnModelCreating_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnModelCreating, methodOnModelCreatingParametersTypes);

            // Assert
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OedbEntities_OnModelCreating_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, 0);

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