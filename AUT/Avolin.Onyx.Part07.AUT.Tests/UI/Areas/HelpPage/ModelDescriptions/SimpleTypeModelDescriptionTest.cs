using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.SimpleTypeModelDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SimpleTypeModelDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SimpleTypeModelDescription" />)
        /// </summary>
        public SimpleTypeModelDescriptionTest() : base(typeof(SimpleTypeModelDescription))
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

        #region General Initializer : Class (SimpleTypeModelDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _simpleTypeModelDescriptionInstanceType;
        private SimpleTypeModelDescription _simpleTypeModelDescriptionInstance;
        private SimpleTypeModelDescription _simpleTypeModelDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SimpleTypeModelDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _simpleTypeModelDescriptionInstanceType = typeof(SimpleTypeModelDescription);
            _simpleTypeModelDescriptionInstanceFixture = this.Create<SimpleTypeModelDescription>(false);
            _simpleTypeModelDescriptionInstance = _simpleTypeModelDescriptionInstanceFixture ?? this.Create<SimpleTypeModelDescription>(true);
            CurrentInstance = _simpleTypeModelDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SimpleTypeModelDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SimpleTypeModelDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SimpleTypeModelDescription_Is_Instance_Present_Test()
        {
            // Assert
            _simpleTypeModelDescriptionInstanceType.ShouldNotBeNull();
            _simpleTypeModelDescriptionInstance.ShouldNotBeNull();
            _simpleTypeModelDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SimpleTypeModelDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SimpleTypeModelDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SimpleTypeModelDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _simpleTypeModelDescriptionInstance.ShouldBeAssignableTo<SimpleTypeModelDescription>();
            _simpleTypeModelDescriptionInstanceFixture.ShouldBeAssignableTo<SimpleTypeModelDescription>();
            CurrentInstance.ShouldBeAssignableTo<SimpleTypeModelDescription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SimpleTypeModelDescription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SimpleTypeModelDescription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SimpleTypeModelDescription instance = null;

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