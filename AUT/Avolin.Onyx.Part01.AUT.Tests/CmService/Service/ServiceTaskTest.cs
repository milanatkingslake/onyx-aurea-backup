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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.ServiceTask" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ServiceTask.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceTaskTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ServiceTaskNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public ServiceTaskTest() : base(publicType: typeof(Common), classNameWithNamespace: ServiceTaskNonPublicTypeName)
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

        private Type _serviceTaskInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ServiceTaskNonPublicTypeName = "CmService.Service.ServiceTask";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _serviceTaskInstance;
        private object _serviceTaskInstanceFixture;

        #region General Initializer : Class (ServiceTask) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ServiceTask" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceTaskInstanceFixture = this.CreateNonPublicType(ServiceTaskNonPublicTypeName);
            _serviceTaskInstance = _serviceTaskInstanceFixture;
            CurrentInstance = _serviceTaskInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceTask) Initializer

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