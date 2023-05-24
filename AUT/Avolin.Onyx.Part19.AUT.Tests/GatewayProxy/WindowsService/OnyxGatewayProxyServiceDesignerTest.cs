using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy.WindowsService;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy.WindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyService" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxGatewayProxyServiceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxGatewayProxyServiceNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxGatewayProxyServiceDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: OnyxGatewayProxyServiceNonPublicTypeName)
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

        private Type _onyxGatewayProxyServiceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxGatewayProxyServiceNonPublicTypeName = "Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyService";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxGatewayProxyServiceInstance;
        private object _onyxGatewayProxyServiceInstanceFixture;

        #region General Initializer : Class (OnyxGatewayProxyService) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayProxyService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayProxyServiceInstanceFixture = this.CreateNonPublicType(OnyxGatewayProxyServiceNonPublicTypeName);
            _onyxGatewayProxyServiceInstance = _onyxGatewayProxyServiceInstanceFixture;
            CurrentInstance = _onyxGatewayProxyServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyService) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayProxyService)

        #region General Initializer : Class (OnyxGatewayProxyService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxGatewayProxyService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_OnyxGatewayProxyServiceDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxGatewayProxyService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}