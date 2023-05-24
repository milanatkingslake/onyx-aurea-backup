using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Script" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Script.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Script" />)
        /// </summary>
        public ScriptTest() : base(typeof(Script))
        { }

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

        #region General Initializer : Class (Script) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptInstanceType;
        private Script _scriptInstance;
        private Script _scriptInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Script" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptInstanceType = typeof(Script);
            _scriptInstanceFixture = this.Create<Script>(false);
            _scriptInstance = _scriptInstanceFixture ?? this.Create<Script>(true);
            CurrentInstance = _scriptInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Script) Initializer

        #region Properties

        private const string PropertyEntityName = "EntityName";

        #endregion

        #region Fields

        private const string FieldentityName = "entityName";

        #endregion

        #endregion

    }
}