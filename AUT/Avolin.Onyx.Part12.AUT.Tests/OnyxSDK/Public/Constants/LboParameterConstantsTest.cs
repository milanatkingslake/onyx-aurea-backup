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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboParameterConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboParameterConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboParameterConstants" />)
        /// </summary>
        public LboParameterConstantsTest() : base(typeof(LboParameterConstants))
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

        #region General Initializer : Class (LboParameterConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboParameterConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboParameterConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboParameterConstantsInstanceType = typeof(LboParameterConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboParameterConstants) Initializer

        #region Fields

        private const string FieldOBJECT_TYPE = "OBJECT_TYPE";
        private const string FieldID = "ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldCOLLECTION = "COLLECTION";
        private const string FieldDATA_TYPE = "DATA_TYPE";
        private const string FieldDEFAULT = "DEFAULT";
        private const string FieldDIRECTION = "DIRECTION";
        private const string FieldDISABLED = "DISABLED";
        private const string FieldINSTALLED_BY = "INSTALLED_BY";
        private const string FieldCONTENT_IN = "CONTENT_IN";
        private const string FieldCONTENT_OUT = "CONTENT_OUT";
        private const string FieldCONTENT_TYPE = "CONTENT_TYPE";
        private const string FieldPROPERTIES = "PROPERTIES";
        private const string FieldPROPERTY = "PROPERTY";
        private const string FieldPARAMETER = "PARAMETER";
        private const string FieldCOLUMN_NAME = "COLUMN_NAME";

        #endregion

        #endregion

        #region General Initializer : Class (LboParameterConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboParameterConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboParameterConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboParameterConstants)

        #region General Initializer : Class (LboParameterConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboParameterConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldOBJECT_TYPE)]
        [TestCase(FieldID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldCOLLECTION)]
        [TestCase(FieldDATA_TYPE)]
        [TestCase(FieldDEFAULT)]
        [TestCase(FieldDIRECTION)]
        [TestCase(FieldDISABLED)]
        [TestCase(FieldINSTALLED_BY)]
        [TestCase(FieldCONTENT_IN)]
        [TestCase(FieldCONTENT_OUT)]
        [TestCase(FieldCONTENT_TYPE)]
        [TestCase(FieldPROPERTIES)]
        [TestCase(FieldPROPERTY)]
        [TestCase(FieldPARAMETER)]
        [TestCase(FieldCOLUMN_NAME)]
        [Category("AUT Fields")]
        public void AUT_LboParameterConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboParameterConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboParameterConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboParameterConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboParameterConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}