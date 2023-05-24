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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboSortPropertyConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboSortPropertyConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboSortPropertyConstants" />)
        /// </summary>
        public LboSortPropertyConstantsTest() : base(typeof(LboSortPropertyConstants))
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

        #region General Initializer : Class (LboSortPropertyConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboSortPropertyConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboSortPropertyConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboSortPropertyConstantsInstanceType = typeof(LboSortPropertyConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboSortPropertyConstants) Initializer

        #region Fields

        private const string FieldPROPERTY_ID = "PROPERTY_ID";
        private const string FieldSORT_DIRECTION = "SORT_DIRECTION";
        private const string FieldSORT_PROPERTY = "SORT_PROPERTY";

        #endregion

        #endregion

        #region General Initializer : Class (LboSortPropertyConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboSortPropertyConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboSortPropertyConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboSortPropertyConstants)

        #region General Initializer : Class (LboSortPropertyConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboSortPropertyConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldPROPERTY_ID)]
        [TestCase(FieldSORT_DIRECTION)]
        [TestCase(FieldSORT_PROPERTY)]
        [Category("AUT Fields")]
        public void AUT_LboSortPropertyConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboSortPropertyConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboSortPropertyConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboSortPropertyConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboSortPropertyConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}