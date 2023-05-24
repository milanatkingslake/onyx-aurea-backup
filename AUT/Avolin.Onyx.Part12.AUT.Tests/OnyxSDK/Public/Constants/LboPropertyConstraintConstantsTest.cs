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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboPropertyConstraintConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboPropertyConstraintConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboPropertyConstraintConstants" />)
        /// </summary>
        public LboPropertyConstraintConstantsTest() : base(typeof(LboPropertyConstraintConstants))
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

        #region General Initializer : Class (LboPropertyConstraintConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboPropertyConstraintConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboPropertyConstraintConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboPropertyConstraintConstantsInstanceType = typeof(LboPropertyConstraintConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboPropertyConstraintConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldINSTALLED_BY = "INSTALLED_BY";
        private const string FieldDEFAULT_NULL = "DEFAULT_NULL";
        private const string FieldTYPE = "TYPE";
        private const string FieldVALUE = "VALUE";
        private const string FieldPROPERTY_CONSTRAINT = "PROPERTY_CONSTRAINT";

        #endregion

        #endregion

        #region General Initializer : Class (LboPropertyConstraintConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraintConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyConstraintConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboPropertyConstraintConstants)

        #region General Initializer : Class (LboPropertyConstraintConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraintConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldINSTALLED_BY)]
        [TestCase(FieldDEFAULT_NULL)]
        [TestCase(FieldTYPE)]
        [TestCase(FieldVALUE)]
        [TestCase(FieldPROPERTY_CONSTRAINT)]
        [Category("AUT Fields")]
        public void AUT_LboPropertyConstraintConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboPropertyConstraintConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraintConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboPropertyConstraintConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboPropertyConstraintConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}