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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptingException.ScriptingRewindException" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptingException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingRewindExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingRewindException" />)
        /// </summary>
        public ScriptingRewindExceptionTest() : base(typeof(ScriptingRewindException))
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

        #region General Initializer : Class (ScriptingRewindException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingRewindExceptionInstanceType;
        private ScriptingRewindException _scriptingRewindExceptionInstance;
        private ScriptingRewindException _scriptingRewindExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingRewindException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingRewindExceptionInstanceType = typeof(ScriptingRewindException);
            _scriptingRewindExceptionInstanceFixture = this.Create<ScriptingRewindException>(false);
            _scriptingRewindExceptionInstance = _scriptingRewindExceptionInstanceFixture ?? this.Create<ScriptingRewindException>(true);
            CurrentInstance = _scriptingRewindExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScriptingRewindException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingRewindException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingRewindException_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingRewindExceptionInstanceType.ShouldNotBeNull();
            _scriptingRewindExceptionInstance.ShouldNotBeNull();
            _scriptingRewindExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingRewindException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingRewindException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingRewindException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingRewindExceptionInstance.ShouldBeAssignableTo<ScriptingRewindException>();
            _scriptingRewindExceptionInstanceFixture.ShouldBeAssignableTo<ScriptingRewindException>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingRewindException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptingRewindException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingRewindException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptingRewindException instance = null;

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