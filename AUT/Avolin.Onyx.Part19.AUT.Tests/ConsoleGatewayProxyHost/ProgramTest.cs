using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ConsoleGatewayProxyHost;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.ConsoleGatewayProxyHost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ConsoleGatewayProxyHost.Program" />)
    ///     and namespace <see cref="Onyx.ConsoleGatewayProxyHost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ProgramTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Program" />)
        /// </summary>
        public ProgramTest() : base(typeof(Program))
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

        #region General Initializer : Class (Program) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _programInstanceType;
        private Program _programInstance;
        private Program _programInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Program" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _programInstanceType = typeof(Program);
            _programInstanceFixture = this.Create<Program>(false);
            _programInstance = _programInstanceFixture ?? this.Create<Program>(true);
            CurrentInstance = _programInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Program) Initializer

        #region Methods

        private const string MethodMain = "Main";

        #endregion

        #endregion

        #region General Initializer : Class (Program) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Program_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #endregion

        #region Category : Instance

        #region General Instance : Class (Program) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Program" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Program_Is_Instance_Present_Test()
        {
            // Assert
            _programInstanceType.ShouldNotBeNull();
            _programInstance.ShouldNotBeNull();
            _programInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Program) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Program" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Program_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _programInstance.ShouldBeAssignableTo<Program>();
            _programInstanceFixture.ShouldBeAssignableTo<Program>();
            CurrentInstance.ShouldBeAssignableTo<Program>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Program) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Program_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Program instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (Main) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Program_Main_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMain);
            var currentMethodInfo = this.GetMethodInfo(MethodMain, 0);
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