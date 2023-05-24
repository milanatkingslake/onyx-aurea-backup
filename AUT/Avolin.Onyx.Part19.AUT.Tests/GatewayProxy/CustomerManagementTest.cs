using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.CustomerManagement" />)
    ///     and namespace <see cref="Onyx.GatewayProxy"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CustomerManagementTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerManagement" />)
        /// </summary>
        public CustomerManagementTest() : base(typeof(CustomerManagement))
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

        #region General Initializer : Class (CustomerManagement) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerManagementInstanceType;
        private CustomerManagement _customerManagementInstance;
        private CustomerManagement _customerManagementInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerManagement" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerManagementInstanceType = typeof(CustomerManagement);
            _customerManagementInstanceFixture = this.Create<CustomerManagement>(false);
            _customerManagementInstance = _customerManagementInstanceFixture ?? this.Create<CustomerManagement>(true);
            CurrentInstance = _customerManagementInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomerManagement) Initializer

        #region Methods

        private const string MethodSearch = "Search";
        private const string MethodUpdate = "Update";
        private const string MethodAddLink = "AddLink";
        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetWorkTicketFieldMetaData = "GetWorkTicketFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (Update) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerManagement_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (AddLink) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerManagement_AddLink_Method_Call_Internally(Type[] types)
        {
            var methodAddLinkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddLink, methodAddLinkParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerManagement_GetDetailsViewById_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailsViewByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkTicketFieldMetaData) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerManagement_GetWorkTicketFieldMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkTicketFieldMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkTicketFieldMetaData, methodGetWorkTicketFieldMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerManagement_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}