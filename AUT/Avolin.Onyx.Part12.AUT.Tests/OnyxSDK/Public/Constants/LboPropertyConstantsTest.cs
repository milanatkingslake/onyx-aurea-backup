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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboPropertyConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboPropertyConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboPropertyConstants" />)
        /// </summary>
        public LboPropertyConstantsTest() : base(typeof(LboPropertyConstants))
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

        #region General Initializer : Class (LboPropertyConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboPropertyConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboPropertyConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboPropertyConstantsInstanceType = typeof(LboPropertyConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboPropertyConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldINSTALLED_BY = "INSTALLED_BY";
        private const string FieldDISABLED = "DISABLED";
        private const string FieldDATATYPE = "DATATYPE";
        private const string FieldCONTENT = "CONTENT";
        private const string FieldCOLLECTION = "COLLECTION";
        private const string FieldGENERATED_ID = "GENERATED_ID";
        private const string FieldREAD_ONLY = "READ_ONLY";
        private const string FieldOBJECT_TYPE = "OBJECT_TYPE";
        private const string FieldJOIN_RELATIONSHIP = "JOIN_RELATIONSHIP";
        private const string FieldTARGET_PROPERTY = "TARGET_PROPERTY";
        private const string FieldDENORMALIZED_DEFINITION = "DENORMALIZED_DEFINITION";
        private const string FieldPROPERTY_CONSTRAINTS = "PROPERTY_CONSTRAINTS";
        private const string FieldPROPERTY_CONSTRAINT = "PROPERTY_CONSTRAINT";
        private const string FieldPROPERTY = "PROPERTY";

        #endregion

        #endregion

        #region General Initializer : Class (LboPropertyConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboPropertyConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboPropertyConstants)

        #region General Initializer : Class (LboPropertyConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboPropertyConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldINSTALLED_BY)]
        [TestCase(FieldDISABLED)]
        [TestCase(FieldDATATYPE)]
        [TestCase(FieldCONTENT)]
        [TestCase(FieldCOLLECTION)]
        [TestCase(FieldGENERATED_ID)]
        [TestCase(FieldREAD_ONLY)]
        [TestCase(FieldOBJECT_TYPE)]
        [TestCase(FieldJOIN_RELATIONSHIP)]
        [TestCase(FieldTARGET_PROPERTY)]
        [TestCase(FieldDENORMALIZED_DEFINITION)]
        [TestCase(FieldPROPERTY_CONSTRAINTS)]
        [TestCase(FieldPROPERTY_CONSTRAINT)]
        [TestCase(FieldPROPERTY)]
        [Category("AUT Fields")]
        public void AUT_LboPropertyConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboPropertyConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboPropertyConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboPropertyConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboPropertyConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}