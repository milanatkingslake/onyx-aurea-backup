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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.RecurrencePattern" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class RecurrencePatternTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RecurrencePattern" />)
        /// </summary>
        public RecurrencePatternTest() : base(typeof(RecurrencePattern))
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

        #region General Initializer : Class (RecurrencePattern) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _recurrencePatternInstanceType;
        private RecurrencePattern _recurrencePatternInstance;
        private RecurrencePattern _recurrencePatternInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RecurrencePattern" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _recurrencePatternInstanceType = typeof(RecurrencePattern);
            _recurrencePatternInstanceFixture = this.Create<RecurrencePattern>(false);
            _recurrencePatternInstance = _recurrencePatternInstanceFixture ?? this.Create<RecurrencePattern>(true);
            CurrentInstance = _recurrencePatternInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (RecurrencePattern) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RecurrencePattern" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RecurrencePattern_Is_Instance_Present_Test()
        {
            // Assert
            _recurrencePatternInstanceType.ShouldNotBeNull();
            _recurrencePatternInstance.ShouldNotBeNull();
            _recurrencePatternInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RecurrencePattern) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RecurrencePattern" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RecurrencePattern_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _recurrencePatternInstance.ShouldBeAssignableTo<RecurrencePattern>();
            _recurrencePatternInstanceFixture.ShouldBeAssignableTo<RecurrencePattern>();
            CurrentInstance.ShouldBeAssignableTo<RecurrencePattern>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RecurrencePattern) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_RecurrencePattern_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RecurrencePattern instance = null;

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