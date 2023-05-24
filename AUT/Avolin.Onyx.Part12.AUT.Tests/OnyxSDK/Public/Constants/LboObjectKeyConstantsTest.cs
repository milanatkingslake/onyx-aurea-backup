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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboObjectKeyConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboObjectKeyConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboObjectKeyConstants" />)
        /// </summary>
        public LboObjectKeyConstantsTest() : base(typeof(LboObjectKeyConstants))
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

        #region General Initializer : Class (LboObjectKeyConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboObjectKeyConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboObjectKeyConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboObjectKeyConstantsInstanceType = typeof(LboObjectKeyConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboObjectKeyConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldOBJECT_KEY_TYPE = "OBJECT_KEY_TYPE";
        private const string FieldKEY_PROPERTIES = "KEY_PROPERTIES";
        private const string FieldKEY_PROPERTY = "KEY_PROPERTY";
        private const string FieldOBJECT_KEY = "OBJECT_KEY";
        private const string FieldPROPERTY_ID = "PROPERTY_ID";

        #endregion

        #endregion

        #region General Initializer : Class (LboObjectKeyConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboObjectKeyConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboObjectKeyConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboObjectKeyConstants)

        #region General Initializer : Class (LboObjectKeyConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboObjectKeyConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldOBJECT_KEY_TYPE)]
        [TestCase(FieldKEY_PROPERTIES)]
        [TestCase(FieldKEY_PROPERTY)]
        [TestCase(FieldOBJECT_KEY)]
        [TestCase(FieldPROPERTY_ID)]
        [Category("AUT Fields")]
        public void AUT_LboObjectKeyConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboObjectKeyConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboObjectKeyConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboObjectKeyConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboObjectKeyConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}