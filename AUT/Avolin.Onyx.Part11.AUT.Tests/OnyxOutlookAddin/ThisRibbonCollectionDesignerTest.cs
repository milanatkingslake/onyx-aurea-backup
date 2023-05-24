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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ThisRibbonCollection" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ThisRibbonCollectionDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ThisRibbonCollectionNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public ThisRibbonCollectionDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: ThisRibbonCollectionNonPublicTypeName)
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

        private Type _thisRibbonCollectionInstanceType;
        
        private const string ThisRibbonCollectionNonPublicTypeName = "OnyxOutlookAddin.ThisRibbonCollection";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _thisRibbonCollectionInstance;
        private object _thisRibbonCollectionInstanceFixture;

        #region General Initializer : Class (ThisRibbonCollection) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ThisRibbonCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _thisRibbonCollectionInstanceFixture = this.CreateNonPublicType(ThisRibbonCollectionNonPublicTypeName);
            _thisRibbonCollectionInstance = _thisRibbonCollectionInstanceFixture;
            CurrentInstance = _thisRibbonCollectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #endregion
    }
}