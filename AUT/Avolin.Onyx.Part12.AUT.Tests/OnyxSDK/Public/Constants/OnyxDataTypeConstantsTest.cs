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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.OnyxDataTypeConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxDataTypeConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxDataTypeConstants" />)
        /// </summary>
        public OnyxDataTypeConstantsTest() : base(typeof(OnyxDataTypeConstants))
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

        #region General Initializer : Class (OnyxDataTypeConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxDataTypeConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxDataTypeConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxDataTypeConstantsInstanceType = typeof(OnyxDataTypeConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxDataTypeConstants) Initializer

        #region Fields

        private const string FieldTYPE_STRING = "TYPE_STRING";
        private const string FieldTYPE_I4 = "TYPE_I4";
        private const string FieldTYPE_DATE_TIME = "TYPE_DATE_TIME";
        private const string FieldTYPE_BOOLEAN = "TYPE_BOOLEAN";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxDataTypeConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxDataTypeConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDataTypeConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxDataTypeConstants)

        #region General Initializer : Class (OnyxDataTypeConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxDataTypeConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldTYPE_STRING)]
        [TestCase(FieldTYPE_I4)]
        [TestCase(FieldTYPE_DATE_TIME)]
        [TestCase(FieldTYPE_BOOLEAN)]
        [Category("AUT Fields")]
        public void AUT_OnyxDataTypeConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxDataTypeConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxDataTypeConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDataTypeConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxDataTypeConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}