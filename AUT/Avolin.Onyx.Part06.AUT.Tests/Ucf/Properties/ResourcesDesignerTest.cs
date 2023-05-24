using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Onyx.Ucf.Properties;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf.Properties
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.Properties.Resources" />)
    ///     and namespace <see cref="Onyx.Ucf.Properties"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResourcesDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ResourcesNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public ResourcesDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: ResourcesNonPublicTypeName)
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

        private Type _resourcesInstanceType;
        
        private const string ResourcesNonPublicTypeName = "Onyx.Ucf.Properties.Resources";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _resourcesInstance;
        private object _resourcesInstanceFixture;

        #region General Initializer : Class (Resources) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Resources" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resourcesInstanceFixture = this.CreateNonPublicType(ResourcesNonPublicTypeName);
            _resourcesInstance = _resourcesInstanceFixture;
            CurrentInstance = _resourcesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Resources) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}