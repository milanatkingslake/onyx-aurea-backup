using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.WindowFormRegionCollection" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class WindowFormRegionCollectionDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="WindowFormRegionCollectionNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public WindowFormRegionCollectionDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: WindowFormRegionCollectionNonPublicTypeName)
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

        private Type _windowFormRegionCollectionInstanceType;
        
        private const string WindowFormRegionCollectionNonPublicTypeName = "OnyxOutlookAddin.WindowFormRegionCollection";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _windowFormRegionCollectionInstance;
        private object _windowFormRegionCollectionInstanceFixture;

        #region General Initializer : Class (WindowFormRegionCollection) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="WindowFormRegionCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _windowFormRegionCollectionInstanceFixture = this.CreateNonPublicType(WindowFormRegionCollectionNonPublicTypeName);
            _windowFormRegionCollectionInstance = _windowFormRegionCollectionInstanceFixture;
            CurrentInstance = _windowFormRegionCollectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #endregion
    }
}