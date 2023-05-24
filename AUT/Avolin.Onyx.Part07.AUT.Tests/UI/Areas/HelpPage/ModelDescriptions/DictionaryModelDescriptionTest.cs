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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.DictionaryModelDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DictionaryModelDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DictionaryModelDescription" />)
        /// </summary>
        public DictionaryModelDescriptionTest() : base(typeof(DictionaryModelDescription))
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

        #region General Initializer : Class (DictionaryModelDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dictionaryModelDescriptionInstanceType;
        private DictionaryModelDescription _dictionaryModelDescriptionInstance;
        private DictionaryModelDescription _dictionaryModelDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DictionaryModelDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dictionaryModelDescriptionInstanceType = typeof(DictionaryModelDescription);
            _dictionaryModelDescriptionInstanceFixture = this.Create<DictionaryModelDescription>(false);
            _dictionaryModelDescriptionInstance = _dictionaryModelDescriptionInstanceFixture ?? this.Create<DictionaryModelDescription>(true);
            CurrentInstance = _dictionaryModelDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (DictionaryModelDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DictionaryModelDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DictionaryModelDescription_Is_Instance_Present_Test()
        {
            // Assert
            _dictionaryModelDescriptionInstanceType.ShouldNotBeNull();
            _dictionaryModelDescriptionInstance.ShouldNotBeNull();
            _dictionaryModelDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DictionaryModelDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DictionaryModelDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DictionaryModelDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dictionaryModelDescriptionInstance.ShouldBeAssignableTo<DictionaryModelDescription>();
            _dictionaryModelDescriptionInstanceFixture.ShouldBeAssignableTo<DictionaryModelDescription>();
            CurrentInstance.ShouldBeAssignableTo<DictionaryModelDescription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DictionaryModelDescription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DictionaryModelDescription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DictionaryModelDescription instance = null;

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