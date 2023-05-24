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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Incident" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Incident.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IncidentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="IncidentNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public IncidentTest() : base(publicType: typeof(Common), classNameWithNamespace: IncidentNonPublicTypeName)
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

        private Type _incidentInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string IncidentNonPublicTypeName = "CmService.Service.Incident";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _incidentInstance;
        private object _incidentInstanceFixture;

        #region General Initializer : Class (Incident) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Incident" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentInstanceFixture = this.CreateNonPublicType(IncidentNonPublicTypeName);
            _incidentInstance = _incidentInstanceFixture;
            CurrentInstance = _incidentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Incident) Initializer

        #region Methods

        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetIncidentFieldMetaData = "GetIncidentFieldMetaData";
        private const string MethodGetRetrieveByTrackingCode = "GetRetrieveByTrackingCode";
        private const string MethodGetIncidentProductDetailsById = "GetIncidentProductDetailsById";
        private const string MethodSave = "Save";
        private const string MethodRecentIncidents = "RecentIncidents";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Incident)

        #region General Initializer : Class (Incident) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetIncidentFieldMetaData, 0)]
        [TestCase(MethodGetRetrieveByTrackingCode, 0)]
        [TestCase(MethodGetIncidentProductDetailsById, 0)]
        [TestCase(MethodSave, 0)]
        [TestCase(MethodRecentIncidents, 0)]
        [Category("AUT Explore")]
        public void AUT_Incident_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Incident) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Incident_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}