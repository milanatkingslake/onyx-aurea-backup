using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Survey.SurveyException;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.SurveyException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.SurveyException.SurveyBaseException" />)
    ///     and namespace <see cref="Onyx.UI.Survey.SurveyException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyBaseExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyBaseException" />)
        /// </summary>
        public SurveyBaseExceptionTest() : base(typeof(SurveyBaseException))
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

        #region General Initializer : Class (SurveyBaseException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyBaseExceptionInstanceType;
        private SurveyBaseException _surveyBaseExceptionInstance;
        private SurveyBaseException _surveyBaseExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyBaseException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyBaseExceptionInstanceType = typeof(SurveyBaseException);
            _surveyBaseExceptionInstanceFixture = this.Create<SurveyBaseException>(false);
            _surveyBaseExceptionInstance = _surveyBaseExceptionInstanceFixture ?? this.Create<SurveyBaseException>(true);
            CurrentInstance = _surveyBaseExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SurveyBaseException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBaseException_Is_Instance_Present_Test()
        {
            // Assert
            _surveyBaseExceptionInstanceType.ShouldNotBeNull();
            _surveyBaseExceptionInstance.ShouldNotBeNull();
            _surveyBaseExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyBaseException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyBaseException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBaseException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyBaseExceptionInstance.ShouldBeAssignableTo<SurveyBaseException>();
            _surveyBaseExceptionInstanceFixture.ShouldBeAssignableTo<SurveyBaseException>();
            CurrentInstance.ShouldBeAssignableTo<SurveyBaseException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            SurveyBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SurveyBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _surveyBaseExceptionInstance.ShouldNotBeNull();
            _surveyBaseExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SurveyBaseException>();
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            SurveyBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SurveyBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _surveyBaseExceptionInstance.ShouldNotBeNull();
            _surveyBaseExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) instance created

        /// <summary>
        ///     Class (<see cref="SurveyBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_Is_Created_Test()
        {
            // Assert
            _surveyBaseExceptionInstance.ShouldNotBeNull();
            _surveyBaseExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="SurveyBaseException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_SurveyBaseException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="SurveyBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SurveyBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSurveyBaseExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSurveyBaseExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SurveyBaseException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SurveyBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBaseException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSurveyBaseExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSurveyBaseExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}