using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.LboConfiguration" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\LboConfiguration.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LboConfigurationNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public LboConfigurationTest() : base(publicType: typeof(Common), classNameWithNamespace: LboConfigurationNonPublicTypeName)
        { }

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

        private Type _lboConfigurationInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LboConfigurationNonPublicTypeName = "CmService.Service.LboConfiguration";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _lboConfigurationInstance;
        private object _lboConfigurationInstanceFixture;

        #region General Initializer : Class (LboConfiguration) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LboConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboConfigurationInstanceFixture = this.CreateNonPublicType(LboConfigurationNonPublicTypeName);
            _lboConfigurationInstance = _lboConfigurationInstanceFixture;
            CurrentInstance = _lboConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboConfiguration) Initializer

        #region Methods

        private const string MethodGetLboMappings = "GetLboMappings";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LboConfiguration)

        #region General Initializer : Class (LboConfiguration) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetLboMappings, 0)]
        [Category("AUT Explore")]
        public void AUT_LboConfiguration_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : Message) Test Try-Catch Verify Exception Throw - Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT TryCatch")]
        public void AUT_LboConfiguration_GetLboMappings_Try_Catch_Should_Not_Throw_Exception()
        {
            // Arrange
            var methodGetLboMappingsParametersTypes = new Type[] { typeof(Message) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMappings, methodGetLboMappingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
    }
}