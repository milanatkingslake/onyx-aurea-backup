using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.CustomEntity" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\CustomEntity.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomEntityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CustomEntityNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public CustomEntityTest() : base(publicType: typeof(Common), classNameWithNamespace: CustomEntityNonPublicTypeName)
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

        private Type _customEntityInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CustomEntityNonPublicTypeName = "CmService.Service.CustomEntity";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _customEntityInstance;
        private object _customEntityInstanceFixture;

        #region General Initializer : Class (CustomEntity) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CustomEntity" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customEntityInstanceFixture = this.CreateNonPublicType(CustomEntityNonPublicTypeName);
            _customEntityInstance = _customEntityInstanceFixture;
            CurrentInstance = _customEntityInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomEntity) Initializer

        #region Methods

        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetCustomEntityFieldMetaData = "GetCustomEntityFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomEntity)

        #region General Initializer : Class (CustomEntity) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomEntity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetCustomEntityFieldMetaData, 0)]
        [TestCase(MethodSave, 0)]
        [Category("AUT Explore")]
        public void AUT_CustomEntity_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomEntity) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomEntity" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomEntity_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}