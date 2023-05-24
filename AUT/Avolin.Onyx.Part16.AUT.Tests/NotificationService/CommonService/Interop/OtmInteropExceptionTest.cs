using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.CommonService.Interop;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.CommonService.Interop
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.CommonService.Interop.OtmInteropException" />)
    ///     and namespace <see cref="NotificationService.CommonService.Interop"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OtmInteropExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OtmInteropException" />)
        /// </summary>
        public OtmInteropExceptionTest() : base(typeof(OtmInteropException))
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

        #region General Initializer : Class (OtmInteropException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _otmInteropExceptionInstanceType;
        private OtmInteropException _otmInteropExceptionInstance;
        private OtmInteropException _otmInteropExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OtmInteropException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _otmInteropExceptionInstanceType = typeof(OtmInteropException);
            _otmInteropExceptionInstanceFixture = this.Create<OtmInteropException>(false);
            _otmInteropExceptionInstance = _otmInteropExceptionInstanceFixture ?? this.Create<OtmInteropException>(true);
            CurrentInstance = _otmInteropExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OtmInteropException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OtmInteropException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmInteropException_Is_Instance_Present_Test()
        {
            // Assert
            _otmInteropExceptionInstanceType.ShouldNotBeNull();
            _otmInteropExceptionInstance.ShouldNotBeNull();
            _otmInteropExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OtmInteropException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OtmInteropException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmInteropException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _otmInteropExceptionInstance.ShouldBeAssignableTo<OtmInteropException>();
            _otmInteropExceptionInstanceFixture.ShouldBeAssignableTo<OtmInteropException>();
            CurrentInstance.ShouldBeAssignableTo<OtmInteropException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OtmInteropException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OtmInteropException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var parameterException = this.CreateType<Exception>();
            OtmInteropException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OtmInteropException(message, parameterException);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _otmInteropExceptionInstance.ShouldNotBeNull();
            _otmInteropExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OtmInteropException>();
        }

        #endregion

        #region General Constructor : Class (OtmInteropException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OtmInteropException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var parameterException = this.CreateType<Exception>();
            OtmInteropException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OtmInteropException(message, parameterException);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _otmInteropExceptionInstance.ShouldNotBeNull();
            _otmInteropExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}