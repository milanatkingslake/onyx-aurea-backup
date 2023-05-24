using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptingException;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptingException
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptingException.ScriptingBusinessLayerRewindException" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptingException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingBusinessLayerRewindExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingBusinessLayerRewindException" />)
        /// </summary>
        public ScriptingBusinessLayerRewindExceptionTest() : base(typeof(ScriptingBusinessLayerRewindException))
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

        #region General Initializer : Class (ScriptingBusinessLayerRewindException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingBusinessLayerRewindExceptionInstanceType;
        private ScriptingBusinessLayerRewindException _scriptingBusinessLayerRewindExceptionInstance;
        private ScriptingBusinessLayerRewindException _scriptingBusinessLayerRewindExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingBusinessLayerRewindException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingBusinessLayerRewindExceptionInstanceType = typeof(ScriptingBusinessLayerRewindException);
            _scriptingBusinessLayerRewindExceptionInstanceFixture = this.Create<ScriptingBusinessLayerRewindException>(false);
            _scriptingBusinessLayerRewindExceptionInstance = _scriptingBusinessLayerRewindExceptionInstanceFixture ?? this.Create<ScriptingBusinessLayerRewindException>(true);
            CurrentInstance = _scriptingBusinessLayerRewindExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScriptingBusinessLayerRewindException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayerRewindException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBusinessLayerRewindException_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingBusinessLayerRewindExceptionInstanceType.ShouldNotBeNull();
            _scriptingBusinessLayerRewindExceptionInstance.ShouldNotBeNull();
            _scriptingBusinessLayerRewindExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingBusinessLayerRewindException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayerRewindException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBusinessLayerRewindException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingBusinessLayerRewindExceptionInstance.ShouldBeAssignableTo<ScriptingBusinessLayerRewindException>();
            _scriptingBusinessLayerRewindExceptionInstanceFixture.ShouldBeAssignableTo<ScriptingBusinessLayerRewindException>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingBusinessLayerRewindException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptingBusinessLayerRewindException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBusinessLayerRewindException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptingBusinessLayerRewindException instance = null;

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