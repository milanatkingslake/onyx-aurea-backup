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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ParameterValueOrFieldReference" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ParameterValueOrFieldReferenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ParameterValueOrFieldReference" />)
        /// </summary>
        public ParameterValueOrFieldReferenceTest() : base(typeof(ParameterValueOrFieldReference))
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

        #region General Initializer : Class (ParameterValueOrFieldReference) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _parameterValueOrFieldReferenceInstanceType;
        private ParameterValueOrFieldReference _parameterValueOrFieldReferenceInstance;
        private ParameterValueOrFieldReference _parameterValueOrFieldReferenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ParameterValueOrFieldReference" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _parameterValueOrFieldReferenceInstanceType = typeof(ParameterValueOrFieldReference);
            _parameterValueOrFieldReferenceInstanceFixture = this.Create<ParameterValueOrFieldReference>(false);
            _parameterValueOrFieldReferenceInstance = _parameterValueOrFieldReferenceInstanceFixture ?? this.Create<ParameterValueOrFieldReference>(true);
            CurrentInstance = _parameterValueOrFieldReferenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ParameterValueOrFieldReference) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ParameterValueOrFieldReference" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ParameterValueOrFieldReference_Is_Instance_Present_Test()
        {
            // Assert
            _parameterValueOrFieldReferenceInstanceType.ShouldNotBeNull();
            _parameterValueOrFieldReferenceInstance.ShouldNotBeNull();
            _parameterValueOrFieldReferenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ParameterValueOrFieldReference) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ParameterValueOrFieldReference" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ParameterValueOrFieldReference_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _parameterValueOrFieldReferenceInstance.ShouldBeAssignableTo<ParameterValueOrFieldReference>();
            _parameterValueOrFieldReferenceInstanceFixture.ShouldBeAssignableTo<ParameterValueOrFieldReference>();
            CurrentInstance.ShouldBeAssignableTo<ParameterValueOrFieldReference>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ParameterValueOrFieldReference) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ParameterValueOrFieldReference_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ParameterValueOrFieldReference instance = null;

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