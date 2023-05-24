using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Private.Metadata.Factory;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata.Factory
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.Factory.LboMethodSortPropertyFactory" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata.Factory"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboMethodSortPropertyFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LboMethodSortPropertyFactoryNonPublicTypeName" />) using
        ///     Using a public type <see cref="MetadataDefinitionFactory" /> to
        ///     create a non-public type.
        /// </summary>
        public LboMethodSortPropertyFactoryTest() : base(publicType: typeof(MetadataDefinitionFactory), classNameWithNamespace: LboMethodSortPropertyFactoryNonPublicTypeName)
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

        private Type _lboMethodSortPropertyFactoryInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LboMethodSortPropertyFactoryNonPublicTypeName = "OnyxSDK.Private.Metadata.Factory.LboMethodSortPropertyFactory";

        #region General Initializer : Class (LboMethodSortPropertyFactory) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LboMethodSortPropertyFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboMethodSortPropertyFactory) Initializer

        #region Methods

        private const string MethodGetLboMethodSortProperty = "GetLboMethodSortProperty";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LboMethodSortPropertyFactory)

        #region General Initializer : Class (LboMethodSortPropertyFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboMethodSortPropertyFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetLboMethodSortProperty, 0)]
        [Category("AUT Explore")]
        public void AUT_LboMethodSortPropertyFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboMethodSortPropertyFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboMethodSortPropertyFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethodSortPropertyFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LboMethodSortPropertyFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboMethodSortPropertyFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_LboMethodSortPropertyFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LboMethodSortPropertyFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboMethodSortPropertyFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethodSortPropertyFactory_Explore_Reflection_Based_NonListed_Fields_Test()
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