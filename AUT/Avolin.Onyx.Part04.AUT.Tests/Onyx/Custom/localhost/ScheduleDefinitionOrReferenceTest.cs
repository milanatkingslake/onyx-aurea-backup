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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ScheduleDefinitionOrReference" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScheduleDefinitionOrReferenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScheduleDefinitionOrReference" />)
        /// </summary>
        public ScheduleDefinitionOrReferenceTest() : base(typeof(ScheduleDefinitionOrReference))
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

        #region General Initializer : Class (ScheduleDefinitionOrReference) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scheduleDefinitionOrReferenceInstanceType;
        private ScheduleDefinitionOrReference _scheduleDefinitionOrReferenceInstance;
        private ScheduleDefinitionOrReference _scheduleDefinitionOrReferenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScheduleDefinitionOrReference" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scheduleDefinitionOrReferenceInstanceType = typeof(ScheduleDefinitionOrReference);
            _scheduleDefinitionOrReferenceInstanceFixture = this.Create<ScheduleDefinitionOrReference>(false);
            _scheduleDefinitionOrReferenceInstance = _scheduleDefinitionOrReferenceInstanceFixture ?? this.Create<ScheduleDefinitionOrReference>(true);
            CurrentInstance = _scheduleDefinitionOrReferenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScheduleDefinitionOrReference) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScheduleDefinitionOrReference" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleDefinitionOrReference_Is_Instance_Present_Test()
        {
            // Assert
            _scheduleDefinitionOrReferenceInstanceType.ShouldNotBeNull();
            _scheduleDefinitionOrReferenceInstance.ShouldNotBeNull();
            _scheduleDefinitionOrReferenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScheduleDefinitionOrReference) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScheduleDefinitionOrReference" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleDefinitionOrReference_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scheduleDefinitionOrReferenceInstance.ShouldBeAssignableTo<ScheduleDefinitionOrReference>();
            _scheduleDefinitionOrReferenceInstanceFixture.ShouldBeAssignableTo<ScheduleDefinitionOrReference>();
            CurrentInstance.ShouldBeAssignableTo<ScheduleDefinitionOrReference>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScheduleDefinitionOrReference) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ScheduleDefinitionOrReference_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScheduleDefinitionOrReference instance = null;

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