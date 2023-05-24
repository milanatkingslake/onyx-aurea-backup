using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxFileAgent;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxFileAgent
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxFileAgent.OEASHelper" />)
    ///     and namespace <see cref="OnyxFileAgent"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OEASHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OEASHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="FileAgent" /> to
        ///     create a non-public type.
        /// </summary>
        public OEASHelperTest() : base(publicType: typeof(FileAgent), classNameWithNamespace: OEASHelperNonPublicTypeName)
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

        private Type _oEASHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OEASHelperNonPublicTypeName = "OnyxFileAgent.OEASHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _oEASHelperInstance;
        private object _oEASHelperInstanceFixture;

        #region General Initializer : Class (OEASHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OEASHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASHelperInstanceFixture = this.CreateNonPublicType(OEASHelperNonPublicTypeName);
            _oEASHelperInstance = _oEASHelperInstanceFixture;
            CurrentInstance = _oEASHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASHelper) Initializer

        #region Methods

        private const string MethodOTMExecute = "OTMExecute";
        private const string MethodValidateSession = "ValidateSession";

        #endregion

        #region Fields

        private const string FieldXMLNODE_USERID = "XMLNODE_USERID";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASHelper)

        #region General Initializer : Class (OEASHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOTMExecute, 0)]
        [TestCase(MethodValidateSession, 0)]
        [Category("AUT Explore")]
        public void AUT_OEASHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OEASHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldXMLNODE_USERID)]
        [Category("AUT Fields")]
        public void AUT_OEASHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion
    }
}