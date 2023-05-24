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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.SurveyException.SurveyBusinessLayerRewindException" />)
    ///     and namespace <see cref="Onyx.UI.Survey.SurveyException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyBusinessLayerRewindExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyBusinessLayerRewindException" />)
        /// </summary>
        public SurveyBusinessLayerRewindExceptionTest() : base(typeof(SurveyBusinessLayerRewindException))
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

        #region General Initializer : Class (SurveyBusinessLayerRewindException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyBusinessLayerRewindExceptionInstanceType;
        private SurveyBusinessLayerRewindException _surveyBusinessLayerRewindExceptionInstance;
        private SurveyBusinessLayerRewindException _surveyBusinessLayerRewindExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyBusinessLayerRewindException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyBusinessLayerRewindExceptionInstanceType = typeof(SurveyBusinessLayerRewindException);
            _surveyBusinessLayerRewindExceptionInstanceFixture = this.Create<SurveyBusinessLayerRewindException>(false);
            _surveyBusinessLayerRewindExceptionInstance = _surveyBusinessLayerRewindExceptionInstanceFixture ?? this.Create<SurveyBusinessLayerRewindException>(true);
            CurrentInstance = _surveyBusinessLayerRewindExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SurveyBusinessLayerRewindException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayerRewindException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBusinessLayerRewindException_Is_Instance_Present_Test()
        {
            // Assert
            _surveyBusinessLayerRewindExceptionInstanceType.ShouldNotBeNull();
            _surveyBusinessLayerRewindExceptionInstance.ShouldNotBeNull();
            _surveyBusinessLayerRewindExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyBusinessLayerRewindException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayerRewindException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBusinessLayerRewindException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyBusinessLayerRewindExceptionInstance.ShouldBeAssignableTo<SurveyBusinessLayerRewindException>();
            _surveyBusinessLayerRewindExceptionInstanceFixture.ShouldBeAssignableTo<SurveyBusinessLayerRewindException>();
            CurrentInstance.ShouldBeAssignableTo<SurveyBusinessLayerRewindException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyBusinessLayerRewindException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBusinessLayerRewindException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyBusinessLayerRewindException instance = null;

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