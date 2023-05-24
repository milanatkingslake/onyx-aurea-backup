using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Constants;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LanguageClutureMappingConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LanguageClutureMappingConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LanguageClutureMappingConstants" />)
        /// </summary>
        public LanguageClutureMappingConstantsTest() : base(typeof(LanguageClutureMappingConstants))
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

        #region General Initializer : Class (LanguageClutureMappingConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _languageClutureMappingConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LanguageClutureMappingConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _languageClutureMappingConstantsInstanceType = typeof(LanguageClutureMappingConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LanguageClutureMappingConstants) Initializer

        #region Fields

        private const string FieldONYX_LANGUAGE_CULTURE_MAPPING = "ONYX_LANGUAGE_CULTURE_MAPPING";
        private const string FieldONYX_LANGUAGE_CULTURE_MAPPINGS = "ONYX_LANGUAGE_CULTURE_MAPPINGS";
        private const string FieldONYX_LANGUAGE_CULTURE_MAPPING_SECTION = "ONYX_LANGUAGE_CULTURE_MAPPING_SECTION";
        private const string FieldCULTURE = "CULTURE";
        private const string FieldLANGUAGE = "LANGUAGE";
        private const string FieldUNIQUEID = "UNIQUEID";

        #endregion

        #endregion

        #region General Initializer : Class (LanguageClutureMappingConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LanguageClutureMappingConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LanguageClutureMappingConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LanguageClutureMappingConstants)

        #region General Initializer : Class (LanguageClutureMappingConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LanguageClutureMappingConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldONYX_LANGUAGE_CULTURE_MAPPING)]
        [TestCase(FieldONYX_LANGUAGE_CULTURE_MAPPINGS)]
        [TestCase(FieldONYX_LANGUAGE_CULTURE_MAPPING_SECTION)]
        [TestCase(FieldCULTURE)]
        [TestCase(FieldLANGUAGE)]
        [TestCase(FieldUNIQUEID)]
        [Category("AUT Fields")]
        public void AUT_LanguageClutureMappingConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (LanguageClutureMappingConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LanguageClutureMappingConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LanguageClutureMappingConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _languageClutureMappingConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}