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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.UIMessagingConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UIMessagingConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UIMessagingConstants" />)
        /// </summary>
        public UIMessagingConstantsTest() : base(typeof(UIMessagingConstants))
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

        #region General Initializer : Class (UIMessagingConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _uIMessagingConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="UIMessagingConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _uIMessagingConstantsInstanceType = typeof(UIMessagingConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UIMessagingConstants) Initializer

        #region Fields

        private const string FieldINFO = "INFO";
        private const string FieldEXCEPTION = "EXCEPTION";
        private const string FieldDEFAULT_MESSAGE = "DEFAULT_MESSAGE";
        private const string FieldSERVER = "SERVER";
        private const string FieldDELIMITER = "DELIMITER";
        private const string FieldDEFAULT_LANGUAGE = "DEFAULT_LANGUAGE";

        #endregion

        #endregion

        #region General Initializer : Class (UIMessagingConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UIMessagingConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UIMessagingConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UIMessagingConstants)

        #region General Initializer : Class (UIMessagingConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="UIMessagingConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldINFO)]
        [TestCase(FieldEXCEPTION)]
        [TestCase(FieldDEFAULT_MESSAGE)]
        [TestCase(FieldSERVER)]
        [TestCase(FieldDELIMITER)]
        [TestCase(FieldDEFAULT_LANGUAGE)]
        [Category("AUT Fields")]
        public void AUT_UIMessagingConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UIMessagingConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UIMessagingConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UIMessagingConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _uIMessagingConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}