using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OEASConfig;

namespace Avolin.Onyx.Part17.AUT.Tests.OEASConfig
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OEASConfig.IList<IGenericArgumentSample, IGenericArgumentSample>" />)
    ///     and namespace <see cref="OEASConfig"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IListTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="IListNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public IListTest() : base(publicType: typeof(Common), classNameWithNamespace: IListNonPublicTypeName)
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

        private Type _iListInstanceType;
        
        private const string IListNonPublicTypeName = "OEASConfig.IList";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _iListInstance;
        private object _iListInstanceFixture;

        #region General Initializer : Class (IList) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="IList<IGenericArgumentSample, IGenericArgumentSample>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _iListInstanceFixture = this.CreateNonPublicType(IListNonPublicTypeName);
            _iListInstance = _iListInstanceFixture;
            CurrentInstance = _iListInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #endregion
    }
}