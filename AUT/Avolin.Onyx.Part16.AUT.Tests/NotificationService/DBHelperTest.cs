using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DBHelper" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DBHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DBHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="IPublishEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public DBHelperTest() : base(publicType: typeof(IPublishEvent), classNameWithNamespace: DBHelperNonPublicTypeName)
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

        private Type _dBHelperInstanceType;
        
        private const string DBHelperNonPublicTypeName = "NotificationService.DBHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _dBHelperInstance;
        private object _dBHelperInstanceFixture;

        #region General Initializer : Class (DBHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DBHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dBHelperInstanceFixture = this.CreateNonPublicType(DBHelperNonPublicTypeName);
            _dBHelperInstance = _dBHelperInstanceFixture;
            CurrentInstance = _dBHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #endregion
    }
}