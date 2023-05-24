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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ExpirationDefinition" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ExpirationDefinitionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExpirationDefinition" />)
        /// </summary>
        public ExpirationDefinitionTest() : base(typeof(ExpirationDefinition))
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

        #region General Initializer : Class (ExpirationDefinition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _expirationDefinitionInstanceType;
        private ExpirationDefinition _expirationDefinitionInstance;
        private ExpirationDefinition _expirationDefinitionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ExpirationDefinition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _expirationDefinitionInstanceType = typeof(ExpirationDefinition);
            _expirationDefinitionInstanceFixture = this.Create<ExpirationDefinition>(false);
            _expirationDefinitionInstance = _expirationDefinitionInstanceFixture ?? this.Create<ExpirationDefinition>(true);
            CurrentInstance = _expirationDefinitionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ExpirationDefinition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExpirationDefinition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExpirationDefinition_Is_Instance_Present_Test()
        {
            // Assert
            _expirationDefinitionInstanceType.ShouldNotBeNull();
            _expirationDefinitionInstance.ShouldNotBeNull();
            _expirationDefinitionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExpirationDefinition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExpirationDefinition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExpirationDefinition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _expirationDefinitionInstance.ShouldBeAssignableTo<ExpirationDefinition>();
            _expirationDefinitionInstanceFixture.ShouldBeAssignableTo<ExpirationDefinition>();
            CurrentInstance.ShouldBeAssignableTo<ExpirationDefinition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExpirationDefinition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ExpirationDefinition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ExpirationDefinition instance = null;

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