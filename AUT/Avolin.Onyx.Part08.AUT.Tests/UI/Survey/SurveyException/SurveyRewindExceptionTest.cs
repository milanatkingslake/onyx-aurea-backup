using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Survey.SurveyException;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.SurveyException
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.SurveyException.SurveyRewindException" />)
    ///     and namespace <see cref="Onyx.UI.Survey.SurveyException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyRewindExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyRewindException" />)
        /// </summary>
        public SurveyRewindExceptionTest() : base(typeof(SurveyRewindException))
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

        #region General Initializer : Class (SurveyRewindException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyRewindExceptionInstanceType;
        private SurveyRewindException _surveyRewindExceptionInstance;
        private SurveyRewindException _surveyRewindExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyRewindException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyRewindExceptionInstanceType = typeof(SurveyRewindException);
            _surveyRewindExceptionInstanceFixture = this.Create<SurveyRewindException>(false);
            _surveyRewindExceptionInstance = _surveyRewindExceptionInstanceFixture ?? this.Create<SurveyRewindException>(true);
            CurrentInstance = _surveyRewindExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SurveyRewindException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyRewindException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyRewindException_Is_Instance_Present_Test()
        {
            // Assert
            _surveyRewindExceptionInstanceType.ShouldNotBeNull();
            _surveyRewindExceptionInstance.ShouldNotBeNull();
            _surveyRewindExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyRewindException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyRewindException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyRewindException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyRewindExceptionInstance.ShouldBeAssignableTo<SurveyRewindException>();
            _surveyRewindExceptionInstanceFixture.ShouldBeAssignableTo<SurveyRewindException>();
            CurrentInstance.ShouldBeAssignableTo<SurveyRewindException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyRewindException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyRewindException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyRewindException instance = null;

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