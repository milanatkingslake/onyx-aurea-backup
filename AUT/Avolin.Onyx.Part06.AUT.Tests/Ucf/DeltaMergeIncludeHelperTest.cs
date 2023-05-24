using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.DeltaMergeIncludeHelper" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DeltaMergeIncludeHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DeltaMergeIncludeHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public DeltaMergeIncludeHelperTest() : base(publicType: typeof(Constants), classNameWithNamespace: DeltaMergeIncludeHelperNonPublicTypeName)
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

        private Type _deltaMergeIncludeHelperInstanceType;
        
        private const string DeltaMergeIncludeHelperNonPublicTypeName = "Onyx.Ucf.DeltaMergeIncludeHelper";

        #region General Initializer : Class (DeltaMergeIncludeHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DeltaMergeIncludeHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergeIncludeHelper) Initializer

        #region Methods

        private const string MethodPatchIncludes = "PatchIncludes";
        private const string MethodGetDepthFromRoot = "GetDepthFromRoot";
        private const string MethodRunReplace = "RunReplace";
        private const string MethodManglePath = "ManglePath";
        private const string MethodReplacePath = "ReplacePath";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}