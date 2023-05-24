using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using ServiceBroker.Host;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.ServiceBroker.Host
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ServiceBroker.Host.DbSynchronizerService" />)
    ///     and namespace <see cref="ServiceBroker.Host"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DbSynchronizerServiceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DbSynchronizerServiceNonPublicTypeName" />) using
        ///     Using a public type <see cref="DbSynchronizerService" /> to
        ///     create a non-public type.
        /// </summary>
        public DbSynchronizerServiceDesignerTest() : base(publicType: typeof(DbSynchronizerService), classNameWithNamespace: DbSynchronizerServiceNonPublicTypeName)
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

        private Type _dbSynchronizerServiceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string DbSynchronizerServiceNonPublicTypeName = "ServiceBroker.Host.DbSynchronizerService";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _dbSynchronizerServiceInstance;
        private object _dbSynchronizerServiceInstanceFixture;

        #region General Initializer : Class (DbSynchronizerService) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DbSynchronizerService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dbSynchronizerServiceInstanceFixture = this.CreateNonPublicType(DbSynchronizerServiceNonPublicTypeName);
            _dbSynchronizerServiceInstance = _dbSynchronizerServiceInstanceFixture;
            CurrentInstance = _dbSynchronizerServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DbSynchronizerService) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (DbSynchronizerService)

        #region General Initializer : Class (DbSynchronizerService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DbSynchronizerService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DbSynchronizerServiceDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DbSynchronizerService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DbSynchronizerService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_DbSynchronizerServiceDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DbSynchronizerService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DbSynchronizerService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DbSynchronizerServiceDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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