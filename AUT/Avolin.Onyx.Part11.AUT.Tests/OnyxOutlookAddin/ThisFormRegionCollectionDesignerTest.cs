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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ThisFormRegionCollection" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ThisFormRegionCollectionDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ThisFormRegionCollectionNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public ThisFormRegionCollectionDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: ThisFormRegionCollectionNonPublicTypeName)
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

        private Type _thisFormRegionCollectionInstanceType;
        
        private const string ThisFormRegionCollectionNonPublicTypeName = "OnyxOutlookAddin.ThisFormRegionCollection";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _thisFormRegionCollectionInstance;
        private object _thisFormRegionCollectionInstanceFixture;

        #region General Initializer : Class (ThisFormRegionCollection) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ThisFormRegionCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _thisFormRegionCollectionInstanceFixture = this.CreateNonPublicType(ThisFormRegionCollectionNonPublicTypeName);
            _thisFormRegionCollectionInstance = _thisFormRegionCollectionInstanceFixture;
            CurrentInstance = _thisFormRegionCollectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #endregion
    }
}