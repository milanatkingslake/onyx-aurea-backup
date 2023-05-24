using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.KeyHelper" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class KeyHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="KeyHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="AccessPrivilege" /> to
        ///     create a non-public type.
        /// </summary>
        public KeyHelperTest() : base(publicType: typeof(AccessPrivilege), classNameWithNamespace: KeyHelperNonPublicTypeName)
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

        private Type _keyHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string KeyHelperNonPublicTypeName = "Onyx.UI.Navigator.Model.KeyHelper";

        #region General Initializer : Class (KeyHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="KeyHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (KeyHelper) Initializer

        #region Methods

        private const string MethodIsValidKeyAtPos = "IsValidKeyAtPos";
        private const string MethodGetTypeInput = "GetTypeInput";
        private const string MethodIsCustomKey = "IsCustomKey";
        private const string MethodIsNumberKey = "IsNumberKey";
        private const string MethodIsLetterSpaceKey = "IsLetterSpaceKey";
        private const string MethodIsLetterKey = "IsLetterKey";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (KeyHelper)

        #region General Initializer : Class (KeyHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="KeyHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIsValidKeyAtPos, 0)]
        [TestCase(MethodGetTypeInput, 0)]
        [TestCase(MethodIsCustomKey, 0)]
        [TestCase(MethodIsNumberKey, 0)]
        [TestCase(MethodIsLetterSpaceKey, 0)]
        [TestCase(MethodIsLetterKey, 0)]
        [Category("AUT Explore")]
        public void AUT_KeyHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (KeyHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="KeyHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_KeyHelper_Explore_Reflection_Based_NonListed_Methods_Test()
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