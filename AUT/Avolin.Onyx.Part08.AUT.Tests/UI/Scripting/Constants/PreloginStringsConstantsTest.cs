using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Constants;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.PreloginStringsConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PreloginStringsConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PreloginStringsConstants" />)
        /// </summary>
        public PreloginStringsConstantsTest() : base(typeof(PreloginStringsConstants))
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

        #region General Initializer : Class (PreloginStringsConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _preloginStringsConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="PreloginStringsConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _preloginStringsConstantsInstanceType = typeof(PreloginStringsConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PreloginStringsConstants) Initializer

        #region Fields

        private const string FieldRESOURCE_FILE_NAME = "RESOURCE_FILE_NAME";

        #endregion

        #endregion

        #region General Initializer : Class (PreloginStringsConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PreloginStringsConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PreloginStringsConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PreloginStringsConstants)

        #region General Initializer : Class (PreloginStringsConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PreloginStringsConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldRESOURCE_FILE_NAME)]
        [Category("AUT Fields")]
        public void AUT_PreloginStringsConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PreloginStringsConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PreloginStringsConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PreloginStringsConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _preloginStringsConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}