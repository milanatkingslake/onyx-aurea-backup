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
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.CustomerManagementExtended" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\CMService\CustomerManagementExtended.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomerManagementExtendedTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerManagementExtended" />)
        /// </summary>
        public CustomerManagementExtendedTest() : base(typeof(CustomerManagementExtended))
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

        #region General Initializer : Class (CustomerManagementExtended) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerManagementExtendedInstanceType;
        private CustomerManagementExtended _customerManagementExtendedInstance;
        private CustomerManagementExtended _customerManagementExtendedInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerManagementExtended" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerManagementExtendedInstanceType = typeof(CustomerManagementExtended);
            _customerManagementExtendedInstanceFixture = this.Create<CustomerManagementExtended>(false);
            _customerManagementExtendedInstance = _customerManagementExtendedInstanceFixture ?? this.Create<CustomerManagementExtended>(true);
            CurrentInstance = _customerManagementExtendedInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

    }
}