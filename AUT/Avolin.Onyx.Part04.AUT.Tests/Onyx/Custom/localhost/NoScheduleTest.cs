using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.NoSchedule" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NoScheduleTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NoSchedule" />)
        /// </summary>
        public NoScheduleTest() : base(typeof(NoSchedule))
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

        #region General Initializer : Class (NoSchedule) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _noScheduleInstanceType;
        private NoSchedule _noScheduleInstance;
        private NoSchedule _noScheduleInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NoSchedule" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _noScheduleInstanceType = typeof(NoSchedule);
            _noScheduleInstanceFixture = this.Create<NoSchedule>(false);
            _noScheduleInstance = _noScheduleInstanceFixture ?? this.Create<NoSchedule>(true);
            CurrentInstance = _noScheduleInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (NoSchedule) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NoSchedule" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_NoSchedule_Is_Instance_Present_Test()
        {
            // Assert
            _noScheduleInstanceType.ShouldNotBeNull();
            _noScheduleInstance.ShouldNotBeNull();
            _noScheduleInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NoSchedule) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NoSchedule" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_NoSchedule_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _noScheduleInstance.ShouldBeAssignableTo<NoSchedule>();
            _noScheduleInstanceFixture.ShouldBeAssignableTo<NoSchedule>();
            CurrentInstance.ShouldBeAssignableTo<NoSchedule>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NoSchedule) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_NoSchedule_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NoSchedule instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}