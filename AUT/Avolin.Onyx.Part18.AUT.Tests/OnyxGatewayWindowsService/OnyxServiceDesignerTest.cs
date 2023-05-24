using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxGatewayWindowsService;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxGatewayWindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxGatewayWindowsService.OnyxService" />)
    ///     and namespace <see cref="OnyxGatewayWindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxServiceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxServiceNonPublicTypeName" />) using
        ///     Using a public type <see cref="OnyxService" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxServiceDesignerTest() : base(publicType: typeof(OnyxService), classNameWithNamespace: OnyxServiceNonPublicTypeName)
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

        private Type _onyxServiceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxServiceNonPublicTypeName = "OnyxGatewayWindowsService.OnyxService";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxServiceInstance;
        private object _onyxServiceInstanceFixture;

        #region General Initializer : Class (OnyxService) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxServiceInstanceFixture = this.CreateNonPublicType(OnyxServiceNonPublicTypeName);
            _onyxServiceInstance = _onyxServiceInstanceFixture;
            CurrentInstance = _onyxServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxService) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxService)

        #region General Initializer : Class (OnyxService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_OnyxServiceDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_OnyxServiceDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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