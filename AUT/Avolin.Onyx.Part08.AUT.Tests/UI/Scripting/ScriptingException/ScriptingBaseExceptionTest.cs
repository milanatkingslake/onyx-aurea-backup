using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptingException;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptingException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptingException.ScriptingBaseException" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptingException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingBaseExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingBaseException" />)
        /// </summary>
        public ScriptingBaseExceptionTest() : base(typeof(ScriptingBaseException))
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

        #region General Initializer : Class (ScriptingBaseException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingBaseExceptionInstanceType;
        private ScriptingBaseException _scriptingBaseExceptionInstance;
        private ScriptingBaseException _scriptingBaseExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingBaseException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingBaseExceptionInstanceType = typeof(ScriptingBaseException);
            _scriptingBaseExceptionInstanceFixture = this.Create<ScriptingBaseException>(false);
            _scriptingBaseExceptionInstance = _scriptingBaseExceptionInstanceFixture ?? this.Create<ScriptingBaseException>(true);
            CurrentInstance = _scriptingBaseExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScriptingBaseException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBaseException_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingBaseExceptionInstanceType.ShouldNotBeNull();
            _scriptingBaseExceptionInstance.ShouldNotBeNull();
            _scriptingBaseExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingBaseException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingBaseException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBaseException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingBaseExceptionInstance.ShouldBeAssignableTo<ScriptingBaseException>();
            _scriptingBaseExceptionInstanceFixture.ShouldBeAssignableTo<ScriptingBaseException>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingBaseException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptingBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            ScriptingBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptingBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptingBaseExceptionInstance.ShouldNotBeNull();
            _scriptingBaseExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptingBaseException>();
        }

        #endregion

        #region General Constructor : Class (ScriptingBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            ScriptingBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptingBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptingBaseExceptionInstance.ShouldNotBeNull();
            _scriptingBaseExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptingBaseException) instance created

        /// <summary>
        ///     Class (<see cref="ScriptingBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_Is_Created_Test()
        {
            // Assert
            _scriptingBaseExceptionInstance.ShouldNotBeNull();
            _scriptingBaseExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptingBaseException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptingBaseException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptingBaseException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ScriptingBaseException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptingBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptingBaseException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptingBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptingBaseExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptingBaseExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptingBaseException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptingBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBaseException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptingBaseExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptingBaseExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}