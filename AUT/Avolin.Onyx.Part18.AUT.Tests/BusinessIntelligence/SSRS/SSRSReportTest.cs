using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using BusinessIntelligence.SSRS;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.BusinessIntelligence.SSRS
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="BusinessIntelligence.SSRS.SSRSReport" />)
    ///     and namespace <see cref="BusinessIntelligence.SSRS"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SSRSReportTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SSRSReport" />)
        /// </summary>
        public SSRSReportTest() : base(typeof(SSRSReport))
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

        #region General Initializer : Class (SSRSReport) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _sSRSReportInstanceType;
        private SSRSReport _sSRSReportInstance;
        private SSRSReport _sSRSReportInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SSRSReport" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sSRSReportInstanceType = typeof(SSRSReport);
            _sSRSReportInstanceFixture = this.Create<SSRSReport>(false);
            _sSRSReportInstance = _sSRSReportInstanceFixture ?? this.Create<SSRSReport>(true);
            CurrentInstance = _sSRSReportInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SSRSReport) Initializer

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodRetrieveReportData = "RetrieveReportData";
        private const string MethodCreateReportXml = "CreateReportXml";
        private const string MethodSetError = "SetError";
        private const string MethodAddNode = "AddNode";
        private const string MethodMapReportTypeString = "MapReportTypeString";
        private const string MethodRetrieveNatLangString = "RetrieveNatLangString";

        #endregion

        #region Fields

        private const string FieldE_INVALID_URL = "E_INVALID_URL";
        private const string FieldE_INVALID_FOLDER_NAME = "E_INVALID_FOLDER_NAME";
        private const string Fieldm_stepPackageXml = "m_stepPackageXml";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (SSRSReport)

        #region General Initializer : Class (SSRSReport) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SSRSReport" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodRetrieveReportData, 0)]
        [TestCase(MethodCreateReportXml, 0)]
        [TestCase(MethodSetError, 0)]
        [TestCase(MethodAddNode, 0)]
        [TestCase(MethodMapReportTypeString, 0)]
        [TestCase(MethodRetrieveNatLangString, 0)]
        public void AUT_SSRSReport_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SSRSReport) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SSRSReport" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldE_INVALID_URL)]
        [TestCase(FieldE_INVALID_FOLDER_NAME)]
        [TestCase(Fieldm_stepPackageXml)]
        [Category("AUT Fields")]
        public void AUT_SSRSReport_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RetrieveReportData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_RetrieveReportData_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveReportDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveReportData, methodRetrieveReportDataParametersTypes);
        }

        #endregion

        #region Method Call : (CreateReportXml) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_CreateReportXml_Method_Call_Internally(Type[] types)
        {
            var methodCreateReportXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateReportXml, methodCreateReportXmlParametersTypes);
        }

        #endregion

        #region Method Call : (SetError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_SetError_Method_Call_Internally(Type[] types)
        {
            var methodSetErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetError, methodSetErrorParametersTypes);
        }

        #endregion

        #region Method Call : (AddNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_AddNode_Method_Call_Internally(Type[] types)
        {
            var methodAddNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddNode, methodAddNodeParametersTypes);
        }

        #endregion

        #region Method Call : (MapReportTypeString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_MapReportTypeString_Method_Call_Internally(Type[] types)
        {
            var methodMapReportTypeStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMapReportTypeString, methodMapReportTypeStringParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SSRSReport_RetrieveNatLangString_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveNatLangStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}