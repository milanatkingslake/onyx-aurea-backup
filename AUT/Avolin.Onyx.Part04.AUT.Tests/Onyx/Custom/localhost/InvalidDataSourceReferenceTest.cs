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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.InvalidDataSourceReference" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class InvalidDataSourceReferenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="InvalidDataSourceReference" />)
        /// </summary>
        public InvalidDataSourceReferenceTest() : base(typeof(InvalidDataSourceReference))
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

        #region General Initializer : Class (InvalidDataSourceReference) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _invalidDataSourceReferenceInstanceType;
        private InvalidDataSourceReference _invalidDataSourceReferenceInstance;
        private InvalidDataSourceReference _invalidDataSourceReferenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="InvalidDataSourceReference" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _invalidDataSourceReferenceInstanceType = typeof(InvalidDataSourceReference);
            _invalidDataSourceReferenceInstanceFixture = this.Create<InvalidDataSourceReference>(false);
            _invalidDataSourceReferenceInstance = _invalidDataSourceReferenceInstanceFixture ?? this.Create<InvalidDataSourceReference>(true);
            CurrentInstance = _invalidDataSourceReferenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (InvalidDataSourceReference) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="InvalidDataSourceReference" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_InvalidDataSourceReference_Is_Instance_Present_Test()
        {
            // Assert
            _invalidDataSourceReferenceInstanceType.ShouldNotBeNull();
            _invalidDataSourceReferenceInstance.ShouldNotBeNull();
            _invalidDataSourceReferenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (InvalidDataSourceReference) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="InvalidDataSourceReference" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_InvalidDataSourceReference_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _invalidDataSourceReferenceInstance.ShouldBeAssignableTo<InvalidDataSourceReference>();
            _invalidDataSourceReferenceInstanceFixture.ShouldBeAssignableTo<InvalidDataSourceReference>();
            CurrentInstance.ShouldBeAssignableTo<InvalidDataSourceReference>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (InvalidDataSourceReference) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_InvalidDataSourceReference_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            InvalidDataSourceReference instance = null;

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