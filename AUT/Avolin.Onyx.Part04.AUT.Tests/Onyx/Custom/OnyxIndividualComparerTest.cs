using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxIndividualComparer" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxIndividualComparerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxIndividualComparerNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxIndividualComparerTest() : base(publicType: typeof(Common), classNameWithNamespace: OnyxIndividualComparerNonPublicTypeName)
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

        private Type _onyxIndividualComparerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxIndividualComparerNonPublicTypeName = "Onyx.Custom.OnyxIndividualComparer";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxIndividualComparerInstance;
        private object _onyxIndividualComparerInstanceFixture;

        #region General Initializer : Class (OnyxIndividualComparer) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxIndividualComparer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxIndividualComparerInstanceFixture = this.CreateNonPublicType(OnyxIndividualComparerNonPublicTypeName);
            _onyxIndividualComparerInstance = _onyxIndividualComparerInstanceFixture;
            CurrentInstance = _onyxIndividualComparerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxIndividualComparer) Initializer

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxIndividualComparer)

        #region General Initializer : Class (OnyxIndividualComparer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxIndividualComparer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        [Category("AUT Explore")]
        public void AUT_OnyxIndividualComparer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxIndividualComparer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxIndividualComparer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIndividualComparer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}