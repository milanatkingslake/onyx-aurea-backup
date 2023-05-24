using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.SalesTask" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\SalesTask.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SalesTaskTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="SalesTaskNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public SalesTaskTest() : base(publicType: typeof(Common), classNameWithNamespace: SalesTaskNonPublicTypeName)
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

        private Type _salesTaskInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string SalesTaskNonPublicTypeName = "CmService.Service.SalesTask";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _salesTaskInstance;
        private object _salesTaskInstanceFixture;

        #region General Initializer : Class (SalesTask) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="SalesTask" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _salesTaskInstanceFixture = this.CreateNonPublicType(SalesTaskNonPublicTypeName);
            _salesTaskInstance = _salesTaskInstanceFixture;
            CurrentInstance = _salesTaskInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SalesTask) Initializer

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