using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.SupportTask" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\SupportTask.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SupportTaskTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SupportTask" />)
        /// </summary>
        public SupportTaskTest() : base(typeof(SupportTask))
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

        #region General Initializer : Class (SupportTask) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _supportTaskInstanceType;
        private SupportTask _supportTaskInstance;
        private SupportTask _supportTaskInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SupportTask" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _supportTaskInstanceType = typeof(SupportTask);
            _supportTaskInstanceFixture = this.Create<SupportTask>(false);
            _supportTaskInstance = _supportTaskInstanceFixture ?? this.Create<SupportTask>(true);
            CurrentInstance = _supportTaskInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SupportTask) Initializer

        #region Properties

        private const string PropertyEntityName = "EntityName";

        #endregion

        #region Methods

        private const string MethodUpdateRecallDate = "UpdateRecallDate";
        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetTaskFieldMetaData = "GetTaskFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #region Fields

        private const string FieldentityName = "entityName";

        #endregion

        #endregion

    }
}