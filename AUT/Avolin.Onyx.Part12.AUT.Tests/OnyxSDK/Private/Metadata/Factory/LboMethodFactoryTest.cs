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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.Factory.LboMethodFactory" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata.Factory"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboMethodFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LboMethodFactoryNonPublicTypeName" />) using
        ///     Using a public type <see cref="MetadataDefinitionFactory" /> to
        ///     create a non-public type.
        /// </summary>
        public LboMethodFactoryTest() : base(publicType: typeof(MetadataDefinitionFactory), classNameWithNamespace: LboMethodFactoryNonPublicTypeName)
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

        private Type _lboMethodFactoryInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LboMethodFactoryNonPublicTypeName = "OnyxSDK.Private.Metadata.Factory.LboMethodFactory";

        #region General Initializer : Class (LboMethodFactory) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LboMethodFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboMethodFactory) Initializer

        #region Methods

        private const string MethodGetLboMethod = "GetLboMethod";
        private const string MethodCreateLboMethod = "CreateLboMethod";

        #endregion

        #region Fields

        private const string Field_onyxLock = "_onyxLock";
        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LboMethodFactory)
        
        #region General Initializer : Class (LboMethodFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboMethodFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethodFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LboMethodFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboMethodFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_onyxLock)]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_LboMethodFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LboMethodFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboMethodFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethodFactory_Explore_Reflection_Based_NonListed_Fields_Test()
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