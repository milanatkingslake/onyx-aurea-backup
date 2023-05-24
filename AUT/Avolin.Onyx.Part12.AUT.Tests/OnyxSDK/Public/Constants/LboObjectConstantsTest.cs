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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.LboObjectConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboObjectConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboObjectConstants" />)
        /// </summary>
        public LboObjectConstantsTest() : base(typeof(LboObjectConstants))
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

        #region General Initializer : Class (LboObjectConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboObjectConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LboObjectConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboObjectConstantsInstanceType = typeof(LboObjectConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboObjectConstants) Initializer

        #region Fields

        private const string FieldID = "ID";
        private const string FieldVALID = "VALID";
        private const string FieldNAME = "NAME";
        private const string FieldDESCRIPTION = "DESCRIPTION";
        private const string FieldRELEASED = "RELEASED";
        private const string FieldSYSTEM = "SYSTEM";
        private const string FieldINSTALLED_BY = "INSTALLED_BY";
        private const string FieldVERSION = "VERSION";
        private const string FieldDISABLED = "DISABLED";
        private const string FieldOBJECT_TYPE = "OBJECT_TYPE";
        private const string FieldDOMAIN_OBJECT = "DOMAIN_OBJECT";
        private const string FieldPARTNER_OBJECT = "PARTNER_OBJECT";
        private const string FieldCUSTOM_VERSION = "CUSTOM_VERSION";
        private const string FieldAPPLY_PARTNER_SECURITY = "APPLY_PARTNER_SECURITY";
        private const string FieldMETHODS = "METHODS";
        private const string FieldMETHOD = "METHOD";
        private const string FieldPROPERTIES = "PROPERTIES";
        private const string FieldPROPERTY = "PROPERTY";
        private const string FieldOBJECT_KEY = "OBJECT_KEY";
        private const string FieldOBJECT_KEYS = "OBJECT_KEYS";
        private const string FieldRELATIONSHIPS = "RELATIONSHIPS";
        private const string FieldRELATIONSHIP = "RELATIONSHIP";
        private const string FieldBUSINESSOBJECT = "BUSINESSOBJECT";

        #endregion

        #endregion

        #region General Initializer : Class (LboObjectConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboObjectConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboObjectConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboObjectConstants)

        #region General Initializer : Class (LboObjectConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboObjectConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldID)]
        [TestCase(FieldVALID)]
        [TestCase(FieldNAME)]
        [TestCase(FieldDESCRIPTION)]
        [TestCase(FieldRELEASED)]
        [TestCase(FieldSYSTEM)]
        [TestCase(FieldINSTALLED_BY)]
        [TestCase(FieldVERSION)]
        [TestCase(FieldDISABLED)]
        [TestCase(FieldOBJECT_TYPE)]
        [TestCase(FieldDOMAIN_OBJECT)]
        [TestCase(FieldPARTNER_OBJECT)]
        [TestCase(FieldCUSTOM_VERSION)]
        [TestCase(FieldAPPLY_PARTNER_SECURITY)]
        [TestCase(FieldMETHODS)]
        [TestCase(FieldMETHOD)]
        [TestCase(FieldPROPERTIES)]
        [TestCase(FieldPROPERTY)]
        [TestCase(FieldOBJECT_KEY)]
        [TestCase(FieldOBJECT_KEYS)]
        [TestCase(FieldRELATIONSHIPS)]
        [TestCase(FieldRELATIONSHIP)]
        [TestCase(FieldBUSINESSOBJECT)]
        [Category("AUT Fields")]
        public void AUT_LboObjectConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboObjectConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboObjectConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboObjectConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _lboObjectConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}